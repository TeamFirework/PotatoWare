Public Class PotatoSkul
    Private PlayerPP As Integer = 0
    Private TroopPP As Integer = 0
    ''' <summary>
    ''' Deals damage in a battle.
    ''' </summary>
    ''' <param name="Target">0 for Player, 1 for Opponent. Who to deal damage to.</param>
    ''' <param name="Amount">How much damage to deal.</param>
    Private Sub dealDamage(Target As Integer, Amount As Integer)
        If Target = 1 Then 'Target 1 is Opponent
            Try
                TroopHP.Value = TroopHP.Value - Amount
            Catch
                TroopHP.Value = 0
            End Try
        ElseIf Target = 0 Then 'Target 0 is Player
            Try
                PlayerHP.Value = PlayerHP.Value - Amount
            Catch
                PlayerHP.Value = 0
            End Try
        End If
        damageCheck()
    End Sub
    ''' <summary>
    ''' Checks the damage dealt and changes the color of the bar accordingly.
    ''' </summary>
    Private Sub damageCheck()
        'Check Player HP after damage is dealt.
        If PlayerHP.Value <= 0 Then
            PotatoManagement.Notify(Date.Now + " :: You lost to troop PotatoSkull.", True)
            Me.Close()
        ElseIf PlayerHP.Value < 11 Then
            PlayerHP.ForeColor = Color.Red
        ElseIf PlayerHP.Value < 51 Then
            PlayerHP.ForeColor = Color.Yellow
        Else
            PlayerHP.ForeColor = Color.Green
        End If
        'Check Power Points.
        PIayerPP.Text = PlayerPP.ToString() + " PP"
        'Check Troop HP after damage is dealt.
        If TroopHP.Value <= 0 Then
            PotatoManagement.Notify(Date.Now + " :: You won against troop PotatoSkull.", True)
            Me.Close()
        ElseIf TroopHP.Value < 11 Then
            TroopHP.ForeColor = Color.Red
        ElseIf TroopHP.Value < 51 Then
            TroopHP.ForeColor = Color.Yellow
        Else
            TroopHP.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Move1Btn_Click(sender As Object, e As EventArgs) Handles Move1Btn.Click
        If PlayerPP >= 10 Then
            PlayerPP = PlayerPP - 10
            dealDamage(1, 20)
        End If
        TroopAI_Move()
    End Sub
    Private Sub Move2Btn_Click(sender As Object, e As EventArgs) Handles Move2Btn.Click
        PlayerPP = PlayerPP + 5
        dealDamage(1, 10)
        TroopAI_Move()
    End Sub
    Private Sub Move3Btn_Click(sender As Object, e As EventArgs) Handles Move3Btn.Click
        If PlayerPP >= 20 Then
            PlayerPP = PlayerPP - 20
            If PlayerHP.Value >= 50 Then
                PlayerHP.Value = 100
            Else
                PlayerHP.Value = PlayerHP.Value + 20
            End If
        End If
        TroopAI_Move()
    End Sub
    Private Sub Move4Btn_Click(sender As Object, e As EventArgs) Handles Move4Btn.Click
        If PlayerPP >= 50 Then
            Player.Image = My.Resources.winlogo_colored
            PlayerPP = PlayerPP - 50
            dealDamage(1, 75)
        End If
        TroopAI_Move()
    End Sub

    Dim RandomValue As Integer
    Dim RndGen As System.Random = New System.Random
    Private Sub TroopAI_Move()
        RandomValue = RndGen.Next(0, 4)
        If RandomValue = 0 Then 'Sweep Swipe
            dealDamage(0, 10)
            TroopPP = TroopPP + 5
        ElseIf RandomValue = 1 Then 'High Kick
            dealDamage(0, 15)
        ElseIf RandomValue = 2 Then 'Uncover
            dealDamage(0, 5)
        ElseIf RandomValue = 3 Then 'Spatial Rend
            If TroopPP = 10 Then
                dealDamage(0, 20)
            End If
        Else
            Throw New FieldAccessException("Value was not 0, 1, 2, or 3")
        End If
    End Sub

    Private Sub PotatoSkul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player.Image = PotatoWare.My.Resources.winlogo
        PlayerHP.Value = 100
        TroopHP.Value = 100
        PlayerPP = 0
        TroopPP = 0
        If My.Application.CommandLineArgs.Contains("--debug") Then
            Button1.Visible = True
        End If
    End Sub

#Region "Debug tools"
    Private Sub SetHundredPwr_Click(sender As Object, e As EventArgs) Handles SetHundredPwr.Click
        PlayerPP = 100
        PIayerPP.Text = PlayerPP.ToString() + " PP"
    End Sub
    Private Sub SetNoPwr_Click(sender As Object, e As EventArgs) Handles SetNoPwr.Click
        PlayerPP = 0
        PIayerPP.Text = PlayerPP.ToString() + " PP"
    End Sub
    Private Sub FilledHealth_Click(sender As Object, e As EventArgs) Handles FilledHealth.Click
        PlayerHP.Value = 100
    End Sub
    Private Sub HalfHealth_Click(sender As Object, e As EventArgs) Handles HalfHealth.Click
        PlayerHP.Value = 50
    End Sub
    Private Sub OneHealth_Click(sender As Object, e As EventArgs) Handles OneHealth.Click
        PlayerHP.Value = 1
    End Sub
    Private Sub TroopHeal_Click(sender As Object, e As EventArgs) Handles TroopHeal.Click
        TroopHP.Value = 100
    End Sub
    Private Sub TroopResetPP_Click(sender As Object, e As EventArgs) Handles TroopResetPP.Click
        TroopPP = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DebugTools.Show(Button1.Location)
    End Sub

    Private Sub DebugTools_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DebugTools.Opening

    End Sub
#End Region
End Class