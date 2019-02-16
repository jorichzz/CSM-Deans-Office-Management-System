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

    Private Sub btnDocCat_Click(sender As Object, e As EventArgs) Handles btnDocCat.Click
        Dim maintenance As New ucManageDocumentCategory
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnDocCat2_Click(sender As Object, e As EventArgs) Handles btnDocCat2.Click
        Dim maintenance As New ucManageDocumentCategory
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btbBorrow_Click(sender As Object, e As EventArgs) Handles btbBorrow.Click
        Dim maintenance As New ucManageDocsBorrowable
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub

    Private Sub btnBorrow2_Click(sender As Object, e As EventArgs) Handles btnBorrow2.Click
        Dim maintenance As New ucManageDocsBorrowable
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
