Imports System.Data.OleDb

Public Class DBControl
    ' Create a DB Connection
    Private connDB As String = My.Settings.MyConn

    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QBankDB.accdb")
    'Private DBCon As New OleDbConnection(connDB)

    ' Create DB Command
    Private DBCmd As OleDbCommand

    ' DB Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' Query Parameters
    Public Params As New List(Of OleDbParameter)

    ' Query Statistics
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' Reset Query Statistics
        RecordCount = 0
        Exception = ""

        Try
            ' Open a Connection
            DBCon.Open()

            ' Create Database Command
            DBCmd = New OleDbCommand(Query, DBCon)

            ' Load Params into DBCom
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' Clear Params list
            Params.Clear()

            ' Execute Command and fill dataset (DataTable)
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)

            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' Close the connection
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    ' Include Query and command parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim newParam As New OleDbParameter(Name, Value)
        Params.Add(newParam)
    End Sub

End Class
