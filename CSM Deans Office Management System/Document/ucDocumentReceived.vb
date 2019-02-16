Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ucDocumentLogs
    Dim edit As Boolean = False
    Dim Id As String
    Private conn As New MySqlConnection("server='localhost'; username='root'; password=''; database='csmdb'")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim document As New ucDocumentsLogs
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub ucDocumentLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Format = DateTimePickerFormat.Custom
        dtpicker.CustomFormat = "MMM dd, yyyy"
        loadCmbType()
        loadCmbCat()
        gbLock()
        lockEditDel()
        loadDataDisplay()
        If admin = False Then
            btnDelete.Visible = False
        End If
    End Sub
    Sub loadImage()
        PictureBox1.Image = Nothing
        Try
            dbConnect()
            Dim query As String = "SELECT Image FROM document WHERE Id = '" & Id & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    Dim data As Byte() = DirectCast(reader("Image"), Byte())
                    Dim ms As New MemoryStream(data)
                    PictureBox1.Image = Image.FromStream(ms)
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadDataDisplay()
        lvDoc.Items.Clear()
        Dim status = "ACTIVE"
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT Id, fileno, doc_from, (SELECT name from documenttype where (document.filetype_Id = documenttype.Id)) AS FileType, (SELECT name from documentcategory where (document.category_Id = documentcategory.Id)) AS Category, subject, receivedby, date_created FROM document WHERE Status = '" & status & "' ORDER BY Id DESC"
            ExecuteQuery(query)

            If reader.HasRows Then

                While reader.Read
                    lvDoc.Items.Add(i + 1)
                    lvDoc.Items(i).SubItems.Add(reader.GetString(0))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(1))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(2))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(3))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(4))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(5))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(6))
                    lvDoc.Items(i).SubItems.Add(reader.GetString(7))
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
        btnPrint.Enabled = False
        btnUpload.Enabled = False
    End Sub
    Sub gbLock()
        dtpicker.Enabled = False
        txtFileNo.Enabled = False
        txtSubj.Enabled = False
        txtFrom.Enabled = False
        txtreceieved.Enabled = False
        cmbFileType.Enabled = False
        cmbCategory.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnPrint.Enabled = False
        btnAdd.Enabled = True
        btnUpload.Enabled = False
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
    Sub loadCmbCat()
        Try
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
    Private Sub btntype_Click(sender As Object, e As EventArgs) Handles btntype.Click
        doctype1 = True
        Dim maintenance As New ucManageDocumentType
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlockItems()
        gbUnlockExcept()
        txtFrom.Focus()
    End Sub
    Sub gbUnlockExcept()
        cmbFileType.Enabled = True
        cmbCategory.Enabled = True
        txtFileNo.Enabled = True
        txtFrom.Enabled = True
        txtSubj.Enabled = True
        txtreceieved.Enabled = True
        dtpicker.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnPrint.Enabled = False
        btnUpload.Enabled = True
    End Sub
    Sub unlockItems()
        cmbFileType.Enabled = True
        cmbCategory.Enabled = True
        txtFileNo.Enabled = True
        txtFrom.Enabled = True
        txtSubj.Enabled = True
        txtreceieved.Enabled = True
        dtpicker.Enabled = True
        btnUpload.Enabled = True
    End Sub
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        doccat1 = True
        Dim maintenance As New ucManageDocumentCategory
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        gbUnlockExcept()
        unlockEditDel()
        edit = True
        btnPrint.Enabled = False
        txtFrom.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnPrint.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT Id, fileno, doc_from, (SELECT name from documenttype where (document.filetype_Id = documenttype.Id)) AS FileType, (SELECT name from documentcategory where (document.category_Id = documentcategory.Id)) AS Category, subject, receivedby, date_created FROM document WHERE Id = '" & Id & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtFileNo.Text = reader.GetString(1)
                    txtFrom.Text = reader.GetString(2)
                    cmbFileType.Text = reader.GetString(3)
                    cmbCategory.Text = reader.GetString(4)
                    txtSubj.Text = reader.GetString(5)
                    txtreceieved.Text = reader.GetString(6)
                    dtpicker.Value = reader.GetString(7)
                End While
            End If
            dbDisconnect()
            loadImage()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub delete()
        If MsgBox("Are you sure you want to delete?", vbYesNo, "Dean's Record Tracking System") = vbYes Then
            Try
                Dim status = "DELETED"
                dbConnect()
                Dim query As String = "UPDATE document SET Status = '" & status & "' WHERE Id = '" & Id & "'"
                ExecuteQuery(query)
                MsgBox("Document successfully Removed!", vbInformation, "Deleted")
                loadDataDisplay()
                clear()
                lockEditDel()
                dbDisconnect()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try
        ElseIf vbNo Then
            Exit Sub
        End If
    End Sub
    Sub clear()
        txtFileNo.Text = ""
        txtFrom.Text = ""
        txtSubj.Text = ""
        cmbCategory.Text = ""
        cmbFileType.Text = ""
        txtreceieved.Text = ""
        dtpicker.Value = DateTime.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Sub save()
        Dim fileno As String = txtFileNo.Text
        Dim from As String = txtFrom.Text
        Dim subj As String = txtSubj.Text
        Dim cat As String = cmbCategory.Text
        Dim type As String = cmbFileType.Text
        Dim rec As String = txtreceieved.Text
        Dim dt As String = dtpicker.Value.ToString("MMM dd, yyyy")

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        If fileno = "" Or from = "" Or subj = "" Or cat = "" Or type = "" Or dt = "" Or rec = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE document SET fileno = '" & fileno & "', date_created = '" & dt & "', subject = '" & subj & "'," _
                                          & " doc_from = '" & from & "', filetype_Id = (select Id from documenttype where name = '" & type & "')," _
                                          & " category_Id = (select Id from documentcategory where name = '" & cat & "'),receivedby = '" & rec & "' WHERE Id = '" & Id & "' "
                    ExecuteQuery(query)

                    dbDisconnect()

                    query = "UPDATE document SET Image = @image WHERE Id = '" & Id & "'"
                    ExecuteQueryParameter(query)
                    command.Parameters.Add("@image", MySqlDbType.Blob).Value = ms.ToArray()

                    connect.Open()
                    command.ExecuteNonQuery()
                    dbDisconnect()
                    MsgBox("Document successfully Updated!", vbInformation, "Updated")
                Catch ex As Exception
                    clear()
                    lockEditDel()
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try


                loadDataDisplay()
                edit = False
            Else
                Try
                    dbConnect()
                    Dim query As String = "INSERT INTO document SET fileno = '" & fileno & "', date_created = '" & dt & "', subject = '" & subj & "'," _
                                          & " doc_from = '" & from & "', filetype_Id = (select Id from documenttype where name = '" & type & "')," _
                                          & " category_Id = (select Id from documentcategory where name = '" & cat & "'), receivedby = '" & rec & "', Status = 'ACTIVE'"

                    ExecuteQuery(query)
                    dbDisconnect()

                    query = "UPDATE document SET Image = @image ORDER BY Id DESC LIMIT 1"
                    ExecuteQueryParameter(query)
                    command.Parameters.Add("@image", MySqlDbType.Blob).Value = ms.ToArray()

                    connect.Open()
                    command.ExecuteNonQuery()
                    dbDisconnect()
                    MsgBox("Document successfully Registered!", vbInformation, "Saved")

                    clear()

                    loadDataDisplay()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try
                edit = False
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lockItems()
        gbLock()
        clear()
    End Sub
    Sub lockItems()
        dtpicker.Enabled = False
        txtFileNo.Enabled = False
        txtSubj.Enabled = False
        txtFrom.Enabled = False
        txtreceieved.Enabled = False
        cmbFileType.Enabled = False
        cmbCategory.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnPrint.Enabled = False
        btnAdd.Enabled = True
        btnUpload.Enabled = False
    End Sub

    Private Sub lvDoc_Click(sender As Object, e As EventArgs) Handles lvDoc.Click
        Id = lvDoc.SelectedItems(0).SubItems(1).Text
        unlockEditDel()
        btnCancel.Enabled = True
        transferName()
    End Sub

    Private Sub txtFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrom.KeyPress, txtreceieved.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtFileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFileNo.KeyPress
        NumOnly(e)
    End Sub

    Private Sub txtSubj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubj.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtSubj_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSubj.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim query As String
            Dim cmd As MySqlCommand
            Dim adp As New MySqlDataAdapter
            Dim dt As New DataSet
            conn.Open()
            query = "SELECT Image FROM document WHERE Id = '" & Id & "'"

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
End Class
