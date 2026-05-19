<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtNama = New TextBox()
        txtNIK = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvKaryawan = New DataGridView()
        txtEmail = New TextBox()
        mtbHP = New MaskedTextBox()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        txtPassword = New TextBox()
        MenuStrip1 = New MenuStrip()
        btnForm2 = New ToolStripMenuItem()
        btnLogin = New ToolStripMenuItem()
        cbRole = New ComboBox()
        txtGaji = New TextBox()
        rdPria = New RadioButton()
        rdWanita = New RadioButton()
        btnPreviewCetak = New Button()
        btnCetak = New Button()
        docLaporan = New Printing.PrintDocument()
        dlgPreview = New PrintPreviewDialog()
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(154, 106)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(404, 23)
        txtNama.TabIndex = 3
        ' 
        ' txtNIK
        ' 
        txtNIK.Location = New Point(154, 70)
        txtNIK.Margin = New Padding(3, 2, 3, 2)
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(404, 23)
        txtNIK.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnSimpan.FlatStyle = FlatStyle.Popup
        btnSimpan.Font = New Font("Helvetica", 9.0F)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(288, 388)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Tambah"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnUbah.FlatStyle = FlatStyle.Popup
        btnUbah.Font = New Font("Helvetica", 9.0F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(359, 388)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(65, 26)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnHapus.FlatStyle = FlatStyle.Popup
        btnHapus.Font = New Font("Helvetica", 9.0F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(430, 388)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnBatal.FlatStyle = FlatStyle.Popup
        btnBatal.Font = New Font("Helvetica", 9.0F)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(501, 388)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvKaryawan
        ' 
        dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKaryawan.Location = New Point(17, 460)
        dgvKaryawan.Margin = New Padding(3, 2, 3, 2)
        dgvKaryawan.Name = "dgvKaryawan"
        dgvKaryawan.RowHeadersWidth = 51
        dgvKaryawan.Size = New Size(569, 122)
        dgvKaryawan.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(154, 143)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(404, 23)
        txtEmail.TabIndex = 11
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(154, 216)
        mtbHP.Mask = "000000000000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(191, 23)
        mtbHP.TabIndex = 13
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(17, 433)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nik atau nama karyawan "
        txtCari.Size = New Size(219, 23)
        txtCari.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(154, 292)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(404, 23)
        txtPassword.TabIndex = 18
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnForm2, btnLogin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(614, 24)
        MenuStrip1.TabIndex = 21
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnForm2
        ' 
        btnForm2.Name = "btnForm2"
        btnForm2.Size = New Size(84, 20)
        btnForm2.Text = "tanggungan"
        ' 
        ' btnLogin
        ' 
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(54, 20)
        btnLogin.Text = "logout"
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"karyawan", "admin"})
        cbRole.Location = New Point(154, 325)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(121, 23)
        cbRole.TabIndex = 22
        ' 
        ' txtGaji
        ' 
        txtGaji.Location = New Point(156, 256)
        txtGaji.Margin = New Padding(3, 2, 3, 2)
        txtGaji.Name = "txtGaji"
        txtGaji.Size = New Size(189, 23)
        txtGaji.TabIndex = 24
        ' 
        ' rdPria
        ' 
        rdPria.AutoSize = True
        rdPria.Location = New Point(156, 180)
        rdPria.Margin = New Padding(3, 2, 3, 2)
        rdPria.Name = "rdPria"
        rdPria.Size = New Size(45, 19)
        rdPria.TabIndex = 26
        rdPria.TabStop = True
        rdPria.Text = "Pria"
        rdPria.UseVisualStyleBackColor = True
        ' 
        ' rdWanita
        ' 
        rdWanita.AutoSize = True
        rdWanita.Location = New Point(207, 180)
        rdWanita.Margin = New Padding(3, 2, 3, 2)
        rdWanita.Name = "rdWanita"
        rdWanita.Size = New Size(62, 19)
        rdWanita.TabIndex = 27
        rdWanita.TabStop = True
        rdWanita.Text = "Wanita"
        rdWanita.UseVisualStyleBackColor = True
        ' 
        ' btnPreviewCetak
        ' 
        btnPreviewCetak.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnPreviewCetak.FlatStyle = FlatStyle.Popup
        btnPreviewCetak.Font = New Font("Helvetica", 9.0F)
        btnPreviewCetak.ForeColor = Color.White
        btnPreviewCetak.Location = New Point(376, 419)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(92, 24)
        btnPreviewCetak.TabIndex = 28
        btnPreviewCetak.Text = "Preview Cetak"
        btnPreviewCetak.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnCetak.FlatStyle = FlatStyle.Popup
        btnCetak.Font = New Font("Helvetica", 9.0F)
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(474, 419)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(92, 24)
        btnCetak.TabIndex = 29
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(614, 593)
        Controls.Add(btnCetak)
        Controls.Add(btnPreviewCetak)
        Controls.Add(rdWanita)
        Controls.Add(rdPria)
        Controls.Add(txtGaji)
        Controls.Add(cbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtCari)
        Controls.Add(mtbHP)
        Controls.Add(txtEmail)
        Controls.Add(dgvKaryawan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtNIK)
        Controls.Add(txtNama)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Sistem Manajemen Data Karyawan PT.XYZ"
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnLogin As ToolStripMenuItem
    Friend WithEvents btnForm2 As ToolStripMenuItem
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents rdWanita As RadioButton
    Friend WithEvents rdPria As RadioButton
    Friend WithEvents btnPreviewCetak As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents docLaporan As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog

End Class
