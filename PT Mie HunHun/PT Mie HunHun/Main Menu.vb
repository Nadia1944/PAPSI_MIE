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
        'Form_Report_Invoice.show()
    End Sub
End Class
