Public Class Produksi
    Sub Batch()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("select * from Produksi where Kode_Batch in (select max(Kode_Batch) from Produksi)", Conn)
        DM = CMD.ExecuteReader
        DM.Read()
        Dim urutankode As String
        Dim hitung As Long
        If Not DM.HasRows Then
            urutankode = "BA" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "BA" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        KodeBatch.Text = urutankode
    End Sub
    Sub Kondisiawal()
        plan.Value = Today
        jadwal.Value = plan.Value
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Produksi", Conn)
        DS = New DataSet
        DA.Fill(DS)
        Dgvpro.DataSource = DS.Tables(0)
        Dgvpro.ReadOnly = True
    End Sub
    Sub datatampil()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Warehouse_RM", Conn) 'gudang rm
        DS = New DataSet
        DA.Fill(DS)
        DGVRM.DataSource = DS.Tables(0)
        DGVRM.ReadOnly = True
    End Sub
    Sub Hidupkanform()
        KodeBatch.Enabled = True
        plan.Enabled = True
        idmie.Enabled = True
        jenismie.Enabled = True
        jumlah.Enabled = True
        terigu.Enabled = True
        garam.Enabled = True
        minyak.Enabled = True
        telur.Enabled = True
        noinvoice.Enabled = True
        Cmbbatch.Enabled = True
        jadwal.Enabled = True
        mieid.Enabled = True
        jenis.Enabled = True
        demand.Enabled = True
        Total_Pro.Enabled = True
    End Sub
    Sub Kosongkanform()
        KodeBatch.Text = ""
        idmie.Text = ""
        jenismie.Text = ""
        jumlah.Text = ""
        terigu.Text = ""
        garam.Text = ""
        minyak.Text = ""
        telur.Text = ""
        noinvoice.Text = ""
        Cmbbatch.Text = ""
        mieid.Text = ""
        jenis.Text = ""
        demand.Text = ""
        Total_Pro.Text = ""
        Total.Text = ""
    End Sub
    Private Sub Produksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        Call Hidupkanform()
        Call Kosongkanform()
        Call Batch()
        Call idinvoice()
        Call matikanform()
        Call batchcode()
    End Sub
    Sub idinvoice()
        Call koneksiDB()
        Try
            CMD = New OleDb.OleDbCommand("select * from Marketing", Conn) 'select from marketing
            DM = CMD.ExecuteReader
            DM.Read()
            Invoice.Items.Clear()
            Do While DM.Read = True
                Invoice.Items.Add(DM.Item("Invoice")) 'invoice marketing
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub matikanform()
        safetystock.Enabled = False
        safety.Enabled = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles buatpesanan.Click
        If noinvoice.Text = "" Or Cmbbatch.Text = "" Or
             mieid.Text = "" Or jenis.Text = "" Or demand.Text = "" Or Total_Pro.Text = "" Then
            MsgBox("Data Rencana Produksi Belum Lengkap")
            Exit Sub
        Else
            MsgBox("Pesanan Sedang Dibuat")
        End If
        Call TampilkanData()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        CMD = New OleDb.OleDbCommand("select * from Marketing where Jumlah = '" & jumlah.Text & "'", Conn)
        DM = CMD.ExecuteReader
        DM.Read()
        Dim totalproduksi As Integer
        totalproduksi = DM.Item("Jumlah") + 10
        Total.Text = (totalproduksi)
        Total.Text = (totalproduksi)
        Dim tepung, asin, goreng, telorr As Integer
        tepung = ((DM.Item("Jumlah") * 24) + 10) * 0.5
        asin = ((DM.Item("Jumlah") * 24) + 10) * 0.5
        goreng = ((DM.Item("Jumlah") * 24) + 10) * 0.25
        telorr = ((DM.Item("Jumlah") * 24) + 10) * 2
        terigu.Text = (tepung & " Kg")
        garam.Text = (asin & " sdm")
        minyak.Text = (goreng & " ml")
        telur.Text = (telorr & " butir")
    End Sub
    Private Sub Invoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Invoice.SelectedIndexChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Marketing where Invoice ='" & Invoice.Text & "'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                idmie.Text = DM.Item("ID_Mie")
                jenismie.Text = DM.Item("Jenis")
                jumlah.Text = DM.Item("Jumlah")

                idmie.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Invoice Tidak Ditemukan")
        End Try
    End Sub
    Private Sub purchase_Click(sender As Object, e As EventArgs) Handles purchase.Click
        Purchasing.Show()
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Invoice.Text = "" Or KodeBatch.Text = "" Or
             idmie.Text = "" Or jenismie.Text = "" Or jumlah.Text = "" Or terigu.Text = "" Or
             garam.Text = "" Or minyak.Text = "" Or telur.Text = "" Then
            MsgBox("Data Rencana Produksi Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Produksi where Kode_batch ='" & KodeBatch.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Produksi values ('" & KodeBatch.Text & "', '" & Invoice.Text & "', '" & idmie.Text & "','" & jenismie.Text & "','" & jumlah.Text & "','" & plan.Value & "','" & terigu.Text & "','" & garam.Text & "','" & minyak.Text & "','" & telur.Text & "','" & Total.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Jadwal Produksi Berhasil Ditambahkan")
            Else
                MsgBox("Jadwal Sudah Ada")
            End If
            Call Kosongkanform()
            Call Kondisiawal()
            Call Batch()
        End If
    End Sub
    Sub batchcode()
        Call koneksiDB()
        Try
            CMD = New OleDb.OleDbCommand("select * from Produksi", Conn) 'select from marketing
            DM = CMD.ExecuteReader
            DM.Read()
            Cmbbatch.Items.Clear()
            Do While DM.Read = True
                Cmbbatch.Items.Add(DM.Item("Kode_Batch")) 'invoice marketing
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cmbbatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbbatch.SelectedIndexChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Produksi where Kode_Batch ='" & Cmbbatch.Text & "'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                Cmbbatch.Text = DM.Item("Kode_Batch")
                noinvoice.Text = DM.Item("Invoice")
                jadwal.Value = DM.Item("Jadwal_Produksi")
                mieid.Text = DM.Item("ID_Mie")
                jenis.Text = DM.Item("Jenis_Mie")
                demand.Text = DM.Item("Jumlah")
                Total_Pro.Text = DM.Item("Total_Produksi")
                Cmbbatch.Focus()
            End If
        Catch ex As Exception
            MsgBox("Data Batch Tidak Ditemukan")
        End Try
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        'ini buat nampilin report produksi
    End Sub

    Private Sub Dgvpro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvpro.CellContentClick
        On Error Resume Next
        Cmbbatch.Text = Dgvpro.Rows(e.RowIndex).Cells(0).Value
        noinvoice.Text = Dgvpro.Rows(e.RowIndex).Cells(1).Value
        jadwal.Value = Dgvpro.Rows(e.RowIndex).Cells(2).Value
        mieid.Text = Dgvpro.Rows(e.RowIndex).Cells(3).Value
        jenismie.Text = Dgvpro.Rows(e.RowIndex).Cells(4).Value
        demand.Text = Dgvpro.Rows(e.RowIndex).Cells(5).Value
        safetystock.Text = Dgvpro.Rows(e.RowIndex).Cells(6).Value
        Total_Pro.Text = Dgvpro.Rows(e.RowIndex).Cells(7).Value
        Call Hidupkanform()
        Cmbbatch.Enabled = False
    End Sub
End Class