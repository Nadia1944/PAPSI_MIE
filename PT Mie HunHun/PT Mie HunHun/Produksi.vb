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
        DA = New OleDb.OleDbDataAdapter("Select * from Produksi", Conn) 'gudang rm
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
        Total.Enabled = True
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
        Total.Text = ""
    End Sub
    Private Sub Produksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        Call Hidupkanform()
        Call Kosongkanform()
        Call Batch()
        Call idinvoice()
        Call matikanform()
    End Sub
    Sub idinvoice()
        Call koneksiDB()
        Try
            CMD = New OleDb.OleDbCommand("select * from Mark_Dis", Conn) 'select from marketing
            DM = CMD.ExecuteReader
            DM.Read()
            Invoice.Items.Clear()
            Do While DM.Read = True
                Invoice.Items.Add(DM.Item("Id_Pemesanan")) 'invoice marketing
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub matikanform()
        safetystock.Enabled = False
        safety.Enabled = False
    End Sub
End Class