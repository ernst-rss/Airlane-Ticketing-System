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
Public Class All
    Private Sub all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From reservation", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "reservation")
        tables = dst.Tables
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dtsplane.DataSource = view
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From costumer", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "costumer")
        tables = dst.Tables
        view = New DataView(tables(0))
        source1.DataSource = view
        DataGridView2.DataSource = view
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "Plane")
        tables = dst.Tables
        view = New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From biza", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "biza")
        tables = dst.Tables
        view = New DataView(tables(0))
        source1.DataSource = view
        DataGridView3.DataSource = view
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From types", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "types")
        tables = dst.Tables
        view = New DataView(tables(0))
        source1.DataSource = view
        DataGridView4.DataSource = view
        con.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        staffmenu.Show()
        Me.Close()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click

        con.Open()
            dad = New OleDb.OleDbDataAdapter("Select * From reservation", con)
            dst.Clear()
            dad.Fill(dst, "Reservation")
            con.Close()


            Dim str As New Integer
            Try
                str = InputBox("Enter ID to Update")
            Catch ex As Exception

            MsgBox("Invalid Entry")
            End Try

            Dim i As Integer = 0

            Do
                If dst.Tables("Reservation").Rows(i)("Id") = str Then
                    currentrow = i
                    Exit Do
                End If
                i += 1
            Loop While Not i = dst.Tables("Reservation").Rows.Count

            If i = dst.Tables("Reservation").Rows.Count Then
                MsgBox("No Id with " & str)
                Exit Sub
            End If

            updateres.ShowDialog()
            Me.all_Load(sender, e)

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Me.all_Load(sender, e)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim str As Integer
        Try
            str = InputBox("Enter Customer ID")
        Catch ex As Exception
            MsgBox("INVALID ENTRY")
            Exit Sub
        End Try

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From costumer where cosID = " & str, con)
        dst.Clear()
        dad.Fill(dst, "Costumer")
        con.Close()

        If dst.Tables("Costumer").Rows.Count = 0 Then
            MsgBox("NO AVAILABLE CUSTOMER")
            Exit Sub
        End If

        userId = str
        fromAll = True
        reservation.ShowDialog()
        Me.all_Load(sender, e)
        fromAll = False
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim str As Integer
        Try
            str = InputBox("Enter ID")
        Catch ex As Exception
            MsgBox("INVALID ENTRY")
            Exit Sub
        End Try

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From reservation where ID = " & str, con)
        dst.Clear()
        dad.Fill(dst, "Reservation")
        con.Close()

        If dst.Tables("Reservation").Rows.Count = 0 Then
            MsgBox("NO AVAILABLE RESERVATION")
            Exit Sub
        End If

        Dim i As Integer = 0

        Do
            If dst.Tables("Reservation").Rows(i)("Id") = str Then
                currentrow = i
                Exit Do
            End If
            i += 1
        Loop While Not i = dst.Tables("Reservation").Rows.Count

        If i = dst.Tables("Reservation").Rows.Count Then
            MsgBox("No Id with " & str)
            Exit Sub
        End If


        Dim resId, rescos, Resplane, reaamo As Integer
        Dim resdtime As DateTime

        resId = dst.Tables("Reservation").Rows(currentrow)("Id")
        rescos = dst.Tables("Reservation").Rows(currentrow)("CosId")
        Resplane = dst.Tables("Reservation").Rows(currentrow)("PlaneId")
        reaamo = dst.Tables("Reservation").Rows(currentrow)("Amount")
        resdtime = dst.Tables("Reservation").Rows(currentrow)("DateReserved")

        Dim stringCommand As String

        stringCommand = "Insert into archived (id, cosId, planeId , amount , datereserved) values("
        stringCommand += resId & "," & rescos & "," & Resplane & "," & reaamo & ", " & resdtime.Date & " )"

        Try
            con.Open()
            cmd = New OleDbCommand(stringCommand, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("delete from reservation where id =" & str, con)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Archived Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        Me.all_Load(sender, e)

    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        restore.ShowDialog()
        Me.all_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From reservation ", con)
        dst.Clear()
        dad.Fill(dst, "Reservation")
        con.Close()
        MsgBox("Number of Entries: " & dst.Tables("Reservation").Rows.Count)
    End Sub
End Class