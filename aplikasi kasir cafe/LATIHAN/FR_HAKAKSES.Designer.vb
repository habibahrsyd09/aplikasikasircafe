<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_hakAkses
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
        Me.DGADMIN = New System.Windows.Forms.DataGridView()
        Me.DGAKSES = New System.Windows.Forms.DataGridView()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        CType(Me.DGADMIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAKSES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGADMIN
        '
        Me.DGADMIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGADMIN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGADMIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGADMIN.Location = New System.Drawing.Point(12, 12)
        Me.DGADMIN.Name = "DGADMIN"
        Me.DGADMIN.Size = New System.Drawing.Size(240, 368)
        Me.DGADMIN.TabIndex = 0
        '
        'DGAKSES
        '
        Me.DGAKSES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGAKSES.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGAKSES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAKSES.Location = New System.Drawing.Point(258, 12)
        Me.DGAKSES.Name = "DGAKSES"
        Me.DGAKSES.Size = New System.Drawing.Size(464, 336)
        Me.DGAKSES.TabIndex = 1
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSIMPAN.Location = New System.Drawing.Point(647, 354)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 2
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'fr_hakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 392)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.DGAKSES)
        Me.Controls.Add(Me.DGADMIN)
        Me.Name = "fr_hakAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_HAKAKSES"
        CType(Me.DGADMIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAKSES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGADMIN As System.Windows.Forms.DataGridView
    Friend WithEvents DGAKSES As System.Windows.Forms.DataGridView
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
End Class
