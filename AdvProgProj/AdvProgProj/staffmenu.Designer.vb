<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffmenu
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
        Me.btnshowcr = New System.Windows.Forms.Button()
        Me.btnshowp = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnshowcr
        '
        Me.btnshowcr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowcr.Location = New System.Drawing.Point(12, 12)
        Me.btnshowcr.Name = "btnshowcr"
        Me.btnshowcr.Size = New System.Drawing.Size(129, 66)
        Me.btnshowcr.TabIndex = 1
        Me.btnshowcr.Text = "Customer Reservation"
        Me.btnshowcr.UseVisualStyleBackColor = True
        '
        'btnshowp
        '
        Me.btnshowp.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowp.Location = New System.Drawing.Point(12, 84)
        Me.btnshowp.Name = "btnshowp"
        Me.btnshowp.Size = New System.Drawing.Size(129, 66)
        Me.btnshowp.TabIndex = 2
        Me.btnshowp.Text = "Plane"
        Me.btnshowp.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(12, 156)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(129, 66)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Exit"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'staffmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(156, 237)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnshowp)
        Me.Controls.Add(Me.btnshowcr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "staffmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffmenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnshowcr As System.Windows.Forms.Button
    Friend WithEvents btnshowp As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
End Class
