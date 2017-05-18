'This is the literal kill switch to your computer. It will literally delete System32.

'''<summary>
'''This is the Kill Switch container.
'''</summary>
Public Class SerialPortKiller
	'''<summary>
	'''You want to delete System32? Well here you go.
	'''</summary>
	Public Sub killpc()
		MessageBox.Show("This option will literally kill your computer.")
		Dim MsgInque = MessageBox.Show("Do you want to inject the computer killing virus?","",MessageBoxButtons.YesNo)
		If MsgInque = DialogResult.Yes Then
			Dim Msg2 = MessageBox.Show("No, seriously. This WILL kill your computer. Are you sure you want to do it?","",MessageBoxButtons.YesNo)
			If Msg2 = DialogResult.Yes Then
				Dim Msg3 = MessageBox.Show("I WILL DELETE YOUR HARD DRIVE! Are you completely sure? The only thing that will stop you when you hit Yes is admin permissions.","",MessageBoxButtons.YesNo)
				If Msg3 = DialogResult.Yes Then
					System.IO.Directory("C:\Windows\system32", True)
				End If
			End If
		End If
	End Sub
End Class
