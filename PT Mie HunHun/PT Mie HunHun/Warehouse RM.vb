Public Class Warehouse_RM

    Sub KosongkanForm()
        Batch.Text = ""
        tepung.Text = ""
        minyak.Text = ""
        telur.Text = ""
        garam.Text = ""
        Kurangtepung.Text = ""
        kurangminyak.Text = ""
        kurangtelur.Text = ""
        kuranggaram.Text = ""
    End Sub
    Sub MatikanForm()
        Batch.Enabled = False
        tepung.Enabled = False
        minyak.Enabled = False
        telur.Enabled = False
        garam.Enabled = False
        Kurangtepung.Enabled = False
        kurangminyak.Enabled = False
        kurangtelur.Enabled = False
        kuranggaram.Enabled = False

    End Sub
    Sub HidupkanForm()
        Batch.Enabled = True
        tepung.Enabled = False
        minyak.Enabled = False
        telur.Enabled = False
        garam.Enabled = False
        Kurangtepung.Enabled = True
        kurangminyak.Enabled = True
        kurangtelur.Enabled = True
        kuranggaram.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from RM ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub



    Private Sub Batch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Batch.SelectedIndexChanged
        Try
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Produksi where Kode_Batch = '" & Batch.Text & "'", Conn)
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                Batch.Text = DM.Item("Kode_Batch")
                tepung.Text = DM.Item("Tepung_terigu")
                minyak.Text = DM.Item("Minyak")
                telur.Text = DM.Item("Telur")
                garam.Text = DM.Item("Garam")
                Batch.Focus()
            End If
        Catch ex As Exception
            MsgBox("Kode Batch Tidak Ditemukan")
        End Try
    End Sub

    Private Sub Warehouse_RM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilkanData()
        Call Kodebatch()
    End Sub
    Sub Kodebatch()
        Call koneksiDB()
        Try
            CMD = New OleDb.OleDbCommand("select * from Produksi", Conn) 'select from marketing 
            DM = CMD.ExecuteReader
            DM.Read()
            Batch.Items.Clear()
            Do While DM.Read = True
                Batch.Items.Add(DM.Item("Kode_Batch"))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Sub hitung()
    'Try
    'Call koneksiDB()
    'CMD = New OleDb.OleDbCommand(" select * from RM , Conn")
    ' DM = CMD.ExecuteReader
    'If DM.HasRows = True Then
    '           DM.Read()
    '          Kurangtepung.Text = (DM.Item("Stok_Tepung") - Val(tepung.Text)) * (-1)
    '         kurangminyak.Text = (DM.Item("Stok_Minyak") - Val(minyak.Text)) * (-1)
    '        kurangtelur.Text = (DM.Item("Stok_Telur") - Val(telur.Text)) * (-1)
    '       kuranggaram.Text = (DM.Item("Stok_Garam") - Val(garam.Text)) * (-1)
    '      Batch.Focus()
    'End If
    'Catch ex As Exception
    '       MsgBox("Data Tidak Ditemukan")
    'End Try


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim kekuranganRM As String = $"insert into Beli_RM values('{Batch.Text}','{Kurangtepung.Text}','{kurangminyak.Text}',' {kurangtelur.Text}',' {kuranggaram.Text}')"
        CMD = New OleDb.OleDbCommand(kekuranganRM, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Kekurangan RM Telah Di-input")
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class

