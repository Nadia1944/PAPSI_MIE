Public Class QC
    Sub Nomorfakturotomatis()
        Call koneksiDB()
        CMD = New OleDb.OleDbCommand("Select * from QC where ID_QC in (select max(ID_QC) from QC)", Conn)
        Dim urutankode As String
        Dim hitung As Long
        DM = CMD.ExecuteReader
        DM.Read()
        If Not DM.HasRows Then
            urutankode = "QC" + Format(Now, "ddMMyy") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
            urutankode = "QC" + Format(Now, "ddMMyy") +
            Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtidqc.Text = urutankode
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from QC", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Sub kodebatch()
        Call koneksiDB()
        Try
            CMD = New OleDb.OleDbCommand("select * from Produksi", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            cmbbatch.Items.Clear()
            Do While DM.Read = True
                'Menambahkan isi combo box dari field/kolom No_faktur
                cmbbatch.Items.Add(DM.Item("Kode_Batch"))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub rumuslayak()
        Dim layak As String
        layak = Val(txtproduksi.Text) - Val(txtdefect.Text)
        txtlayak.Text = layak
    End Sub
    Sub kondisiawal()
        tglcek.Text = Today
    End Sub
    Sub bersihkanform()
        txtpj.Text = ""
        cmbbatch.Text = ""
        txtproduksi.Text = ""
        txtdefect.Text = ""
        txtlayak.Text = ""
        txtpj.Focus()
    End Sub

    Private Sub cmbbatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbatch.SelectedIndexChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("select * from Produksi where Kode_Batch = '" & cmbbatch.Text & "'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                txtproduksi.Text = DM.Item("Total_Produksi")
                txtdefect.Focus()
            End If
        Catch ex As Exception
            MsgBox("Kode Batch Tidak Ditemukan")
        End Try
    End Sub

    Private Sub txtdefect_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdefect.KeyPress
        If e.KeyChar = Chr(13) Then
            Call rumuslayak()
            btnsimpan.Focus()
        End If
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtidqc.Text = "" Or txtpj.Text = "" Or cmbbatch.Text = "" Or txtproduksi.Text = "" Or txtdefect.Text = "" Or txtlayak.Text = "" Then
            MsgBox("Data QC Belum Lengkap")
        Else
            Dim simpanqc As String = $"Insert into QC values('{txtidqc.Text}','{txtpj.Text}','{cmbbatch.Text}','{tglcek.Value.ToString()}','{txtproduksi.Text}','{txtdefect.Text}','{txtlayak.Text}')"
            '$"insert into Ticket values ('{nama textbox-nya}', '{nama textbox-nya}')"
            CMD = New OleDb.OleDbCommand(simpanqc, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data QC Telah Tersimpan")
            Call bersihkanform()
            Call kondisiawal()
            Call Nomorfakturotomatis()
            Call TampilkanData()
        End If
    End Sub
    Private Sub Marketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Nomorfakturotomatis()
        Call TampilkanData()
        Call kodebatch()
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Main_Menu.Show()
    End Sub
End Class