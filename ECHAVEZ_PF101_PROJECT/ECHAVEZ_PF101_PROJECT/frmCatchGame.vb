Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmCatchGame
    Private Const StartingLives As Integer = 3
    Private Const PlayerMoveSpeed As Integer = 8
    Private Const SpawnIntervalMilliseconds As Integer = 900
    Private Const FoodScore As Integer = 10

    Private ReadOnly _fallingItems As New List(Of FallingItem)()
    Private ReadOnly _pressedKeys As New HashSet(Of Keys)()
    Private ReadOnly _random As New Random()
    Private _score As Integer
    Private _lives As Integer = StartingLives
    Private _spawnElapsed As Integer
    Private _gameRunning As Boolean
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
        ThemeManager.ApplyTheme(Me)
        ThemeManager.SetButtonKind(btnRestart, ThemeManager.ButtonKind.Secondary)
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

        _imgFood = LoadItemSprite(foodPath, loadErrors)
        _imgHazard = LoadItemSprite(hazardPath, loadErrors)

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

        Dim newStream As IO.FileStream = IO.File.OpenRead(imgPath)
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If _lives <= 0 Then ResetGame()
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ResetGame()
        StartGame()
    End Sub

    Private Sub StartGame()
        If _gameRunning Then Return

        _gameRunning = True
        _spawnElapsed = 0
        lblGameMessage.Visible = False
        btnStart.Enabled = False
        _pressedKeys.Clear()
        gameTimer.Start()
        pnlPlayfield.Focus()
    End Sub

    Private Sub ResetGame()
        gameTimer.Stop()
        _gameRunning = False
        _score = 0
        _lives = StartingLives
        _spawnElapsed = 0
        _pressedKeys.Clear()
        ClearFallingItems()
        PositionPlayer()
        EnsurePlayerVisible()
        UpdateHud()
        lblGameMessage.Text = "CATCH FOOD - AVOID HAZARDS" & vbCrLf & "Press Start Game to play"
        lblGameMessage.Visible = True
        btnStart.Text = "Start Game"
        btnStart.Enabled = True
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If Not _gameRunning Then Return

        MovePlayer()
        _spawnElapsed += gameTimer.Interval
        If _spawnElapsed >= SpawnIntervalMilliseconds Then
            _spawnElapsed -= SpawnIntervalMilliseconds
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

        _fallingItems.Add(New FallingItem(itemBox, isHazard, _random.Next(3, 6)))
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
    End Sub

    Private Sub EndGame()
        gameTimer.Stop()
        _gameRunning = False
        _pressedKeys.Clear()
        lblGameMessage.Text = "GAME OVER" & vbCrLf & "Final score: " & _score.ToString()
        lblGameMessage.Visible = True
        btnStart.Text = "Play Again"
        btnStart.Enabled = True
    End Sub

    Private Sub PositionPlayer()
        picPlayer.Top = Math.Max(0, pnlPlayfield.ClientSize.Height - picPlayer.Height - 10)
        picPlayer.Left = Math.Max(0, (pnlPlayfield.ClientSize.Width - picPlayer.Width) \ 2)
    End Sub

    Private Sub CenterGameMessage()
        lblGameMessage.Left = Math.Max(0, (pnlPlayfield.ClientSize.Width - lblGameMessage.Width) \ 2)
        lblGameMessage.Top = Math.Max(0, (pnlPlayfield.ClientSize.Height - lblGameMessage.Height) \ 2 - 20)
    End Sub

    Private Sub pnlPlayfield_Resize(sender As Object, e As EventArgs) Handles pnlPlayfield.Resize
        PositionPlayer()
        CenterGameMessage()
    End Sub

    Private Sub frmCatchGame_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) _
        Handles MyBase.PreviewKeyDown, pnlPlayfield.PreviewKeyDown, picPlayer.PreviewKeyDown
        If IsMovementKey(e.KeyCode) Then e.IsInputKey = True
    End Sub

    Private Sub frmCatchGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If IsMovementKey(e.KeyCode) Then
            _pressedKeys.Add(e.KeyCode)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmCatchGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If IsMovementKey(e.KeyCode) Then
            _pressedKeys.Remove(e.KeyCode)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
        If IsMovementKey(keyData And Keys.KeyCode) Then Return True
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
