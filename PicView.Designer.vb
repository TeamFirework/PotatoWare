<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PicView
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrevPicNav = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FilePathLabel = New System.Windows.Forms.Label()
        Me.PictureArea = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EtcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EtcMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PrevPicNav, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FilePathLabel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureArea, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.07026!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92974!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 260)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PrevPicNav
        '
        Me.PrevPicNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrevPicNav.Location = New System.Drawing.Point(3, 234)
        Me.PrevPicNav.Name = "PrevPicNav"
        Me.PrevPicNav.Size = New System.Drawing.Size(26, 23)
        Me.PrevPicNav.TabIndex = 1
        Me.PrevPicNav.Text = "<-"
        Me.PrevPicNav.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(291, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FilePathLabel
        '
        Me.FilePathLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilePathLabel.AutoSize = True
        Me.FilePathLabel.Location = New System.Drawing.Point(35, 231)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(250, 29)
        Me.FilePathLabel.TabIndex = 3
        Me.FilePathLabel.Text = "Empty"
        Me.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureArea
        '
        Me.PictureArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureArea.ErrorImage = Global.PotatoWare.My.Resources.Resources.potato_skull
        Me.PictureArea.InitialImage = Global.PotatoWare.My.Resources.Resources.winlogo
        Me.PictureArea.Location = New System.Drawing.Point(35, 3)
        Me.PictureArea.Name = "PictureArea"
        Me.PictureArea.Size = New System.Drawing.Size(250, 225)
        Me.PictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureArea.TabIndex = 0
        Me.PictureArea.TabStop = False
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 22)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EtcMenu
        '
        Me.EtcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadImageToolStripMenuItem})
        Me.EtcMenu.Name = "ContextMenuStrip1"
        Me.EtcMenu.Size = New System.Drawing.Size(137, 26)
        '
        'LoadImageToolStripMenuItem
        '
        Me.LoadImageToolStripMenuItem.Name = "LoadImageToolStripMenuItem"
        Me.LoadImageToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LoadImageToolStripMenuItem.Text = "Load Image"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "PNG Images (*.png)|*.png|JPG and JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmaps and GI" &
    "Fs (*.bmp, *.gif)|*.bmp;*.gif|All Images (PNG, JPG, JPEG, BMP, GIF)|*.png;*.jpg;" &
    "*.jpeg;*.bmp;*.gif|All Files (*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\%username\"
        '
        'PicView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 260)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = Global.PotatoWare.My.Resources.Resources.potato
        Me.Name = "PicView"
        Me.Text = "Picture Viewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EtcMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureArea As PictureBox
    Friend WithEvents PrevPicNav As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FilePathLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents EtcMenu As ContextMenuStrip
    Friend WithEvents LoadImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
