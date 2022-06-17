<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warehouse_RM
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.kuranggaram = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kurangtelur = New System.Windows.Forms.TextBox()
        Me.kurangminyak = New System.Windows.Forms.TextBox()
        Me.Kurangtepung = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.garam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Batch = New System.Windows.Forms.ComboBox()
        Me.telur = New System.Windows.Forms.TextBox()
        Me.minyak = New System.Windows.Forms.TextBox()
        Me.tepung = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Cekstatus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(413, 194)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Data Warehouse"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(382, 160)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kuranggaram)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.kurangtelur)
        Me.GroupBox1.Controls.Add(Me.kurangminyak)
        Me.GroupBox1.Controls.Add(Me.Kurangtepung)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 180)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Warehouse RM"
        '
        'kuranggaram
        '
        Me.kuranggaram.Location = New System.Drawing.Point(165, 143)
        Me.kuranggaram.Name = "kuranggaram"
        Me.kuranggaram.Size = New System.Drawing.Size(110, 20)
        Me.kuranggaram.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Jumlah Kekurangan Garam "
        '
        'kurangtelur
        '
        Me.kurangtelur.Location = New System.Drawing.Point(165, 99)
        Me.kurangtelur.Name = "kurangtelur"
        Me.kurangtelur.Size = New System.Drawing.Size(110, 20)
        Me.kurangtelur.TabIndex = 11
        '
        'kurangminyak
        '
        Me.kurangminyak.Location = New System.Drawing.Point(165, 63)
        Me.kurangminyak.Name = "kurangminyak"
        Me.kurangminyak.Size = New System.Drawing.Size(110, 20)
        Me.kurangminyak.TabIndex = 10
        '
        'Kurangtepung
        '
        Me.Kurangtepung.Location = New System.Drawing.Point(165, 26)
        Me.Kurangtepung.Name = "Kurangtepung"
        Me.Kurangtepung.Size = New System.Drawing.Size(110, 20)
        Me.Kurangtepung.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jumlah Kekurangan Telur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Jumlah Kekurangan Minyak "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jumlah Kekurangan Tepung "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.garam)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Batch)
        Me.GroupBox3.Controls.Add(Me.telur)
        Me.GroupBox3.Controls.Add(Me.minyak)
        Me.GroupBox3.Controls.Add(Me.tepung)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 226)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kebutuhan Material"
        '
        'garam
        '
        Me.garam.Location = New System.Drawing.Point(165, 181)
        Me.garam.Name = "garam"
        Me.garam.Size = New System.Drawing.Size(110, 20)
        Me.garam.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jumlah Garam "
        '
        'Batch
        '
        Me.Batch.FormattingEnabled = True
        Me.Batch.Location = New System.Drawing.Point(165, 27)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(110, 21)
        Me.Batch.TabIndex = 12
        '
        'telur
        '
        Me.telur.Location = New System.Drawing.Point(165, 137)
        Me.telur.Name = "telur"
        Me.telur.Size = New System.Drawing.Size(110, 20)
        Me.telur.TabIndex = 11
        '
        'minyak
        '
        Me.minyak.Location = New System.Drawing.Point(165, 101)
        Me.minyak.Name = "minyak"
        Me.minyak.Size = New System.Drawing.Size(110, 20)
        Me.minyak.TabIndex = 10
        '
        'tepung
        '
        Me.tepung.Location = New System.Drawing.Point(165, 64)
        Me.tepung.Name = "tepung"
        Me.tepung.Size = New System.Drawing.Size(110, 20)
        Me.tepung.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jumlah Telur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah Minyak "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Jumlah Tepung "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Kode Batch "
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(232, 433)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 30)
        Me.btnsave.TabIndex = 56
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(948, 397)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 30)
        Me.btn_exit.TabIndex = 51
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Cekstatus
        '
        Me.Cekstatus.Location = New System.Drawing.Point(933, 338)
        Me.Cekstatus.Name = "Cekstatus"
        Me.Cekstatus.Size = New System.Drawing.Size(77, 32)
        Me.Cekstatus.TabIndex = 53
        Me.Cekstatus.Text = "Cek Status "
        Me.Cekstatus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(958, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 32)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Warehouse_RM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 485)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cekstatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Warehouse_RM"
        Me.Text = "Warehouse RM"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents kuranggaram As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents kurangtelur As TextBox
    Friend WithEvents kurangminyak As TextBox
    Friend WithEvents Kurangtepung As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents garam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Batch As ComboBox
    Friend WithEvents telur As TextBox
    Friend WithEvents minyak As TextBox
    Friend WithEvents tepung As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Cekstatus As Button
    Friend WithEvents Button1 As Button
End Class
