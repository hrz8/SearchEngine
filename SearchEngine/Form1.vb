Option Strict On
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Threading
Imports FastDirectory

Public Class Form1
    Private programPath As String
    Private total As Integer
    Private dir As DirectoryInfo
    Private t As New Thread(AddressOf ThreadQ)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        StopButton.Enabled = False

        '------interface
        cardseditcust.Visible = False
        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
        cardseditcust.Visible = False
        cardsproject.Visible = False
        cardstype.Visible = False
        cardsextension.Visible = False
        'FolderName.Text = "\\wsl$\Ubuntu-18.04\home\hirzi\repos\eji"
        programPath = My.Application.Info.DirectoryPath
        For Each d As String In File.ReadAllLines(programPath & "\customers.txt")
            CustomerName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\projects.txt")
            ProjectName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\types.txt")
            TypeName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\extensions.txt")
            FileExtension.AddItem(d)
        Next
        'txt Data
        CustomerDataRTB.Text = File.ReadAllText(programPath & "\customers.txt")
        ProjectDataRTB.Text = File.ReadAllText(programPath & "\projects.txt")
        DocTypeDataRTB.Text = File.ReadAllText(programPath & "\types.txt")
        ExtensionDataRTB.Text = File.ReadAllText(programPath & "\extensions.txt")
        'init data grid
        Dim fileName As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        fileName.DataPropertyName = "File Name"
        fileName.Name = "File Name"
        DataGridView1.Columns.Add(fileName)
        Dim loc As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        loc.DataPropertyName = "Location"
        loc.Name = "Location"
        DataGridView1.Columns.Add(loc)
        Dim crt As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        crt.DataPropertyName = "Created At"
        crt.Name = "Created At"
        DataGridView1.Columns.Add(crt)
        Dim upd As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        upd.DataPropertyName = "Updated At"
        upd.Name = "Updated At"
        DataGridView1.Columns.Add(upd)
    End Sub

    Private Sub GetTheFiles(dirIn As DirectoryInfo)
        Dim varFileExt As String = If(FileExtension.selectedIndex = -1, "*", FileExtension.selectedValue.ToString())
        Dim projName As String = If(ProjectName.selectedIndex = -1, "", ProjectName.selectedValue.ToString())
        Dim custName As String = If(CustomerName.selectedIndex = -1, "", CustomerName.selectedValue.ToString())
        Dim typName As String = If(TypeName.selectedIndex = -1, "", TypeName.selectedValue.ToString())
        Dim pattern As String = "(?=.*" & projName & ")(?=.*" & custName & ")(?=.*" & typName & ")(?=.*" & PartNumber.Text & ")(?=.*" & PartName.Text & ").*"

        For Each dirItem In FastDirectoryEnumerator.EnumerateFiles(dirIn.FullName, "*." & varFileExt) _
            .Where(Function(path) Regex.IsMatch(path.Path, pattern, RegexOptions.IgnoreCase)) _
            .ToList()
            Dim itemInfo As New FileInfo(dirItem.Path)
            DataGridView1.Rows.Add(
                itemInfo.Name,
                itemInfo.DirectoryName,
                itemInfo.CreationTime.ToString("dd/MM/yyyy hh:mm:ss"),
                itemInfo.LastWriteTime.ToString("dd/MM/yyyy hh:mm:ss")
            )
            total += 1
        Next

        For Each d In dirIn.EnumerateDirectories().AsParallel()
            GetTheFiles(d)
        Next
    End Sub

    Private Sub ThreadQ()
        dir = New DirectoryInfo(FolderName.Text)
        total = 0
        SearchButton.Enabled = False
        StopButton.Enabled = True
        DataGridView1.Rows.Clear()
        SearchButton.ButtonText = "Searching..."
        SearchButton.BackColor = Color.LightSlateGray
        GetTheFiles(dir)
        SearchButton.Text = "Search"
        SearchButton.Enabled = True
        StopButton.Enabled = False
        If total = 0 Then
            MsgBox("not found")
        Else
            MsgBox("found " & total & " item(s)")
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If FolderName.Text IsNot "" Then
            Try
                t = Nothing
                t = New Thread(AddressOf ThreadQ)
                t.IsBackground = True
                t.Start()
            Catch err As UnauthorizedAccessException
                SearchButton.Text = "Search"
                MsgBox(err.Message)
            End Try
        Else
            MsgBox("select path")
        End If
    End Sub

    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        Dim objFolderDialog As New FolderBrowserDialog()
        FolderName.Text = GetNetworkFolders(objFolderDialog)
    End Sub

    Public Shared Function GetNetworkFolders(ByVal oFolderBrowserDialog As FolderBrowserDialog) As String
        Dim type As Type = oFolderBrowserDialog.[GetType]
        Dim fieldInfo As FieldInfo = type.GetField("rootFolder", BindingFlags.NonPublic Or BindingFlags.Instance)
        'fieldInfo.SetValue(oFolderBrowserDialog, DirectCast(1, Environment.SpecialFolder))
        If oFolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Return oFolderBrowserDialog.SelectedPath
        End If
        Return ""
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim loc As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Process.Start(loc)
        End If
    End Sub



    Private Sub SaveCustomer_Click(sender As Object, e As EventArgs) Handles SaveCustomer.Click
        File.WriteAllText(programPath & "/customers.txt", CustomerDataRTB.Text)
        MsgBox("customer updated!")
    End Sub

    Private Sub SaveProject_Click(sender As Object, e As EventArgs) Handles SaveProject.Click
        File.WriteAllText(programPath & "/projects.txt", ProjectDataRTB.Text)
        MsgBox("project updated!")
    End Sub

    Private Sub SaveDocType_Click(sender As Object, e As EventArgs) Handles SaveDocType.Click
        File.WriteAllText(programPath & "/types.txt", DocTypeDataRTB.Text)
        MsgBox("doc type updated!")
    End Sub

    Private Sub SaveExtension_Click(sender As Object, e As EventArgs) Handles SaveExtension.Click
        File.WriteAllText(programPath & "/extensions.txt", ExtensionDataRTB.Text)
        MsgBox("extension updated!")
    End Sub


    Private Sub EditButton_Click(sender As Object, e As EventArgs)
        cardseditcust.Visible = True

    End Sub


    Private Sub CloseButton_Click_1(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinButton_Click_1(sender As Object, e As EventArgs) Handles MinButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        CustomerName.Clear()
        CustomerName.ResetText()
        ProjectName.Clear()
        ProjectName.ResetText()
        TypeName.Clear()
        TypeName.ResetText()
        FileExtension.Clear()
        FileExtension.ResetText()

        For Each d As String In File.ReadAllLines(programPath & "\customers.txt")
            CustomerName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\projects.txt")
            ProjectName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\types.txt")
            TypeName.AddItem(d)
        Next
        For Each d As String In File.ReadAllLines(programPath & "\extensions.txt")
            FileExtension.AddItem(d)
        Next

        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
    End Sub

    Private Sub EditButton_Click_1(sender As Object, e As EventArgs) Handles EditButton.Click
        CustomerEditBtn.Visible = Not CustomerEditBtn.Visible
        ProjectEditBtn.Visible = Not ProjectEditBtn.Visible
        DocTypeEditBtn.Visible = Not DocTypeEditBtn.Visible
        ExtensionEditBtn.Visible = Not ExtensionEditBtn.Visible
    End Sub

    Private Sub CustomerEditBtn_Click(sender As Object, e As EventArgs) Handles CustomerEditBtn.Click
        cardseditcust.Visible = True

    End Sub

    Private Sub ProjectEditBtn_Click(sender As Object, e As EventArgs) Handles ProjectEditBtn.Click
        cardsproject.Visible = True
    End Sub

    Private Sub DocTypeEditBtn_Click(sender As Object, e As EventArgs) Handles DocTypeEditBtn.Click
        cardstype.Visible = True
    End Sub

    Private Sub ExtensionEditBtn_Click(sender As Object, e As EventArgs) Handles ExtensionEditBtn.Click
        cardsextension.Visible = True

    End Sub
    Private Sub exclose_Click(sender As Object, e As EventArgs) Handles exclose.Click
        cardsextension.Visible = False
        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
    End Sub
    Private Sub custclose_Click(sender As Object, e As EventArgs) Handles custclose.Click
        cardseditcust.Visible = False
        cardsextension.Visible = False
        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
    End Sub
    Private Sub projectclose_Click(sender As Object, e As EventArgs) Handles projectclose.Click
        cardsproject.Visible = False
        cardsextension.Visible = False
        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
    End Sub
    Private Sub typeclose_Click(sender As Object, e As EventArgs) Handles typeclose.Click
        cardstype.Visible = False
        cardsextension.Visible = False
        CustomerEditBtn.Visible = False
        ProjectEditBtn.Visible = False
        DocTypeEditBtn.Visible = False
        ExtensionEditBtn.Visible = False
    End Sub

    Private Sub drectserverbtn_Click(sender As Object, e As EventArgs) Handles drectserverbtn.Click
        FolderName.Text = If(FolderName.Text = "", "\\192.168.10.63", "")
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        t.Abort()
        SearchButton.Text = "Search"
        SearchButton.Enabled = True
        StopButton.Enabled = False
        If total = 0 Then
            MsgBox("not found")
        Else
            MsgBox("found " & total & " item(s)")
        End If
    End Sub
End Class
