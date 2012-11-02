<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblAppName = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDesign.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.SN_Tool.My.Resources.Resources.microlink_RGB_380
        Me.pbLogo.Location = New System.Drawing.Point(3, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(64, 52)
        Me.pbLogo.TabIndex = 27
        Me.pbLogo.TabStop = False
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 2
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDesign.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(9, 9)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 1
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDesign.Size = New System.Drawing.Size(174, 72)
        Me.tblDesign.TabIndex = 28
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(3, 48)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(75, 16)
        Me.lblCopyright.TabIndex = 21
        Me.lblCopyright.Text = "{Copyright}"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(3, 32)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(76, 16)
        Me.lblCompany.TabIndex = 22
        Me.lblCompany.Text = "{Company}"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(3, 16)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(64, 16)
        Me.lblVersion.TabIndex = 24
        Me.lblVersion.Text = "{Version}"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(3, 0)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(83, 16)
        Me.lblAppName.TabIndex = 20
        Me.lblAppName.Text = "{App Name}"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblAppName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVersion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCompany, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCopyright, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(73, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(89, 64)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(192, 90)
        Me.Controls.Add(Me.tblDesign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label

End Class
