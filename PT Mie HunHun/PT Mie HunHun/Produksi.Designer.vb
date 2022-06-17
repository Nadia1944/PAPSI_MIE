<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produksi
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Invoice = New System.Windows.Forms.ComboBox()
        Me.FG = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.plan = New System.Windows.Forms.DateTimePicker()
        Me.KodeBatch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Button()
        Me.purchase = New System.Windows.Forms.Button()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.cekstok = New System.Windows.Forms.Button()
        Me.DGVRM = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.telur = New System.Windows.Forms.TextBox()
        Me.minyak = New System.Windows.Forms.TextBox()
        Me.garam = New System.Windows.Forms.TextBox()
        Me.terigu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.idmie = New System.Windows.Forms.TextBox()
        Me.safety = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.jenismie = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Print = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.noinvoice = New System.Windows.Forms.TextBox()
        Me.Cmbbatch = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jadwal = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Excel = New System.Windows.Forms.Button()
        Me.Dgvpro = New System.Windows.Forms.DataGridView()
        Me.buatpesanan = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mieid = New System.Windows.Forms.TextBox()
        Me.Total_Pro = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.safetystock = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.jenis = New System.Windows.Forms.TextBox()
        Me.demand = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgvpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(719, 547)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Save)
        Me.TabPage1.Controls.Add(Me.Status)
        Me.TabPage1.Controls.Add(Me.purchase)
        Me.TabPage1.Controls.Add(Me.Hitung)
        Me.TabPage1.Controls.Add(Me.cekstok)
        Me.TabPage1.Controls.Add(Me.DGVRM)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(711, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rencana Produksi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Invoice)
        Me.GroupBox4.Controls.Add(Me.FG)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.plan)
        Me.GroupBox4.Controls.Add(Me.KodeBatch)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(263, 134)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Planning"
        '
        'Invoice
        '
        Me.Invoice.FormattingEnabled = True
        Me.Invoice.Location = New System.Drawing.Point(102, 13)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Size = New System.Drawing.Size(155, 21)
        Me.Invoice.TabIndex = 18
        '
        'FG
        '
        Me.FG.FormattingEnabled = True
        Me.FG.Location = New System.Drawing.Point(102, 42)
        Me.FG.Name = "FG"
        Me.FG.Size = New System.Drawing.Size(155, 21)
        Me.FG.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "FG Demand"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Invoice"
        '
        'plan
        '
        Me.plan.Location = New System.Drawing.Point(102, 98)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(155, 20)
        Me.plan.TabIndex = 9
        '
        'KodeBatch
        '
        Me.KodeBatch.Location = New System.Drawing.Point(102, 72)
        Me.KodeBatch.Name = "KodeBatch"
        Me.KodeBatch.Size = New System.Drawing.Size(155, 20)
        Me.KodeBatch.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Rencana Jadwal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Kode Batch"
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(166, 337)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(64, 26)
        Me.Save.TabIndex = 16
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(584, 319)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(79, 26)
        Me.Status.TabIndex = 14
        Me.Status.Text = "Status"
        Me.Status.UseVisualStyleBackColor = True
        '
        'purchase
        '
        Me.purchase.Location = New System.Drawing.Point(584, 354)
        Me.purchase.Name = "purchase"
        Me.purchase.Size = New System.Drawing.Size(79, 38)
        Me.purchase.TabIndex = 13
        Me.purchase.Text = "Purchasing >>>"
        Me.purchase.UseVisualStyleBackColor = True
        '
        'Hitung
        '
        Me.Hitung.Location = New System.Drawing.Point(96, 337)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(64, 26)
        Me.Hitung.TabIndex = 12
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'cekstok
        '
        Me.cekstok.Location = New System.Drawing.Point(584, 285)
        Me.cekstok.Name = "cekstok"
        Me.cekstok.Size = New System.Drawing.Size(79, 26)
        Me.cekstok.TabIndex = 11
        Me.cekstok.Text = "Cek Stok RM"
        Me.cekstok.UseVisualStyleBackColor = True
        '
        'DGVRM
        '
        Me.DGVRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRM.Location = New System.Drawing.Point(285, 111)
        Me.DGVRM.Name = "DGVRM"
        Me.DGVRM.Size = New System.Drawing.Size(409, 151)
        Me.DGVRM.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.telur)
        Me.GroupBox2.Controls.Add(Me.minyak)
        Me.GroupBox2.Controls.Add(Me.garam)
        Me.GroupBox2.Controls.Add(Me.terigu)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 144)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material yang Dibutuhkan"
        '
        'telur
        '
        Me.telur.Location = New System.Drawing.Point(94, 98)
        Me.telur.Name = "telur"
        Me.telur.Size = New System.Drawing.Size(98, 20)
        Me.telur.TabIndex = 7
        '
        'minyak
        '
        Me.minyak.Location = New System.Drawing.Point(94, 74)
        Me.minyak.Name = "minyak"
        Me.minyak.Size = New System.Drawing.Size(98, 20)
        Me.minyak.TabIndex = 6
        '
        'garam
        '
        Me.garam.Location = New System.Drawing.Point(94, 48)
        Me.garam.Name = "garam"
        Me.garam.Size = New System.Drawing.Size(98, 20)
        Me.garam.TabIndex = 5
        '
        'terigu
        '
        Me.terigu.Location = New System.Drawing.Point(94, 24)
        Me.terigu.Name = "terigu"
        Me.terigu.Size = New System.Drawing.Size(98, 20)
        Me.terigu.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Telur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Minyak Goreng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Garam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tepung Terigu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.idmie)
        Me.GroupBox1.Controls.Add(Me.safety)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.jenismie)
        Me.GroupBox1.Controls.Add(Me.jumlah)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 188)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produk yang Diproduksi"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Total Produksi"
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(90, 149)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(111, 20)
        Me.Total.TabIndex = 12
        '
        'idmie
        '
        Me.idmie.Location = New System.Drawing.Point(90, 29)
        Me.idmie.Name = "idmie"
        Me.idmie.Size = New System.Drawing.Size(111, 20)
        Me.idmie.TabIndex = 10
        '
        'safety
        '
        Me.safety.Location = New System.Drawing.Point(90, 113)
        Me.safety.Name = "safety"
        Me.safety.Size = New System.Drawing.Size(111, 20)
        Me.safety.TabIndex = 9
        Me.safety.Text = "10 pcs"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Safety Stock"
        '
        'jenismie
        '
        Me.jenismie.Location = New System.Drawing.Point(90, 57)
        Me.jenismie.Name = "jenismie"
        Me.jenismie.Size = New System.Drawing.Size(111, 20)
        Me.jenismie.TabIndex = 6
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(90, 84)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(111, 20)
        Me.jumlah.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jenis Mie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Mie"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Print)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Excel)
        Me.TabPage2.Controls.Add(Me.Dgvpro)
        Me.TabPage2.Controls.Add(Me.buatpesanan)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(711, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Proses Produksi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.Location = New System.Drawing.Point(585, 311)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(90, 33)
        Me.Print.TabIndex = 29
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.noinvoice)
        Me.GroupBox5.Controls.Add(Me.Cmbbatch)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.jadwal)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(29, 49)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(263, 98)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Produksi"
        '
        'noinvoice
        '
        Me.noinvoice.Location = New System.Drawing.Point(98, 44)
        Me.noinvoice.Name = "noinvoice"
        Me.noinvoice.Size = New System.Drawing.Size(155, 20)
        Me.noinvoice.TabIndex = 13
        '
        'Cmbbatch
        '
        Me.Cmbbatch.FormattingEnabled = True
        Me.Cmbbatch.Location = New System.Drawing.Point(98, 11)
        Me.Cmbbatch.Name = "Cmbbatch"
        Me.Cmbbatch.Size = New System.Drawing.Size(155, 21)
        Me.Cmbbatch.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Invoice"
        '
        'jadwal
        '
        Me.jadwal.Location = New System.Drawing.Point(98, 73)
        Me.jadwal.Name = "jadwal"
        Me.jadwal.Size = New System.Drawing.Size(155, 20)
        Me.jadwal.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Jadwal Produksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Kode Batch"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(585, 347)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 33)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "QC >>>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Excel
        '
        Me.Excel.Location = New System.Drawing.Point(585, 274)
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(90, 33)
        Me.Excel.TabIndex = 25
        Me.Excel.Text = "Export to Excel"
        Me.Excel.UseVisualStyleBackColor = True
        '
        'Dgvpro
        '
        Me.Dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvpro.Location = New System.Drawing.Point(316, 71)
        Me.Dgvpro.Name = "Dgvpro"
        Me.Dgvpro.Size = New System.Drawing.Size(359, 189)
        Me.Dgvpro.TabIndex = 24
        '
        'buatpesanan
        '
        Me.buatpesanan.Location = New System.Drawing.Point(202, 329)
        Me.buatpesanan.Name = "buatpesanan"
        Me.buatpesanan.Size = New System.Drawing.Size(90, 33)
        Me.buatpesanan.TabIndex = 23
        Me.buatpesanan.Text = "Buat Pesanan"
        Me.buatpesanan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mieid)
        Me.GroupBox3.Controls.Add(Me.Total_Pro)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.safetystock)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.jenis)
        Me.GroupBox3.Controls.Add(Me.demand)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 172)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Produk yang Diproduksi"
        '
        'mieid
        '
        Me.mieid.Location = New System.Drawing.Point(117, 29)
        Me.mieid.Name = "mieid"
        Me.mieid.Size = New System.Drawing.Size(111, 20)
        Me.mieid.TabIndex = 12
        '
        'Total_Pro
        '
        Me.Total_Pro.Location = New System.Drawing.Point(117, 140)
        Me.Total_Pro.Name = "Total_Pro"
        Me.Total_Pro.Size = New System.Drawing.Size(111, 20)
        Me.Total_Pro.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Total Produksi"
        '
        'safetystock
        '
        Me.safetystock.Location = New System.Drawing.Point(117, 113)
        Me.safetystock.Name = "safetystock"
        Me.safetystock.Size = New System.Drawing.Size(111, 20)
        Me.safetystock.TabIndex = 9
        Me.safetystock.Text = "10 pcs"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Safety Stock"
        '
        'jenis
        '
        Me.jenis.Location = New System.Drawing.Point(117, 57)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(111, 20)
        Me.jenis.TabIndex = 6
        '
        'demand
        '
        Me.demand.Location = New System.Drawing.Point(117, 84)
        Me.demand.Name = "demand"
        Me.demand.Size = New System.Drawing.Size(111, 20)
        Me.demand.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Jumlah yang diminta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Jenis Mie"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "ID Mie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPARTEMEN PRODUKSI"
        '
        'Produksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 557)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Produksi"
        Me.Text = "Produksi"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGVRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgvpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents plan As DateTimePicker
    Friend WithEvents KodeBatch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Status As Button
    Friend WithEvents purchase As Button
    Friend WithEvents Hitung As Button
    Friend WithEvents cekstok As Button
    Friend WithEvents DGVRM As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents telur As TextBox
    Friend WithEvents minyak As TextBox
    Friend WithEvents garam As TextBox
    Friend WithEvents terigu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Total As TextBox
    Friend WithEvents idmie As TextBox
    Friend WithEvents safety As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents jenismie As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Print As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents noinvoice As TextBox
    Friend WithEvents Cmbbatch As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents jadwal As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Excel As Button
    Friend WithEvents Dgvpro As DataGridView
    Friend WithEvents buatpesanan As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mieid As TextBox
    Friend WithEvents Total_Pro As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents safetystock As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents jenis As TextBox
    Friend WithEvents demand As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FG As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Invoice As ComboBox
End Class
