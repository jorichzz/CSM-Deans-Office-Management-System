Public Class ucManageDepartment
    Dim edit As Boolean = False
    Dim Id As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If dept = True Then
            Dim maintenance As New ucFacultyProfiling
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
            dept = False
        Else
            Dim maintenance As New ucFacultyMaintenance
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        loadDocTypeID()
        unlockItems()
        gbUnlockExcept()
        txtName.Focus()
    End Sub
    Sub gbUnlockExcept()
        txtName.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        txtName.Enabled = True
    End Sub
    Sub loadDocTypeID()
        Try
            dbConnect()
            Dim query As String = "SELECT Id from department ORDER BY Id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtDocTypeID.Text = "DEPT" & Val(Mid(reader.GetString(0), 5, 9)) + 1
                End While
            Else
                txtDocTypeID.Text = "DEPT1001"
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub ucManageDocumentCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lockEditDel()
        gbLock()
        loadDataDisplay()
        If admin = False Then
            btnDel.Visible = False
        End If
    End Sub
    Sub lockEditDel()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub gbLock()
        txtName.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub loadDataDisplay()
        lvUser.Items.Clear()
        Dim status = "ACTIVE"
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT Id, name FROM department WHERE Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvUser.Items.Add(reader.GetString("Id"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("name"))
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
        txtName.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM department WHERE Id = '" & Id & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtName.Text = reader.GetString(1)
                    txtDocTypeID.Text = Id
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
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
                Dim query As String = "UPDATE department SET Status = '" & status & "' WHERE Id = '" & Id & "'"
                ExecuteQuery(query)
                MsgBox("Department successfully Removed!", vbInformation, "Deleted")
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
        txtDocTypeID.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Dim dcreated As String = DateTime.Now.ToString("MMM dd, yyyy")
    Sub save()
        Dim id As String = txtDocTypeID.Text
        Dim name As String = Trim(txtName.Text)

        If id = "" Or name = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE department SET name = '" & name & "' WHERE Id = '" & id & "' "
                    ExecuteQuery(query)
                    MsgBox("Department successfully Updated!", vbInformation, "Updated")
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
                    Dim query As String = "INSERT INTO department SET Id  = '" & id & "', name ='" & name & "', Status ='ACTIVE', date_created ='" & dcreated & "'"

                    ExecuteQuery(query)
                    MsgBox("Department successfully Registered!", vbInformation, "Saved")

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
        txtName.Enabled = False
        txtDocTypeID.Enabled = False
    End Sub

    Private Sub lvUser_Click(sender As Object, e As EventArgs) Handles lvUser.Click
        Id = lvUser.Items(lvUser.SelectedIndices(0)).Text
        unlockEditDel()
        btnCancel.Enabled = True
        transferName()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        CharOnly(e)
    End Sub
End Class
