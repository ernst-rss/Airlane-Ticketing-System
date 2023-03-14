Public Class startmenu


    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        Dim input As String = InputBox("Enter Master Code", "THE MASTER CODE IS PUPPQUE") 'Master Code is PUPPQUE'e
        If input = "PUPPQUE" Then
            Me.Hide()
            staffmenu.ShowDialog()

        End If
    End Sub

    Private Sub btncus_Click(sender As Object, e As EventArgs) Handles btncus.Click
        cuslog.Show()
        staffmenu.Close()
        Me.Hide()
    End Sub


    Private Sub startmenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub startmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
