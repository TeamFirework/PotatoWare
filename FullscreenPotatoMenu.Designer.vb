<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullscreenPotatoMenu
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
        Me.FSPMHeader = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PotatoWareSettingsCue = New System.Windows.Forms.Button()
        Me.NotifiCue = New System.Windows.Forms.Button()
        Me.ExitFullscreen = New System.Windows.Forms.Button()
        Me.OpenAppsCue = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.AppList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BossBattlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BossBattlesItem_TroopPotatoSkullItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.AppList.SuspendLayout()
        Me.SuspendLayout()
        '
        'FSPMHeader
        '
        Me.FSPMHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.FSPMHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSPMHeader.Image = Global.PotatoWare.My.Resources.Resources.potato_bakedimg
        Me.FSPMHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FSPMHeader.Location = New System.Drawing.Point(0, 0)
        Me.FSPMHeader.Name = "FSPMHeader"
        Me.FSPMHeader.Size = New System.Drawing.Size(254, 35)
        Me.FSPMHeader.TabIndex = 0
        Me.FSPMHeader.Text = "PotatoDesktop Menu   "
        Me.FSPMHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PotatoWareSettingsCue)
        Me.FlowLayoutPanel1.Controls.Add(Me.NotifiCue)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExitFullscreen)
        Me.FlowLayoutPanel1.Controls.Add(Me.OpenAppsCue)
        Me.FlowLayoutPanel1.Controls.Add(Me.Back)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 35)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(254, 252)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PotatoWareSettingsCue
        '
        Me.PotatoWareSettingsCue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PotatoWareSettingsCue.Image = Global.PotatoWare.My.Resources.Resources.potatoimg
        Me.PotatoWareSettingsCue.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PotatoWareSettingsCue.Location = New System.Drawing.Point(3, 3)
        Me.PotatoWareSettingsCue.Name = "PotatoWareSettingsCue"
        Me.PotatoWareSettingsCue.Size = New System.Drawing.Size(130, 27)
        Me.PotatoWareSettingsCue.TabIndex = 0
        Me.PotatoWareSettingsCue.Text = "PotatoWare Settings"
        Me.PotatoWareSettingsCue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PotatoWareSettingsCue.UseVisualStyleBackColor = True
        '
        'NotifiCue
        '
        Me.NotifiCue.Image = Global.PotatoWare.My.Resources.Resources.apple_purpleAnimated1
        Me.NotifiCue.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.NotifiCue.Location = New System.Drawing.Point(139, 3)
        Me.NotifiCue.Name = "NotifiCue"
        Me.NotifiCue.Size = New System.Drawing.Size(93, 27)
        Me.NotifiCue.TabIndex = 1
        Me.NotifiCue.Text = "Notifications"
        Me.NotifiCue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NotifiCue.UseVisualStyleBackColor = True
        '
        'ExitFullscreen
        '
        Me.ExitFullscreen.Location = New System.Drawing.Point(3, 36)
        Me.ExitFullscreen.Name = "ExitFullscreen"
        Me.ExitFullscreen.Size = New System.Drawing.Size(136, 28)
        Me.ExitFullscreen.TabIndex = 2
        Me.ExitFullscreen.Text = "Exit PotatoWare Desktop"
        Me.ExitFullscreen.UseVisualStyleBackColor = True
        '
        'OpenAppsCue
        '
        Me.OpenAppsCue.Image = Global.PotatoWare.My.Resources.Resources.potatoimg
        Me.OpenAppsCue.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OpenAppsCue.Location = New System.Drawing.Point(145, 36)
        Me.OpenAppsCue.Name = "OpenAppsCue"
        Me.OpenAppsCue.Size = New System.Drawing.Size(75, 28)
        Me.OpenAppsCue.TabIndex = 3
        Me.OpenAppsCue.Text = "Apps"
        Me.OpenAppsCue.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(3, 70)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(50, 28)
        Me.Back.TabIndex = 4
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'AppList
        '
        Me.AppList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BossBattlesToolStripMenuItem})
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(137, 26)
        Me.AppList.Text = "Apps"
        '
        'BossBattlesToolStripMenuItem
        '
        Me.BossBattlesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BossBattlesItem_TroopPotatoSkullItem})
        Me.BossBattlesToolStripMenuItem.Name = "BossBattlesToolStripMenuItem"
        Me.BossBattlesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BossBattlesToolStripMenuItem.Text = "Boss Battles"
        '
        'BossBattlesItem_TroopPotatoSkullItem
        '
        Me.BossBattlesItem_TroopPotatoSkullItem.Name = "BossBattlesItem_TroopPotatoSkullItem"
        Me.BossBattlesItem_TroopPotatoSkullItem.Size = New System.Drawing.Size(168, 22)
        Me.BossBattlesItem_TroopPotatoSkullItem.Text = "Troop PotatoSkull"
        '
        'FullscreenPotatoMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(254, 287)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FSPMHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FullscreenPotatoMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PotatoWare"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.AppList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FSPMHeader As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PotatoWareSettingsCue As Button
    Friend WithEvents NotifiCue As Button
    Friend WithEvents ExitFullscreen As Button
    Friend WithEvents OpenAppsCue As Button
    Friend WithEvents AppList As ContextMenuStrip
    Friend WithEvents BossBattlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BossBattlesItem_TroopPotatoSkullItem As ToolStripMenuItem
    Friend WithEvents Back As Button
End Class
