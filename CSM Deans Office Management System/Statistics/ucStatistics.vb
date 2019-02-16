Public Class ucStatistics
    Private Sub ucStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim maintenance As New ucStudentStat
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnStudent2_Click(sender As Object, e As EventArgs) Handles btnStudent2.Click
        Dim maintenance As New ucStudentStat
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Dim maintenance As New ucFacultyStat
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnFaculty2_Click(sender As Object, e As EventArgs) Handles btnFaculty2.Click
        Dim maintenance As New ucFacultyStat
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
