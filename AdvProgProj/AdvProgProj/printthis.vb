Public Class printthis


    Private Sub printthis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtprint.Text = receipt
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SaveFileDialog1.FileName = "Reservation" & userId & planeid & ind
        SaveFileDialog1.ShowDialog()
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, rtxtprint.Text, False)
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtxtprint.Text, rtxtprint.Font, Brushes.Black, 10, 10)
    End Sub
End Class