<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warehouse_FG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btninput = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtjmlminus = New System.Windows.Forms.TextBox()
        Me.txtfgminus = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnkirim = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtjml = New System.Windows.Forms.TextBox()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.cmbidmie = New System.Windows.Forms.ComboBox()
        Me.cmbinvoice = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(12, 262)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 22)
        Me.btninput.TabIndex = 13
        Me.btninput.Text = "INPUT"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(480, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(137, 262)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 22)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtjmlminus)
        Me.GroupBox2.Controls.Add(Me.txtfgminus)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 71)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produksi"
        '
        'txtjmlminus
        '
        Me.txtjmlminus.Location = New System.Drawing.Point(107, 39)
        Me.txtjmlminus.Name = "txtjmlminus"
        Me.txtjmlminus.Size = New System.Drawing.Size(83, 20)
        Me.txtjmlminus.TabIndex = 8
        '
        'txtfgminus
        '
        Me.txtfgminus.Location = New System.Drawing.Point(107, 13)
        Me.txtfgminus.Name = "txtfgminus"
        Me.txtfgminus.Size = New System.Drawing.Size(83, 20)
        Me.txtfgminus.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Produksi    :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No    :"
        '
        'btnkirim
        '
        Me.btnkirim.Location = New System.Drawing.Point(137, 135)
        Me.btnkirim.Name = "btnkirim"
        Me.btnkirim.Size = New System.Drawing.Size(75, 22)
        Me.btnkirim.TabIndex = 9
        Me.btnkirim.Text = "KIRIM"
        Me.btnkirim.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(229, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(326, 151)
        Me.DataGridView1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtjml)
        Me.GroupBox1.Controls.Add(Me.txtjenis)
        Me.GroupBox1.Controls.Add(Me.cmbidmie)
        Me.GroupBox1.Controls.Add(Me.cmbinvoice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Masuk"
        '
        'txtjml
        '
        Me.txtjml.Location = New System.Drawing.Point(71, 84)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(121, 20)
        Me.txtjml.TabIndex = 7
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(71, 63)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(121, 20)
        Me.txtjenis.TabIndex = 6
        '
        'cmbidmie
        '
        Me.cmbidmie.FormattingEnabled = True
        Me.cmbidmie.Location = New System.Drawing.Point(71, 42)
        Me.cmbidmie.Name = "cmbidmie"
        Me.cmbidmie.Size = New System.Drawing.Size(121, 21)
        Me.cmbidmie.TabIndex = 5
        '
        'cmbinvoice
        '
        Me.cmbinvoice.FormattingEnabled = True
        Me.cmbinvoice.Location = New System.Drawing.Point(71, 20)
        Me.cmbinvoice.Name = "cmbinvoice"
        Me.cmbinvoice.Size = New System.Drawing.Size(121, 21)
        Me.cmbinvoice.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah    :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Mie    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice    :"
        '
        'Warehouse_FG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 287)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnkirim)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Warehouse_FG"
        Me.Text = "Warehouse_FG"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btninput As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtjmlminus As TextBox
    Friend WithEvents txtfgminus As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnkirim As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtjml As TextBox
    Friend WithEvents txtjenis As TextBox
    Friend WithEvents cmbidmie As ComboBox
    Friend WithEvents cmbinvoice As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
