Imports System.Windows

Public Class UserControl1
    Public opendlg As New OpenFileDialog 'An openfiledialog (duh)
    Public Sub OpenFile()
        MetroForm.AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Sets the mediastate to pause
        MetroForm.IsMediaPlaying = False 'Sets the boolean to false because the media file is no longer playing
        MetroForm.Refresh() 'Helps keep it fresh ;)
        If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            MetroForm.Refresh() 'Again ^^^
            MetroForm.AxPlayer1.MediaElement1.Source = New Uri(opendlg.FileName) 'Loads the media file selected by the user
            MetroForm.AxPlayer1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Sets the mediastate to play
            MetroForm.IsMediaPlaying = True 'Sets the boolean to true because the media file is now playing
            Dim NameSongTxt As String = IO.Path.GetFileNameWithoutExtension(opendlg.FileName) 'Gets the name of the file (which is most likely to be the name of the song)
            MetroForm.LabelPos.Text = "00:00:00" 'Sets the text of the label on MetroForm to nothing, just to refresh ;)
        End If
    End Sub

    Private Sub MediaElement1_BufferingEnded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingEnded
        MetroForm.LabelStatus.Hide() 'Hides our status label
    End Sub

    Private Sub MediaElement1_BufferingStarted(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingStarted
        MetroForm.LabelStatus.Text = "Buffering..." 'Sets our status text to buffering ^^^ you know why :|
        MetroForm.LabelStatus.Show() 'Shows our status label
    End Sub

    Private Sub MediaElement1_MediaEnded(sender As Object, e As RoutedEventArgs) Handles MediaElement1.MediaEnded
        If MetroForm.repeatplay = True Then 'if activated repeat
            If MetroForm.lbxSafeName.SelectedIndex = MetroForm.lbxSafeName.Items.Count - 1 Then 'if last media
                MetroForm.realindex = "-1"
                MetroForm.NextTrack()
            Else
                MetroForm.NextTrack()
            End If
        Else
            MetroForm.IsMediaPlaying = False
        End If
    End Sub

    Private Sub MediaElement1_MediaFailed(sender As Object, e As System.Windows.ExceptionRoutedEventArgs) Handles MediaElement1.MediaFailed
        MetroForm.LabelStatus.Text = "Media failed to open..." 'Sets our status label text to Media file opened because...well...it opened? :P
        MetroForm.LabelStatus.Show() 'Shows our status label
    End Sub

    Private Sub MediaElement1_MediaOpened(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.MediaOpened
        MetroForm.LabelStatus.Hide() 'Hides our status label
    End Sub
End Class
