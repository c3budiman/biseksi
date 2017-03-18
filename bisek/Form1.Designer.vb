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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.inE = New System.Windows.Forms.TextBox()
        Me.inB = New System.Windows.Forms.TextBox()
        Me.inA = New System.Windows.Forms.TextBox()
        Me.inPersamaan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.akar_ = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inITERASI = New System.Windows.Forms.TextBox()
        Me.iterasi = New System.Windows.Forms.CheckBox()
        Me.xtol = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label5.Location = New System.Drawing.Point(2, 123)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(56, 13)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Toleransi :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label4.Location = New System.Drawing.Point(3, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Batas B :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label3.Location = New System.Drawing.Point(3, 71)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(50, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Batas A :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(2, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Persamaan :"
        '
        'inE
        '
        Me.inE.Location = New System.Drawing.Point(71, 119)
        Me.inE.Name = "inE"
        Me.inE.Size = New System.Drawing.Size(213, 20)
        Me.inE.TabIndex = 14
        '
        'inB
        '
        Me.inB.Location = New System.Drawing.Point(71, 93)
        Me.inB.Name = "inB"
        Me.inB.Size = New System.Drawing.Size(213, 20)
        Me.inB.TabIndex = 13
        '
        'inA
        '
        Me.inA.Location = New System.Drawing.Point(71, 67)
        Me.inA.Name = "inA"
        Me.inA.Size = New System.Drawing.Size(213, 20)
        Me.inA.TabIndex = 12
        '
        'inPersamaan
        '
        Me.inPersamaan.Location = New System.Drawing.Point(71, 41)
        Me.inPersamaan.Name = "inPersamaan"
        Me.inPersamaan.Size = New System.Drawing.Size(213, 20)
        Me.inPersamaan.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(15, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 22)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Akarnya :"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(16, 224)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(268, 23)
        Me.clear.TabIndex = 24
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToCSVToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportToCSVToolStripMenuItem
        '
        Me.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem"
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Simpan Ke CSV"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExitToolStripMenuItem.Text = "Keluar"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AboutToolStripMenuItem.Text = "Tentang"
        '
        'akar_
        '
        Me.akar_.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.akar_.BackColor = System.Drawing.Color.White
        Me.akar_.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.akar_.Location = New System.Drawing.Point(19, 349)
        Me.akar_.Name = "akar_"
        Me.akar_.ReadOnly = True
        Me.akar_.Size = New System.Drawing.Size(265, 29)
        Me.akar_.TabIndex = 26
        '
        'dataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.dataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.a, Me.fa, Me.b, Me.fb, Me.c, Me.fc})
        Me.dataGridView1.GridColor = System.Drawing.Color.White
        Me.dataGridView1.Location = New System.Drawing.Point(290, 55)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(722, 330)
        Me.dataGridView1.TabIndex = 21
        '
        'nomor
        '
        Me.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nomor.HeaderText = "no"
        Me.nomor.Name = "nomor"
        Me.nomor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomor.Width = 44
        '
        'a
        '
        Me.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.a.HeaderText = "a"
        Me.a.Name = "a"
        '
        'fa
        '
        Me.fa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fa.HeaderText = "f(a)"
        Me.fa.Name = "fa"
        '
        'b
        '
        Me.b.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.b.HeaderText = "b"
        Me.b.Name = "b"
        '
        'fb
        '
        Me.fb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fb.HeaderText = "f(b)"
        Me.fb.Name = "fb"
        '
        'c
        '
        Me.c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c.HeaderText = "c"
        Me.c.Name = "c"
        '
        'fc
        '
        Me.fc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fc.HeaderText = "f(c)"
        Me.fc.Name = "fc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(290, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Iterasi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(2, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Max Iterasi :"
        '
        'inITERASI
        '
        Me.inITERASI.Location = New System.Drawing.Point(71, 146)
        Me.inITERASI.Name = "inITERASI"
        Me.inITERASI.Size = New System.Drawing.Size(213, 20)
        Me.inITERASI.TabIndex = 30
        '
        'iterasi
        '
        Me.iterasi.AutoSize = True
        Me.iterasi.Location = New System.Drawing.Point(201, 189)
        Me.iterasi.Name = "iterasi"
        Me.iterasi.Size = New System.Drawing.Size(83, 17)
        Me.iterasi.TabIndex = 31
        Me.iterasi.Text = "Maks Iterasi"
        Me.iterasi.UseVisualStyleBackColor = True
        '
        'xtol
        '
        Me.xtol.AutoSize = True
        Me.xtol.Location = New System.Drawing.Point(126, 189)
        Me.xtol.Name = "xtol"
        Me.xtol.Size = New System.Drawing.Size(69, 17)
        Me.xtol.TabIndex = 32
        Me.xtol.Text = "Toleransi"
        Me.xtol.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(50, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Metode :"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImage = Global.bisek.My.Resources.Resources.blue_dark_windows_desktop_wallpaper_wallpaper_blue_backgrounds_for_websites_wallpaperblue_dark_background_white_light_windows_desktop
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1018, 389)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.xtol)
        Me.Controls.Add(Me.iterasi)
        Me.Controls.Add(Me.inITERASI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.akar_)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.inE)
        Me.Controls.Add(Me.inB)
        Me.Controls.Add(Me.inA)
        Me.Controls.Add(Me.inPersamaan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Metode Biseksi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents inE As TextBox
    Private WithEvents inB As TextBox
    Private WithEvents inA As TextBox
    Private WithEvents inPersamaan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents clear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents akar_ As TextBox
    Private WithEvents dataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Private WithEvents Label7 As Label
    Private WithEvents inITERASI As TextBox
    Friend WithEvents iterasi As CheckBox
    Friend WithEvents xtol As CheckBox
    Private WithEvents Label8 As Label
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents fa As DataGridViewTextBoxColumn
    Friend WithEvents b As DataGridViewTextBoxColumn
    Friend WithEvents fb As DataGridViewTextBoxColumn
    Friend WithEvents c As DataGridViewTextBoxColumn
    Friend WithEvents fc As DataGridViewTextBoxColumn
End Class
