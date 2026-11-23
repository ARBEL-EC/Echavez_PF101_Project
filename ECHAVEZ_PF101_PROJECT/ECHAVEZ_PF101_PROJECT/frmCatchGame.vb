Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmCatchGame
    Private Const StartingLives As Integer = 3
    Private Const PlayerMoveSpeed As Integer = 8
    Private Const FoodScore As Integer = 10

    Private ReadOnly _fallingItems As New List(Of FallingItem)()
    Private ReadOnly _pressedKeys As New HashSet(Of Keys)()
    Private ReadOnly _random As New Random()
    Private _score As Integer
    Private _lives As Integer = StartingLives
    Private _spawnElapsed As Integer
    Private Enum RoundState
        Ready
        Running
        Paused
        Finished
    End Enum

    Private ReadOnly _activeTime As New Stopwatch()
    Private ReadOnly _difficultyPicker As New ComboBox With {.DropDownStyle = ComboBoxStyle.DropDownList, .Width = 96,
                                                             .AccessibleName = "Difficulty"}
    Private ReadOnly _playerName As New TextBox With {.Text = "Player", .MaxLength = CatchGameLeaderboard.MaximumNameLength,
                                                      .Width = 112, .AccessibleName = "Player name"}
    Private ReadOnly _pauseButton As New Button With {.Text = "Pause", .AutoSize = True, .Height = 36}
    Private ReadOnly _topTenButton As New Button With {.Text = "Top 10", .AutoSize = True, .Height = 36}
    Private ReadOnly _leaderboard As New CatchGameLeaderboard(CatchGameLeaderboard.DefaultDatabasePath)
    Private _state As RoundState
    Private _difficulty As CatchGameDifficulty
    Private _roundPlayer As String
    Private _level As Integer = 1
    Private _playerSprite As Image
    Private _playerSpriteStream As IO.Stream
    Private _imgFood As Image
    Private _imgHazard As Image

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub frmCatchGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpRoundControls()
        ThemeManager.ApplyTheme(Me)
        ThemeManager.SetButtonKind(btnRestart, ThemeManager.ButtonKind.Secondary)
        ThemeManager.SetButtonKind(_pauseButton, ThemeManager.ButtonKind.Secondary)
        ThemeManager.SetButtonKind(_topTenButton, ThemeManager.ButtonKind.Secondary)
        SetRoundState(RoundState.Ready)
        picPlayer.SizeMode = PictureBoxSizeMode.Zoom
        picPlayer.BackColor = Color.Transparent
        LoadPlayerSpriteFromAssets()

        Dim doubleBufferedProperty = GetType(Control).GetProperty(
            "DoubleBuffered",
            Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If doubleBufferedProperty Is Nothing Then
            Throw New InvalidOperationException("The playfield could not enable double buffering.")
        End If
        doubleBufferedProperty.SetValue(pnlPlayfield, True, Nothing)

        pnlHud.BackColor = Color.FromArgb(26, 30, 38)
        pnlPlayfield.BackColor = Color.FromArgb(37, 43, 56)
        lblGameMessage.BackColor = pnlPlayfield.BackColor
        lblGameMessage.ForeColor = Color.FromArgb(248, 250, 252)
        lblScore.ForeColor = Color.FromArgb(248, 250, 252)
        lblLives.ForeColor = Color.FromArgb(248, 250, 252)
        lblHint.ForeColor = Color.FromArgb(148, 163, 184)

        LoadItemSprites()
        PositionPlayer()
        EnsurePlayerVisible()
        UpdateHud()
        CenterGameMessage()
    End Sub

    Private Sub LoadPlayerSpriteFromAssets()
        Dim assetsDir As String = IO.Path.Combine(Application.StartupPath, "Assets")
        Dim possibleNames As String() = {"player.png", "player.gif", "basketball.png", "pou.png"}
        Dim playerPath As String = String.Empty

        For Each imageName As String In possibleNames
            Dim testPath As String = IO.Path.Combine(assetsDir, imageName)
            If IO.File.Exists(testPath) Then
                playerPath = testPath
                Exit For
            End If
        Next

        If playerPath.Length = 0 Then
            SetPlayerFallback()
            Return
        End If

        Dim loadedImage As Image
        Try
            Using imageStream As IO.FileStream = IO.File.OpenRead(playerPath)
                Using sourceImage As Image = Image.FromStream(imageStream, True, True)
                    loadedImage = New Bitmap(sourceImage)
                End Using
            End Using
        Catch ex As IO.IOException
            ShowPlayerSpriteLoadError(playerPath, ex.Message)
            SetPlayerFallback()
            Return
        Catch ex As UnauthorizedAccessException
            ShowPlayerSpriteLoadError(playerPath, ex.Message)
            SetPlayerFallback()
            Return
        Catch ex As ArgumentException
            ShowPlayerSpriteLoadError(playerPath, ex.Message)
            SetPlayerFallback()
            Return
        Catch ex As System.Runtime.InteropServices.ExternalException
            ShowPlayerSpriteLoadError(playerPath, ex.Message)
            SetPlayerFallback()
            Return
        Catch ex As System.Security.SecurityException
            ShowPlayerSpriteLoadError(playerPath, ex.Message)
            SetPlayerFallback()
            Return
        Catch ex As OutOfMemoryException
            ShowPlayerSpriteLoadError(playerPath, "The image is invalid or could not be decoded.")
            SetPlayerFallback()
            Return
        End Try

        Dim oldImage As Image = _playerSprite
        Dim oldStream As IO.Stream = _playerSpriteStream
        picPlayer.Image = loadedImage
        _playerSprite = loadedImage
        _playerSpriteStream = Nothing
        picPlayer.SizeMode = PictureBoxSizeMode.Zoom
        picPlayer.BackColor = Color.Transparent

        If oldImage IsNot Nothing Then oldImage.Dispose()
        If oldStream IsNot Nothing Then oldStream.Dispose()
    End Sub

    Private Sub SetPlayerFallback()
        picPlayer.Image = Nothing
        picPlayer.BackColor = Color.DodgerBlue
        If _playerSprite IsNot Nothing Then
            _playerSprite.Dispose()
            _playerSprite = Nothing
        End If
        If _playerSpriteStream IsNot Nothing Then
            _playerSpriteStream.Dispose()
            _playerSpriteStream = Nothing
        End If
    End Sub

    Private Sub EnsurePlayerVisible()
        If Not pnlPlayfield.Controls.Contains(picPlayer) Then
            pnlPlayfield.Controls.Add(picPlayer)
        End If
        picPlayer.Visible = True
        picPlayer.BringToFront()
    End Sub

    Private Sub ShowPlayerSpriteLoadError(playerPath As String, message As String)
        MessageBox.Show(Me,
                        "The player sprite could not be loaded from:" & vbCrLf &
                        playerPath & vbCrLf & vbCrLf & message,
                        "Catch Game Sprite Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
    End Sub

    Private Sub LoadItemSprites()
        Dim loadErrors As New List(Of String)()
        Dim assetsPath As String = IO.Path.Combine(Application.StartupPath, "Assets")
        Dim foodPath As String = IO.Path.Combine(assetsPath, "food.png")
        Dim hazardPath As String = IO.Path.Combine(assetsPath, "hazard.png")
        Dim bombPath As String = IO.Path.Combine(assetsPath, "Bomb.png")

        _imgFood = LoadItemSprite(foodPath, loadErrors)

        Dim hazardErrors As New List(Of String)()
        _imgHazard = LoadItemSprite(hazardPath, hazardErrors)
        If _imgHazard Is Nothing Then _imgHazard = LoadItemSprite(bombPath, hazardErrors)
        If _imgHazard Is Nothing Then loadErrors.AddRange(hazardErrors)

        If loadErrors.Count > 0 Then
            MessageBox.Show(Me,
                            "One or more item sprites could not be loaded. Colored fallback items will be used instead." &
                            vbCrLf & vbCrLf & String.Join(vbCrLf, loadErrors.ToArray()),
                            "Catch Game Sprite Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function LoadItemSprite(imgPath As String, loadErrors As List(Of String)) As Image
        Try
            Using imageStream As IO.FileStream = IO.File.OpenRead(imgPath)
                Using sourceImage As Image = Image.FromStream(imageStream, True, True)
                    Return New Bitmap(sourceImage)
                End Using
            End Using
        Catch ex As IO.IOException
            loadErrors.Add(imgPath & ": " & ex.Message)
        Catch ex As UnauthorizedAccessException
            loadErrors.Add(imgPath & ": " & ex.Message)
        Catch ex As ArgumentException
            loadErrors.Add(imgPath & ": " & ex.Message)
        Catch ex As System.Runtime.InteropServices.ExternalException
            loadErrors.Add(imgPath & ": " & ex.Message)
        Catch ex As System.Security.SecurityException
            loadErrors.Add(imgPath & ": " & ex.Message)
        Catch ex As OutOfMemoryException
            loadErrors.Add(imgPath & ": the image is invalid or could not be decoded.")
        End Try

        Return Nothing
    End Function

    Public Sub SetPlayerSprite(imgPath As String)
        If String.IsNullOrWhiteSpace(imgPath) Then
            Throw New ArgumentException("A sprite file path is required.", NameOf(imgPath))
        End If

        ' Keep the backing stream for animated images without holding the file open.
        Dim newStream As New IO.MemoryStream(IO.File.ReadAllBytes(imgPath), writable:=False)
        Dim newImage As Image
        Try
            newImage = Image.FromStream(newStream, True, True)
        Catch
            newStream.Dispose()
            Throw
        End Try

        Dim oldImage As Image = _playerSprite
        Dim oldStream As IO.Stream = _playerSpriteStream
        picPlayer.Image = newImage
        _playerSprite = newImage
        _playerSpriteStream = newStream

        If oldImage IsNot Nothing Then oldImage.Dispose()
        If oldStream IsNot Nothing Then oldStream.Dispose()
    End Sub

    Private Sub SetUpRoundControls()
        _difficultyPicker.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        _difficultyPicker.SelectedIndex = CInt(CatchGameDifficulty.Normal)
        AddHandler _pauseButton.Click, AddressOf TogglePause
        AddHandler _topTenButton.Click, AddressOf ShowLeaderboard
        AddHandler btnRestart.PreviewKeyDown, AddressOf frmCatchGame_PreviewKeyDown
        AddHandler _pauseButton.PreviewKeyDown, AddressOf frmCatchGame_PreviewKeyDown
        AddHandler _topTenButton.PreviewKeyDown, AddressOf frmCatchGame_PreviewKeyDown

        Dim actions As New FlowLayoutPanel With {.Dock = DockStyle.Top, .AutoSize = True,
                                                  .AutoSizeMode = AutoSizeMode.GrowAndShrink, .Padding = New Padding(8, 3, 8, 0)}
        actions.Controls.AddRange(New Control() {lblScore, lblLives, btnStart, btnRestart, _pauseButton, _topTenButton})
        Dim options As New FlowLayoutPanel With {.Dock = DockStyle.Top, .AutoSize = True,
                                                  .AutoSizeMode = AutoSizeMode.GrowAndShrink, .Padding = New Padding(8, 0, 8, 3)}
        lblHint.AutoSize = True
        lblHint.Margin = New Padding(8, 5, 3, 3)
        options.Controls.AddRange(New Control() {
            New Label With {.Text = "Difficulty", .AutoSize = True, .Margin = New Padding(3, 5, 3, 3)}, _difficultyPicker,
            New Label With {.Text = "Name", .AutoSize = True, .Margin = New Padding(8, 5, 3, 3)}, _playerName, lblHint
        })
        pnlHud.Controls.Add(options)
        pnlHud.Controls.Add(actions)
        pnlHud.AutoSize = True
        pnlHud.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If _state = RoundState.Ready OrElse _state = RoundState.Finished Then BeginRound()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        BeginRound()
    End Sub

    Private Sub BeginRound()
        gameTimer.Stop()
        _activeTime.Reset()
        _difficulty = CType(_difficultyPicker.SelectedIndex, CatchGameDifficulty)
        _roundPlayer = _playerName.Text
        _score = 0
        _lives = StartingLives
        _level = 1
        _spawnElapsed = 0
        ClearFallingItems()
        PositionPlayer()
        EnsurePlayerVisible()
        UpdateHud()
        ResumeRound()
    End Sub

    Private Sub SetRoundState(state As RoundState)
        _state = state
        _pressedKeys.Clear()
        Dim canConfigure As Boolean = state = RoundState.Ready OrElse state = RoundState.Finished
        _difficultyPicker.Enabled = canConfigure
        _playerName.Enabled = canConfigure
        btnStart.Enabled = canConfigure
        btnStart.Text = If(state = RoundState.Finished, "Play Again", "Start Game")
        _pauseButton.Enabled = Not canConfigure
        _pauseButton.Text = If(state = RoundState.Paused, "Resume", "Pause")
    End Sub

    Private Sub ResumeRound()
        SetRoundState(RoundState.Running)
        lblGameMessage.Hide()
        _activeTime.Start()
        gameTimer.Start()
        pnlPlayfield.Focus()
    End Sub

    Private Sub PauseRound()
        gameTimer.Stop()
        _activeTime.Stop()
        SetRoundState(RoundState.Paused)
        ShowRoundMessage("PAUSED" & vbCrLf & "Choose Resume to continue.")
    End Sub

    Private Sub TogglePause(sender As Object, e As EventArgs)
        If _state = RoundState.Running Then
            PauseRound()
        ElseIf _state = RoundState.Paused Then
            ResumeRound()
        End If
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If _state <> RoundState.Running Then Return

        MovePlayer()
        Dim currentLevel As Integer = CatchGamePace.LevelAt(_activeTime.ElapsedMilliseconds)
        If currentLevel <> _level Then
            _level = currentLevel
            UpdateHud()
        End If

        _spawnElapsed += gameTimer.Interval
        Dim interval As Integer = CatchGamePace.SpawnInterval(_difficulty, _level)
        If _spawnElapsed >= interval Then
            _spawnElapsed -= interval
            SpawnFallingItem()
        End If

        MoveAndCheckFallingItems()
    End Sub

    Private Sub MovePlayer()
        Dim horizontalMovement As Integer = 0
        If _pressedKeys.Contains(Keys.Left) OrElse _pressedKeys.Contains(Keys.A) Then
            horizontalMovement -= PlayerMoveSpeed
        End If
        If _pressedKeys.Contains(Keys.Right) OrElse _pressedKeys.Contains(Keys.D) Then
            horizontalMovement += PlayerMoveSpeed
        End If

        If horizontalMovement <> 0 Then
            Dim newX As Integer = picPlayer.Left + horizontalMovement
            Dim maxLeft As Integer = Math.Max(0, pnlPlayfield.ClientSize.Width - picPlayer.Width)
            picPlayer.Left = Math.Max(0, Math.Min(maxLeft, newX))
        End If
    End Sub

    Private Sub SpawnFallingItem()
        Dim isHazard As Boolean = _random.Next(4) = 0
        Dim itemBox As New PictureBox()
        itemBox.Size = New Size(40, 40)
        itemBox.Location = New Point(_random.Next(Math.Max(1, pnlPlayfield.ClientSize.Width - itemBox.Width + 1)), -itemBox.Height)
        itemBox.BackColor = Color.Transparent
        itemBox.SizeMode = PictureBoxSizeMode.Zoom
        itemBox.Image = If(isHazard, _imgHazard, _imgFood)
        If itemBox.Image Is Nothing Then
            itemBox.BackColor = If(isHazard, Color.Crimson, Color.Gold)
        End If
        itemBox.Tag = If(isHazard, "Hazard", "Food")
        itemBox.TabStop = False
        itemBox.AccessibleName = If(isHazard, "Hazard", "Food")
        pnlPlayfield.Controls.Add(itemBox)
        itemBox.BringToFront()
        picPlayer.BringToFront()

        Dim speed As Integer = CatchGamePace.MinimumFallSpeed(_difficulty, _level) + _random.Next(3)
        _fallingItems.Add(New FallingItem(itemBox, isHazard, speed))
    End Sub

    Private Sub MoveAndCheckFallingItems()
        Dim index As Integer = _fallingItems.Count - 1
        While index >= 0
            Dim item As FallingItem = _fallingItems(index)
            item.Box.Top += item.FallSpeed

            If item.Box.Bounds.IntersectsWith(picPlayer.Bounds) Then
                If item.IsHazard Then
                    _lives -= 1
                Else
                    _score += FoodScore
                End If
                RemoveItem(index)
                UpdateHud()

                If _lives <= 0 Then
                    EndGame()
                    Return
                End If
            ElseIf item.Box.Top >= pnlPlayfield.ClientSize.Height Then
                RemoveItem(index)
            End If

            index -= 1
        End While
    End Sub

    Private Sub RemoveItem(index As Integer)
        Dim item As FallingItem = _fallingItems(index)
        _fallingItems.RemoveAt(index)
        pnlPlayfield.Controls.Remove(item.Box)
        item.Box.Dispose()
    End Sub

    Private Sub ClearFallingItems()
        For index As Integer = _fallingItems.Count - 1 To 0 Step -1
            RemoveItem(index)
        Next
    End Sub

    Private Sub UpdateHud()
        lblScore.Text = "SCORE " & _score.ToString("0000")
        lblLives.Text = "LIVES " & _lives.ToString()
        lblHint.Text = "Level " & _level.ToString() & "   ·   ← / → or A / D   ·   Food +10"
    End Sub

    Private Sub EndGame()
        gameTimer.Stop()
        _activeTime.Stop()
        SetRoundState(RoundState.Finished)
        Dim scoreStatus As String = "Score saved. Choose Play Again or Top 10."
        Try
            _leaderboard.SaveScore(_roundPlayer, _difficulty, _score)
        Catch ex As Exception When IsLeaderboardError(ex)
            Debug.WriteLine(ex.ToString())
            scoreStatus = "Score could not be saved. You can still play again."
        End Try
        ShowRoundMessage("GAME OVER" & vbCrLf & _difficulty.ToString() & " · Level " & _level.ToString() &
                         " · Score " & _score.ToString() & vbCrLf & scoreStatus)
    End Sub

    Private Sub ShowRoundMessage(message As String)
        lblGameMessage.Text = message
        lblGameMessage.BringToFront()
        lblGameMessage.Show()
        CenterGameMessage()
    End Sub

    Private Sub ShowLeaderboard(sender As Object, e As EventArgs)
        If _state = RoundState.Running Then PauseRound()
        Try
            Using scores As DataTable = _leaderboard.ReadTopTen(),
                  dialog As New Form With {.Text = "Catch Game Top 10", .ClientSize = New Size(570, 360),
                                           .StartPosition = FormStartPosition.CenterParent, .ShowInTaskbar = False}
                Dim grid As New DataGridView With {
                    .Dock = DockStyle.Fill, .DataSource = scores, .ReadOnly = True,
                    .AllowUserToAddRows = False, .AllowUserToDeleteRows = False, .RowHeadersVisible = False,
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                }
                dialog.Controls.Add(grid)
                If scores.Rows.Count = 0 Then
                    dialog.Controls.Add(New Label With {.Text = "Complete a round to record a score.", .Dock = DockStyle.Top,
                                                       .Height = 30, .TextAlign = ContentAlignment.MiddleCenter})
                End If
                ThemeManager.ApplyTheme(dialog)
                dialog.ShowDialog(TopLevelControl)
            End Using
        Catch ex As Exception When IsLeaderboardError(ex)
            Debug.WriteLine(ex.ToString())
            MessageBox.Show(Me, "Could not open the local leaderboard.", "Catch Game", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Shared Function IsLeaderboardError(ex As Exception) As Boolean
        Return TypeOf ex Is Microsoft.Data.Sqlite.SqliteException OrElse TypeOf ex Is IO.IOException OrElse
               TypeOf ex Is UnauthorizedAccessException OrElse TypeOf ex Is System.Security.SecurityException OrElse
               TypeOf ex Is TypeInitializationException OrElse TypeOf ex Is DllNotFoundException OrElse
               TypeOf ex Is BadImageFormatException OrElse TypeOf ex Is EntryPointNotFoundException
    End Function

    Private Sub PositionPlayer()
        picPlayer.Top = Math.Max(0, pnlPlayfield.ClientSize.Height - picPlayer.Height - 10)
        picPlayer.Left = Math.Max(0, (pnlPlayfield.ClientSize.Width - picPlayer.Width) \ 2)
    End Sub

    Private Sub CenterGameMessage()
        lblGameMessage.Width = Math.Max(1, Math.Min(LogicalToDeviceUnits(640), pnlPlayfield.ClientSize.Width - LogicalToDeviceUnits(24)))
        Dim messageSize As Size = TextRenderer.MeasureText(lblGameMessage.Text, lblGameMessage.Font,
                                                           New Size(lblGameMessage.Width, Integer.MaxValue), TextFormatFlags.WordBreak)
        lblGameMessage.Height = messageSize.Height + LogicalToDeviceUnits(16)
        lblGameMessage.Left = Math.Max(0, (pnlPlayfield.ClientSize.Width - lblGameMessage.Width) \ 2)
        lblGameMessage.Top = Math.Max(0, (pnlPlayfield.ClientSize.Height - lblGameMessage.Height) \ 2 - 20)
    End Sub

    Private Sub pnlPlayfield_Resize(sender As Object, e As EventArgs) Handles pnlPlayfield.Resize
        PositionPlayer()
        CenterGameMessage()
    End Sub

    Private Sub frmCatchGame_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) _
        Handles MyBase.PreviewKeyDown, pnlPlayfield.PreviewKeyDown, picPlayer.PreviewKeyDown
        If _state = RoundState.Running AndAlso IsMovementKey(e.KeyCode) Then e.IsInputKey = True
    End Sub

    Private Sub frmCatchGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If _state = RoundState.Running AndAlso IsMovementKey(e.KeyCode) Then
            _pressedKeys.Add(e.KeyCode)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmCatchGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If _state = RoundState.Running AndAlso IsMovementKey(e.KeyCode) Then
            _pressedKeys.Remove(e.KeyCode)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
        If _state = RoundState.Running AndAlso IsMovementKey(keyData And Keys.KeyCode) Then Return True
        Return MyBase.IsInputKey(keyData)
    End Function

    Private Function IsMovementKey(key As Keys) As Boolean
        Return key = Keys.Left OrElse key = Keys.Right OrElse key = Keys.A OrElse key = Keys.D
    End Function

    Private Sub frmCatchGame_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        _pressedKeys.Clear()
    End Sub

    Private Sub frmCatchGame_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseItemSprites()
    End Sub

    Friend Sub ReleaseGameResources()
        If gameTimer IsNot Nothing Then gameTimer.Stop()
        _activeTime.Stop()
        ClearFallingItems()
        picPlayer.Image = Nothing
        If _playerSprite IsNot Nothing Then
            _playerSprite.Dispose()
            _playerSprite = Nothing
        End If
        If _playerSpriteStream IsNot Nothing Then
            _playerSpriteStream.Dispose()
            _playerSpriteStream = Nothing
        End If
        ReleaseItemSprites()
    End Sub

    Private Sub ReleaseItemSprites()
        If _imgFood IsNot Nothing Then
            _imgFood.Dispose()
            _imgFood = Nothing
        End If
        If _imgHazard IsNot Nothing Then
            _imgHazard.Dispose()
            _imgHazard = Nothing
        End If
    End Sub

    Private Sub picPlayer_Click(sender As Object, e As EventArgs) Handles picPlayer.Click

    End Sub
End Class

Friend NotInheritable Class FallingItem
    Public Sub New(box As PictureBox, isHazard As Boolean, fallSpeed As Integer)
        Me.Box = box
        Me.IsHazard = isHazard
        Me.FallSpeed = fallSpeed
    End Sub

    Public Property Box As PictureBox
    Public Property IsHazard As Boolean
    Public Property FallSpeed As Integer
End Class
