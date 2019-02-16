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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtQuestion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.txtAnswer = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.btnConfirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtNewPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.btnExit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCheck = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuestion.Enabled = False
        Me.txtQuestion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Black
        Me.txtQuestion.HintForeColor = System.Drawing.Color.Empty
        Me.txtQuestion.HintText = "Question"
        Me.txtQuestion.isPassword = False
        Me.txtQuestion.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtQuestion.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtQuestion.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtQuestion.LineThickness = 2
        Me.txtQuestion.Location = New System.Drawing.Point(293, 102)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(285, 36)
        Me.txtQuestion.TabIndex = 3
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQuestion.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = "User name"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtUsername.LineThickness = 2
        Me.txtUsername.Location = New System.Drawing.Point(293, 26)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(237, 36)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = "Username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.HintForeColor = System.Drawing.Color.Empty
        Me.txtAnswer.HintText = "Answer"
        Me.txtAnswer.isPassword = False
        Me.txtAnswer.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtAnswer.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtAnswer.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtAnswer.LineThickness = 2
        Me.txtAnswer.Location = New System.Drawing.Point(293, 149)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(285, 36)
        Me.txtAnswer.TabIndex = 1
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAnswer.Visible = False
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
        'btnConfirm
        '
        Me.btnConfirm.ActiveBorderThickness = 1
        Me.btnConfirm.ActiveCornerRadius = 20
        Me.btnConfirm.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfirm.ActiveForecolor = System.Drawing.Color.White
        Me.btnConfirm.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirm.BackgroundImage = CType(resources.GetObject("btnConfirm.BackgroundImage"), System.Drawing.Image)
        Me.btnConfirm.ButtonText = "Confirm"
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.IdleBorderThickness = 1
        Me.btnConfirm.IdleCornerRadius = 20
        Me.btnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnConfirm.IdleForecolor = System.Drawing.Color.White
        Me.btnConfirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnConfirm.Location = New System.Drawing.Point(415, 204)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(163, 42)
        Me.btnConfirm.TabIndex = 47
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConfirm.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtNewPassword.HintText = ""
        Me.txtNewPassword.isPassword = True
        Me.txtNewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNewPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNewPassword.LineThickness = 2
        Me.txtNewPassword.Location = New System.Drawing.Point(293, 243)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(285, 36)
        Me.txtNewPassword.TabIndex = 123
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewPassword.Visible = False
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
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtConfirmPassword.HintText = ""
        Me.txtConfirmPassword.isPassword = True
        Me.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtConfirmPassword.LineThickness = 2
        Me.txtConfirmPassword.Location = New System.Drawing.Point(293, 289)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(285, 36)
        Me.txtConfirmPassword.TabIndex = 341
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.Visible = False
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
        'btnSubmit
        '
        Me.btnSubmit.ActiveBorderThickness = 1
        Me.btnSubmit.ActiveCornerRadius = 20
        Me.btnSubmit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSubmit.ActiveForecolor = System.Drawing.Color.White
        Me.btnSubmit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.ButtonText = "Submit"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.IdleBorderThickness = 1
        Me.btnSubmit.IdleCornerRadius = 20
        Me.btnSubmit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSubmit.IdleForecolor = System.Drawing.Color.White
        Me.btnSubmit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(415, 357)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(163, 42)
        Me.btnSubmit.TabIndex = 47
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSubmit.Visible = False
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
        'btnExit
        '
        Me.btnExit.ActiveBorderThickness = 1
        Me.btnExit.ActiveCornerRadius = 1
        Me.btnExit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.ActiveForecolor = System.Drawing.Color.White
        Me.btnExit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.ButtonText = " X"
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IdleBorderThickness = 1
        Me.btnExit.IdleCornerRadius = 1
        Me.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnExit.IdleForecolor = System.Drawing.Color.White
        Me.btnExit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(737, 1)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(48, 33)
        Me.btnExit.TabIndex = 47
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheck
        '
        Me.btnCheck.ActiveBorderThickness = 1
        Me.btnCheck.ActiveCornerRadius = 20
        Me.btnCheck.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheck.ActiveForecolor = System.Drawing.Color.White
        Me.btnCheck.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck.BackgroundImage = CType(resources.GetObject("btnCheck.BackgroundImage"), System.Drawing.Image)
        Me.btnCheck.ButtonText = "Check"
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.IdleBorderThickness = 1
        Me.btnCheck.IdleCornerRadius = 20
        Me.btnCheck.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCheck.IdleForecolor = System.Drawing.Color.White
        Me.btnCheck.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCheck.Location = New System.Drawing.Point(448, 67)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(81, 32)
        Me.btnCheck.TabIndex = 47
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtNew.TabIndex = 2
        Me.txtNew.Text = "password"
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
        Me.txtConfirm.TabIndex = 3
        Me.txtConfirm.Text = "password"
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblconfirm)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtUsername)
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

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtQuestion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblanswer As Label
    Friend WithEvents lblquestion As Label
    Friend WithEvents txtAnswer As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConfirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblconfirm As Label
    Friend WithEvents lblnew As Label
    Friend WithEvents txtConfirmPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNewPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblcorrect As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCheck As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblsuccess As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtNew As TextBox
End Class
