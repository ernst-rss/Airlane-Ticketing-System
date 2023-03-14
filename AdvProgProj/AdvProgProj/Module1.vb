Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=..\ARES.accdb")
    Public dad As OleDbDataAdapter
    Public drd As OleDbDataReader
    Public cmd As OleDbCommand
    Public dst As New DataSet
    Public currentrow As Integer
    Public tables As DataTableCollection
    Public source1 As New BindingSource
    Public cmds As String

    Public userId As Integer
    Public receipt As String
    Public ind As Integer
    Public planeid As Integer

    Public updating As Boolean
    Public planes As String
    Public planeprice As Integer
    Public planedest As String
    Public planetime As DateTime

    Public fromAll As Boolean = False
End Module