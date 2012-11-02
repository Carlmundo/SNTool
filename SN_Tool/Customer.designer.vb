<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.lblSelect = New System.Windows.Forms.Label
        Me.lstName = New System.Windows.Forms.ListBox
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.lblTitleSerial = New System.Windows.Forms.Label
        Me.cmdLaunch = New System.Windows.Forms.Button
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lnkContact = New System.Windows.Forms.LinkLabel
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDesign.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelect
        '
        Me.lblSelect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSelect.Location = New System.Drawing.Point(84, 52)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(252, 16)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "Select an item to reveal the serial number:"
        Me.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstName
        '
        Me.lstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 16
        Me.lstName.Location = New System.Drawing.Point(20, 71)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(380, 164)
        Me.lstName.TabIndex = 5
        '
        'txtSerial
        '
        Me.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSerial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(54, 273)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(312, 22)
        Me.txtSerial.TabIndex = 8
        Me.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitleSerial
        '
        Me.lblTitleSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleSerial.AutoSize = True
        Me.lblTitleSerial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSerial.Location = New System.Drawing.Point(160, 238)
        Me.lblTitleSerial.Name = "lblTitleSerial"
        Me.lblTitleSerial.Size = New System.Drawing.Size(100, 16)
        Me.lblTitleSerial.TabIndex = 15
        Me.lblTitleSerial.Text = "Serial Number"
        '
        'cmdLaunch
        '
        Me.cmdLaunch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdLaunch.AutoSize = True
        Me.cmdLaunch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLaunch.Location = New System.Drawing.Point(170, 298)
        Me.cmdLaunch.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdLaunch.Name = "cmdLaunch"
        Me.cmdLaunch.Size = New System.Drawing.Size(80, 31)
        Me.cmdLaunch.TabIndex = 21
        Me.cmdLaunch.Text = "Launch"
        Me.cmdLaunch.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogo.Image = Global.SN_Tool.My.Resources.Resources.microlink_RGB_380
        Me.pbLogo.Location = New System.Drawing.Point(19, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(381, 46)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 18
        Me.pbLogo.TabStop = False
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.cmdLaunch, 0, 6)
        Me.tblDesign.Controls.Add(Me.txtSerial, 0, 5)
        Me.tblDesign.Controls.Add(Me.lblSelect, 0, 1)
        Me.tblDesign.Controls.Add(Me.lstName, 0, 2)
        Me.tblDesign.Controls.Add(Me.lblTitleSerial, 0, 3)
        Me.tblDesign.Controls.Add(Me.lnkContact, 0, 4)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 7
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.Size = New System.Drawing.Size(420, 328)
        Me.tblDesign.TabIndex = 25
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.SN_Tool.My.Resources.Resources.microlink_RGB_380
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(153, 120)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 20)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Launch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(51, 257)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(312, 22)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnkContact
        '
        Me.lnkContact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkContact.AutoSize = True
        Me.lnkContact.Location = New System.Drawing.Point(64, 254)
        Me.lnkContact.Name = "lnkContact"
        Me.lnkContact.Size = New System.Drawing.Size(291, 16)
        Me.lnkContact.TabIndex = 22
        Me.lnkContact.TabStop = True
        Me.lnkContact.Text = "Contact Microlink for the serial number if required"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 328)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.Text = "SN Tool"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblTitleSerial As System.Windows.Forms.Label
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cmdLaunch As System.Windows.Forms.Button
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lnkContact As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
