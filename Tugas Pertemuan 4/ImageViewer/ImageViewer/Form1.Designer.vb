<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDimension = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusBits = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusResolution = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusRawFormat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainerUtama = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.lvImage = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAtrributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvExif = New System.Windows.Forms.ListView()
        Me.chProperty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUtama.Panel1.SuspendLayout()
        Me.SplitContainerUtama.Panel2.SuspendLayout()
        Me.SplitContainerUtama.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "285678_drive_icon.png")
        Me.ImageList1.Images.SetKeyName(1, "299060_folder_icon.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusReady, Me.ToolStripStatusDimension, Me.ToolStripStatusBits, Me.ToolStripStatusResolution, Me.ToolStripStatusRawFormat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 30)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusReady
        '
        Me.ToolStripStatusReady.Name = "ToolStripStatusReady"
        Me.ToolStripStatusReady.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripStatusReady.Text = "Ready."
        '
        'ToolStripStatusDimension
        '
        Me.ToolStripStatusDimension.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusDimension.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusDimension.Name = "ToolStripStatusDimension"
        Me.ToolStripStatusDimension.Size = New System.Drawing.Size(97, 24)
        Me.ToolStripStatusDimension.Text = "Dimensions: "
        '
        'ToolStripStatusBits
        '
        Me.ToolStripStatusBits.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusBits.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusBits.Name = "ToolStripStatusBits"
        Me.ToolStripStatusBits.Size = New System.Drawing.Size(68, 24)
        Me.ToolStripStatusBits.Text = "# of bits"
        '
        'ToolStripStatusResolution
        '
        Me.ToolStripStatusResolution.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusResolution.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusResolution.Name = "ToolStripStatusResolution"
        Me.ToolStripStatusResolution.Size = New System.Drawing.Size(83, 24)
        Me.ToolStripStatusResolution.Text = "Resolution"
        '
        'ToolStripStatusRawFormat
        '
        Me.ToolStripStatusRawFormat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusRawFormat.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusRawFormat.Name = "ToolStripStatusRawFormat"
        Me.ToolStripStatusRawFormat.Size = New System.Drawing.Size(92, 24)
        Me.ToolStripStatusRawFormat.Text = "Raw Format"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        '
        'SplitContainerUtama
        '
        Me.SplitContainerUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUtama.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerUtama.Name = "SplitContainerUtama"
        '
        'SplitContainerUtama.Panel1
        '
        Me.SplitContainerUtama.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainerUtama.Panel2
        '
        Me.SplitContainerUtama.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainerUtama.Size = New System.Drawing.Size(800, 420)
        Me.SplitContainerUtama.SplitterDistance = 266
        Me.SplitContainerUtama.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvImage)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(530, 420)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvExif)
        Me.SplitContainer2.Size = New System.Drawing.Size(530, 166)
        Me.SplitContainer2.SplitterDistance = 176
        Me.SplitContainer2.TabIndex = 0
        '
        'tvDrive
        '
        Me.tvDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.ImageList1
        Me.tvDrive.Location = New System.Drawing.Point(0, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(266, 420)
        Me.tvDrive.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvDrive, "Please select drive/folder that contain one or more images")
        '
        'lvImage
        '
        Me.lvImage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chExtension, Me.chFileSize, Me.chLastModified, Me.chLastAccessed, Me.chCreatedDate, Me.chAtrributes})
        Me.lvImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvImage.GridLines = True
        Me.lvImage.HideSelection = False
        Me.lvImage.Location = New System.Drawing.Point(0, 0)
        Me.lvImage.Name = "lvImage"
        Me.lvImage.Size = New System.Drawing.Size(530, 250)
        Me.lvImage.SmallImageList = Me.ImageList1
        Me.lvImage.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lvImage, "Image file(s)")
        Me.lvImage.UseCompatibleStateImageBehavior = False
        Me.lvImage.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        '
        'chLastModified
        '
        Me.chLastModified.Text = "Modified Date"
        '
        'chLastAccessed
        '
        Me.chLastAccessed.Text = "Last Accessed"
        '
        'chCreatedDate
        '
        Me.chCreatedDate.Text = "Created Date"
        '
        'chAtrributes
        '
        Me.chAtrributes.Text = "Atrributes"
        '
        'lvExif
        '
        Me.lvExif.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProperty, Me.chValue})
        Me.lvExif.GridLines = True
        Me.lvExif.HideSelection = False
        Me.lvExif.Location = New System.Drawing.Point(17, 31)
        Me.lvExif.Name = "lvExif"
        Me.lvExif.Size = New System.Drawing.Size(121, 97)
        Me.lvExif.TabIndex = 0
        Me.lvExif.UseCompatibleStateImageBehavior = False
        Me.lvExif.View = System.Windows.Forms.View.Details
        '
        'chProperty
        '
        Me.chProperty.Text = "Property"
        '
        'chValue
        '
        Me.chValue.Text = "Value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerUtama)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainerUtama.Panel1.ResumeLayout(False)
        Me.SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUtama.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAtrributes As ColumnHeader
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
End Class
