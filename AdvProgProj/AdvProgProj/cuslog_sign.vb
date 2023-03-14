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
Public Class cuslog_sign

    Private Sub cuslog_sign_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Application.Exit()
    End Sub

    Private Sub cuslog_sign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source1 = New BindingSource
        dst = New DataSet
        ComboBox1.Items.Add("Economic")
        ComboBox1.Items.Add("Business")
        ComboBox1.Items.Add("Kid")
        ComboBox1.Items.Add("Senior")
        ComboBox1.Text = "Economic"

    End Sub

    Private Function valid() As Boolean
        If IsNumeric(txtid.Text) Then
            If txtid.Text.Length > 3 Then
                MsgBox("No ID longer than 3 digits")
                txtid.SelectAll()
                
                Return False
            End If
        ElseIf Not IsNumeric(txtid.Text) Then
            MsgBox("Must enter numeric character only on ID")
            txtid.Focus()
            txtid.SelectAll()
            Return False
        End If

        If IsNumeric(txtbid.Text) Then
            If txtbid.Text.Length > 3 Then
                MsgBox("No BizaID longer than 3 digits")

                txtbid.SelectAll()

                Return False
            End If
        ElseIf Not IsNumeric(txtbid.Text) Then
            MsgBox("Must enter numeric character only in Biza ID")
            txtid.Focus()
            txtid.SelectAll()
            Return False
        End If

        If Not IsNumeric(txtam.Text) Then
            MsgBox("Must enter numeric character only in Amount")
            txtam.Focus()
            txtam.SelectAll()
            Return False
        End If


        If txtfname.Text <> "" Or txtlname.Text <> "" Then
            Dim i As Integer
            Dim ch As Char
            i = 0
            While i < txtfname.Text.Length
                ch = txtfname.Text.Chars(i)
                If IsNumeric(ch) = True Then
                    MsgBox("Must don't have numeric in Name")
                    Return False
                End If
                i += 1
            End While
            While i < txtlname.Text.Length
                ch = txtlname.Text.Chars(i)
                If IsNumeric(ch) = True Then
                    MsgBox("Must don't have numeric in Name")
                    Return False
                End If
                i += 1
            End While
        ElseIf txtfname.Text = "" Or txtlname.Text = "" Then
            Return False
        End If

        If txtpass.Text.Length > 4 Then
            If Not txtpass.Text = txtconfirm.Text Then
                MsgBox("Password don't Match")
                Return False
            End If
        ElseIf txtpass.Text.Length <= 4 Then
            MsgBox("Weak Password : Must have 5 or more characters")
            Return False
        End If

        Return True
    End Function


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If valid() Then
            Dim str As String
            str = "Insert into Costumer values("
            str += txtid.Text.Trim()
            str += ","
            str += """" & txtlname.Text.Trim() & """"
            str += ","
            str += """" & txtfname.Text.Trim() & """"
            str += ","
            str += """" & ComboBox1.Text.Trim() & """"
            str += ","
            str += """" & txtbid.Text.Trim() & """"
            str += ","
            str += """" & txtpass.Text.Trim() & """"
            str += ")"
            Try
                con.Open()
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Account Created Successfully")
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Could Not Create Account!!")
                MsgBox(ex.Message & "-" & ex.Source)
                con.Close()
            End Try
            str = "Insert into BiZa values("
            str += txtbid.Text.Trim()
            str += ","
            str += """" & txtam.Text.Trim() & """"
            str += ")"
            Try
                con.Open()
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Could Not Create Account!!")
                MsgBox(ex.Message & "-" & ex.Source)
                con.Close()
            End Try
            cuslog.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cuslog.Show()
        Me.Hide()
    End Sub
End Class