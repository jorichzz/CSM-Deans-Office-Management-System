Public Class ucManageCourse
    Dim edit As Boolean = False
    Dim Id As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If course = True Then
            Dim maintenance As New ucStudentProfiling
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
            course = False
        Else
            Dim maintenance As New ucStudentMaintenance
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
        End If
    End Sub
    Private Sub ucManageCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtCode.Enabled = False
        txtDescription.Enabled = False
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
            Dim query As String = "SELECT * FROM course WHERE Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvUser.Items.Add(reader.GetString("Id"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("code"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("description"))
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        loadCourseID()
        unlockItems()
        gbUnlockExcept()
        txtCode.Focus()
    End Sub
    Sub gbUnlockExcept()
        txtCode.Enabled = True
        txtDescription.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        txtCode.Enabled = True
        txtDescription.Enabled = True
    End Sub
    Sub loadCourseID()
        Try
            dbConnect()
            Dim query As String = "SELECT Id from course ORDER BY Id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCourseID.Text = "COURSE" & Val(Mid(reader.GetString(0), 7, 11)) + 1
                End While
            Else
                txtCourseID.Text = "COURSE1001"
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
        txtCode.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM course WHERE Id = '" & Id & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtCode.Text = reader.GetString(1)
                    txtDescription.Text = reader.GetString(2)
                    txtCourseID.Text = Id
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
                Dim query As String = "UPDATE course SET Status = '" & status & "' WHERE Id = '" & Id & "'"
                ExecuteQuery(query)
                MsgBox("Course successfully Removed!", vbInformation, "Deleted")
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
        txtCourseID.Text = ""
        txtCode.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Dim dcreated As String = DateTime.Now.ToString("MMM dd, yyyy")
    Sub save()
        Dim id As String = txtCourseID.Text
        Dim code As String = Trim(txtCode.Text)
        Dim desc As String = Trim(txtDescription.Text)

        If id = "" Or desc = "" Or code = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE course SET code = '" & code & "', description = '" & desc & "' WHERE Id = '" & id & "' "
                    ExecuteQuery(query)
                    MsgBox("Course successfully Updated!", vbInformation, "Updated")
                    dbDisconnect()
                Catch ex As Exception
                    clear()
                    lockEditDel()
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try

                loadCourseID()
                loadDataDisplay()
                edit = False
            Else
                Try
                    dbConnect()
                    Dim query As String = "INSERT INTO course SET Id  = '" & id & "', code ='" & code & "', description ='" & desc & "', Status ='ACTIVE', date_created ='" & dcreated & "'"

                    ExecuteQuery(query)
                    MsgBox("Course successfully Registered!", vbInformation, "Saved")

                    clear()
                    loadCourseID()
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
        txtCode.Enabled = False
        txtDescription.Enabled = False
        txtCourseID.Enabled = False
    End Sub

    Private Sub lvUser_Click(sender As Object, e As EventArgs) Handles lvUser.Click
        Id = lvUser.Items(lvUser.SelectedIndices(0)).Text
        unlockEditDel()
        btnCancel.Enabled = True
        transferName()
    End Sub
End Class
