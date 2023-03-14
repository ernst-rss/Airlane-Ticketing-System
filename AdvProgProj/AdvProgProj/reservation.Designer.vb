<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservation
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
        Me.dtsplane = New System.Windows.Forms.DataGridView()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btncurrent = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.dttime = New System.Windows.Forms.DateTimePicker()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtdest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtsplane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(487, 72)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 38)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(487, 27)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 38)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dtsplane
        '
        Me.dtsplane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsplane.Location = New System.Drawing.Point(10, 197)
        Me.dtsplane.Name = "dtsplane"
        Me.dtsplane.Size = New System.Drawing.Size(594, 163)
        Me.dtsplane.TabIndex = 17
        '
        'btnlast
        '
        Me.btnlast.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.Location = New System.Drawing.Point(448, 153)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(94, 38)
        Me.btnlast.TabIndex = 24
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(348, 153)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(94, 38)
        Me.btnnext.TabIndex = 23
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btncurrent
        '
        Me.btncurrent.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncurrent.Location = New System.Drawing.Point(248, 153)
        Me.btncurrent.Name = "btncurrent"
        Me.btncurrent.Size = New System.Drawing.Size(94, 38)
        Me.btncurrent.TabIndex = 22
        Me.btncurrent.Text = "--"
        Me.btncurrent.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.Location = New System.Drawing.Point(148, 153)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(94, 38)
        Me.btnprev.TabIndex = 21
        Me.btnprev.Text = "Previous"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(48, 153)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(94, 38)
        Me.btnfirst.TabIndex = 20
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'dttime
        '
        Me.dttime.CustomFormat = "dd/MM/yyyy"
        Me.dttime.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.dttime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttime.Location = New System.Drawing.Point(161, 76)
        Me.dttime.Name = "dttime"
        Me.dttime.Size = New System.Drawing.Size(275, 26)
        Me.dttime.TabIndex = 28
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(161, 108)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(275, 26)
        Me.txtsearch.TabIndex = 27
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(161, 44)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(275, 26)
        Me.txtprice.TabIndex = 26
        '
        'txtdest
        '
        Me.txtdest.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdest.Location = New System.Drawing.Point(161, 12)
        Me.txtdest.Name = "txtdest"
        Me.txtdest.Size = New System.Drawing.Size(275, 26)
        Me.txtdest.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Plane Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Time Departure"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Destination"
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(622, 373)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dttime)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtdest)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btncurrent)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.dtsplane)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "reservation"
        Me.Text = "reservation"
        CType(Me.dtsplane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents dtsplane As System.Windows.Forms.DataGridView
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btncurrent As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents dttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtdest As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
