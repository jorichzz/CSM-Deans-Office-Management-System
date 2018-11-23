Public Class ucStudentProfiling
    Dim edit As Boolean = False
    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbCourse()
        loadCmbGender()
        loadCmbScho()
        loadCmbStatus()
        loadCmbYear()
        lockEditDel()
        gbLock()
        loadDataDisplay()
        If searchStud = True Then
            unlockEditDel()
            btnCancel.Enabled = True
            transferName()
        End If
    End Sub
    Sub lockEditDel()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub gbLock()
        txtID.Enabled = False
        txtGivenName.Enabled = False
        txtLastName.Enabled = False
        txtMI.Enabled = False
        cmbCourse.Enabled = False
        cmbGender.Enabled = False
        cmbScho.Enabled = False
        cmbStatus.Enabled = False
        cmbYL.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub loadDataDisplay()
        lvStudent.Items.Clear()
        Dim status = "ACTIVE"
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT Id, name, (SELECT code from course where course.Id = course_Id), gender, (SELECT name from scholarship where scholarship.Id = scholarship_Id)," _
                                  & " (SELECT yearlevel from year where year.Id = year_Id), scholastic_Status FROM student " _
                                  & " WHERE (Status = '" & status & "') AND (Id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    lvStudent.Items.Add((i + 1))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(0))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(1))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(2))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(3))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(4))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(5))
                    lvStudent.Items(i).SubItems.Add(reader.GetString(6))
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
    Sub loadCmbCourse()
        Try
            dbConnect()
            Dim query As String = " SELECT code FROM course WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbCourse.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbScho()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM scholarship WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbScho.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbYear()
        Try
            dbConnect()
            Dim query As String = " SELECT yearlevel FROM year WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbYL.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbGender()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub
    Sub loadCmbStatus()
        cmbStatus.Items.Add("Regular")
        cmbStatus.Items.Add("Irregular")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If searchStud = True Then
            Dim maintenance As New ucSearchStudent
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
            searchStud = False
        Else
            Dim maintenance As New ucStudent
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
        End If
    End Sub

    Private Sub btntype_Click(sender As Object, e As EventArgs) Handles btntype.Click
        course = True
        Dim maintenance As New ucManageCourse
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnScho_Click(sender As Object, e As EventArgs) Handles btnScho.Click
        scholar = True
        Dim maintenance As New ucManageScholarship
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        year = True
        Dim maintenance As New ucManageYearLevel
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlockItems()
        gbUnlockExcept()
        txtID.Focus()
    End Sub
    Sub gbUnlockExcept()
        txtID.Enabled = True
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtMI.Enabled = True
        cmbCourse.Enabled = True
        cmbGender.Enabled = True
        cmbScho.Enabled = True
        cmbStatus.Enabled = True
        cmbYL.Enabled = True

        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        txtID.Enabled = True
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtMI.Enabled = True
        cmbCourse.Enabled = True
        cmbGender.Enabled = True
        cmbScho.Enabled = True
        cmbStatus.Enabled = True
        cmbYL.Enabled = True

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        gbUnlockExcept()
        unlockEditDel()
        edit = True
        txtID.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT Id,givenname,lastname,minitial,(SELECT code from course where course.Id = course_Id)," _
            & " gender, (SELECT name from scholarship where scholarship.Id = scholarship_Id)," _
            & " (SELECT yearlevel from year where year.Id = year_Id), scholastic_Status FROM student WHERE Id = '" & StudID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtID.Text = reader.GetString(0)
                    txtGivenName.Text = reader.GetString(1)
                    txtLastName.Text = reader.GetString(2)
                    txtMI.Text = reader.GetString(3)
                    cmbCourse.Text = reader.GetString(4)
                    cmbGender.Text = reader.GetString(5)
                    cmbScho.Text = reader.GetString(6)
                    cmbYL.Text = reader.GetString(7)
                    cmbStatus.Text = reader.GetString(8)
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
                Dim query As String = "UPDATE student SET Status = '" & status & "' WHERE Id = '" & StudID & "'"
                ExecuteQuery(query)
                MsgBox("Student successfully Removed!", vbInformation, "Deleted")
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
        txtID.Text = ""
        txtGivenName.Text = ""
        txtLastName.Text = ""
        txtMI.Text = ""
        cmbCourse.Text = ""
        cmbGender.Text = ""
        cmbScho.Text = ""
        cmbStatus.Text = ""
        cmbYL.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        gbLock()
        lockEditDel()
        edit = False
    End Sub
    Dim dcreated As String = DateTime.Now.ToString("MMM dd, yyyy")
    Sub save()
        Dim id As String = Trim(txtID.Text)
        Dim gname As String = Trim(txtGivenName.Text)
        Dim fname As String = Trim(txtLastName.Text)
        Dim mi As String = Trim(txtMI.Text)
        Dim course As String = cmbCourse.Text
        Dim gender As String = cmbGender.Text
        Dim scho As String = cmbScho.Text
        Dim status As String = cmbStatus.Text
        Dim year As String = cmbYL.Text
        Dim name As String = fname + "," + gname + " " + mi + "."

        If id = "" Or name = "" Or gname = "" Or fname = "" Or course = "" Or gender = "" Or scho = "" Or status = "" Or year = "" Then
            MsgBox("Please fill up all the information")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE student SET Id = '" & id & "', givenname = '" & gname & "', lastname = '" & fname & "'," _
                    & " minitial = '" & mi & "', course_Id = (select Id from course where course.code = '" & course & "'), gender = '" & gender & "'," _
                    & " scholarship_ID = (select Id from scholarship where scholarship.name = '" & scho & "'), scholastic_Status = '" & status & "'," _
                    & " year_Id = (select Id from year where year.yearlevel = '" & year & "'), name = '" & name & "' WHERE Id = '" & id & "' "
                    ExecuteQuery(query)
                    MsgBox("Student successfully Updated!", vbInformation, "Updated")
                    dbDisconnect()
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
                    Dim query As String = "INSERT INTO student SET Id = '" & id & "', givenname = '" & gname & "', lastname = '" & fname & "'," _
                    & " minitial = '" & mi & "', course_Id = (select Id from course where course.code = '" & course & "'), gender = '" & gender & "'," _
                    & " scholarship_ID = (select Id from scholarship where scholarship.name = '" & scho & "'), scholastic_Status = '" & status & "'," _
                    & " year_Id = (select Id from year where year.yearlevel = '" & year & "'), name = '" & name & "', Status ='ACTIVE', date_created ='" & dcreated & "'"

                    ExecuteQuery(query)
                    MsgBox("Student successfully Registered!", vbInformation, "Saved")

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
        txtID.Enabled = False
        txtGivenName.Enabled = False
        txtLastName.Enabled = False
        txtMI.Enabled = False
        cmbCourse.Enabled = False
        cmbGender.Enabled = False
        cmbScho.Enabled = False
        cmbStatus.Enabled = False
        cmbYL.Enabled = False
    End Sub

    Private Sub lvStudent_Click(sender As Object, e As EventArgs) Handles lvStudent.Click
        StudID = lvStudent.SelectedItems(0).SubItems(1).Text
        unlockEditDel()
        btnCancel.Enabled = True
        transferName()
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub
End Class
