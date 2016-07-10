<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAliquoting
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
        Me.nudVol = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvAliquots = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAliq1 = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.txtSampleType = New System.Windows.Forms.TextBox()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.dtpColdt = New System.Windows.Forms.DateTimePicker()
        Me.cb_rack = New System.Windows.Forms.ComboBox()
        Me.cb_shelf = New System.Windows.Forms.ComboBox()
        Me.nud_pos = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cb_Box = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cb_freezer = New System.Windows.Forms.ComboBox()
        Me.grpArchiving = New System.Windows.Forms.GroupBox()
        Me.cmdGBox = New System.Windows.Forms.Button()
        Me.btn_archive = New System.Windows.Forms.Button()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArchiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Curl = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.grp_Shipping = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpsenddate = New System.Windows.Forms.DateTimePicker()
        Me.ch_Expected = New System.Windows.Forms.CheckBox()
        Me.txtAddressee = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cb_destination = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_origin = New System.Windows.Forms.ComboBox()
        CType(Me.nudVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAliquots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_pos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArchiving.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        Me.grp_Shipping.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudVol
        '
        Me.nudVol.DecimalPlaces = 2
        Me.nudVol.Location = New System.Drawing.Point(327, 68)
        Me.nudVol.Name = "nudVol"
        Me.nudVol.Size = New System.Drawing.Size(65, 20)
        Me.nudVol.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(594, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Colection Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(382, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Collection Site"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(158, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Sample Type"
        '
        'dgvAliquots
        '
        Me.dgvAliquots.AllowUserToAddRows = False
        Me.dgvAliquots.AllowUserToDeleteRows = False
        Me.dgvAliquots.AllowUserToOrderColumns = True
        Me.dgvAliquots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAliquots.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAliquots.Location = New System.Drawing.Point(12, 95)
        Me.dgvAliquots.MultiSelect = False
        Me.dgvAliquots.Name = "dgvAliquots"
        Me.dgvAliquots.ReadOnly = True
        Me.dgvAliquots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAliquots.Size = New System.Drawing.Size(843, 210)
        Me.dgvAliquots.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "&Add aliquots"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(354, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Please Scan each of the Unique ID of the sample labels into these boxes "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "UNIQUEID"
        '
        'txtAliq1
        '
        Me.txtAliq1.Location = New System.Drawing.Point(81, 69)
        Me.txtAliq1.Name = "txtAliq1"
        Me.txtAliq1.Size = New System.Drawing.Size(171, 20)
        Me.txtAliq1.TabIndex = 39
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Location = New System.Drawing.Point(16, 16)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(133, 20)
        Me.txtBarcode.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = " Barcode "
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(266, 72)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(47, 13)
        Me.lblVolume.TabIndex = 59
        Me.lblVolume.Text = "Vol/Wgt"
        '
        'txtSampleType
        '
        Me.txtSampleType.Enabled = False
        Me.txtSampleType.Location = New System.Drawing.Point(230, 12)
        Me.txtSampleType.Name = "txtSampleType"
        Me.txtSampleType.Size = New System.Drawing.Size(133, 20)
        Me.txtSampleType.TabIndex = 36
        '
        'txtSite
        '
        Me.txtSite.Enabled = False
        Me.txtSite.Location = New System.Drawing.Point(456, 14)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(125, 20)
        Me.txtSite.TabIndex = 36
        '
        'dtpColdt
        '
        Me.dtpColdt.Enabled = False
        Me.dtpColdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpColdt.Location = New System.Drawing.Point(678, 13)
        Me.dtpColdt.Name = "dtpColdt"
        Me.dtpColdt.Size = New System.Drawing.Size(91, 20)
        Me.dtpColdt.TabIndex = 60
        Me.dtpColdt.Value = New Date(2016, 7, 8, 0, 0, 0, 0)
        '
        'cb_rack
        '
        Me.cb_rack.FormattingEnabled = True
        Me.cb_rack.Location = New System.Drawing.Point(263, 38)
        Me.cb_rack.Name = "cb_rack"
        Me.cb_rack.Size = New System.Drawing.Size(121, 21)
        Me.cb_rack.TabIndex = 79
        '
        'cb_shelf
        '
        Me.cb_shelf.FormattingEnabled = True
        Me.cb_shelf.Location = New System.Drawing.Point(163, 38)
        Me.cb_shelf.Name = "cb_shelf"
        Me.cb_shelf.Size = New System.Drawing.Size(94, 21)
        Me.cb_shelf.TabIndex = 78
        '
        'nud_pos
        '
        Me.nud_pos.Location = New System.Drawing.Point(470, 38)
        Me.nud_pos.Maximum = New Decimal(New Integer() {81, 0, 0, 0})
        Me.nud_pos.Name = "nud_pos"
        Me.nud_pos.Size = New System.Drawing.Size(36, 20)
        Me.nud_pos.TabIndex = 77
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(467, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "Position"
        '
        'cb_Box
        '
        Me.cb_Box.FormattingEnabled = True
        Me.cb_Box.Location = New System.Drawing.Point(390, 38)
        Me.cb_Box.MaxDropDownItems = 100
        Me.cb_Box.Name = "cb_Box"
        Me.cb_Box.Size = New System.Drawing.Size(62, 21)
        Me.cb_Box.TabIndex = 75
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(390, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Box"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(265, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Rack"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(160, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Shelf"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Freezer"
        '
        'cb_freezer
        '
        Me.cb_freezer.FormattingEnabled = True
        Me.cb_freezer.Items.AddRange(New Object() {"1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "2", "20", "21", "22", "23", "24", "3", "4", "5", "6", "7", "8", "9"})
        Me.cb_freezer.Location = New System.Drawing.Point(15, 38)
        Me.cb_freezer.MaxDropDownItems = 100
        Me.cb_freezer.Name = "cb_freezer"
        Me.cb_freezer.Size = New System.Drawing.Size(142, 21)
        Me.cb_freezer.TabIndex = 70
        '
        'grpArchiving
        '
        Me.grpArchiving.AutoSize = True
        Me.grpArchiving.Controls.Add(Me.cmdGBox)
        Me.grpArchiving.Controls.Add(Me.btn_archive)
        Me.grpArchiving.Controls.Add(Me.cb_rack)
        Me.grpArchiving.Controls.Add(Me.cb_shelf)
        Me.grpArchiving.Controls.Add(Me.nud_pos)
        Me.grpArchiving.Controls.Add(Me.Label20)
        Me.grpArchiving.Controls.Add(Me.cb_Box)
        Me.grpArchiving.Controls.Add(Me.Label22)
        Me.grpArchiving.Controls.Add(Me.Label23)
        Me.grpArchiving.Controls.Add(Me.Label24)
        Me.grpArchiving.Controls.Add(Me.Label25)
        Me.grpArchiving.Controls.Add(Me.cb_freezer)
        Me.grpArchiving.Location = New System.Drawing.Point(16, 311)
        Me.grpArchiving.Name = "grpArchiving"
        Me.grpArchiving.Size = New System.Drawing.Size(818, 78)
        Me.grpArchiving.TabIndex = 80
        Me.grpArchiving.TabStop = False
        Me.grpArchiving.Text = "Sample archiving"
        Me.grpArchiving.Visible = False
        '
        'cmdGBox
        '
        Me.cmdGBox.Location = New System.Drawing.Point(564, 36)
        Me.cmdGBox.Name = "cmdGBox"
        Me.cmdGBox.Size = New System.Drawing.Size(57, 23)
        Me.cmdGBox.TabIndex = 81
        Me.cmdGBox.Text = "BoxView"
        Me.cmdGBox.UseVisualStyleBackColor = True
        '
        'btn_archive
        '
        Me.btn_archive.Location = New System.Drawing.Point(645, 35)
        Me.btn_archive.Name = "btn_archive"
        Me.btn_archive.Size = New System.Drawing.Size(129, 23)
        Me.btn_archive.TabIndex = 80
        Me.btn_archive.Text = "Save to Archive"
        Me.btn_archive.UseVisualStyleBackColor = True
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiveToolStripMenuItem, Me.ToolStripMenuItem1, Me.Curl, Me.EditToolStripMenuItem, Me.ToolStripMenuItem3, Me.Delete})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(179, 136)
        '
        'ArchiveToolStripMenuItem
        '
        Me.ArchiveToolStripMenuItem.Name = "ArchiveToolStripMenuItem"
        Me.ArchiveToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ArchiveToolStripMenuItem.Text = "Archive"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem1.Text = "Ship"
        '
        'Curl
        '
        Me.Curl.Name = "Curl"
        Me.Curl.Size = New System.Drawing.Size(178, 22)
        Me.Curl.Text = "Curl"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem3.Text = "============="
        '
        'Delete
        '
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(178, 22)
        Me.Delete.Text = "Delete"
        '
        'grp_Shipping
        '
        Me.grp_Shipping.AutoSize = True
        Me.grp_Shipping.Controls.Add(Me.Label2)
        Me.grp_Shipping.Controls.Add(Me.dtpsenddate)
        Me.grp_Shipping.Controls.Add(Me.ch_Expected)
        Me.grp_Shipping.Controls.Add(Me.txtAddressee)
        Me.grp_Shipping.Controls.Add(Me.Button4)
        Me.grp_Shipping.Controls.Add(Me.cb_destination)
        Me.grp_Shipping.Controls.Add(Me.Label3)
        Me.grp_Shipping.Controls.Add(Me.Label6)
        Me.grp_Shipping.Controls.Add(Me.Label7)
        Me.grp_Shipping.Controls.Add(Me.cb_origin)
        Me.grp_Shipping.Location = New System.Drawing.Point(16, 395)
        Me.grp_Shipping.Name = "grp_Shipping"
        Me.grp_Shipping.Size = New System.Drawing.Size(818, 90)
        Me.grp_Shipping.TabIndex = 82
        Me.grp_Shipping.TabStop = False
        Me.grp_Shipping.Text = "Sample Shipping"
        Me.grp_Shipping.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Send Date"
        '
        'dtpsenddate
        '
        Me.dtpsenddate.CustomFormat = "MM/dd/yyyy"
        Me.dtpsenddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsenddate.Location = New System.Drawing.Point(311, 15)
        Me.dtpsenddate.Name = "dtpsenddate"
        Me.dtpsenddate.Size = New System.Drawing.Size(104, 20)
        Me.dtpsenddate.TabIndex = 84
        '
        'ch_Expected
        '
        Me.ch_Expected.AutoSize = True
        Me.ch_Expected.Location = New System.Drawing.Point(581, 32)
        Me.ch_Expected.Name = "ch_Expected"
        Me.ch_Expected.Size = New System.Drawing.Size(168, 17)
        Me.ch_Expected.TabIndex = 83
        Me.ch_Expected.Text = "This Sample is expected back"
        Me.ch_Expected.UseVisualStyleBackColor = True
        '
        'txtAddressee
        '
        Me.txtAddressee.Location = New System.Drawing.Point(311, 51)
        Me.txtAddressee.Name = "txtAddressee"
        Me.txtAddressee.Size = New System.Drawing.Size(228, 20)
        Me.txtAddressee.TabIndex = 82
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(753, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 23)
        Me.Button4.TabIndex = 80
        Me.Button4.Text = "Dispatch"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cb_destination
        '
        Me.cb_destination.FormattingEnabled = True
        Me.cb_destination.Items.AddRange(New Object() {"", "Nairobi", "Kisumu", "Atlanta", "UoM"})
        Me.cb_destination.Location = New System.Drawing.Point(71, 50)
        Me.cb_destination.Name = "cb_destination"
        Me.cb_destination.Size = New System.Drawing.Size(119, 21)
        Me.cb_destination.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Attention To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Origin"
        '
        'cb_origin
        '
        Me.cb_origin.FormattingEnabled = True
        Me.cb_origin.Items.AddRange(New Object() {"", "Nairobi", "Kisumu", "Atlanta", "UoM"})
        Me.cb_origin.Location = New System.Drawing.Point(48, 18)
        Me.cb_origin.MaxDropDownItems = 100
        Me.cb_origin.Name = "cb_origin"
        Me.cb_origin.Size = New System.Drawing.Size(142, 21)
        Me.cb_origin.TabIndex = 70
        '
        'frmAliquoting
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(875, 490)
        Me.Controls.Add(Me.grp_Shipping)
        Me.Controls.Add(Me.grpArchiving)
        Me.Controls.Add(Me.dtpColdt)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.nudVol)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvAliquots)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAliq1)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.txtSampleType)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAliquoting"
        Me.Text = "Aliquoting"
        CType(Me.nudVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAliquots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_pos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArchiving.ResumeLayout(False)
        Me.grpArchiving.PerformLayout()
        Me.ctxMenu.ResumeLayout(False)
        Me.grp_Shipping.ResumeLayout(False)
        Me.grp_Shipping.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudVol As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvAliquots As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAliq1 As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents txtSampleType As TextBox
    Friend WithEvents txtSite As TextBox
    Friend WithEvents dtpColdt As DateTimePicker
    Friend WithEvents cb_rack As ComboBox
    Friend WithEvents cb_shelf As ComboBox
    Friend WithEvents nud_pos As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents cb_Box As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cb_freezer As ComboBox
    Friend WithEvents grpArchiving As GroupBox
    Friend WithEvents btn_archive As Button
    Friend WithEvents cmdGBox As Button
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents Delete As ToolStripMenuItem
    Friend WithEvents Curl As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents grp_Shipping As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpsenddate As DateTimePicker
    Friend WithEvents ch_Expected As CheckBox
    Friend WithEvents txtAddressee As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents cb_destination As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_origin As ComboBox
    Friend WithEvents ArchiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
