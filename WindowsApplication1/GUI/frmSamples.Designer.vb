﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSamples
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cb = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst_symptoms = New System.Windows.Forms.CheckedListBox()
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpColldate = New System.Windows.Forms.DateTimePicker()
        Me.cb_study = New System.Windows.Forms.ComboBox()
        Me.cb_Group = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBactec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Location = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_SampleType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBactec = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_Demo = New System.Windows.Forms.CheckBox()
        Me.grpEnterics = New System.Windows.Forms.GroupBox()
        Me.cb_sufficient = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_appearance = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpDemo = New System.Windows.Forms.GroupBox()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nud_P_Age = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdentifier2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dgvSamples = New System.Windows.Forms.DataGridView()
        Me.tc_ReceiveSamples = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpEnterics.SuspendLayout()
        Me.grpDemo.SuspendLayout()
        CType(Me.nud_P_Age, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_ReceiveSamples.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.cb)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.chk_Demo)
        Me.TabPage1.Controls.Add(Me.grpEnterics)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.grpDemo)
        Me.TabPage1.Controls.Add(Me.dgvSamples)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1054, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(756, 512)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 71
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cb
        '
        Me.cb.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb.FormattingEnabled = True
        Me.cb.Items.AddRange(New Object() {"Null", "Accepted", "Rejected"})
        Me.cb.Location = New System.Drawing.Point(486, 22)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(121, 23)
        Me.cb.TabIndex = 62
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lst_symptoms)
        Me.GroupBox3.Controls.Add(Me.dtpReceiveDate)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpColldate)
        Me.GroupBox3.Controls.Add(Me.cb_study)
        Me.GroupBox3.Controls.Add(Me.cb_Group)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 304)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Collection Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Study"
        '
        'lst_symptoms
        '
        Me.lst_symptoms.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_symptoms.FormattingEnabled = True
        Me.lst_symptoms.Location = New System.Drawing.Point(7, 166)
        Me.lst_symptoms.Name = "lst_symptoms"
        Me.lst_symptoms.Size = New System.Drawing.Size(338, 123)
        Me.lst_symptoms.TabIndex = 58
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpReceiveDate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReceiveDate.Location = New System.Drawing.Point(99, 127)
        Me.dtpReceiveDate.MaxDate = New Date(2016, 6, 13, 0, 0, 0, 0)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.Size = New System.Drawing.Size(102, 22)
        Me.dtpReceiveDate.TabIndex = 57
        Me.dtpReceiveDate.Value = New Date(2016, 6, 13, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 16)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Received Date"
        '
        'dtpColldate
        '
        Me.dtpColldate.CustomFormat = "MM/dd/yyyy"
        Me.dtpColldate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpColldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpColldate.Location = New System.Drawing.Point(102, 93)
        Me.dtpColldate.Name = "dtpColldate"
        Me.dtpColldate.Size = New System.Drawing.Size(99, 22)
        Me.dtpColldate.TabIndex = 56
        '
        'cb_study
        '
        Me.cb_study.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_study.FormattingEnabled = True
        Me.cb_study.Location = New System.Drawing.Point(52, 63)
        Me.cb_study.Name = "cb_study"
        Me.cb_study.Size = New System.Drawing.Size(282, 24)
        Me.cb_study.TabIndex = 50
        '
        'cb_Group
        '
        Me.cb_Group.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Group.FormattingEnabled = True
        Me.cb_Group.Location = New System.Drawing.Point(52, 16)
        Me.cb_Group.Name = "cb_Group"
        Me.cb_Group.Size = New System.Drawing.Size(282, 24)
        Me.cb_Group.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 16)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Group"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBactec)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cb_Location)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cb_SampleType)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtBactec)
        Me.GroupBox2.Controls.Add(Me.txtBarcode)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 138)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'lblBactec
        '
        Me.lblBactec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBactec.AutoSize = True
        Me.lblBactec.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBactec.Location = New System.Drawing.Point(4, 102)
        Me.lblBactec.Name = "lblBactec"
        Me.lblBactec.Size = New System.Drawing.Size(82, 16)
        Me.lblBactec.TabIndex = 55
        Me.lblBactec.Text = "Bactec Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "SpecimenID"
        '
        'cb_Location
        '
        Me.cb_Location.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Location.FormattingEnabled = True
        Me.cb_Location.Location = New System.Drawing.Point(104, 38)
        Me.cb_Location.Name = "cb_Location"
        Me.cb_Location.Size = New System.Drawing.Size(221, 24)
        Me.cb_Location.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Location"
        '
        'cb_SampleType
        '
        Me.cb_SampleType.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_SampleType.FormattingEnabled = True
        Me.cb_SampleType.Location = New System.Drawing.Point(103, 68)
        Me.cb_SampleType.Name = "cb_SampleType"
        Me.cb_SampleType.Size = New System.Drawing.Size(222, 24)
        Me.cb_SampleType.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "SampleType"
        '
        'txtBactec
        '
        Me.txtBactec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBactec.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBactec.Location = New System.Drawing.Point(103, 98)
        Me.txtBactec.Name = "txtBactec"
        Me.txtBactec.Size = New System.Drawing.Size(222, 22)
        Me.txtBactec.TabIndex = 54
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(104, 11)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(221, 22)
        Me.txtBarcode.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(397, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Sample Status"
        '
        'chk_Demo
        '
        Me.chk_Demo.AutoSize = True
        Me.chk_Demo.Location = New System.Drawing.Point(400, 62)
        Me.chk_Demo.Name = "chk_Demo"
        Me.chk_Demo.Size = New System.Drawing.Size(94, 17)
        Me.chk_Demo.TabIndex = 68
        Me.chk_Demo.Text = "Demographics"
        Me.chk_Demo.UseVisualStyleBackColor = True
        '
        'grpEnterics
        '
        Me.grpEnterics.Controls.Add(Me.cb_sufficient)
        Me.grpEnterics.Controls.Add(Me.Label5)
        Me.grpEnterics.Controls.Add(Me.cb_appearance)
        Me.grpEnterics.Controls.Add(Me.Label10)
        Me.grpEnterics.Location = New System.Drawing.Point(7, 148)
        Me.grpEnterics.Name = "grpEnterics"
        Me.grpEnterics.Size = New System.Drawing.Size(348, 77)
        Me.grpEnterics.TabIndex = 67
        Me.grpEnterics.TabStop = False
        '
        'cb_sufficient
        '
        Me.cb_sufficient.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_sufficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sufficient.FormattingEnabled = True
        Me.cb_sufficient.Location = New System.Drawing.Point(103, 44)
        Me.cb_sufficient.Name = "cb_sufficient"
        Me.cb_sufficient.Size = New System.Drawing.Size(98, 24)
        Me.cb_sufficient.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Sufficient"
        '
        'cb_appearance
        '
        Me.cb_appearance.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_appearance.FormattingEnabled = True
        Me.cb_appearance.Location = New System.Drawing.Point(103, 17)
        Me.cb_appearance.Name = "cb_appearance"
        Me.cb_appearance.Size = New System.Drawing.Size(97, 24)
        Me.cb_appearance.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Appearance"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(674, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(583, 512)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpDemo
        '
        Me.grpDemo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDemo.Controls.Add(Me.cb_gender)
        Me.grpDemo.Controls.Add(Me.Label2)
        Me.grpDemo.Controls.Add(Me.nud_P_Age)
        Me.grpDemo.Controls.Add(Me.Label8)
        Me.grpDemo.Controls.Add(Me.txtIdentifier2)
        Me.grpDemo.Controls.Add(Me.Label7)
        Me.grpDemo.Controls.Add(Me.Label6)
        Me.grpDemo.Controls.Add(Me.txtName)
        Me.grpDemo.Enabled = False
        Me.grpDemo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDemo.Location = New System.Drawing.Point(400, 85)
        Me.grpDemo.Name = "grpDemo"
        Me.grpDemo.Size = New System.Drawing.Size(621, 111)
        Me.grpDemo.TabIndex = 34
        Me.grpDemo.TabStop = False
        Me.grpDemo.Text = "Sample Demographics"
        '
        'cb_gender
        '
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cb_gender.Location = New System.Drawing.Point(274, 76)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(107, 24)
        Me.cb_gender.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Gender"
        '
        'nud_P_Age
        '
        Me.nud_P_Age.Location = New System.Drawing.Point(135, 76)
        Me.nud_P_Age.Name = "nud_P_Age"
        Me.nud_P_Age.Size = New System.Drawing.Size(55, 22)
        Me.nud_P_Age.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Age"
        '
        'txtIdentifier2
        '
        Me.txtIdentifier2.Location = New System.Drawing.Point(135, 48)
        Me.txtIdentifier2.Name = "txtIdentifier2"
        Me.txtIdentifier2.Size = New System.Drawing.Size(186, 22)
        Me.txtIdentifier2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Identifier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Participants Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 22)
        Me.txtName.TabIndex = 0
        '
        'dgvSamples
        '
        Me.dgvSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSamples.Location = New System.Drawing.Point(400, 240)
        Me.dgvSamples.Name = "dgvSamples"
        Me.dgvSamples.Size = New System.Drawing.Size(630, 251)
        Me.dgvSamples.TabIndex = 37
        '
        'tc_ReceiveSamples
        '
        Me.tc_ReceiveSamples.Controls.Add(Me.TabPage1)
        Me.tc_ReceiveSamples.Location = New System.Drawing.Point(12, 8)
        Me.tc_ReceiveSamples.Name = "tc_ReceiveSamples"
        Me.tc_ReceiveSamples.SelectedIndex = 0
        Me.tc_ReceiveSamples.Size = New System.Drawing.Size(1062, 590)
        Me.tc_ReceiveSamples.TabIndex = 67
        '
        'frmSamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.tc_ReceiveSamples)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSamples"
        Me.Text = "Receive Samples"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpEnterics.ResumeLayout(False)
        Me.grpEnterics.PerformLayout()
        Me.grpDemo.ResumeLayout(False)
        Me.grpDemo.PerformLayout()
        CType(Me.nud_P_Age, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_ReceiveSamples.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_ReceiveSamples As TabControl
    Friend WithEvents dgvSamples As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdentifier2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nud_P_Age As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_gender As ComboBox
    Friend WithEvents grpDemo As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_appearance As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_sufficient As ComboBox
    Friend WithEvents grpEnterics As GroupBox
    Friend WithEvents chk_Demo As CheckBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cb_SampleType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cb_Location As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cb_Group As ComboBox
    Friend WithEvents dtpColldate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpReceiveDate As DateTimePicker
    Friend WithEvents lst_symptoms As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cb As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtBactec As TextBox
    Friend WithEvents lblBactec As Label
    Friend WithEvents cb_study As ComboBox
    Friend WithEvents Button4 As Button
End Class
