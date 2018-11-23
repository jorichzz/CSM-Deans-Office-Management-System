Public Class ucDocumentReceived
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim document As New ucDocument
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub ucDocumentLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Format = DateTimePickerFormat.Custom
        dtpicker.CustomFormat = "MMM dd, yyyy"
        loadCmbType()
        gbLock()
        lockEditDel()
        loadDataDisplay()
    End Sub
    Sub loadDataDisplay()
        lvDoc.Items.Clear()
        Dim status = "ACTIVE"
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT (SELECT name from documenttype where (document.filetype_Id = documenttype.Id)) AS FileType, fileno, subject, date_created FROM document WHERE Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then

                While reader.Read
                    lvDoc.Items.Add(i + 1)
                    lvDoc.Items(i).SubItems.Add(reader.GetString(0))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(1))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(2))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(3))
                    i += 1
                End While
            End If

            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show("An Error Occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub lockEditDel()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Sub gbLock()
        dtpicker.Enabled = False
        txtFileNo.Enabled = False
        txtSubj.Enabled = False
        cmbFileType.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
    End Sub
    Sub loadCmbType()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM documenttype WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbFileType.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btntype_Click(sender As Object, e As EventArgs) Handles btntype.Click
        doctype = True
        Dim maintenance As New ucManageDocumentType
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
