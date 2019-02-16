Imports MySql.Data.MySqlClient
Public Class ucSearchDocs
    Private conn As New MySqlConnection("server='localhost'; username='root'; password=''; database='csmdb'")
    Dim Id As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If fromreceived = True Then
            Dim document As New ucDocumenDelivered
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(document)
            fromreceived = False
        Else
            Dim document As New ucSearchDocument
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(document)
        End If
    End Sub

    Private Sub ucSearchDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbType()
        loadCmbCategory()
        cmbType.SelectedIndex = 0
        cmbCategory.SelectedIndex = 0
        loadDataDisplay()
        txtSearch.Focus()

        If recieve = "recieved" Then
            Label1.Text = "Search Recieved Document"
            lvReceived.Visible = True
            lvDelivered.Visible = False
        Else
            Label1.Text = "Search Delivered Document"
            lvReceived.Visible = False
            lvDelivered.Visible = True
        End If
    End Sub
    Sub loadDataDisplay()
        Dim dtype, dcat As String
        dtype = cmbType.Text
        dcat = cmbCategory.Text
        lvReceived.Items.Clear()
        lvDelivered.Items.Clear()
        If cmbCategory.Text = "All" Then
            dcat = ""
        Else
            dcat = cmbCategory.Text
        End If
        If cmbType.Text = "All" Then
            dtype = ""
        Else
            dtype = cmbType.Text
        End If
        Try
            Dim query As String
            Dim i As Integer = 0
            dbConnect()
            If recieve = "recieved" Then
                query = "SELECT * FROM search_received WHERE (fileno LIKE '%" & txtSearch.Text & "%' OR subject LIKE '%" & txtSearch.Text & "%' OR doc_from LIKE '%" & txtSearch.Text & "%') AND FileType LIKE '%" & dtype & "%' AND Category LIKE '%" & dcat & "%' ORDER BY Id DESC"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        lvReceived.Items.Add((i + 1))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(0))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(1))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(2))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(3))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(4))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(5))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(6))
                        lvReceived.Items(i).SubItems.Add(reader.GetString(7))
                        i += 1
                    End While
                End If
            Else
                query = "SELECT * FROM search_delivered WHERE (fileno LIKE '%" & txtSearch.Text & "%' OR subject LIKE '%" & txtSearch.Text & "%' OR doc_from LIKE '%" & txtSearch.Text & "%') AND FileType LIKE '%" & dtype & "%' AND Category LIKE '%" & dcat & "%' ORDER BY Id DESC"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        lvDelivered.Items.Add((i + 1))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(0))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(1))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(2))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(3))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(4))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(5))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(6))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(7))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(8))
                        lvDelivered.Items(i).SubItems.Add(reader.GetString(9))
                        i += 1
                    End While
                End If
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbType()
        Try
            cmbType.Items.Add("All")
            dbConnect()
            Dim query As String = " SELECT name FROM documenttype WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbType.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbCategory()
        Try
            cmbCategory.Items.Add("All")
            dbConnect()
            Dim query As String = " SELECT name FROM documentcategory WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbCategory.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub lvReceived_DoubleClick(sender As Object, e As EventArgs) Handles lvReceived.DoubleClick
        If fromreceived = True Then
            docID = lvReceived.SelectedItems(0).SubItems(1).Text
            searchdoc = True
            Dim student As New ucDocumenDelivered
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(student)
            fromreceived = False
        Else
            docID = lvReceived.SelectedItems(0).SubItems(1).Text
            Try
                Dim query As String
                Dim i As Integer = 0
                Dim folder As String

                dbConnect()
                query = "SELECT * FROM search_received WHERE Id = '" & docID & "'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        folder = reader.GetString(3) + " " + reader.GetString(4)
                    End While
                End If
                dbDisconnect()
                MsgBox("This specific document is in the folder '" + folder + "' and located at the document cabinet")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                disposeConnection()
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim query As String
            Dim cmd As MySqlCommand
            Dim adp As New MySqlDataAdapter
            Dim dt As New DataSet
            conn.Open()
            If recieve = "recieved" Then
                query = "SELECT Image FROM document WHERE Id = '" & Id & "'"
            Else
                query = "SELECT Image FROM documentdelivered WHERE Id = '" & Id & "'"
            End If


            cmd = New MySqlCommand(query, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "DocumentPrint")

            Dim report As New CrystalReportImage
            report.SetDataSource(dt)
            frmReport.CrystalReportViewer1.ReportSource = report
            frmReport.CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            conn.Close()
            frmReport.Show()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub lvDelivered_Click(sender As Object, e As EventArgs) Handles lvDelivered.Click
        Id = lvDelivered.SelectedItems(0).SubItems(1).Text
        btnPrint.Enabled = True
    End Sub

    Private Sub lvReceived_Click(sender As Object, e As EventArgs) Handles lvReceived.Click
        Id = lvReceived.SelectedItems(0).SubItems(1).Text
        btnPrint.Enabled = True
    End Sub

    Private Sub lvDelivered_DoubleClick(sender As Object, e As EventArgs) Handles lvDelivered.DoubleClick
        docID = lvDelivered.SelectedItems(0).SubItems(1).Text
        Try
            Dim query As String
            Dim i As Integer = 0
            Dim folder As String

            dbConnect()
            query = "SELECT * FROM search_delivered WHERE Id = '" & docID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    folder = reader.GetString(3) + " " + reader.GetString(4)
                End While
            End If
            dbDisconnect()
            MsgBox("This specific document is in the folder '" + folder + "' and located at the document cabinet")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
End Class
