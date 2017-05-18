<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullscreenPotato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullscreenPotato))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemExtend = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireFoxOtherItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChromeOtherItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PdnOtherItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotatoWareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotatoWareToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BossesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroopPotatoSkullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMgrItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmearedPotatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaintItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentTimeItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneSec = New System.Windows.Forms.Timer(Me.components)
        Me.FileManager = New System.Windows.Forms.OpenFileDialog()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.NewUITaskbar = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NewUiTimeLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TaskbarHelper = New System.Windows.Forms.MenuStrip()
        Me.CurrentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.NewUITaskbar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskbarHelper.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.CurrentToolStripMenuItem, Me.CurrentTimeItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 420)
        Me.MenuStrip1.MdiWindowListItem = Me.CurrentToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemExtend, Me.PotatoWareToolStripMenuItem, Me.FileMgrItem, Me.PaintItem, Me.ExitItem})
        Me.StartToolStripMenuItem.Image = Global.PotatoWare.My.Resources.Resources.winlogo
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ItemExtend
        '
        Me.ItemExtend.BackColor = System.Drawing.Color.MediumBlue
        Me.ItemExtend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FireFoxOtherItem, Me.ChromeOtherItem, Me.PdnOtherItem})
        Me.ItemExtend.Enabled = False
        Me.ItemExtend.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ItemExtend.Name = "ItemExtend"
        Me.ItemExtend.Size = New System.Drawing.Size(176, 22)
        Me.ItemExtend.Text = "Other Programs..."
        Me.ItemExtend.ToolTipText = "To change their directories, go to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PotatoWare -> Help -> Settings ->" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Potato De" &
    "sktop -> Program Directories"
        Me.ItemExtend.Visible = False
        '
        'FireFoxOtherItem
        '
        Me.FireFoxOtherItem.BackColor = System.Drawing.Color.MediumBlue
        Me.FireFoxOtherItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FireFoxOtherItem.Name = "FireFoxOtherItem"
        Me.FireFoxOtherItem.Size = New System.Drawing.Size(121, 22)
        Me.FireFoxOtherItem.Text = "Firefox"
        Me.FireFoxOtherItem.Visible = False
        '
        'ChromeOtherItem
        '
        Me.ChromeOtherItem.BackColor = System.Drawing.Color.MediumBlue
        Me.ChromeOtherItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ChromeOtherItem.Name = "ChromeOtherItem"
        Me.ChromeOtherItem.Size = New System.Drawing.Size(121, 22)
        Me.ChromeOtherItem.Text = "Chrome"
        Me.ChromeOtherItem.Visible = False
        '
        'PdnOtherItem
        '
        Me.PdnOtherItem.BackColor = System.Drawing.Color.MediumBlue
        Me.PdnOtherItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PdnOtherItem.Name = "PdnOtherItem"
        Me.PdnOtherItem.Size = New System.Drawing.Size(121, 22)
        Me.PdnOtherItem.Text = "Paint.net"
        Me.PdnOtherItem.Visible = False
        '
        'PotatoWareToolStripMenuItem
        '
        Me.PotatoWareToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue
        Me.PotatoWareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PotatoWareToolStripMenuItem1, Me.BossesToolStripMenuItem})
        Me.PotatoWareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PotatoWareToolStripMenuItem.Image = Global.PotatoWare.My.Resources.Resources.potatoimg
        Me.PotatoWareToolStripMenuItem.Name = "PotatoWareToolStripMenuItem"
        Me.PotatoWareToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PotatoWareToolStripMenuItem.Text = "PotatoWare"
        '
        'PotatoWareToolStripMenuItem1
        '
        Me.PotatoWareToolStripMenuItem1.BackColor = System.Drawing.Color.Lime
        Me.PotatoWareToolStripMenuItem1.Enabled = False
        Me.PotatoWareToolStripMenuItem1.Name = "PotatoWareToolStripMenuItem1"
        Me.PotatoWareToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.PotatoWareToolStripMenuItem1.Text = "PotatoWare"
        '
        'BossesToolStripMenuItem
        '
        Me.BossesToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.BossesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TroopPotatoSkullToolStripMenuItem})
        Me.BossesToolStripMenuItem.Name = "BossesToolStripMenuItem"
        Me.BossesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BossesToolStripMenuItem.Text = "Bosses"
        '
        'TroopPotatoSkullToolStripMenuItem
        '
        Me.TroopPotatoSkullToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.TroopPotatoSkullToolStripMenuItem.Name = "TroopPotatoSkullToolStripMenuItem"
        Me.TroopPotatoSkullToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TroopPotatoSkullToolStripMenuItem.Text = "Troop: Potato Skull"
        '
        'FileMgrItem
        '
        Me.FileMgrItem.BackColor = System.Drawing.Color.MediumBlue
        Me.FileMgrItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmearedPotatoToolStripMenuItem, Me.PictureViewerToolStripMenuItem})
        Me.FileMgrItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FileMgrItem.Name = "FileMgrItem"
        Me.FileMgrItem.Size = New System.Drawing.Size(176, 22)
        Me.FileMgrItem.Text = "File Manager"
        '
        'SmearedPotatoToolStripMenuItem
        '
        Me.SmearedPotatoToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.SmearedPotatoToolStripMenuItem.Name = "SmearedPotatoToolStripMenuItem"
        Me.SmearedPotatoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SmearedPotatoToolStripMenuItem.Text = "SmearedPotato"
        '
        'PictureViewerToolStripMenuItem
        '
        Me.PictureViewerToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.PictureViewerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PictureViewerToolStripMenuItem.Name = "PictureViewerToolStripMenuItem"
        Me.PictureViewerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PictureViewerToolStripMenuItem.Text = "Picture Viewer"
        '
        'PaintItem
        '
        Me.PaintItem.BackColor = System.Drawing.Color.MediumBlue
        Me.PaintItem.Enabled = False
        Me.PaintItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PaintItem.Image = Global.PotatoWare.My.Resources.Resources.paint_icon
        Me.PaintItem.Name = "PaintItem"
        Me.PaintItem.Size = New System.Drawing.Size(176, 22)
        Me.PaintItem.Text = "Paint"
        Me.PaintItem.Visible = False
        '
        'ExitItem
        '
        Me.ExitItem.BackColor = System.Drawing.Color.MediumBlue
        Me.ExitItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ExitItem.Name = "ExitItem"
        Me.ExitItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitItem.Text = "Exit Potato Desktop"
        '
        'CurrentToolStripMenuItem
        '
        Me.CurrentToolStripMenuItem.Name = "CurrentToolStripMenuItem"
        Me.CurrentToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.CurrentToolStripMenuItem.Text = "Current"
        '
        'CurrentTimeItem
        '
        Me.CurrentTimeItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CurrentTimeItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationCenterToolStripMenuItem, Me.CalendarToolStripMenuItem})
        Me.CurrentTimeItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentTimeItem.Name = "CurrentTimeItem"
        Me.CurrentTimeItem.Size = New System.Drawing.Size(65, 20)
        Me.CurrentTimeItem.Text = "12:00AM"
        '
        'NotificationCenterToolStripMenuItem
        '
        Me.NotificationCenterToolStripMenuItem.Image = Global.PotatoWare.My.Resources.Resources.apple_purpleAnimated1
        Me.NotificationCenterToolStripMenuItem.Name = "NotificationCenterToolStripMenuItem"
        Me.NotificationCenterToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NotificationCenterToolStripMenuItem.Text = "Notification Center"
        '
        'CalendarToolStripMenuItem
        '
        Me.CalendarToolStripMenuItem.Enabled = False
        Me.CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem"
        Me.CalendarToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CalendarToolStripMenuItem.Text = "Calendar"
        '
        'OneSec
        '
        Me.OneSec.Enabled = True
        Me.OneSec.Interval = 1000
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "RibbonTab1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Text = "RibbonPanel1"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Text = "RibbonTab2"
        '
        'NewUITaskbar
        '
        Me.NewUITaskbar.BackColor = System.Drawing.Color.Transparent
        Me.NewUITaskbar.Controls.Add(Me.TableLayoutPanel1)
        Me.NewUITaskbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NewUITaskbar.Location = New System.Drawing.Point(0, 373)
        Me.NewUITaskbar.Name = "NewUITaskbar"
        Me.NewUITaskbar.Size = New System.Drawing.Size(521, 47)
        Me.NewUITaskbar.TabIndex = 2
        Me.NewUITaskbar.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NewUiTimeLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TaskbarHelper, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(521, 47)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NewUiTimeLabel
        '
        Me.NewUiTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewUiTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUiTimeLabel.Location = New System.Drawing.Point(424, 0)
        Me.NewUiTimeLabel.Name = "NewUiTimeLabel"
        Me.NewUiTimeLabel.Size = New System.Drawing.Size(94, 47)
        Me.NewUiTimeLabel.TabIndex = 0
        Me.NewUiTimeLabel.Text = "12:00 AM"
        Me.NewUiTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DateToolTip.SetToolTip(Me.NewUiTimeLabel, "1/1/1987")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PotatoWare.My.Resources.Resources.potatoimg
        Me.PictureBox1.Location = New System.Drawing.Point(103, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TaskbarHelper
        '
        Me.TaskbarHelper.AutoSize = False
        Me.TaskbarHelper.BackColor = System.Drawing.Color.Transparent
        Me.TaskbarHelper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskbarHelper.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentToolStripMenuItem1})
        Me.TaskbarHelper.Location = New System.Drawing.Point(0, 0)
        Me.TaskbarHelper.MdiWindowListItem = Me.CurrentToolStripMenuItem1
        Me.TaskbarHelper.Name = "TaskbarHelper"
        Me.TaskbarHelper.Size = New System.Drawing.Size(100, 47)
        Me.TaskbarHelper.TabIndex = 2
        Me.TaskbarHelper.Text = "MenuStrip2"
        '
        'CurrentToolStripMenuItem1
        '
        Me.CurrentToolStripMenuItem1.Name = "CurrentToolStripMenuItem1"
        Me.CurrentToolStripMenuItem1.Size = New System.Drawing.Size(48, 43)
        Me.CurrentToolStripMenuItem1.Text = "Open"
        '
        'FullscreenPotato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.NewUITaskbar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FullscreenPotato"
        Me.Text = "Potato Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.NewUITaskbar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskbarHelper.ResumeLayout(False)
        Me.TaskbarHelper.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitItem As ToolStripMenuItem
    Friend WithEvents PaintItem As ToolStripMenuItem
    Friend WithEvents ItemExtend As ToolStripMenuItem
    Friend WithEvents FireFoxOtherItem As ToolStripMenuItem
    Friend WithEvents ChromeOtherItem As ToolStripMenuItem
    Friend WithEvents PdnOtherItem As ToolStripMenuItem
    Friend WithEvents CurrentTimeItem As ToolStripMenuItem
    Friend WithEvents OneSec As Timer
    Friend WithEvents FileMgrItem As ToolStripMenuItem
    Friend WithEvents PotatoWareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PotatoWareToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BossesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TroopPotatoSkullToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileManager As OpenFileDialog
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents SmearedPotatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificationCenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUITaskbar As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NewUiTimeLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateToolTip As ToolTip
    Friend WithEvents TaskbarHelper As MenuStrip
    Friend WithEvents CurrentToolStripMenuItem1 As ToolStripMenuItem
End Class
