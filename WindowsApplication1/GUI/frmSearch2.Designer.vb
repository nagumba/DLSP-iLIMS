<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Results = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbResult = New System.Windows.Forms.ComboBox()
        Me.cb_typeD = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbBarcode = New System.Windows.Forms.ComboBox()
        Me.cb_TypeCat = New System.Windows.Forms.ComboBox()
        Me.cb_DateCat = New System.Windows.Forms.ComboBox()
        Me.cb_barCar = New System.Windows.Forms.ComboBox()
        Me.chkResult = New System.Windows.Forms.CheckBox()
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
        Me.cb_locCat = New System.Windows.Forms.ComboBox()
        Me.cb_Locaca = New System.Windows.Forms.ComboBox()
        Me.cb_location = New System.Windows.Forms.ComboBox()
        Me.chkLocation = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.Results)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(34, 17)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Include the following"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(359, 17)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Aliquots remaining"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(218, 16)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Archiving"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Results
        '
        Me.Results.AutoSize = True
        Me.Results.Location = New System.Drawing.Point(121, 16)
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
        Me.CheckBox1.Location = New System.Drawing.Point(16, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "SampleDetails"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(682, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Export Results to Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ilims.My.Resources.Resources.search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(714, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbResult
        '
        Me.cbResult.Enabled = False
        Me.cbResult.FormattingEnabled = True
        Me.cbResult.Items.AddRange(New Object() {"", "Culture", "PCR", "Elisa", "Binax", "Bactec", "Gramstain"})
        Me.cbResult.Location = New System.Drawing.Point(138, 139)
        Me.cbResult.Name = "cbResult"
        Me.cbResult.Size = New System.Drawing.Size(195, 21)
        Me.cbResult.TabIndex = 61
        '
        'cb_typeD
        '
        Me.cb_typeD.Enabled = False
        Me.cb_typeD.FormattingEnabled = True
        Me.cb_typeD.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_typeD.Location = New System.Drawing.Point(359, 112)
        Me.cb_typeD.Name = "cb_typeD"
        Me.cb_typeD.Size = New System.Drawing.Size(195, 21)
        Me.cb_typeD.TabIndex = 59
        '
        'cbType
        '
        Me.cbType.Enabled = False
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cbType.Location = New System.Drawing.Point(138, 112)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(195, 21)
        Me.cbType.TabIndex = 57
        '
        'cbBarcode
        '
        Me.cbBarcode.Enabled = False
        Me.cbBarcode.FormattingEnabled = True
        Me.cbBarcode.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cbBarcode.Location = New System.Drawing.Point(138, 27)
        Me.cbBarcode.Name = "cbBarcode"
        Me.cbBarcode.Size = New System.Drawing.Size(195, 21)
        Me.cbBarcode.TabIndex = 56
        '
        'cb_TypeCat
        '
        Me.cb_TypeCat.Enabled = False
        Me.cb_TypeCat.FormattingEnabled = True
        Me.cb_TypeCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_TypeCat.Location = New System.Drawing.Point(569, 113)
        Me.cb_TypeCat.Name = "cb_TypeCat"
        Me.cb_TypeCat.Size = New System.Drawing.Size(97, 21)
        Me.cb_TypeCat.TabIndex = 53
        '
        'cb_DateCat
        '
        Me.cb_DateCat.Enabled = False
        Me.cb_DateCat.FormattingEnabled = True
        Me.cb_DateCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_DateCat.Location = New System.Drawing.Point(569, 56)
        Me.cb_DateCat.Name = "cb_DateCat"
        Me.cb_DateCat.Size = New System.Drawing.Size(97, 21)
        Me.cb_DateCat.TabIndex = 55
        '
        'cb_barCar
        '
        Me.cb_barCar.Enabled = False
        Me.cb_barCar.FormattingEnabled = True
        Me.cb_barCar.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_barCar.Location = New System.Drawing.Point(569, 28)
        Me.cb_barCar.Name = "cb_barCar"
        Me.cb_barCar.Size = New System.Drawing.Size(97, 21)
        Me.cb_barCar.TabIndex = 52
        '
        'chkResult
        '
        Me.chkResult.AutoSize = True
        Me.chkResult.Location = New System.Drawing.Point(14, 143)
        Me.chkResult.Name = "chkResult"
        Me.chkResult.Size = New System.Drawing.Size(56, 17)
        Me.chkResult.TabIndex = 51
        Me.chkResult.Text = "Result"
        Me.chkResult.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(331, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "TO"
        '
        'chkSampleType
        '
        Me.chkSampleType.AutoSize = True
        Me.chkSampleType.Location = New System.Drawing.Point(14, 118)
        Me.chkSampleType.Name = "chkSampleType"
        Me.chkSampleType.Size = New System.Drawing.Size(88, 17)
        Me.chkSampleType.TabIndex = 47
        Me.chkSampleType.Text = "Sample Type"
        Me.chkSampleType.UseVisualStyleBackColor = True
        '
        'chk_dates
        '
        Me.chk_dates.AutoSize = True
        Me.chk_dates.Location = New System.Drawing.Point(14, 61)
        Me.chk_dates.Name = "chk_dates"
        Me.chk_dates.Size = New System.Drawing.Size(121, 17)
        Me.chk_dates.TabIndex = 49
        Me.chk_dates.Text = "Entry Date Between"
        Me.chk_dates.UseVisualStyleBackColor = True
        '
        'chk_barcode
        '
        Me.chk_barcode.AutoSize = True
        Me.chk_barcode.Location = New System.Drawing.Point(14, 33)
        Me.chk_barcode.Name = "chk_barcode"
        Me.chk_barcode.Size = New System.Drawing.Size(66, 17)
        Me.chk_barcode.TabIndex = 46
        Me.chk_barcode.Text = "Barcode"
        Me.chk_barcode.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(359, 140)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(195, 20)
        Me.txtUser.TabIndex = 45
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Location = New System.Drawing.Point(359, 28)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(195, 20)
        Me.txtBarcode.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Search Criteria"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(359, 57)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(205, 20)
        Me.dtpEndDate.TabIndex = 41
        '
        'dtspStartDAte
        '
        Me.dtspStartDAte.Enabled = False
        Me.dtspStartDAte.Location = New System.Drawing.Point(138, 57)
        Me.dtspStartDAte.Name = "dtspStartDAte"
        Me.dtspStartDAte.Size = New System.Drawing.Size(195, 20)
        Me.dtspStartDAte.TabIndex = 42
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Location = New System.Drawing.Point(14, 226)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.Size = New System.Drawing.Size(829, 292)
        Me.dgvRecords.TabIndex = 40
        '
        'cb_locCat
        '
        Me.cb_locCat.Enabled = False
        Me.cb_locCat.FormattingEnabled = True
        Me.cb_locCat.Items.AddRange(New Object() {"AND", "OR"})
        Me.cb_locCat.Location = New System.Drawing.Point(569, 86)
        Me.cb_locCat.Name = "cb_locCat"
        Me.cb_locCat.Size = New System.Drawing.Size(97, 21)
        Me.cb_locCat.TabIndex = 54
        '
        'cb_Locaca
        '
        Me.cb_Locaca.Enabled = False
        Me.cb_Locaca.FormattingEnabled = True
        Me.cb_Locaca.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_Locaca.Location = New System.Drawing.Point(359, 85)
        Me.cb_Locaca.Name = "cb_Locaca"
        Me.cb_Locaca.Size = New System.Drawing.Size(195, 21)
        Me.cb_Locaca.TabIndex = 60
        '
        'cb_location
        '
        Me.cb_location.Enabled = False
        Me.cb_location.FormattingEnabled = True
        Me.cb_location.Items.AddRange(New Object() {"CONTAINS", "=", "STARTS WITH", "END WITH"})
        Me.cb_location.Location = New System.Drawing.Point(138, 85)
        Me.cb_location.Name = "cb_location"
        Me.cb_location.Size = New System.Drawing.Size(195, 21)
        Me.cb_location.TabIndex = 58
        '
        'chkLocation
        '
        Me.chkLocation.AutoSize = True
        Me.chkLocation.Location = New System.Drawing.Point(14, 91)
        Me.chkLocation.Name = "chkLocation"
        Me.chkLocation.Size = New System.Drawing.Size(55, 17)
        Me.chkLocation.TabIndex = 48
        Me.chkLocation.Text = "Group"
        Me.chkLocation.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(595, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "Approve"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(689, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 23)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "Reject"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(321, 197)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 67
        '
        'Button5
        '
        Me.Button5.Image = Global.ilims.My.Resources.Resources.close
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(724, 91)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 68
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmSearch2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 592)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbResult)
        Me.Controls.Add(Me.cb_Locaca)
        Me.Controls.Add(Me.cb_typeD)
        Me.Controls.Add(Me.cb_location)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.cb_locCat)
        Me.Controls.Add(Me.cbBarcode)
        Me.Controls.Add(Me.cb_TypeCat)
        Me.Controls.Add(Me.cb_DateCat)
        Me.Controls.Add(Me.cb_barCar)
        Me.Controls.Add(Me.chkResult)
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
        Me.Name = "frmSearch2"
        Me.Text = "frmSearch2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Results As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbResult As ComboBox
    Friend WithEvents cb_typeD As ComboBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents cbBarcode As ComboBox
    Friend WithEvents cb_TypeCat As ComboBox
    Friend WithEvents cb_DateCat As ComboBox
    Friend WithEvents cb_barCar As ComboBox
    Friend WithEvents chkResult As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkSampleType As CheckBox
    Friend WithEvents chk_dates As CheckBox
    Friend WithEvents chk_barcode As CheckBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtspStartDAte As DateTimePicker
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents cb_locCat As ComboBox
    Friend WithEvents cb_Locaca As ComboBox
    Friend WithEvents cb_location As ComboBox
    Friend WithEvents chkLocation As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
