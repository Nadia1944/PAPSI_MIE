<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marketing
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtgrand = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidmie = New System.Windows.Forms.TextBox()
        Me.cmb_jenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtongkir = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinvoice = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tglorder = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(277, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Kembalian          :"
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(366, 232)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(87, 20)
        Me.txtkembalian.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(277, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Bayar                 :"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(366, 209)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(87, 20)
        Me.txtbayar.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(272, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Total Rp"
        '
        'txtgrand
        '
        Me.txtgrand.Location = New System.Drawing.Point(366, 160)
        Me.txtgrand.Name = "txtgrand"
        Me.txtgrand.Size = New System.Drawing.Size(87, 39)
        Me.txtgrand.TabIndex = 38
        Me.txtgrand.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtjumlah)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtidmie)
        Me.GroupBox2.Controls.Add(Me.cmb_jenis)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 138)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Order"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Jumlah                :"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(104, 99)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(101, 20)
        Me.txtjumlah.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Id Mie                 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Harga                 :"
        '
        'txtidmie
        '
        Me.txtidmie.Location = New System.Drawing.Point(104, 22)
        Me.txtidmie.Name = "txtidmie"
        Me.txtidmie.Size = New System.Drawing.Size(101, 20)
        Me.txtidmie.TabIndex = 14
        '
        'cmb_jenis
        '
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Items.AddRange(New Object() {"Mie Pipih", "Mie Kering"})
        Me.cmb_jenis.Location = New System.Drawing.Point(104, 48)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(101, 21)
        Me.cmb_jenis.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Jenis                   :"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(104, 75)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(101, 20)
        Me.txtharga.TabIndex = 23
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(393, 258)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(60, 24)
        Me.btn_simpan.TabIndex = 36
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtongkir)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtinvoice)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tglorder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 270)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Order"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ongkos Kirim      :"
        '
        'txtongkir
        '
        Me.txtongkir.Location = New System.Drawing.Point(103, 222)
        Me.txtongkir.Name = "txtongkir"
        Me.txtongkir.Size = New System.Drawing.Size(101, 20)
        Me.txtongkir.TabIndex = 20
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(104, 101)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 112)
        Me.txtalamat.TabIndex = 18
        Me.txtalamat.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Invoice               :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Distributor :"
        '
        'txtinvoice
        '
        Me.txtinvoice.Location = New System.Drawing.Point(104, 26)
        Me.txtinvoice.Name = "txtinvoice"
        Me.txtinvoice.Size = New System.Drawing.Size(101, 20)
        Me.txtinvoice.TabIndex = 10
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(104, 75)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(101, 20)
        Me.txtnama.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Alamat                :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tanggal Order    :"
        '
        'tglorder
        '
        Me.tglorder.Location = New System.Drawing.Point(104, 50)
        Me.tglorder.Name = "tglorder"
        Me.tglorder.Size = New System.Drawing.Size(101, 20)
        Me.tglorder.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 289)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 156)
        Me.DataGridView1.TabIndex = 44
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 460)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtgrand)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtgrand As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidmie As TextBox
    Friend WithEvents cmb_jenis As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtongkir As TextBox
    Friend WithEvents txtalamat As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtinvoice As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tglorder As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
