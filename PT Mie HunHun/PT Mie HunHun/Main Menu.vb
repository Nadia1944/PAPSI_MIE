Public Class Main_Menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksiDB()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub QCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QCToolStripMenuItem.Click
        QC.Show()
    End Sub

    Private Sub DepartemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartemenToolStripMenuItem.Click
        Marketing.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        'Form_Report_Invoice.Show()
    End Sub

    Private Sub ProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduksiToolStripMenuItem.Click
        Produksi.Show()
    End Sub

    Private Sub PurchasingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasingToolStripMenuItem.Click
        Purchasing.Show()
    End Sub

    Private Sub WarehouseFGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehouseFGToolStripMenuItem.Click
        Warehouse_FG.Show()
    End Sub

    Private Sub WarehouseRMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehouseRMToolStripMenuItem.Click
        Warehouse_RM.Show()
    End Sub

    Friend Class Report_Produksi
        Public Sub New()
        End Sub
    End Class

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        Form_Report_Produksi.Show()
    End Sub
End Class
