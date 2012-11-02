Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("About {0}", My.Application.Info.Title)
        Me.lblAppName.Text = My.Application.Info.AssemblyName
        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblCompany.Text = My.Application.Info.CompanyName
        Me.lblCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
