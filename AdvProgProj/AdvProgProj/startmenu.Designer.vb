<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startmenu
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
        Me.btnstaff = New System.Windows.Forms.Button()
        Me.btncus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnstaff
        '
        Me.btnstaff.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaff.Location = New System.Drawing.Point(12, 12)
        Me.btnstaff.Name = "btnstaff"
        Me.btnstaff.Size = New System.Drawing.Size(129, 66)
        Me.btnstaff.TabIndex = 0
        Me.btnstaff.Text = "Staff"
        Me.btnstaff.UseVisualStyleBackColor = True
        '
        'btncus
        '
        Me.btncus.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncus.Location = New System.Drawing.Point(12, 84)
        Me.btncus.Name = "btncus"
        Me.btncus.Size = New System.Drawing.Size(129, 66)
        Me.btncus.TabIndex = 1
        Me.btncus.Text = "Customer"
        Me.btncus.UseVisualStyleBackColor = True
        '
        'startmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(155, 163)
        Me.Controls.Add(Me.btncus)
        Me.Controls.Add(Me.btnstaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "startmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnstaff As System.Windows.Forms.Button
    Friend WithEvents btncus As System.Windows.Forms.Button

End Class
