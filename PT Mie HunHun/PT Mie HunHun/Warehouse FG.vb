Public Class Warehouse_FG

    Sub TampilkanData()
            Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Warehouse_FG ", Conn)
        DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
        End Sub
        Sub bersihkanproduksi()
            txtfgminus.Text = " "
            txtjmlminus.Text = " "
        End Sub
        Sub Nomorfakturotomatis()
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("Select * from FG_Prod where FG_Minus in (select max(FG_Minus) from FG_Prod)", Conn)
            Dim urutankode As String
            Dim hitung As Long
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                urutankode = "FG" + Format(Now, "ddMMyy") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(DM.GetString(0), 9) + 1
                urutankode = "FG" + Format(Now, "ddMMyy") +
                Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            txtfgminus.Text = urutankode
        End Sub
        Private Sub cmbinvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbinvoice.SelectedIndexChanged
            Try
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" select * from Marketing where Invoice = '" & cmbinvoice.Text & "'", Conn)
                DM = CMD.ExecuteReader
                If DM.HasRows = True Then
                    DM.Read()
                    cmbidmie.Text = DM.Item("ID_Mie")
                    txtjenis.Text = DM.Item("Jenis")
                    txtjml.Text = DM.Item("Jumlah") * 24
                    btnkirim.Focus()
                End If
            Catch ex As Exception
                MsgBox("Data Invoice Tidak Ditemukan")
            End Try
        End Sub
        Sub invoice()
            Call koneksiDB()
            Try
                CMD = New OleDb.OleDbCommand("select * from Marketing", Conn) 'select from marketing 
                DM = CMD.ExecuteReader
                DM.Read()
                cmbinvoice.Items.Clear()
                Do While DM.Read = True
                    cmbinvoice.Items.Add(DM.Item("Invoice"))
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
            Dim jumlahminus As String = $"insert into FG_Prod values('{txtfgminus.Text}','{txtjmlminus.Text}')"
            CMD = New OleDb.OleDbCommand(jumlahminus, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Kekurangan Produk Telah Di-input")
            Call bersihkanproduksi()
        End Sub

        Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
            txtfgminus.Enabled = True
            txtjmlminus.Enabled = True
            Call Nomorfakturotomatis()
        'CMD = New OleDb.OleDbCommand("SELECT * From Warehouse_FG where Id_Mie = '" & cmbidmie.Text & "'", Conn)
        'DM = CMD.ExecuteReader
        'DM.Read()
        'Dim hitung As String
        'hitung = ((DM.Item("Jumlah_Stok") - Val(txtjml.Text))) * (-1)
        'txtjmlminus.Text = hitung
        'CMD = New OleDb.OleDbCommand(hitung, Conn)
        'CMD.ExecuteNonQuery()
    End Sub
        Private Sub FG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call TampilkanData()
        Call invoice()
        txtfgminus.Enabled = False
            txtjmlminus.Enabled = False
        End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
