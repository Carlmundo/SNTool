Imports Microsoft.Win32

Public Class Main
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RegDirKey
        RegDirKey = Registry.LocalMachine.OpenSubKey("Software\Microlink\License", True)
        RegDirKey.SetValue("SerialsEntered", "0")
        Shell("SN_Tool.exe", AppWinStyle.NormalFocus)
        Me.Close()
    End Sub
End Class
