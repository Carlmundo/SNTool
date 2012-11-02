Imports System.Windows.Forms

Public Class AddItem

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtUseProduct.Text = "" Then 'Stop Blank entires being added to the list
            MsgBox("Please enter a name for the application.", MsgBoxStyle.Exclamation, "Attention")
        Else
            If Production.lstName.Items.Contains(txtUseProduct.Text) Then 'Stop Duplicates from appearing
                MsgBox("Item already exists.", MsgBoxStyle.Exclamation, "Attention")
            Else
                If IO.File.Exists(txtUsePath.Text) Or txtUsePath.Text = "" Then
                    Production.lstName.Items.Add(txtUseProduct.Text)
                    HiddenData.lstPath.Items.Add(txtUsePath.Text)
                    HiddenData.lstMask.Items.Add("Custom")
                    Me.Close()
                Else
                    MsgBox("Path doesn't exist.", MsgBoxStyle.Exclamation, "Attention")
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myStream As System.IO.Stream
        Dim BrowsePathDialog As New OpenFileDialog()
        BrowsePathDialog.InitialDirectory = Environ("systemdrive")
        BrowsePathDialog.Filter = "All files|*.*|Programs|*.exe"
        BrowsePathDialog.FilterIndex = 2
        BrowsePathDialog.RestoreDirectory = True

        If BrowsePathDialog.ShowDialog() = DialogResult.OK Then
            myStream = BrowsePathDialog.OpenFile()
            If Not (myStream Is Nothing) Then
                txtUsePath.Text = BrowsePathDialog.FileName
                myStream.Close()
            End If
        End If
    End Sub

    Private Sub AddItem_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Production.Enabled = True
    End Sub

    Private Sub AddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
