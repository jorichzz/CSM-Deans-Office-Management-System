Public Class ucUserMaintenance
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim maintenance As New ucManageUser
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnUser2_Click(sender As Object, e As EventArgs) Handles btnUser2.Click
        Dim maintenance As New ucManageUser
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
