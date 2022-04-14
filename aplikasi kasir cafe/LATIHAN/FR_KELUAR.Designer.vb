<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KELUAR
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnatas = New System.Windows.Forms.Panel()
        Me.PNCARI = New System.Windows.Forms.Panel()
        Me.DGCARI = New System.Windows.Forms.DataGridView()
        Me.BTNKELUAR = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCARI = New System.Windows.Forms.Button()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.TXTBARANG = New System.Windows.Forms.TextBox()
        Me.TXTSATUAN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNBAYAR = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txttunai = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnbawah = New System.Windows.Forms.Panel()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.dgtampilan = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SATUAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KLIK_KANAN = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nota = New System.Drawing.Printing.PrintDocument()
        Me.pnatas.SuspendLayout()
        Me.PNCARI.SuspendLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PNBAYAR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnbawah.SuspendLayout()
        CType(Me.dgtampilan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KLIK_KANAN.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnatas
        '
        Me.pnatas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnatas.Controls.Add(Me.PNCARI)
        Me.pnatas.Controls.Add(Me.btnminimize)
        Me.pnatas.Controls.Add(Me.GroupBox2)
        Me.pnatas.Controls.Add(Me.btnmenu)
        Me.pnatas.Controls.Add(Me.GroupBox1)
        Me.pnatas.Location = New System.Drawing.Point(0, 0)
        Me.pnatas.Name = "pnatas"
        Me.pnatas.Size = New System.Drawing.Size(983, 194)
        Me.pnatas.TabIndex = 0
        '
        'PNCARI
        '
        Me.PNCARI.BackColor = System.Drawing.Color.White
        Me.PNCARI.Controls.Add(Me.DGCARI)
        Me.PNCARI.Controls.Add(Me.BTNKELUAR)
        Me.PNCARI.Controls.Add(Me.TXTCARI)
        Me.PNCARI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNCARI.Location = New System.Drawing.Point(0, 0)
        Me.PNCARI.Name = "PNCARI"
        Me.PNCARI.Size = New System.Drawing.Size(983, 194)
        Me.PNCARI.TabIndex = 9
        Me.PNCARI.Visible = False
        '
        'DGCARI
        '
        Me.DGCARI.AllowUserToAddRows = False
        Me.DGCARI.AllowUserToDeleteRows = False
        Me.DGCARI.AllowUserToResizeColumns = False
        Me.DGCARI.AllowUserToResizeRows = False
        Me.DGCARI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCARI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCARI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGCARI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCARI.Location = New System.Drawing.Point(3, 30)
        Me.DGCARI.Name = "DGCARI"
        Me.DGCARI.ReadOnly = True
        Me.DGCARI.RowHeadersVisible = False
        Me.DGCARI.Size = New System.Drawing.Size(975, 161)
        Me.DGCARI.TabIndex = 11
        '
        'BTNKELUAR
        '
        Me.BTNKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNKELUAR.Location = New System.Drawing.Point(903, 4)
        Me.BTNKELUAR.Name = "BTNKELUAR"
        Me.BTNKELUAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNKELUAR.TabIndex = 10
        Me.BTNKELUAR.Text = "Keluar"
        Me.BTNKELUAR.UseVisualStyleBackColor = True
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(3, 4)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(879, 20)
        Me.TXTCARI.TabIndex = 0
        '
        'btnminimize
        '
        Me.btnminimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimize.Location = New System.Drawing.Point(885, 13)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(35, 22)
        Me.btnminimize.TabIndex = 4
        Me.btnminimize.Text = "-"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbtotal)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 146)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Harga"
        '
        'lbtotal
        '
        Me.lbtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbtotal.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.Location = New System.Drawing.Point(6, 22)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(603, 103)
        Me.lbtotal.TabIndex = 2
        Me.lbtotal.Text = "0"
        Me.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.Red
        Me.btnmenu.Location = New System.Drawing.Point(926, 12)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(45, 23)
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.Text = "X"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCARI)
        Me.GroupBox1.Controls.Add(Me.TXTHARGA)
        Me.GroupBox1.Controls.Add(Me.TXTKODE)
        Me.GroupBox1.Controls.Add(Me.TXTBARANG)
        Me.GroupBox1.Controls.Add(Me.TXTSATUAN)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'BTNCARI
        '
        Me.BTNCARI.Location = New System.Drawing.Point(247, 15)
        Me.BTNCARI.Name = "BTNCARI"
        Me.BTNCARI.Size = New System.Drawing.Size(75, 23)
        Me.BTNCARI.TabIndex = 8
        Me.BTNCARI.Text = " Cari (F1)"
        Me.BTNCARI.UseVisualStyleBackColor = True
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(74, 109)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.ReadOnly = True
        Me.TXTHARGA.Size = New System.Drawing.Size(248, 20)
        Me.TXTHARGA.TabIndex = 7
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(74, 16)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(160, 20)
        Me.TXTKODE.TabIndex = 6
        '
        'TXTBARANG
        '
        Me.TXTBARANG.Location = New System.Drawing.Point(74, 47)
        Me.TXTBARANG.Name = "TXTBARANG"
        Me.TXTBARANG.ReadOnly = True
        Me.TXTBARANG.Size = New System.Drawing.Size(248, 20)
        Me.TXTBARANG.TabIndex = 5
        '
        'TXTSATUAN
        '
        Me.TXTSATUAN.Location = New System.Drawing.Point(74, 78)
        Me.TXTSATUAN.Name = "TXTSATUAN"
        Me.TXTSATUAN.ReadOnly = True
        Me.TXTSATUAN.Size = New System.Drawing.Size(248, 20)
        Me.TXTSATUAN.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'PNBAYAR
        '
        Me.PNBAYAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PNBAYAR.Controls.Add(Me.GroupBox3)
        Me.PNBAYAR.Location = New System.Drawing.Point(12, 261)
        Me.PNBAYAR.Name = "PNBAYAR"
        Me.PNBAYAR.Size = New System.Drawing.Size(538, 186)
        Me.PNBAYAR.TabIndex = 12
        Me.PNBAYAR.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btntutup)
        Me.GroupBox3.Controls.Add(Me.txtbayar)
        Me.GroupBox3.Controls.Add(Me.txttunai)
        Me.GroupBox3.Controls.Add(Me.txtkembalian)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 159)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'btntutup
        '
        Me.btntutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntutup.BackColor = System.Drawing.Color.Red
        Me.btntutup.Location = New System.Drawing.Point(460, 12)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(44, 23)
        Me.btntutup.TabIndex = 6
        Me.btntutup.Text = "X"
        Me.btntutup.UseVisualStyleBackColor = False
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(82, 18)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.ReadOnly = True
        Me.txtbayar.Size = New System.Drawing.Size(255, 20)
        Me.txtbayar.TabIndex = 5
        Me.txtbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttunai
        '
        Me.txttunai.Location = New System.Drawing.Point(82, 54)
        Me.txttunai.Name = "txttunai"
        Me.txttunai.Size = New System.Drawing.Size(255, 20)
        Me.txttunai.TabIndex = 4
        Me.txttunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(82, 93)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.ReadOnly = True
        Me.txtkembalian.Size = New System.Drawing.Size(255, 20)
        Me.txtkembalian.TabIndex = 3
        Me.txtkembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kembalian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tunai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Bayar"
        '
        'pnbawah
        '
        Me.pnbawah.Controls.Add(Me.btnbayar)
        Me.pnbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnbawah.Location = New System.Drawing.Point(0, 465)
        Me.pnbawah.Name = "pnbawah"
        Me.pnbawah.Size = New System.Drawing.Size(983, 59)
        Me.pnbawah.TabIndex = 1
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(12, 6)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 2
        Me.btnbayar.Text = "Bayar (F2)"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'dgtampilan
        '
        Me.dgtampilan.AllowUserToAddRows = False
        Me.dgtampilan.AllowUserToDeleteRows = False
        Me.dgtampilan.AllowUserToResizeColumns = False
        Me.dgtampilan.AllowUserToResizeRows = False
        Me.dgtampilan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgtampilan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtampilan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgtampilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampilan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.BARANG, Me.SATUAN, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.dgtampilan.Location = New System.Drawing.Point(-3, 192)
        Me.dgtampilan.Name = "dgtampilan"
        Me.dgtampilan.RowHeadersVisible = False
        Me.dgtampilan.Size = New System.Drawing.Size(983, 273)
        Me.dgtampilan.TabIndex = 0
        '
        'KODE
        '
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'BARANG
        '
        Me.BARANG.HeaderText = "MENU"
        Me.BARANG.Name = "BARANG"
        Me.BARANG.ReadOnly = True
        Me.BARANG.Width = 500
        '
        'SATUAN
        '
        Me.SATUAN.HeaderText = "SATUAN"
        Me.SATUAN.Name = "SATUAN"
        Me.SATUAN.ReadOnly = True
        '
        'HARGA
        '
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 80
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'KLIK_KANAN
        '
        Me.KLIK_KANAN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.KLIK_KANAN.Name = "KLIK_KANAN"
        Me.KLIK_KANAN.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'nota
        '
        '
        'FR_KELUAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 524)
        Me.Controls.Add(Me.PNBAYAR)
        Me.Controls.Add(Me.dgtampilan)
        Me.Controls.Add(Me.pnbawah)
        Me.Controls.Add(Me.pnatas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FR_KELUAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KELUAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnatas.ResumeLayout(False)
        Me.PNCARI.ResumeLayout(False)
        Me.PNCARI.PerformLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PNBAYAR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnbawah.ResumeLayout(False)
        CType(Me.dgtampilan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KLIK_KANAN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnatas As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnbawah As System.Windows.Forms.Panel
    Friend WithEvents dgtampilan As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents BTNCARI As System.Windows.Forms.Button
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents TXTBARANG As System.Windows.Forms.TextBox
    Friend WithEvents TXTSATUAN As System.Windows.Forms.TextBox
    Friend WithEvents btnbayar As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents PNCARI As System.Windows.Forms.Panel
    Friend WithEvents DGCARI As System.Windows.Forms.DataGridView
    Friend WithEvents BTNKELUAR As System.Windows.Forms.Button
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents PNBAYAR As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents txttunai As System.Windows.Forms.TextBox
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents KLIK_KANAN As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SATUAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nota As System.Drawing.Printing.PrintDocument
End Class
