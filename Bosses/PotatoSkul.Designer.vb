<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PotatoSkul
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PotatoSkul))
        Me.TroopSkul = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.PlayerHP = New System.Windows.Forms.ProgressBar()
        Me.TroopHP = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Move1Btn = New System.Windows.Forms.Button()
        Me.Move2Btn = New System.Windows.Forms.Button()
        Me.Move3Btn = New System.Windows.Forms.Button()
        Me.Move4Btn = New System.Windows.Forms.Button()
        Me.PIayerPP = New System.Windows.Forms.Label()
        Me.DebugTools = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PowerPointsModifier1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetHundredPwr = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetNoPwr = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealthModifier1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilledHealth = New System.Windows.Forms.ToolStripMenuItem()
        Me.HalfHealth = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneHealth = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroopHeal = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroopResetPP = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TroopSkul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.DebugTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'TroopSkul
        '
        Me.TroopSkul.Image = Global.PotatoWare.My.Resources.Resources.potato_skul_lg
        Me.TroopSkul.Location = New System.Drawing.Point(172, 12)
        Me.TroopSkul.Name = "TroopSkul"
        Me.TroopSkul.Size = New System.Drawing.Size(103, 105)
        Me.TroopSkul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TroopSkul.TabIndex = 0
        Me.TroopSkul.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.PotatoWare.My.Resources.Resources.winlogo
        Me.Player.Location = New System.Drawing.Point(12, 12)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(103, 105)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 1
        Me.Player.TabStop = False
        '
        'PlayerHP
        '
        Me.PlayerHP.Location = New System.Drawing.Point(12, 123)
        Me.PlayerHP.Name = "PlayerHP"
        Me.PlayerHP.Size = New System.Drawing.Size(103, 15)
        Me.PlayerHP.TabIndex = 2
        Me.PlayerHP.Value = 100
        '
        'TroopHP
        '
        Me.TroopHP.Location = New System.Drawing.Point(172, 123)
        Me.TroopHP.Name = "TroopHP"
        Me.TroopHP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TroopHP.RightToLeftLayout = True
        Me.TroopHP.Size = New System.Drawing.Size(103, 15)
        Me.TroopHP.TabIndex = 3
        Me.TroopHP.Value = 100
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Move1Btn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Move2Btn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Move3Btn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Move4Btn, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 149)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(263, 100)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Move1Btn
        '
        Me.Move1Btn.BackColor = System.Drawing.Color.Red
        Me.Move1Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Move1Btn.Location = New System.Drawing.Point(3, 3)
        Me.Move1Btn.Name = "Move1Btn"
        Me.Move1Btn.Size = New System.Drawing.Size(125, 44)
        Me.Move1Btn.TabIndex = 0
        Me.Move1Btn.Text = "High Kick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10 PP"
        Me.Move1Btn.UseVisualStyleBackColor = False
        '
        'Move2Btn
        '
        Me.Move2Btn.BackColor = System.Drawing.Color.Green
        Me.Move2Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Move2Btn.Location = New System.Drawing.Point(134, 3)
        Me.Move2Btn.Name = "Move2Btn"
        Me.Move2Btn.Size = New System.Drawing.Size(126, 44)
        Me.Move2Btn.TabIndex = 1
        Me.Move2Btn.Text = "Sweep Swipe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 PP"
        Me.Move2Btn.UseVisualStyleBackColor = False
        '
        'Move3Btn
        '
        Me.Move3Btn.BackColor = System.Drawing.Color.Blue
        Me.Move3Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Move3Btn.Location = New System.Drawing.Point(3, 53)
        Me.Move3Btn.Name = "Move3Btn"
        Me.Move3Btn.Size = New System.Drawing.Size(125, 44)
        Me.Move3Btn.TabIndex = 2
        Me.Move3Btn.Text = "Recover" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20 PP"
        Me.Move3Btn.UseVisualStyleBackColor = False
        '
        'Move4Btn
        '
        Me.Move4Btn.BackColor = System.Drawing.Color.Yellow
        Me.Move4Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Move4Btn.Location = New System.Drawing.Point(134, 53)
        Me.Move4Btn.Name = "Move4Btn"
        Me.Move4Btn.Size = New System.Drawing.Size(126, 44)
        Me.Move4Btn.TabIndex = 3
        Me.Move4Btn.Text = "Power Punch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50 PP"
        Me.Move4Btn.UseVisualStyleBackColor = False
        '
        'PIayerPP
        '
        Me.PIayerPP.AutoSize = True
        Me.PIayerPP.Location = New System.Drawing.Point(12, 104)
        Me.PIayerPP.Name = "PIayerPP"
        Me.PIayerPP.Size = New System.Drawing.Size(30, 13)
        Me.PIayerPP.TabIndex = 5
        Me.PIayerPP.Text = "0 PP"
        '
        'DebugTools
        '
        Me.DebugTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowerPointsModifier1, Me.HealthModifier1, Me.TroopHeal, Me.TroopResetPP})
        Me.DebugTools.Name = "DebugTools"
        Me.DebugTools.Size = New System.Drawing.Size(156, 114)
        Me.DebugTools.Text = "Debug Tools"
        '
        'PowerPointsModifier1
        '
        Me.PowerPointsModifier1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetHundredPwr, Me.SetNoPwr})
        Me.PowerPointsModifier1.Name = "PowerPointsModifier1"
        Me.PowerPointsModifier1.Size = New System.Drawing.Size(155, 22)
        Me.PowerPointsModifier1.Text = "PP Mod"
        '
        'SetHundredPwr
        '
        Me.SetHundredPwr.Name = "SetHundredPwr"
        Me.SetHundredPwr.Size = New System.Drawing.Size(109, 22)
        Me.SetHundredPwr.Text = "100 PP"
        '
        'SetNoPwr
        '
        Me.SetNoPwr.Name = "SetNoPwr"
        Me.SetNoPwr.Size = New System.Drawing.Size(109, 22)
        Me.SetNoPwr.Text = "0 PP"
        '
        'HealthModifier1
        '
        Me.HealthModifier1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilledHealth, Me.HalfHealth, Me.OneHealth})
        Me.HealthModifier1.Name = "HealthModifier1"
        Me.HealthModifier1.Size = New System.Drawing.Size(155, 22)
        Me.HealthModifier1.Text = "HP Mod"
        '
        'FilledHealth
        '
        Me.FilledHealth.Name = "FilledHealth"
        Me.FilledHealth.Size = New System.Drawing.Size(111, 22)
        Me.FilledHealth.Text = "100 HP"
        '
        'HalfHealth
        '
        Me.HalfHealth.Name = "HalfHealth"
        Me.HalfHealth.Size = New System.Drawing.Size(111, 22)
        Me.HalfHealth.Text = "50 HP"
        '
        'OneHealth
        '
        Me.OneHealth.Name = "OneHealth"
        Me.OneHealth.Size = New System.Drawing.Size(111, 22)
        Me.OneHealth.Text = "1 HP"
        '
        'TroopHeal
        '
        Me.TroopHeal.Name = "TroopHeal"
        Me.TroopHeal.Size = New System.Drawing.Size(155, 22)
        Me.TroopHeal.Text = "Heal Opponent"
        '
        'TroopResetPP
        '
        Me.TroopResetPP.Name = "TroopResetPP"
        Me.TroopResetPP.Size = New System.Drawing.Size(155, 22)
        Me.TroopResetPP.Text = "Reset Troop PP"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumPurple
        Me.Button1.Image = Global.PotatoWare.My.Resources.Resources.apple_purpleAnimated1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(113, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 22)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Debug"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PotatoSkul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PIayerPP)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TroopHP)
        Me.Controls.Add(Me.PlayerHP)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.TroopSkul)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PotatoSkul"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Troop: Potato Skull"
        CType(Me.TroopSkul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.DebugTools.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TroopSkul As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents PlayerHP As ProgressBar
    Friend WithEvents TroopHP As ProgressBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Move1Btn As Button
    Friend WithEvents Move2Btn As Button
    Friend WithEvents Move3Btn As Button
    Friend WithEvents Move4Btn As Button
    Friend WithEvents PIayerPP As Label
    Friend WithEvents DebugTools As ContextMenuStrip
    Friend WithEvents PowerPointsModifier1 As ToolStripMenuItem
    Friend WithEvents SetHundredPwr As ToolStripMenuItem
    Friend WithEvents SetNoPwr As ToolStripMenuItem
    Friend WithEvents HealthModifier1 As ToolStripMenuItem
    Friend WithEvents FilledHealth As ToolStripMenuItem
    Friend WithEvents HalfHealth As ToolStripMenuItem
    Friend WithEvents OneHealth As ToolStripMenuItem
    Friend WithEvents TroopHeal As ToolStripMenuItem
    Friend WithEvents TroopResetPP As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
