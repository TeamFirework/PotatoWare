Public Class PicView
    Private Sub LoadImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadImageToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim ImgSel = OpenFileDialog1.FileName
        FilePathLabel.Text = ImgSel
        PictureArea.Load(ImgSel)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EtcMenu.Show(Button2, Point.Empty)
    End Sub
End Class