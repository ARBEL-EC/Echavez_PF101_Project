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
    Private ReadOnly _levelLabel As New Label With {.AutoSize = True}
    Private ReadOnly _roundCard As New TableLayoutPanel With {
        .ColumnCount = 1, .RowCount = 5, .AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .Padding = New Padding(12)
    }
    Private ReadOnly _roundSummary As New Label With {.AutoSize = True, .TextAlign = ContentAlignment.MiddleCenter, .Anchor = AnchorStyles.None}
    Private ReadOnly _roundStatus As New Label With {.AutoSize = True, .TextAlign = ContentAlignment.MiddleCenter, .Anchor = AnchorStyles.None}
    Private ReadOnly _cardActions As New FlowLayoutPanel With {.AutoSize = True, .Anchor = AnchorStyles.None}
    Private ReadOnly _cardPrimary As New Button With {.AutoSize = True}
    Private ReadOnly _cardTopTen As New Button With {.Text = "Top 10", .AutoSize = True}
    Private ReadOnly _diagnostics As New LinkLabel With {.Text = "Open diagnostics", .AutoSize = True, .Anchor = AnchorStyles.None}
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
        BuildRoundCard()
        ThemeManager.ApplyTheme(Me)
        ThemeManager.SetButtonKind(btnRestart, ThemeManager.ButtonKind.Secondary)
        ThemeManager.SetButtonKind(_pauseButton, ThemeManager.ButtonKind.Secondary)
        ThemeManager.SetButtonKind(_topTenButton, ThemeManager.ButtonKind.Secondary)
        ThemeManager.SetButtonKind(_cardTopTen, ThemeManager.ButtonKind.Secondary)
        SetRoundState(RoundState.Ready)
        picPlayer.SizeMode = PictureBoxSizeMode.Zoom
        picPlayer.BackColor = Color.Transparent
        LoadPlayerSpriteFromAssets()

        pnlHud.BackColor = ThemeManager.ClrSurface
        pnlPlayfield.BackColor = Color.FromArgb(37, 43, 56)
        _roundCard.BackColor = ThemeManager.ClrSurface
        lblHint.ForeColor = ThemeManager.ClrTextMuted
        _roundStatus.ForeColor = ThemeManager.ClrTextMuted

        LoadItemSprites()
        PositionPlayer()
        EnsurePlayerVisible()
        UpdateHud()
        ShowRoundCard("Catch food and avoid hazards", "", "Choose a difficulty, then start the game.")
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

        Dim stats As FlowLayoutPanel = CreateHudRow()
        For Each metric As Label In {lblScore, lblLives, _levelLabel}
            metric.AutoSize = True
            metric.Font = ThemeManager.GetFont("Segoe UI", 11.0F, FontStyle.Bold)
            metric.Margin = New Padding(4, 7, 16, 7)
            stats.Controls.Add(metric)
        Next
        lblHint.AutoSize = True
        lblHint.Margin = New Padding(4, 8, 4, 6)
        lblHint.Text = "Move with ← / → or A / D"
        stats.Controls.Add(lblHint)

        Dim controls As FlowLayoutPanel = CreateHudRow()
        controls.Controls.AddRange(New Control() {
            New Label With {.Text = "Difficulty", .AutoSize = True, .Margin = New Padding(4, 7, 3, 3)}, _difficultyPicker,
            New Label With {.Text = "Player name", .AutoSize = True, .Margin = New Padding(8, 7, 3, 3)}, _playerName,
            btnStart, btnRestart, _pauseButton, _topTenButton
        })
        For Each button As Button In {btnStart, btnRestart, _pauseButton, _topTenButton}
            button.AutoSize = True
            button.Size = New Size(0, LogicalToDeviceUnits(28))
            button.Margin = New Padding(4, 3, 4, 3)
        Next

        pnlHud.Controls.Add(controls)
        pnlHud.Controls.Add(stats)
        pnlHud.AutoSize = True
        pnlHud.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Private Shared Function CreateHudRow() As FlowLayoutPanel
        Return New FlowLayoutPanel With {.Dock = DockStyle.Top, .AutoSize = True,
                                         .AutoSizeMode = AutoSizeMode.GrowAndShrink, .Padding = New Padding(8, 0, 8, 3)}
    End Function

    Private Sub BuildRoundCard()
        _roundCard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        For index As Integer = 0 To _roundCard.RowCount - 1
            _roundCard.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next
        lblGameMessage.AutoSize = True
        lblGameMessage.Anchor = AnchorStyles.None
        lblGameMessage.Font = ThemeManager.GetFont("Segoe UI", 15.0F, FontStyle.Bold)
        lblGameMessage.BackColor = Color.Transparent
        _roundCard.Controls.Add(lblGameMessage, 0, 0)
        _roundCard.Controls.Add(_roundSummary, 0, 1)
        _roundCard.Controls.Add(_roundStatus, 0, 2)
        _cardActions.Controls.AddRange(New Control() {_cardPrimary, _cardTopTen})
        _roundCard.Controls.Add(_cardActions, 0, 3)
        _roundCard.Controls.Add(_diagnostics, 0, 4)
        AddHandler _cardPrimary.Click,
            Sub(sender, args)
                If _state = RoundState.Paused Then
                    ResumeRound()
                ElseIf _state = RoundState.Finished Then
                    BeginRound()
                End If
            End Sub
        AddHandler _cardTopTen.Click, AddressOf ShowLeaderboard
        AddHandler _diagnostics.LinkClicked, Sub(sender, args) OpenDiagnostics(_leaderboard.LastDiagnosticPath)
        pnlPlayfield.Controls.Add(_roundCard)
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
        _roundCard.Hide()
        _activeTime.Start()
        gameTimer.Start()
        pnlPlayfield.Focus()
    End Sub

    Private Sub PauseRound()
        gameTimer.Stop()
        _activeTime.Stop()
        SetRoundState(RoundState.Paused)
        ShowRoundCard("Paused", RoundSummary(), "")
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
        lblScore.Text = "Score " & _score.ToString("0000")
        lblLives.Text = "Lives " & _lives.ToString()
        _levelLabel.Text = "Level " & _level.ToString()
    End Sub

    Private Sub EndGame()
        gameTimer.Stop()
        _activeTime.Stop()
        SetRoundState(RoundState.Finished)
        Dim saved As Boolean = False
        Try
            _leaderboard.SaveScore(_roundPlayer, _difficulty, _score)
            saved = True
        Catch ex As Exception When CatchGameLeaderboard.IsStorageError(ex)
            Debug.WriteLine(ex.Message)
        End Try
        ShowRoundCard("Game over", RoundSummary(), If(saved, "Score saved to the leaderboard.", "Score could not be saved."),
                      showDiagnostics:=Not saved)
    End Sub

    Private Function RoundSummary() As String
        Return "Score " & _score.ToString() & "   ·   Level " & _level.ToString() & "   ·   " & _difficulty.ToString()
    End Function

    Private Sub ShowRoundCard(title As String, summary As String, status As String, Optional showDiagnostics As Boolean = False)
        lblGameMessage.Text = title
        _roundSummary.Text = summary
        _roundSummary.Visible = summary.Length > 0
        _roundStatus.Text = status
        _roundStatus.Visible = status.Length > 0
        _cardPrimary.Text = If(_state = RoundState.Paused, "Resume", "Play Again")
        _cardActions.Visible = _state = RoundState.Paused OrElse _state = RoundState.Finished
        _cardTopTen.Visible = _state = RoundState.Finished
        _diagnostics.Visible = showDiagnostics AndAlso _leaderboard.LastDiagnosticPath IsNot Nothing
        _roundCard.Show()
        CenterRoundCard()
        _roundCard.BringToFront()
    End Sub

    Private Sub ShowLeaderboard(sender As Object, e As EventArgs)
        If _state = RoundState.Running Then PauseRound()
        Dim scores As DataTable = Nothing
        Try
            scores = _leaderboard.ReadTopTen()
        Catch ex As Exception When CatchGameLeaderboard.IsStorageError(ex)
            Debug.WriteLine(ex.Message)
        End Try

        Using results As DataTable = scores,
              dialog As New Form With {.Text = "Catch Game Top 10", .ClientSize = New Size(570, 360),
                                       .StartPosition = FormStartPosition.CenterParent, .ShowInTaskbar = False}
            If results Is Nothing Then
                Dim status As New Label With {.Text = "The local leaderboard is unavailable.", .Dock = DockStyle.Top,
                                               .AutoSize = True, .Padding = New Padding(12)}
                Dim path As String = _leaderboard.LastDiagnosticPath
                If path IsNot Nothing Then
                    Dim link As New LinkLabel With {.Text = "Open diagnostics", .AutoSize = True,
                                                    .Dock = DockStyle.Top, .Padding = New Padding(12)}
                    AddHandler link.LinkClicked, Sub(source, args) OpenDiagnostics(path)
                    dialog.Controls.Add(link)
                End If
                dialog.Controls.Add(status)
            Else
                Dim grid As New DataGridView With {
                    .Dock = DockStyle.Fill, .DataSource = results, .ReadOnly = True,
                    .AllowUserToAddRows = False, .AllowUserToDeleteRows = False, .RowHeadersVisible = False,
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                }
                dialog.Controls.Add(grid)
                If results.Rows.Count = 0 Then
                    dialog.Controls.Add(New Label With {.Text = "Complete a round to record a score.", .Dock = DockStyle.Top,
                                                       .Height = 30, .TextAlign = ContentAlignment.MiddleCenter})
                End If
            End If
            ThemeManager.ApplyTheme(dialog)
            dialog.ShowDialog(TopLevelControl)
        End Using
    End Sub

    Private Sub OpenDiagnostics(path As String)
        If path Is Nothing Then Return
        Try
            Using launched As Process = Process.Start(New ProcessStartInfo(path) With {.UseShellExecute = True})
            End Using
        Catch ex As System.ComponentModel.Win32Exception
            Debug.WriteLine(ex.Message)
            MessageBox.Show(Me, "Open the following diagnostics file in a text editor." & vbCrLf & path,
                            "Catch Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PositionPlayer(Optional recenter As Boolean = True)
        picPlayer.Top = Math.Max(0, pnlPlayfield.ClientSize.Height - picPlayer.Height - 10)
        Dim maxLeft As Integer = Math.Max(0, pnlPlayfield.ClientSize.Width - picPlayer.Width)
        picPlayer.Left = If(recenter, maxLeft \ 2, Math.Min(picPlayer.Left, maxLeft))
    End Sub

    Private Sub CenterRoundCard()
        Dim width As Integer = Math.Max(1, Math.Min(LogicalToDeviceUnits(380), pnlPlayfield.ClientSize.Width - LogicalToDeviceUnits(24)))
        _roundCard.MaximumSize = New Size(width, 0)
        _roundCard.MinimumSize = New Size(width, 0)
        Dim textWidth As Integer = Math.Max(1, width - _roundCard.Padding.Horizontal - 8)
        For Each label As Control In {lblGameMessage, _roundSummary, _roundStatus}
            label.MaximumSize = New Size(textWidth, 0)
        Next
        _roundCard.PerformLayout()
        _roundCard.Left = Math.Max(0, (pnlPlayfield.ClientSize.Width - _roundCard.Width) \ 2)
        _roundCard.Top = Math.Max(0, (pnlPlayfield.ClientSize.Height - _roundCard.Height) \ 2)
    End Sub

    Private Sub pnlPlayfield_Resize(sender As Object, e As EventArgs) Handles pnlPlayfield.Resize
        PositionPlayer(_state = RoundState.Ready)
        For Each item As FallingItem In _fallingItems
            item.Box.Left = Math.Min(item.Box.Left, Math.Max(0, pnlPlayfield.ClientSize.Width - item.Box.Width))
        Next
        CenterRoundCard()
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

    Friend Sub ReleaseGameResources()
        If gameTimer IsNot Nothing Then gameTimer.Stop()
        _activeTime.Stop()
        ClearFallingItems()
        If picPlayer IsNot Nothing Then picPlayer.Image = Nothing
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

Friend NotInheritable Class CatchGamePlayfield
    Inherits Panel

    Friend Sub New()
        SetStyle(ControlStyles.Selectable, True)
        DoubleBuffered = True
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
