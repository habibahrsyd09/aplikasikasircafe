<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_LAPORAN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TAMPILNAMA = New System.Windows.Forms.Button()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntampil = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tglmulai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tglsampai = New System.Windows.Forms.DateTimePicker()
        Me.dgtampilan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgtampilan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 121)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TAMPILNAMA)
        Me.GroupBox2.Controls.Add(Me.TXTNAMA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(472, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(474, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TAMPILNAMA
        '
        Me.TAMPILNAMA.Location = New System.Drawing.Point(109, 59)
        Me.TAMPILNAMA.Name = "TAMPILNAMA"
        Me.TAMPILNAMA.Size = New System.Drawing.Size(55, 23)
        Me.TAMPILNAMA.TabIndex = 9
        Me.TAMPILNAMA.Text = "TAMPIL"
        Me.TAMPILNAMA.UseVisualStyleBackColor = True
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Location = New System.Drawing.Point(109, 26)
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(236, 20)
        Me.TXTNAMA.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAMA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btntampil)
        Me.GroupBox1.Controls.Add(Me.btncetak)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tglmulai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tglsampai)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btntampil
        '
        Me.btntampil.Location = New System.Drawing.Point(258, 59)
        Me.btntampil.Name = "btntampil"
        Me.btntampil.Size = New System.Drawing.Size(75, 23)
        Me.btntampil.TabIndex = 7
        Me.btntampil.Text = "Tampil"
        Me.btntampil.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(350, 59)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 8
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mulai TGL"
        '
        'tglmulai
        '
        Me.tglmulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglmulai.Location = New System.Drawing.Point(97, 21)
        Me.tglmulai.Name = "tglmulai"
        Me.tglmulai.Size = New System.Drawing.Size(96, 20)
        Me.tglmulai.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sampai TGL"
        '
        'tglsampai
        '
        Me.tglsampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglsampai.Location = New System.Drawing.Point(97, 55)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Size = New System.Drawing.Size(97, 20)
        Me.tglsampai.TabIndex = 6
        '
        'dgtampilan
        '
        Me.dgtampilan.AllowUserToAddRows = False
        Me.dgtampilan.AllowUserToDeleteRows = False
        Me.dgtampilan.AllowUserToResizeColumns = False
        Me.dgtampilan.AllowUserToResizeRows = False
        Me.dgtampilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgtampilan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgtampilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampilan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtampilan.Location = New System.Drawing.Point(0, 121)
        Me.dgtampilan.Name = "dgtampilan"
        Me.dgtampilan.ReadOnly = True
        Me.dgtampilan.RowHeadersVisible = False
        Me.dgtampilan.Size = New System.Drawing.Size(958, 324)
        Me.dgtampilan.TabIndex = 0
        '
        'FR_LAPORAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 445)
        Me.Controls.Add(Me.dgtampilan)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FR_LAPORAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_LAPORAN"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgtampilan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tglmulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgtampilan As System.Windows.Forms.DataGridView
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btntampil As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TAMPILNAMA As System.Windows.Forms.Button
    Friend WithEvents TXTNAMA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
