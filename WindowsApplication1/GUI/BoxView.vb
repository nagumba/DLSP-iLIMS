Public Class BoxView

    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Public Sub BuildTree(ByVal dt As DataTable, ByVal trv As TreeView, ByVal expandAll As [Boolean])
        ' Clear the TreeView if there are another datas in this TreeView
        trv.Nodes.Clear()
        Dim node As TreeNode
        Dim subNode As TreeNode
        For Each row As DataRow In dt.Rows
            'search in the treeview if any country is already present
            node = Searchnode(row.Item(0).ToString(), trv)
            If node IsNot Nothing Then
                'Country is already present
                subNode = New TreeNode(row.Item(1).ToString())
                'Add cities to country
                node.Nodes.Add(subNode)
            Else
                node = New TreeNode(row.Item(0).ToString())
                subNode = New TreeNode(row.Item(1).ToString())
                'Add cities to country
                node.Nodes.Add(subNode)
                trv.Nodes.Add(node)
            End If
        Next
        If expandAll Then
            ' Expand the TreeView
            trv.ExpandAll()
        End If
    End Sub


    Private Function Searchnode(ByVal nodetext As String, ByVal trv As TreeView) As TreeNode
        For Each node As TreeNode In trv.Nodes
            If node.Text = nodetext Then
                Return node
            End If
        Next
    End Function

    Public Function CreateDataTable() As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Country")
        ' The value in this column will display on the TreeNode
        dataTable.Columns.Add("City")
        ' The value in this column will identify its parentId

        ' Fill the DataTable
        dataTable.Rows.Add("India", "New Delhi")
        dataTable.Rows.Add("India", "Mumbai")
        dataTable.Rows.Add("India", "Kolkata")
        dataTable.Rows.Add("India", "Noida")
        dataTable.Rows.Add("USA", "New York")
        dataTable.Rows.Add("USA", "Washington")
        dataTable.Rows.Add("USA", "")
        dataTable.Rows.Add("USA", "India")
        Return dataTable
    End Function

    Private Sub BoxView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Searchnode() As TreeNode
        Dim barcode As Integer = 99999999
        Dim sam As String = "NPOP"
        Dim position As Integer = 1
        BuildTree(CreateDataTable, TreeView1, True)
        btn1.Text = barcode & vbCrLf & sam & vbCrLf & position

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim pos1, pos2, pos3 As String

        ' pos1 = 

    End Sub
End Class