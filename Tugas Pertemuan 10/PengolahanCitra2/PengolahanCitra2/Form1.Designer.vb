﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerahkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelapkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanHistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Putar90DerajatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 422)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistogramToolStripMenuItem, Me.EfekToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.PropertiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyscaleToolStripMenuItem, Me.CerahkanToolStripMenuItem, Me.GelapkanToolStripMenuItem, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ResetToolStripMenuItem, Me.TampilkanHistogramToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'EfekToolStripMenuItem
        '
        Me.EfekToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamkanToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.Putar90DerajatToolStripMenuItem, Me.FlipHorizontalToolStripMenuItem, Me.FlipVertikalToolStripMenuItem})
        Me.EfekToolStripMenuItem.Name = "EfekToolStripMenuItem"
        Me.EfekToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.EfekToolStripMenuItem.Text = "Efek"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'PropertiToolStripMenuItem
        '
        Me.PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        Me.PropertiToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PropertiToolStripMenuItem.Text = "Properti"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'GreyscaleToolStripMenuItem
        '
        Me.GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        Me.GreyscaleToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GreyscaleToolStripMenuItem.Text = "Greyscale"
        '
        'CerahkanToolStripMenuItem
        '
        Me.CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        Me.CerahkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CerahkanToolStripMenuItem.Text = "Cerahkan"
        '
        'GelapkanToolStripMenuItem
        '
        Me.GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        Me.GelapkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.GelapkanToolStripMenuItem.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanHistogramToolStripMenuItem
        '
        Me.TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        Me.TampilkanHistogramToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'TajamkanToolStripMenuItem
        '
        Me.TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        Me.TajamkanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TajamkanToolStripMenuItem.Text = "Tajamkan"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'Putar90DerajatToolStripMenuItem
        '
        Me.Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Me.Putar90DerajatToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Putar90DerajatToolStripMenuItem.Text = "Putar 90 Derajat"
        '
        'FlipHorizontalToolStripMenuItem
        '
        Me.FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        Me.FlipHorizontalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipVertikalToolStripMenuItem
        '
        Me.FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        Me.FlipVertikalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Form Utama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Putar90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
