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
Public Class reservation

    Dim ex As Integer = 0
    Dim planeD As Integer
    Dim planeDest As String
    Dim planeprice As Integer
    Dim prev As Integer
    Dim disc As Integer
    Dim change As Integer
    Dim disid As Integer

    Public Sub UpdateTextBox(ByVal x As Integer)
        Try
            txtprice.Text = dst.Tables("Plane").Rows(x)("PlanePrice")
            txtdest.Text = dst.Tables("Plane").Rows(x)("PlaneDestination")
            dttime.Value = dst.Tables("Plane").Rows(x)("PlaneDeparture")
            btncurrent.Text = dst.Tables("Plane").Rows(x)("PlaneId")
            planeD = dst.Tables("Plane").Rows(x)("PlaneId")
        Catch ex As Exception
        End Try

    End Sub
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source1 = New BindingSource
        dst = New DataSet
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane order by planedeparture", con)
        dst = New DataSet
        dad.Fill(dst, "Plane")
        Do
            For i As Integer = 0 To dst.Tables("Plane").Rows.Count - 1
                If DateAdd(DateInterval.Day, ex, Today) = dst.Tables("Plane").Rows(i)("Planedeparture") Then
                    dst.Tables("Plane").Rows.RemoveAt(i)
                    i -= 1
                    Exit For
                End If
            Next
            ex += 1
        Loop While ex < 14
        ex = 0
        tables = dst.Tables

        currentrow = 0
        Dim view As New DataView(tables(0))
        source1 = New BindingSource
        source1.DataSource = view
        dtsplane.DataSource = view
        UpdateTextBox(0)
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


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim str As String
        Dim disprice As Integer
        Dim i As Integer

        planeDest = txtdest.Text

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * from Types where type in (Select type from costumer where cosID = " & userId & " )", con)
        dst.Clear()
        dad.Fill(dst, "Types")
        i = dst.Tables("Types").Rows(0)("Discount")
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * from biza where bizaId in (Select bizaId from costumer where cosID = " & userId & " )", con)
        dst.Clear()
        dad.Fill(dst, "Biza")
        prev = dst.Tables("Biza").Rows(0)("BizaAmount")
        disid = dst.Tables("Biza").Rows(0)("BizaId")
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * from plane where planeId = " & btncurrent.Text.Trim(), con)
        dst.Clear()
        dad.Fill(dst, "Plane")
        planeprice = dst.Tables("Plane").Rows(0)("planeprice")
        disprice = planeprice * (i / 100)
        con.Close()

        
        If prev - disprice < 0 Then
            MsgBox("Insufficient Amount")
            Exit Sub

        End If

        con.Open()
        dad = New OleDbDataAdapter("Select * From Reservation", con)
        dst.Clear()
        dad.Fill(dst, "Reservation")
        Dim resvID As Integer = dst.Tables("Reservation").Rows(dst.Tables("Reservation").Rows.Count - 1)("ID") + 1
        con.Close()

        str = "Insert into Reservation (Id, cosId, planeId, amount, datereserved) values("
        str += resvID & "," & userId & "," & """" & planeD & """" & "," & """" & disprice & """ ,now())"


        con.Open()
        cmd = New OleDbCommand("Update biza set bizaamount = " & prev - disprice & " where bizaId = " & disid, con)
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Reserved")
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * from reservation order by id", con)
        dst.Clear()
        dad.Fill(dst, "Reservation")
        ind = dst.Tables("Reservation").Rows(dst.Tables("Reservation").Rows.Count - 1)("Id")
        con.Close()

        Me.reservation_Load(sender, e)

        If fromAll Then
            Me.Close()
        Else
            usermenu.Show()
            Me.Close()
        End If



    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From plane where planedestination Like '%" & txtsearch.Text & "%' order by planedeparture", con)
        dst.Clear()
        dad.Fill(dst, "Plane")
        Do
            For i As Integer = 0 To dst.Tables("Plane").Rows.Count - 1
                If DateAdd(DateInterval.Day, ex, Today) = dst.Tables("Plane").Rows(i)("Planedeparture") Then
                    dst.Tables("Plane").Rows.RemoveAt(i)
                    i -= 1
                    Exit For
                End If
            Next
            ex += 1
        Loop While ex < 14
        ex = 0
        tables = dst.Tables
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dtsplane.DataSource = view
        UpdateTextBox(0)
        con.Close()
    End Sub

    Private Sub dtsplane_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsplane.CellContentClick

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        usermenu.Show()
        Me.Close()
    End Sub
End Class