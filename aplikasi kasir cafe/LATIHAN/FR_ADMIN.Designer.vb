<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FR_ADMIN))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.LBNAMA = New System.Windows.Forms.Label()
        Me.LBNIK = New System.Windows.Forms.Label()
        Me.CBTYPE = New System.Windows.Forms.ComboBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.TXTPASS2 = New System.Windows.Forms.TextBox()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.BTNSIMPAN)
        Me.GroupBox1.Controls.Add(Me.LBNAMA)
        Me.GroupBox1.Controls.Add(Me.LBNIK)
        Me.GroupBox1.Controls.Add(Me.CBTYPE)
        Me.GroupBox1.Controls.Add(Me.TXTPASS)
        Me.GroupBox1.Controls.Add(Me.TXTPASS2)
        Me.GroupBox1.Controls.Add(Me.TXTUSER)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User Admin"
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(203, 222)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 12
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'LBNAMA
        '
        Me.LBNAMA.AutoSize = True
        Me.LBNAMA.Location = New System.Drawing.Point(200, 67)
        Me.LBNAMA.Name = "LBNAMA"
        Me.LBNAMA.Size = New System.Drawing.Size(38, 13)
        Me.LBNAMA.TabIndex = 11
        Me.LBNAMA.Text = "NAMA"
        '
        'LBNIK
        '
        Me.LBNIK.AutoSize = True
        Me.LBNIK.Location = New System.Drawing.Point(200, 37)
        Me.LBNIK.Name = "LBNIK"
        Me.LBNIK.Size = New System.Drawing.Size(25, 13)
        Me.LBNIK.TabIndex = 10
        Me.LBNIK.Text = "NIK"
        '
        'CBTYPE
        '
        Me.CBTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTYPE.FormattingEnabled = True
        Me.CBTYPE.Items.AddRange(New Object() {"ADMIN.", "MANAGER.", "KASIR."})
        Me.CBTYPE.Location = New System.Drawing.Point(203, 184)
        Me.CBTYPE.Name = "CBTYPE"
        Me.CBTYPE.Size = New System.Drawing.Size(353, 21)
        Me.CBTYPE.TabIndex = 9
        '
        'TXTPASS
        '
        Me.TXTPASS.Location = New System.Drawing.Point(203, 124)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(353, 20)
        Me.TXTPASS.TabIndex = 8
        Me.TXTPASS.UseSystemPasswordChar = True
        '
        'TXTPASS2
        '
        Me.TXTPASS2.Location = New System.Drawing.Point(203, 150)
        Me.TXTPASS2.Name = "TXTPASS2"
        Me.TXTPASS2.Size = New System.Drawing.Size(353, 20)
        Me.TXTPASS2.TabIndex = 7
        Me.TXTPASS2.UseSystemPasswordChar = True
        '
        'TXTUSER
        '
        Me.TXTUSER.Location = New System.Drawing.Point(203, 97)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(353, 20)
        Me.TXTUSER.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RE PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'FR_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FR_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBNIK As System.Windows.Forms.Label
    Friend WithEvents CBTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents LBNAMA As System.Windows.Forms.Label
End Class
