<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_BARANG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FR_BARANG))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.TXTBARANG = New System.Windows.Forms.TextBox()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.CBSATUAN = New System.Windows.Forms.ComboBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.DGTAMPILAN = New System.Windows.Forms.DataGridView()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGTAMPILAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MENU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SATUAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA SATUAN"
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(125, 131)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.Size = New System.Drawing.Size(100, 20)
        Me.TXTHARGA.TabIndex = 4
        '
        'TXTBARANG
        '
        Me.TXTBARANG.Location = New System.Drawing.Point(125, 57)
        Me.TXTBARANG.Name = "TXTBARANG"
        Me.TXTBARANG.Size = New System.Drawing.Size(264, 20)
        Me.TXTBARANG.TabIndex = 6
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(125, 21)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(100, 20)
        Me.TXTKODE.TabIndex = 7
        '
        'CBSATUAN
        '
        Me.CBSATUAN.FormattingEnabled = True
        Me.CBSATUAN.Items.AddRange(New Object() {"MAKANAN", "MINUMAN"})
        Me.CBSATUAN.Location = New System.Drawing.Point(125, 91)
        Me.CBSATUAN.Name = "CBSATUAN"
        Me.CBSATUAN.Size = New System.Drawing.Size(121, 21)
        Me.CBSATUAN.TabIndex = 8
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(125, 157)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 9
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(27, 196)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(919, 20)
        Me.TXTCARI.TabIndex = 10
        '
        'DGTAMPILAN
        '
        Me.DGTAMPILAN.AllowUserToAddRows = False
        Me.DGTAMPILAN.AllowUserToDeleteRows = False
        Me.DGTAMPILAN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTAMPILAN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPILAN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGTAMPILAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPILAN.Location = New System.Drawing.Point(27, 222)
        Me.DGTAMPILAN.Name = "DGTAMPILAN"
        Me.DGTAMPILAN.ReadOnly = True
        Me.DGTAMPILAN.RowHeadersVisible = False
        Me.DGTAMPILAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTAMPILAN.Size = New System.Drawing.Size(919, 219)
        Me.DGTAMPILAN.TabIndex = 11
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.klik_kanan.Name = "ContextMenuStrip1"
        Me.klik_kanan.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'FR_BARANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(979, 453)
        Me.Controls.Add(Me.DGTAMPILAN)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.CBSATUAN)
        Me.Controls.Add(Me.TXTKODE)
        Me.Controls.Add(Me.TXTBARANG)
        Me.Controls.Add(Me.TXTHARGA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FR_BARANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " FR MENU"
        CType(Me.DGTAMPILAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents TXTBARANG As System.Windows.Forms.TextBox
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents CBSATUAN As System.Windows.Forms.ComboBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents DGTAMPILAN As System.Windows.Forms.DataGridView
    Friend WithEvents klik_kanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
