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

Public Class logmenu

    Private Sub logmenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub logmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source1 = New BindingSource
        dst = New DataSet
        con.Open()
        dst.Clear()
        dad = New OleDb.OleDbDataAdapter("Select * from costumer", con)
        dad.Fill(dst, "costumer")
        con.Close()
    End Sub

    Private Function valid() As Boolean
        If Not IsNumeric(txtid.Text) Then
            MsgBox("Empty ID")
            Return False
        End If
        Return True
    End Function




    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Try
            con.Open()
            dad = New OleDb.OleDbDataAdapter("Select * from costumer where cosId = " & txtid.Text, con)
            dst.Clear()
            dad.Fill(dst, "Costumer")
            con.Close()
        Catch ex As Exception
        End Try
        Try
            If dst.Tables("Costumer").Rows(0)("cosID") = txtid.Text And dst.Tables("Costumer").Rows(0)("password") = txtpass.Text Then
                Dim str As String
                str = dst.Tables("Costumer").Rows(0)("Lname")
                MsgBox("Welcome Mr. " & str)
                userId = txtid.Text
                usermenu.Show()
                Me.Hide()
                Exit Sub
            Else
                MsgBox("Invalid UserID/Password")
                con.Close()
                con.Open()
                dad = New OleDb.OleDbDataAdapter("Select * from costumer ", con)
                dst.Clear()
                dad.Fill(dst, "Costumer")
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Invalid UserID/Password")
            con.Close()
            con.Open()
            dad = New OleDb.OleDbDataAdapter("Select * from costumer ", con)
            dst.Clear()
            dad.Fill(dst, "Costumer")
            con.Close()
        End Try


    End Sub




    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()

    End Sub
End Class