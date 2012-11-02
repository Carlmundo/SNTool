Option Strict Off
Option Explicit On
Imports Microsoft.Win32
Public Class Production
    Inherits System.Windows.Forms.Form
    Dim RegDirKey, RegKeySoftware, RegKeyMicrolink, RegKeyLicense, RegKeyProduct As RegistryKey
    Dim RegDir
    Dim Position As Short
    Dim items = (From line In IO.File.ReadAllLines("app_list.txt") _
                      Select New With { _
                      .l1 = line.Split(","c)(0).Replace(Chr(34), "").Trim, _
                      .l2 = line.Split(","c)(1).Replace(Chr(34), "").Trim, _
                      .l3 = line.Split(","c)(2).Replace(Chr(34), "").Trim}).ToList
    Dim FullList As New System.Text.StringBuilder

    Private Sub Production_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LicenseCount As Integer
        RegDir = "Software\Microlink\License"
        RegDirKey = Registry.LocalMachine.OpenSubKey("Software\Microlink\License", True)
        RegKeySoftware = Registry.LocalMachine.OpenSubKey("Software", True)
        RegKeySoftware.CreateSubKey("Microlink")
        RegKeyMicrolink = Registry.LocalMachine.OpenSubKey("Software\Microlink", True)
        RegKeyMicrolink.CreateSubKey("License")
        RegKeySoftware.Close()
        RegKeyMicrolink.Close()

        lstName.Items.Clear()
        HiddenData.lstPath.Items.Clear()

        For Each item In items
            lstName.Items.Add(item.l1)
            HiddenData.lstPath.Items.Add(item.l2)
            HiddenData.lstMask.Items.Add(item.l3)
        Next

        For i As Integer = HiddenData.lstPath.Items.Count - 1 To 0 Step -1
            If Not IO.File.Exists("C:\Program Files (x86)\" & HiddenData.lstPath.Items.Item(i)) Then
                If Not IO.File.Exists("C:\Program Files\" & HiddenData.lstPath.Items.Item(i)) Then
                    If Not IO.File.Exists("C:\ProgramData\" & HiddenData.lstPath.Items.Item(i)) Then
                        lstName.Items.RemoveAt(i)
                        HiddenData.lstPath.Items.RemoveAt(i)
                        HiddenData.lstMask.Items.RemoveAt(i)
                    End If
                End If
            End If
        Next

        LicenseCount = Registry.LocalMachine.OpenSubKey(RegDir).SubKeyCount

        For i As Integer = 0 To (LicenseCount - 1)
            If Not lstName.Items.Contains(Registry.LocalMachine.OpenSubKey("SOFTWARE\Microlink\License").GetSubKeyNames(i)) Then 'Stops duplicate entries
                lstName.Items.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\Microlink\License").GetSubKeyNames(i))
                HiddenData.lstPath.Items.Add("")
                HiddenData.lstMask.Items.Add("Custom")
            End If
        Next

        If lstName.Items.Count = 0 Then
            MsgBox("Could not find any software that needs a serial number entered.", MsgBoxStyle.Information, "Attention")
            Me.Close()
        Else
            lstName.SelectedIndex = 0
        End If
    End Sub

    Private Sub lstName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstName.SelectedIndexChanged
        Position = lstName.SelectedIndex
        txtSerial.Mask = ">" & HiddenData.lstMask.Items(Position)
        lblPath.Text = ""
        If txtSerial.Mask = ">" Then 'If Blank Mask
            txtSerial.Mask = ""
            Command_RemoveItem_Disabled()
        End If
        If txtSerial.Mask = ">Custom" Then 'If Custom app
            txtSerial.Mask = ""
            Command_RemoveItem_Enabled()
            RegKeyProduct = Registry.LocalMachine.OpenSubKey(RegDir & "\" & lstName.SelectedItem, True)
            If Not RegKeyProduct Is Nothing Then
                lblPath.Text = RegKeyProduct.GetValue("Path")
            Else
                lblPath.Text = HiddenData.lstPath.Items(Position)
            End If

        Else
            Command_RemoveItem_Disabled()
            If IO.File.Exists("C:\ProgramData\" & HiddenData.lstPath.Items(Position)) Then
                lblPath.Text = "C:\ProgramData\" & HiddenData.lstPath.Items(Position)
            End If
            If IO.File.Exists("C:\Program Files (x86)\" & HiddenData.lstPath.Items(Position)) Then
                lblPath.Text = "C:\Program Files (x86)\" & HiddenData.lstPath.Items(Position)
            End If
            If IO.File.Exists("C:\Program Files\" & HiddenData.lstPath.Items(Position)) Then
                lblPath.Text = "C:\Program Files\" & HiddenData.lstPath.Items(Position)
            End If
        End If

            RegKeyProduct = Registry.LocalMachine.OpenSubKey(RegDir & "\" & lstName.SelectedItem, True)
            txtSerial.Text = ""
            txtSerial.Focus()
            On Error Resume Next
        txtSerial.Text = RegKeyProduct.GetValue("Serial")
        If txtSerial.Text.Contains("OEM") Then
            txtSerial.Mask = ""
            txtSerial.Text = "OEM"
        End If
        RegKeyProduct.Close()
    End Sub

    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        If txtSerial.Mask = "" Then 'If Custom App
            txtSerial.Text = txtSerial.Text.ToUpper()
            SetSerial()
        Else
            If Not txtSerial.MaskCompleted Then 'If Validation passed
                MsgBox("Please enter the full serial number.", MsgBoxStyle.Exclamation, "Attention")
            Else
                SetSerial()
            End If
        End If
    End Sub

    Private Sub cmdOEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOEM.Click
        txtSerial.Mask = ""
        txtSerial.Text = "OEM"
        SetSerial()
    End Sub

    Public Sub SetSerial()
        If Not txtSerial.Text = "" Then
            RegKeyLicense = Registry.LocalMachine.OpenSubKey(RegDir, True)
            RegKeyLicense.CreateSubKey(lstName.SelectedItem)
            RegKeyProduct = Registry.LocalMachine.OpenSubKey(RegDir & "\" & lstName.SelectedItem, True)
            RegKeyProduct.SetValue("Path", lblPath.Text)
            RegKeyProduct.SetValue("Serial", txtSerial.Text)
            RegKeyLicense.Close()
            RegKeyProduct.Close()
            MsgBox("Serial Number set for " & lstName.SelectedItem & ".", MsgBoxStyle.Information, "Serial Added")
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtSerial.Text = ""
        RemoveKey()
        MsgBox("Serial Number deleted for " & lstName.SelectedItem & ".", MsgBoxStyle.Information, "Serial Deleted")
    End Sub

    Private Sub txtSerial_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSerial.MouseClick
        If txtSerial.Text = "" Then
            txtSerial.SelectionStart = 0
        End If
    End Sub

    Public Sub RemoveKey()
        On Error Resume Next
        RegKeyLicense = Registry.LocalMachine.OpenSubKey(RegDir, True)
        RegKeyLicense.DeleteSubKey(lstName.SelectedItem)
        RegKeyLicense.Close()
    End Sub

    Public Sub Command_AddItem()
        AddItem.Show()
        Me.Enabled = False
        AddItem.txtUseProduct.Focus()
    End Sub

    Public Sub Command_RemoveItem()
        Dim RemovePos
        RemovePos = Position
        RemoveKey()
        lstName.SelectedIndex = Position - 1
        lstName.Items.RemoveAt(RemovePos)
        HiddenData.lstPath.Items.RemoveAt(RemovePos)
        HiddenData.lstMask.Items.RemoveAt(RemovePos)
    End Sub


    Private Sub CMenu_Serial_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_Serial_Cut.Click
        txtSerial.Cut()
    End Sub

    Private Sub CMenu_Serial_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_Serial_Copy.Click
        txtSerial.Copy()
    End Sub

    Private Sub CMenu_Serial_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_Serial_Paste.Click
        txtSerial.Paste()
    End Sub

    Private Sub CMenu_Serial_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_Serial_SelectAll.Click
        txtSerial.SelectAll()
    End Sub

    Private Sub CMenu_List_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_List_AddItem.Click
        Command_AddItem()
    End Sub

    Private Sub CMenu_List_RemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMenu_List_RemoveItem.Click
        Command_RemoveItem()
    End Sub

    Public Sub Command_RemoveItem_Enabled()
        Menu_Items_RemoveItem.Enabled = True
        CMenu_List_RemoveItem.Enabled = True
    End Sub

    Public Sub Command_RemoveItem_Disabled()
        Menu_Items_RemoveItem.Enabled = False
        CMenu_List_RemoveItem.Enabled = False
    End Sub

    Private Sub Production_FormClosing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        Dim CloseButton As DialogResult
        CloseButton = MessageBox.Show _
        ("Please make sure all serials have been input." & vbCrLf & vbCrLf & "Once you close the program you will not be able to enter the serial numbers again." & vbCrLf & vbCrLf & "Are you sure you want to close?", _
         "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If CloseButton = Windows.Forms.DialogResult.Yes Then
            HowToUse.Close()
            About.Close()
            RegDirKey = Registry.LocalMachine.OpenSubKey("Software\Microlink\License", True)
            RegDirKey.SetValue("SerialsEntered", "1")
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Menu_Items_AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Items_AddItem.Click
        Command_AddItem()
    End Sub

    Private Sub Menu_Items_RemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Items_RemoveItem.Click
        Command_RemoveItem()
    End Sub

    Private Sub Menu_Edit_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Edit_Cut.Click
        txtSerial.Cut()
    End Sub

    Private Sub Menu_Edit_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Edit_Copy.Click
        txtSerial.Copy()
    End Sub

    Private Sub Menu_Edit_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Edit_Paste.Click
        txtSerial.Paste()
    End Sub

    Private Sub Menu_Edit_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Edit_SelectAll.Click
        txtSerial.SelectAll()
    End Sub

    Private Sub Menu_View_CustomerView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_View_CustomerView.Click
        Me.Enabled = False
        Customer.Show()
    End Sub

    Private Sub Menu_Help_HowToUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Help_HowToUse.Click
        HowToUse.Show()
    End Sub

    Private Sub Menu_Help_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Help_About.Click
        About.Show()
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        If txtSalesOrder.Text = Nothing Then
            MsgBox("Please enter a Sales Order No.")
        Else
            FullList.Remove(0, FullList.Length)
            For i As Integer = 0 To lstName.Items.Count - 1
                lstName.SelectedItem = lstName.Items.Item(i)
                If System.Text.RegularExpressions.Regex.Match(txtSerial.Text, "\w").Success Or System.Text.RegularExpressions.Regex.Match(txtSerial.Text, "\d").Success Then
                    FullList.AppendLine(lstName.Items(i).ToString & ": " & txtSerial.Text)
                End If
            Next

            If FullList.ToString = Nothing Then
                MsgBox("No serial numbers have been entered. There is nothing to print.")
            Else

                sfdExport.FileName = txtSalesOrder.Text & "s.txt"
                sfdExport.ShowDialog()
                IO.File.WriteAllText(sfdExport.FileName, FullList.ToString)
                Shell(Environ("windir") & "\system32\notepad.exe " & Chr(34) & sfdExport.FileName & Chr(34), AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
End Class

