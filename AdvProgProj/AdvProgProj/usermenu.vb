Public Class usermenu

    Private Sub btnmake_Click(sender As Object, e As EventArgs) Handles btnmake.Click
        reservation.Show()
        Me.Hide()
    End Sub

    Private Sub usermenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From biza where bizaId in (select bizaId from costumer where cosId = " & userId & ")", con)
        dst.Clear()
        dad.Fill(dst, "biza")
        lblamount.Text = dst.Tables("biza").Rows(0)("BizaAmount")
        con.Close()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        userId = Nothing
        logmenu.Show()
        Me.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        editmenu.Show()
        Me.Close()
    End Sub
End Class