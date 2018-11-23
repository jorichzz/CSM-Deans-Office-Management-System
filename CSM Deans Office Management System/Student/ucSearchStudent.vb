Public Class ucSearchStudent

    Private Sub ucSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbCourse()
        loadCmbGender()
        loadCmbScho()
        loadCmbStatus()
        loadCmbYear()
        loadDataDisplay()
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

    Private Sub lvStudent_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvStudent.ColumnClick

    End Sub
End Class
