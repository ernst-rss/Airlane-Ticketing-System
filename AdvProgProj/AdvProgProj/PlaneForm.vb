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
Public Class PlaneForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Clear()
        txtdest.Clear()
        txtprice.Clear()
        dttime.Value = Today
        If updating Then
            txtid.Text = planes
            txtdest.Text = planedest
            txtprice.Text = planeprice
            dttime.Value = planetime

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If updating Then
            Try
                con.Open()
                cmd = New OleDbCommand("Update plane set planeDestination = """ & txtdest.Text.Trim() & """ where planeId = " & txtid.Text, con)
                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = New OleDbCommand("Update plane set planedeparture = " & dttime.Value & " where planeId = " & txtid.Text.Trim(), con)
                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = New OleDbCommand("Update plane set planePrice = " & txtprice.Text() & " where planeId = " & txtid.Text.Trim(), con)
                cmd.ExecuteNonQuery()
                con.Close()

                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Could Not Update Record!!")
                MsgBox(ex.Message & "-" & ex.Source)
                con.Close()
            End Try
        Else
            Dim str As String
            str = "Insert into plane (planeid ,planedestination,planedeparture, planeprice) values("
            str += txtid.Text.Trim()
            str += ","
            str += """" & txtdest.Text.Trim() & """"
            str += ","
            str += """" & dttime.Value & """"
            str += ","
            str += """" & txtprice.Text.Trim() & """"
            str += ")"
            Try
                con.Open()
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                dst.Clear()
                dad = New OleDbDataAdapter("Select * From plane Order by planedeparture", con)
                dad.Fill(dst, "Plane")
                MsgBox("Record Insertion Successfully!!!")
                Me.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!")
                MsgBox(ex.Message & "-" & ex.Source)
                con.Close()
            End Try
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class