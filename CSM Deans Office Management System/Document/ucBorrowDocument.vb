Public Class ucBorrowDocument
    Dim edit As Boolean = False
    Dim Id As String
    Dim txtDocTypeID As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim document As New ucDocument
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub btntype_Click(sender As Object, e As EventArgs) Handles btntype.Click
        bdoccat = True
        Dim maintenance As New ucManageDocsBorrowable
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        loadDocTypeID()
        unlockItems()
        gbUnlockExcept()
        txtFileNo.Focus()
    End Sub
    Sub loadCmbCat()
        cmbFileType.Items.Clear()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM bdocumentcategory WHERE Status = 'ACTIVE'"
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
    Sub gbUnlockExcept()
        cmbFileType.Enabled = True
        dtpicker.Enabled = True
        txtFileNo.Enabled = True
        txtBorrower.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        cmbFileType.Enabled = True
        dtpicker.Enabled = True
        txtFileNo.Enabled = True
        txtBorrower.Enabled = True
    End Sub
    Sub loadDocTypeID()
        Try
            dbConnect()
            Dim query As String = "SELECT Id from borroweddocument ORDER BY Id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtDocTypeID = "BDID" & Val(Mid(reader.GetString(0), 5, 9)) + 1
                End While
            Else
                txtDocTypeID = "BDID1001"
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub ucManageDocumentType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbCat()
        lockEditDel()
        gbLock()
        loadDataDisplay()
    End Sub
    Sub lockEditDel()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnReturn.Enabled = False
    End Sub
    Sub gbLock()
        cmbFileType.Enabled = False
        dtpicker.Enabled = False
        txtFileNo.Enabled = False
        txtBorrower.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnReturn.Enabled = False
    End Sub
    Sub loadDataDisplay()
        lvUser.Items.Clear()
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT * FROM search_borrowed WHERE category LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%' ORDER BY Id DESC"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvUser.Items.Add(i + 1)
                    lvUser.Items(i).SubItems.Add(reader.GetString(0))
                    lvUser.Items(i).SubItems.Add(reader.GetString(1))
                    lvUser.Items(i).SubItems.Add(reader.GetString(2))
                    lvUser.Items(i).SubItems.Add(reader.GetString(3))
                    lvUser.Items(i).SubItems.Add(reader.GetString(4))
                    lvUser.Items(i).SubItems.Add(reader.GetString(5))
                    If reader.GetString(6) = "BORROWED" Then
                        lvUser.Items(i).BackColor = Color.Pink
                    Else
                        lvUser.Items(i).BackColor = Color.LightGreen
                    End If
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        gbUnlockExcept()
        unlockEditDel()
        edit = True
        txtFileNo.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnReturn.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM search_borrowed WHERE Id = '" & Id & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtDocTypeID = reader.GetString(0)
                    txtFileNo.Text = reader.GetString(1)
                    txtBorrower.Text = reader.GetString(2)
                    cmbFileType.Text = reader.GetString(3)
                    dtpicker.Text = reader.GetString(4)
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            returned()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub returned()
        Dim stat As String
        dbConnect()
        Dim query As String = "SELECT Status from borroweddocument WHERE Id = '" & Id & "'"
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                stat = reader.GetString(0)
            End While
        End If
        dbDisconnect()
        If stat = "BORROWED" Then
            Try
                Dim status = "RETURNED"
                Dim dcreated As String = Date.Now.ToString("MMM dd, yyyy")
                dbConnect()
                query = "UPDATE borroweddocument SET Status = '" & status & "', date_returned = '" & dcreated & "' WHERE Id = '" & Id & "'"
                ExecuteQuery(query)
                MsgBox("Borrowed Document successfully Return!", vbInformation, "Return")
                loadDataDisplay()
                clear()
                lockEditDel()
                dbDisconnect()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try
        ElseIf stat = "RETURNED" Then
            Try
                Dim status = "BORROWED"
                Dim dcreated As String = ""
                dbConnect()
                query = "UPDATE borroweddocument SET Status = '" & status & "', date_returned = '" & dcreated & "' WHERE Id = '" & Id & "'"
                ExecuteQuery(query)
                MsgBox("Borrowed Document successfully Reborrowed!", vbInformation, "Return")
                loadDataDisplay()
                clear()
                lockEditDel()
                dbDisconnect()
            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()
            End Try
        End If

    End Sub
    Sub clear()
        txtDocTypeID = ""
        txtFileNo.Text = ""
        txtBorrower.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Sub save()
        Dim id As String = txtDocTypeID
        Dim name As String = Trim(txtFileNo.Text)
        Dim borrower As String = Trim(txtBorrower.Text)
        Dim cat As String = cmbFileType.Text
        Dim dcreated As String = dtpicker.Value.ToString("MMM dd, yyyy")

        If id = "" Or name = "" Or borrower = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE borroweddocument SET borrowedby = '" & borrower & "', name = '" & name & "', date_borrowed = '" & dcreated & "', bcategory_Id = (select Id from bdocumentcategory where name = '" & cat & "') WHERE Id = '" & id & "' "
                    ExecuteQuery(query)
                    MsgBox("Borrowed Document successfully Updated!", vbInformation, "Updated")
                    dbDisconnect()
                Catch ex As Exception
                    clear()
                    lockEditDel()
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try

                loadDocTypeID()
                loadDataDisplay()
                edit = False
            Else
                Try
                    dbConnect()
                    Dim query As String = "INSERT INTO borroweddocument SET Id  = '" & id & "', borrowedby = '" & borrower & "', name ='" & name & "', bcategory_Id = (select Id from bdocumentcategory where name = '" & cat & "'), Status ='BORROWED', date_borrowed ='" & dcreated & "'"

                    ExecuteQuery(query)
                    MsgBox("Borrowed Document successfully Registered!", vbInformation, "Saved")

                    clear()
                    loadDocTypeID()
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
        txtFileNo.Enabled = False
        txtBorrower.Enabled = False
        cmbFileType.Enabled = False
        dtpicker.Enabled = False
    End Sub

    Private Sub lvUser_Click(sender As Object, e As EventArgs) Handles lvUser.Click
        Id = lvUser.SelectedItems(0).SubItems(1).Text
        unlockEditDel()
        btnCancel.Enabled = True
        transferName()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFileNo.KeyPress, txtBorrower.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFileNo.KeyDown, txtBorrower.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub
End Class
