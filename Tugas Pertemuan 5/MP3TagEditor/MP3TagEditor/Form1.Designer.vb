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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lvMP3 = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTextPlaying = New System.Windows.Forms.Label()
        Me.lblTextDuration = New System.Windows.Forms.Label()
        Me.lblPlaying = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblMp3Editor = New System.Windows.Forms.Label()
        Me.lblTrack = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.lblTear = New System.Windows.Forms.Label()
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvDrive
        '
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.ImageList1
        Me.tvDrive.Location = New System.Drawing.Point(3, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(260, 449)
        Me.tvDrive.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "285678_drive_icon.png")
        Me.ImageList1.Images.SetKeyName(1, "299060_folder_icon.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(798, 449)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvMP3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(528, 449)
        Me.SplitContainer2.SplitterDistance = 250
        Me.SplitContainer2.TabIndex = 0
        '
        'lvMP3
        '
        Me.lvMP3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chExtension, Me.chFileSize, Me.chLastModified, Me.chLastAccessed, Me.chCreatedDate, Me.chAttributes})
        Me.lvMP3.GridLines = True
        Me.lvMP3.HideSelection = False
        Me.lvMP3.Location = New System.Drawing.Point(3, 3)
        Me.lvMP3.Name = "lvMP3"
        Me.lvMP3.Size = New System.Drawing.Size(522, 244)
        Me.lvMP3.SmallImageList = Me.ImageList1
        Me.lvMP3.TabIndex = 2
        Me.lvMP3.UseCompatibleStateImageBehavior = False
        Me.lvMP3.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 95
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        Me.chExtension.Width = 55
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        Me.chFileSize.Width = 63
        '
        'chLastModified
        '
        Me.chLastModified.Text = "Last Modified"
        Me.chLastModified.Width = 84
        '
        'chLastAccessed
        '
        Me.chLastAccessed.Text = "Last Accessed"
        Me.chLastAccessed.Width = 97
        '
        'chCreatedDate
        '
        Me.chCreatedDate.Text = "Created Date"
        Me.chCreatedDate.Width = 65
        '
        'chAttributes
        '
        Me.chAttributes.Text = "Attributes"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtYear)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtAlbum)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtArtist)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTitle)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTrack)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTear)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblAlbum)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblArtist)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTitle)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTrack)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblMp3Editor)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(528, 195)
        Me.SplitContainer3.SplitterDistance = 305
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnPlay)
        Me.GroupBox1.Controls.Add(Me.lblDuration)
        Me.GroupBox1.Controls.Add(Me.lblPlaying)
        Me.GroupBox1.Controls.Add(Me.lblTextDuration)
        Me.GroupBox1.Controls.Add(Me.lblTextPlaying)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'lblTextPlaying
        '
        Me.lblTextPlaying.AutoSize = True
        Me.lblTextPlaying.Location = New System.Drawing.Point(7, 22)
        Me.lblTextPlaying.Name = "lblTextPlaying"
        Me.lblTextPlaying.Size = New System.Drawing.Size(55, 16)
        Me.lblTextPlaying.TabIndex = 0
        Me.lblTextPlaying.Text = "Playing:"
        '
        'lblTextDuration
        '
        Me.lblTextDuration.AutoSize = True
        Me.lblTextDuration.Location = New System.Drawing.Point(7, 47)
        Me.lblTextDuration.Name = "lblTextDuration"
        Me.lblTextDuration.Size = New System.Drawing.Size(60, 16)
        Me.lblTextDuration.TabIndex = 1
        Me.lblTextDuration.Text = "Duration:"
        '
        'lblPlaying
        '
        Me.lblPlaying.AutoSize = True
        Me.lblPlaying.Location = New System.Drawing.Point(80, 22)
        Me.lblPlaying.Name = "lblPlaying"
        Me.lblPlaying.Size = New System.Drawing.Size(38, 16)
        Me.lblPlaying.TabIndex = 2
        Me.lblPlaying.Text = "00:00"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(80, 47)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(38, 16)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "00:00"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(10, 78)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(107, 78)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(10, 107)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(92, 58)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'lblMp3Editor
        '
        Me.lblMp3Editor.AutoSize = True
        Me.lblMp3Editor.Location = New System.Drawing.Point(12, 12)
        Me.lblMp3Editor.Name = "lblMp3Editor"
        Me.lblMp3Editor.Size = New System.Drawing.Size(95, 16)
        Me.lblMp3Editor.TabIndex = 0
        Me.lblMp3Editor.Text = "MP3 ID3 Editor"
        '
        'lblTrack
        '
        Me.lblTrack.AutoSize = True
        Me.lblTrack.Location = New System.Drawing.Point(12, 38)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(45, 16)
        Me.lblTrack.TabIndex = 1
        Me.lblTrack.Text = "Track:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(36, 16)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title:"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(12, 85)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(39, 16)
        Me.lblArtist.TabIndex = 3
        Me.lblArtist.Text = "Artist:"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(12, 110)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(48, 16)
        Me.lblAlbum.TabIndex = 4
        Me.lblAlbum.Text = "Album:"
        '
        'lblTear
        '
        Me.lblTear.AutoSize = True
        Me.lblTear.Location = New System.Drawing.Point(12, 136)
        Me.lblTear.Name = "lblTear"
        Me.lblTear.Size = New System.Drawing.Size(39, 16)
        Me.lblTear.TabIndex = 5
        Me.lblTear.Text = "Year:"
        '
        'txtTrack
        '
        Me.txtTrack.Location = New System.Drawing.Point(63, 35)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(57, 22)
        Me.txtTrack.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(63, 58)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(208, 22)
        Me.txtTitle.TabIndex = 7
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(63, 82)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(208, 22)
        Me.txtArtist.TabIndex = 8
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(63, 107)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(160, 22)
        Me.txtAlbum.TabIndex = 9
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(63, 133)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(44, 22)
        Me.txtYear.TabIndex = 10
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(210, 145)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3TagEditor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvDrive As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lvMP3 As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents lblTrack As Label
    Friend WithEvents lblMp3Editor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPlaying As Label
    Friend WithEvents lblTextDuration As Label
    Friend WithEvents lblTextPlaying As Label
    Friend WithEvents lblTear As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Timer1 As Timer
End Class
