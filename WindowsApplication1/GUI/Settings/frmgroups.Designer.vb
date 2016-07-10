<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroups
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdescrp = New System.Windows.Forms.TextBox()
        Me.txtgroup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdedit = New System.Windows.Forms.Button()
        Me.dtggroups = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtggroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 28)
        Me.Panel1.TabIndex = 108
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Groups management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdescrp)
        Me.GroupBox1.Controls.Add(Me.txtgroup)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 97)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        '
        'txtdescrp
        '
        Me.txtdescrp.Location = New System.Drawing.Point(125, 50)
        Me.txtdescrp.Multiline = True
        Me.txtdescrp.Name = "txtdescrp"
        Me.txtdescrp.Size = New System.Drawing.Size(458, 36)
        Me.txtdescrp.TabIndex = 3
        '
        'txtgroup
        '
        Me.txtgroup.Location = New System.Drawing.Point(125, 19)
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.Size = New System.Drawing.Size(181, 20)
        Me.txtgroup.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Group Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 66)
        Me.GroupBox3.TabIndex = 106
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdsave)
        Me.GroupBox4.Controls.Add(Me.cmddelete)
        Me.GroupBox4.Location = New System.Drawing.Point(373, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(246, 55)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(6, 14)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(109, 36)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Save  group"
        Me.cmdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddelete.Location = New System.Drawing.Point(131, 12)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(109, 36)
        Me.cmddelete.TabIndex = 18
        Me.cmddelete.Text = "&Delete group"
        Me.cmddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.cmdedit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 55)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdclose.Location = New System.Drawing.Point(8, 13)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(109, 36)
        Me.cmdclose.TabIndex = 19
        Me.cmdclose.Text = "&New group"
        Me.cmdclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdedit
        '
        Me.cmdedit.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdedit.Location = New System.Drawing.Point(123, 13)
        Me.cmdedit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(109, 36)
        Me.cmdedit.TabIndex = 17
        Me.cmdedit.Text = "&Edit group"
        Me.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'dtggroups
        '
        Me.dtggroups.BackgroundColor = System.Drawing.Color.White
        Me.dtggroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtggroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtggroups.Location = New System.Drawing.Point(18, 139)
        Me.dtggroups.Name = "dtggroups"
        Me.dtggroups.Size = New System.Drawing.Size(637, 193)
        Me.dtggroups.TabIndex = 105
        '
        'frmgroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 419)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtggroups)
        Me.Name = "frmgroups"
        Me.Text = "frmgroups"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtggroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdescrp As TextBox
    Friend WithEvents txtgroup As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdclose As Button
    Friend WithEvents cmdedit As Button
    Friend WithEvents dtggroups As DataGridView
End Class
