<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()

        ' ── Kontrol asli (nama TIDAK boleh diubah) ───────────────────
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

        ' ── Kontrol UI baru (panel, label) ───────────────────────────
        pnlHeader = New Panel()
        pnlLeft = New Panel()
        pnlRight = New Panel()
        pnlDivider = New Panel()
        pnlHeaderSep = New Panel()
        pnlFormTitle = New Panel()
        pnlSearchBar = New Panel()
        pnlBottomBar = New Panel()
        pnlSepForm = New Panel()

        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblBrand = New Label()

        lblLNIK = New Label()
        lblLNama = New Label()
        lblLEmail = New Label()
        lblLJK = New Label()
        lblLHP = New Label()
        lblLGaji = New Label()
        lblLPwd = New Label()
        lblLRole = New Label()
        lblFormSec = New Label()
        lblTableSec = New Label()
        lblSearchIcon = New Label()
        lblPrintSec = New Label()

        CType(dgvKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlSearchBar.SuspendLayout()
        pnlBottomBar.SuspendLayout()
        pnlFormTitle.SuspendLayout()
        SuspendLayout()

        ' ═══════════════════════════════════════════════
        '  MENUSTRIP  –  navigasi atas (navy)
        ' ═══════════════════════════════════════════════
        MenuStrip1.BackColor = Color.FromArgb(11, 30, 61)
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnForm2, btnLogin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1060, 24)
        MenuStrip1.TabIndex = 21
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 0, 0, 0)

        btnForm2.Name = "btnForm2"
        btnForm2.Text = "📋  Data Tanggungan"
        btnForm2.ForeColor = Color.FromArgb(201, 168, 76)
        btnForm2.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        btnLogin.Name = "btnLogin"
        btnLogin.Text = "⏻  Logout"
        btnLogin.ForeColor = Color.FromArgb(242, 130, 130)
        btnLogin.Font = New Font("Segoe UI", 9)

        ' ═══════════════════════════════════════════════
        '  pnlHeader  –  bar judul navy di bawah menu
        ' ═══════════════════════════════════════════════
        pnlHeader.BackColor = Color.FromArgb(19, 41, 82)
        pnlHeader.Location = New Point(0, 24)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1060, 64)

        lblBrand.AutoSize = False
        lblBrand.BackColor = Color.FromArgb(201, 168, 76)
        lblBrand.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(11, 30, 61)
        lblBrand.Location = New Point(18, 12)
        lblBrand.Size = New Size(40, 40)
        lblBrand.Text = "PA"
        lblBrand.TextAlign = ContentAlignment.MiddleCenter

        lblHeaderTitle.AutoSize = False
        lblHeaderTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(68, 10)
        lblHeaderTitle.Size = New Size(400, 26)
        lblHeaderTitle.Text = "Data Karyawan"

        lblHeaderSub.AutoSize = False
        lblHeaderSub.Font = New Font("Segoe UI", 9)
        lblHeaderSub.ForeColor = Color.FromArgb(123, 141, 176)
        lblHeaderSub.Location = New Point(70, 36)
        lblHeaderSub.Size = New Size(500, 18)
        lblHeaderSub.Text = "Kelola data seluruh karyawan — NIK, profil, gaji, dan hak akses sistem"

        pnlHeaderSep.BackColor = Color.FromArgb(201, 168, 76)
        pnlHeaderSep.Location = New Point(0, 62)
        pnlHeaderSep.Size = New Size(1060, 2)

        pnlHeader.Controls.Add(lblBrand)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(pnlHeaderSep)

        ' ═══════════════════════════════════════════════
        '  pnlLeft  –  panel form input (putih)
        ' ═══════════════════════════════════════════════
        pnlLeft.BackColor = Color.White
        pnlLeft.Location = New Point(0, 90)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(368, 640)

        ' ── Judul section form ──
        pnlFormTitle.BackColor = Color.FromArgb(245, 247, 251)
        pnlFormTitle.Location = New Point(0, 0)
        pnlFormTitle.Size = New Size(368, 40)

        lblFormSec.AutoSize = False
        lblFormSec.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblFormSec.ForeColor = Color.FromArgb(11, 30, 61)
        lblFormSec.Location = New Point(14, 0)
        lblFormSec.Size = New Size(340, 40)
        lblFormSec.Text = "✏  FORM INPUT KARYAWAN"
        lblFormSec.TextAlign = ContentAlignment.MiddleLeft
        pnlFormTitle.Controls.Add(lblFormSec)

        Dim Px As Integer = 14   ' margin kiri dalam panel

        ' ── NIK ──
        lblLNIK.AutoSize = True
        lblLNIK.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLNIK.ForeColor = Color.FromArgb(123, 141, 176)
        lblLNIK.Location = New Point(Px, 52)
        lblLNIK.Text = "NIK KARYAWAN"

        txtNIK.BackColor = Color.FromArgb(245, 247, 251)
        txtNIK.BorderStyle = BorderStyle.FixedSingle
        txtNIK.Font = New Font("Segoe UI", 10)
        txtNIK.ForeColor = Color.FromArgb(11, 30, 61)
        txtNIK.Location = New Point(Px, 69)
        txtNIK.Margin = New Padding(3, 2, 3, 2)
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(338, 30)
        txtNIK.TabIndex = 4

        ' ── Nama ──
        lblLNama.AutoSize = True
        lblLNama.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLNama.ForeColor = Color.FromArgb(123, 141, 176)
        lblLNama.Location = New Point(Px, 110)
        lblLNama.Text = "NAMA LENGKAP"

        txtNama.BackColor = Color.FromArgb(245, 247, 251)
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10)
        txtNama.ForeColor = Color.FromArgb(11, 30, 61)
        txtNama.Location = New Point(Px, 127)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(338, 30)
        txtNama.TabIndex = 3

        ' ── Email ──
        lblLEmail.AutoSize = True
        lblLEmail.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLEmail.ForeColor = Color.FromArgb(123, 141, 176)
        lblLEmail.Location = New Point(Px, 168)
        lblLEmail.Text = "EMAIL"

        txtEmail.BackColor = Color.FromArgb(245, 247, 251)
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 10)
        txtEmail.ForeColor = Color.FromArgb(11, 30, 61)
        txtEmail.Location = New Point(Px, 185)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(338, 30)
        txtEmail.TabIndex = 11

        ' ── Jenis Kelamin ──
        lblLJK.AutoSize = True
        lblLJK.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLJK.ForeColor = Color.FromArgb(123, 141, 176)
        lblLJK.Location = New Point(Px, 226)
        lblLJK.Text = "JENIS KELAMIN"

        rdPria.AutoSize = True
        rdPria.Font = New Font("Segoe UI", 10)
        rdPria.ForeColor = Color.FromArgb(11, 30, 61)
        rdPria.Location = New Point(Px, 244)
        rdPria.Margin = New Padding(3, 2, 3, 2)
        rdPria.Name = "rdPria"
        rdPria.Size = New Size(54, 22)
        rdPria.TabIndex = 26
        rdPria.TabStop = True
        rdPria.Text = "Pria"
        rdPria.UseVisualStyleBackColor = True

        rdWanita.AutoSize = True
        rdWanita.Font = New Font("Segoe UI", 10)
        rdWanita.ForeColor = Color.FromArgb(11, 30, 61)
        rdWanita.Location = New Point(Px + 70, 244)
        rdWanita.Margin = New Padding(3, 2, 3, 2)
        rdWanita.Name = "rdWanita"
        rdWanita.Size = New Size(72, 22)
        rdWanita.TabIndex = 27
        rdWanita.TabStop = True
        rdWanita.Text = "Wanita"
        rdWanita.UseVisualStyleBackColor = True

        ' ── HP ──
        lblLHP.AutoSize = True
        lblLHP.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLHP.ForeColor = Color.FromArgb(123, 141, 176)
        lblLHP.Location = New Point(Px, 278)
        lblLHP.Text = "NO. HP"

        mtbHP.BackColor = Color.FromArgb(245, 247, 251)
        mtbHP.BorderStyle = BorderStyle.FixedSingle
        mtbHP.Font = New Font("Segoe UI", 10)
        mtbHP.ForeColor = Color.FromArgb(11, 30, 61)
        mtbHP.Location = New Point(Px, 295)
        mtbHP.Mask = "000000000000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(200, 30)
        mtbHP.TabIndex = 13

        ' ── Gaji ──
        lblLGaji.AutoSize = True
        lblLGaji.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLGaji.ForeColor = Color.FromArgb(123, 141, 176)
        lblLGaji.Location = New Point(Px, 336)
        lblLGaji.Text = "GAJI (RP)"

        txtGaji.BackColor = Color.FromArgb(245, 247, 251)
        txtGaji.BorderStyle = BorderStyle.FixedSingle
        txtGaji.Font = New Font("Segoe UI", 10)
        txtGaji.ForeColor = Color.FromArgb(11, 30, 61)
        txtGaji.Location = New Point(Px, 353)
        txtGaji.Margin = New Padding(3, 2, 3, 2)
        txtGaji.Name = "txtGaji"
        txtGaji.Size = New Size(200, 30)
        txtGaji.TabIndex = 24

        ' ── Password ──
        lblLPwd.AutoSize = True
        lblLPwd.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLPwd.ForeColor = Color.FromArgb(123, 141, 176)
        lblLPwd.Location = New Point(Px, 394)
        lblLPwd.Text = "PASSWORD"

        txtPassword.BackColor = Color.FromArgb(245, 247, 251)
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10)
        txtPassword.ForeColor = Color.FromArgb(11, 30, 61)
        txtPassword.Location = New Point(Px, 411)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(338, 30)
        txtPassword.TabIndex = 18

        ' ── Role ──
        lblLRole.AutoSize = True
        lblLRole.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLRole.ForeColor = Color.FromArgb(123, 141, 176)
        lblLRole.Location = New Point(Px, 452)
        lblLRole.Text = "ROLE AKSES"

        cbRole.BackColor = Color.FromArgb(245, 247, 251)
        cbRole.FlatStyle = FlatStyle.Flat
        cbRole.Font = New Font("Segoe UI", 10)
        cbRole.ForeColor = Color.FromArgb(11, 30, 61)
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"karyawan", "admin"})
        cbRole.Location = New Point(Px, 469)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(160, 28)
        cbRole.TabIndex = 22

        ' ── Garis pemisah sebelum tombol ──
        pnlSepForm.BackColor = Color.FromArgb(230, 235, 245)
        pnlSepForm.Location = New Point(0, 510)
        pnlSepForm.Size = New Size(368, 1)

        ' ── Tombol-tombol CRUD ──
        '  Tambah (hijau teal)
        btnSimpan.BackColor = Color.FromArgb(22, 160, 115)
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(14, 520)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 34)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "+ Tambah"
        btnSimpan.UseVisualStyleBackColor = False
        btnSimpan.Cursor = Cursors.Hand

        '  Ubah (biru)
        btnUbah.BackColor = Color.FromArgb(59, 130, 246)
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(96, 520)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(72, 34)
        btnUbah.TabIndex = 7
        btnUbah.Text = "✎ Ubah"
        btnUbah.UseVisualStyleBackColor = False
        btnUbah.Cursor = Cursors.Hand

        '  Hapus (merah)
        btnHapus.BackColor = Color.FromArgb(220, 80, 80)
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(174, 520)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(72, 34)
        btnHapus.TabIndex = 8
        btnHapus.Text = "🗑 Hapus"
        btnHapus.UseVisualStyleBackColor = False
        btnHapus.Cursor = Cursors.Hand

        '  Batal (abu-abu)
        btnBatal.BackColor = Color.FromArgb(180, 188, 206)
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(252, 520)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(72, 34)
        btnBatal.TabIndex = 9
        btnBatal.Text = "✖ Batal"
        btnBatal.UseVisualStyleBackColor = False
        btnBatal.Cursor = Cursors.Hand

        ' ── Rakit pnlLeft ──
        pnlLeft.Controls.Add(pnlFormTitle)
        pnlLeft.Controls.Add(lblLNIK)
        pnlLeft.Controls.Add(txtNIK)
        pnlLeft.Controls.Add(lblLNama)
        pnlLeft.Controls.Add(txtNama)
        pnlLeft.Controls.Add(lblLEmail)
        pnlLeft.Controls.Add(txtEmail)
        pnlLeft.Controls.Add(lblLJK)
        pnlLeft.Controls.Add(rdPria)
        pnlLeft.Controls.Add(rdWanita)
        pnlLeft.Controls.Add(lblLHP)
        pnlLeft.Controls.Add(mtbHP)
        pnlLeft.Controls.Add(lblLGaji)
        pnlLeft.Controls.Add(txtGaji)
        pnlLeft.Controls.Add(lblLPwd)
        pnlLeft.Controls.Add(txtPassword)
        pnlLeft.Controls.Add(lblLRole)
        pnlLeft.Controls.Add(cbRole)
        pnlLeft.Controls.Add(pnlSepForm)
        pnlLeft.Controls.Add(btnSimpan)
        pnlLeft.Controls.Add(btnUbah)
        pnlLeft.Controls.Add(btnHapus)
        pnlLeft.Controls.Add(btnBatal)

        ' ═══════════════════════════════════════════════
        '  pnlDivider  –  garis vertikal pemisah
        ' ═══════════════════════════════════════════════
        pnlDivider.BackColor = Color.FromArgb(220, 228, 240)
        pnlDivider.Location = New Point(368, 90)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1, 640)

        ' ═══════════════════════════════════════════════
        '  pnlRight  –  panel tabel (latar abu muda)
        ' ═══════════════════════════════════════════════
        pnlRight.BackColor = Color.FromArgb(248, 250, 253)
        pnlRight.Location = New Point(369, 90)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(691, 640)

        ' ── Header tabel ──
        lblTableSec.AutoSize = False
        lblTableSec.BackColor = Color.FromArgb(245, 247, 251)
        lblTableSec.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblTableSec.ForeColor = Color.FromArgb(11, 30, 61)
        lblTableSec.Location = New Point(0, 0)
        lblTableSec.Size = New Size(691, 36)
        lblTableSec.Text = "   📊  TABEL DATA KARYAWAN — Klik baris untuk memuat ke form"
        lblTableSec.TextAlign = ContentAlignment.MiddleLeft

        ' ── Search bar ──
        pnlSearchBar.BackColor = Color.White
        pnlSearchBar.Location = New Point(0, 36)
        pnlSearchBar.Size = New Size(691, 44)

        lblSearchIcon.AutoSize = True
        lblSearchIcon.Font = New Font("Segoe UI", 11)
        lblSearchIcon.ForeColor = Color.FromArgb(123, 141, 176)
        lblSearchIcon.Location = New Point(12, 12)
        lblSearchIcon.Text = "🔍"

        txtCari.BackColor = Color.White
        txtCari.BorderStyle = BorderStyle.None
        txtCari.Font = New Font("Segoe UI", 10)
        txtCari.ForeColor = Color.FromArgb(11, 30, 61)
        txtCari.Location = New Point(38, 13)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama atau NIK karyawan..."
        txtCari.Size = New Size(620, 22)
        txtCari.TabIndex = 15

        pnlSearchBar.Controls.Add(lblSearchIcon)
        pnlSearchBar.Controls.Add(txtCari)

        ' ── DataGridView ──
        Dim hdrStyle As New DataGridViewCellStyle()
        hdrStyle.BackColor = Color.FromArgb(11, 30, 61)
        hdrStyle.ForeColor = Color.White
        hdrStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        hdrStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        hdrStyle.Padding = New Padding(6, 0, 0, 0)

        Dim rowStyle As New DataGridViewCellStyle()
        rowStyle.BackColor = Color.White
        rowStyle.ForeColor = Color.FromArgb(11, 30, 61)
        rowStyle.SelectionBackColor = Color.FromArgb(219, 234, 254)
        rowStyle.SelectionForeColor = Color.FromArgb(11, 30, 61)
        rowStyle.Font = New Font("Segoe UI", 9)

        Dim altStyle As New DataGridViewCellStyle()
        altStyle.BackColor = Color.FromArgb(248, 250, 253)

        dgvKaryawan.AlternatingRowsDefaultCellStyle = altStyle
        dgvKaryawan.BackgroundColor = Color.FromArgb(248, 250, 253)
        dgvKaryawan.BorderStyle = BorderStyle.None
        dgvKaryawan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKaryawan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvKaryawan.ColumnHeadersDefaultCellStyle = hdrStyle
        dgvKaryawan.ColumnHeadersHeight = 38
        dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvKaryawan.DefaultCellStyle = rowStyle
        dgvKaryawan.EnableHeadersVisualStyles = False
        dgvKaryawan.GridColor = Color.FromArgb(225, 232, 245)
        dgvKaryawan.Location = New Point(0, 80)
        dgvKaryawan.Margin = New Padding(3, 2, 3, 2)
        dgvKaryawan.Name = "dgvKaryawan"
        dgvKaryawan.RowHeadersVisible = False
        dgvKaryawan.RowTemplate.Height = 36
        dgvKaryawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKaryawan.Size = New Size(691, 516)
        dgvKaryawan.TabIndex = 10

        ' ── Bar bawah (preview + cetak) ──
        pnlBottomBar.BackColor = Color.FromArgb(245, 247, 251)
        pnlBottomBar.Location = New Point(0, 596)
        pnlBottomBar.Size = New Size(691, 44)

        lblPrintSec.AutoSize = True
        lblPrintSec.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblPrintSec.ForeColor = Color.FromArgb(123, 141, 176)
        lblPrintSec.Location = New Point(12, 14)
        lblPrintSec.Text = "LAPORAN:"

        btnPreviewCetak.BackColor = Color.FromArgb(11, 30, 61)
        btnPreviewCetak.FlatStyle = FlatStyle.Flat
        btnPreviewCetak.FlatAppearance.BorderSize = 0
        btnPreviewCetak.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnPreviewCetak.ForeColor = Color.White
        btnPreviewCetak.Location = New Point(88, 7)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(110, 30)
        btnPreviewCetak.TabIndex = 28
        btnPreviewCetak.Text = "🔍 Preview Cetak"
        btnPreviewCetak.UseVisualStyleBackColor = False
        btnPreviewCetak.Cursor = Cursors.Hand

        btnCetak.BackColor = Color.FromArgb(201, 168, 76)
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnCetak.ForeColor = Color.FromArgb(11, 30, 61)
        btnCetak.Location = New Point(204, 7)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(90, 30)
        btnCetak.TabIndex = 29
        btnCetak.Text = "🖨 Cetak"
        btnCetak.UseVisualStyleBackColor = False
        btnCetak.Cursor = Cursors.Hand

        pnlBottomBar.Controls.Add(lblPrintSec)
        pnlBottomBar.Controls.Add(btnPreviewCetak)
        pnlBottomBar.Controls.Add(btnCetak)

        ' ── Rakit pnlRight ──
        pnlRight.Controls.Add(lblTableSec)
        pnlRight.Controls.Add(pnlSearchBar)
        pnlRight.Controls.Add(dgvKaryawan)
        pnlRight.Controls.Add(pnlBottomBar)

        ' ── PrintDocument & Preview (tidak perlu styling visual) ──
        dlgPreview.AutoScrollMargin = New Size(0, 0)
        dlgPreview.AutoScrollMinSize = New Size(0, 0)
        dlgPreview.ClientSize = New Size(400, 300)
        dlgPreview.Enabled = True
        dlgPreview.Name = "dlgPreview"
        dlgPreview.Visible = False

        ' ═══════════════════════════════════════════════
        '  Form1  –  konfigurasi form utama
        ' ═══════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 242, 247)
        ClientSize = New Size(1060, 730)
        Controls.Add(pnlRight)
        Controls.Add(pnlDivider)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1060, 730)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PA_PEMVIS — Data Karyawan"

        CType(dgvKaryawan, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        pnlFormTitle.ResumeLayout(False)
        pnlBottomBar.ResumeLayout(False)
        pnlBottomBar.PerformLayout()
        pnlRight.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' ── Deklarasi kontrol ASLI (nama tidak boleh berubah) ───────────
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

    ' ── Kontrol UI baru (private) ────────────────────────────────────
    Private pnlHeader As Panel
    Private pnlLeft As Panel
    Private pnlRight As Panel
    Private pnlDivider As Panel
    Private pnlHeaderSep As Panel
    Private pnlFormTitle As Panel
    Private pnlSearchBar As Panel
    Private pnlBottomBar As Panel
    Private pnlSepForm As Panel
    Private lblHeaderTitle As Label
    Private lblHeaderSub As Label
    Private lblBrand As Label
    Private lblLNIK As Label
    Private lblLNama As Label
    Private lblLEmail As Label
    Private lblLJK As Label
    Private lblLHP As Label
    Private lblLGaji As Label
    Private lblLPwd As Label
    Private lblLRole As Label
    Private lblFormSec As Label
    Private lblTableSec As Label
    Private lblSearchIcon As Label
    Private lblPrintSec As Label

End Class