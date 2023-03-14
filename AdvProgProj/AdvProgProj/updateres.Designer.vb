<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateres
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
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.dttime = New System.Windows.Forms.DateTimePicker()
        Me.txtplane = New System.Windows.Forms.TextBox()
        Me.txtcus = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtamo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(303, 256)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 38)
        Me.btnexit.TabIndex = 41
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(131, 256)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 38)
        Me.btnadd.TabIndex = 40
        Me.btnadd.Text = "Confirm"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dttime
        '
        Me.dttime.CustomFormat = "dd/MM/yyyy"
        Me.dttime.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.dttime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttime.Location = New System.Drawing.Point(209, 189)
        Me.dttime.Name = "dttime"
        Me.dttime.Size = New System.Drawing.Size(275, 26)
        Me.dttime.TabIndex = 39
        '
        'txtplane
        '
        Me.txtplane.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplane.Location = New System.Drawing.Point(209, 125)
        Me.txtplane.Name = "txtplane"
        Me.txtplane.Size = New System.Drawing.Size(275, 26)
        Me.txtplane.TabIndex = 38
        '
        'txtcus
        '
        Me.txtcus.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcus.Location = New System.Drawing.Point(209, 93)
        Me.txtcus.Name = "txtcus"
        Me.txtcus.Size = New System.Drawing.Size(275, 26)
        Me.txtcus.TabIndex = 37
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(209, 61)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(275, 26)
        Me.txtid.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Date Reserved"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "PlaneId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "CosId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID"
        '
        'txtamo
        '
        Me.txtamo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamo.Location = New System.Drawing.Point(209, 157)
        Me.txtamo.Name = "txtamo"
        Me.txtamo.Size = New System.Drawing.Size(275, 26)
        Me.txtamo.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Amount"
        '
        'updateres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 325)
        Me.Controls.Add(Me.txtamo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dttime)
        Me.Controls.Add(Me.txtplane)
        Me.Controls.Add(Me.txtcus)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "updateres"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents dttime As DateTimePicker
    Friend WithEvents txtplane As TextBox
    Friend WithEvents txtcus As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtamo As TextBox
    Friend WithEvents Label5 As Label
End Class
