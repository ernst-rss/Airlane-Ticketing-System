<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuslog
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
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btnsign = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnlog
        '
        Me.btnlog.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.Location = New System.Drawing.Point(12, 12)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(117, 59)
        Me.btnlog.TabIndex = 12
        Me.btnlog.Text = "Log In"
        Me.btnlog.UseVisualStyleBackColor = True
        '
        'btnsign
        '
        Me.btnsign.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsign.Location = New System.Drawing.Point(12, 77)
        Me.btnsign.Name = "btnsign"
        Me.btnsign.Size = New System.Drawing.Size(117, 59)
        Me.btnsign.TabIndex = 13
        Me.btnsign.Text = "Sign Up"
        Me.btnsign.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(12, 142)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(117, 59)
        Me.btnback.TabIndex = 14
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'cuslog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(144, 220)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnsign)
        Me.Controls.Add(Me.btnlog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "cuslog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cuslog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlog As System.Windows.Forms.Button
    Friend WithEvents btnsign As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
