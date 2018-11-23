Public Class ucStudentMaintenance
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Dim maintenance As New ucManageCourse
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnCourse2_Click(sender As Object, e As EventArgs) Handles btnCourse2.Click
        Dim maintenance As New ucManageDocumentType
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnScholar_Click(sender As Object, e As EventArgs) Handles btnScholar.Click
        Dim maintenance As New ucManageScholarship
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnScholar2_Click(sender As Object, e As EventArgs) Handles btnScholar2.Click
        Dim maintenance As New ucManageScholarship
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnYearLevel_Click(sender As Object, e As EventArgs) Handles btnYearLevel.Click
        Dim maintenance As New ucManageYearLevel
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnYearLevel2_Click(sender As Object, e As EventArgs) Handles btnYearLevel2.Click
        Dim maintenance As New ucManageYearLevel
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
