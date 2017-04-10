Public Class MetroForm
    Public realindex As String
    Public IsMediaPlaying As Boolean 'This will be used to determine whether our media file is playing or not
    Public Sub NextTrack()
        realindex += 1
        lbxLocation.SelectedIndex = realindex
        lbxSafeName.SelectedIndex = realindex
        AxPlayer1.MediaElement1.Source = New Uri(lbxLocation.SelectedItem)
        IsMediaPlaying = True
    End Sub
    Public Sub PreviousTrack()
        realindex -= 1
        lbxLocation.SelectedIndex = realindex
        lbxSafeName.SelectedIndex = realindex
        AxPlayer1.MediaElement1.Source = New Uri(lbxLocation.SelectedItem)
        IsMediaPlaying = True
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If IsMediaPlaying = False Then
            ButtoPlayPause.Image = My.Resources.icon_play_48 'Sets the Play/Pause button to a play icon
        Else
            ButtoPlayPause.Image = My.Resources.icon_pause_48 'Sets the Play/Pause button to a pause icon
            LabelPos.Text = AxPlayer1.MediaElement1.Position.Duration.ToString 'Sets the labels text to the position of the media file
        End If
        Label2.Text = lbxSafeName.SelectedItem
        If lbxSafeName.Visible = True Then
            btList.Text = "▪"
        Else
            btList.Text = "■"
        End If
        If Me.WindowState = FormWindowState.Maximized Then
            btMaximize.Text = "▫"
        Else
            btMaximize.Text = "□"
        End If
    End Sub

    Private Sub ButtoPlayPause_Click(sender As System.Object, e As System.EventArgs) Handles ButtoPlayPause.Click
        If IsMediaPlaying = False Then
            AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Plays the media file
            IsMediaPlaying = True 'Sets our "IsMediaPlaying" boolean to true because the mediastate has been set to play
        Else
            AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Pauses the media file
            IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to pause
        End If
    End Sub

    Private Sub ButtonStop_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStop.Click
        AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop 'Stops the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to stop
    End Sub

    Private Sub ButtonRew_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRew.Click
        AxPlayer1.MediaElement1.Position = AxPlayer1.MediaElement1.Position - TimeSpan.FromSeconds(10) 'Subtracts 10 seconds to the position of the media file
    End Sub

    Private Sub ButtonFstFrwrd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFstFrwrd.Click
        AxPlayer1.MediaElement1.Position = AxPlayer1.MediaElement1.Position + TimeSpan.FromSeconds(10) 'Adds 10 seconds to the position of the media file
    End Sub
    Public repeatplay As Boolean = False
    Private Sub ButtonOpen_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpen.Click
        If repeatplay = True Then
            repeatplay = False
            ButtonOpen.BackColor = Color.FromArgb(64, 64, 64)
        Else
            ButtonOpen.BackColor = Color.FromArgb(94, 94, 94)
            repeatplay = True
        End If
    End Sub

    Private Sub PlayAx(sender As System.Object, e As System.EventArgs)
        AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Plays the media file
        IsMediaPlaying = True 'Sets our "IsMediaPlaying" boolean to true because the mediastate has been set to play
    End Sub

    Private Sub PauseAx(sender As System.Object, e As System.EventArgs)
        AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Pauses the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to pause
    End Sub

    Private Sub StopAx(sender As System.Object, e As System.EventArgs)
        AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop 'Stops the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to stop
    End Sub

    Private Sub RewindAx(sender As System.Object, e As System.EventArgs)
        AxPlayer1.MediaElement1.Position = AxPlayer1.MediaElement1.Position - TimeSpan.FromSeconds(10) 'Subtracts 10 seconds to the position of the media file
    End Sub

    Private Sub FastforwardAx(sender As System.Object, e As System.EventArgs)
        AxPlayer1.MediaElement1.Position = AxPlayer1.MediaElement1.Position + TimeSpan.FromSeconds(10) 'Adds 10 seconds to the position of the media file
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        AxPlayer1.MediaElement1.SpeedRatio = TrackBar1.Value 'Sets the media file playing speed according to the value of the trackbar
        Speedvaluelabel.Text = "x" + TrackBar1.Value.ToString 'Displays the speed in string/text form
    End Sub

    Private Sub SpeedSettings_Show(sender As System.Object, e As System.EventArgs)
        SpeedPanel.Show() 'Shows the panel to control the speed of the media file
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SpeedPanel.Hide() 'Hides the panel to control the speed of the media file
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btExit.Click
        End 'Closes program
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then 'Checks if already maximized
            Me.WindowState = FormWindowState.Normal 'Maximized so we will normalize it
        Else
            Me.WindowState = FormWindowState.Maximized 'not maximized so we will maximize it
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btMinimize.Click
        Me.WindowState = FormWindowState.Minimized 'minimized it because user cannot miniize again if the program is already minimized
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles btList.Click
        If lbxSafeName.Visible = False Then 'Checks if list is shown
            lbxSafeName.Visible = True ' shows list
        Else
            lbxSafeName.Visible = False ' hides list
        End If
    End Sub

    Private Sub btnFullScreen_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mlOpen_Click(sender As Object, e As EventArgs) Handles mlOpen.Click
        Dim open As New OpenFileDialog
        open.Title = "MyPlay"
        open.Multiselect = True
        open.Filter = "Media Files|*.mp3;*.ogg;*.wma;*.avi;*.mp4;*.flv;*.wmv|Music Files|*.mp3;*.ogg;*.wma|Video Files|*.avi;*.mp4;*.flv;*.wmv|All Files|*.*"
        If open.ShowDialog = DialogResult.OK Then
            For Each dosyakonum As String In open.FileNames
                lbxLocation.Items.Add(dosyakonum)
            Next
            For Each dosyaadi As String In open.SafeFileNames
                lbxSafeName.Items.Add(dosyaadi)
            Next
        End If
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlPrevious.Click
        PreviousTrack()
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlMext.Click
        NextTrack()
    End Sub

    Private Sub SpeedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlSpeed.Click
        If SpeedPanel.Visible = True Then
            SpeedPanel.Visible = False
        Else
            SpeedPanel.Visible = True
        End If
    End Sub

    Private Sub PlaySelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlPS.Click, lbxSafeName.MouseDoubleClick
        realindex = lbxSafeName.SelectedIndex
        lbxLocation.SelectedIndex = realindex
        AxPlayer1.MediaElement1.Source = New Uri(lbxLocation.SelectedItem)
        IsMediaPlaying = True
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlRS.Click
        lbxLocation.Items.Remove(lbxSafeName.SelectedIndex)
        lbxSafeName.Items.Remove(lbxSafeName.SelectedIndex)
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlCL.Click
        lbxSafeName.Items.Clear()
        lbxLocation.Items.Clear()
    End Sub

    Private Sub SaveListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlSL.Click
        Dim SetSave As SaveFileDialog = New SaveFileDialog
        Dim i As Integer
        SetSave.Title = "Save Playlist"
        SetSave.Filter = "MyPlay Editable Playlist v3|*.mpel3"
        If SetSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As New IO.StreamWriter(SetSave.FileName, False)
            Dim Seperator As String = ";" & vbNewLine
            For i = 0 To lbxLocation.Items.Count - 1
                s.WriteLine(lbxLocation.Items.Item(i) & Seperator)
                s.WriteLine(lbxSafeName.Items.Item(i) & Seperator)
            Next
            s.Close()
        End If

    End Sub

    Private Sub OpenListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mlOpenList.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "MyPlay Editable Playlist v3|*.mpel3"
        If OpenFile.ShowDialog = DialogResult.OK Then
            Dim ReadFile As New System.IO.StreamReader(OpenFile.FileName, False)
            Dim Playlist As String = ReadFile.ReadToEnd
            Dim SplittedFase() = Playlist.Split(";" & vbNewLine)
            Dim Count As Integer = SplittedFase.Count - Val(1)
            Dim i As Integer = 0
            Do Until i = Count
                lbxLocation.Items.Add(SplittedFase(i))
                i += Val(1)
                lbxSafeName.Items.Add(SplittedFase(i))
                i += Val(1)
            Loop
            ReadFile.Close()
        End If
    End Sub
    Sub translate(OpenFile As String, OpenList As String, PlaySelected As String, RemoveSelected As String, NextTrack As String, Previous As String, ClearList As String, SaveList As String, Speed As String, Settings As String, Library As String, Musics As String, Videos As String, Clear As String, CheckForUpdate As String, NotifyMeWhenThereIsUpdate As String, Add As String, About As String)
        mlCL.Text = ClearList
        mlSL.Text = SaveList
        mlOpen.Text = OpenFile
        mlOpenList.Text = OpenList
        mlPS.Text = PlaySelected
        mlSpeed.Text = Speed
        mlRS.Text = RemoveSelected
        mlPrevious.Text = Previous
        mlMext.Text = NextTrack
        frmList.Text = Library
        frmList.Label1.Text = Library
        frmList.tbMusics.Text = Musics
        frmList.tbVideos.Text = Videos
        frmList.Button1.Text = Add
        frmList.Button2.Text = Add
        Settingsfrm.Text = Settings
        Settingsfrm.Label1.Text = Settings
        Settingsfrm.cbUpdates.Text = CheckForUpdate
        Settingsfrm.cbNotify.Text = NotifyMeWhenThereIsUpdate
        Settingsfrm.MetroLabel1.Text = Library & " :"
        Settingsfrm.MetroButton1.Text = Clear
        Settingsfrm.MetroTile1.Text = Settings
        Settingsfrm.MetroTile4.Text = About
        Label3.Text = Speed
        mlLibrary.Text = Library
    End Sub

    Private Sub MetroForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.Lang = "Türkçe" Then
            translate("Dosya Aç", "Liste Aç", "Seçileni Oynat", "Seçileni Kaldır", "Sonraki", "Önceki", "Listeyi Temizle", "Listeyi Kaydet", "Hız", "Ayarlar", "Kütüphane", "Müzikler", "Videolar", "Temizle", "Güncellemeleri Kontrol Et", "Güncellemelerde uyar", "Ekle", "Hakkında")
        ElseIf My.Settings.Lang = "English" Then
            translate("Open File", "Open List", "Play Selected", "Remove Selected", "Next", "Previous", "ClearList", "SaveList", "Speed", "Settings", "Library", "Musics", "Videos", "Clear", "Check For Updates", "Notify Me if There is Update", "Add", "About")
        End If
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Settingsfrm.ShowDialog()
    End Sub
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    ' Left mouse button pressed
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub
    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles pbLogo.DoubleClick, Panel1.DoubleClick, Label2.DoubleClick, Label1.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mlLibrary_Click(sender As Object, e As EventArgs) Handles mlLibrary.Click
        frmList.Show()
    End Sub
End Class