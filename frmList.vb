Public Class frmList
    Private Sub lbX_Click(sender As Object, e As EventArgs) Handles lbX.Click
        Me.Close()
        lbxMusic1.Items.Clear()
        lbxMusic2.Items.Clear()
        lbxVideo1.Items.Clear()
        lbxVideo2.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Multiselect = True
        open.Filter = "Music Files|*.mp3;*.ogg;*.wma|All Files|*.*"
        If open.ShowDialog = DialogResult.OK Then
            For Each filename As String In open.FileNames
                My.Settings.MusicLocations.Add(filename)
            Next
            For Each safefilename As String In open.SafeFileNames
                My.Settings.MusicNames.Add(safefilename)
            Next
            RefreshMusic()
        End If
    End Sub
    Sub RefreshMusic()
        lbxMusic1.Items.Clear()
        lbxMusic2.Items.Clear()
        For Each filename As String In My.Settings.MusicLocations
            lbxMusic2.Items.Add(filename)
        Next
        For Each safefilename As String In My.Settings.MusicNames
            lbxMusic1.Items.Add(safefilename)
        Next
    End Sub
    Sub RefreshVideo()
        lbxVideo1.Items.Clear()
        lbxVideo2.Items.Clear()
        For Each filename As String In My.Settings.VideoLocations
            lbxVideo2.Items.Add(filename)
        Next
        For Each safefilename As String In My.Settings.VideoNames
            lbxVideo1.Items.Add(safefilename)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open As New OpenFileDialog
        open.Multiselect = True
        open.Filter = "Video Files|*.avi;*.mp4;*.flv;*.wmv|All Files|*.*"
        If open.ShowDialog = DialogResult.OK Then
            For Each filename As String In open.FileNames
                My.Settings.VideoLocations.Add(filename)
            Next
            For Each safefilename As String In open.SafeFileNames
                My.Settings.VideoNames.Add(safefilename)
            Next
            RefreshVideo()
        End If
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMusic()
        RefreshVideo()
    End Sub
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    ' Left mouse button pressed
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub
    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick, Label1.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles lbxMusic1.DoubleClick
        lbxMusic2.SelectedIndex = lbxMusic1.SelectedIndex
        MetroForm.lbxLocation.Items.Add(lbxMusic2.SelectedItem)
        MetroForm.lbxSafeName.Items.Add(lbxMusic1.SelectedItem)
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles lbxVideo1.DoubleClick
        lbxVideo2.SelectedIndex = lbxMusic1.SelectedIndex
        MetroForm.lbxLocation.Items.Add(lbxVideo2.SelectedItem)
        MetroForm.lbxSafeName.Items.Add(lbxVideo1.SelectedItem)
    End Sub
End Class