<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.slider = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnStudentProfile = New System.Windows.Forms.Button()
        Me.btnFacultyProfile = New System.Windows.Forms.Button()
        Me.btnDocument = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 68)
        Me.Panel2.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(869, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(76, 23)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "txtTime"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(345, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(90, 23)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "txtName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(248, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome, "
        '
        'Timer1
        '
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlDashboard.Location = New System.Drawing.Point(231, 65)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1139, 710)
        Me.pnlDashboard.TabIndex = 3
        '
        'slider
        '
        Me.slider.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.slider.Location = New System.Drawing.Point(3, 183)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(10, 62)
        Me.slider.TabIndex = 5
        Me.slider.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnMaintenance)
        Me.Panel1.Controls.Add(Me.btnStudentProfile)
        Me.Panel1.Controls.Add(Me.btnFacultyProfile)
        Me.Panel1.Controls.Add(Me.btnDocument)
        Me.Panel1.Controls.Add(Me.slider)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 773)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(31, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(16, 530)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 63)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "EXIT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMaintenance
        '
        Me.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaintenance.BackgroundImage = CType(resources.GetObject("btnMaintenance.BackgroundImage"), System.Drawing.Image)
        Me.btnMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMaintenance.Location = New System.Drawing.Point(16, 442)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(212, 63)
        Me.btnMaintenance.TabIndex = 4
        Me.btnMaintenance.Text = "MAINTENANCE"
        Me.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMaintenance.UseVisualStyleBackColor = False
        '
        'btnStudentProfile
        '
        Me.btnStudentProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStudentProfile.BackgroundImage = CType(resources.GetObject("btnStudentProfile.BackgroundImage"), System.Drawing.Image)
        Me.btnStudentProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudentProfile.FlatAppearance.BorderSize = 0
        Me.btnStudentProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnStudentProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnStudentProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProfile.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudentProfile.Location = New System.Drawing.Point(16, 352)
        Me.btnStudentProfile.Name = "btnStudentProfile"
        Me.btnStudentProfile.Size = New System.Drawing.Size(212, 63)
        Me.btnStudentProfile.TabIndex = 4
        Me.btnStudentProfile.Text = "STUDENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudentProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnStudentProfile.UseVisualStyleBackColor = False
        '
        'btnFacultyProfile
        '
        Me.btnFacultyProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFacultyProfile.BackgroundImage = CType(resources.GetObject("btnFacultyProfile.BackgroundImage"), System.Drawing.Image)
        Me.btnFacultyProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFacultyProfile.FlatAppearance.BorderSize = 0
        Me.btnFacultyProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnFacultyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnFacultyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFacultyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacultyProfile.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacultyProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFacultyProfile.Location = New System.Drawing.Point(16, 265)
        Me.btnFacultyProfile.Name = "btnFacultyProfile"
        Me.btnFacultyProfile.Size = New System.Drawing.Size(212, 63)
        Me.btnFacultyProfile.TabIndex = 4
        Me.btnFacultyProfile.Text = "FACULTY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFacultyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacultyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnFacultyProfile.UseVisualStyleBackColor = False
        '
        'btnDocument
        '
        Me.btnDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDocument.BackgroundImage = CType(resources.GetObject("btnDocument.BackgroundImage"), System.Drawing.Image)
        Me.btnDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDocument.FlatAppearance.BorderSize = 0
        Me.btnDocument.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocument.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocument.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDocument.Location = New System.Drawing.Point(16, 183)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(212, 63)
        Me.btnDocument.TabIndex = 4
        Me.btnDocument.Text = "DOCUMENTS"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDocument.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents slider As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDocument As Button
    Friend WithEvents btnFacultyProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnStudentProfile As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
