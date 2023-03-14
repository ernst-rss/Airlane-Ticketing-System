Public Class staffmenu

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim answer As DialogResult = MessageBox.Show("Are you Sure?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            Me.Hide()
            Application.Exit()

        End If
    End Sub

    Private Sub btnshowp_Click(sender As Object, e As EventArgs) Handles btnshowp.Click
        Me.Hide()
        Plane.Show()

    End Sub

    Private Sub staffmenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub btnshowcr_Click(sender As Object, e As EventArgs) Handles btnshowcr.Click
        All.Show()
        Me.Close()
    End Sub

End Class