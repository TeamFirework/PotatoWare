Imports System.Net
Imports System.IO
Imports System.Text
Public Class ServiceForm
    Friend address As String
    Friend client As WebClient
    Friend TextRead As TextBox
    Private Sub Load_Event() Handles Me.Load
        PotatoLaunch.Hide()
        PotatoLaunch.ExitServiceModeToolStripMenuItem.Visible = True
        Dim Returned = PotatoManagement.WebTextReturn("http://bleonard252.firstcloudit.com/potato/event.txt")
        If My.Computer.Network.IsAvailable = False Then
            MessageBox.Show("Network is unavailable. Please try again later when you are connected to the Internet.", "PWISE Network Error")
            PotatoLaunch.Show()
            Hide()
        ElseIf Returned = "prepare" Then
            'This one should only be found here! This tells the ServiceTick to activate.
            ServiceTick.Enabled = True
            ServiceTick.Start()
        ElseIf Returned = "neo event" Then
            'This starts the Mettaton NEO event. In the Ticker, it will cause the ticker to stop ticking and then 1s later begin the event.
            neofight.Show()
        ElseIf Returned = "none" Or Returned = "no event" Then
            'No event is scheduled. Wait 1s, show PotatoLaunch, and return a popup message indicating there is no event.
            Threading.Thread.Sleep(900)
            PotatoLaunch.Show()
            Threading.Thread.Sleep(100)
            MessageBox.Show(caption:="PotatoWare Special Events", text:="There was no Special Event available.", icon:=MessageBoxIcon.Information, buttons:=MessageBoxButtons.OK)
        Else
            'Something surely went wrong. 
            Threading.Thread.Sleep(900)
            PotatoLaunch.Show()
            Threading.Thread.Sleep(100)
            Hide()
            MessageBox.Show(caption:="PotatoWare Special Events", text:="The Special Event information provider is returning invalid information. The host went down, you are not on the latest version of PotatoWare, or I messed up my data.", icon:=MessageBoxIcon.Error, buttons:=MessageBoxButtons.OK)
        End If
    End Sub
    Public Sub ServiceTick_Tick(sender As Object, e As EventArgs) Handles ServiceTick.Tick
        Dim Returned = PotatoManagement.WebTextReturn("http://bleonard252.firstcloudit.com/potato/event.txt")
        If Returned = "Disconnected from the Internet" Then
            ServiceTick.Enabled = False
            MessageBox.Show("You are no longer connected to the Internet.")
            Hide()
            Close()
        ElseIf Returned = "neo event" Then
            'This starts the Mettaton NEO event. In the Ticker, it will cause the ticker to stop ticking and then 1s later begin the event.
            ServiceTick.Enabled = False
            Threading.Thread.Sleep(900)
            neofight.Show()
            Hide()
        ElseIf Returned = "flora" Then
            'This starts the Flora screen upon accepting the gift. A window called "FloraEvent" will set off.
            ServiceTick.Enabled = False
            FloraEvent.Show()
        ElseIf Returned = "none" Or Returned = "no event" Then
            'No event is scheduled. Wait 1s, show PotatoLaunch, and return a popup message indicating there is no event.
            Threading.Thread.Sleep(900)
            PotatoLaunch.Show()
            Threading.Thread.Sleep(100)
            MessageBox.Show(caption:="PotatoWare Special Events", text:="The Special Event has concluded.", icon:=MessageBoxIcon.Information, buttons:=MessageBoxButtons.OK)
            ServiceTick.Enabled = False
            Hide()
        Else
            'Something surely went wrong. 
            Threading.Thread.Sleep(900)
            PotatoLaunch.Show()
            Threading.Thread.Sleep(100)
            ServiceTick.Enabled = False
            Hide()
            MessageBox.Show(caption:="PotatoWare Special Events", text:="The Special Event information provider is returning invalid information. The host went down, you are not on the latest version of PotatoWare, or I messed up my data.", icon:=MessageBoxIcon.Error, buttons:=MessageBoxButtons.OK)
            HelpBox.contentForHelp = "PotatoWare Error Help: {ERROR CODE: PWISE-SVC-INV-01} PotatoWare Integrated Special Event Service Error. Invalid Return. Expected Results: Host should return supported value. Actual Results: Host returned following text: " + Returned + " The service has been stopped. Please copy and paste this entire message and send it to facebook.com/bleonard252."
            HelpBox.Show() 'This one and the one above it are to help you! They're intended to return errors when you make oopsies and need to fix bugs.
        End If
    End Sub
    Public Sub Closig() Handles Me.FormClosing
        Dim potat = PotatoLaunch.ContextMenuStrip1.Items.IndexOfKey("Exit Service Mode")
        PotatoLaunch.ExitServiceModeToolStripMenuItem.Visible = False
    End Sub
End Class