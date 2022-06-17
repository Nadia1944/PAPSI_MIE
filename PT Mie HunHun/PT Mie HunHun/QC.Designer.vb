<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QC
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnwh = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtlayak = New System.Windows.Forms.TextBox()
        Me.txtdefect = New System.Windows.Forms.TextBox()
        Me.txtproduksi = New System.Windows.Forms.TextBox()
        Me.tglcek = New System.Windows.Forms.DateTimePicker()
        Me.cmbbatch = New System.Windows.Forms.ComboBox()
        Me.txtpj = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidqc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 158)
        Me.DataGridView1.TabIndex = 23
        '
        'btnwh
        '
        Me.btnwh.Location = New System.Drawing.Point(284, 51)
        Me.btnwh.Name = "btnwh"
        Me.btnwh.Size = New System.Drawing.Size(97, 24)
        Me.btnwh.TabIndex = 21
        Me.btnwh.Text = "Warehouse FG"
        Me.btnwh.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(284, 21)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(97, 24)
        Me.btnsimpan.TabIndex = 20
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtlayak
        '
        Me.txtlayak.Location = New System.Drawing.Point(119, 156)
        Me.txtlayak.Name = "txtlayak"
        Me.txtlayak.Size = New System.Drawing.Size(121, 20)
        Me.txtlayak.TabIndex = 11
        '
        'txtdefect
        '
        Me.txtdefect.Location = New System.Drawing.Point(119, 132)
        Me.txtdefect.Name = "txtdefect"
        Me.txtdefect.Size = New System.Drawing.Size(121, 20)
        Me.txtdefect.TabIndex = 10
        '
        'txtproduksi
        '
        Me.txtproduksi.Location = New System.Drawing.Point(119, 108)
        Me.txtproduksi.Name = "txtproduksi"
        Me.txtproduksi.Size = New System.Drawing.Size(121, 20)
        Me.txtproduksi.TabIndex = 9
        '
        'tglcek
        '
        Me.tglcek.Location = New System.Drawing.Point(119, 85)
        Me.tglcek.Name = "tglcek"
        Me.tglcek.Size = New System.Drawing.Size(121, 20)
        Me.tglcek.TabIndex = 8
        '
        'cmbbatch
        '
        Me.cmbbatch.FormattingEnabled = True
        Me.cmbbatch.Location = New System.Drawing.Point(119, 60)
        Me.cmbbatch.Name = "cmbbatch"
        Me.cmbbatch.Size = New System.Drawing.Size(121, 21)
        Me.cmbbatch.TabIndex = 7
        '
        'txtpj
        '
        Me.txtpj.FormattingEnabled = True
        Me.txtpj.Items.AddRange(New Object() {"Bpk. Zura", "Bpk. Vendy"})
        Me.txtpj.Location = New System.Drawing.Point(119, 36)
        Me.txtpj.Name = "txtpj"
        Me.txtpj.Size = New System.Drawing.Size(121, 21)
        Me.txtpj.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtlayak)
        Me.GroupBox1.Controls.Add(Me.txtdefect)
        Me.GroupBox1.Controls.Add(Me.txtproduksi)
        Me.GroupBox1.Controls.Add(Me.tglcek)
        Me.GroupBox1.Controls.Add(Me.cmbbatch)
        Me.GroupBox1.Controls.Add(Me.txtpj)
        Me.GroupBox1.Controls.Add(Me.txtidqc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 190)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail QC"
        '
        'txtidqc
        '
        Me.txtidqc.Location = New System.Drawing.Point(119, 13)
        Me.txtidqc.Name = "txtidqc"
        Me.txtidqc.Size = New System.Drawing.Size(121, 20)
        Me.txtidqc.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Jumlah Layak           :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Cek            :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Jumlah Defect          :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Batch              :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Jumlah Produksi       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penanggung Jawab :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID                             :"
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(284, 81)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(97, 24)
        Me.btnmenu.TabIndex = 22
        Me.btnmenu.Text = "Main Menu"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'QC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 389)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnwh)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnmenu)
        Me.Name = "QC"
        Me.Text = "QC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnwh As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtlayak As TextBox
    Friend WithEvents txtdefect As TextBox
    Friend WithEvents txtproduksi As TextBox
    Friend WithEvents tglcek As DateTimePicker
    Friend WithEvents cmbbatch As ComboBox
    Friend WithEvents txtpj As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidqc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmenu As Button
End Class
