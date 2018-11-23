<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentProfiling
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStudentProfiling))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGivenName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnScho = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnYear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btntype = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbYL = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbScho = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.txtID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtMI = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvStudent = New System.Windows.Forms.ListView()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 23)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Student Profile"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(37, 79)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 95)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "                  Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Black
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(37, 281)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(169, 95)
        Me.btnDel.TabIndex = 63
        Me.btnDel.Text = "               Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(37, 180)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(169, 95)
        Me.btnEdit.TabIndex = 62
        Me.btnEdit.Text = "                  Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 12)
        Me.Panel1.TabIndex = 59
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(37, 589)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 73)
        Me.btnBack.TabIndex = 65
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLastName.HintForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLastName.HintText = "Last Name"
        Me.txtLastName.isPassword = False
        Me.txtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtLastName.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtLastName.LineThickness = 4
        Me.txtLastName.Location = New System.Drawing.Point(162, 79)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(243, 33)
        Me.txtLastName.TabIndex = 5
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(13, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 22)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Student Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(14, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 22)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Course:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(334, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 22)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Scholarship:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(728, 129)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 49)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(728, 74)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 49)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Student ID No:"
        '
        'txtGivenName
        '
        Me.txtGivenName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGivenName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGivenName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGivenName.HintForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGivenName.HintText = "Given Name"
        Me.txtGivenName.isPassword = False
        Me.txtGivenName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtGivenName.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtGivenName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtGivenName.LineThickness = 4
        Me.txtGivenName.Location = New System.Drawing.Point(413, 79)
        Me.txtGivenName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(243, 33)
        Me.txtGivenName.TabIndex = 4
        Me.txtGivenName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btnScho)
        Me.GroupBox2.Controls.Add(Me.btnYear)
        Me.GroupBox2.Controls.Add(Me.btntype)
        Me.GroupBox2.Controls.Add(Me.cmbStatus)
        Me.GroupBox2.Controls.Add(Me.cmbYL)
        Me.GroupBox2.Controls.Add(Me.cmbGender)
        Me.GroupBox2.Controls.Add(Me.cmbScho)
        Me.GroupBox2.Controls.Add(Me.cmbCourse)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtMI)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtGivenName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(210, 75)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 243)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'btnScho
        '
        Me.btnScho.ActiveBorderThickness = 1
        Me.btnScho.ActiveCornerRadius = 20
        Me.btnScho.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnScho.ActiveForecolor = System.Drawing.Color.White
        Me.btnScho.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnScho.BackColor = System.Drawing.SystemColors.Control
        Me.btnScho.BackgroundImage = CType(resources.GetObject("btnScho.BackgroundImage"), System.Drawing.Image)
        Me.btnScho.ButtonText = " +"
        Me.btnScho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScho.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScho.ForeColor = System.Drawing.Color.White
        Me.btnScho.IdleBorderThickness = 1
        Me.btnScho.IdleCornerRadius = 20
        Me.btnScho.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnScho.IdleForecolor = System.Drawing.Color.White
        Me.btnScho.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnScho.Location = New System.Drawing.Point(679, 135)
        Me.btnScho.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnScho.Name = "btnScho"
        Me.btnScho.Size = New System.Drawing.Size(47, 35)
        Me.btnScho.TabIndex = 54
        Me.btnScho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYear
        '
        Me.btnYear.ActiveBorderThickness = 1
        Me.btnYear.ActiveCornerRadius = 20
        Me.btnYear.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnYear.ActiveForecolor = System.Drawing.Color.White
        Me.btnYear.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnYear.BackColor = System.Drawing.SystemColors.Control
        Me.btnYear.BackgroundImage = CType(resources.GetObject("btnYear.BackgroundImage"), System.Drawing.Image)
        Me.btnYear.ButtonText = " +"
        Me.btnYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYear.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYear.ForeColor = System.Drawing.Color.White
        Me.btnYear.IdleBorderThickness = 1
        Me.btnYear.IdleCornerRadius = 20
        Me.btnYear.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnYear.IdleForecolor = System.Drawing.Color.White
        Me.btnYear.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnYear.Location = New System.Drawing.Point(270, 182)
        Me.btnYear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnYear.Name = "btnYear"
        Me.btnYear.Size = New System.Drawing.Size(47, 35)
        Me.btnYear.TabIndex = 53
        Me.btnYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btntype
        '
        Me.btntype.ActiveBorderThickness = 1
        Me.btntype.ActiveCornerRadius = 20
        Me.btntype.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btntype.ActiveForecolor = System.Drawing.Color.White
        Me.btntype.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btntype.BackColor = System.Drawing.SystemColors.Control
        Me.btntype.BackgroundImage = CType(resources.GetObject("btntype.BackgroundImage"), System.Drawing.Image)
        Me.btntype.ButtonText = " +"
        Me.btntype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntype.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntype.ForeColor = System.Drawing.Color.White
        Me.btntype.IdleBorderThickness = 1
        Me.btntype.IdleCornerRadius = 20
        Me.btntype.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btntype.IdleForecolor = System.Drawing.Color.White
        Me.btntype.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btntype.Location = New System.Drawing.Point(270, 126)
        Me.btntype.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btntype.Name = "btntype"
        Me.btntype.Size = New System.Drawing.Size(47, 35)
        Me.btntype.TabIndex = 52
        Me.btntype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(500, 189)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(222, 31)
        Me.cmbStatus.TabIndex = 51
        '
        'cmbYL
        '
        Me.cmbYL.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYL.FormattingEnabled = True
        Me.cmbYL.Location = New System.Drawing.Point(131, 186)
        Me.cmbYL.Name = "cmbYL"
        Me.cmbYL.Size = New System.Drawing.Size(139, 31)
        Me.cmbYL.TabIndex = 51
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(547, 37)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(119, 31)
        Me.cmbGender.TabIndex = 51
        '
        'cmbScho
        '
        Me.cmbScho.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbScho.FormattingEnabled = True
        Me.cmbScho.Location = New System.Drawing.Point(457, 139)
        Me.cmbScho.Name = "cmbScho"
        Me.cmbScho.Size = New System.Drawing.Size(222, 31)
        Me.cmbScho.TabIndex = 51
        '
        'cmbCourse
        '
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(99, 130)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(171, 31)
        Me.cmbCourse.TabIndex = 50
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.HintForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.HintText = "Student ID No."
        Me.txtID.isPassword = False
        Me.txtID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtID.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtID.LineThickness = 4
        Me.txtID.Location = New System.Drawing.Point(168, 35)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(270, 35)
        Me.txtID.TabIndex = 4
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMI
        '
        Me.txtMI.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtMI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMI.HintForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMI.HintText = "M.I"
        Me.txtMI.isPassword = False
        Me.txtMI.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtMI.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtMI.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtMI.LineThickness = 4
        Me.txtMI.Location = New System.Drawing.Point(664, 77)
        Me.txtMI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(42, 35)
        Me.txtMI.TabIndex = 4
        Me.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(454, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 22)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(329, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Scholastic Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(14, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Year Level:"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 44
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student ID No."
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 261
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Scholarship"
        Me.ColumnHeader4.Width = 116
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Year Level"
        Me.ColumnHeader5.Width = 108
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Scholastic Status"
        Me.ColumnHeader7.Width = 173
        '
        'lvStudent
        '
        Me.lvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStudent.FullRowSelect = True
        Me.lvStudent.GridLines = True
        Me.lvStudent.Location = New System.Drawing.Point(210, 370)
        Me.lvStudent.MultiSelect = False
        Me.lvStudent.Name = "lvStudent"
        Me.lvStudent.Size = New System.Drawing.Size(854, 292)
        Me.lvStudent.TabIndex = 64
        Me.lvStudent.UseCompatibleStateImageBehavior = False
        Me.lvStudent.View = System.Windows.Forms.View.Details
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSearch.HintForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSearch.HintText = "Name or Student No."
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtSearch.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtSearch.LineThickness = 4
        Me.txtSearch.Location = New System.Drawing.Point(261, 327)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(295, 35)
        Me.txtSearch.TabIndex = 4
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 41)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Gender"
        Me.ColumnHeader8.Width = 89
        '
        'ucStudentProfiling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvStudent)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ucStudentProfiling"
        Me.Size = New System.Drawing.Size(1139, 708)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGivenName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbYL As ComboBox
    Friend WithEvents cmbScho As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtMI As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents lvStudent As ListView
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnScho As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnYear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btntype As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
