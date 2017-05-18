<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotificationCenter))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WindowCaption = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Label()
        Me.ReorgWindow = New System.Windows.Forms.PictureBox()
        Me.NotifDisplay = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorgWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WindowCaption, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExitButton, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MinimizeButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReorgWindow, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NotifDisplay, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(295, 303)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PotatoWare.My.Resources.Resources.apple_purpleAnimated1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WindowCaption
        '
        Me.WindowCaption.AutoSize = True
        Me.WindowCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowCaption.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.WindowCaption.Location = New System.Drawing.Point(28, 0)
        Me.WindowCaption.Name = "WindowCaption"
        Me.WindowCaption.Size = New System.Drawing.Size(204, 27)
        Me.WindowCaption.TabIndex = 1
        Me.WindowCaption.Text = "Notification Center" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double-click to remove"
        Me.WindowCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExitButton
        '
        Me.ExitButton.AutoSize = True
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ExitButton.Location = New System.Drawing.Point(278, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(14, 27)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "X"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinimizeButton
        '
        Me.MinimizeButton.AutoSize = True
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MinimizeButton.Location = New System.Drawing.Point(238, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(14, 27)
        Me.MinimizeButton.TabIndex = 3
        Me.MinimizeButton.Text = "_"
        Me.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReorgWindow
        '
        Me.ReorgWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReorgWindow.Image = Global.PotatoWare.My.Resources.Resources.maximise
        Me.ReorgWindow.Location = New System.Drawing.Point(258, 3)
        Me.ReorgWindow.Name = "ReorgWindow"
        Me.ReorgWindow.Size = New System.Drawing.Size(14, 21)
        Me.ReorgWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ReorgWindow.TabIndex = 4
        Me.ReorgWindow.TabStop = False
        '
        'NotifDisplay
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NotifDisplay, 5)
        Me.NotifDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotifDisplay.FormattingEnabled = True
        Me.NotifDisplay.Location = New System.Drawing.Point(3, 30)
        Me.NotifDisplay.Name = "NotifDisplay"
        Me.NotifDisplay.Size = New System.Drawing.Size(289, 270)
        Me.NotifDisplay.TabIndex = 5
        '
        'NotificationCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(295, 303)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotificationCenter"
        Me.Text = "Notification Center - Double-click to remove"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorgWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WindowCaption As Label
    Friend WithEvents ExitButton As Label
    Friend WithEvents MinimizeButton As Label
    Friend WithEvents ReorgWindow As PictureBox
    Friend WithEvents NotifDisplay As ListBox
End Class
