Public Class frmSearchFaculty
    Private Sub frmSearchFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
    End Sub
    Sub loadDataDisplay()
        lvFaculty.Items.Clear()
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT * FROM search_faculty WHERE Id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvFaculty.Items.Add((i + 1))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(0))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(1))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(2))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(3))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(4))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(5))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(6))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(7))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(8))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(9))
                    lvFaculty.Items(i).SubItems.Add(reader.GetString(10))
                    i += 1
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub lvFaculty_DoubleClick(sender As Object, e As EventArgs) Handles lvFaculty.DoubleClick
        FacuID = lvFaculty.SelectedItems(0).SubItems(1).Text
        searchFacu = True
        Me.Hide()
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        searchFacu = False
        Me.Hide()
    End Sub
End Class