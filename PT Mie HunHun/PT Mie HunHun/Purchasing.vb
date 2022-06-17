Public Class Purchasing
    Sub NomorPO()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("select * from Order_RM where No_PO in (select max(No_PO) from Order_RM)", Conn)
        DM = CMD.ExecuteReader
        DM.Read()
        Dim urutankode As String
        Dim hitung As Long
        If Not DM.HasRows Then
            urutankode = "PO" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "PO" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtnoPO.Text = urutankode
    End Sub
    Sub kondisiawal()
        tglPO.Value = Today
    End Sub
    Sub KosongkanForm()
        Namapemesan.Text = ""
        Supplier.Text = ""
        batchcmb.Text = ""
        Nama.Text = ""
        jumlahorder.Text = ""
        satuanRM.Text = ""
        hargaRM.Text = ""
        txtnoPO.Focus()
    End Sub
    Sub MatikanForm()
        txtnoPO.Enabled = False
        Namapemesan.Enabled = False
        Supplier.Enabled = False
        Nama.Enabled = False
        satuanRM.Enabled = False
        hargaRM.Enabled = False
        jumlahorder.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtnoPO.Enabled = True
        Namapemesan.Enabled = True
        Supplier.Enabled = True
        Nama.Enabled = True
        batchcmb.Enabled = True
        satuanRM.Enabled = True
        hargaRM.Enabled = True
        jumlahorder.Enabled = True
        tglPO.Enabled = True
        tgl_kirim.Enabled = True
        cmbTOP.Enabled = True
    End Sub
    Sub Hidupkanbtn()
        Save.Enabled = True
        Edit.Enabled = True
        btnexit.Enabled = True
        Input.Enabled = True
        CetakPO.Enabled = True
        Delete.Enabled = True
        Cancel.Enabled = True
    End Sub
    Sub Matikanbtn()
        Edit.Enabled = False
        Delete.Enabled = False
        Cancel.Enabled = False
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from Purchasing", Conn)
        DS = New DataSet
        DA.Fill(DS)
        dgvPO.DataSource = DS.Tables(0)
        dgvPO.ReadOnly = True
    End Sub
    Private Sub Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        'Call TampilkanData()
        Call Matikanbtn()
        tglPO.Enabled = False
        tgl_kirim.Enabled = False
        cmbTOP.Enabled = False
        txtnoPO.Text = NoPO.Text
        Call kondisiawal()
        Call NomorPO()
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Call KosongkanForm()
        Call MatikanForm()
    End Sub
    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        Call NomorPO()
        Call HidupkanForm()
        Call KosongkanForm()
        Call Hidupkanbtn()
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim menu As New Main_Menu
        Me.Close()
        menu.Show()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If txtnoPO.Text = "" Or Supplier.Text = "" Or Namapemesan.Text = "" Or
           Nama.Text = "" Or jumlahorder.Text = "" Or satuanRM.Text = "" Or hargaRM.Text = "" Then
            MsgBox("Data Pesanan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Purchasing set Tanggal_PO = '" & tglPO.Value & "', Supplier = '" & Supplier.Text & "', Pemesan = '" & Namapemesan.Text & "', Kode_Batch = '" & batchcmb.Text & "',
           Nama_RM = '" & Nama.Text & "', Jumlah_Order = '" & jumlahorder.Text & "',  Satuan_RM = '" &
           satuanRM.Text & "', Harga_RM = '" & hargaRM.Text & "', Tanggal_Kirim = '" & tglkirim.Text & "' , Jangka_Waktu = '" & cmbTOP.Text & "' Where No_PO = '" & txtnoPO.Text & "'", Conn)

            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles batchcmb.SelectedIndexChanged

    End Sub
End Class