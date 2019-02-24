<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.txtUsername = New ns1.BunifuMaterialTextbox()
        Me.txtAnswer = New ns1.BunifuMaterialTextbox()
        Me.txtNewPassword = New ns1.BunifuMaterialTextbox()
        Me.txtConfirmPassword = New ns1.BunifuMaterialTextbox()
        Me.btnCheck = New ns1.BunifuFlatButton()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New ns1.BunifuElipse(Me.components)
        Me.btnConfirm = New ns1.BunifuFlatButton()
        Me.BunifuElipse4 = New ns1.BunifuElipse(Me.components)
        Me.btnSubmit = New ns1.BunifuFlatButton()
        Me.btnExit = New ns1.BunifuFlatButton()
        Me.txtQuestion = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(159, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Username:"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblquestion.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblquestion.Location = New System.Drawing.Point(168, 116)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(97, 22)
        Me.lblquestion.TabIndex = 46
        Me.lblquestion.Text = "Question:"
        Me.lblquestion.Visible = False
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblanswer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblanswer.Location = New System.Drawing.Point(182, 163)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(83, 22)
        Me.lblanswer.TabIndex = 46
        Me.lblanswer.Text = "Answer:"
        Me.lblanswer.Visible = False
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblnew.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblnew.Location = New System.Drawing.Point(118, 257)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(147, 22)
        Me.lblnew.TabIndex = 46
        Me.lblnew.Text = "New Password:"
        Me.lblnew.Visible = False
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblconfirm.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblconfirm.Location = New System.Drawing.Point(89, 303)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(176, 22)
        Me.lblconfirm.TabIndex = 46
        Me.lblconfirm.Text = "Confirm Password:"
        Me.lblconfirm.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 25)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Forgot Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcorrect
        '
        Me.lblcorrect.AutoSize = True
        Me.lblcorrect.BackColor = System.Drawing.Color.Transparent
        Me.lblcorrect.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.Green
        Me.lblcorrect.Location = New System.Drawing.Point(201, 216)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(173, 19)
        Me.lblcorrect.TabIndex = 48
        Me.lblcorrect.Text = "The answer is Correct!"
        Me.lblcorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblcorrect.Visible = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Green
        Me.lbluser.Location = New System.Drawing.Point(257, 73)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(164, 18)
        Me.lbluser.TabIndex = 48
        Me.lbluser.Text = "Username Confirmed"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbluser.Visible = False
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.BackColor = System.Drawing.Color.Transparent
        Me.lblsuccess.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.Green
        Me.lblsuccess.Location = New System.Drawing.Point(71, 365)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(333, 25)
        Me.lblsuccess.TabIndex = 48
        Me.lblsuccess.Text = "Password successfully updated!"
        Me.lblsuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblsuccess.Visible = False
        '
        'txtNew
        '
        Me.txtNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNew.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(293, 253)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNew.Size = New System.Drawing.Size(285, 20)
        Me.txtNew.TabIndex = 4
        Me.txtNew.Text = "password"
        Me.txtNew.Visible = False
        '
        'txtConfirm
        '
        Me.txtConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(293, 299)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirm.Size = New System.Drawing.Size(285, 20)
        Me.txtConfirm.TabIndex = 5
        Me.txtConfirm.Text = "password"
        Me.txtConfirm.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = "Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtUsername.LineThickness = 4
        Me.txtUsername.Location = New System.Drawing.Point(293, 31)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(285, 31)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtAnswer
        '
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.HintForeColor = System.Drawing.Color.Empty
        Me.txtAnswer.HintText = "Answer"
        Me.txtAnswer.isPassword = False
        Me.txtAnswer.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtAnswer.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtAnswer.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtAnswer.LineThickness = 4
        Me.txtAnswer.Location = New System.Drawing.Point(293, 154)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(285, 31)
        Me.txtAnswer.TabIndex = 3
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAnswer.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.Enabled = False
        Me.txtNewPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtNewPassword.HintText = ""
        Me.txtNewPassword.isPassword = False
        Me.txtNewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNewPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNewPassword.LineThickness = 4
        Me.txtNewPassword.Location = New System.Drawing.Point(293, 250)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(285, 31)
        Me.txtNewPassword.TabIndex = 343
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewPassword.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtConfirmPassword.HintText = ""
        Me.txtConfirmPassword.isPassword = False
        Me.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtConfirmPassword.LineThickness = 4
        Me.txtConfirmPassword.Location = New System.Drawing.Point(293, 294)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(285, 31)
        Me.txtConfirmPassword.TabIndex = 343
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheck.BorderRadius = 0
        Me.btnCheck.ButtonText = "Check"
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheck.DisabledColor = System.Drawing.Color.Gray
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCheck.Iconimage = Nothing
        Me.btnCheck.Iconimage_right = Nothing
        Me.btnCheck.Iconimage_right_Selected = Nothing
        Me.btnCheck.Iconimage_Selected = Nothing
        Me.btnCheck.IconMarginLeft = 0
        Me.btnCheck.IconMarginRight = 0
        Me.btnCheck.IconRightVisible = True
        Me.btnCheck.IconRightZoom = 0R
        Me.btnCheck.IconVisible = True
        Me.btnCheck.IconZoom = 90.0R
        Me.btnCheck.IsTab = False
        Me.btnCheck.Location = New System.Drawing.Point(439, 70)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCheck.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCheck.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCheck.selected = False
        Me.btnCheck.Size = New System.Drawing.Size(113, 21)
        Me.btnCheck.TabIndex = 344
        Me.btnCheck.Text = "Check"
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCheck.Textcolor = System.Drawing.Color.White
        Me.btnCheck.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.btnCheck
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 15
        Me.BunifuElipse3.TargetControl = Me.btnConfirm
        '
        'btnConfirm
        '
        Me.btnConfirm.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.BorderRadius = 0
        Me.btnConfirm.ButtonText = "Confirm"
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.DisabledColor = System.Drawing.Color.Gray
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConfirm.Iconimage = Nothing
        Me.btnConfirm.Iconimage_right = Nothing
        Me.btnConfirm.Iconimage_right_Selected = Nothing
        Me.btnConfirm.Iconimage_Selected = Nothing
        Me.btnConfirm.IconMarginLeft = 0
        Me.btnConfirm.IconMarginRight = 0
        Me.btnConfirm.IconRightVisible = True
        Me.btnConfirm.IconRightZoom = 0R
        Me.btnConfirm.IconVisible = True
        Me.btnConfirm.IconZoom = 90.0R
        Me.btnConfirm.IsTab = False
        Me.btnConfirm.Location = New System.Drawing.Point(422, 210)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnConfirm.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConfirm.selected = False
        Me.btnConfirm.Size = New System.Drawing.Size(156, 32)
        Me.btnConfirm.TabIndex = 345
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConfirm.Textcolor = System.Drawing.Color.White
        Me.btnConfirm.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Visible = False
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 15
        Me.BunifuElipse4.TargetControl = Me.btnSubmit
        '
        'btnSubmit
        '
        Me.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.BorderRadius = 0
        Me.btnSubmit.ButtonText = "Submit"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.DisabledColor = System.Drawing.Color.Gray
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSubmit.Iconimage = Nothing
        Me.btnSubmit.Iconimage_right = Nothing
        Me.btnSubmit.Iconimage_right_Selected = Nothing
        Me.btnSubmit.Iconimage_Selected = Nothing
        Me.btnSubmit.IconMarginLeft = 0
        Me.btnSubmit.IconMarginRight = 0
        Me.btnSubmit.IconRightVisible = True
        Me.btnSubmit.IconRightZoom = 0R
        Me.btnSubmit.IconVisible = True
        Me.btnSubmit.IconZoom = 90.0R
        Me.btnSubmit.IsTab = False
        Me.btnSubmit.Location = New System.Drawing.Point(422, 358)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSubmit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSubmit.selected = False
        Me.btnSubmit.Size = New System.Drawing.Size(156, 32)
        Me.btnSubmit.TabIndex = 345
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSubmit.Textcolor = System.Drawing.Color.White
        Me.btnSubmit.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.BorderRadius = 0
        Me.btnExit.ButtonText = "X"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledColor = System.Drawing.Color.Gray
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExit.Iconimage = Nothing
        Me.btnExit.Iconimage_right = Nothing
        Me.btnExit.Iconimage_right_Selected = Nothing
        Me.btnExit.Iconimage_Selected = Nothing
        Me.btnExit.IconMarginLeft = 0
        Me.btnExit.IconMarginRight = 0
        Me.btnExit.IconRightVisible = True
        Me.btnExit.IconRightZoom = 0R
        Me.btnExit.IconVisible = True
        Me.btnExit.IconZoom = 90.0R
        Me.btnExit.IsTab = False
        Me.btnExit.Location = New System.Drawing.Point(751, 9)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(36, 21)
        Me.btnExit.TabIndex = 344
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.Textcolor = System.Drawing.Color.White
        Me.btnExit.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuestion.FormattingEnabled = True
        Me.txtQuestion.ItemHeight = 23
        Me.txtQuestion.Location = New System.Drawing.Point(293, 109)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(285, 29)
        Me.txtQuestion.TabIndex = 346
        Me.txtQuestion.UseSelectable = True
        Me.txtQuestion.Visible = False
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 422)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblconfirm)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForgotPassword"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblanswer As Label
    Friend WithEvents lblquestion As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblconfirm As Label
    Friend WithEvents lblnew As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcorrect As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lblsuccess As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtNew As TextBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents txtAnswer As ns1.BunifuMaterialTextbox
    Friend WithEvents txtUsername As ns1.BunifuMaterialTextbox
    Friend WithEvents txtConfirmPassword As ns1.BunifuMaterialTextbox
    Friend WithEvents txtNewPassword As ns1.BunifuMaterialTextbox
    Friend WithEvents btnCheck As ns1.BunifuFlatButton
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents btnSubmit As ns1.BunifuFlatButton
    Friend WithEvents btnConfirm As ns1.BunifuFlatButton
    Friend WithEvents btnExit As ns1.BunifuFlatButton
    Friend WithEvents BunifuElipse3 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse4 As ns1.BunifuElipse
    Friend WithEvents txtQuestion As MetroFramework.Controls.MetroComboBox
End Class
