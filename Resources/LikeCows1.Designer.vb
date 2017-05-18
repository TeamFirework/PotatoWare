<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LikeCows1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LikeCows1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.OopsLabel = New System.Windows.Forms.Label()
        Me.OopsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(12, 78)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(65, 22)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(202, 77)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(70, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Enabled = False
        Me.btnFinish.Location = New System.Drawing.Point(132, 77)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(64, 23)
        Me.btnFinish.TabIndex = 3
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'OopsLabel
        '
        Me.OopsLabel.AutoSize = True
        Me.OopsLabel.ForeColor = System.Drawing.Color.Red
        Me.OopsLabel.Location = New System.Drawing.Point(68, 65)
        Me.OopsLabel.Name = "OopsLabel"
        Me.OopsLabel.Size = New System.Drawing.Size(128, 13)
        Me.OopsLabel.TabIndex = 4
        Me.OopsLabel.Text = "Oops! Can't click that yet."
        Me.OopsLabel.Visible = False
        '
        'OopsTimer
        '
        Me.OopsTimer.Interval = 1000
        '
        'LikeCows1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 102)
        Me.Controls.Add(Me.OopsLabel)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LikeCows1"
        Me.ShowInTaskbar = False
        Me.Text = "Baked PotatoWare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents OopsLabel As Label
    Friend WithEvents OopsTimer As Timer
End Class
