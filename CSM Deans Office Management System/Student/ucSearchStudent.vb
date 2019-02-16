Imports MySql.Data.MySqlClient
Public Class ucSearchStudent
    Dim query As String
    Private conn As New MySqlConnection("server='localhost'; username='root'; password=''; database='csmdb'")

    Private Sub ucSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbCourse()
        loadCmbGender()
        loadCmbScho()
        loadCmbStatus()
        loadCmbYear()
        cmbCourse.SelectedIndex = 0
        cmbGender.SelectedIndex = 0
        cmbScho.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0
        cmbYL.SelectedIndex = 0
        loadDataDisplay()
        txtSearch.Focus()
    End Sub
    Sub loadDataDisplay()
        Dim course, gender, scho, academicstat, yl As String
        course = cmbCourse.Text
        gender = cmbGender.Text
        scho = cmbScho.Text
        academicstat = cmbStatus.Text
        yl = cmbYL.Text
        lvStudent.Items.Clear()
        If cmbCourse.Text = "All" Then
            course = ""
        Else
            course = cmbCourse.Text
        End If
        If cmbGender.Text = "All" Then
            gender = ""
        Else
            gender = cmbGender.Text
        End If
        If cmbScho.Text = "All" Then
            scho = ""
        Else
            scho = cmbScho.Text
        End If
        If cmbStatus.Text = "All" Then
            academicstat = ""
        Else
            academicstat = cmbStatus.Text
        End If
        If cmbYL.Text = "All" Then
            yl = ""
        Else
            yl = cmbYL.Text
        End If
        Try
            Dim i As Integer = 0
            dbConnect()

            query = "SELECT * FROM search_student WHERE Id LIKE '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%'"

            If cmbGender.Text = "All" And cmbStatus.Text = "All" And cmbScho.Text = "All" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%'" _
                      & " AND year_level LIKE '%" & yl & "%'"
                'Combo box for gender = all and status = all
            ElseIf cmbGender.Text = "All" And cmbStatus.Text = "All" And cmbScho.Text = "With" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship != 'None'" _
                      & " AND year_level LIKE '%" & yl & "%'"
            ElseIf cmbGender.Text = "All" And cmbStatus.Text = "All" And cmbScho.Text = "None" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = 'None'" _
                      & " AND year_level LIKE '%" & yl & "%'"
            ElseIf cmbGender.Text = "All" And cmbStatus.Text = "All" And (cmbScho.Text <> "None" And cmbScho.Text <> "With") Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = '" & scho & "'" _
                      & " AND year_level LIKE '%" & yl & "%'"
                'Combo box for gender = all and status = regular/irregular
            ElseIf cmbGender.Text = "All" And cmbStatus.Text <> "All" And cmbScho.Text = "All" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%'" _
                      & " AND year_level LIKE '%" & yl & "%' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text = "All" And cmbStatus.Text <> "All" And cmbScho.Text = "With" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship != 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text = "All" And cmbStatus.Text <> "All" And cmbScho.Text = "None" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text = "All" And cmbStatus.Text <> "All" And (cmbScho.Text <> "None" And cmbScho.Text <> "With") Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = '" & scho & "'" _
                      & " AND year_level LIKE '%" & yl & "%' AND scholastic_Status = '" & academicstat & "'"
                'Combo box for gender = male/femal status = all
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text = "All" And cmbScho.Text = "All" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text = "All" And cmbScho.Text = "With" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship != 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text = "All" And cmbScho.Text = "None" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text = "All" And (cmbScho.Text <> "None" And cmbScho.Text <> "With") Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = '" & scho & "'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "'"
                'Combo box for gender = male/female and status = regular/irregular
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text <> "All" And cmbScho.Text = "All" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text <> "All" And cmbScho.Text = "With" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship != 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text <> "All" And cmbScho.Text = "None" Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = 'None'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "' AND scholastic_Status = '" & academicstat & "'"
            ElseIf cmbGender.Text <> "All" And cmbStatus.Text <> "All" And (cmbScho.Text <> "None" And cmbScho.Text <> "With") Then
                query = "SELECT * FROM search_student " _
                      & " WHERE (Id Like '%" & txtSearch.Text & "%' OR name LIKE '%" & txtSearch.Text & "%')" _
                      & " AND course LIKE '%" & course & "%' AND scholarship = '" & scho & "'" _
                      & " AND year_level LIKE '%" & yl & "%' AND gender = '" & gender & "' AND scholastic_Status = '" & academicstat & "'"
            End If

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
            cmbCourse.Items.Add("All")
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
            cmbScho.Items.Add("All")
            cmbScho.Items.Add("With")
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
            cmbYL.Items.Add("All")
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
        cmbGender.Items.Add("All")
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub
    Sub loadCmbStatus()
        cmbStatus.Items.Add("All")
        cmbStatus.Items.Add("Regular")
        cmbStatus.Items.Add("Irregular")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim student As New ucStudent
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub lvStudent_DoubleClick(sender As Object, e As EventArgs) Handles lvStudent.DoubleClick
        StudID = lvStudent.SelectedItems(0).SubItems(1).Text
        searchStud = True
        Dim student As New ucStudentProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbYL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYL.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        loadDataDisplay()
    End Sub

    Private Sub cmbScho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbScho.SelectedIndexChanged
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
            adp.Fill(dt, "Student")

            Dim report As New CrystalReportStudent
            Dim myTextObject As CrystalDecisions.CrystalReports.Engine.TextObject
            myTextObject = report.Section1.ReportObjects.Item("Text26")
            myTextObject.Text = cmbGender.Text
            myTextObject = report.Section1.ReportObjects.Item("Text25")
            myTextObject.Text = cmbCourse.Text
            myTextObject = report.Section1.ReportObjects.Item("Text24")
            myTextObject.Text = cmbScho.Text
            myTextObject = report.Section1.ReportObjects.Item("Text28")
            myTextObject.Text = cmbStatus.Text
            myTextObject = report.Section1.ReportObjects.Item("Text29")
            myTextObject.Text = cmbYL.Text


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
