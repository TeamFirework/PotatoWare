Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class FullscreenPotato
#Region "Process"
    <DllImport("User32", CharSet:=CharSet.Auto, ExactSpelling:=True)> Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndParent As IntPtr) As IntPtr
    End Function

    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    Private Sub CallProcessMdi(procName As String, processPath As String)
        Dim p As Process = Process.Start(processPath)
        p.WaitForInputIdle()
        SetParent(p.MainWindowHandle, Handle)
    End Sub
#End Region 'Copy the region to make stuff work in other MDIs. Import System.Runtime.InteropServices where you put it!

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200
    Private Sub FullscreenPotato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Image.FromFile(GetCurrentWallpaper())
        OneSec_Tick()
        ' REMOVE BORDER FROM MDICLIENT
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next
        'Interface changes and coloring
        If My.Settings.UseOldPotatoFullscreenInterface = False Then
            MenuStrip1.Visible = False
            NewUITaskbar.Visible = True
            MainMenuStrip = TaskbarHelper
        Else
            NewUITaskbar.Height = 0
        End If
        MenuStrip1.BackColor = My.Settings.FullscreenPotatoTheme
        NewUITaskbar.BackColor = My.Settings.FullscreenPotatoTheme
        For Each item In MenuStrip1.Items
            item.ForeColor = My.Settings.FSPTaskText
        Next
    End Sub
    Private Function GetCurrentWallpaper() As String
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Return WallpaperPath
    End Function

    Public Minute As Integer
    Public Hour As Integer
    Public Year As Integer
    Public Day As Integer
    Public Month As Integer
    Public IsPm As Boolean = False
    Public IsPmLabel As String

    Private Sub OneSec_Tick() Handles OneSec.Tick
        'A second went by.
        'Set the time variables.
        Minute = Now.Minute
        'Set the minute to double numbers.
        If Minute < 10 Then
            Minute = "0" + Minute.ToString
        End If
        Hour = Now.Hour
        'Set the hour to 12-hour form.
        If My.Settings.TimeIs24Hours = False Then
            If Hour >= 12 Then
                Hour = Hour - 12
                IsPm = True
            Else
                IsPm = False
            End If
        End If
        Dim MinFix As String = Minute
        If Minute < 10 Then
            MinFix = "0" + Minute
        End If
        Year = Now.Year
        Day = Now.Day
        Month = Now.Month
        If My.Settings.TimeIs24Hours = False Then
            If IsPm Then
                IsPmLabel = " PM"
            Else
                IsPmLabel = " AM"
            End If
        Else
            IsPmLabel = ""
        End If
        'Update the time in the corner.
        CurrentTimeItem.Text = Hour.ToString + ":" + MinFix + IsPmLabel
        CurrentTimeItem.ToolTipText = Now.DayOfWeek.ToString + " " + Day.ToString + "/" + Month.ToString + "/" + Year.ToString
        NewUiTimeLabel.Text = Hour.ToString + ":" + MinFix + IsPmLabel
        DateToolTip.SetToolTip(NewUiTimeLabel, Now.DayOfWeek.ToString + " " + Day.ToString + "/" + Month.ToString + "/" + Year.ToString)
    End Sub 'One second elapsed. For refreshing stuff.

    Private Sub FileMgrItem_Click(sender As Object, e As EventArgs) Handles FileMgrItem.Click
        CallProcessMdi("explorer", "C:\Windows\explorer.exe")
    End Sub
    Private Sub PaintItem_Click(sender As Object, e As EventArgs) Handles PaintItem.Click
        CallProcessMdi("mspaint", "C:\Windows\System32\mspaint.exe")
    End Sub
    Private Sub NotepadItem_Click(sender As Object, e As EventArgs)
        CallProcessMdi("notepad", "C:\Windows\notepad.exe")
    End Sub
    Private Sub FireFoxOtherItem_Click(sender As Object, e As EventArgs) Handles FireFoxOtherItem.Click
        CallProcessMdi("firefox", System.IO.Directory.GetFiles("C:\Program Files*\", "firefox.exe").ToString())
    End Sub
    Private Sub ChromeOtherItem_Click(sender As Object, e As EventArgs) Handles ChromeOtherItem.Click
        CallProcessMdi("chrome", System.IO.Directory.GetFiles("C:\Program Files*\", "chrome.exe").ToString)
    End Sub
    Private Sub ExitItem_Click(sender As Object, e As EventArgs) Handles ExitItem.Click
        PotatoLaunch.Show()
        Me.Close()
    End Sub

    Private Sub PotatoWareToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PotatoWareToolStripMenuItem1.Click
        'I think I killed my potato
        PotatoManagement.LaunchMDI(PotatoLaunch, Me)
    End Sub

    Private Sub TroopPotatoSkullToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TroopPotatoSkullToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(PotatoSkul, Me)
    End Sub

    Private Sub PictureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PotatoManagement.LaunchMDI(PicView, Me)
    End Sub

    Private Sub StartToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.DropDownOpened
        StartToolStripMenuItem.Image = My.Resources.winlogo_colored
    End Sub
    Private Sub StartToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.DropDownClosed
        StartToolStripMenuItem.Image = My.Resources.winlogo
    End Sub

    Private Sub SmearedPotatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmearedPotatoToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(SmearedPotato, Me)
    End Sub

    Private Sub PictureViewerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PictureViewerToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(PicView, Me)
    End Sub

    Public Sub PotatoMenuOpen(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Add Potato Immersive Menu here.
        Dim x As Integer = (My.Computer.Screen.Bounds.Width - FullscreenPotatoMenu.Width) / 2
        Dim y As Integer = My.Computer.Screen.Bounds.Height - FullscreenPotatoMenu.Height - NewUITaskbar.Height
        FullscreenPotatoMenu.Reposition(x, y)
        PotatoManagement.LaunchMDI(FullscreenPotatoMenu, Me)
    End Sub
End Class '
Namespace MDITest

    Public Class MDIClientSupport

        Private Declare Function GetWindowLong Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer

        Private Declare Function SetWindowLong Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer

        Private Declare Function SetWindowPos Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Integer

        Private Const GWL_EXSTYLE As Integer = -20

        Private Const WS_EX_CLIENTEDGE As Integer = 512

        Private Const SWP_NOSIZE As UInteger = 1

        Private Const SWP_NOMOVE As UInteger = 2

        Private Const SWP_NOZORDER As UInteger = 4

        Private Const SWP_NOREDRAW As UInteger = 8

        Private Const SWP_NOACTIVATE As UInteger = 16

        Private Const SWP_FRAMECHANGED As UInteger = 32

        Private Const SWP_SHOWWINDOW As UInteger = 64

        Private Const SWP_HIDEWINDOW As UInteger = 128

        Private Const SWP_NOCOPYBITS As UInteger = 256

        Private Const SWP_NOOWNERZORDER As UInteger = 512

        Private Const SWP_NOSENDCHANGING As UInteger = 1024

        Public Shared Function SetBevel(ByVal form As Form, ByVal show As Boolean) As Boolean
            For Each c As Control In form.Controls
                Dim client As MdiClient = CType(c, MdiClient)
                If (Not (client) Is Nothing) Then
                    Dim windowLong As Integer = MDIClientSupport.GetWindowLong(c.Handle, GWL_EXSTYLE)
                    If show Then
                        windowLong = (windowLong Or WS_EX_CLIENTEDGE)
                    Else
                        windowLong &= WS_EX_CLIENTEDGE
                    End If

                    MDIClientSupport.SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                    ' Update the non-client area.
                    MDIClientSupport.SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0, (SWP_NOACTIVATE _
                                    Or (SWP_NOMOVE _
                                    Or (SWP_NOSIZE _
                                    Or (SWP_NOZORDER _
                                    Or (SWP_NOOWNERZORDER Or SWP_FRAMECHANGED))))))
                    Return True
                End If

            Next
            Return False
        End Function
    End Class
End Namespace