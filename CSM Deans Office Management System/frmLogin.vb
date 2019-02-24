Public Class frmLogin
    Dim username, password As String
    Dim flag As Integer = 0
    Public administrator, clerk As Boolean

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "Username" And txtUsername.Text = "password" Then
            MsgBox("Please Enter Username/Password")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please Enter Password")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Please Enter Username")
        Else
            login()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        CharOnly(e)
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPassword.Text = "Username" And txtUsername.Text = "password" Then
                MsgBox("Please Enter Username/Password")
            ElseIf txtPassword.Text = "" Then
                MsgBox("Please Enter Password")
            ElseIf txtUsername.Text = "" Then
                MsgBox("Please Enter Username")
            Else
                btnLogin_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPassword.Text = "Username" And txtUsername.Text = "password" Then
                MsgBox("Please Enter Username/Password")
            ElseIf txtPassword.Text = "" Then
                MsgBox("Please Enter Password")
            ElseIf txtUsername.Text = "" Then
                MsgBox("Please Enter Username")
            Else
                btnLogin_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        CharOnly(e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmForgotPassword.ShowDialog()
        txtUsername.Focus()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDisplay()
        txtUsername.Focus()
    End Sub

    Sub loadDataDisplay()
        Dim status = "ACTIVE"
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM schoolyear WHERE Status = '" & status & "'"
            ExecuteQuery(query)

            If reader.HasRows Then
                While reader.Read
                    schoolyear = reader.GetString("Id")
                    pres = reader.GetString("President")
                    vpaa = reader.GetString("VPAA")
                End While
            End If
            dbDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
    Sub login()
        Try
            dbConnect()
            Dim query As String = "SELECT * FROM user WHERE username = @username AND password = @password AND schoolyear_Id = '" & schoolyear & "'"
            ExecuteQueryParameter(query)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)
            reader = command.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If reader.Item("Id") = "" Then
                    MsgBox("Invalid Username/Password", vbExclamation, "Access Denied!")
                    'ElseIf reader.HasRows And reader.Item("user_State") = "Online" Then
                    '    MsgBox("User is Still Online", vbExclamation, "Access Denied!")
                ElseIf reader.Item("user_Type") = "SuperAdmin" Then
                    MsgBox("Developer Logged-in.", vbInformation, "Success!")
                    admin = True
                    flag = 1
                    frmDashboard.txtName.Text = reader.Item("name")
                    frmDashboard.ShowDialog()
                    txtUsername.Text = "Username"
                    txtPassword.Text = "Password"
                    administrator = True
                    txtUsername.Focus()
                    'Me.Hide()
                ElseIf reader.Item("user_Type") = "Admin" Then
                    MsgBox("Admin Logged-in.", vbInformation, "Success!")
                    admin = True
                    flag = 1
                    frmDashboard.txtName.Text = reader.Item("name")
                    frmDashboard.ShowDialog()
                    txtUsername.Text = "Username"
                    txtPassword.Text = "Password"
                    administrator = True
                    txtUsername.Focus()
                    'Me.Hide()
                ElseIf reader.Item("user_Type") = "User" Then
                    MsgBox("User " + txtUsername.Text + " Logged-in!", vbInformation, "Success!")
                    clerk = True
                    admin = False
                    flag = 2
                    frmDashboard.txtName.Text = reader.Item("name")
                    frmDashboard.ShowDialog()
                    txtUsername.Text = "Username"
                    txtPassword.Text = "Password"
                    txtUsername.Focus()
                    'Me.Hide()
                End If
                dbDisconnect()
            Else
                MsgBox("Invalid Username/Password", vbExclamation, "Access Denied!")
            End If

            'If flag = 1 Then
            '    dbConnect()
            '    Dim query1 As String = "INSERT INTO user_logs SET user_ID = " _
            '                         & "(SELECT user_ID FROM user WHERE user_Username= '" & txtUsername.Text & "'), ul_action = 'Login'"
            '    ExecuteQuery(query1)
            '    dbDisconnect()
            'ElseIf flag = 2 Then
            '    dbConnect()
            '    Dim query1 As String = "INSERT INTO user_logs SET user_ID = " _
            '                         & "(SELECT user_ID FROM user WHERE user_Username= '" & txtUsername.Text & "'), ul_action = 'Login'"
            '    ExecuteQuery(query1)
            '    dbDisconnect()
            'End If
            'dbConnect()
            'Dim query2 As String = "UPDATE user SET user_State = 'Online' WHERE user_Username = '" & txtUsername.Text & "' AND user_Password = '" & txtPassword.Text & "'"
            'ExecuteQuery(query2)
            'dbDisconnect()

        Catch ex As Exception
            MessageBox.Show("An error occured." & ex.Message)
        Finally
            disposeConnection()
        End Try
    End Sub
End Class