Public Class ucDocument
    Private Sub btnDocumentLogs_Click(sender As Object, e As EventArgs) Handles btnDocumentLogs.Click
        Dim document As New ucDocumentReceived
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub btnDocumentLogs2_Click(sender As Object, e As EventArgs) Handles btnDocumentLogs2.Click
        Dim document As New ucDocumentReceived
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Dim document As New ucBorrowDocument
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub

    Private Sub btnLogs2_Click(sender As Object, e As EventArgs) Handles btnLogs2.Click
        Dim document As New ucBorrowDocument
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub
End Class
