Imports MySql.Data.MySqlClient
Public Class ucSearchFaculty
    Private conn As New MySqlConnection("server='localhost'; username='root'; password=''; database='csmdb'")
    Dim query As String
    Private Sub ucSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbDepartment()
        loadCmbDesignation()
        loadCmbSchoolGrad()
        loadCmbEligibility()
        loadCmbTA()
        loadCmbWA()
        loadCmbAR()
        loadCmbHEA()
        loadCmbGender()


        cmbDept.SelectedIndex = 0
        cmbDesign.SelectedIndex = 0
        cmbSG.SelectedIndex = 0
        cmbEligi.SelectedIndex = 0
        cmbTstatus.SelectedIndex = 0
        cmbWstatus.SelectedIndex = 0
        cmbAR.SelectedIndex = 0
        cmbHEA.SelectedIndex = 0
        cmbGender.SelectedIndex = 0
        loadDataDisplay()
        txtSearch.Focus()
    End Sub
    Sub loadDataDisplay()
        Dim department As String = cmbDept.Text
        Dim designation As String = cmbDesign.Text
        Dim eligibility As String = cmbEligi.Text
        Dim schoolgrad As String = cmbSG.Text
        Dim AR As String = cmbAR.Text
        Dim gender As String = cmbGender.Text
        Dim TA As String = cmbTstatus.Text
        Dim WA As String = cmbWstatus.Text
        Dim HEA As String = cmbHEA.Text

        lvFaculty.Items.Clear()
        If cmbDept.Text = "All" Then
            department = ""
        Else
            department = cmbDept.Text
        End If
        If cmbDesign.Text = "All" Then
            designation = ""
        Else
            designation = cmbDesign.Text
        End If
        If cmbEligi.Text = "All" Then
            eligibility = ""
        Else
            eligibility = cmbEligi.Text
        End If
        If cmbSG.Text = "All" Then
            schoolgrad = ""
        Else
            schoolgrad = cmbSG.Text
        End If
        If cmbAR.Text = "All" Then
            AR = ""
        Else
            AR = cmbAR.Text
        End If
        If cmbTstatus.Text = "All" Then
            TA = ""
        Else
            TA = cmbTstatus.Text
        End If
        If cmbWstatus.Text = "All" Then
            WA = ""
        Else
            WA = cmbWstatus.Text
        End If
        If cmbHEA.Text = "All" Then
            HEA = ""
        Else
            HEA = cmbHEA.Text
        End If
        Try
            Dim i As Integer = 0
            dbConnect()

            query = "SELECT * FROM search_student WHERE Id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%'"

            If cmbGender.Text = "All" Then
                query = "SELECT * FROM search_faculty " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND department Like '%" & department & "%' AND designation Like '%" & designation & "%'" _
                      & " AND eligibility Like '%" & eligibility & "%' AND schoolgrad Like '%" & schoolgrad & "%'" _
                      & " AND academic_rank Like '%" & AR & "%' AND teaching_stat Like '%" & TA & "%'" _
                      & " AND working_stat Like '%" & WA & "%' AND educ_attainment Like '%" & HEA & "%'"
                'Combo box for gender = all and status = all
            ElseIf cmbGender.Text <> "All" Then
                query = "SELECT * FROM search_faculty " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND department Like '%" & department & "%' AND designation Like '%" & designation & "%'" _
                      & " AND eligibility Like '%" & eligibility & "%' AND schoolgrad Like '%" & schoolgrad & "%'" _
                      & " AND academic_rank Like '%" & AR & "%' AND teaching_stat Like '%" & TA & "%'" _
                      & " AND working_stat Like '%" & WA & "%' AND educ_attainment Like '%" & HEA & "%' AND gender = '" & gender & "'"
            End If

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
    Sub loadCmbDepartment()
        Try
            dbConnect()
            Dim query As String = " SELECT name FROM department WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)
            cmbDept.Items.Add("All")
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
            cmbDesign.Items.Add("All")
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
            cmbSG.Items.Add("All")
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
            Dim query As String = " SELECT name FROM eligibility WHERE Status = 'ACTIVE'"
            ExecuteQuery(query)
            cmbEligi.Items.Add("All")
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
    Sub loadCmbGender()
        cmbGender.Items.Add("All")
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub
    Sub loadCmbWA()
        cmbWstatus.Items.Add("All")
        cmbWstatus.Items.Add("Active")
        cmbWstatus.Items.Add("OnLeave")
        cmbWstatus.Items.Add("Retired")
    End Sub
    Sub loadCmbTA()
        cmbTstatus.Items.Add("All")
        cmbTstatus.Items.Add("Regular")
        cmbTstatus.Items.Add("Visiting Lecturer")
    End Sub
    Sub loadCmbHEA()
        cmbHEA.Items.Add("All")
        cmbHEA.Items.Add("Baccalaureate Degree")
        cmbHEA.Items.Add("Masteral Degree")
        cmbHEA.Items.Add("Post-Doctorate Degree")
        cmbHEA.Items.Add("Doctorate Degree")
    End Sub
    Sub loadCmbAR()
        cmbAR.Items.Add("All")
        cmbAR.Items.Add("Professor")
        cmbAR.Items.Add("Associate Professor")
        cmbAR.Items.Add("Instructor")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim student As New ucFaculty
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub lvStudent_DoubleClick(sender As Object, e As EventArgs)
        FacuID = lvFaculty.SelectedItems(0).SubItems(1).Text
        searchStud = True
        Dim student As New ucStudentProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbHEA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHEA.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbSG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSG.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbTstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTstatus.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbEligi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEligi.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbWstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWstatus.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbDesign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDesign.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAR.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub lvFaculty_DoubleClick(sender As Object, e As EventArgs) Handles lvFaculty.DoubleClick
        FacuID = lvFaculty.SelectedItems(0).SubItems(1).Text
        searchFacu = True
        Dim student As New ucFacultyProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub txtSearch_OnValueChanged_1(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim cmd As MySqlCommand
            Dim adp As New MySqlDataAdapter
            Dim dt As New DataSet
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "Faculty")

            Dim report As New CrystalReportFaculty
            Dim myTextObject As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObject = report.Section1.ReportObjects.Item("Text26")
            myTextObject.Text = cmbGender.Text
            myTextObject = report.Section1.ReportObjects.Item("Text25")
            myTextObject.Text = cmbHEA.Text
            myTextObject = report.Section1.ReportObjects.Item("Text24")
            myTextObject.Text = cmbDept.Text
            myTextObject = report.Section1.ReportObjects.Item("Text23")
            myTextObject.Text = cmbEligi.Text
            myTextObject = report.Section1.ReportObjects.Item("Text27")
            myTextObject.Text = cmbSG.Text
            myTextObject = report.Section1.ReportObjects.Item("Text28")
            myTextObject.Text = cmbTstatus.Text
            myTextObject = report.Section1.ReportObjects.Item("Text29")
            myTextObject.Text = cmbWstatus.Text
            myTextObject = report.Section1.ReportObjects.Item("Text30")
            myTextObject.Text = cmbAR.Text
            myTextObject = report.Section1.ReportObjects.Item("Text31")
            myTextObject.Text = cmbDesign.Text

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

    Private Sub lvFaculty_Click(sender As Object, e As EventArgs) Handles lvFaculty.Click
        FacuID = lvFaculty.SelectedItems(0).SubItems(1).Text
    End Sub
End Class