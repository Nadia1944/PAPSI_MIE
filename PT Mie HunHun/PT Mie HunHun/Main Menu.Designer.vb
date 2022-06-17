<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseFGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarehouseRMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.WarehouseFGToolStripMenuItem, Me.ProduksiToolStripMenuItem, Me.PurchasingToolStripMenuItem, Me.WarehouseRMToolStripMenuItem, Me.ToolStripMenuItem2, Me.QCToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(508, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.ToolStripMenuItem1.Text = "Marketing"
        '
        'WarehouseFGToolStripMenuItem
        '
        Me.WarehouseFGToolStripMenuItem.Name = "WarehouseFGToolStripMenuItem"
        Me.WarehouseFGToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.WarehouseFGToolStripMenuItem.Text = "Warehouse FG"
        '
        'ProduksiToolStripMenuItem
        '
        Me.ProduksiToolStripMenuItem.Name = "ProduksiToolStripMenuItem"
        Me.ProduksiToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProduksiToolStripMenuItem.Text = "Produksi"
        '
        'PurchasingToolStripMenuItem
        '
        Me.PurchasingToolStripMenuItem.Name = "PurchasingToolStripMenuItem"
        Me.PurchasingToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PurchasingToolStripMenuItem.Text = "Purchasing"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
        '
        'QCToolStripMenuItem
        '
        Me.QCToolStripMenuItem.Name = "QCToolStripMenuItem"
        Me.QCToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.QCToolStripMenuItem.Text = "QC"
        '
        'WarehouseRMToolStripMenuItem
        '
        Me.WarehouseRMToolStripMenuItem.Name = "WarehouseRMToolStripMenuItem"
        Me.WarehouseRMToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.WarehouseRMToolStripMenuItem.Text = "Warehouse RM"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WarehouseFGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents WarehouseRMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCToolStripMenuItem As ToolStripMenuItem
End Class
