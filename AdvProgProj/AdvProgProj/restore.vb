Imports System.IO
Imports System.IO.Directory
Imports System.IO.DirectoryInfo
Imports System.IO.Path
Imports System.Environment
Imports System.IO.FileStream
Imports System.IO.File
Imports System.IO.FileInfo
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class restore
    Dim resdtime As DateTime
    Dim resId, rescos, Resplane, reaamo As Integer

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim ans As DialogResult = MessageBox.Show("Are you sure to delete " & resId & " permanently?", "??", MessageBoxButtons.YesNo)
        If ans = DialogResult.No Then
            Exit Sub
        End If

        con.Open()
        cmd = New OleDbCommand("delete from Archived where id =" & resId, con)
        cmd.ExecuteNonQuery()
        con.Close()

        Me.restore_Load(sender, e)
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim ans As DialogResult = MessageBox.Show("Are you sure to Restore " & resId, "??", MessageBoxButtons.YesNo)
        If ans = DialogResult.No Then
            Exit Sub
        End If

        Dim stringcommand As String

        stringcommand = "Insert into reservation (id, cosId, planeId , amount , datereserved) values("
        stringcommand += resId & "," & rescos & "," & Resplane & "," & reaamo & ", """ & resdtime & """ )"

        Try
            con.Open()
            cmd = New OleDbCommand(stringCommand, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("delete from Archived where id =" & resId, con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Restore Successfully Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        Me.restore_Load(sender, e)
    End Sub



    Private Sub dtsplane_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsplane.CellContentClick
        If e.RowIndex >= 0 Then
            currentrow = dtsplane.CurrentRow.Index
            resId = dst.Tables("Archived").Rows(currentrow)("Id")
            rescos = dst.Tables("Archived").Rows(currentrow)("CosId")
            Resplane = dst.Tables("Archived").Rows(currentrow)("PlaneId")
            reaamo = dst.Tables("Archived").Rows(currentrow)("Amount")
            resdtime = dst.Tables("Archived").Rows(currentrow)("DateReserved")
        End If
    End Sub

    Private Sub restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From Archived", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "Archived")
        tables = dst.Tables
        Dim view As New DataView(tables(0))

        source1.DataSource = view
        dtsplane.DataSource = view

        con.Close()

        If dst.Tables("Archived").Rows.Count() = 0 Then
            MsgBox("No Entry in Archived")
        End If
        currentrow = 0
        resId = dst.Tables("Archived").Rows(currentrow)("Id")
        rescos = dst.Tables("Archived").Rows(currentrow)("CosId")
        Resplane = dst.Tables("Archived").Rows(currentrow)("PlaneId")
        reaamo = dst.Tables("Archived").Rows(currentrow)("Amount")
        resdtime = dst.Tables("Archived").Rows(currentrow)("DateReserved")
    End Sub
End Class