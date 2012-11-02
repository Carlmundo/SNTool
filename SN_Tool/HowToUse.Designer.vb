<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToUse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToUse))
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.cmdCloseHelp = New System.Windows.Forms.Button
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.tblDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(3, 32)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(350, 176)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(113, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Padding = New System.Windows.Forms.Padding(5)
        Me.lblHeading.Size = New System.Drawing.Size(129, 32)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "How To Use"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCloseHelp
        '
        Me.cmdCloseHelp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdCloseHelp.AutoSize = True
        Me.cmdCloseHelp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseHelp.Location = New System.Drawing.Point(261, 211)
        Me.cmdCloseHelp.Name = "cmdCloseHelp"
        Me.cmdCloseHelp.Size = New System.Drawing.Size(92, 26)
        Me.cmdCloseHelp.TabIndex = 2
        Me.cmdCloseHelp.Text = "Close"
        Me.cmdCloseHelp.UseVisualStyleBackColor = True
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDesign.Controls.Add(Me.lblHeading, 0, 0)
        Me.tblDesign.Controls.Add(Me.cmdCloseHelp, 0, 2)
        Me.tblDesign.Controls.Add(Me.lblInstructions, 0, 1)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 3
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Size = New System.Drawing.Size(351, 240)
        Me.tblDesign.TabIndex = 3
        '
        'HowToUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(351, 240)
        Me.Controls.Add(Me.tblDesign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "HowToUse"
        Me.Text = "How To Use"
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents cmdCloseHelp As System.Windows.Forms.Button
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
End Class
