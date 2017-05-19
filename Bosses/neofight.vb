Public Class neofight
    Private PlayerHP As Integer
    Private EnemyHP As Integer
    Private PlayerMomentum As Integer
    Public ReturnVal As String
    Private RandVal As Integer
    Dim RndGen As Random = New Random
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Sub neofight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.potato 'First let's fix the icon.
        'Aaah, sneaking around my code I see.
        'And what do we do with snoopers?
        'We give them our code.
        'But not really. This is just Visual Basic code designed to create a special event for Mettaton NEO.
        'This isn't even all of this event's coding, either: there's the launch mechanism, implemented in PotatoLaunch.vb.
        PlayerHP = 10000
        EnemyHP = 30000
        PlayerMomentum = 0
        My.Computer.Audio.Play(My.Resources.neo, AudioPlayMode.BackgroundLoop) 'Then as the initialization finishes, begin the BGM. This does play regardless of the Music setting.
        PlayerHPBar.Value = PlayerHP
        If RndGen.Next(0, 2) = 0 Then
            PlayerName.Text = "Chara"
        Else
            PlayerName.Text = "Frisk"
        End If
        SendMessage(PlayerHPBar.Handle, 1040, 3, 0)
    End Sub
    Private Sub FightButton_Click(sender As Object, e As EventArgs) Handles FightButton.Click
        'Generate attack. Deals between 750 and 900 damage (Both inclusive).
        RandVal = RndGen.Next(750, 901)
        Dim doMissInt As Integer
        doMissInt = RndGen.Next(0, 6)
        If doMissInt = 0 Then
            'Attack misses.
            sayBattle("* Missed!", 1)
            Refresh()
            Threading.Thread.Sleep(1000)
        Else
            'Attack lands.
            EnemyHP = EnemyHP - RandVal 'Subtract enemy health from damage.
        End If
        'Have the enemy attack you back. You can avoid it.
        doRetaliate()
        HPCalc()
    End Sub
    Private Sub sayBattle(phrase As String, Optional type As Integer = 0)
        If type = 1 Then
            'All at once.
            BattleInfoText.Text = phrase
        ElseIf type = 2 Then
            'Slow type.
            BattleInfoText.Text = ""
            For Each character In phrase
                'Give it a little time to add.
                Refresh()
                Threading.Thread.Sleep(750)
                'Add it to the box.
                BattleInfoText.Text = BattleInfoText.Text + character
            Next
        ElseIf type = 3 Then
            'A cry for mercy which will not be given to Mettaton NEO.
            'At the point that this one will be called, the battle is almost over.
            BattleInfoText.Text = ""
            For Each character In phrase
                'Give it a little time to add.
                Refresh()
                Threading.Thread.Sleep(1000)
                'Add it to the box.
                BattleInfoText.Text = BattleInfoText.Text + character
            Next
        Else
            'Normal.
            BattleInfoText.Text = ""
            For Each character In phrase
                'Give it a little time to add.
                Refresh()
                Threading.Thread.Sleep(50)
                'Add it to the box.
                BattleInfoText.Text = BattleInfoText.Text + character
            Next
        End If
    End Sub
    Private Sub doRetaliate()
        'You just attacked. Which attack should we use?
        RandVal = RndGen.Next(0, 2)
        If RandVal = 0 Then
            sayBattle("* Let's play Russian Roulette!")
            Refresh()
            Threading.Thread.Sleep(1000)
            PlayerHP = PlayerHP - RndGen.Next(785, 971)
            sayBattle("* Damage was dealt by Mettaton NEO.", 1)
            Refresh()
            Threading.Thread.Sleep(500)
        ElseIf RandVal = 1 Then
            neoattack_guessing.ShowDialog(Me)
            If ReturnVal = "avoid" Then
                'Attack missed.
                sayBattle("* Mettaton NEO missed!", 1)
                Refresh()
                Threading.Thread.Sleep(1500)
                sayBattle("* Mettaton NEO dealt recoil damage!", 1)
                Refresh()
                Threading.Thread.Sleep(1500)
                EnemyHP = EnemyHP - RndGen.Next(675, 951)
            ElseIf ReturnVal = "hit" Then
                sayBattle("* Mettaton NEO attacked.", 1)
                Refresh()
                Threading.Thread.Sleep(1500)
                PlayerHP = PlayerHP - RndGen.Next(675, 951)
            End If
        End If
        sayBattle("* Mettaton NEO blocks the way!", 1)
    End Sub
    Private HasCriedMercy As Boolean
    Private HasYelledMercy As Boolean
    Private Sub HPCalc()
        If PlayerHP > 0 Then
            PlayerHPBar.Value = PlayerHP
        Else
            PlayerHPBar.Value = 0
        End If
        If PlayerHP <= 0 Then
            'Game Over!
            sayBattle("GAME OVER", 2)
            Threading.Thread.Sleep(3000)
            Dim menace = MessageBox.Show("PotatoUser... Don't give up! Stay determined!", "PWISE Mettaton NEO Event", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
            If menace = DialogResult.Retry Then
                'Close() now it works 
                Show()
            Else
                'Given up. Will restart PotatoWare.
                PotatoLaunch.Show()
                Close()
            End If
            'TODO: Show game over here and offer retry.
        ElseIf EnemyHP <= 0 Then
            'You Win!
            PotatoManagement.Notify(Date.Now + " :: You won against Event Boss Mettaton NEO!", True)
            If My.Settings.BeatMettatonNEO = False Then
                PotatoManagement.Notify("You have unlocked the ability to fight Mettaton NEO again in the future.", True)
                MessageBox.Show("You can access Mettaton NEO from the Apps > Boss Battles menu, then press Mettaton NEO.", "PotatoWare Help")
                Close()
            End If
            My.Settings.BeatMettatonNEO = True
        ElseIf EnemyHP <= 1000 Then
            If HasCriedMercy = False Then
                sayBattle("* NO! Please, have mercy! My fans don't want to see this!", 2)
            End If
            HasCriedMercy = True 'This way he won't cry mercy every turn.
        ElseIf EnemyHP <= 500 Then
            If HasYelledMercy = False Then
                sayBattle("* HAVE MERCY!", 3)
            End If
            HasYelledMercy = True 'This way he won't yell every turn.
        End If
    End Sub
    Public KeyIsPressed As Boolean
    Private Sub Form_DoEventSpace(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Then
            KeyIsPressed = True
        Else
            KeyIsPressed = False
        End If
    End Sub

    Private Sub neofight_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop() 'This stops the event's music.
    End Sub

    Private Sub ActButton_Click(sender As Object, e As EventArgs) Handles ActButton.Click
        sayBattle("* Mettaton NEO is trying to determine your next move.", 1)
        Threading.Thread.Sleep(100)
        ActMenuDrop.Show(ActButton.Location)
    End Sub
    Private Sub BudgeActItem_Click(sender As Object, e As EventArgs) Handles BudgeActItem.Click
        sayBattle("* You move slightly.")
        Refresh()
        Threading.Thread.Sleep(500)
        Dim rndval As Integer
        rndval = RndGen.Next(0, 3)
        If rndval = 0 Then
            sayBattle("* Mettaton NEO is unaffected.")
            PlayerMomentum = PlayerMomentum + 10
        ElseIf rndval = 1 Then
            sayBattle("* Mettaton NEO thinks he can sneak in a potato.")
            PlayerMomentum = PlayerMomentum + 20
        ElseIf rndval = 2 Then
            sayBattle("* Mettaton NEO became annoyed and let his guard down.")
            If PlayerMomentum >= 10 Then
                PlayerMomentum = PlayerMomentum - 10
                EnemyHP = EnemyHP - RndGen.Next(999, 1011) 'Anywhere between 999 and 1010 damage. Budge OP!
                Refresh()
                Threading.Thread.Sleep(1000)
                sayBattle("* Mettaton NEO took damage!", 1)
            End If
        End If
        Refresh()
        Threading.Thread.Sleep(1000)
        doRetaliate()
        HPCalc()
    End Sub

    Private Sub CheckActItem_Click(sender As Object, e As EventArgs) Handles CheckActItem.Click
        sayBattle("* METTATON NEO - 90 ATK 9 DEF" + vbNewLine + "* Dr. Alphys's greatest invention.")
        Refresh()
        Threading.Thread.Sleep(1000)
        doRetaliate()
        HPCalc()
    End Sub

    Private Sub ItemButton_Click(sender As Object, e As EventArgs) Handles ItemButton.Click
        sayBattle("* No items in bag. Just an old, crushed potato chip.", 1)
        Refresh()
        Threading.Thread.Sleep(1000)
        doRetaliate()
        HPCalc()
    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub MercyButton_Click(sender As Object, e As EventArgs) Handles MercyButton.Click
        sayBattle("* There will be no mercy!", 1)
        Threading.Thread.Sleep(1000)
        doRetaliate()
        HPCalc()
    End Sub

    'TODO:  - Link it to the debug options menu for testing!
    '       - Add a boolean setting to note completion, and then in the next update it will unlock in the Boss Battles menu.
    '
    'DONE:  - Added sayBattle() SUB with a sequence that adds letters one after the other and uses parameters to determine type.
    '       - Changed the event background service to launch it.
    '       - Add more efficient battle techniques and AI implementations of a sort.
    '       - Add notification for completion.
    '       - Add an enemy retaliation. The player should be able to manually avoid the attack.
    '       - Add ACT, ITEM, and a useless MERCY function.

End Class
