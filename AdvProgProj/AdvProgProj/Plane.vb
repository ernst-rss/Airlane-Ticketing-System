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
Public Class Plane


    Dim dateString As Date


    Public Sub UpdateTextBox(ByVal x As Integer)
        Try
            txtid.Text = dst.Tables("Plane").Rows(x)("PlaneId")
            txtprice.Text = dst.Tables("Plane").Rows(x)("PlanePrice")
            txtdest.Text = dst.Tables("Plane").Rows(x)("PlaneDestination")
            dttime.Value = dst.Tables("Plane").Rows(x)("PlaneDeparture")
            btncurrent.Text = dst.Tables("Plane").Rows(x)("PlaneId")

        Catch ex As Exception
        End Try

    End Sub
    Private Function valid() As Boolean
        If IsNumeric(txtid.Text) Then
            If txtid.Text.Length > 3 Then
                MsgBox("No ID longer than 3 digits")
                txtid.Focus()
                txtid.SelectAll()
                Return False
            End If
        ElseIf Not IsNumeric(txtid.Text) Then
            MsgBox("Must enter numeric character only")
            txtid.Focus()
            txtid.SelectAll()
            Return False
        End If

        If Not IsNumeric(txtprice.Text) Then
            MsgBox("Must enter numeric character only")
            txtprice.Focus()
            txtprice.SelectAll()
            Return False
        End If

        
        If Not txtdest.Text = "" Then
            Dim i As Integer
            Dim ch As Char
            i = 0
            While i < txtdest.Text.Length
                ch = txtdest.Text.Chars(i)
                If IsNumeric(ch) = True Then
                    Return False
                End If
                i += 1
            End While
        ElseIf txtdest.Text = "" Then
            Return False
        End If

        Return True
    End Function


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        staffmenu.Show()
        Me.Close()
    End Sub

    Private Sub Plane_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub Plane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane order by planedeparture", con)
        source1 = New BindingSource
        dst = New DataSet
        dst.Clear()
        dad.Fill(dst, "Plane")
        tables = dst.Tables
        Dim view As New DataView(tables(0))

        source1.DataSource = view
        dtsplane.DataSource = view

        con.Close()
        btncurrent.Text = dst.Tables("Plane").Rows(currentrow)("PlaneId")
    End Sub


    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        currentrow = 0
        UpdateTextBox(currentrow)
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        If currentrow > 0 Then
            currentrow = currentrow - 1
            UpdateTextBox(currentrow)
        Else
            MessageBox.Show("This is the First One", "Alert!")
        End If
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If currentrow = dst.Tables("Plane").Rows.Count - 1 Then
            MessageBox.Show("This is the Last One", "Alert!")

        Else
            currentrow = currentrow + 1
            UpdateTextBox(currentrow)
        End If
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        currentrow = dst.Tables("Plane").Rows.Count - 1

        UpdateTextBox(currentrow)
    End Sub

    Private Sub txttime_GotFocus(sender As Object, e As EventArgs)
        lblformat.Text = "DD/MM/YYYY"
    End Sub

    Private Sub txttime_LostFocus(sender As Object, e As EventArgs)
        lblformat.Text = ""
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        updating = False
        PlaneForm.ShowDialog()
        con.Open()
        dst.Clear()
        dad = New OleDb.OleDbDataAdapter("Select * From plane order by planedeparture", con)
        dad.Fill(dst, "Plane")
        con.Close()
    End Sub
    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        updating = True
        planes = txtid.Text
        planedest = txtdest.Text
        planeprice = txtprice.Text
        planetime = dttime.Value
        PlaneForm.ShowDialog()
        con.Open()
        dst.Clear()
        dad = New OleDb.OleDbDataAdapter("Select * From plane order by planedeparture", con)
        dad.Fill(dst, "Plane")
        con.Close()
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane where planedestination like '%" & txtsearch.Text & "%' order by planedeparture", con)
        dst.Clear()
        dad.Fill(dst, "Plane")
        tables = dst.Tables
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dtsplane.DataSource = view
        UpdateTextBox(0)
        con.Close()
    End Sub


    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim valid As DialogResult
        valid = MessageBox.Show("Are you really sure to delete " & dst.Tables("Plane").Rows(currentrow)("PlaneId") & " going to " & dst.Tables("Plane").Rows(currentrow)("PlaneDestination"), "Please Don't", MessageBoxButtons.YesNo)
        If valid = DialogResult.No Then
            Exit Sub
        End If
        Try
            Dim str As String
            str = "delete from plane where planeId =" & txtid.Text.Trim()
            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("Select * from Plane Order by planedeparture", con)
            dad.Fill(dst, "Plane")
            MsgBox("Record deleted successfully, Sad!")
            If currentrow > 0 Then
                currentrow = currentrow + 1
                UpdateTextBox(currentrow)
            Else
                currentrow = currentrow + 1
                UpdateTextBox(currentrow)
            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class