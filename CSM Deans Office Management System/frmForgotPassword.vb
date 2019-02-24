Public Class frmForgotPassword
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        hidebot()
        hidemid()
        txtUsername.Text = ""
        lbluser.Visible = False
        Me.Hide()
    End Sub
    Sub showmid()
        lbluser.Visible = True
        lblanswer.Visible = True
        lblquestion.Visible = True
        txtAnswer.Visible = True
        txtQuestion.Visible = True
        btnConfirm.Visible = True
    End Sub
    Sub hidemid()
        lblanswer.Visible = False
        lblquestion.Visible = False
        txtAnswer.Visible = False
        txtQuestion.Visible = False
        btnConfirm.Visible = False
        lblcorrect.Visible = False

        txtAnswer.Text = ""
        txtQuestion.Text = ""
    End Sub
    Sub showbot()
        lblnew.Visible = True
        lblconfirm.Visible = True
        txtNewPassword.Visible = True
        txtNew.Visible = True
        txtConfirmPassword.Visible = True
        txtConfirm.Visible = True
        btnSubmit.Visible = True
        lblsuccess.Visible = False
    End Sub
    Sub hidebot()
        lblnew.Visible = False
        lblconfirm.Visible = False
        txtNewPassword.Visible = False
        txtNew.Visible = True
        txtConfirmPassword.Visible = False
        txtConfirm.Visible = False

        txtNewPassword.Text = ""
        txtNew.Text = ""
        txtConfirmPassword.Text = ""
        txtConfirm.Text = ""
        btnSubmit.Visible = False
        lblsuccess.Visible = False
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            lbluser.Text = ""
            dbConnect()
            Dim query As String = "SELECT Id, name, schoolyear_Id,(SELECT question FROM question WHERE question_Id = Id) AS question FROM user WHERE schoolyear_Id = '" & schoolyear & "' AND username = '" & txtUsername.Text & "'"
            ExecuteQuery(query)
            reader.Read()

            If reader.HasRows Then
                lbluser.Text = "Username Confirmed!"
                lbluser.ForeColor = Color.Green
                showmid()
                txtAnswer.Focus()

            Else
                lbluser.Text = "Invalid Username!"
                lbluser.ForeColor = Color.Red
                lbluser.Visible = True
                hidemid()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            lblcorrect.Text = ""
            dbConnect()
            Dim query As String = "SELECT Id, name, (SELECT question FROM question WHERE question_Id = Id) AS question, user_Answer, schoolyear_Id FROM user WHERE schoolyear_Id = '" & schoolyear & "' AND username = '" & txtUsername.Text & "'"
            ExecuteQuery(query)
            reader.Read()

            If reader.HasRows Then
                If reader.GetString(3) = txtAnswer.Text Then
                    lblcorrect.Text = "The Answer is Correct!"
                    lblcorrect.ForeColor = Color.Green
                    lblcorrect.Visible = True
                    showbot()
                    txtNew.Focus()
                Else
                    lblcorrect.Text = "The Answer is Incorrect!"
                    lblcorrect.ForeColor = Color.Red
                    lblcorrect.Visible = True
                    hidebot()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            lblsuccess.Text = ""

            If txtNew.Text = "" Or txtNew.Text = " " Then
                MsgBox("Please Enter a New Password!")
            Else
                If txtNew.Text = txtConfirm.Text Then
                    dbConnect()
                    Dim query As String = "UPDATE user SET password = '" & txtConfirm.Text & "' WHERE schoolyear_Id = '" & schoolyear & "'AND username = '" & txtUsername.Text & "'"
                    ExecuteQuery(query)

                    lblsuccess.Text = "Password successfully Updated!"
                    lblsuccess.ForeColor = Color.Green
                    lblsuccess.Visible = True
                    TabIndex = 47
                Else
                    lblsuccess.Text = "Password do not match!"
                    lblsuccess.ForeColor = Color.Red
                    lblsuccess.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        loadCmb()
    End Sub
    Sub loadCmb()
        Try
            dbConnect()
            Dim query As String = " SELECT question FROM question "
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    txtQuestion.Items.Add(reader.GetString(0))
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MsgBox("An Error occured: ", ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNew.KeyDown, txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCheck_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNew.KeyPress, txtUsername.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtAnswer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm_Click(sender, e)
        End If
    End Sub

    Private Sub txtAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) 
        CharOnly(e)
    End Sub

    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles  txtConfirm.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit_Click(sender, e)
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirm.KeyPress
        CharOnly(e)
    End Sub
End Class