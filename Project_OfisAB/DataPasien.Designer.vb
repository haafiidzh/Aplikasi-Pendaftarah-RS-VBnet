<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPasien
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPasien))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode_rm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pasien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jkelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_lahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmp_lahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bangsal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jpasien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tgl_keluar = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_rm, Me.nama_pasien, Me.alamat, Me.jkelamin, Me.tgl_lahir, Me.tmp_lahir, Me.telp, Me.bangsal, Me.jpasien, Me.tgl_masuk})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(38, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(948, 263)
        Me.DataGridView1.TabIndex = 16
        '
        'kode_rm
        '
        Me.kode_rm.HeaderText = "No. RM"
        Me.kode_rm.Name = "kode_rm"
        Me.kode_rm.ReadOnly = True
        '
        'nama_pasien
        '
        Me.nama_pasien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_pasien.HeaderText = "Nama"
        Me.nama_pasien.Name = "nama_pasien"
        Me.nama_pasien.ReadOnly = True
        Me.nama_pasien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'alamat
        '
        Me.alamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        Me.alamat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'jkelamin
        '
        Me.jkelamin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.jkelamin.HeaderText = "Jenis Kelamin"
        Me.jkelamin.Name = "jkelamin"
        Me.jkelamin.ReadOnly = True
        Me.jkelamin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.jkelamin.Width = 90
        '
        'tgl_lahir
        '
        Me.tgl_lahir.HeaderText = "Tanggal Lahir"
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.ReadOnly = True
        '
        'tmp_lahir
        '
        Me.tmp_lahir.HeaderText = "Tempat Lahir"
        Me.tmp_lahir.Name = "tmp_lahir"
        Me.tmp_lahir.ReadOnly = True
        '
        'telp
        '
        Me.telp.HeaderText = "No. Telepon"
        Me.telp.Name = "telp"
        Me.telp.ReadOnly = True
        '
        'bangsal
        '
        Me.bangsal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bangsal.HeaderText = "Bangsal"
        Me.bangsal.Name = "bangsal"
        Me.bangsal.ReadOnly = True
        Me.bangsal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'jpasien
        '
        Me.jpasien.HeaderText = "Jenis Pasien"
        Me.jpasien.Name = "jpasien"
        Me.jpasien.ReadOnly = True
        '
        'tgl_masuk
        '
        Me.tgl_masuk.HeaderText = "Tanggal Masuk"
        Me.tgl_masuk.Name = "tgl_masuk"
        Me.tgl_masuk.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "REGISTRASI PASIEN RAWAT INAP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "SURAKARTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "RUMAH SAKIT KASIH BUNDA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(846, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 47)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "HAPUS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(822, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(108, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SpringGreen
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(751, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 47)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "EDIT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Turquoise
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(622, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 47)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "PROSES"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(38, 156)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 40)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "KEMBALI"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tgl_keluar
        '
        Me.tgl_keluar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tgl_keluar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_keluar.Location = New System.Drawing.Point(441, 162)
        Me.tgl_keluar.Name = "tgl_keluar"
        Me.tgl_keluar.Size = New System.Drawing.Size(156, 21)
        Me.tgl_keluar.TabIndex = 56
        Me.tgl_keluar.Visible = False
        '
        'DataPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.tgl_keluar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.Name = "DataPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPasien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kode_rm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_pasien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jkelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl_lahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmp_lahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bangsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jpasien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tgl_keluar As System.Windows.Forms.Label
End Class
