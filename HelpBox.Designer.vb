<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpBox))
        Me.HelpContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HelpContent
        '
        Me.HelpContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpContent.Location = New System.Drawing.Point(0, 0)
        Me.HelpContent.Multiline = True
        Me.HelpContent.Name = "HelpContent"
        Me.HelpContent.ReadOnly = True
        Me.HelpContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpContent.Size = New System.Drawing.Size(515, 386)
        Me.HelpContent.TabIndex = 0
        '
        'HelpBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 386)
        Me.Controls.Add(Me.HelpContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpBox"
        Me.Text = "PotatoWare Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpContent As TextBox
End Class
