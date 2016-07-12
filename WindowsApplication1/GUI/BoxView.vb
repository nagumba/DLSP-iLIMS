Imports System.Data.SqlClient

Public Class BoxView

    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Public f As Button
    'Public Sub BuildTree(ByVal dt As DataTable, ByVal trv As TreeView, ByVal expandAll As [Boolean])
    '    ' Clear the TreeView if there are another datas in this TreeView
    '    trv.Nodes.Clear()
    '    Dim node As TreeNode
    '    Dim subNode As TreeNode
    '    For Each row As DataRow In dt.Rows
    '        'search in the treeview if any country is already present
    '        node = Searchnode(row.Item(0).ToString(), trv)
    '        If node IsNot Nothing Then
    '            'Country is already present
    '            subNode = New TreeNode(row.Item(1).ToString())
    '            'Add cities to country
    '            node.Nodes.Add(subNode)
    '        Else
    '            node = New TreeNode(row.Item(0).ToString())
    '            subNode = New TreeNode(row.Item(1).ToString())
    '            'Add cities to country
    '            node.Nodes.Add(subNode)
    '            trv.Nodes.Add(node)
    '        End If
    '    Next
    '    If expandAll Then
    '        ' Expand the TreeView
    '        trv.ExpandAll()
    '    End If
    'End Sub


    'Private Function Searchnode(ByVal nodetext As String, ByVal trv As TreeView) As TreeNode
    '    For Each node As TreeNode In trv.Nodes
    '        If node.Text = nodetext Then
    '            Return node
    '        End If
    '    Next
    'End Function

    'Public Function CreateDataTable() As DataTable
    '    Dim dataTable As New DataTable()
    '    dataTable.Columns.Add("Country")
    '    ' The value in this column will display on the TreeNode
    '    dataTable.Columns.Add("City")
    '    ' The value in this column will identify its parentId

    '    ' Fill the DataTable
    '    dataTable.Rows.Add("India", "New Delhi")
    '    dataTable.Rows.Add("India", "Mumbai")
    '    dataTable.Rows.Add("India", "Kolkata")
    '    dataTable.Rows.Add("India", "Noida")
    '    dataTable.Rows.Add("USA", "New York")
    '    dataTable.Rows.Add("USA", "Washington")
    '    dataTable.Rows.Add("USA", "")
    '    dataTable.Rows.Add("USA", "India")
    '    Return dataTable
    'End Function

    'Private Sub BoxView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    '    Searchnode() As TreeNode
    '    Dim barcode As Integer = 99999999
    '    Dim sam As String = "NPOP"
    '    Dim position As Integer = 1
    '    BuildTree(CreateDataTable, TreeView1, True)
    '    btn1.Text = barcode & vbCrLf & sam & vbCrLf & position

    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    'End Sub

    'Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    '    Dim pos1, pos2, pos3 As String

    '    ' pos1 = 

    'End Sub
    'Private Sub treeview()
    '    Dim sql As String = "Select lastname + ', ' + firstname as Name, lastname from Employees order by Lastname"
    '    Dim rdr As SqlDataReader
    '    Dim cnn As SqlConnection = New SqlConnection(db)
    '    Dim cmd As SqlCommand = New SqlCommand(sql, cnn)
    '    'open connection
    '    Try
    '        rdr = cmd.ExecuteReader()
    '        'Add Alphabet letter to each node of Treeview
    '        Dim I As Integer
    '        Dim node_letter As String
    '        'Set the Document Type
    '        tv1.Nodes.Add("Contacts")
    '        'Set the Documents
    '        tv1.SelectedNode = tv1.Nodes.Item(0)
    '        tv1.ExpandAll()
    '        tv1.ShowLines = True
    '        tv1.ShowPlusMinus = True

    '        For I = 1 To 26
    '            node_letter = Chr(64 + I)
    '            tv1.SelectedNode.Nodes.Add(node_letter)
    '        Next I



    '        '  Add database records to appropriate Alphabet Node

    '        Dim node_key As String
    '        Dim entry_letter As String
    '        Dim node_name As String
    '        Do While rdr.Read
    '            node_key = rdr.GetString(0)
    '            entry_letter = node_key.Substring(0, 1)
    '            Dim myNode As TreeNode
    '            I = 0
    '            node_name = rdr.GetString(0)
    '            For Each myNode In tv1.Nodes.Item(0).Nodes
    '                If myNode.Text = entry_letter Then
    '                    tv1.Nodes.Item(0).Nodes.Item(myNode.Index).Nodes.Add(node_name)
    '                    Exit For
    '                End If
    '            Next
    '        Loop

    '    Catch ex As Exception
    '        MsgBox("Failed to load" & vbCrLf & ex.Message)
    '    Finally
    '        cnn.Close()
    '    End Try



    '    tv1.Nodes(0).Expand()
    'End Sub

    Private Sub BoxView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateBoxes()
    End Sub


    Private Sub GenerateBoxes()

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


End Class