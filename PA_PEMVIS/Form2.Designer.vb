<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        cbNik = New ComboBox()
        cbStatus = New ComboBox()
        txtNama = New TextBox()
        txtHubungan = New TextBox()
        dgvTanggungan = New DataGridView()
        btnSimpan = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1 = New MenuStrip()
        btnKaryawan = New ToolStripMenuItem()
        btnLogout = New ToolStripMenuItem()
        btnCetak = New Button()
        btnPreviewCetak = New Button()
        docLaporan = New Printing.PrintDocument()
        dlgPreview = New PrintPreviewDialog()
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbNik
        ' 
        cbNik.FormattingEnabled = True
        cbNik.Location = New Point(138, 68)
        cbNik.Name = "cbNik"
        cbNik.Size = New Size(336, 23)
        cbNik.TabIndex = 4
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Bekerja", "TIdak Bekerja", "Meninggal Dunia"})
        cbStatus.Location = New Point(138, 215)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(178, 23)
        cbStatus.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(138, 120)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(336, 23)
        txtNama.TabIndex = 6
        ' 
        ' txtHubungan
        ' 
        txtHubungan.Location = New Point(138, 168)
        txtHubungan.Name = "txtHubungan"
        txtHubungan.Size = New Size(336, 23)
        txtHubungan.TabIndex = 7
        ' 
        ' dgvTanggungan
        ' 
        dgvTanggungan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTanggungan.Location = New Point(27, 304)
        dgvTanggungan.Name = "dgvTanggungan"
        dgvTanggungan.Size = New Size(539, 117)
        dgvTanggungan.TabIndex = 8
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnSimpan.FlatStyle = FlatStyle.Popup
        btnSimpan.Font = New Font("Helvetica", 9F)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(489, 78)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnBatal.FlatStyle = FlatStyle.Popup
        btnBatal.Font = New Font("Helvetica", 9F)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(489, 182)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnHapus.FlatStyle = FlatStyle.Popup
        btnHapus.Font = New Font("Helvetica", 9F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(489, 148)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnUbah.FlatStyle = FlatStyle.Popup
        btnUbah.Font = New Font("Helvetica", 9F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(489, 115)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(65, 26)
        btnUbah.TabIndex = 10
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(27, 276)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(539, 23)
        txtCari.TabIndex = 23
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnKaryawan, btnLogout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(578, 24)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnKaryawan
        ' 
        btnKaryawan.Name = "btnKaryawan"
        btnKaryawan.Size = New Size(69, 20)
        btnKaryawan.Text = "karyawan"
        ' 
        ' btnLogout
        ' 
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(57, 20)
        btnLogout.Text = "Logout"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnCetak.FlatStyle = FlatStyle.Popup
        btnCetak.Font = New Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(403, 214)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 25
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnPreviewCetak
        ' 
        btnPreviewCetak.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnPreviewCetak.FlatStyle = FlatStyle.Popup
        btnPreviewCetak.Font = New Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreviewCetak.ForeColor = Color.White
        btnPreviewCetak.Location = New Point(322, 215)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(75, 23)
        btnPreviewCetak.TabIndex = 26
        btnPreviewCetak.Text = "Preview"
        btnPreviewCetak.UseVisualStyleBackColor = False
        ' 
        ' docLaporan
        ' 
        ' 
        ' dlgPreview
        ' 
        dlgPreview.AutoScrollMargin = New Size(0, 0)
        dlgPreview.AutoScrollMinSize = New Size(0, 0)
        dlgPreview.ClientSize = New Size(400, 300)
        dlgPreview.Enabled = True
        dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), Icon)
        dlgPreview.Name = "dlgPreview"
        dlgPreview.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(578, 443)
        Controls.Add(btnPreviewCetak)
        Controls.Add(btnCetak)
        Controls.Add(txtCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvTanggungan)
        Controls.Add(txtHubungan)
        Controls.Add(txtNama)
        Controls.Add(cbStatus)
        Controls.Add(cbNik)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Sistem Manajemen Data Karyawan PT.XYZ"
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbNik As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHubungan As TextBox
    Friend WithEvents dgvTanggungan As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnLogout As ToolStripMenuItem
    Friend WithEvents btnKaryawan As ToolStripMenuItem
    Friend WithEvents btnPreviewCetak As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents docLaporan As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
