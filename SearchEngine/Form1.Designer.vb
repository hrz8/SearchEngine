Imports Bunifu.Framework.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.CustomerName = New Bunifu.Framework.UI.BunifuDropdown()
        Me.ProjectName = New Bunifu.Framework.UI.BunifuDropdown()
        Me.FileExtension = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TypeName = New Bunifu.Framework.UI.BunifuDropdown()
        Me.PartName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.SearchButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.header = New Bunifu.Framework.UI.BunifuCards()
        Me.garislbl = New System.Windows.Forms.Label()
        Me.EditButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RefreshButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MinButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CloseButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cardseditcust = New Bunifu.Framework.UI.BunifuCards()
        Me.CustomerDataRTB = New System.Windows.Forms.RichTextBox()
        Me.custclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SaveCustomer = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Editcustlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PartNumber = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.cardsproject = New Bunifu.Framework.UI.BunifuCards()
        Me.ProjectDataRTB = New System.Windows.Forms.RichTextBox()
        Me.projectclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SaveProject = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cardstype = New Bunifu.Framework.UI.BunifuCards()
        Me.DocTypeDataRTB = New System.Windows.Forms.RichTextBox()
        Me.typeclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SaveDocType = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cardsextension = New Bunifu.Framework.UI.BunifuCards()
        Me.ExtensionDataRTB = New System.Windows.Forms.RichTextBox()
        Me.exclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SaveExtension = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CustomerEditBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ProjectEditBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DocTypeEditBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ExtensionEditBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.drectserverbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse9 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse10 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StopButton = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.cardseditcust.SuspendLayout()
        Me.cardsproject.SuspendLayout()
        Me.cardstype.SuspendLayout()
        Me.cardsextension.SuspendLayout()
        CType(Me.CustomerEditBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectEditBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocTypeEditBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExtensionEditBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomTextbox1.Enabled = False
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.BunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(60, 19)
        Me.BunifuCustomTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.ReadOnly = True
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(148, 37)
        Me.BunifuCustomTextbox1.TabIndex = 2
        Me.BunifuCustomTextbox1.Text = "Finder"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(13, 66)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 6)
        Me.Panel3.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeight = 50
        Me.BunifuTransition1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(8)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.White
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.Gray
        Me.DataGridView1.Location = New System.Drawing.Point(59, 338)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(877, 353)
        Me.DataGridView1.TabIndex = 2
        '
        'CustomerName
        '
        Me.CustomerName.BackColor = System.Drawing.Color.Transparent
        Me.CustomerName.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.CustomerName, BunifuAnimatorNS.DecorationType.None)
        Me.CustomerName.DisabledColor = System.Drawing.Color.Gray
        Me.CustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.CustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomerName.Items = New String(-1) {}
        Me.CustomerName.Location = New System.Drawing.Point(59, 188)
        Me.CustomerName.Margin = New System.Windows.Forms.Padding(5)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.NomalColor = System.Drawing.Color.White
        Me.CustomerName.onHoverColor = System.Drawing.Color.White
        Me.CustomerName.selectedIndex = -1
        Me.CustomerName.Size = New System.Drawing.Size(181, 37)
        Me.CustomerName.TabIndex = 4
        '
        'ProjectName
        '
        Me.ProjectName.BackColor = System.Drawing.Color.Transparent
        Me.ProjectName.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.ProjectName, BunifuAnimatorNS.DecorationType.None)
        Me.ProjectName.DisabledColor = System.Drawing.Color.Gray
        Me.ProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.ProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProjectName.Items = New String(-1) {}
        Me.ProjectName.Location = New System.Drawing.Point(303, 188)
        Me.ProjectName.Margin = New System.Windows.Forms.Padding(5)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.NomalColor = System.Drawing.Color.White
        Me.ProjectName.onHoverColor = System.Drawing.Color.White
        Me.ProjectName.selectedIndex = -1
        Me.ProjectName.Size = New System.Drawing.Size(181, 37)
        Me.ProjectName.TabIndex = 5
        '
        'FileExtension
        '
        Me.FileExtension.BackColor = System.Drawing.Color.Transparent
        Me.FileExtension.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.FileExtension, BunifuAnimatorNS.DecorationType.None)
        Me.FileExtension.DisabledColor = System.Drawing.Color.Gray
        Me.FileExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.FileExtension.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileExtension.Items = New String(-1) {}
        Me.FileExtension.Location = New System.Drawing.Point(548, 270)
        Me.FileExtension.Margin = New System.Windows.Forms.Padding(5)
        Me.FileExtension.Name = "FileExtension"
        Me.FileExtension.NomalColor = System.Drawing.Color.White
        Me.FileExtension.onHoverColor = System.Drawing.Color.White
        Me.FileExtension.selectedIndex = -1
        Me.FileExtension.Size = New System.Drawing.Size(181, 37)
        Me.FileExtension.TabIndex = 7
        '
        'TypeName
        '
        Me.TypeName.BackColor = System.Drawing.Color.Transparent
        Me.TypeName.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.TypeName, BunifuAnimatorNS.DecorationType.None)
        Me.TypeName.DisabledColor = System.Drawing.Color.Gray
        Me.TypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TypeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TypeName.Items = New String(-1) {}
        Me.TypeName.Location = New System.Drawing.Point(548, 188)
        Me.TypeName.Margin = New System.Windows.Forms.Padding(5)
        Me.TypeName.Name = "TypeName"
        Me.TypeName.NomalColor = System.Drawing.Color.White
        Me.TypeName.onHoverColor = System.Drawing.Color.White
        Me.TypeName.selectedIndex = -1
        Me.TypeName.Size = New System.Drawing.Size(181, 37)
        Me.TypeName.TabIndex = 6
        '
        'PartName
        '
        Me.PartName.BorderColor = System.Drawing.Color.SeaGreen
        Me.PartName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.PartName, BunifuAnimatorNS.DecorationType.None)
        Me.PartName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PartName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PartName.Location = New System.Drawing.Point(303, 270)
        Me.PartName.Margin = New System.Windows.Forms.Padding(4)
        Me.PartName.Multiline = True
        Me.PartName.Name = "PartName"
        Me.PartName.Size = New System.Drawing.Size(181, 37)
        Me.PartName.TabIndex = 9
        '
        'SearchButton
        '
        Me.SearchButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchButton.BorderRadius = 7
        Me.SearchButton.ButtonText = "Search"
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SearchButton, BunifuAnimatorNS.DecorationType.None)
        Me.SearchButton.DisabledColor = System.Drawing.Color.Gray
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Iconcolor = System.Drawing.Color.Transparent
        Me.SearchButton.Iconimage = Nothing
        Me.SearchButton.Iconimage_right = Nothing
        Me.SearchButton.Iconimage_right_Selected = Nothing
        Me.SearchButton.Iconimage_Selected = Nothing
        Me.SearchButton.IconMarginLeft = 0
        Me.SearchButton.IconMarginRight = 0
        Me.SearchButton.IconRightVisible = False
        Me.SearchButton.IconRightZoom = 0R
        Me.SearchButton.IconVisible = False
        Me.SearchButton.IconZoom = 90.0R
        Me.SearchButton.IsTab = False
        Me.SearchButton.Location = New System.Drawing.Point(817, 199)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SearchButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SearchButton.OnHoverTextColor = System.Drawing.Color.White
        Me.SearchButton.selected = False
        Me.SearchButton.Size = New System.Drawing.Size(119, 37)
        Me.SearchButton.TabIndex = 10
        Me.SearchButton.Text = "Search"
        Me.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SearchButton.Textcolor = System.Drawing.Color.White
        Me.SearchButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.Location = New System.Drawing.Point(59, 164)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 25)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Customer"
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SelectFolderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SelectFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SelectFolderButton.BorderRadius = 7
        Me.SelectFolderButton.ButtonText = "Browse"
        Me.SelectFolderButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SelectFolderButton, BunifuAnimatorNS.DecorationType.None)
        Me.SelectFolderButton.DisabledColor = System.Drawing.Color.Gray
        Me.SelectFolderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectFolderButton.Iconcolor = System.Drawing.Color.Transparent
        Me.SelectFolderButton.Iconimage = Nothing
        Me.SelectFolderButton.Iconimage_right = Nothing
        Me.SelectFolderButton.Iconimage_right_Selected = Nothing
        Me.SelectFolderButton.Iconimage_Selected = Nothing
        Me.SelectFolderButton.IconMarginLeft = 0
        Me.SelectFolderButton.IconMarginRight = 0
        Me.SelectFolderButton.IconRightVisible = False
        Me.SelectFolderButton.IconRightZoom = 0R
        Me.SelectFolderButton.IconVisible = False
        Me.SelectFolderButton.IconZoom = 90.0R
        Me.SelectFolderButton.IsTab = False
        Me.SelectFolderButton.Location = New System.Drawing.Point(303, 107)
        Me.SelectFolderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SelectFolderButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SelectFolderButton.OnHoverTextColor = System.Drawing.Color.White
        Me.SelectFolderButton.selected = False
        Me.SelectFolderButton.Size = New System.Drawing.Size(108, 37)
        Me.SelectFolderButton.TabIndex = 13
        Me.SelectFolderButton.Text = "Browse"
        Me.SelectFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SelectFolderButton.Textcolor = System.Drawing.Color.White
        Me.SelectFolderButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox2.Location = New System.Drawing.Point(303, 164)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 25)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "Project"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox3.Location = New System.Drawing.Point(548, 164)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 25)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "Doc Type"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox4.Location = New System.Drawing.Point(548, 245)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 25)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = "Extension"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox5.Location = New System.Drawing.Point(59, 245)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 25)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.Text = "Part No"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TextBox6, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox6.Location = New System.Drawing.Point(303, 245)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(133, 25)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = "Part Name"
        '
        'FolderName
        '
        Me.FolderName.BorderColor = System.Drawing.Color.White
        Me.FolderName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.FolderName, BunifuAnimatorNS.DecorationType.None)
        Me.FolderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FolderName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FolderName.Location = New System.Drawing.Point(60, 107)
        Me.FolderName.Margin = New System.Windows.Forms.Padding(4)
        Me.FolderName.Multiline = True
        Me.FolderName.Name = "FolderName"
        Me.FolderName.Size = New System.Drawing.Size(215, 37)
        Me.FolderName.TabIndex = 12
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.White
        Me.header.BorderRadius = 5
        Me.header.BottomSahddow = True
        Me.header.color = System.Drawing.Color.White
        Me.header.Controls.Add(Me.garislbl)
        Me.header.Controls.Add(Me.EditButton)
        Me.header.Controls.Add(Me.RefreshButton)
        Me.header.Controls.Add(Me.MinButton)
        Me.header.Controls.Add(Me.CloseButton)
        Me.header.Controls.Add(Me.Panel3)
        Me.header.Controls.Add(Me.BunifuCustomTextbox1)
        Me.BunifuTransition1.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.LeftSahddow = False
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.RightSahddow = True
        Me.header.ShadowDepth = 50
        Me.header.Size = New System.Drawing.Size(1001, 73)
        Me.header.TabIndex = 19
        '
        'garislbl
        '
        Me.garislbl.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.garislbl, BunifuAnimatorNS.DecorationType.None)
        Me.garislbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.garislbl.ForeColor = System.Drawing.Color.Silver
        Me.garislbl.Location = New System.Drawing.Point(905, 4)
        Me.garislbl.Name = "garislbl"
        Me.garislbl.Size = New System.Drawing.Size(19, 29)
        Me.garislbl.TabIndex = 23
        Me.garislbl.Text = "|"
        '
        'EditButton
        '
        Me.EditButton.Activecolor = System.Drawing.Color.DarkGray
        Me.EditButton.BackColor = System.Drawing.Color.Transparent
        Me.EditButton.BackgroundImage = Global.SearchEngine.My.Resources.Resources.edit
        Me.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditButton.BorderRadius = 0
        Me.EditButton.ButtonText = ""
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.EditButton, BunifuAnimatorNS.DecorationType.None)
        Me.EditButton.DisabledColor = System.Drawing.Color.Gray
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Iconcolor = System.Drawing.Color.Transparent
        Me.EditButton.Iconimage = Nothing
        Me.EditButton.Iconimage_right = Nothing
        Me.EditButton.Iconimage_right_Selected = Nothing
        Me.EditButton.Iconimage_Selected = Nothing
        Me.EditButton.IconMarginLeft = 0
        Me.EditButton.IconMarginRight = 0
        Me.EditButton.IconRightVisible = False
        Me.EditButton.IconRightZoom = 0R
        Me.EditButton.IconVisible = False
        Me.EditButton.IconZoom = 90.0R
        Me.EditButton.IsTab = False
        Me.EditButton.Location = New System.Drawing.Point(771, 13)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(5)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Normalcolor = System.Drawing.Color.Transparent
        Me.EditButton.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.EditButton.OnHoverTextColor = System.Drawing.Color.White
        Me.EditButton.selected = False
        Me.EditButton.Size = New System.Drawing.Size(46, 16)
        Me.EditButton.TabIndex = 25
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EditButton.Textcolor = System.Drawing.Color.White
        Me.EditButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RefreshButton
        '
        Me.RefreshButton.Activecolor = System.Drawing.Color.DarkGray
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.BackgroundImage = Global.SearchEngine.My.Resources.Resources.refresh
        Me.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshButton.BorderRadius = 0
        Me.RefreshButton.ButtonText = ""
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.RefreshButton, BunifuAnimatorNS.DecorationType.None)
        Me.RefreshButton.DisabledColor = System.Drawing.Color.Gray
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Iconcolor = System.Drawing.Color.Transparent
        Me.RefreshButton.Iconimage = Nothing
        Me.RefreshButton.Iconimage_right = Nothing
        Me.RefreshButton.Iconimage_right_Selected = Nothing
        Me.RefreshButton.Iconimage_Selected = Nothing
        Me.RefreshButton.IconMarginLeft = 0
        Me.RefreshButton.IconMarginRight = 0
        Me.RefreshButton.IconRightVisible = False
        Me.RefreshButton.IconRightZoom = 0R
        Me.RefreshButton.IconVisible = False
        Me.RefreshButton.IconZoom = 90.0R
        Me.RefreshButton.IsTab = False
        Me.RefreshButton.Location = New System.Drawing.Point(830, 13)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Normalcolor = System.Drawing.Color.Transparent
        Me.RefreshButton.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.RefreshButton.OnHoverTextColor = System.Drawing.Color.White
        Me.RefreshButton.selected = False
        Me.RefreshButton.Size = New System.Drawing.Size(67, 16)
        Me.RefreshButton.TabIndex = 23
        Me.RefreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RefreshButton.Textcolor = System.Drawing.Color.White
        Me.RefreshButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MinButton
        '
        Me.MinButton.Activecolor = System.Drawing.Color.DarkGray
        Me.MinButton.BackColor = System.Drawing.Color.Transparent
        Me.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MinButton.BorderRadius = 0
        Me.MinButton.ButtonText = "ー"
        Me.MinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.MinButton, BunifuAnimatorNS.DecorationType.None)
        Me.MinButton.DisabledColor = System.Drawing.Color.Gray
        Me.MinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinButton.Iconcolor = System.Drawing.Color.Transparent
        Me.MinButton.Iconimage = Nothing
        Me.MinButton.Iconimage_right = Nothing
        Me.MinButton.Iconimage_right_Selected = Nothing
        Me.MinButton.Iconimage_Selected = Nothing
        Me.MinButton.IconMarginLeft = 0
        Me.MinButton.IconMarginRight = 0
        Me.MinButton.IconRightVisible = False
        Me.MinButton.IconRightZoom = 0R
        Me.MinButton.IconVisible = False
        Me.MinButton.IconZoom = 90.0R
        Me.MinButton.IsTab = False
        Me.MinButton.Location = New System.Drawing.Point(928, 11)
        Me.MinButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MinButton.Name = "MinButton"
        Me.MinButton.Normalcolor = System.Drawing.Color.Transparent
        Me.MinButton.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.MinButton.OnHoverTextColor = System.Drawing.Color.White
        Me.MinButton.selected = False
        Me.MinButton.Size = New System.Drawing.Size(27, 23)
        Me.MinButton.TabIndex = 24
        Me.MinButton.Text = "ー"
        Me.MinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MinButton.Textcolor = System.Drawing.Color.DarkGray
        Me.MinButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CloseButton
        '
        Me.CloseButton.Activecolor = System.Drawing.Color.DarkGray
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.BorderRadius = 0
        Me.CloseButton.ButtonText = "x"
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.CloseButton, BunifuAnimatorNS.DecorationType.None)
        Me.CloseButton.DisabledColor = System.Drawing.Color.Gray
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Iconcolor = System.Drawing.Color.Transparent
        Me.CloseButton.Iconimage = Nothing
        Me.CloseButton.Iconimage_right = Nothing
        Me.CloseButton.Iconimage_right_Selected = Nothing
        Me.CloseButton.Iconimage_Selected = Nothing
        Me.CloseButton.IconMarginLeft = 0
        Me.CloseButton.IconMarginRight = 0
        Me.CloseButton.IconRightVisible = False
        Me.CloseButton.IconRightZoom = 0R
        Me.CloseButton.IconVisible = False
        Me.CloseButton.IconZoom = 90.0R
        Me.CloseButton.IsTab = False
        Me.CloseButton.Location = New System.Drawing.Point(959, 7)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Normalcolor = System.Drawing.Color.Transparent
        Me.CloseButton.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.CloseButton.OnHoverTextColor = System.Drawing.Color.White
        Me.CloseButton.selected = False
        Me.CloseButton.Size = New System.Drawing.Size(30, 24)
        Me.CloseButton.TabIndex = 23
        Me.CloseButton.Text = "x"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CloseButton.Textcolor = System.Drawing.Color.DarkGray
        Me.CloseButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        '
        'cardseditcust
        '
        Me.cardseditcust.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cardseditcust.BorderRadius = 10
        Me.cardseditcust.BottomSahddow = True
        Me.cardseditcust.color = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cardseditcust.Controls.Add(Me.CustomerDataRTB)
        Me.cardseditcust.Controls.Add(Me.custclose)
        Me.cardseditcust.Controls.Add(Me.SaveCustomer)
        Me.cardseditcust.Controls.Add(Me.Label2)
        Me.cardseditcust.Controls.Add(Me.Editcustlbl)
        Me.cardseditcust.Controls.Add(Me.Label6)
        Me.BunifuTransition1.SetDecoration(Me.cardseditcust, BunifuAnimatorNS.DecorationType.None)
        Me.cardseditcust.LeftSahddow = True
        Me.cardseditcust.Location = New System.Drawing.Point(349, 230)
        Me.cardseditcust.Name = "cardseditcust"
        Me.cardseditcust.RightSahddow = True
        Me.cardseditcust.ShadowDepth = 40
        Me.cardseditcust.Size = New System.Drawing.Size(283, 281)
        Me.cardseditcust.TabIndex = 21
        '
        'CustomerDataRTB
        '
        Me.BunifuTransition1.SetDecoration(Me.CustomerDataRTB, BunifuAnimatorNS.DecorationType.None)
        Me.CustomerDataRTB.Location = New System.Drawing.Point(34, 85)
        Me.CustomerDataRTB.Name = "CustomerDataRTB"
        Me.CustomerDataRTB.Size = New System.Drawing.Size(218, 139)
        Me.CustomerDataRTB.TabIndex = 29
        Me.CustomerDataRTB.Text = ""
        '
        'custclose
        '
        Me.custclose.Activecolor = System.Drawing.Color.Transparent
        Me.custclose.BackColor = System.Drawing.Color.Transparent
        Me.custclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.custclose.BorderRadius = 7
        Me.custclose.ButtonText = "x"
        Me.custclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.custclose, BunifuAnimatorNS.DecorationType.None)
        Me.custclose.DisabledColor = System.Drawing.Color.Gray
        Me.custclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custclose.Iconcolor = System.Drawing.Color.Transparent
        Me.custclose.Iconimage = Nothing
        Me.custclose.Iconimage_right = Nothing
        Me.custclose.Iconimage_right_Selected = Nothing
        Me.custclose.Iconimage_Selected = Nothing
        Me.custclose.IconMarginLeft = 0
        Me.custclose.IconMarginRight = 0
        Me.custclose.IconRightVisible = False
        Me.custclose.IconRightZoom = 0R
        Me.custclose.IconVisible = False
        Me.custclose.IconZoom = 90.0R
        Me.custclose.IsTab = False
        Me.custclose.Location = New System.Drawing.Point(250, 6)
        Me.custclose.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.custclose.Name = "custclose"
        Me.custclose.Normalcolor = System.Drawing.Color.Transparent
        Me.custclose.OnHovercolor = System.Drawing.Color.Transparent
        Me.custclose.OnHoverTextColor = System.Drawing.Color.White
        Me.custclose.selected = False
        Me.custclose.Size = New System.Drawing.Size(30, 24)
        Me.custclose.TabIndex = 27
        Me.custclose.Text = "x"
        Me.custclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.custclose.Textcolor = System.Drawing.Color.DarkGray
        Me.custclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        '
        'SaveCustomer
        '
        Me.SaveCustomer.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveCustomer.BorderRadius = 7
        Me.SaveCustomer.ButtonText = "Save"
        Me.SaveCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SaveCustomer, BunifuAnimatorNS.DecorationType.None)
        Me.SaveCustomer.DisabledColor = System.Drawing.Color.Gray
        Me.SaveCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCustomer.Iconcolor = System.Drawing.Color.Transparent
        Me.SaveCustomer.Iconimage = Nothing
        Me.SaveCustomer.Iconimage_right = Nothing
        Me.SaveCustomer.Iconimage_right_Selected = Nothing
        Me.SaveCustomer.Iconimage_Selected = Nothing
        Me.SaveCustomer.IconMarginLeft = 0
        Me.SaveCustomer.IconMarginRight = 0
        Me.SaveCustomer.IconRightVisible = False
        Me.SaveCustomer.IconRightZoom = 0R
        Me.SaveCustomer.IconVisible = False
        Me.SaveCustomer.IconZoom = 90.0R
        Me.SaveCustomer.IsTab = False
        Me.SaveCustomer.Location = New System.Drawing.Point(193, 236)
        Me.SaveCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveCustomer.Name = "SaveCustomer"
        Me.SaveCustomer.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveCustomer.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveCustomer.OnHoverTextColor = System.Drawing.Color.White
        Me.SaveCustomer.selected = False
        Me.SaveCustomer.Size = New System.Drawing.Size(59, 28)
        Me.SaveCustomer.TabIndex = 17
        Me.SaveCustomer.Text = "Save"
        Me.SaveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveCustomer.Textcolor = System.Drawing.Color.White
        Me.SaveCustomer.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label2.Location = New System.Drawing.Point(26, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Edit"
        '
        'Editcustlbl
        '
        Me.Editcustlbl.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Editcustlbl, BunifuAnimatorNS.DecorationType.None)
        Me.Editcustlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.Editcustlbl.Location = New System.Drawing.Point(29, 60)
        Me.Editcustlbl.Name = "Editcustlbl"
        Me.Editcustlbl.Size = New System.Drawing.Size(65, 16)
        Me.Editcustlbl.TabIndex = 1
        Me.Editcustlbl.Text = "Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(24, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 29)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "________"
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.BunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
        '
        'PartNumber
        '
        Me.PartNumber.BorderColor = System.Drawing.Color.White
        Me.PartNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.PartNumber, BunifuAnimatorNS.DecorationType.None)
        Me.PartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PartNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PartNumber.Location = New System.Drawing.Point(60, 270)
        Me.PartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.PartNumber.Multiline = True
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Size = New System.Drawing.Size(181, 37)
        Me.PartNumber.TabIndex = 22
        '
        'cardsproject
        '
        Me.cardsproject.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cardsproject.BorderRadius = 10
        Me.cardsproject.BottomSahddow = True
        Me.cardsproject.color = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cardsproject.Controls.Add(Me.ProjectDataRTB)
        Me.cardsproject.Controls.Add(Me.projectclose)
        Me.cardsproject.Controls.Add(Me.SaveProject)
        Me.cardsproject.Controls.Add(Me.Label1)
        Me.cardsproject.Controls.Add(Me.Label3)
        Me.cardsproject.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me.cardsproject, BunifuAnimatorNS.DecorationType.None)
        Me.cardsproject.LeftSahddow = True
        Me.cardsproject.Location = New System.Drawing.Point(333, 245)
        Me.cardsproject.Name = "cardsproject"
        Me.cardsproject.RightSahddow = True
        Me.cardsproject.ShadowDepth = 40
        Me.cardsproject.Size = New System.Drawing.Size(283, 281)
        Me.cardsproject.TabIndex = 30
        '
        'ProjectDataRTB
        '
        Me.BunifuTransition1.SetDecoration(Me.ProjectDataRTB, BunifuAnimatorNS.DecorationType.None)
        Me.ProjectDataRTB.Location = New System.Drawing.Point(34, 85)
        Me.ProjectDataRTB.Name = "ProjectDataRTB"
        Me.ProjectDataRTB.Size = New System.Drawing.Size(218, 139)
        Me.ProjectDataRTB.TabIndex = 29
        Me.ProjectDataRTB.Text = ""
        '
        'projectclose
        '
        Me.projectclose.Activecolor = System.Drawing.Color.Transparent
        Me.projectclose.BackColor = System.Drawing.Color.Transparent
        Me.projectclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.projectclose.BorderRadius = 7
        Me.projectclose.ButtonText = "x"
        Me.projectclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.projectclose, BunifuAnimatorNS.DecorationType.None)
        Me.projectclose.DisabledColor = System.Drawing.Color.Gray
        Me.projectclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectclose.Iconcolor = System.Drawing.Color.Transparent
        Me.projectclose.Iconimage = Nothing
        Me.projectclose.Iconimage_right = Nothing
        Me.projectclose.Iconimage_right_Selected = Nothing
        Me.projectclose.Iconimage_Selected = Nothing
        Me.projectclose.IconMarginLeft = 0
        Me.projectclose.IconMarginRight = 0
        Me.projectclose.IconRightVisible = False
        Me.projectclose.IconRightZoom = 0R
        Me.projectclose.IconVisible = False
        Me.projectclose.IconZoom = 90.0R
        Me.projectclose.IsTab = False
        Me.projectclose.Location = New System.Drawing.Point(250, 6)
        Me.projectclose.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.projectclose.Name = "projectclose"
        Me.projectclose.Normalcolor = System.Drawing.Color.Transparent
        Me.projectclose.OnHovercolor = System.Drawing.Color.Transparent
        Me.projectclose.OnHoverTextColor = System.Drawing.Color.White
        Me.projectclose.selected = False
        Me.projectclose.Size = New System.Drawing.Size(30, 24)
        Me.projectclose.TabIndex = 27
        Me.projectclose.Text = "x"
        Me.projectclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.projectclose.Textcolor = System.Drawing.Color.DarkGray
        Me.projectclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        '
        'SaveProject
        '
        Me.SaveProject.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SaveProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveProject.BorderRadius = 7
        Me.SaveProject.ButtonText = "Save"
        Me.SaveProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SaveProject, BunifuAnimatorNS.DecorationType.None)
        Me.SaveProject.DisabledColor = System.Drawing.Color.Gray
        Me.SaveProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveProject.Iconcolor = System.Drawing.Color.Transparent
        Me.SaveProject.Iconimage = Nothing
        Me.SaveProject.Iconimage_right = Nothing
        Me.SaveProject.Iconimage_right_Selected = Nothing
        Me.SaveProject.Iconimage_Selected = Nothing
        Me.SaveProject.IconMarginLeft = 0
        Me.SaveProject.IconMarginRight = 0
        Me.SaveProject.IconRightVisible = False
        Me.SaveProject.IconRightZoom = 0R
        Me.SaveProject.IconVisible = False
        Me.SaveProject.IconZoom = 90.0R
        Me.SaveProject.IsTab = False
        Me.SaveProject.Location = New System.Drawing.Point(193, 236)
        Me.SaveProject.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveProject.Name = "SaveProject"
        Me.SaveProject.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveProject.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveProject.OnHoverTextColor = System.Drawing.Color.White
        Me.SaveProject.selected = False
        Me.SaveProject.Size = New System.Drawing.Size(59, 28)
        Me.SaveProject.TabIndex = 17
        Me.SaveProject.Text = "Save"
        Me.SaveProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveProject.Textcolor = System.Drawing.Color.White
        Me.SaveProject.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.Label3.Location = New System.Drawing.Point(29, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Project"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(24, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "________"
        '
        'cardstype
        '
        Me.cardstype.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cardstype.BorderRadius = 10
        Me.cardstype.BottomSahddow = True
        Me.cardstype.color = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cardstype.Controls.Add(Me.DocTypeDataRTB)
        Me.cardstype.Controls.Add(Me.typeclose)
        Me.cardstype.Controls.Add(Me.SaveDocType)
        Me.cardstype.Controls.Add(Me.Label5)
        Me.cardstype.Controls.Add(Me.Label7)
        Me.cardstype.Controls.Add(Me.Label8)
        Me.BunifuTransition1.SetDecoration(Me.cardstype, BunifuAnimatorNS.DecorationType.None)
        Me.cardstype.LeftSahddow = True
        Me.cardstype.Location = New System.Drawing.Point(336, 233)
        Me.cardstype.Name = "cardstype"
        Me.cardstype.RightSahddow = True
        Me.cardstype.ShadowDepth = 40
        Me.cardstype.Size = New System.Drawing.Size(283, 281)
        Me.cardstype.TabIndex = 31
        '
        'DocTypeDataRTB
        '
        Me.BunifuTransition1.SetDecoration(Me.DocTypeDataRTB, BunifuAnimatorNS.DecorationType.None)
        Me.DocTypeDataRTB.Location = New System.Drawing.Point(34, 85)
        Me.DocTypeDataRTB.Name = "DocTypeDataRTB"
        Me.DocTypeDataRTB.Size = New System.Drawing.Size(218, 139)
        Me.DocTypeDataRTB.TabIndex = 29
        Me.DocTypeDataRTB.Text = ""
        '
        'typeclose
        '
        Me.typeclose.Activecolor = System.Drawing.Color.Transparent
        Me.typeclose.BackColor = System.Drawing.Color.Transparent
        Me.typeclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.typeclose.BorderRadius = 7
        Me.typeclose.ButtonText = "x"
        Me.typeclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.typeclose, BunifuAnimatorNS.DecorationType.None)
        Me.typeclose.DisabledColor = System.Drawing.Color.Gray
        Me.typeclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeclose.Iconcolor = System.Drawing.Color.Transparent
        Me.typeclose.Iconimage = Nothing
        Me.typeclose.Iconimage_right = Nothing
        Me.typeclose.Iconimage_right_Selected = Nothing
        Me.typeclose.Iconimage_Selected = Nothing
        Me.typeclose.IconMarginLeft = 0
        Me.typeclose.IconMarginRight = 0
        Me.typeclose.IconRightVisible = False
        Me.typeclose.IconRightZoom = 0R
        Me.typeclose.IconVisible = False
        Me.typeclose.IconZoom = 90.0R
        Me.typeclose.IsTab = False
        Me.typeclose.Location = New System.Drawing.Point(250, 6)
        Me.typeclose.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.typeclose.Name = "typeclose"
        Me.typeclose.Normalcolor = System.Drawing.Color.Transparent
        Me.typeclose.OnHovercolor = System.Drawing.Color.Transparent
        Me.typeclose.OnHoverTextColor = System.Drawing.Color.White
        Me.typeclose.selected = False
        Me.typeclose.Size = New System.Drawing.Size(30, 24)
        Me.typeclose.TabIndex = 27
        Me.typeclose.Text = "x"
        Me.typeclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.typeclose.Textcolor = System.Drawing.Color.DarkGray
        Me.typeclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        '
        'SaveDocType
        '
        Me.SaveDocType.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveDocType.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveDocType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveDocType.BorderRadius = 7
        Me.SaveDocType.ButtonText = "Save"
        Me.SaveDocType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SaveDocType, BunifuAnimatorNS.DecorationType.None)
        Me.SaveDocType.DisabledColor = System.Drawing.Color.Gray
        Me.SaveDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveDocType.Iconcolor = System.Drawing.Color.Transparent
        Me.SaveDocType.Iconimage = Nothing
        Me.SaveDocType.Iconimage_right = Nothing
        Me.SaveDocType.Iconimage_right_Selected = Nothing
        Me.SaveDocType.Iconimage_Selected = Nothing
        Me.SaveDocType.IconMarginLeft = 0
        Me.SaveDocType.IconMarginRight = 0
        Me.SaveDocType.IconRightVisible = False
        Me.SaveDocType.IconRightZoom = 0R
        Me.SaveDocType.IconVisible = False
        Me.SaveDocType.IconZoom = 90.0R
        Me.SaveDocType.IsTab = False
        Me.SaveDocType.Location = New System.Drawing.Point(193, 236)
        Me.SaveDocType.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveDocType.Name = "SaveDocType"
        Me.SaveDocType.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveDocType.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveDocType.OnHoverTextColor = System.Drawing.Color.White
        Me.SaveDocType.selected = False
        Me.SaveDocType.Size = New System.Drawing.Size(59, 28)
        Me.SaveDocType.TabIndex = 17
        Me.SaveDocType.Text = "Save"
        Me.SaveDocType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveDocType.Textcolor = System.Drawing.Color.White
        Me.SaveDocType.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label5.Location = New System.Drawing.Point(26, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Edit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.Label7.Location = New System.Drawing.Point(29, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Doc Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(24, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "________"
        '
        'cardsextension
        '
        Me.cardsextension.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cardsextension.BorderRadius = 10
        Me.cardsextension.BottomSahddow = True
        Me.cardsextension.color = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cardsextension.Controls.Add(Me.ExtensionDataRTB)
        Me.cardsextension.Controls.Add(Me.exclose)
        Me.cardsextension.Controls.Add(Me.SaveExtension)
        Me.cardsextension.Controls.Add(Me.Label9)
        Me.cardsextension.Controls.Add(Me.Label10)
        Me.cardsextension.Controls.Add(Me.Label11)
        Me.BunifuTransition1.SetDecoration(Me.cardsextension, BunifuAnimatorNS.DecorationType.None)
        Me.cardsextension.LeftSahddow = True
        Me.cardsextension.Location = New System.Drawing.Point(346, 227)
        Me.cardsextension.Name = "cardsextension"
        Me.cardsextension.RightSahddow = True
        Me.cardsextension.ShadowDepth = 40
        Me.cardsextension.Size = New System.Drawing.Size(283, 281)
        Me.cardsextension.TabIndex = 32
        '
        'ExtensionDataRTB
        '
        Me.BunifuTransition1.SetDecoration(Me.ExtensionDataRTB, BunifuAnimatorNS.DecorationType.None)
        Me.ExtensionDataRTB.Location = New System.Drawing.Point(34, 85)
        Me.ExtensionDataRTB.Name = "ExtensionDataRTB"
        Me.ExtensionDataRTB.Size = New System.Drawing.Size(218, 139)
        Me.ExtensionDataRTB.TabIndex = 29
        Me.ExtensionDataRTB.Text = ""
        '
        'exclose
        '
        Me.exclose.Activecolor = System.Drawing.Color.Transparent
        Me.exclose.BackColor = System.Drawing.Color.Transparent
        Me.exclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exclose.BorderRadius = 7
        Me.exclose.ButtonText = "x"
        Me.exclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.exclose, BunifuAnimatorNS.DecorationType.None)
        Me.exclose.DisabledColor = System.Drawing.Color.Gray
        Me.exclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exclose.Iconcolor = System.Drawing.Color.Transparent
        Me.exclose.Iconimage = Nothing
        Me.exclose.Iconimage_right = Nothing
        Me.exclose.Iconimage_right_Selected = Nothing
        Me.exclose.Iconimage_Selected = Nothing
        Me.exclose.IconMarginLeft = 0
        Me.exclose.IconMarginRight = 0
        Me.exclose.IconRightVisible = False
        Me.exclose.IconRightZoom = 0R
        Me.exclose.IconVisible = False
        Me.exclose.IconZoom = 90.0R
        Me.exclose.IsTab = False
        Me.exclose.Location = New System.Drawing.Point(250, 6)
        Me.exclose.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.exclose.Name = "exclose"
        Me.exclose.Normalcolor = System.Drawing.Color.Transparent
        Me.exclose.OnHovercolor = System.Drawing.Color.Transparent
        Me.exclose.OnHoverTextColor = System.Drawing.Color.White
        Me.exclose.selected = False
        Me.exclose.Size = New System.Drawing.Size(30, 24)
        Me.exclose.TabIndex = 27
        Me.exclose.Text = "x"
        Me.exclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.exclose.Textcolor = System.Drawing.Color.DarkGray
        Me.exclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        '
        'SaveExtension
        '
        Me.SaveExtension.Activecolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveExtension.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveExtension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveExtension.BorderRadius = 7
        Me.SaveExtension.ButtonText = "Save"
        Me.SaveExtension.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.SaveExtension, BunifuAnimatorNS.DecorationType.None)
        Me.SaveExtension.DisabledColor = System.Drawing.Color.Gray
        Me.SaveExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveExtension.Iconcolor = System.Drawing.Color.Transparent
        Me.SaveExtension.Iconimage = Nothing
        Me.SaveExtension.Iconimage_right = Nothing
        Me.SaveExtension.Iconimage_right_Selected = Nothing
        Me.SaveExtension.Iconimage_Selected = Nothing
        Me.SaveExtension.IconMarginLeft = 0
        Me.SaveExtension.IconMarginRight = 0
        Me.SaveExtension.IconRightVisible = False
        Me.SaveExtension.IconRightZoom = 0R
        Me.SaveExtension.IconVisible = False
        Me.SaveExtension.IconZoom = 90.0R
        Me.SaveExtension.IsTab = False
        Me.SaveExtension.Location = New System.Drawing.Point(193, 236)
        Me.SaveExtension.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveExtension.Name = "SaveExtension"
        Me.SaveExtension.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SaveExtension.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SaveExtension.OnHoverTextColor = System.Drawing.Color.White
        Me.SaveExtension.selected = False
        Me.SaveExtension.Size = New System.Drawing.Size(59, 28)
        Me.SaveExtension.TabIndex = 17
        Me.SaveExtension.Text = "Save"
        Me.SaveExtension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveExtension.Textcolor = System.Drawing.Color.White
        Me.SaveExtension.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label9.Location = New System.Drawing.Point(26, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Edit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.Label10.Location = New System.Drawing.Point(29, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Extension"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(24, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 29)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "________"
        '
        'CustomerEditBtn
        '
        Me.CustomerEditBtn.BackColor = System.Drawing.Color.Transparent
        Me.CustomerEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.CustomerEditBtn, BunifuAnimatorNS.DecorationType.None)
        Me.CustomerEditBtn.Image = Global.SearchEngine.My.Resources.Resources.editicon
        Me.CustomerEditBtn.ImageActive = Nothing
        Me.CustomerEditBtn.Location = New System.Drawing.Point(251, 195)
        Me.CustomerEditBtn.Name = "CustomerEditBtn"
        Me.CustomerEditBtn.Size = New System.Drawing.Size(24, 23)
        Me.CustomerEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CustomerEditBtn.TabIndex = 33
        Me.CustomerEditBtn.TabStop = False
        Me.CustomerEditBtn.Zoom = 10
        '
        'ProjectEditBtn
        '
        Me.ProjectEditBtn.BackColor = System.Drawing.Color.Transparent
        Me.ProjectEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.ProjectEditBtn, BunifuAnimatorNS.DecorationType.None)
        Me.ProjectEditBtn.Image = Global.SearchEngine.My.Resources.Resources.editicon
        Me.ProjectEditBtn.ImageActive = Nothing
        Me.ProjectEditBtn.Location = New System.Drawing.Point(492, 199)
        Me.ProjectEditBtn.Name = "ProjectEditBtn"
        Me.ProjectEditBtn.Size = New System.Drawing.Size(24, 23)
        Me.ProjectEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProjectEditBtn.TabIndex = 34
        Me.ProjectEditBtn.TabStop = False
        Me.ProjectEditBtn.Zoom = 10
        '
        'DocTypeEditBtn
        '
        Me.DocTypeEditBtn.BackColor = System.Drawing.Color.Transparent
        Me.DocTypeEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.DocTypeEditBtn, BunifuAnimatorNS.DecorationType.None)
        Me.DocTypeEditBtn.Image = Global.SearchEngine.My.Resources.Resources.editicon
        Me.DocTypeEditBtn.ImageActive = Nothing
        Me.DocTypeEditBtn.Location = New System.Drawing.Point(737, 195)
        Me.DocTypeEditBtn.Name = "DocTypeEditBtn"
        Me.DocTypeEditBtn.Size = New System.Drawing.Size(24, 23)
        Me.DocTypeEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DocTypeEditBtn.TabIndex = 35
        Me.DocTypeEditBtn.TabStop = False
        Me.DocTypeEditBtn.Zoom = 10
        '
        'ExtensionEditBtn
        '
        Me.ExtensionEditBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExtensionEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.ExtensionEditBtn, BunifuAnimatorNS.DecorationType.None)
        Me.ExtensionEditBtn.Image = Global.SearchEngine.My.Resources.Resources.editicon
        Me.ExtensionEditBtn.ImageActive = Nothing
        Me.ExtensionEditBtn.Location = New System.Drawing.Point(737, 276)
        Me.ExtensionEditBtn.Name = "ExtensionEditBtn"
        Me.ExtensionEditBtn.Size = New System.Drawing.Size(24, 23)
        Me.ExtensionEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExtensionEditBtn.TabIndex = 36
        Me.ExtensionEditBtn.TabStop = False
        Me.ExtensionEditBtn.Zoom = 10
        '
        'drectserverbtn
        '
        Me.drectserverbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.drectserverbtn.BackColor = System.Drawing.Color.Transparent
        Me.drectserverbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.drectserverbtn.BorderRadius = 0
        Me.drectserverbtn.ButtonText = "Server"
        Me.drectserverbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.drectserverbtn, BunifuAnimatorNS.DecorationType.None)
        Me.drectserverbtn.DisabledColor = System.Drawing.Color.Gray
        Me.drectserverbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drectserverbtn.ForeColor = System.Drawing.Color.Transparent
        Me.drectserverbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.drectserverbtn.Iconimage = Nothing
        Me.drectserverbtn.Iconimage_right = Nothing
        Me.drectserverbtn.Iconimage_right_Selected = Nothing
        Me.drectserverbtn.Iconimage_Selected = Nothing
        Me.drectserverbtn.IconMarginLeft = 0
        Me.drectserverbtn.IconMarginRight = 0
        Me.drectserverbtn.IconRightVisible = False
        Me.drectserverbtn.IconRightZoom = 0R
        Me.drectserverbtn.IconVisible = False
        Me.drectserverbtn.IconZoom = 90.0R
        Me.drectserverbtn.IsTab = False
        Me.drectserverbtn.Location = New System.Drawing.Point(427, 115)
        Me.drectserverbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.drectserverbtn.Name = "drectserverbtn"
        Me.drectserverbtn.Normalcolor = System.Drawing.Color.Transparent
        Me.drectserverbtn.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.drectserverbtn.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.drectserverbtn.selected = False
        Me.drectserverbtn.Size = New System.Drawing.Size(56, 20)
        Me.drectserverbtn.TabIndex = 37
        Me.drectserverbtn.Text = "Server"
        Me.drectserverbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.drectserverbtn.Textcolor = System.Drawing.Color.DimGray
        Me.drectserverbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(424, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 29)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "____"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.DataGridView1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 20
        Me.BunifuElipse3.TargetControl = Me.CustomerName
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 20
        Me.BunifuElipse4.TargetControl = Me.PartName
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 20
        Me.BunifuElipse5.TargetControl = Me.ProjectName
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 20
        Me.BunifuElipse6.TargetControl = Me.FileExtension
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 20
        Me.BunifuElipse8.TargetControl = Me.TypeName
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 20
        Me.BunifuElipse9.TargetControl = Me.PartNumber
        '
        'BunifuElipse10
        '
        Me.BunifuElipse10.ElipseRadius = 20
        Me.BunifuElipse10.TargetControl = Me.FolderName
        '
        'StopButton
        '
        Me.StopButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.StopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopButton.BorderRadius = 7
        Me.StopButton.ButtonText = "Stop"
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.StopButton, BunifuAnimatorNS.DecorationType.None)
        Me.StopButton.DisabledColor = System.Drawing.Color.Gray
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Iconcolor = System.Drawing.Color.Transparent
        Me.StopButton.Iconimage = Nothing
        Me.StopButton.Iconimage_right = Nothing
        Me.StopButton.Iconimage_right_Selected = Nothing
        Me.StopButton.Iconimage_Selected = Nothing
        Me.StopButton.IconMarginLeft = 0
        Me.StopButton.IconMarginRight = 0
        Me.StopButton.IconRightVisible = False
        Me.StopButton.IconRightZoom = 0R
        Me.StopButton.IconVisible = False
        Me.StopButton.IconZoom = 90.0R
        Me.StopButton.IsTab = False
        Me.StopButton.Location = New System.Drawing.Point(817, 269)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(5)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.StopButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.StopButton.OnHoverTextColor = System.Drawing.Color.White
        Me.StopButton.selected = False
        Me.StopButton.Size = New System.Drawing.Size(119, 37)
        Me.StopButton.TabIndex = 39
        Me.StopButton.Text = "Stop"
        Me.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StopButton.Textcolor = System.Drawing.Color.White
        Me.StopButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 737)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.drectserverbtn)
        Me.Controls.Add(Me.ExtensionEditBtn)
        Me.Controls.Add(Me.DocTypeEditBtn)
        Me.Controls.Add(Me.ProjectEditBtn)
        Me.Controls.Add(Me.CustomerEditBtn)
        Me.Controls.Add(Me.cardsextension)
        Me.Controls.Add(Me.cardstype)
        Me.Controls.Add(Me.cardsproject)
        Me.Controls.Add(Me.PartNumber)
        Me.Controls.Add(Me.cardseditcust)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.PartName)
        Me.Controls.Add(Me.FileExtension)
        Me.Controls.Add(Me.TypeName)
        Me.Controls.Add(Me.ProjectName)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label12)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.cardseditcust.ResumeLayout(False)
        Me.cardseditcust.PerformLayout()
        Me.cardsproject.ResumeLayout(False)
        Me.cardsproject.PerformLayout()
        Me.cardstype.ResumeLayout(False)
        Me.cardstype.PerformLayout()
        Me.cardsextension.ResumeLayout(False)
        Me.cardsextension.PerformLayout()
        CType(Me.CustomerEditBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectEditBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocTypeEditBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExtensionEditBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents CustomerName As Bunifu.Framework.UI.BunifuDropdown



    Friend WithEvents PartName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents FileExtension As BunifuDropdown
    Friend WithEvents TypeName As BunifuDropdown
    Friend WithEvents ProjectName As BunifuDropdown

    Private Sub BunifuDropdown4_onItemSelected(sender As Object, e As EventArgs) Handles TypeName.onItemSelected

    End Sub

    Private Sub BunifuDropdown3_onItemSelected(sender As Object, e As EventArgs) Handles FileExtension.onItemSelected

    End Sub

    Private Sub BunifuCustomTextbox3_TextChanged(sender As Object, e As EventArgs) Handles PartName.TextChanged

    End Sub

    Private Sub BunifuCustomTextbox2_TextChanged(sender As Object, e As EventArgs) Handles PartNumber.TextChanged

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SearchButton As BunifuFlatButton
    Friend WithEvents SelectFolderButton As BunifuFlatButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents cardseditcust As BunifuCards
    Friend WithEvents SaveCustomer As BunifuFlatButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label2 As Label
    Friend WithEvents Editcustlbl As Label
    Friend WithEvents header As BunifuCards
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BunifuDragControl1 As BunifuDragControl
    Friend WithEvents PartNumber As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuElipse2 As BunifuElipse
    Friend WithEvents BunifuElipse3 As BunifuElipse
    Friend WithEvents BunifuElipse4 As BunifuElipse
    Friend WithEvents BunifuElipse5 As BunifuElipse
    Friend WithEvents BunifuElipse6 As BunifuElipse
    Friend WithEvents BunifuElipse8 As BunifuElipse
    Friend WithEvents BunifuElipse9 As BunifuElipse
    Friend WithEvents BunifuElipse10 As BunifuElipse
    Friend WithEvents MinButton As BunifuFlatButton
    Friend WithEvents CloseButton As BunifuFlatButton
    Friend WithEvents EditButton As BunifuFlatButton
    Friend WithEvents RefreshButton As BunifuFlatButton
    Friend WithEvents custclose As BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents garislbl As Label
    Friend WithEvents cardsproject As BunifuCards
    Friend WithEvents ProjectDataRTB As RichTextBox
    Friend WithEvents projectclose As BunifuFlatButton
    Friend WithEvents SaveProject As BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CustomerDataRTB As RichTextBox
    Friend WithEvents cardsextension As BunifuCards
    Friend WithEvents ExtensionDataRTB As RichTextBox
    Friend WithEvents exclose As BunifuFlatButton
    Friend WithEvents SaveExtension As BunifuFlatButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cardstype As BunifuCards
    Friend WithEvents DocTypeDataRTB As RichTextBox
    Friend WithEvents typeclose As BunifuFlatButton
    Friend WithEvents SaveDocType As BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CustomerEditBtn As BunifuImageButton
    Friend WithEvents ExtensionEditBtn As BunifuImageButton
    Friend WithEvents DocTypeEditBtn As BunifuImageButton
    Friend WithEvents ProjectEditBtn As BunifuImageButton
    Friend WithEvents drectserverbtn As BunifuFlatButton
    Friend WithEvents Label12 As Label
    Friend WithEvents StopButton As BunifuFlatButton
End Class
