Public Class cuslog

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        startmenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnsign_Click(sender As Object, e As EventArgs) Handles btnsign.Click
        cuslog_sign.Show()
        Me.Hide()
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        logmenu.Show()
        Me.Hide()
    End Sub

 
    Private Sub cuslog_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub cuslog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class