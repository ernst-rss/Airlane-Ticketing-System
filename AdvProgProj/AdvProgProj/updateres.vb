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
Public Class updateres
    Private Sub updateres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Clear()
        txtcus.Clear()
        txtplane.Clear()
        txtamo.Clear()
        dttime.Value = Today

        txtid.Text = dst.Tables("Reservation").Rows(currentrow)("Id")
        txtcus.Text = dst.Tables("Reservation").Rows(currentrow)("CosId")
        txtplane.Text = dst.Tables("Reservation").Rows(currentrow)("PlaneId")
        txtamo.Text = dst.Tables("Reservation").Rows(currentrow)("Amount")
        dttime.Value = dst.Tables("Reservation").Rows(currentrow)("DateReserved")

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From costumer where cosId = " & txtcus.Text.Trim(), con)
        dad.Fill(dst, "Costumer")
        con.Close()

        If dst.Tables("Costumer").Rows.Count = 0 Then
            MsgBox("NO AVAILABLE CUSTOMER")
            Exit Sub
        End If

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane where planeId = " & txtplane.Text.Trim(), con)
        dad.Fill(dst, "Plane")
        con.Close()

        If dst.Tables("Plane").Rows.Count = 0 Then
            MsgBox("NO AVAILABLE PLANE")
            Exit Sub
        End If

        Try
            con.Open()
            cmd = New OleDbCommand("Update reservation set cosId = """ & txtcus.Text.Trim() & """ where Id = " & txtid.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("Update reservation set PlaneId = """ & txtplane.Text.Trim() & """ where Id = " & txtid.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("Update reservation set amount = """ & txtamo.Text.Trim() & """ where Id = " & txtid.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("Update reservation set datereserved = """ & dttime.Value & """ where Id = " & txtid.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()


            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Update Record!!")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class