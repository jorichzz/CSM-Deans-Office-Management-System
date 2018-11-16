Public Class ucMaintenance
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim maintenance As New ucUserMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnUser2_Click(sender As Object, e As EventArgs) Handles btnUser2.Click
        Dim maintenance As New ucUserMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDocument_Click(sender As Object, e As EventArgs) Handles btnDocument.Click
        Dim maintenance As New ucDocumentMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDocument2_Click(sender As Object, e As EventArgs) Handles btnDocument2.Click
        Dim maintenance As New ucDocumentMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
