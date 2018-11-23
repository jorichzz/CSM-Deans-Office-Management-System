Public Class ucStudent
    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim student As New ucStudentProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub btnStudent2_Click(sender As Object, e As EventArgs) Handles btnStudent2.Click
        Dim student As New ucStudentProfiling
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim student As New ucSearchStudent
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim student As New ucSearchStudent
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(student)
    End Sub
End Class
