Option Strict Off
Option Explicit On
Imports Microsoft.Win32

Public Class Customer
    Inherits System.Windows.Forms.Form
    Dim RegKeySoftware, RegKeyMicrolink, RegKeyLicense, RegKeyProduct As RegistryKey
    Dim RegDir
    Dim LicenseCount As Integer

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RegDir = "Software\Microlink\License"
        RegKeySoftware = Registry.LocalMachine.OpenSubKey("Software", True)
        RegKeySoftware.CreateSubKey("Microlink")
        RegKeyMicrolink = Registry.LocalMachine.OpenSubKey("Software\Microlink", True)
        RegKeyMicrolink.CreateSubKey("License")
        RegKeySoftware.Close()
        RegKeyMicrolink.Close()
        LicenseCount = Registry.LocalMachine.OpenSubKey(RegDir).SubKeyCount

        lstName.Items.Clear()

        For i As Integer = 0 To (LicenseCount - 1)
            lstName.Items.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\Microlink\License").GetSubKeyNames(i))
        Next

        If lstName.Items.Count = 0 Then
            MsgBox("Could not find any serial numbers.", MsgBoxStyle.Information, "Attention")
            Me.Close()
        Else
            lstName.SelectedIndex = 0
        End If

    End Sub

    Private Sub lstName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstName.SelectedIndexChanged
        RegKeyProduct = Registry.LocalMachine.OpenSubKey(RegDir & "\" & lstName.SelectedItem, True)
        HiddenData.lblPath.Text = RegKeyProduct.GetValue("Path")
        If IO.File.Exists(HiddenData.lblPath.Text) Then
            cmdLaunch.Enabled = True
        Else
            cmdLaunch.Enabled = False
        End If
        If RegKeyProduct.GetValue("Serial") = "OEM" Then
            txtSerial.Visible = False
            lnkContact.Visible = True
        ElseIf RegKeyProduct.GetValue("Serial") = "" Then
            txtSerial.Visible = True
            lnkContact.Visible = False
            txtSerial.Text = "No Serial Found."
        Else
            txtSerial.Visible = True
            lnkContact.Visible = False
            txtSerial.Text = RegKeyProduct.GetValue("Serial")
        End If
        RegKeyProduct.Close()
    End Sub

    Private Sub cmdLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLaunch.Click
        Shell(HiddenData.lblPath.Text, AppWinStyle.NormalFocus)
    End Sub

    Private Sub Customer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Production.Enabled = False Then
            Production.Enabled = True
        End If
    End Sub

    Private Sub lnkContact_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkContact.LinkClicked
        System.Diagnostics.Process.Start("http://www.microlinkpc.com/contact-us")
    End Sub
End Class

