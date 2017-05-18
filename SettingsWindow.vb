Public Class SettingsWindow
    Private Sub SettingsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PW_Use24Hr.Checked = My.Settings.TimeIs24Hours 'Set the Use 24 Hours setting box to match the setting.

    End Sub

    Private Sub PW_Use24Hr_CheckedChanged(sender As Object, e As EventArgs) Handles PW_Use24Hr.CheckedChanged
        My.Settings.TimeIs24Hours = PW_Use24Hr.Checked
    End Sub 'Setting: Use 24 Hours?

#Region "Window dragging"
    'When putting this into another Form, change the Handles.
    Private dragging As Boolean = False
    Private dragCursorPoint As Point
    Private dragFormPoint As Point

    Private Sub FormMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, Label2.MouseDown
        dragging = True
        dragCursorPoint = Cursor.Position
        dragFormPoint = Me.Location
    End Sub

    Private Sub FormMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, Label2.MouseMove
        If dragging Then
            Dim dif As Point = Point.Subtract(Cursor.Position, New Size(dragCursorPoint))
            Me.Location = Point.Add(dragFormPoint, New Size(dif))
        End If
    End Sub

    Private Sub FormMain_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp, Label2.MouseUp
        dragging = False
    End Sub
#End Region
#Region "Exit Button events"
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.ForeColor = Color.Red
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.ForeColor = Color.White
    End Sub
#End Region

    Private Sub UseOldInterfaceSetting_CheckedChanged(sender As Object, e As EventArgs) Handles UseOldInterfaceSetting.CheckedChanged
        My.Settings.UseOldPotatoFullscreenInterface = UseOldInterfaceSetting.Checked
    End Sub

    Private Sub FullscreenPotatoThemeColorButton_Click(sender As Object, e As EventArgs) Handles FullscreenPotatoThemeColorButton.Click
        ColorSelector.Color = My.Settings.FullscreenPotatoTheme
        ColorSelector.ShowDialog(Me)
        My.Settings.FullscreenPotatoTheme = ColorSelector.Color
    End Sub

    Private Sub TaskTextRadio_Black_CheckedChanged(sender As Object, e As EventArgs) Handles TaskTextRadio_Black.Click
        My.Settings.FSPTaskText = Color.Black
    End Sub
    Private Sub TaskTextRadio_White_CheckedChanged(sender As Object, e As EventArgs) Handles TaskTextRadio_White.Click
        My.Settings.FSPTaskText = Color.White
    End Sub

    Private Sub UseOldInterfaceSetting_Paint(sender As Object, e As PaintEventArgs) Handles UseOldInterfaceSetting.Paint
        UseOldInterfaceSetting.Checked = My.Settings.UseOldPotatoFullscreenInterface 'Set the Use Old Desktop Interface setting to match.
    End Sub

    Private Sub TaskText_Panel_Paint(sender As Object, e As EventArgs) Handles TaskText_Panel.Paint
        If My.Settings.FSPTaskText = Color.White Then
            TaskTextRadio_White.Checked = True
        Else
            TaskTextRadio_Black.Checked = True
        End If
    End Sub
End Class