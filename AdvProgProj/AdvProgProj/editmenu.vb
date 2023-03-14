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
Public Class editmenu

    Dim disId As Integer
    Dim old As String
    Dim bid As Integer

    Private Sub editmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source1 = New BindingSource
        dst = New DataSet
        ComboBox1.Items.Add("Economic")
        ComboBox1.Items.Add("Business")
        ComboBox1.Items.Add("Kid")
        ComboBox1.Items.Add("Senior")

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * From costumer where cosId = " & userId, con)
        dst.Clear()
        dad.Fill(dst, "costumer")

        disId = dst.Tables("costumer").Rows(0)("cosId")
        txtfname.Text = dst.Tables("costumer").Rows(0)("fname")
        txtlname.Text = dst.Tables("costumer").Rows(0)("lname")
        old = dst.Tables("costumer").Rows(0)("password")
        ComboBox1.Text = dst.Tables("costumer").Rows(0)("Type")
        bid = dst.Tables("costumer").Rows(0)("BizaId")
        con.Close()

        con.Open()
        dad = New OleDb.OleDbDataAdapter("Select * from biza where bizaId = " & bid, con)
        dst.Clear()
        dad.Fill(dst, "Biza")
        txtam.Text = dst.Tables("Biza").Rows(0)("BizaAmount")
        con.Close()
    End Sub

    Private Sub txtold_GotFocus(sender As Object, e As EventArgs) Handles txtold.GotFocus
        lbl.Text = "If you wish not to change, Leave this Blank"
    End Sub

    Private Sub txtold_LostFocus(sender As Object, e As EventArgs) Handles txtold.LostFocus
        lbl.Text = ""
    End Sub

    Private Function valid()
        If Not IsNumeric(txtam.Text) Then
            MsgBox("Must enter numeric character only")
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
        If Not txtold.Text = "" Then
            If txtpass.Text.Length > 4 Then
                If Not txtpass.Text = txtconfirm.Text Then
                    MsgBox("Password don't Match")
                    Return False
                End If
            ElseIf txtpass.Text.Length <= 4 Then
                MsgBox("Weak Password : Must have 5 or more characters")
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtold_TextChanged(sender As Object, e As EventArgs) Handles txtold.TextChanged
        btnedit.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        btnedit.Enabled = True
    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged
        btnedit.Enabled = True
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged
        btnedit.Enabled = True
    End Sub

    Private Sub txtam_TextChanged(sender As Object, e As EventArgs) Handles txtam.TextChanged
        btnedit.Enabled = True
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim changepass As Boolean = False
        If Not txtold.Text = "" Then
            changepass = True
            If Not txtold.Text = old Then
                MsgBox("Incorrect Password")
                Exit Sub
            End If
        End If

        If Not valid() Then
            Exit Sub
        End If

        Dim str
        con.Open()
        str = "update costumer set fname ="
        str += """" & txtfname.Text.Trim() & """" & "where cosid = " & userId
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        str = "update costumer set lname ="
        str += """" & txtlname.Text.Trim() & """" & "where cosid = " & userId
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        str = "update costumer set type ="
        str += """" & ComboBox1.Text.Trim() & """" & "where cosid = " & userId
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        str = "update biza set bizaAmount ="
        str += """" & txtam.Text.Trim() & """" & "where Bizaid = " & bid
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        con.Close()

        If changepass Then
            con.Open()
            str = "update costumer set password ="
            str += """" & txtpass.Text.Trim() & """" & "where cosid = " & userId
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        MsgBox("Edit Successfully")
        usermenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usermenu.Show()
        Me.Close()
    End Sub
End Class