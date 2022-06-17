Public Class Marketing
    Sub Nomorfakturotomatis()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("Select * from Marketing where Invoice in (select max(Invoice) from Marketing)", Conn)
        Dim urutankode As String
        Dim hitung As Long
        DM = CMD.ExecuteReader
        DM.Read()
        If Not DM.HasRows Then
            urutankode = "OM" + Format(Now, "ddMMyy") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "OM" + Format(Now, "ddMMyy") +
            Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtinvoice.Text = urutankode
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Marketing", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Sub RumusGrandTotal()
        Dim hitung As Integer = 0
        hitung = Val(txtharga.Text) * Val(txtjumlah.Text) * 24 + Val(txtongkir.Text)
        txtgrand.Text = hitung
    End Sub
    Sub bersihinputbaru()
        txtidmie.Text = ""
        cmb_jenis.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        cmb_jenis.Focus()
    End Sub
    Sub kondisiawal()
        tglorder.Text = Today
    End Sub
    Sub bersihkanform()
        txtnama.Text = ""
        txtalamat.Text = ""
        txtidmie.Text = ""
        cmb_jenis.Text = ""
        txtjumlah.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub cmb_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis.SelectedIndexChanged
        If cmb_jenis.SelectedItem = "Mie Pipih" Then
            txtidmie.Text = "M001"
            txtharga.Text = "4000"
        ElseIf cmb_jenis.SelectedItem = "Mie Kering" Then
            txtidmie.Text = "M002"
            txtharga.Text = "4500"
        End If
        txtjumlah.Focus()
    End Sub
    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            Call RumusGrandTotal()
            txtbayar.Focus()
        End If
    End Sub
    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txtgrand.Text) Then
                MsgBox("Maaf Uang Pembayaran Kurang")
            ElseIf Val(txtbayar.Text) = Val(txtgrand.Text) Then
                txtkembalian.Text = 0
            ElseIf Val(txtbayar.Text) > Val(txtgrand.Text) Then
                txtkembalian.Text = Val(txtbayar.Text) - Val(txtgrand.Text)
                btn_simpan.Focus()
            End If
        End If
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txtinvoice.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtidmie.Text = "" Or cmb_jenis.Text = "" Or txtjumlah.Text = "" Then
            MsgBox("Data Transaksi Belum Lengkap")
        Else
            Dim subtotal As String
            subtotal = Val(txtharga.Text) * Val(txtjumlah.Text) * 24
            Dim statusorder As String
            statusorder = "Belum Dikirim"
            Dim simpanmarketing As String = $"Insert into Marketing values('{txtinvoice.Text}','{tglorder.Value.ToString()}','{txtnama.Text}','{txtalamat.Text}','{txtongkir.Text}','{txtidmie.Text}','{cmb_jenis.Text}','{txtharga.Text}','{txtjumlah.Text}','{subtotal}','{txtgrand.Text}','{txtbayar.Text}','{txtkembalian.Text}','{statusorder}')"
            '$"insert into Ticket values ('{nama textbox-nya}', '{nama textbox-nya}')"
            CMD = New OleDb.OleDbCommand(simpanmarketing, Conn)
            CMD.ExecuteNonQuery()
            'Data disimpan di tabel Receipt_Naili
            MsgBox("Data Order Telah Tersimpan")
            Call bersihkanform()
            Call kondisiawal()
            Call Nomorfakturotomatis()
            Call TampilkanData()
        End If
    End Sub
    Private Sub Marketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Nomorfakturotomatis()
        Call TampilkanData()
    End Sub
End Class