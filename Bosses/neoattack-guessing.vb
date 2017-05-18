Public Class neoattack_guessing
    Private DodgeButton As Integer
    Private Sub neoattack_guessing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RndGen = New Random
        DodgeButton = RndGen.Next(1, 4)
    End Sub
    Private Sub doDamage(Button As Integer)
        If Button = DodgeButton Then
            'Avoided the attack.
            neofight.ReturnVal = "avoid"
            Close()
        Else
            'Attack hit.
            neofight.ReturnVal = "hit"
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doDamage(1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        doDamage(2)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        doDamage(3)
    End Sub
End Class