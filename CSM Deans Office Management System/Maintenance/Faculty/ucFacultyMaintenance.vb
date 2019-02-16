Public Class ucFacultyMaintenance
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Dim maintenance As New ucManageDepartment
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDepartment2_Click(sender As Object, e As EventArgs) Handles btnDepartment2.Click
        Dim maintenance As New ucManageDepartment
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnSchoolGrad_Click(sender As Object, e As EventArgs) Handles btnSchoolGrad.Click
        Dim maintenance As New ucManageSchoolGraduated
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnSchoolGrad2_Click(sender As Object, e As EventArgs) Handles btnSchoolGrad2.Click
        Dim maintenance As New ucManageSchoolGraduated
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDesignation_Click(sender As Object, e As EventArgs) Handles btnDesignation.Click
        Dim maintenance As New ucManageDesignation
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDesignation2_Click(sender As Object, e As EventArgs) Handles btnDesignation2.Click
        Dim maintenance As New ucManageDesignation
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnEligibility_Click(sender As Object, e As EventArgs) Handles btnEligibility.Click
        Dim maintenance As New ucManageEligibility
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnEligibility2_Click(sender As Object, e As EventArgs) Handles btnEligibility2.Click
        Dim maintenance As New ucManageEligibility
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
