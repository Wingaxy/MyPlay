Public Class Settingsfrm
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        TabControl1.SelectedTab = tbSettings
        Button1.Visible = True
        Label3.Text = TabControl1.SelectedTab.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = tbMain
        Button1.Visible = False
        Label3.Text = TabControl1.SelectedTab.Text
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        TabControl1.SelectedTab = tbAbout
        Button1.Visible = True
        Label3.Text = TabControl1.SelectedTab.Text
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    ' Left mouse button pressed
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label4.MouseDown, Label2.MouseDown, Label1.MouseDown, Button1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub
    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label4.MouseMove, Label2.MouseMove, Label1.MouseMove, Button1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label4.MouseUp, Label2.MouseUp, Label1.MouseUp, Button1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick, Label2.DoubleClick, Label1.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Settingsfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbUpdates.Checked = My.Settings.CheckForUpdates
        cbNotify.Checked = My.Settings.NotifyUserforUpdates
        PictureBox1.Image = MetroForm.pbLogo.Image
    End Sub

    Private Sub cbUpdates_CheckedChanged(sender As Object, e As EventArgs) Handles cbUpdates.CheckedChanged
        My.Settings.CheckForUpdates = cbUpdates.Checked
    End Sub

    Private Sub cbNotify_CheckedChanged(sender As Object, e As EventArgs) Handles cbNotify.CheckedChanged
        My.Settings.NotifyUserforUpdates = cbNotify.Checked
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        My.Settings.MusicLocations.Clear()
        My.Settings.VideoLocations.Clear()
        My.Settings.MusicNames.Clear()
        My.Settings.VideoNames.Clear()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If MsgBox("Do you want to set this language :" & vbNewLine & ListView1.SelectedItems(0).Text, vbYesNoCancel, "MyPlay") = MsgBoxResult.Yes Then
            If ListView1.SelectedItems(0).Text = "Türkçe" Then
                MetroForm.translate("Dosya Aç", "Liste Aç", "Seçileni Oynat", "Seçileni Kaldır", "Sonraki", "Önceki", "Listeyi Temizle", "Listeyi Kaydet", "Hız", "Ayarlar", "Kütüphane", "Müzikler", "Videolar", "Temizle", "Güncellemeleri Kontrol Et", "Güncellemelerde uyar", "Ekle", "Hakkında")
            ElseIf ListView1.SelectedItems(0).Text = "English" Then
                MetroForm.translate("Open File", "Open List", "Play Selected", "Remove Selected", "Next", "Previous", "ClearList", "SaveList", "Speed", "Settings", "Library", "Musics", "Videos", "Clear", "Check For Updates", "Notify Me if There is Update", "Add", "About")
            End If
            My.Settings.Lang = ListView1.SelectedItems(0).Text
        End If
    End Sub
End Class