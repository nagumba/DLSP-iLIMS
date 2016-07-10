<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResultsQC
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.cb_Locaca = New System.Windows.Forms.ComboBox()
        Me.cb_typeD = New System.Windows.Forms.ComboBox()
        Me.cb_location = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cb_locCat = New System.Windows.Forms.ComboBox()
        Me.cbBarcode = New System.Windows.Forms.ComboBox()
        Me.cb_TypeCat = New System.Windows.Forms.ComboBox()
        Me.cb_DateCat = New System.Windows.Forms.ComboBox()
        Me.cb_barCar = New System.Windows.Forms.ComboBox()
        Me.chkUser = New System.Windows.Forms.CheckBox()
        Me.chkLocation = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSampleType = New System.Windows.Forms.CheckBox()
        Me.chk_dates = New System.Windows.Forms.CheckBox()
        Me.chk_barcode = New System.Windows.Forms.CheckBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtspStartDAte = New System.Windows.Forms.DateTimePicker()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Results = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_Test = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Archive = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_aliq = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(730, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Export Results to Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(730, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbUser
        '
        Me.cbUser.Enabled = False
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cbUser.Location = New System.Drawing.Point(136, 144)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(175, 21)
        Me.cbUser.TabIndex = 36
        '
        'cb_Locaca
        '
        Me.cb_Locaca.Enabled = False
        Me.cb_Locaca.FormattingEnabled = True
        Me.cb_Locaca.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_Locaca.Location = New System.Drawing.Point(357, 90)
        Me.cb_Locaca.Name = "cb_Locaca"
        Me.cb_Locaca.Size = New System.Drawing.Size(175, 21)
        Me.cb_Locaca.TabIndex = 35
        '
        'cb_typeD
        '
        Me.cb_typeD.Enabled = False
        Me.cb_typeD.FormattingEnabled = True
        Me.cb_typeD.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_typeD.Location = New System.Drawing.Point(357, 117)
        Me.cb_typeD.Name = "cb_typeD"
        Me.cb_typeD.Size = New System.Drawing.Size(175, 21)
        Me.cb_typeD.TabIndex = 34
        '
        'cb_location
        '
        Me.cb_location.Enabled = False
        Me.cb_location.FormattingEnabled = True
        Me.cb_location.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_location.Location = New System.Drawing.Point(136, 90)
        Me.cb_location.Name = "cb_location"
        Me.cb_location.Size = New System.Drawing.Size(175, 21)
        Me.cb_location.TabIndex = 33
        '
        'cbType
        '
        Me.cbType.Enabled = False
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cbType.Location = New System.Drawing.Point(136, 117)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(175, 21)
        Me.cbType.TabIndex = 32
        '
        'cb_locCat
        '
        Me.cb_locCat.Enabled = False
        Me.cb_locCat.FormattingEnabled = True
        Me.cb_locCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_locCat.Location = New System.Drawing.Point(567, 91)
        Me.cb_locCat.Name = "cb_locCat"
        Me.cb_locCat.Size = New System.Drawing.Size(77, 21)
        Me.cb_locCat.TabIndex = 29
        '
        'cbBarcode
        '
        Me.cbBarcode.Enabled = False
        Me.cbBarcode.FormattingEnabled = True
        Me.cbBarcode.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cbBarcode.Location = New System.Drawing.Point(136, 32)
        Me.cbBarcode.Name = "cbBarcode"
        Me.cbBarcode.Size = New System.Drawing.Size(175, 21)
        Me.cbBarcode.TabIndex = 31
        '
        'cb_TypeCat
        '
        Me.cb_TypeCat.Enabled = False
        Me.cb_TypeCat.FormattingEnabled = True
        Me.cb_TypeCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_TypeCat.Location = New System.Drawing.Point(567, 118)
        Me.cb_TypeCat.Name = "cb_TypeCat"
        Me.cb_TypeCat.Size = New System.Drawing.Size(77, 21)
        Me.cb_TypeCat.TabIndex = 28
        '
        'cb_DateCat
        '
        Me.cb_DateCat.Enabled = False
        Me.cb_DateCat.FormattingEnabled = True
        Me.cb_DateCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_DateCat.Location = New System.Drawing.Point(567, 61)
        Me.cb_DateCat.Name = "cb_DateCat"
        Me.cb_DateCat.Size = New System.Drawing.Size(77, 21)
        Me.cb_DateCat.TabIndex = 30
        '
        'cb_barCar
        '
        Me.cb_barCar.Enabled = False
        Me.cb_barCar.FormattingEnabled = True
        Me.cb_barCar.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_barCar.Location = New System.Drawing.Point(567, 33)
        Me.cb_barCar.Name = "cb_barCar"
        Me.cb_barCar.Size = New System.Drawing.Size(77, 21)
        Me.cb_barCar.TabIndex = 27
        '
        'chkUser
        '
        Me.chkUser.AutoSize = True
        Me.chkUser.Location = New System.Drawing.Point(12, 148)
        Me.chkUser.Name = "chkUser"
        Me.chkUser.Size = New System.Drawing.Size(48, 17)
        Me.chkUser.TabIndex = 26
        Me.chkUser.Text = "User"
        Me.chkUser.UseVisualStyleBackColor = True
        '
        'chkLocation
        '
        Me.chkLocation.AutoSize = True
        Me.chkLocation.Location = New System.Drawing.Point(12, 96)
        Me.chkLocation.Name = "chkLocation"
        Me.chkLocation.Size = New System.Drawing.Size(92, 17)
        Me.chkLocation.TabIndex = 23
        Me.chkLocation.Text = "Coll Collection"
        Me.chkLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(329, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TO"
        '
        'chkSampleType
        '
        Me.chkSampleType.AutoSize = True
        Me.chkSampleType.Location = New System.Drawing.Point(12, 123)
        Me.chkSampleType.Name = "chkSampleType"
        Me.chkSampleType.Size = New System.Drawing.Size(88, 17)
        Me.chkSampleType.TabIndex = 22
        Me.chkSampleType.Text = "Sample Type"
        Me.chkSampleType.UseVisualStyleBackColor = True
        '
        'chk_dates
        '
        Me.chk_dates.AutoSize = True
        Me.chk_dates.Location = New System.Drawing.Point(12, 66)
        Me.chk_dates.Name = "chk_dates"
        Me.chk_dates.Size = New System.Drawing.Size(121, 17)
        Me.chk_dates.TabIndex = 24
        Me.chk_dates.Text = "Entry Date Between"
        Me.chk_dates.UseVisualStyleBackColor = True
        '
        'chk_barcode
        '
        Me.chk_barcode.AutoSize = True
        Me.chk_barcode.Location = New System.Drawing.Point(12, 38)
        Me.chk_barcode.Name = "chk_barcode"
        Me.chk_barcode.Size = New System.Drawing.Size(66, 17)
        Me.chk_barcode.TabIndex = 21
        Me.chk_barcode.Text = "Barcode"
        Me.chk_barcode.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(357, 145)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(175, 20)
        Me.txtUser.TabIndex = 20
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Location = New System.Drawing.Point(357, 33)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(175, 20)
        Me.txtBarcode.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Search Criteria"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(367, 61)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(148, 20)
        Me.dtpEndDate.TabIndex = 16
        '
        'dtspStartDAte
        '
        Me.dtspStartDAte.CustomFormat = "MM/dd/yyyy"
        Me.dtspStartDAte.Enabled = False
        Me.dtspStartDAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtspStartDAte.Location = New System.Drawing.Point(148, 62)
        Me.dtspStartDAte.Name = "dtspStartDAte"
        Me.dtspStartDAte.Size = New System.Drawing.Size(138, 20)
        Me.dtspStartDAte.TabIndex = 17
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Location = New System.Drawing.Point(12, 246)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(924, 232)
        Me.dgvRecords.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.Results)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 54)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Include the following"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(359, 20)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Aliquots remaining"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(218, 19)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Archiving"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Results
        '
        Me.Results.AutoSize = True
        Me.Results.Location = New System.Drawing.Point(121, 19)
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(61, 17)
        Me.Results.TabIndex = 1
        Me.Results.Text = "Results"
        Me.Results.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(16, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "SampleDetails"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Test, Me.tsm_Archive, Me.tsm_aliq})
        Me.ctxMenu.Name = "ContextMenuStrip1"
        Me.ctxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ctxMenu.Size = New System.Drawing.Size(138, 70)
        '
        'tsm_Test
        '
        Me.tsm_Test.DoubleClickEnabled = True
        Me.tsm_Test.Name = "tsm_Test"
        Me.tsm_Test.Size = New System.Drawing.Size(137, 22)
        Me.tsm_Test.Text = "Test Sample"
        '
        'tsm_Archive
        '
        Me.tsm_Archive.Name = "tsm_Archive"
        Me.tsm_Archive.Size = New System.Drawing.Size(137, 22)
        Me.tsm_Archive.Text = "Archive"
        '
        'tsm_aliq
        '
        Me.tsm_aliq.Name = "tsm_aliq"
        Me.tsm_aliq.Size = New System.Drawing.Size(137, 22)
        Me.tsm_aliq.Text = "Aliquot"
        '
        'frmResultsQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbUser)
        Me.Controls.Add(Me.cb_Locaca)
        Me.Controls.Add(Me.cb_typeD)
        Me.Controls.Add(Me.cb_location)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.cb_locCat)
        Me.Controls.Add(Me.cbBarcode)
        Me.Controls.Add(Me.cb_TypeCat)
        Me.Controls.Add(Me.cb_DateCat)
        Me.Controls.Add(Me.cb_barCar)
        Me.Controls.Add(Me.chkUser)
        Me.Controls.Add(Me.chkLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkSampleType)
        Me.Controls.Add(Me.chk_dates)
        Me.Controls.Add(Me.chk_barcode)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtspStartDAte)
        Me.Controls.Add(Me.dgvRecords)
        Me.Name = "frmResultsQC"
        Me.Text = "frmSearch"
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents dtspStartDAte As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents chk_barcode As CheckBox
    Friend WithEvents chk_dates As CheckBox
    Friend WithEvents chkSampleType As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkLocation As CheckBox
    Friend WithEvents chkUser As CheckBox
    Friend WithEvents cb_barCar As ComboBox
    Friend WithEvents cb_DateCat As ComboBox
    Friend WithEvents cb_TypeCat As ComboBox
    Friend WithEvents cbBarcode As ComboBox
    Friend WithEvents cb_locCat As ComboBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cb_location As ComboBox
    Friend WithEvents cb_typeD As ComboBox
    Friend WithEvents cb_Locaca As ComboBox
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Results As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents tsm_Test As ToolStripMenuItem
    Friend WithEvents tsm_Archive As ToolStripMenuItem
    Friend WithEvents tsm_aliq As ToolStripMenuItem
End Class
