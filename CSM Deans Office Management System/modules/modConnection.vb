Imports MySql.Data.MySqlClient

Module modConnection
    Public schoolyear As String
    Public pres As String
    Public vpaa As String

    Public connect As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As New MySqlCommand

    'FOR SEARCHING STUDENT
    Public StudID As String
    Public searchStud As Boolean = False

    'FOR SEARCHING FACULTY
    Public FacuID As String
    Public searchFacu As Boolean = False

    'FOR SEARCHING DOCUMENT FROM RECEIVED
    Public fromreceived As Boolean = False
    Public recieve As String
    Public docID As String

    'FOR SEARCHING Document
    Public searchdoc As Boolean = False

    'FOR MAINTENANCE PORPOSE

    Public admin As Boolean = False

    'DOCUMENT
    Public bdoccat As Boolean = False
    Public doctype1 As Boolean = False
    Public doctype2 As Boolean = False
    Public doccat1 As Boolean = False
    Public doccat2 As Boolean = False
    'STUDENT
    Public course As Boolean = False
    Public scholar As Boolean = False
    Public year As Boolean = False
    'FACULTY
    Public dept As Boolean = False
    Public schoolgrad As Boolean = False
    Public design As Boolean = False
    Public eligi As Boolean = False
    Public Sub setfalse()
        'FOR MAINTENANCE PORPOSE
        'DOCUMENT
        bdoccat = False
        doctype1 = False
        doctype2 = False
        doccat1 = False
        doccat2 = False
        'STUDENT
        course = False
        scholar = False
        year = False
        'FACULTY
        dept = False
        schoolgrad = False
        design = False
        eligi = False
    End Sub


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
