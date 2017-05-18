Public Class NotificationCenter
    Private Sub LoadCenter(sender As Object, e As EventArgs) Handles Me.Load
        NotifDisplay.Items.Clear()
        Try
            If My.Settings.NotificationGrid IsNot Nothing Then
                For Each item In My.Settings.NotificationGrid
                    NotifDisplay.Items.Add(item)
                Next
            End If
        Catch
            'Nothing
        End Try
    End Sub

    Private Sub NotifDisplay_DoubleClick(sender As Object, e As EventArgs) Handles NotifDisplay.DoubleClick
        Dim imi = NotifDisplay.SelectedIndex
        My.Settings.NotificationGrid.RemoveAt(imi)
        NotifDisplay.Items.RemoveAt(imi)
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        'Refresh the list.
        NotifDisplay.Items.Clear()
        NotifDisplay.Items.Add(My.Settings.NotificationGrid)
    End Sub

#Region "Window dragging"
    'When putting this into another Form, change the Handles.
    Private dragging As Boolean = False
    Private dragCursorPoint As Point
    Private dragFormPoint As Point

    Private Sub FormMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, WindowCaption.MouseDown
        dragging = True
        dragCursorPoint = Cursor.Position
        dragFormPoint = Me.Location
    End Sub

    Private Sub FormMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, WindowCaption.MouseMove
        If dragging Then
            Dim dif As Point = Point.Subtract(Cursor.Position, New Size(dragCursorPoint))
            Me.Location = Point.Add(dragFormPoint, New Size(dif))
        End If
    End Sub

    Private Sub FormMain_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp, WindowCaption.MouseUp
        dragging = False
    End Sub
#End Region
#Region "Caption Button events"
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.ForeColor = Color.Red
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.ForeColor = Color.White
    End Sub

    Private Sub ReorgWindow_Click(sender As Object, e As EventArgs) Handles ReorgWindow.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NotificationCenter_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            NotifDisplay.Parent = Me
            TableLayoutPanel1.Visible = False
        Else
            NotifDisplay.Parent = TableLayoutPanel1
            TableLayoutPanel1.Visible = True
        End If
    End Sub
#End Region
End Class