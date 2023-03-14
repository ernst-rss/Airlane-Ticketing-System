<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restore
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
        Me.dtsplane = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        CType(Me.dtsplane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtsplane
        '
        Me.dtsplane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsplane.Location = New System.Drawing.Point(12, 12)
        Me.dtsplane.Name = "dtsplane"
        Me.dtsplane.Size = New System.Drawing.Size(617, 646)
        Me.dtsplane.TabIndex = 19
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(687, 249)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 38)
        Me.btnexit.TabIndex = 43
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(687, 161)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 38)
        Me.btnadd.TabIndex = 42
        Me.btnadd.Text = "Restore"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(687, 205)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(94, 38)
        Me.btndel.TabIndex = 44
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 676)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dtsplane)
        Me.Name = "restore"
        Me.Text = "Form1"
        CType(Me.dtsplane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtsplane As DataGridView
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndel As Button
End Class
