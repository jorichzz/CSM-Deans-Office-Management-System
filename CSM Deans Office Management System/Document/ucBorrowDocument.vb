Public Class ucBorrowDocument
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim document As New ucDocument
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(document)
    End Sub
End Class
