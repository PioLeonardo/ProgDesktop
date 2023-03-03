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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDateTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNotepadKuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLine = New System.Windows.Forms.ToolStripStatusLabel()
        Me.insertStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.capsStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.numStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtNotepad = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        Me.SaveasToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveasToolStripMenuItem.Text = "Save &as..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.PageSetupToolStripMenuItem.Text = "&Page Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.PrintToolStripMenuItem.Text = "P&rint"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.FindToolStripMenuItem, Me.FindNextToolStripMenuItem, Me.ReplaceToolStripMenuItem, Me.GoToToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.InsertDateTimeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CutToolStripMenuItem.Text = "&Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CopyToolStripMenuItem.Text = "C&opy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.FindToolStripMenuItem.Text = "&Find..."
        '
        'FindNextToolStripMenuItem
        '
        Me.FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        Me.FindNextToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.FindNextToolStripMenuItem.Text = "Find &Next"
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ReplaceToolStripMenuItem.Text = "&Replace..."
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.GoToToolStripMenuItem.Text = "&Go To..."
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.SelectAllToolStripMenuItem.Text = "&Select All"
        '
        'InsertDateTimeToolStripMenuItem
        '
        Me.InsertDateTimeToolStripMenuItem.Name = "InsertDateTimeToolStripMenuItem"
        Me.InsertDateTimeToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.InsertDateTimeToolStripMenuItem.Text = "Insert Date &Time"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(70, 26)
        Me.FormatToolStripMenuItem.Text = "&Format"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.WordToolStripMenuItem.Text = "&Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.FontToolStripMenuItem.Text = "F&ont"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.StatusBarToolStripMenuItem.Text = "&Status bar"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutNotepadKuToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.HelpToolStripMenuItem.Text = "&Help..."
        '
        'AboutNotepadKuToolStripMenuItem
        '
        Me.AboutNotepadKuToolStripMenuItem.Name = "AboutNotepadKuToolStripMenuItem"
        Me.AboutNotepadKuToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.AboutNotepadKuToolStripMenuItem.Text = "About NotepadKu"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusReady, Me.ToolStripStatusLine, Me.insertStripStatus, Me.capsStripStatus, Me.numStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 30)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusReady
        '
        Me.ToolStripStatusReady.Name = "ToolStripStatusReady"
        Me.ToolStripStatusReady.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripStatusReady.Text = "Ready."
        '
        'ToolStripStatusLine
        '
        Me.ToolStripStatusLine.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLine.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLine.Name = "ToolStripStatusLine"
        Me.ToolStripStatusLine.Size = New System.Drawing.Size(55, 24)
        Me.ToolStripStatusLine.Text = "Line: 1"
        '
        'insertStripStatus
        '
        Me.insertStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.insertStripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.insertStripStatus.Enabled = False
        Me.insertStripStatus.Name = "insertStripStatus"
        Me.insertStripStatus.Size = New System.Drawing.Size(36, 24)
        Me.insertStripStatus.Text = "INS"
        '
        'capsStripStatus
        '
        Me.capsStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.capsStripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.capsStripStatus.Enabled = False
        Me.capsStripStatus.Name = "capsStripStatus"
        Me.capsStripStatus.Size = New System.Drawing.Size(48, 24)
        Me.capsStripStatus.Text = "CAPS"
        '
        'numStripStatus
        '
        Me.numStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.numStripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.numStripStatus.Enabled = False
        Me.numStripStatus.Name = "numStripStatus"
        Me.numStripStatus.Size = New System.Drawing.Size(47, 24)
        Me.numStripStatus.Text = "NUM"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.txt"
        Me.OpenFileDialog1.FileName = "Untitled"
        Me.OpenFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        Me.OpenFileDialog1.Title = "Open File Text"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.EnableMetric = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.FileName = "Untitled.txt"
        Me.SaveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        Me.SaveFileDialog1.Title = "Save File Text as"
        '
        'PrintDocument1
        '
        '
        'txtNotepad
        '
        Me.txtNotepad.AcceptsReturn = True
        Me.txtNotepad.AcceptsTab = True
        Me.txtNotepad.AllowDrop = True
        Me.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotepad.Location = New System.Drawing.Point(0, 30)
        Me.txtNotepad.Multiline = True
        Me.txtNotepad.Name = "txtNotepad"
        Me.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotepad.Size = New System.Drawing.Size(800, 390)
        Me.txtNotepad.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNotepad)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "NotepadKu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotepadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtNotepad As TextBox
End Class
