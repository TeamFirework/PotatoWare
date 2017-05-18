Public Class FullscreenPotatoMenu
    Private Sub PotatoWareSettingsCue_Click(sender As Object, e As EventArgs) Handles PotatoWareSettingsCue.Click
        PotatoManagement.LaunchMDI(SettingsWindow, FullscreenPotato)
        Close()
    End Sub
    Private Sub NotifiCue_Click(sender As Object, e As EventArgs) Handles NotifiCue.Click
        PotatoManagement.LaunchMDI(NotificationCenter, FullscreenPotato)
        Close()
    End Sub
    Private Sub ExitFullscreen_Click(sender As Object, e As EventArgs) Handles ExitFullscreen.Click
        Close()
        PotatoLaunch.Show()
        FullscreenPotato.Close()
    End Sub
    Private Sub OpenAppsCue_Click(sender As Object, e As EventArgs) Handles OpenAppsCue.Click
        AppList.Show(Me, OpenAppsCue.Location)
    End Sub
    Private Sub BossBattlesItem_TroopPotatoSkullItem_Click(sender As Object, e As EventArgs) Handles BossBattlesItem_TroopPotatoSkullItem.Click
        PotatoManagement.LaunchMDI(PotatoSkul, FullscreenPotato)
    End Sub
    Public Sub Reposition(x As Integer, y As Integer)
        SetDesktopLocation(x, y)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Close()
    End Sub
End Class