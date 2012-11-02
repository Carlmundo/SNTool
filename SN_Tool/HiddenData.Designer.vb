<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HiddenData
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
        Me.lstPath = New System.Windows.Forms.ListBox
        Me.lblPath = New System.Windows.Forms.Label
        Me.lstMask = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstPath
        '
        Me.lstPath.FormattingEnabled = True
        Me.lstPath.Location = New System.Drawing.Point(12, 12)
        Me.lstPath.Name = "lstPath"
        Me.lstPath.Size = New System.Drawing.Size(102, 95)
        Me.lstPath.TabIndex = 11
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(17, 118)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(39, 13)
        Me.lblPath.TabIndex = 12
        Me.lblPath.Text = "lblPath"
        '
        'lstMask
        '
        Me.lstMask.FormattingEnabled = True
        Me.lstMask.Location = New System.Drawing.Point(132, 12)
        Me.lstMask.Name = "lstMask"
        Me.lstMask.Size = New System.Drawing.Size(102, 95)
        Me.lstMask.TabIndex = 13
        '
        'HiddenData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstMask)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lstPath)
        Me.Name = "HiddenData"
        Me.Text = "HiddenData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPath As System.Windows.Forms.ListBox
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents lstMask As System.Windows.Forms.ListBox
End Class
