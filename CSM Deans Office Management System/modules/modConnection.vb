Imports MySql.Data.MySqlClient

Module modConnection
    Public connect As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As New MySqlCommand

    Public StudID As String 'FOR SEARCHING STUDENT
    Public searchStud As Boolean = False

    Public doctype As Boolean = False
    Public course As Boolean = False
    Public scholar As Boolean = False
    Public year As Boolean = False

    Public Sub dbConnect()
        connect = New MySqlConnection("server=localhost;uid=root;pwd=;database=csmdb;")
        connect.Open()
    End Sub

    Public Sub dbDisconnect()
        connect.Close()
    End Sub

    Public Function Retrieve(query As String) As DataTable
        Dim dataTable As New DataTable
        Try
            connect.Open()
            Dim Adapter = New MySqlDataAdapter(query, connect)
            '//Adapter.SelectCommand.Parameters.AddWithValue("@param", query);
            Adapter.Fill(dataTable)
        Catch ex As Exception
            MsgBox("An Error Occured: ", ex.Message)
        Finally
            If (connect.State = System.Data.ConnectionState.Open) Then
                connect.Close()
            End If

            Retrieve = dataTable
            disposeConnection()
        End Try
    End Function
    Public Sub ExecuteQuery(query As String)
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader

    End Sub
    Public Sub ExecuteQueryParameter(query As String)
        command = New MySqlCommand(query, connect)
    End Sub

    Public Sub disposeConnection()
        connect.Dispose()
    End Sub

End Module
