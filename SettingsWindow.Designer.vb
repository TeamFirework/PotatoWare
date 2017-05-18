<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsWindow))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UseOldInterfaceSetting = New System.Windows.Forms.CheckBox()
        Me.FullscreenPotatoThemeColorButton = New System.Windows.Forms.Button()
        Me.TaskText_Panel = New System.Windows.Forms.GroupBox()
        Me.TaskTextRadio_Black = New System.Windows.Forms.RadioButton()
        Me.TaskTextRadio_White = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PotatoWare_SettingOrganizer = New System.Windows.Forms.FlowLayoutPanel()
        Me.PW_Use24Hr = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.ColorSelector = New System.Windows.Forms.ColorDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TaskText_Panel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.PotatoWare_SettingOrganizer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(3, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(316, 302)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(308, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Potato Desktop"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.UseOldInterfaceSetting)
        Me.FlowLayoutPanel1.Controls.Add(Me.FullscreenPotatoThemeColorButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskText_Panel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(302, 270)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'UseOldInterfaceSetting
        '
        Me.UseOldInterfaceSetting.AutoSize = True
        Me.UseOldInterfaceSetting.Checked = True
        Me.UseOldInterfaceSetting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseOldInterfaceSetting.Location = New System.Drawing.Point(3, 3)
        Me.UseOldInterfaceSetting.Name = "UseOldInterfaceSetting"
        Me.UseOldInterfaceSetting.Size = New System.Drawing.Size(152, 17)
        Me.UseOldInterfaceSetting.TabIndex = 1
        Me.UseOldInterfaceSetting.Text = "Use Old PotatoDesktop UI"
        Me.UseOldInterfaceSetting.UseVisualStyleBackColor = True
        '
        'FullscreenPotatoThemeColorButton
        '
        Me.FullscreenPotatoThemeColorButton.Location = New System.Drawing.Point(161, 3)
        Me.FullscreenPotatoThemeColorButton.Name = "FullscreenPotatoThemeColorButton"
        Me.FullscreenPotatoThemeColorButton.Size = New System.Drawing.Size(72, 29)
        Me.FullscreenPotatoThemeColorButton.TabIndex = 2
        Me.FullscreenPotatoThemeColorButton.Text = "Colors"
        Me.FullscreenPotatoThemeColorButton.UseVisualStyleBackColor = True
        '
        'TaskText_Panel
        '
        Me.TaskText_Panel.Controls.Add(Me.TaskTextRadio_Black)
        Me.TaskText_Panel.Controls.Add(Me.TaskTextRadio_White)
        Me.TaskText_Panel.Location = New System.Drawing.Point(3, 38)
        Me.TaskText_Panel.Name = "TaskText_Panel"
        Me.TaskText_Panel.Size = New System.Drawing.Size(132, 54)
        Me.TaskText_Panel.TabIndex = 4
        Me.TaskText_Panel.TabStop = False
        Me.TaskText_Panel.Text = "Taskbar Text Color"
        '
        'TaskTextRadio_Black
        '
        Me.TaskTextRadio_Black.AutoSize = True
        Me.TaskTextRadio_Black.Checked = True
        Me.TaskTextRadio_Black.Location = New System.Drawing.Point(65, 19)
        Me.TaskTextRadio_Black.Name = "TaskTextRadio_Black"
        Me.TaskTextRadio_Black.Size = New System.Drawing.Size(52, 17)
        Me.TaskTextRadio_Black.TabIndex = 4
        Me.TaskTextRadio_Black.TabStop = True
        Me.TaskTextRadio_Black.Text = "Black"
        Me.TaskTextRadio_Black.UseVisualStyleBackColor = True
        '
        'TaskTextRadio_White
        '
        Me.TaskTextRadio_White.AutoSize = True
        Me.TaskTextRadio_White.Location = New System.Drawing.Point(6, 19)
        Me.TaskTextRadio_White.Name = "TaskTextRadio_White"
        Me.TaskTextRadio_White.Size = New System.Drawing.Size(53, 17)
        Me.TaskTextRadio_White.TabIndex = 3
        Me.TaskTextRadio_White.Text = "White"
        Me.TaskTextRadio_White.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PotatoWare_SettingOrganizer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(308, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PotatoWare"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PotatoWare_SettingOrganizer
        '
        Me.PotatoWare_SettingOrganizer.Controls.Add(Me.PW_Use24Hr)
        Me.PotatoWare_SettingOrganizer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PotatoWare_SettingOrganizer.Location = New System.Drawing.Point(3, 3)
        Me.PotatoWare_SettingOrganizer.Name = "PotatoWare_SettingOrganizer"
        Me.PotatoWare_SettingOrganizer.Size = New System.Drawing.Size(302, 270)
        Me.PotatoWare_SettingOrganizer.TabIndex = 0
        '
        'PW_Use24Hr
        '
        Me.PW_Use24Hr.AutoSize = True
        Me.PW_Use24Hr.Location = New System.Drawing.Point(3, 3)
        Me.PW_Use24Hr.Name = "PW_Use24Hr"
        Me.PW_Use24Hr.Size = New System.Drawing.Size(122, 17)
        Me.PW_Use24Hr.TabIndex = 0
        Me.PW_Use24Hr.Text = "Use 24-hour format?"
        Me.PW_Use24Hr.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PotatoWare Settings"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExitButton, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(322, 328)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PotatoWare.My.Resources.Resources.winsettings_white
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.AutoSize = True
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(305, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(14, 20)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "X"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(322, 328)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsWindow"
        Me.Text = "PotatoWare Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TaskText_Panel.ResumeLayout(False)
        Me.TaskText_Panel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.PotatoWare_SettingOrganizer.ResumeLayout(False)
        Me.PotatoWare_SettingOrganizer.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PotatoWare_SettingOrganizer As FlowLayoutPanel
    Friend WithEvents PW_Use24Hr As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitButton As Label
    Friend WithEvents UseOldInterfaceSetting As CheckBox
    Friend WithEvents FullscreenPotatoThemeColorButton As Button
    Friend WithEvents ColorSelector As ColorDialog
    Friend WithEvents TaskText_Panel As GroupBox
    Friend WithEvents TaskTextRadio_Black As RadioButton
    Friend WithEvents TaskTextRadio_White As RadioButton
End Class
