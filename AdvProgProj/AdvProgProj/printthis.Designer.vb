<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printthis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printthis))
        Me.rtxtprint = New System.Windows.Forms.RichTextBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'rtxtprint
        '
        Me.rtxtprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtprint.Location = New System.Drawing.Point(29, 24)
        Me.rtxtprint.Name = "rtxtprint"
        Me.rtxtprint.Size = New System.Drawing.Size(362, 326)
        Me.rtxtprint.TabIndex = 0
        Me.rtxtprint.Text = ""
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(59, 369)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(129, 66)
        Me.btnprint.TabIndex = 2
        Me.btnprint.Text = "Print Receipt"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(235, 369)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(129, 66)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save Receipt"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.FileName = "Receipt"
        Me.SaveFileDialog1.Filter = "|*.txt"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'printthis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(429, 447)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.rtxtprint)
        Me.Name = "printthis"
        Me.Text = "printthis"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxtprint As System.Windows.Forms.RichTextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
