Public Class ucSystemConfig
    Dim edit As Boolean = False
    Private Sub ucSystemConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCmbSY()
        loadDataDisplay()
    End Sub
    Sub loadCmbSY()
        cmbSY.Items.Clear()
        Try
            Dim i As Integer = 0
            dbConnect()
            Dim query As String = "SELECT name FROM schoolyear "
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbSY.Items.Add(reader.GetString(0))
                    i += 1
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub loadDataDisplay()
        txtPres.Text = ""
        txtVPAA.Text = ""
        Dim status = "ACTIVE"
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM schoolyear WHERE Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    cmbSY.Text = reader.GetString("name")
                    txtPres.Text = reader.GetString("President")
                    txtVPAA.Text = reader.GetString("VPAA")
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try

    End Sub
    Sub loaddata()
        txtPres.Text = ""
        txtVPAA.Text = ""
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM schoolyear WHERE name = '" & cmbSY.Text & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    txtPres.Text = reader.GetString("President")
                    txtVPAA.Text = reader.GetString("VPAA")
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub cmbSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSY.SelectedIndexChanged
        If edit = True Then
            loaddata()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cmbSY.Enabled = True
        txtVPAA.Enabled = True
        txtPres.Enabled = True
        edit = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sy As String = cmbSY.Text
        Dim pres As String = Trim(txtPres.Text)
        Dim vpres As String = Trim(txtVPAA.Text)

        If sy = "" Or pres = "" Or vpres = "" Then
            MsgBox("Please fill up all the information")
        Else
            Try
                dbConnect()
                Dim query As String = "UPDATE schoolyear SET Status = 'INACTIVE' WHERE Status = 'ACTIVE'"
                ExecuteQuery(query)

                dbDisconnect()


                dbConnect()
                query = "UPDATE schoolyear SET President ='" & pres & "', VPAA = '" & vpres & "', Status ='ACTIVE' WHERE name = '" & sy & "'"

                ExecuteQuery(query)
                MsgBox("Configuration successfully Saved!", vbInformation, "Saved")

                loadDataDisplay()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                disposeConnection()
                txtPres.Enabled = False
                txtVPAA.Enabled = False
                btnEdit.Enabled = True
                btnSave.Enabled = False
                cmbSY.Enabled = False
            End Try
        End If
        edit = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maintenance As New ucMaintenance
        frmDashboard.pnlDashboard.Controls.Clear()
        frmDashboard.pnlDashboard.Controls.Add(maintenance)
    End Sub
End Class
