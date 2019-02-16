Public Class ucManageUser
    Dim edit As Boolean = False
    Dim userID As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucUserMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub ucManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lockEditDel()
        gbLock()
        loadCmbQuestion()
        loadDataDisplay()
    End Sub
    Sub loadCmbQuestion()
        Try
            dbConnect()
            Dim query As String = " SELECT question FROM question"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbQuestion.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Sub lockEditDel()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub gbLock()
        txtGivenName.Enabled = False
        txtLastName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cmbQuestion.Enabled = False
        txtAnswer.Enabled = False
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
            Dim query As String = "SELECT Id, givenname, lastname, name, username, password, user_type, date_created FROM user WHERE user_type != 'SuperAdmin' AND user_Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvUser.Items.Add(reader.GetString("Id"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("name"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("givenname"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("lastname"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("username"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("password"))
                    lvUser.Items(i).SubItems.Add(reader.GetString("date_created"))
                    i += 1
                End While
            End If

            dbDisconnect()

            'dbConnect()
            'query = "SELECT user_Name FROM user "
            'If reader.HasRows Then
            '    While reader.Read
            '        frmDashboard.txtName.Text = reader.GetString(3)
            '    End While
            'End If
            'dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        loadUserID()
        unlockItems()
        gbUnlockExcept()
        txtGivenName.Focus()
    End Sub
    Sub gbUnlockExcept()
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtAnswer.Enabled = True
        cmbQuestion.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtPassword.Enabled = True
        txtUsername.Enabled = True
    End Sub
    Sub loadUserID()
        Try
            dbConnect()
            Dim query As String = "SELECT Id from user ORDER BY Id DESC LIMIT 1"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtUserID.Text = "USR" & Val(Mid(reader.GetString(0), 4, 6)) + 1
                End While
            Else
                txtUserID.Text = "USR1001"
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
        txtGivenName.Focus()
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT Id, name, givenname, lastname, username, password, user_type, user_Status, (SELECT question from question where question_Id = question.Id ), user_Answer, date_created FROM user WHERE Id = '" & userID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtGivenName.Text = reader.GetString(2)
                    txtLastName.Text = reader.GetString(3)
                    txtUsername.Text = reader.GetString(4)
                    txtPassword.Text = reader.GetString(5)
                    cmbQuestion.Text = reader.GetString(8)
                    txtAnswer.Text = reader.GetString(9)
                    txtUserID.Text = userID
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
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
        If MsgBox("Are you sure you want to delete?", vbYesNo, "POS and Inventory System") = vbYes Then
            Try
                Dim status = "DELETED"
                dbConnect()
                Dim query As String = "UPDATE user SET user_Status = '" & status & "' WHERE Id = '" & userID & "'"
                ExecuteQuery(query)
                MsgBox("User Account successfully Removed!", vbInformation, "Deleted")
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
        Dim maintenance As New ucManageUser
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Dim dcreated As String = DateTime.Now.ToString("MMM dd, yyyy")
    Sub save()
        Dim id As String = txtUserID.Text
        Dim gname As String = Trim(txtGivenName.Text)
        Dim fname As String = Trim(txtLastName.Text)
        Dim fullname As String = gname + " " + fname
        Dim un As String = Trim(txtUsername.Text)
        Dim pwd As String = Trim(txtPassword.Text)
        Dim question As String = Trim(cmbQuestion.Text)
        Dim answer As String = Trim(txtAnswer.Text)

        If id = "" Or gname = "" Or fname = "" Or fullname = "" Or un = "" Or pwd = "" Or question = "" Or answer = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE user SET givenname = '" & gname & "', lastname = '" & fname & "', name = '" & fullname & "', " _
                        & "  username = '" & un & "', password = '" & pwd & "', question_Id = (SELECT Id from question WHERE question = '" & question & "' ), user_Answer = '" & answer & "' WHERE Id = '" & userID & "' "
                    ExecuteQuery(query)
                    MsgBox("User successfully Updated!", vbInformation, "Updated")
                    dbDisconnect()
                Catch ex As Exception
                    clear()
                    lockEditDel()
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try

                loadUserID()
                loadDataDisplay()
                edit = False
            Else
                Try
                    dbConnect()
                    Dim query As String = "INSERT INTO user SET Id  = '" & id & "', user_type='User', name = '" & fullname & "', " _
                            & " givenname = '" & gname & "', lastname = '" & fname & "', username = '" & un & "', " _
                            & " password = '" & pwd & "', question_Id = (SELECT Id from question WHERE question = '" & question & "' ), user_Answer = '" & answer & "' , date_created = '" & dcreated & "', user_Status = 'ACTIVE'"

                    ExecuteQuery(query)
                    MsgBox("User successfully Registered!", vbInformation, "Saved")

                    clear()
                    loadUserID()
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

    Private Sub lvUser_Click(sender As Object, e As EventArgs) Handles lvUser.Click
        userID = lvUser.Items(lvUser.SelectedIndices(0)).Text
        transferName()
        unlockEditDel()
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lockItems()
        gbLock()
        clear()
    End Sub
    Sub lockItems()
        txtGivenName.Enabled = False
        txtLastName.Enabled = False
        txtPassword.Enabled = False
        txtUsername.Enabled = False
        txtAnswer.Enabled = False
        cmbQuestion.Enabled = False
    End Sub
End Class
