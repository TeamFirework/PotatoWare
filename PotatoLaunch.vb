Imports System.Runtime.InteropServices
Public Class PotatoLaunch
    'Below is the Data Directory. Use when needed.
    ''' <summary>
    ''' Gets the directory where data is stored.
    ''' Value contains the final backslash.
    ''' </summary>
    Shared ReadOnly DataDirectory = "C:\ProgramData\PotatoWare"
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On PotatoWare load, do the following...
        ChiveIconChanger()
        PotatoManagement.ArgCheck()
        PotatoManagement.URLCheck()
        PotatoManagement.checkAppUpdates()
        ' ____________________________________________________________________________________
        If My.Application.CommandLineArgs.Contains("--debug") Then
            DebugOptionsToolStripMenuItem.Visible = True
        End If
        If (My.Application.CommandLineArgs.Contains("--launch desktop") Or My.Application.CommandLineArgs.Contains("--launch fullscreen")) Then
            Me.Hide()
            FullscreenPotato.Show()
        End If
        ' ------------------------------------------------------------------------------------
#Region "Modular imports"
        If File.Exists(DataDirectory + "\modular.dll") Then
            Dim modular As New DllImportAttribute(DataDirectory + "\modular.dll")
            'ModularHandler. 'ModularHandler not created yet!
        Else
            'OK, Nothing special here. Oooooooop!
        End If
#End Region

        ' ====================================================================================
    End Sub
    Private Sub ChiveIconChanger()
        If My.Settings.ChivesIcon = 0 Then
            Icon = My.Resources.potato
        End If
        If My.Settings.ChivesIcon = 1 Then
            Icon = My.Resources.apple_golden
        End If
        If My.Settings.ChivesIcon = 2 Then
            Icon = My.Resources.apple_blue
        End If
        If My.Settings.ChivesIcon = 3 Then
            Icon = My.Resources.potato_baked
        End If
        If My.Settings.ChivesIcon = 4 Then
            Icon = My.Resources.potato_poisonous
        End If
        If My.Settings.ChivesIcon = 5 Then
            Icon = My.Resources.potato_skull1
        End If
        If My.Settings.ChivesIcon > 5 Then
            My.Settings.ChivesIcon = 0
            Icon = My.Resources.potato
        End If
    End Sub
    Public Sub SKULLMENUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SKULLMENUToolStripMenuItem.Click
#Region "Help Content: Skull Menu"
        HelpBox.contentForHelp =
"The Skull Menu features a lot of cool stuff!
They're all community requested jokes that I implemented as so.
For any help on an individual Skull Menu item, hover over it for a second.
If you need any help on anything else, just go look for it!"
#End Region
        HelpBox.Show()
    End Sub
    Private Sub HamAndEggsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HamAndEggsToolStripMenuItem.Click
        'Initiate Operation SourCream and Chives!
        If My.Settings.ChivesIcon = 0 Then
            MessageBox.Show("Smearing sour cream and chives on the potato turned it into an apple...?")
        End If
        My.Settings.ChivesIcon = My.Settings.ChivesIcon + 1
        ChiveIconChanger()
    End Sub
    ''' <remarks>
    ''' Notes On Stuff Go Here!
    ''' 
    ''' </remarks>
    Public Sub AppWhatIsToolmenuItem_Click(sender As Object, e As EventArgs) Handles AppWhatIsToolmenuItem.Click
#Region "Help Content: What is PotatoWare?"
        HelpBox.contentForHelp = "PotatoWare is an application that contains a lot of features.
You can call it a central application for your computer. If you have any requests, find my latest posts on Facebook.
It is very easy to use, take a poke around the menus given and hover your mouse cursor over anything you need help with.
If you want some more help with PotatoWare, go through the section of the Help drop-down menu and find what you need help with."
#End Region
        HelpBox.Show()
    End Sub
    Private Sub PotatoDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PotatoDesktopToolStripMenuItem.Click
        FullscreenPotato.Show()
        Me.Close()
    End Sub
    Private Sub SpecialEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialEventsToolStripMenuItem.Click
        Dim EventWin As New ServiceForm
        PotatoManagement.LaunchMDI(EventWin, Me)
    End Sub

    'Hover texts.
#Region ""
    Private Sub FileMenu_MouseEnter(sender As Object, e As EventArgs) Handles FileMenu.MouseEnter
        ToolStripStatusLabel1.ForeColor = Color.Gray
        ToolStripStatusLabel1.Text = "*dust*"
    End Sub
    Private Sub FileMenu_MouseLeave(sender As Object, e As EventArgs) Handles FileMenu.MouseLeave
        ToolStripStatusLabel1.ForeColor = Color.Black
        ToolStripStatusLabel1.Text = "Ready"
    End Sub
    '[==== ABOVE: FILE MENU; BELOW: SKULL MENU ====]
    Private Sub SkullMenu_MouseEnter(sender As Object, e As EventArgs) Handles SKULLMENUToolStripMenuItem.MouseEnter
        ToolStripStatusLabel1.Text = "Contains items of interest"
    End Sub
    Private Sub SkullMenu_MouseLeave(sender As Object, e As EventArgs) Handles SKULLMENUToolStripMenuItem.MouseLeave
        ToolStripStatusLabel1.Text = "Ready"
    End Sub
    '[==== ABOVE: SKULL MENU; BELOW: APPS MENU ====]
    Private Sub AppsMenu_MouseEnter() Handles AppsToolStripMenuItem.MouseEnter
        ToolStripStatusLabel1.Text = "Contains applications part of PotatoWare"
    End Sub
    Private Sub AppsMenu_MouseLeave() Handles AppsToolStripMenuItem.MouseLeave
        ToolStripStatusLabel1.Text = "Ready"
    End Sub
    '[==== ABOVE: APPS MENU; BELOW: SMEAREDPOTATO ====]
    Private Sub SmearedPotatoToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles SmearedPotatoToolStripMenuItem.MouseEnter
        ToolStripStatusLabel1.Text = "SmearedPotato: Pretty Much Notepad"
    End Sub
    Private Sub SmearedPotatoToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles SmearedPotatoToolStripMenuItem.MouseLeave
        ToolStripStatusLabel1.Text = "Ready"
    End Sub





    Private Sub EyeOfCthulhuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EyeOfCthulhuToolStripMenuItem.Click
        'Test battle.
        'ServiceForm.Show()
        'Special Event dependency removed along with Eye of Cthulhu event. Notify developer.
        MessageBox.Show(caption:="PotatoWare Error", text:="Reminder: As the Special Event dependency was removed, the Eye event went out with it.\nThis is no longer usable.")
    End Sub

    Private Sub BossBattlesToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles BossBattlesToolStripMenuItem.MouseEnter
        ToolStripStatusLabel1.Text = "Coming Soon: Boss Battles and Vs."
    End Sub
    Private Sub BossBattlesToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles BossBattlesToolStripMenuItem.MouseLeave
        ToolStripStatusLabel1.Text = "Ready"
    End Sub


#End Region

    Private Sub SettingsItem_Click(sender As Object, e As EventArgs) Handles SettingsItem.Click
        SettingsWindow.ShowDialog(Me)
    End Sub

    Private Sub PictureViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureViewerToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(PicView, Me)
    End Sub

    Private Sub PotatoSkullTroop_BattleLauncher_Click(sender As Object, e As EventArgs) Handles PotatoSkullTroop_BattleLauncher.Click
        PotatoManagement.LaunchMDI(PotatoSkul, Me)
    End Sub

    Private Sub SmearedPotatoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PotatoManagement.LaunchMDI(SmearedPotato, Me)
    End Sub

    Private Sub NotificationCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationCenterToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(NotificationCenter, Me)
    End Sub

    Private Sub TestNotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestNotificationToolStripMenuItem.Click
        PotatoManagement.Notify(InputBox("Notification Content...", "PotatoWare Debugger"))
    End Sub

    Private Sub DebugMetNeoItem_Click(sender As Object, e As EventArgs) Handles DebugMetNeoItem.Click
        neofight.Show()
    End Sub

    Private Sub ExitServiceModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitServiceModeToolStripMenuItem.Click
        ServiceForm.Close()
        Show()
    End Sub

    Private Sub SmearedPotatoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SmearedPotatoToolStripMenuItem.Click
        PotatoManagement.LaunchMDI(SmearedPotato, Me)
    End Sub

    Private Sub KeywordSearch_KeyPress(sender As Object, e As KeyEventArgs) Handles KeywordSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            PotatoManagement.ProcessKeywordSearch(KeywordSearch.Text)
        End If
    End Sub
End Class

' Is Extendable: Yes
' Is Weathering: No
' Is Wet: No
' Can Be Wet: No
' Is Hot: No
' Can Be Hot: No
' ... Checking system. State good.
'   --> Is Extendable
'   --> Can not be hot
'   --> Can not be wet
Public Class PotatoManagement
    Shared CurrentVersion As String = "0.1.0"
    Shared Function vers()
        Return CurrentVersion
    End Function
    Shared Sub LaunchMDI(MdiChildForm As Form, MdiParentForm As Form)
        Dim MdiWindow As Form = MdiChildForm
        MdiWindow.MdiParent = MdiParentForm
        Try
            MdiChildForm.Show()
        Catch ex As Exception
            'Nothing.
        End Try
    End Sub
    Shared Sub ProcessKeywordSearch(keyword As String)
        'No keywords.
    End Sub
    Public Class DWM
        Public Sub Composit()
            ' Getting the code, please wait...
        End Sub
    End Class
    Shared Function WebTextReturn(address As String)
        If My.Computer.Network.IsAvailable Then
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Return reader.ReadToEnd
        Else
            Return "Disconnected from the Internet"
        End If
    End Function
    Shared Sub checkAppUpdates()
        Dim Version As String = WebTextReturn("http://bleonard252.firstcloudit.com/potato/version.txt")
        If My.Computer.Network.IsAvailable Then
            If Version = CurrentVersion Then
                'Nothing. Up to date.
            ElseIf Version.Contains(vbCrLf) Then
                'Multiline documents are invalid.
                MessageBox.Show("You do not have access to the update server at this time.")
            Else
                'Prompt the user to update.
                'TODO: add custom form
                If MessageBox.Show("A new update is available for PotatoWare. Current version: " + CurrentVersion + " Update: " + Version + " OK = Update?", "PotatoWare", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    Process.Start("https://mega.nz/#F!tx1zUbbK!UtFWv5YJ8y_eVT0XEqnHhg")
                    PotatoLaunch.Close()
                End If
            End If
        End If
    End Sub

    Shared Vor As New TextBox
    Shared Sub Notify(ntfic As String, Optional doPopup As Boolean = False)
        If doPopup Then
            MessageBox.Show(caption:="PotatoWare Notification", text:=ntfic)
        End If
        My.Settings.NotificationGrid.Add(ntfic)
    End Sub
End Class
Public Class D
End Class
''' <summary>
'''  Creates A Glass Interface.
''' </summary>
''' <remarks></remarks>
Friend Class Glass_Full
    Private Const DTT_COMPOSITED As Integer = CInt((1 << 13))
    Private Const DTT_GLOWSIZE As Integer = CInt((1 << 11))

    'Text format consts
    Private Const DT_SINGLELINE As Integer = &H20
    Private Const DT_CENTER As Integer = &H1
    Private Const DT_VCENTER As Integer = &H4
    Private Const DT_NOPREFIX As Integer = &H800

    'Const for BitBlt
    Private Const SRCCOPY As Integer = &HCC0020


    'Consts for CreateDIBSection
    Private Const BI_RGB As Integer = 0
    Private Const DIB_RGB_COLORS As Integer = 0
    'color table in RGBs
    Private Structure MARGINS
        Public m_Left As Integer
        Public m_Right As Integer
        Public m_Top As Integer
        Public m_Buttom As Integer
    End Structure

    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    Private Structure DTTOPTS
        Public dwSize As UInteger
        Public dwFlags As UInteger
        Public crText As UInteger
        Public crBorder As UInteger
        Public crShadow As UInteger
        Public iTextShadowType As Integer
        Public ptShadowOffset As POINTAPI
        Public iBorderSize As Integer
        Public iFontPropId As Integer
        Public iColorPropId As Integer
        Public iStateId As Integer
        Public fApplyOverlay As Integer
        Public iGlowSize As Integer
        Public pfnDrawTextCallback As IntPtr
        Public lParam As Integer
    End Structure

    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer


    End Structure

    Private Structure BITMAPINFOHEADER
        Public biSize As Integer
        Public biWidth As Integer
        Public biHeight As Integer
        Public biPlanes As Short
        Public biBitCount As Short
        Public biCompression As Integer
        Public biSizeImage As Integer
        Public biXPelsPerMeter As Integer
        Public biYPelsPerMeter As Integer
        Public biClrUsed As Integer
        Public biClrImportant As Integer
    End Structure

    Private Structure RGBQUAD
        Public rgbBlue As Byte
        Public rgbGreen As Byte
        Public rgbRed As Byte
        Public rgbReserved As Byte
    End Structure

    Private Structure BITMAPINFO
        Public bmiHeader As BITMAPINFOHEADER
        Public bmiColors As RGBQUAD
    End Structure


    'API declares
    <DllImport("dwmapi.dll")>
    Private Shared Sub DwmIsCompositionEnabled(ByRef enabledptr As Integer)
    End Sub
    <DllImport("dwmapi.dll")>
    Private Shared Sub DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef margin As MARGINS)
    End Sub


    Private Declare Auto Function GetDC Lib "user32.dll" (ByVal hdc As IntPtr) As IntPtr
    Private Declare Auto Function SaveDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Integer
    Private Declare Auto Function ReleaseDC Lib "user32.dll" (ByVal hdc As IntPtr, ByVal state As Integer) As Integer
    Private Declare Auto Function CreateCompatibleDC Lib "gdi32.dll" (ByVal hDC As IntPtr) As IntPtr
    <DllImport("gdi32.dll", ExactSpelling:=True)>
    Private Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
    End Function
    Private Declare Auto Function DeleteObject Lib "gdi32.dll" (ByVal hObject As IntPtr) As Boolean
    Private Declare Auto Function DeleteDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Boolean
    <DllImport("gdi32.dll")>
    Private Shared Function BitBlt(ByVal hdc As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr,
     ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As UInteger) As Boolean
    End Function

    Private Declare Unicode Function DrawThemeTextEx Lib "UxTheme.dll" (ByVal hTheme As IntPtr, ByVal hdc As IntPtr, ByVal iPartId As Integer, ByVal iStateId As Integer, ByVal text As String, ByVal iCharCount As Integer,
     ByVal dwFlags As Integer, ByRef pRect As RECT, ByRef pOptions As DTTOPTS) As Integer
    Private Declare Auto Function DrawThemeText Lib "UxTheme.dll" (ByVal hTheme As IntPtr, ByVal hdc As IntPtr, ByVal iPartId As Integer, ByVal iStateId As Integer, ByVal text As String, ByVal iCharCount As Integer,
     ByVal dwFlags1 As Integer, ByVal dwFlags2 As Integer, ByRef pRect As RECT) As Integer
    Private Declare Auto Function CreateDIBSection Lib "gdi32.dll" (ByVal hdc As IntPtr, ByRef pbmi As BITMAPINFO, ByVal iUsage As UInteger, ByVal ppvBits As Integer, ByVal hSection As IntPtr, ByVal dwOffset As UInteger) As IntPtr

    Shared Sub SetGlass(ByVal Form As Form)
        Dim en As Integer = 0
        Dim mg As New MARGINS()
        mg.m_Buttom = -1
        mg.m_Left = -1
        mg.m_Right = -1
        mg.m_Top = -1
        'make sure you are not on a legacy OS 
        If System.Environment.OSVersion.Version.Major >= 6 Then
            DwmIsCompositionEnabled(en)
            'check if the desktop composition is enabled
            If en > 0 Then
                DwmExtendFrameIntoClientArea(Form.Handle, mg)
            Else
                Throw New ApplicationException("This computer does not have the areo interface enabled.")
            End If
        Else
            Throw New ApplicationException("This computer does not have the areo theme capibility.")
        End If
    End Sub

    Private Function IsCompositionEnabled() As Boolean

        If Environment.OSVersion.Version.Major < 6 Then
            Return False
        End If

        Dim compositionEnabled As Integer = 0
        DwmIsCompositionEnabled(compositionEnabled)
        If compositionEnabled > 0 Then
            Return True
        Else
            Return False


        End If
    End Function

    Public Sub FillBlackRegion(ByVal gph As Graphics, ByVal rgn As Rectangle)
        Dim rc As New RECT()
        rc.left = rgn.Left
        rc.right = rgn.Right
        rc.top = rgn.Top
        rc.bottom = rgn.Bottom

        Dim destdc As IntPtr = gph.GetHdc()
        'hwnd must be the handle of form,not control
        Dim Memdc As IntPtr = CreateCompatibleDC(destdc)
        Dim bitmap As IntPtr
        Dim bitmapOld As IntPtr = IntPtr.Zero

        Dim dib As New BITMAPINFO()
        dib.bmiHeader.biHeight = -(rc.bottom - rc.top)
        dib.bmiHeader.biWidth = rc.right - rc.left
        dib.bmiHeader.biPlanes = 1
        dib.bmiHeader.biSize = Marshal.SizeOf(GetType(BITMAPINFOHEADER))
        dib.bmiHeader.biBitCount = 32
        dib.bmiHeader.biCompression = BI_RGB
        If Not (SaveDC(Memdc) = 0) Then
            bitmap = CreateDIBSection(Memdc, dib, DIB_RGB_COLORS, 0, IntPtr.Zero, 0)
            If Not (bitmap = IntPtr.Zero) Then
                bitmapOld = SelectObject(Memdc, bitmap)

                BitBlt(destdc, rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top, Memdc,
                 0, 0, SRCCOPY)
            End If

            'Remember to clean up
            SelectObject(Memdc, bitmapOld)

            DeleteObject(bitmap)

            ReleaseDC(Memdc, -1)


            DeleteDC(Memdc)
        End If

        gph.ReleaseHdc()
    End Sub

    Public Sub DrawTextOnGlass(ByVal hwnd As IntPtr, ByVal text As [String], ByVal font As Font, ByVal ctlrct As Rectangle, ByVal iglowSize As Integer)
        If IsCompositionEnabled() Then
            Dim rc As New RECT()
            Dim rc2 As New RECT()

            rc.left = ctlrct.Left
            rc.right = ctlrct.Right + 2 * iglowSize
            'make it larger to contain the glow effect
            rc.top = ctlrct.Top
            rc.bottom = ctlrct.Bottom + 2 * iglowSize

            'Just the same rect with rc,but (0,0) at the lefttop
            rc2.left = 0
            rc2.top = 0
            rc2.right = rc.right - rc.left
            rc2.bottom = rc.bottom - rc.top

            Dim destdc As IntPtr = GetDC(hwnd)
            'hwnd must be the handle of form,not control
            Dim Memdc As IntPtr = CreateCompatibleDC(destdc)
            ' Set up a memory DC where we'll draw the text.
            Dim bitmap As IntPtr
            Dim bitmapOld As IntPtr = IntPtr.Zero
            Dim logfnotOld As IntPtr

            Dim uFormat As Integer = DT_SINGLELINE Or DT_CENTER Or DT_VCENTER Or DT_NOPREFIX
            'text format
            Dim dib As New BITMAPINFO()
            dib.bmiHeader.biHeight = -(rc.bottom - rc.top)
            ' negative because DrawThemeTextEx() uses a top-down DIB
            dib.bmiHeader.biWidth = rc.right - rc.left
            dib.bmiHeader.biPlanes = 1
            dib.bmiHeader.biSize = Marshal.SizeOf(GetType(BITMAPINFOHEADER))
            dib.bmiHeader.biBitCount = 32
            dib.bmiHeader.biCompression = BI_RGB
            If Not (SaveDC(Memdc) = 0) Then
                bitmap = CreateDIBSection(Memdc, dib, DIB_RGB_COLORS, 0, IntPtr.Zero, 0)
                ' Create a 32-bit bmp for use in offscreen drawing when glass is on
                If Not (bitmap = IntPtr.Zero) Then
                    bitmapOld = SelectObject(Memdc, bitmap)
                    Dim hFont As IntPtr = font.ToHfont()
                    logfnotOld = SelectObject(Memdc, hFont)
                    Try

                        Dim renderer As New System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.Caption.Active)

                        Dim dttOpts As New DTTOPTS()

                        dttOpts.dwSize = CUInt(Marshal.SizeOf(GetType(DTTOPTS)))

                        dttOpts.dwFlags = DTT_COMPOSITED Or DTT_GLOWSIZE


                        dttOpts.iGlowSize = iglowSize

                        DrawThemeTextEx(renderer.Handle, Memdc, 0, 0, text, -1,
                         uFormat, rc2, dttOpts)

                        BitBlt(destdc, rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top, Memdc,
                         0, 0, SRCCOPY)
                    Catch e As Exception
                        Trace.WriteLine(e.Message)
                    End Try

                    'Remember to clean up
                    SelectObject(Memdc, bitmapOld)
                    SelectObject(Memdc, logfnotOld)
                    DeleteObject(bitmap)
                    DeleteObject(hFont)

                    ReleaseDC(Memdc, -1)

                    DeleteDC(Memdc)

                End If

            End If

        End If
    End Sub
End Class