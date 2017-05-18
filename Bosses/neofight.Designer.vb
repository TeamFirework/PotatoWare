<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class neofight
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FightButton = New System.Windows.Forms.Button()
        Me.ActButton = New System.Windows.Forms.Button()
        Me.ItemButton = New System.Windows.Forms.Button()
        Me.MercyButton = New System.Windows.Forms.Button()
        Me.BattleInfoText = New System.Windows.Forms.Label()
        Me.ActMenuDrop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BudgeActItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckActItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerName = New System.Windows.Forms.Label()
        Me.PlayerHPBar = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ActMenuDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PotatoWare.My.Resources.Resources.Mettaton_NEO
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.92738!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.07262!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(501, 358)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FightButton, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ActButton, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ItemButton, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.MercyButton, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BattleInfoText, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PlayerName, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PlayerHPBar, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 171)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.68998!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.31002!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(495, 184)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'FightButton
        '
        Me.FightButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FightButton.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FightButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FightButton.Location = New System.Drawing.Point(3, 136)
        Me.FightButton.Name = "FightButton"
        Me.FightButton.Size = New System.Drawing.Size(117, 45)
        Me.FightButton.TabIndex = 0
        Me.FightButton.Text = "Fight"
        Me.FightButton.UseVisualStyleBackColor = True
        '
        'ActButton
        '
        Me.ActButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActButton.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ActButton.Location = New System.Drawing.Point(126, 136)
        Me.ActButton.Name = "ActButton"
        Me.ActButton.Size = New System.Drawing.Size(117, 45)
        Me.ActButton.TabIndex = 1
        Me.ActButton.Text = "Act"
        Me.ActButton.UseVisualStyleBackColor = True
        '
        'ItemButton
        '
        Me.ItemButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemButton.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ItemButton.Location = New System.Drawing.Point(249, 136)
        Me.ItemButton.Name = "ItemButton"
        Me.ItemButton.Size = New System.Drawing.Size(117, 45)
        Me.ItemButton.TabIndex = 2
        Me.ItemButton.Text = "Item"
        Me.ItemButton.UseVisualStyleBackColor = True
        '
        'MercyButton
        '
        Me.MercyButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MercyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MercyButton.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MercyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MercyButton.Location = New System.Drawing.Point(372, 136)
        Me.MercyButton.Name = "MercyButton"
        Me.MercyButton.Size = New System.Drawing.Size(120, 45)
        Me.MercyButton.TabIndex = 3
        Me.MercyButton.Text = "Mercy"
        Me.MercyButton.UseVisualStyleBackColor = True
        '
        'BattleInfoText
        '
        Me.BattleInfoText.BackColor = System.Drawing.Color.Transparent
        Me.BattleInfoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel2.SetColumnSpan(Me.BattleInfoText, 4)
        Me.BattleInfoText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattleInfoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BattleInfoText.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BattleInfoText.ForeColor = System.Drawing.Color.White
        Me.BattleInfoText.Location = New System.Drawing.Point(3, 0)
        Me.BattleInfoText.Name = "BattleInfoText"
        Me.BattleInfoText.Size = New System.Drawing.Size(489, 105)
        Me.BattleInfoText.TabIndex = 4
        Me.BattleInfoText.Text = "* Mettaton NEO blocks the way!"
        '
        'ActMenuDrop
        '
        Me.ActMenuDrop.BackColor = System.Drawing.Color.Black
        Me.ActMenuDrop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BudgeActItem, Me.CheckActItem})
        Me.ActMenuDrop.Name = "ActMenuDrop"
        Me.ActMenuDrop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ActMenuDrop.ShowImageMargin = False
        Me.ActMenuDrop.Size = New System.Drawing.Size(98, 60)
        '
        'BudgeActItem
        '
        Me.BudgeActItem.BackColor = System.Drawing.Color.Black
        Me.BudgeActItem.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BudgeActItem.ForeColor = System.Drawing.Color.White
        Me.BudgeActItem.Name = "BudgeActItem"
        Me.BudgeActItem.Size = New System.Drawing.Size(97, 28)
        Me.BudgeActItem.Text = "Budge"
        Me.BudgeActItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BudgeActItem.ToolTipText = "Causes you to move slightly."
        '
        'CheckActItem
        '
        Me.CheckActItem.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckActItem.ForeColor = System.Drawing.Color.White
        Me.CheckActItem.Name = "CheckActItem"
        Me.CheckActItem.Size = New System.Drawing.Size(97, 28)
        Me.CheckActItem.Text = "Check"
        '
        'PlayerName
        '
        Me.PlayerName.AutoSize = True
        Me.PlayerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayerName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName.ForeColor = System.Drawing.Color.White
        Me.PlayerName.Location = New System.Drawing.Point(3, 105)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(117, 28)
        Me.PlayerName.TabIndex = 5
        Me.PlayerName.Text = "CHARAFRISK"
        Me.PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerHPBar
        '
        Me.PlayerHPBar.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.SetColumnSpan(Me.PlayerHPBar, 2)
        Me.PlayerHPBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayerHPBar.ForeColor = System.Drawing.Color.Gold
        Me.PlayerHPBar.Location = New System.Drawing.Point(126, 108)
        Me.PlayerHPBar.Maximum = 10000
        Me.PlayerHPBar.Name = "PlayerHPBar"
        Me.PlayerHPBar.Size = New System.Drawing.Size(240, 22)
        Me.PlayerHPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PlayerHPBar.TabIndex = 6
        Me.PlayerHPBar.Value = 1000
        '
        'neofight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(501, 358)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "neofight"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mettaton NEO Event"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ActMenuDrop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FightButton As Button
    Friend WithEvents ActButton As Button
    Friend WithEvents ItemButton As Button
    Friend WithEvents MercyButton As Button
    Friend WithEvents BattleInfoText As Label
    Friend WithEvents ActMenuDrop As ContextMenuStrip
    Friend WithEvents BudgeActItem As ToolStripMenuItem
    Friend WithEvents CheckActItem As ToolStripMenuItem
    Friend WithEvents PlayerName As Label
    Friend WithEvents PlayerHPBar As ProgressBar
End Class
