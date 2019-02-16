Public Class ucFacultyProfiling
    Dim edit As Boolean = False
    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbDepartment()
        loadCmbDesignation()
        loadCmbSchoolGrad()
        loadCmbEligibility()
        loadCmbTA()
        loadCmbWA()
        loadCmbAR()
        loadCmbHEA()
        loadCmbGender()
        loadCmbYGYH()
        lockEditDel()
        gbLock()
        If admin = False Then
            btnDel.Visible = False
        End If
        txtSearch.Focus()
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
        cmbGender.Enabled = False
        cmbDesign.Enabled = False
        cmbDept.Enabled = False
        cmbSG.Enabled = False
        cmbEligi.Enabled = False
        cmbTstatus.Enabled = False
        cmbWstatus.Enabled = False
        cmbAR.Enabled = False
        cmbHEA.Enabled = False
        cmbYG.Enabled = False
        cmbYH.Enabled = False
        txtSpecialization.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
    End Sub
    Sub loadCmbDepartment()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM department WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbDept.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbDesignation()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM designation WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbDesign.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbSchoolGrad()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM schoolgrad WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbSG.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbEligibility()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM eligibility WHERE name != 'None' AND Status = 'ACTIVE'"
            ExecuteQuery(query)
            cmbEligi.Items.Clear()
            If reader.HasRows Then
                While reader.Read
                    cmbEligi.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadCmbYGYH()
        Dim year As String = DateTime.Now.ToString("yyyy")
        For i As Integer = 1955 To Val(year)
            cmbYG.Items.Add(i)
            cmbYH.Items.Add(i)
        Next
    End Sub
    Sub loadCmbGender()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub
    Sub loadCmbWA()
        cmbWstatus.Items.Add("Active")
        cmbWstatus.Items.Add("OnLeave")
        cmbWstatus.Items.Add("Retired")
    End Sub
    Sub loadCmbTA()
        cmbTstatus.Items.Add("Regular")
        cmbTstatus.Items.Add("Visiting Lecturer")
    End Sub
    Sub loadCmbHEA()
        cmbHEA.Items.Clear()
        cmbHEA.Items.Add("Baccalaureate Degree")
        cmbHEA.Items.Add("Masteral Degree")
        cmbHEA.Items.Add("Post-Doctorate Degree")
        cmbHEA.Items.Add("Doctorate Degree")
    End Sub
    Sub loadCmbAR()
        cmbAR.Items.Add("None")
        cmbAR.Items.Add("Professor")
        cmbAR.Items.Add("Associate Professor")
        cmbAR.Items.Add("Instructor")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If searchFacu = True Then
            Dim maintenance As New ucSearchFaculty
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
            searchFacu = False
        Else
            Dim maintenance As New ucFaculty
            frmDashboard.pnlDashboard.Controls.Clear()
            frmDashboard.pnlDashboard.Controls.Add(maintenance)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlockItems()
        gbUnlockExcept()
        loadCmbEligibility()
        txtID.Focus()
    End Sub
    Sub gbUnlockExcept()
        txtID.Enabled = True
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtMI.Enabled = True
        txtSpecialization.Enabled = True
        cmbGender.Enabled = True
        cmbDept.Enabled = True
        cmbDesign.Enabled = True
        cmbSG.Enabled = True
        cmbEligi.Enabled = True
        cmbTstatus.Enabled = True
        cmbWstatus.Enabled = True
        cmbAR.Enabled = True
        cmbHEA.Enabled = True
        cmbYG.Enabled = True
        cmbYH.Enabled = True

        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub unlockItems()
        txtID.Enabled = True
        txtGivenName.Enabled = True
        txtLastName.Enabled = True
        txtMI.Enabled = True
        txtSpecialization.Enabled = True
        cmbDept.Enabled = True
        cmbGender.Enabled = True
        cmbDesign.Enabled = True
        cmbSG.Enabled = True
        cmbEligi.Enabled = True
        cmbTstatus.Enabled = True
        cmbWstatus.Enabled = True
        cmbAR.Enabled = True
        cmbHEA.Enabled = True
        cmbYG.Enabled = True
        cmbYH.Enabled = True

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        gbUnlockExcept()
        unlockEditDel()
        edit = True
        txtID.Enabled = False
        txtLastName.Focus()
    End Sub
    Sub unlockEditDel()
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
    End Sub
    Sub transferName()
        Try
            dbConnect()
            Dim query As String = "SELECT Id,givenname,lastname,minitial,gender,(SELECT name from department where department.Id = department_Id)," _
            & " (SELECT name from designation where designation.Id = designation_Id)," _
            & " (SELECT name from schoolgrad where schoolgrad.Id = schoolgrad_Id), teaching_stat, working_stat, academic_rank, year_graduated,year_hired,specialization FROM faculty WHERE Id = '" & FacuID & "'"
            ExecuteQuery(query)
            If reader.HasRows Then
                While reader.Read
                    txtID.Text = reader.GetString(0)
                    txtGivenName.Text = reader.GetString(1)
                    txtLastName.Text = reader.GetString(2)
                    txtMI.Text = reader.GetString(3)
                    cmbGender.Text = reader.GetString(4)
                    cmbDept.Text = reader.GetString(5)
                    cmbDesign.Text = reader.GetString(6)
                    cmbSG.Text = reader.GetString(7)
                    cmbTstatus.Text = reader.GetString(8)
                    cmbWstatus.Text = reader.GetString(9)
                    cmbAR.Text = reader.GetString(10)
                    cmbYG.Text = reader.GetString(11)
                    cmbYH.Text = reader.GetString(12)
                    txtSpecialization.Text = reader.GetString(13)
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
                Dim query As String = "UPDATE faculty SET Status = '" & status & "' WHERE Id = '" & StudID & "'"
                ExecuteQuery(query)
                MsgBox("Faculty successfully Removed!", vbInformation, "Deleted")
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
        Dim student As New ucFacultyProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub
    Dim dcreated As String = DateTime.Now.ToString("MMM dd, yyyy")
    Sub save()
        Dim id As String = Trim(txtID.Text)
        Dim gname As String = Trim(txtGivenName.Text)
        Dim fname As String = Trim(txtLastName.Text)
        Dim mi As String = Trim(txtMI.Text)
        Dim department As String = cmbDept.Text
        Dim designation As String = cmbDesign.Text
        Dim schoolgrad As String = cmbSG.Text
        Dim AR As String = cmbAR.Text
        Dim gender As String = cmbGender.Text
        Dim TA As String = cmbTstatus.Text
        Dim WA As String = cmbWstatus.Text
        Dim YG As String = cmbYG.Text
        Dim YH As String = cmbYH.Text
        Dim special As String = txtSpecialization.Text
        Dim name As String = fname + "," + gname + " " + mi + "."

        If id = "" Or name = "" Or gname = "" Or fname = "" Or YG = "" Or YH = "" Or special = "" Or department = "" Or gender = "" Or designation = "" Or schoolgrad = "" Or AR = "" Or TA = "" Or WA = "" Then
            MsgBox("Please fill up all the information")
        ElseIf cmbHEA.CheckedItems.Count < 1 Then
            MsgBox("Please fill out the Highest Educational Attainment")
        Else
            If edit = True Then

                Try
                    dbConnect()
                    Dim query As String = "UPDATE faculty SET Id = '" & id & "', year_graduated = '" & YG & "', year_hired = '" & YH & "', specialization = '" & special & "', givenname = '" & gname & "', lastname = '" & fname & "'," _
                    & " minitial = '" & mi & "', department_Id = (select Id from department where department.name = '" & department & "'), gender = '" & gender & "'," _
                    & " designation_Id = (select Id from designation where designation.name = '" & designation & "'), academic_rank = '" & AR & "'," _
                    & " schoolgrad_Id = (select Id from schoolgrad where schoolgrad.name = '" & schoolgrad & "'), teaching_stat = '" & TA & "', working_stat = '" & WA & "', name = '" & name & "' WHERE Id = '" & id & "' "
                    ExecuteQuery(query)
                    dbDisconnect()

                    dbConnect()
                    query = "DELETE FROM faculty_eligibility_rela WHERE faculty_Id = '" & id & "' "
                    ExecuteQuery(query)
                    dbDisconnect()

                    Dim eligi As String
                    If cmbEligi.CheckedItems.Count < 1 Then
                        dbConnect()
                        query = "INSERT INTO faculty_eligibility_rela SET faculty_Id = '" & id & "', eligibility_Id = (SELECT Id FROM eligibility WHERE name = 'None') "
                        ExecuteQuery(query)
                        dbDisconnect()
                        eligi = "None"
                    Else
                        For Each eligibility As String In cmbEligi.CheckedItems
                            dbConnect()
                            query = "INSERT INTO faculty_eligibility_rela SET faculty_Id = '" & id & "', eligibility_Id = (SELECT Id FROM eligibility WHERE name = '" & eligibility & "') "
                            ExecuteQuery(query)
                            dbDisconnect()
                            eligi = eligi + "," + eligibility
                        Next
                    End If

                    dbConnect()
                    query = "UPDATE faculty SET eligibility = '" & eligi & "' WHERE Id = '" & id & "'"
                    ExecuteQuery(query)
                    dbDisconnect()

                    dbConnect()
                    query = "DELETE FROM faculty_highesteduc_rela WHERE faculty_Id = '" & id & "' "
                    ExecuteQuery(query)
                    dbDisconnect()


                    Dim education As String
                    For Each HEA As String In cmbHEA.CheckedItems
                        dbConnect()
                        query = "INSERT INTO faculty_highesteduc_rela SET faculty_Id = '" & id & "', highest_educ = '" & HEA & "'"
                        ExecuteQuery(query)
                        dbDisconnect()
                        education = education + "," + HEA
                    Next

                    dbConnect()
                    query = "UPDATE faculty SET educ_attainment = '" & education & "' WHERE Id = '" & id & "'"
                    ExecuteQuery(query)
                    dbDisconnect()

                    MsgBox("Faculty successfully Updated!", vbInformation, "Updated")
                Catch ex As Exception
                    clear()
                    lockEditDel()
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try
                edit = False
            Else
                Try
                    dbConnect()
                    Dim query As String = "INSERT INTO faculty SET Id = '" & id & "', year_graduated = '" & YG & "', year_hired = '" & YH & "', specialization = '" & special & "', givenname = '" & gname & "', lastname = '" & fname & "', Status = 'ACTIVE', date_created = '" & dcreated & "'," _
                    & " minitial = '" & mi & "', department_Id = (select Id from department where department.name = '" & department & "'), gender = '" & gender & "'," _
                    & " designation_Id = (select Id from designation where designation.name = '" & designation & "'), academic_rank = '" & AR & "'," _
                    & " schoolgrad_Id = (select Id from schoolgrad where schoolgrad.name = '" & schoolgrad & "'), teaching_stat = '" & TA & "', working_stat = '" & WA & "', name = '" & name & "'"

                    ExecuteQuery(query)

                    Dim eligi As String
                    If cmbEligi.CheckedItems.Count < 1 Then
                        dbConnect()
                        query = "INSERT INTO faculty_eligibility_rela SET faculty_Id = '" & id & "', eligibility_Id = (SELECT Id FROM eligibility WHERE name = 'None') "
                        ExecuteQuery(query)
                        dbDisconnect()
                    Else
                        For Each eligibility As String In cmbEligi.CheckedItems
                            dbConnect()
                            query = "INSERT INTO faculty_eligibility_rela SET faculty_Id = '" & id & "', eligibility_Id = (SELECT Id FROM eligibility WHERE name = '" & eligibility & "') "
                            ExecuteQuery(query)
                            dbDisconnect()
                            eligi = eligi + vbNewLine + eligibility
                        Next
                    End If

                    dbConnect()
                    query = "UPDATE faculty SET eligibility = '" & eligi & "' WHERE Id = '" & id & "'"
                    ExecuteQuery(query)
                    dbDisconnect()

                    Dim education As String
                    For Each HEA As String In cmbHEA.CheckedItems
                        dbConnect()
                        query = "INSERT INTO faculty_highesteduc_rela SET faculty_Id = '" & id & "', highest_educ = '" & HEA & "'"
                        ExecuteQuery(query)
                        dbDisconnect()
                        education = education + vbNewLine + HEA
                    Next
                    dbConnect()
                    query = "UPDATE faculty SET educ_attainment = '" & education & "' WHERE Id = '" & id & "'"
                    ExecuteQuery(query)
                    dbDisconnect()
                    MsgBox("Faculty successfully Registered!", vbInformation, "Saved")

                    clear()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    disposeConnection()
                    clear()
                End Try
                edit = False
            End If
            gbLock()
            lockEditDel()
            edit = False
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
        cmbGender.Enabled = False
        cmbDept.Enabled = False
        cmbDesign.Enabled = False
        cmbSG.Enabled = False
        cmbEligi.Enabled = False
        cmbTstatus.Enabled = False
        cmbWstatus.Enabled = False
        cmbAR.Enabled = False
        cmbHEA.Enabled = False
        cmbYG.Enabled = False
        cmbYH.Enabled = False
        txtSpecialization.Enabled = False
    End Sub
    Private Sub transferEligibility()
        loadCmbEligibility()

        Dim List = New List(Of String)
        Dim query As String = "SELECT name FROM eligibility, faculty_eligibility_rela WHERE eligibility.Id = faculty_eligibility_rela.eligibility_Id AND faculty_eligibility_rela.Faculty_Id = '" + FacuID + "' AND name != 'None' ORDER BY eligibility.Id"
        dbConnect()
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                List.Add(reader.GetString("name"))
            End While
        End If
        dbDisconnect()
        If List.Count > 0 Or List IsNot Nothing Then
            For Each item As String In List
                For i As Integer = 0 To cmbEligi.Items.Count - 1

                    If CType(cmbEligi.Items(i), String) = item Then
                        cmbEligi.SetItemChecked(i, True)
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub transferHighestEduc()
        loadCmbHEA()

        Dim List = New List(Of String)
        Dim query As String = "SELECT highest_educ FROM faculty_highesteduc_rela WHERE faculty_highesteduc_rela.Faculty_Id = '" + FacuID + "'"
        dbConnect()
        ExecuteQuery(query)
        If reader.HasRows Then
            While reader.Read
                List.Add(reader.GetString(0))
            End While
        End If
        dbDisconnect()
        If List.Count > 0 Or List IsNot Nothing Then
            For Each item As String In List
                For i As Integer = 0 To cmbHEA.Items.Count - 1
                    If CType(cmbHEA.Items(i), String) = item Then
                        cmbHEA.SetItemChecked(i, True)
                    End If
                Next
            Next
        End If

        'System.Windows.Forms.MessageBox.Show("Error on selecting descriptions", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.[Error])
    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        dept = True
        Dim maintenance As New ucManageDepartment
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnEligi_Click(sender As Object, e As EventArgs) Handles btnEligi.Click
        eligi = True
        Dim maintenance As New ucManageEligibility
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDesign_Click(sender As Object, e As EventArgs) Handles btnDesign.Click
        design = True
        Dim maintenance As New ucManageDesignation
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnSG_Click(sender As Object, e As EventArgs) Handles btnSG.Click
        schoolgrad = True
        Dim maintenance As New ucManageSchoolGraduated
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                dbConnect()
                Dim query As String = "SELECT Id FROM faculty WHERE Id = '" & txtSearch.Text & "' AND Status = 'ACTIVE'"
                ExecuteQuery(query)
                If reader.HasRows Then
                    While reader.Read
                        FacuID = reader.GetString(0)
                    End While
                    dbDisconnect()
                    unlockEditDel()
                    btnCancel.Enabled = True
                    transferName()
                    transferEligibility()
                    transferHighestEduc()
                    txtSearch.Enabled = False
                Else
                    MsgBox("Faculty ID is Invalid")
                End If

            Catch ex As Exception
                MsgBox("An Error occured: ", ex.Message)
            Finally
                disposeConnection()

            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearchFaculty.ShowDialog()
        If searchFacu = True Then
            unlockEditDel()
            btnCancel.Enabled = True
            transferName()
            transferEligibility()
            transferHighestEduc()
            txtSearch.Enabled = False
        End If
    End Sub
End Class
