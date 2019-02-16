<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDocumentMaintenance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDocumentMaintenance))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDocType2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDocType = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDocCat = New System.Windows.Forms.Button()
        Me.btnDocCat2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btbBorrow = New System.Windows.Forms.Button()
        Me.btnBorrow2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(302, 225)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 86)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "•Manage Document Type." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Add Document Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Delete Document Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Edit Document" &
    " Type"
        '
        'btnDocType2
        '
        Me.btnDocType2.BackColor = System.Drawing.SystemColors.Control
        Me.btnDocType2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDocType2.FlatAppearance.BorderSize = 0
        Me.btnDocType2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocType2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocType2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocType2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDocType2.Location = New System.Drawing.Point(305, 190)
        Me.btnDocType2.Name = "btnDocType2"
        Me.btnDocType2.Size = New System.Drawing.Size(163, 33)
        Me.btnDocType2.TabIndex = 20
        Me.btnDocType2.Text = "Document Type"
        Me.btnDocType2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocType2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 12)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Document Maintenance"
        '
        'btnDocType
        '
        Me.btnDocType.BackColor = System.Drawing.SystemColors.Control
        Me.btnDocType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDocType.FlatAppearance.BorderSize = 0
        Me.btnDocType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocType.Image = CType(resources.GetObject("btnDocType.Image"), System.Drawing.Image)
        Me.btnDocType.Location = New System.Drawing.Point(161, 190)
        Me.btnDocType.Name = "btnDocType"
        Me.btnDocType.Size = New System.Drawing.Size(138, 131)
        Me.btnDocType.TabIndex = 14
        Me.btnDocType.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me.btnDocType
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
        Me.btnBack.Location = New System.Drawing.Point(37, 588)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 73)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDocCat
        '
        Me.btnDocCat.BackColor = System.Drawing.SystemColors.Control
        Me.btnDocCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDocCat.FlatAppearance.BorderSize = 0
        Me.btnDocCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocCat.Image = CType(resources.GetObject("btnDocCat.Image"), System.Drawing.Image)
        Me.btnDocCat.Location = New System.Drawing.Point(618, 190)
        Me.btnDocCat.Name = "btnDocCat"
        Me.btnDocCat.Size = New System.Drawing.Size(138, 131)
        Me.btnDocCat.TabIndex = 14
        Me.btnDocCat.UseVisualStyleBackColor = False
        '
        'btnDocCat2
        '
        Me.btnDocCat2.BackColor = System.Drawing.SystemColors.Control
        Me.btnDocCat2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDocCat2.FlatAppearance.BorderSize = 0
        Me.btnDocCat2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocCat2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDocCat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocCat2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocCat2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDocCat2.Location = New System.Drawing.Point(762, 190)
        Me.btnDocCat2.Name = "btnDocCat2"
        Me.btnDocCat2.Size = New System.Drawing.Size(213, 33)
        Me.btnDocCat2.TabIndex = 20
        Me.btnDocCat2.Text = "Document Category"
        Me.btnDocCat2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocCat2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(759, 225)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(242, 86)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "•Manage Document Category." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Add Document Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Delete Document Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•E" &
    "dit Document Category"
        '
        'btbBorrow
        '
        Me.btbBorrow.BackColor = System.Drawing.SystemColors.Control
        Me.btbBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbBorrow.FlatAppearance.BorderSize = 0
        Me.btbBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btbBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btbBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbBorrow.Image = CType(resources.GetObject("btbBorrow.Image"), System.Drawing.Image)
        Me.btbBorrow.Location = New System.Drawing.Point(401, 400)
        Me.btbBorrow.Name = "btbBorrow"
        Me.btbBorrow.Size = New System.Drawing.Size(138, 131)
        Me.btbBorrow.TabIndex = 14
        Me.btbBorrow.UseVisualStyleBackColor = False
        '
        'btnBorrow2
        '
        Me.btnBorrow2.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrow2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow2.FlatAppearance.BorderSize = 0
        Me.btnBorrow2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBorrow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBorrow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBorrow2.Location = New System.Drawing.Point(545, 400)
        Me.btnBorrow2.Name = "btnBorrow2"
        Me.btnBorrow2.Size = New System.Drawing.Size(266, 33)
        Me.btnBorrow2.TabIndex = 20
        Me.btnBorrow2.Text = "Docs Borrowable Category"
        Me.btnBorrow2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrow2.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(542, 435)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(289, 86)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.Text = "•Manage Docs Borrowable Category." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Add Docs Borrowable Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Delete Docs Bo" &
    "rrowable Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•Edit Docs Borrowable Category"
        '
        'ucDocumentMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBorrow2)
        Me.Controls.Add(Me.btnDocCat2)
        Me.Controls.Add(Me.btnDocType2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbBorrow)
        Me.Controls.Add(Me.btnDocCat)
        Me.Controls.Add(Me.btnDocType)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ucDocumentMaintenance"
        Me.Size = New System.Drawing.Size(1139, 708)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnDocType2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDocType As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDocCat As Button
    Friend WithEvents btnDocCat2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btbBorrow As Button
    Friend WithEvents btnBorrow2 As Button
    Friend WithEvents TextBox3 As TextBox
End Class
