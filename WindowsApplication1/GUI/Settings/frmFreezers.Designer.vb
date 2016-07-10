<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreezers
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
        Me.cmdNewFreezer = New System.Windows.Forms.Button()
        Me.cmdDeleteFreezer = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdEditFreezer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvFreezers = New System.Windows.Forms.DataGridView()
        Me.grpFreezers = New System.Windows.Forms.GroupBox()
        Me.nud_Fno = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpInstallDate = New System.Windows.Forms.DateTimePicker()
        Me.nudFreezerBoxes = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NudFreezerRacks = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudFreezerShelves = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFreezerLocation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt = New System.Windows.Forms.Label()
        Me.txtFreezerName = New System.Windows.Forms.TextBox()
        CType(Me.dgvFreezers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFreezers.SuspendLayout()
        CType(Me.nud_Fno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFreezerBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudFreezerRacks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFreezerShelves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNewFreezer
        '
        Me.cmdNewFreezer.Location = New System.Drawing.Point(19, 218)
        Me.cmdNewFreezer.Name = "cmdNewFreezer"
        Me.cmdNewFreezer.Size = New System.Drawing.Size(83, 21)
        Me.cmdNewFreezer.TabIndex = 24
        Me.cmdNewFreezer.Text = "New Freezer"
        Me.cmdNewFreezer.UseVisualStyleBackColor = True
        '
        'cmdDeleteFreezer
        '
        Me.cmdDeleteFreezer.Enabled = False
        Me.cmdDeleteFreezer.Location = New System.Drawing.Point(466, 207)
        Me.cmdDeleteFreezer.Name = "cmdDeleteFreezer"
        Me.cmdDeleteFreezer.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteFreezer.TabIndex = 23
        Me.cmdDeleteFreezer.Text = "Delete Freezer"
        Me.cmdDeleteFreezer.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(265, 206)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Save Freezer"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEditFreezer
        '
        Me.cmdEditFreezer.Enabled = False
        Me.cmdEditFreezer.Location = New System.Drawing.Point(357, 206)
        Me.cmdEditFreezer.Name = "cmdEditFreezer"
        Me.cmdEditFreezer.Size = New System.Drawing.Size(88, 24)
        Me.cmdEditFreezer.TabIndex = 21
        Me.cmdEditFreezer.Text = "Edit"
        Me.cmdEditFreezer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(563, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Existing freezers (Click on a freezer then click Edit to update an exsisting free" &
    "zer)"
        '
        'dgvFreezers
        '
        Me.dgvFreezers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFreezers.Location = New System.Drawing.Point(6, 304)
        Me.dgvFreezers.Name = "dgvFreezers"
        Me.dgvFreezers.Size = New System.Drawing.Size(873, 154)
        Me.dgvFreezers.TabIndex = 19
        '
        'grpFreezers
        '
        Me.grpFreezers.Controls.Add(Me.nud_Fno)
        Me.grpFreezers.Controls.Add(Me.Label8)
        Me.grpFreezers.Controls.Add(Me.dtpInstallDate)
        Me.grpFreezers.Controls.Add(Me.nudFreezerBoxes)
        Me.grpFreezers.Controls.Add(Me.Label6)
        Me.grpFreezers.Controls.Add(Me.NudFreezerRacks)
        Me.grpFreezers.Controls.Add(Me.Label5)
        Me.grpFreezers.Controls.Add(Me.nudFreezerShelves)
        Me.grpFreezers.Controls.Add(Me.Label2)
        Me.grpFreezers.Controls.Add(Me.Label3)
        Me.grpFreezers.Controls.Add(Me.txtFreezerLocation)
        Me.grpFreezers.Controls.Add(Me.Label7)
        Me.grpFreezers.Controls.Add(Me.Txt)
        Me.grpFreezers.Controls.Add(Me.txtFreezerName)
        Me.grpFreezers.Location = New System.Drawing.Point(22, 12)
        Me.grpFreezers.Name = "grpFreezers"
        Me.grpFreezers.Size = New System.Drawing.Size(630, 189)
        Me.grpFreezers.TabIndex = 25
        Me.grpFreezers.TabStop = False
        Me.grpFreezers.Text = "Adding a new Freezer"
        '
        'nud_Fno
        '
        Me.nud_Fno.Location = New System.Drawing.Point(103, 20)
        Me.nud_Fno.Name = "nud_Fno"
        Me.nud_Fno.Size = New System.Drawing.Size(120, 20)
        Me.nud_Fno.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Install Date"
        '
        'dtpInstallDate
        '
        Me.dtpInstallDate.Location = New System.Drawing.Point(121, 139)
        Me.dtpInstallDate.Name = "dtpInstallDate"
        Me.dtpInstallDate.Size = New System.Drawing.Size(163, 20)
        Me.dtpInstallDate.TabIndex = 13
        '
        'nudFreezerBoxes
        '
        Me.nudFreezerBoxes.Location = New System.Drawing.Point(542, 98)
        Me.nudFreezerBoxes.Name = "nudFreezerBoxes"
        Me.nudFreezerBoxes.Size = New System.Drawing.Size(61, 20)
        Me.nudFreezerBoxes.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No of boxes per Rack"
        '
        'NudFreezerRacks
        '
        Me.NudFreezerRacks.Location = New System.Drawing.Point(329, 98)
        Me.NudFreezerRacks.Name = "NudFreezerRacks"
        Me.NudFreezerRacks.Size = New System.Drawing.Size(61, 20)
        Me.NudFreezerRacks.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No of Racks per Shelf"
        '
        'nudFreezerShelves
        '
        Me.nudFreezerShelves.Location = New System.Drawing.Point(121, 98)
        Me.nudFreezerShelves.Name = "nudFreezerShelves"
        Me.nudFreezerShelves.Size = New System.Drawing.Size(61, 20)
        Me.nudFreezerShelves.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Freezer Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No of Shelves"
        '
        'txtFreezerLocation
        '
        Me.txtFreezerLocation.Location = New System.Drawing.Point(102, 72)
        Me.txtFreezerLocation.Name = "txtFreezerLocation"
        Me.txtFreezerLocation.Size = New System.Drawing.Size(163, 20)
        Me.txtFreezerLocation.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Freezer NO."
        '
        'Txt
        '
        Me.Txt.AutoSize = True
        Me.Txt.Location = New System.Drawing.Point(11, 49)
        Me.Txt.Name = "Txt"
        Me.Txt.Size = New System.Drawing.Size(73, 13)
        Me.Txt.TabIndex = 0
        Me.Txt.Text = "Freezer Name"
        '
        'txtFreezerName
        '
        Me.txtFreezerName.Location = New System.Drawing.Point(103, 46)
        Me.txtFreezerName.Name = "txtFreezerName"
        Me.txtFreezerName.Size = New System.Drawing.Size(162, 20)
        Me.txtFreezerName.TabIndex = 1
        '
        'frmFreezers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 491)
        Me.Controls.Add(Me.cmdNewFreezer)
        Me.Controls.Add(Me.cmdDeleteFreezer)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdEditFreezer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvFreezers)
        Me.Controls.Add(Me.grpFreezers)
        Me.Name = "frmFreezers"
        CType(Me.dgvFreezers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFreezers.ResumeLayout(False)
        Me.grpFreezers.PerformLayout()
        CType(Me.nud_Fno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFreezerBoxes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudFreezerRacks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFreezerShelves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdNewFreezer As Button
    Friend WithEvents cmdDeleteFreezer As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdEditFreezer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvFreezers As DataGridView
    Friend WithEvents grpFreezers As GroupBox
    Friend WithEvents nudFreezerBoxes As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NudFreezerRacks As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudFreezerShelves As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFreezerLocation As TextBox
    Friend WithEvents Txt As Label
    Friend WithEvents txtFreezerName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpInstallDate As DateTimePicker
    Friend WithEvents nud_Fno As NumericUpDown
    Friend WithEvents Label7 As Label
End Class
