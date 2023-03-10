<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.chFileName2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSize2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbFileName = New System.Windows.Forms.TabPage()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.tbExtension = New System.Windows.Forms.TabPage()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.tbAutoNumber = New System.Windows.Forms.TabPage()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lbIncrementBy = New System.Windows.Forms.Label()
        Me.lbStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbFileName.SuspendLayout()
        Me.tbExtension.SuspendLayout()
        Me.tbAutoNumber.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 9)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(40, 16)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path: "
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(59, 9)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(554, 22)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(619, 9)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(41, 23)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(666, 12)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(53, 16)
        Me.lblExt.TabIndex = 3
        Me.lblExt.Text = "File Ext:"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(722, 9)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(63, 22)
        Me.txtExt.TabIndex = 4
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(26, 43)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(81, 16)
        Me.lblOri.TabIndex = 5
        Me.lblOri.Text = "Original File:"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(415, 43)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(83, 16)
        Me.lblPreview.TabIndex = 6
        Me.lblPreview.Text = "Preview File:"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chSize, Me.chAttributes, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(29, 62)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(380, 226)
        Me.lvOri.TabIndex = 7
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        Me.chFileName.Width = 52
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        Me.chExtension.Width = 48
        '
        'chSize
        '
        Me.chSize.Text = "Size"
        Me.chSize.Width = 46
        '
        'chAttributes
        '
        Me.chAttributes.Text = "Attributes"
        Me.chAttributes.Width = 43
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        Me.chCreated.Width = 50
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        Me.chAccessed.Width = 47
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        Me.chModified.Width = 51
        '
        'lvPreview
        '
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName2, Me.chExtension2, Me.chSize2, Me.chAttributes2, Me.chCreated2, Me.chAccessed2, Me.chModified2})
        Me.lvPreview.GridLines = True
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(415, 62)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(370, 226)
        Me.lvPreview.TabIndex = 8
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'chFileName2
        '
        Me.chFileName2.Text = "File Name"
        '
        'chExtension2
        '
        Me.chExtension2.Text = "Extension"
        '
        'chSize2
        '
        Me.chSize2.Text = "Size"
        '
        'chAttributes2
        '
        Me.chAttributes2.Text = "Attributes"
        '
        'chCreated2
        '
        Me.chCreated2.Text = "Date Created"
        '
        'chAccessed2
        '
        Me.chAccessed2.Text = "Date Accessed"
        '
        'chModified2
        '
        Me.chModified2.Text = "Date Modified"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbFileName)
        Me.TabControl1.Controls.Add(Me.tbExtension)
        Me.TabControl1.Controls.Add(Me.tbAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(15, 304)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(670, 145)
        Me.TabControl1.TabIndex = 9
        '
        'tbFileName
        '
        Me.tbFileName.Controls.Add(Me.cbCaseF)
        Me.tbFileName.Controls.Add(Me.txtInsertBeforeF)
        Me.tbFileName.Controls.Add(Me.txtRightCropNCharF)
        Me.tbFileName.Controls.Add(Me.txtInsertAfterF)
        Me.tbFileName.Controls.Add(Me.txtLeftCropNCharF)
        Me.tbFileName.Controls.Add(Me.txtWithThisF)
        Me.tbFileName.Controls.Add(Me.txtReplaceThisF)
        Me.tbFileName.Controls.Add(Me.txtReplaceWithF)
        Me.tbFileName.Controls.Add(Me.lblCaseF)
        Me.tbFileName.Controls.Add(Me.lblWithThisF)
        Me.tbFileName.Controls.Add(Me.rbRightCropNCharF)
        Me.tbFileName.Controls.Add(Me.rbLeftCropNCharF)
        Me.tbFileName.Controls.Add(Me.rbInsertAfterF)
        Me.tbFileName.Controls.Add(Me.rbInsertBeforeF)
        Me.tbFileName.Controls.Add(Me.rbReplaceThisF)
        Me.tbFileName.Controls.Add(Me.rbReplaceWithF)
        Me.tbFileName.Location = New System.Drawing.Point(4, 25)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFileName.Size = New System.Drawing.Size(662, 116)
        Me.tbFileName.TabIndex = 0
        Me.tbFileName.Text = "Filename"
        Me.tbFileName.UseVisualStyleBackColor = True
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(501, 6)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(155, 24)
        Me.cbCaseF.TabIndex = 15
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(127, 57)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(263, 22)
        Me.txtInsertBeforeF.TabIndex = 14
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(533, 82)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(123, 22)
        Me.txtRightCropNCharF.TabIndex = 13
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(495, 58)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(161, 22)
        Me.txtInsertAfterF.TabIndex = 12
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(127, 82)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(97, 22)
        Me.txtLeftCropNCharF.TabIndex = 11
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(454, 33)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(202, 22)
        Me.txtWithThisF.TabIndex = 10
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(127, 32)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(263, 22)
        Me.txtReplaceThisF.TabIndex = 9
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(127, 4)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(321, 22)
        Me.txtReplaceWithF.TabIndex = 8
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(453, 10)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(42, 16)
        Me.lblCaseF.TabIndex = 7
        Me.lblCaseF.Text = "Case:"
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(396, 39)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(52, 16)
        Me.lblWithThisF.TabIndex = 6
        Me.lblWithThisF.Text = "with this"
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(399, 84)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(128, 20)
        Me.rbRightCropNCharF.TabIndex = 5
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right crop n char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(10, 84)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(118, 20)
        Me.rbLeftCropNCharF.TabIndex = 4
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left crop n char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertAfterF
        '
        Me.rbInsertAfterF.AutoSize = True
        Me.rbInsertAfterF.Location = New System.Drawing.Point(399, 58)
        Me.rbInsertAfterF.Name = "rbInsertAfterF"
        Me.rbInsertAfterF.Size = New System.Drawing.Size(90, 20)
        Me.rbInsertAfterF.TabIndex = 3
        Me.rbInsertAfterF.TabStop = True
        Me.rbInsertAfterF.Text = "Insert After"
        Me.rbInsertAfterF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(10, 58)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(103, 20)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.TabStop = True
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(10, 32)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "Replace This"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.AutoSize = True
        Me.rbReplaceWithF.Location = New System.Drawing.Point(10, 6)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace With"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'tbExtension
        '
        Me.tbExtension.Controls.Add(Me.cbCaseE)
        Me.tbExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.tbExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.tbExtension.Controls.Add(Me.txtInsertAfterE)
        Me.tbExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.tbExtension.Controls.Add(Me.txtWithThisE)
        Me.tbExtension.Controls.Add(Me.txtReplaceThisE)
        Me.tbExtension.Controls.Add(Me.txtReplaceWithE)
        Me.tbExtension.Controls.Add(Me.lblCaseE)
        Me.tbExtension.Controls.Add(Me.lblWithThisE)
        Me.tbExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.tbExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.tbExtension.Controls.Add(Me.rbInsertAfterE)
        Me.tbExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.tbExtension.Controls.Add(Me.rbReplaceThisE)
        Me.tbExtension.Controls.Add(Me.rbReplaceWithE)
        Me.tbExtension.Location = New System.Drawing.Point(4, 25)
        Me.tbExtension.Name = "tbExtension"
        Me.tbExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExtension.Size = New System.Drawing.Size(662, 116)
        Me.tbExtension.TabIndex = 1
        Me.tbExtension.Text = "Extension"
        Me.tbExtension.UseVisualStyleBackColor = True
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(499, 10)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(155, 24)
        Me.cbCaseE.TabIndex = 31
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(125, 61)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(263, 22)
        Me.txtInsertBeforeE.TabIndex = 30
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(531, 86)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(123, 22)
        Me.txtRightCropNCharE.TabIndex = 29
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(493, 62)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(161, 22)
        Me.txtInsertAfterE.TabIndex = 28
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(125, 86)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(97, 22)
        Me.txtLeftCropNCharE.TabIndex = 27
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(452, 37)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(202, 22)
        Me.txtWithThisE.TabIndex = 26
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(125, 36)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(263, 22)
        Me.txtReplaceThisE.TabIndex = 25
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(125, 8)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(321, 22)
        Me.txtReplaceWithE.TabIndex = 24
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(451, 14)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(42, 16)
        Me.lblCaseE.TabIndex = 23
        Me.lblCaseE.Text = "Case:"
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(394, 43)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(52, 16)
        Me.lblWithThisE.TabIndex = 22
        Me.lblWithThisE.Text = "with this"
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(397, 88)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(128, 20)
        Me.rbRightCropNCharE.TabIndex = 21
        Me.rbRightCropNCharE.Text = "Right crop n char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(8, 88)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(118, 20)
        Me.rbLeftCropNCharE.TabIndex = 20
        Me.rbLeftCropNCharE.Text = "Left crop n char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(397, 62)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(90, 20)
        Me.rbInsertAfterE.TabIndex = 19
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(8, 62)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(103, 20)
        Me.rbInsertBeforeE.TabIndex = 18
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(8, 36)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceThisE.TabIndex = 17
        Me.rbReplaceThisE.Text = "Replace This"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Checked = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(8, 10)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(109, 20)
        Me.rbReplaceWithE.TabIndex = 16
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'tbAutoNumber
        '
        Me.tbAutoNumber.Controls.Add(Me.gbWith)
        Me.tbAutoNumber.Controls.Add(Me.gbPlace)
        Me.tbAutoNumber.Location = New System.Drawing.Point(4, 25)
        Me.tbAutoNumber.Name = "tbAutoNumber"
        Me.tbAutoNumber.Size = New System.Drawing.Size(662, 116)
        Me.tbAutoNumber.TabIndex = 2
        Me.tbAutoNumber.Text = "Autonumber"
        Me.tbAutoNumber.UseVisualStyleBackColor = True
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lbIncrementBy)
        Me.gbWith.Controls.Add(Me.lbStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(167, 9)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Size = New System.Drawing.Size(474, 100)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With:"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(140, 52)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 22)
        Me.nudIncrementBy.TabIndex = 3
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(140, 24)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 22)
        Me.nudStartWithNumber.TabIndex = 2
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbIncrementBy
        '
        Me.lbIncrementBy.AutoSize = True
        Me.lbIncrementBy.Location = New System.Drawing.Point(24, 56)
        Me.lbIncrementBy.Name = "lbIncrementBy"
        Me.lbIncrementBy.Size = New System.Drawing.Size(86, 16)
        Me.lbIncrementBy.TabIndex = 1
        Me.lbIncrementBy.Text = "Increment by:"
        '
        'lbStartWithNumber
        '
        Me.lbStartWithNumber.AutoSize = True
        Me.lbStartWithNumber.Location = New System.Drawing.Point(24, 30)
        Me.lbStartWithNumber.Name = "lbStartWithNumber"
        Me.lbStartWithNumber.Size = New System.Drawing.Size(110, 16)
        Me.lbStartWithNumber.TabIndex = 0
        Me.lbStartWithNumber.Text = "Start with number:"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(10, 9)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(151, 100)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place:"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(6, 56)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(122, 20)
        Me.rbBeforeFileName.TabIndex = 18
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(6, 30)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(109, 20)
        Me.rbAfterFileName.TabIndex = 17
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(691, 319)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(94, 23)
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(691, 348)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(94, 23)
        Me.btnRename.TabIndex = 11
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(691, 377)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(94, 23)
        Me.btnUndo.TabIndex = 12
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.lblExt)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabControl1.ResumeLayout(False)
        Me.tbFileName.ResumeLayout(False)
        Me.tbFileName.PerformLayout()
        Me.tbExtension.ResumeLayout(False)
        Me.tbExtension.PerformLayout()
        Me.tbAutoNumber.ResumeLayout(False)
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chSize As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chSize2 As ColumnHeader
    Friend WithEvents chAttributes2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbFileName As TabPage
    Friend WithEvents tbExtension As TabPage
    Friend WithEvents tbAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lbIncrementBy As Label
    Friend WithEvents lbStartWithNumber As Label
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
End Class
