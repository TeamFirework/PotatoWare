<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class neoattack_guessing
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
        Me.Backpan = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Backpan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Backpan
        '
        Me.Backpan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Backpan.Controls.Add(Me.Button3)
        Me.Backpan.Controls.Add(Me.Button2)
        Me.Backpan.Controls.Add(Me.Button1)
        Me.Backpan.Controls.Add(Me.Label1)
        Me.Backpan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Backpan.Location = New System.Drawing.Point(0, 0)
        Me.Backpan.Name = "Backpan"
        Me.Backpan.Size = New System.Drawing.Size(275, 275)
        Me.Backpan.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(145, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(78, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(10, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your life depends on your choice." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No pressure."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'neoattack_guessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(275, 275)
        Me.Controls.Add(Me.Backpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "neoattack_guessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mettaton NEO"
        Me.Backpan.ResumeLayout(False)
        Me.Backpan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Backpan As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
