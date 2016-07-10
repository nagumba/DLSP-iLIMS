<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocations
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
        Me.dvgLocations8 = New System.Windows.Forms.DataGridView()
        CType(Me.dvgLocations8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgLocations8
        '
        Me.dvgLocations8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLocations8.Location = New System.Drawing.Point(2, 3)
        Me.dvgLocations8.Name = "dvgLocations8"
        Me.dvgLocations8.Size = New System.Drawing.Size(1144, 221)
        Me.dvgLocations8.TabIndex = 0
        '
        'frmLocations
        '
        Me.ClientSize = New System.Drawing.Size(1303, 685)
        Me.Controls.Add(Me.dvgLocations8)
        Me.Name = "frmLocations"
        CType(Me.dvgLocations8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_county As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Province As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_Country As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents dvgLocations As DataGridView
    Friend WithEvents ELabDataSetBindingSource As BindingSource
    Friend WithEvents ELabDataSet As eLabDataSet
    Friend WithEvents dvgLocations8 As DataGridView
End Class
