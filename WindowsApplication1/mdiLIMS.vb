Imports System.Windows.Forms

Public Class mdiLIMS
    Dim db As New iLabDataContext
    Public f As Button
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Cuser = "Noel Agumba"
        tssUser.Text = Cuser


    End Sub
    Private Sub Dynamyc()
        MsgBox(f.Name)
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        Dim frm As New frmmanagepassword
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AddFreezersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFreezersToolStripMenuItem.Click

        Dim frm As New frmFreezers
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub AddSampleTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSampleTypesToolStripMenuItem.Click

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUsersToolStripMenuItem.Click

        Dim frm As New frmUsers
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ManageGroupsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageGroupsToolStripMenuItem.Click

        Dim frm As New frmGroups
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ReceiveSamplesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveSamplesToolStripMenuItem.Click

    End Sub

    Private Sub TestingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestingToolStripMenuItem.Click
        Dim frm As New frmResults
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ArchivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivingToolStripMenuItem.Click
        'Dim frm As New frmArchiving
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub AliquotingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AliquotingToolStripMenuItem.Click
        Dim frm As New frmAliquoting
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ReceipientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceipientToolStripMenuItem.Click
        'Dim frm As New frmShipped
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub SenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenderToolStripMenuItem.Click
        Dim frm As New frmShipping
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mdiLims_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        Exit Sub
    End Sub

    Private Sub mdiLims_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Exit Sub
    End Sub

    Private Sub SearchRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecordToolStripMenuItem.Click
        Dim frm As New frmResultsQC
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frm As New frmLocations
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FieldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldToolStripMenuItem.Click
        Dim frm As New frmSamples
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ShippedSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShippedSamplesToolStripMenuItem.Click
        Dim frm As New frmShipping
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub GenerateBoxes(frm As BoxView)

        Dim TableLayoutPanel As New TableLayoutPanel
        TableLayoutPanel = TableLayoutPanel1
        TableLayoutPanel.Name = "boxes"
        TableLayoutPanel.Visible = False
        Dim i As Integer
        Dim l As Integer = 0
        Dim abarcode As String = "Barcode"
        Dim aUniqueID As String = "UniqueID"
        Dim SAMTYPE As String = "Type"
        For i = 0 To 80
            TableLayoutPanel.Controls.Add(New Button)
        Next
        For Each f In TableLayoutPanel.Controls
            f.BackColor = Color.LightBlue
            l += 1
            f.Text = l.ToString() & vbCrLf & abarcode & vbCrLf & aUniqueID & vbCrLf & SAMTYPE
            f.Name = "Pos" & l.ToString
            AddHandler f.Click, AddressOf clickMe
            f.AutoSize = True
        Next
        TableLayoutPanel.Top = 0
        TableLayoutPanel.Left = 0

        TableLayoutPanel.Visible = True
    End Sub
    Private Sub clickMe(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button
        btn = CType(sender, Button)
        Dim str As String = btn.Text
        MessageBox.Show(str)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim f As Form
        f = New frmSearch2
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to exit elab?", vbYesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub QCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QCToolStripMenuItem.Click
        Dim frm As New frmSearch2
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class


