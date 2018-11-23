Public Class frmDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm tt dddd, dd MMMM yyyy")
    End Sub
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        btnDocument_Click_2(sender, e)
    End Sub

    Private Sub btnDocument_Click_2(sender As Object, e As EventArgs) Handles btnDocument.Click
        Dim document As New ucDocument
        pnlDashboard.Controls.Clear()
        pnlDashboard.Controls.Add(document)
        slider.Height = btnDocument.Height()
        slider.Top = btnDocument.Top()
        doctype = False
        course = False
        scholar = False
        year = False
        searchStud = False
    End Sub

    Private Sub btnFacultyProfile_Click_1(sender As Object, e As EventArgs) Handles btnFacultyProfile.Click
        Dim faculty As New ucFaculty
        pnlDashboard.Controls.Clear()
        pnlDashboard.Controls.Add(faculty)
        slider.Height = btnFacultyProfile.Height()
        slider.Top = btnFacultyProfile.Top()
        doctype = False
        course = False
        scholar = False
        year = False
        searchStud = False
    End Sub

    Private Sub btnStudentProfile_Click_1(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        Dim student As New ucStudent
        pnlDashboard.Controls.Clear()
        pnlDashboard.Controls.Add(student)
        slider.Height = btnStudentProfile.Height()
        slider.Top = btnStudentProfile.Top()
        doctype = False
        course = False
        scholar = False
        year = False
        searchStud = False
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        slider.Height = btnLogout.Height()
        slider.Top = btnLogout.Top()
        Me.Hide()
        Application.Exit()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Dim maintenance As New ucMaintenance
        pnlDashboard.Controls.Clear()
        pnlDashboard.Controls.Add(maintenance)
        slider.Height = btnMaintenance.Height()
        slider.Top = btnMaintenance.Top()
        doctype = False
        course = False
        scholar = False
        year = False
        searchStud = False
    End Sub
End Class
