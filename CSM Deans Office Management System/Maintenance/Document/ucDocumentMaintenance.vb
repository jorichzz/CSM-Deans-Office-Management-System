Public Class ucDocumentMaintenance
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDocType_Click(sender As Object, e As EventArgs) Handles btnDocType.Click
        Dim maintenance As New ucManageDocumentType
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDocType2_Click(sender As Object, e As EventArgs) Handles btnDocType2.Click
        Dim maintenance As New ucManageDocumentType
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
