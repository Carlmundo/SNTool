<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Production))
        Me.lstName = New System.Windows.Forms.ListBox
        Me.CMenu_List = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMenu_List_AddItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CMenu_List_RemoveItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSet = New System.Windows.Forms.Button
        Me.lblTitleSerial = New System.Windows.Forms.Label
        Me.cmdOEM = New System.Windows.Forms.Button
        Me.txtSerial = New System.Windows.Forms.MaskedTextBox
        Me.CMenu_Serial = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMenu_Serial_Cut = New System.Windows.Forms.ToolStripMenuItem
        Me.CMenu_Serial_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.CMenu_Serial_Paste = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CMenu_Serial_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClear = New System.Windows.Forms.Button
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.Menu_Items = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Items_AddItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Items_RemoveItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Edit = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Edit_Cut = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Edit_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Edit_Paste = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.Menu_Edit_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_View = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_View_CustomerView = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Help = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Help_HowToUse = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.Menu_Help_About = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.lblPath = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdExport = New System.Windows.Forms.Button
        Me.flwSalesOrder = New System.Windows.Forms.FlowLayoutPanel
        Me.lblSalesOrder = New System.Windows.Forms.Label
        Me.txtSalesOrder = New System.Windows.Forms.TextBox
        Me.PrintList = New System.Drawing.Printing.PrintDocument
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.sfdExport = New System.Windows.Forms.SaveFileDialog
        Me.CMenu_List.SuspendLayout()
        Me.CMenu_Serial.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.tblDesign.SuspendLayout()
        Me.flwButtons.SuspendLayout()
        Me.flwSalesOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstName.ContextMenuStrip = Me.CMenu_List
        Me.lstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 16
        Me.lstName.Location = New System.Drawing.Point(16, 89)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(432, 212)
        Me.lstName.TabIndex = 1
        '
        'CMenu_List
        '
        Me.CMenu_List.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMenu_List_AddItem, Me.CMenu_List_RemoveItem})
        Me.CMenu_List.Name = "ContextMenuList"
        Me.CMenu_List.Size = New System.Drawing.Size(169, 48)
        '
        'CMenu_List_AddItem
        '
        Me.CMenu_List_AddItem.Image = CType(resources.GetObject("CMenu_List_AddItem.Image"), System.Drawing.Image)
        Me.CMenu_List_AddItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CMenu_List_AddItem.Name = "CMenu_List_AddItem"
        Me.CMenu_List_AddItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.CMenu_List_AddItem.Size = New System.Drawing.Size(168, 22)
        Me.CMenu_List_AddItem.Text = "Add Item"
        '
        'CMenu_List_RemoveItem
        '
        Me.CMenu_List_RemoveItem.Enabled = False
        Me.CMenu_List_RemoveItem.Image = CType(resources.GetObject("CMenu_List_RemoveItem.Image"), System.Drawing.Image)
        Me.CMenu_List_RemoveItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CMenu_List_RemoveItem.Name = "CMenu_List_RemoveItem"
        Me.CMenu_List_RemoveItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.CMenu_List_RemoveItem.Size = New System.Drawing.Size(168, 22)
        Me.CMenu_List_RemoveItem.Text = "Remove Item"
        '
        'cmdSet
        '
        Me.cmdSet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSet.AutoSize = True
        Me.cmdSet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSet.Location = New System.Drawing.Point(98, 3)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(89, 46)
        Me.cmdSet.TabIndex = 1
        Me.cmdSet.Text = "Save"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'lblTitleSerial
        '
        Me.lblTitleSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleSerial.AutoSize = True
        Me.lblTitleSerial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSerial.Location = New System.Drawing.Point(182, 304)
        Me.lblTitleSerial.Name = "lblTitleSerial"
        Me.lblTitleSerial.Size = New System.Drawing.Size(100, 16)
        Me.lblTitleSerial.TabIndex = 2
        Me.lblTitleSerial.Text = "Serial Number"
        Me.lblTitleSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdOEM
        '
        Me.cmdOEM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOEM.AutoSize = True
        Me.cmdOEM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOEM.Location = New System.Drawing.Point(3, 13)
        Me.cmdOEM.Name = "cmdOEM"
        Me.cmdOEM.Size = New System.Drawing.Size(89, 26)
        Me.cmdOEM.TabIndex = 0
        Me.cmdOEM.Text = "Use OEM"
        Me.cmdOEM.UseVisualStyleBackColor = True
        '
        'txtSerial
        '
        Me.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSerial.BeepOnError = True
        Me.txtSerial.ContextMenuStrip = Me.CMenu_Serial
        Me.txtSerial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtSerial.Location = New System.Drawing.Point(56, 323)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ResetOnSpace = False
        Me.txtSerial.ShortcutsEnabled = False
        Me.txtSerial.Size = New System.Drawing.Size(352, 22)
        Me.txtSerial.TabIndex = 3
        Me.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMenu_Serial
        '
        Me.CMenu_Serial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMenu_Serial_Cut, Me.CMenu_Serial_Copy, Me.CMenu_Serial_Paste, Me.ToolStripSeparator3, Me.CMenu_Serial_SelectAll})
        Me.CMenu_Serial.Name = "ContextMenuSerial"
        Me.CMenu_Serial.Size = New System.Drawing.Size(165, 98)
        '
        'CMenu_Serial_Cut
        '
        Me.CMenu_Serial_Cut.Image = CType(resources.GetObject("CMenu_Serial_Cut.Image"), System.Drawing.Image)
        Me.CMenu_Serial_Cut.ImageTransparentColor = System.Drawing.Color.Black
        Me.CMenu_Serial_Cut.Name = "CMenu_Serial_Cut"
        Me.CMenu_Serial_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CMenu_Serial_Cut.Size = New System.Drawing.Size(164, 22)
        Me.CMenu_Serial_Cut.Text = "Cu&t"
        '
        'CMenu_Serial_Copy
        '
        Me.CMenu_Serial_Copy.Image = CType(resources.GetObject("CMenu_Serial_Copy.Image"), System.Drawing.Image)
        Me.CMenu_Serial_Copy.ImageTransparentColor = System.Drawing.Color.Black
        Me.CMenu_Serial_Copy.Name = "CMenu_Serial_Copy"
        Me.CMenu_Serial_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CMenu_Serial_Copy.Size = New System.Drawing.Size(164, 22)
        Me.CMenu_Serial_Copy.Text = "&Copy"
        '
        'CMenu_Serial_Paste
        '
        Me.CMenu_Serial_Paste.Image = CType(resources.GetObject("CMenu_Serial_Paste.Image"), System.Drawing.Image)
        Me.CMenu_Serial_Paste.ImageTransparentColor = System.Drawing.Color.Black
        Me.CMenu_Serial_Paste.Name = "CMenu_Serial_Paste"
        Me.CMenu_Serial_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CMenu_Serial_Paste.Size = New System.Drawing.Size(164, 22)
        Me.CMenu_Serial_Paste.Text = "&Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'CMenu_Serial_SelectAll
        '
        Me.CMenu_Serial_SelectAll.Name = "CMenu_Serial_SelectAll"
        Me.CMenu_Serial_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CMenu_Serial_SelectAll.Size = New System.Drawing.Size(164, 22)
        Me.CMenu_Serial_SelectAll.Text = "Select &All"
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClear.AutoSize = True
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(193, 13)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(89, 26)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "Delete Key"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(42, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(381, 46)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 18
        Me.pbLogo.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Items, Me.Menu_Edit, Me.Menu_View, Me.Menu_Help})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(465, 24)
        Me.MenuStrip.TabIndex = 30
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'Menu_Items
        '
        Me.Menu_Items.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Items_AddItem, Me.Menu_Items_RemoveItem})
        Me.Menu_Items.Name = "Menu_Items"
        Me.Menu_Items.Size = New System.Drawing.Size(48, 20)
        Me.Menu_Items.Text = "Items"
        '
        'Menu_Items_AddItem
        '
        Me.Menu_Items_AddItem.Image = CType(resources.GetObject("Menu_Items_AddItem.Image"), System.Drawing.Image)
        Me.Menu_Items_AddItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Items_AddItem.Name = "Menu_Items_AddItem"
        Me.Menu_Items_AddItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.Menu_Items_AddItem.Size = New System.Drawing.Size(168, 22)
        Me.Menu_Items_AddItem.Text = "Add Item"
        '
        'Menu_Items_RemoveItem
        '
        Me.Menu_Items_RemoveItem.Enabled = False
        Me.Menu_Items_RemoveItem.Image = CType(resources.GetObject("Menu_Items_RemoveItem.Image"), System.Drawing.Image)
        Me.Menu_Items_RemoveItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Items_RemoveItem.Name = "Menu_Items_RemoveItem"
        Me.Menu_Items_RemoveItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.Menu_Items_RemoveItem.Size = New System.Drawing.Size(168, 22)
        Me.Menu_Items_RemoveItem.Text = "Remove Item"
        '
        'Menu_Edit
        '
        Me.Menu_Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Edit_Cut, Me.Menu_Edit_Copy, Me.Menu_Edit_Paste, Me.ToolStripSeparator5, Me.Menu_Edit_SelectAll})
        Me.Menu_Edit.Name = "Menu_Edit"
        Me.Menu_Edit.Size = New System.Drawing.Size(39, 20)
        Me.Menu_Edit.Text = "&Edit"
        '
        'Menu_Edit_Cut
        '
        Me.Menu_Edit_Cut.Image = CType(resources.GetObject("Menu_Edit_Cut.Image"), System.Drawing.Image)
        Me.Menu_Edit_Cut.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Edit_Cut.Name = "Menu_Edit_Cut"
        Me.Menu_Edit_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Menu_Edit_Cut.Size = New System.Drawing.Size(164, 22)
        Me.Menu_Edit_Cut.Text = "Cu&t"
        '
        'Menu_Edit_Copy
        '
        Me.Menu_Edit_Copy.Image = CType(resources.GetObject("Menu_Edit_Copy.Image"), System.Drawing.Image)
        Me.Menu_Edit_Copy.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Edit_Copy.Name = "Menu_Edit_Copy"
        Me.Menu_Edit_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Menu_Edit_Copy.Size = New System.Drawing.Size(164, 22)
        Me.Menu_Edit_Copy.Text = "&Copy"
        '
        'Menu_Edit_Paste
        '
        Me.Menu_Edit_Paste.Image = CType(resources.GetObject("Menu_Edit_Paste.Image"), System.Drawing.Image)
        Me.Menu_Edit_Paste.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Edit_Paste.Name = "Menu_Edit_Paste"
        Me.Menu_Edit_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Menu_Edit_Paste.Size = New System.Drawing.Size(164, 22)
        Me.Menu_Edit_Paste.Text = "&Paste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(161, 6)
        '
        'Menu_Edit_SelectAll
        '
        Me.Menu_Edit_SelectAll.Name = "Menu_Edit_SelectAll"
        Me.Menu_Edit_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.Menu_Edit_SelectAll.Size = New System.Drawing.Size(164, 22)
        Me.Menu_Edit_SelectAll.Text = "Select &All"
        '
        'Menu_View
        '
        Me.Menu_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_View_CustomerView})
        Me.Menu_View.Name = "Menu_View"
        Me.Menu_View.Size = New System.Drawing.Size(44, 20)
        Me.Menu_View.Text = "&View"
        '
        'Menu_View_CustomerView
        '
        Me.Menu_View_CustomerView.Name = "Menu_View_CustomerView"
        Me.Menu_View_CustomerView.Size = New System.Drawing.Size(154, 22)
        Me.Menu_View_CustomerView.Text = "Customer View"
        '
        'Menu_Help
        '
        Me.Menu_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Help_HowToUse, Me.ToolStripSeparator6, Me.Menu_Help_About})
        Me.Menu_Help.Name = "Menu_Help"
        Me.Menu_Help.Size = New System.Drawing.Size(44, 20)
        Me.Menu_Help.Text = "&Help"
        '
        'Menu_Help_HowToUse
        '
        Me.Menu_Help_HowToUse.Image = CType(resources.GetObject("Menu_Help_HowToUse.Image"), System.Drawing.Image)
        Me.Menu_Help_HowToUse.ImageTransparentColor = System.Drawing.Color.Black
        Me.Menu_Help_HowToUse.Name = "Menu_Help_HowToUse"
        Me.Menu_Help_HowToUse.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.Menu_Help_HowToUse.Size = New System.Drawing.Size(157, 22)
        Me.Menu_Help_HowToUse.Text = "How To Use"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(154, 6)
        '
        'Menu_Help_About
        '
        Me.Menu_Help_About.Name = "Menu_Help_About"
        Me.Menu_Help_About.Size = New System.Drawing.Size(157, 22)
        Me.Menu_Help_About.Text = "&About"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 464)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(465, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblPath
        '
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(81, 17)
        Me.lblPath.Text = "{Launch Path}"
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 5)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.cmdExport, 0, 6)
        Me.tblDesign.Controls.Add(Me.lblTitleSerial, 0, 3)
        Me.tblDesign.Controls.Add(Me.txtSerial, 0, 4)
        Me.tblDesign.Controls.Add(Me.lstName, 0, 2)
        Me.tblDesign.Controls.Add(Me.flwSalesOrder, 0, 1)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 24)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 7
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.Size = New System.Drawing.Size(465, 440)
        Me.tblDesign.TabIndex = 0
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdOEM)
        Me.flwButtons.Controls.Add(Me.cmdSet)
        Me.flwButtons.Controls.Add(Me.cmdClear)
        Me.flwButtons.Location = New System.Drawing.Point(90, 351)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(285, 52)
        Me.flwButtons.TabIndex = 4
        Me.flwButtons.WrapContents = False
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExport.AutoSize = True
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Location = New System.Drawing.Point(188, 410)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(89, 26)
        Me.cmdExport.TabIndex = 5
        Me.cmdExport.Text = " Export"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'flwSalesOrder
        '
        Me.flwSalesOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwSalesOrder.AutoSize = True
        Me.flwSalesOrder.Controls.Add(Me.lblSalesOrder)
        Me.flwSalesOrder.Controls.Add(Me.txtSalesOrder)
        Me.flwSalesOrder.Location = New System.Drawing.Point(120, 55)
        Me.flwSalesOrder.Name = "flwSalesOrder"
        Me.flwSalesOrder.Size = New System.Drawing.Size(225, 28)
        Me.flwSalesOrder.TabIndex = 0
        '
        'lblSalesOrder
        '
        Me.lblSalesOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSalesOrder.AutoSize = True
        Me.lblSalesOrder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesOrder.Location = New System.Drawing.Point(3, 6)
        Me.lblSalesOrder.Name = "lblSalesOrder"
        Me.lblSalesOrder.Size = New System.Drawing.Size(108, 16)
        Me.lblSalesOrder.TabIndex = 0
        Me.lblSalesOrder.Text = "Sales Order No."
        Me.lblSalesOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesOrder
        '
        Me.txtSalesOrder.Location = New System.Drawing.Point(117, 3)
        Me.txtSalesOrder.Name = "txtSalesOrder"
        Me.txtSalesOrder.Size = New System.Drawing.Size(105, 22)
        Me.txtSalesOrder.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(274, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(8, 8)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'sfdExport
        '
        Me.sfdExport.DefaultExt = "txt"
        Me.sfdExport.Filter = """Text Documents (*.txt)""|"
        Me.sfdExport.InitialDirectory = "Q:\Production Scans"
        '
        'Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 486)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.tblDesign)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Production"
        Me.Text = "SN Tool"
        Me.CMenu_List.ResumeLayout(False)
        Me.CMenu_Serial.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        Me.flwSalesOrder.ResumeLayout(False)
        Me.flwSalesOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents lblTitleSerial As System.Windows.Forms.Label
    Friend WithEvents cmdOEM As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtSerial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents CMenu_Serial As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMenu_Serial_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMenu_Serial_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMenu_Serial_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CMenu_Serial_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMenu_List As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMenu_List_AddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMenu_List_RemoveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPath As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Menu_Items As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Items_AddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Items_RemoveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Edit_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Edit_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Edit_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Menu_Edit_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_View_CustomerView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Help_HowToUse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Menu_Help_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents PrintList As System.Drawing.Printing.PrintDocument
    Friend WithEvents flwSalesOrder As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtSalesOrder As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblSalesOrder As System.Windows.Forms.Label
    Friend WithEvents sfdExport As System.Windows.Forms.SaveFileDialog


   

End Class
