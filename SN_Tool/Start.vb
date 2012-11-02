Imports Microsoft.Win32
Public Class Start
    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microlink\License", "SerialsEntered", Nothing) = "1" Then
            If Not IO.File.Exists("app_list.txt") Then
                MsgBox("Unable to find app_list.txt." & vbNewLine & vbNewLine & "Please contact Microlink to solve this issue.", MsgBoxStyle.Exclamation, "Error")
                Me.Close()
            Else
                Production.Show()
                Me.Close()
                Production.txtSerial.Focus()
            End If
        Else
            Customer.Show()
            Me.Close()
        End If
    End Sub
End Class