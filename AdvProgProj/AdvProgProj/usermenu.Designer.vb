<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usermenu
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
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnmake = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(280, 87)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(129, 66)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit Account"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnmake
        '
        Me.btnmake.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmake.Location = New System.Drawing.Point(280, 15)
        Me.btnmake.Name = "btnmake"
        Me.btnmake.Size = New System.Drawing.Size(129, 66)
        Me.btnmake.TabIndex = 3
        Me.btnmake.Text = "Make Reservation"
        Me.btnmake.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(280, 159)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(129, 66)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Log Out"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(149, 134)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(58, 19)
        Me.lblamount.TabIndex = 5
        Me.lblamount.Text = "Label1"
        Me.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(25, 98)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(182, 19)
        Me.lblname.TabIndex = 6
        Me.lblname.Text = "Your Current Balance is"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hi, User!"
        '
        'usermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(443, 244)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnmake)
        Me.Controls.Add(Me.btnedit)
        Me.Name = "usermenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "usermenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnmake As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
