<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusers
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
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lst_users = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cpwd = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.usrnm = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.initials = New System.Windows.Forms.TextBox()
        Me.onames = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdedit = New System.Windows.Forms.Button()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(105, 376)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(14, 16)
        Me.lblcount.TabIndex = 119
        Me.lblcount.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 16)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "Record count :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 395)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(667, 41)
        Me.GroupBox4.TabIndex = 117
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "data legend"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(498, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Administer system"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(266, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "supervises field activivties"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "conducts data collection"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(451, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ADMIN :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(188, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "SUPERVISOR :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "CI :"
        '
        'lst_users
        '
        Me.lst_users.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_users.FullRowSelect = True
        Me.lst_users.GridLines = True
        Me.lst_users.Location = New System.Drawing.Point(13, 202)
        Me.lst_users.Name = "lst_users"
        Me.lst_users.Size = New System.Drawing.Size(670, 171)
        Me.lst_users.TabIndex = 116
        Me.lst_users.UseCompatibleStateImageBehavior = False
        Me.lst_users.View = System.Windows.Forms.View.Details
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(13, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 27)
        Me.Panel3.TabIndex = 115
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(705, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(5, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Patient care system | system users"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdclose)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 32)
        Me.Panel1.TabIndex = 114
        '
        'cmdclose
        '
        Me.cmdclose.Location = New System.Drawing.Point(644, 4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(34, 23)
        Me.cmdclose.TabIndex = 1
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "system users management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cpwd)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.usrnm)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.initials)
        Me.GroupBox1.Controls.Add(Me.onames)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 126)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'grp
        '
        Me.grp.FormattingEnabled = True
        Me.grp.Location = New System.Drawing.Point(86, 26)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(181, 21)
        Me.grp.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "group ID :"
        '
        'cpwd
        '
        Me.cpwd.Location = New System.Drawing.Point(473, 97)
        Me.cpwd.Name = "cpwd"
        Me.cpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cpwd.Size = New System.Drawing.Size(181, 20)
        Me.cpwd.TabIndex = 14
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(473, 71)
        Me.pwd.Name = "pwd"
        Me.pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd.Size = New System.Drawing.Size(181, 20)
        Me.pwd.TabIndex = 13
        '
        'usrnm
        '
        Me.usrnm.Location = New System.Drawing.Point(473, 46)
        Me.usrnm.Name = "usrnm"
        Me.usrnm.Size = New System.Drawing.Size(181, 20)
        Me.usrnm.TabIndex = 12
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(473, 22)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(181, 20)
        Me.email.TabIndex = 11
        '
        'initials
        '
        Me.initials.Location = New System.Drawing.Point(86, 101)
        Me.initials.Name = "initials"
        Me.initials.Size = New System.Drawing.Size(66, 20)
        Me.initials.TabIndex = 10
        '
        'onames
        '
        Me.onames.Location = New System.Drawing.Point(86, 75)
        Me.onames.Name = "onames"
        Me.onames.Size = New System.Drawing.Size(181, 20)
        Me.onames.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(375, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "confirm password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "email address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Initials :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Other name :"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(86, 50)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(181, 20)
        Me.fname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdsave)
        Me.GroupBox3.Controls.Add(Me.cmddelete)
        Me.GroupBox3.Controls.Add(Me.cmdedit)
        Me.GroupBox3.Controls.Add(Me.cmdaddnew)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 434)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(671, 44)
        Me.GroupBox3.TabIndex = 112
        Me.GroupBox3.TabStop = False
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(471, 9)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(96, 30)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Save  user"
        Me.cmdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddelete.Location = New System.Drawing.Point(570, 9)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(99, 30)
        Me.cmddelete.TabIndex = 18
        Me.cmddelete.Text = "&Delete user"
        Me.cmddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdedit
        '
        Me.cmdedit.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdedit.Location = New System.Drawing.Point(107, 9)
        Me.cmdedit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(101, 30)
        Me.cmdedit.TabIndex = 17
        Me.cmdedit.Text = "&Edid Record"
        Me.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaddnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdaddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdaddnew.Location = New System.Drawing.Point(6, 9)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(97, 30)
        Me.cmdaddnew.TabIndex = 20
        Me.cmdaddnew.Text = "&New Record"
        Me.cmdaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 484)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lst_users)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcount As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lst_users As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdclose As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grp As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cpwd As TextBox
    Friend WithEvents pwd As TextBox
    Friend WithEvents usrnm As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents initials As TextBox
    Friend WithEvents onames As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdedit As Button
    Friend WithEvents cmdaddnew As Button
End Class
