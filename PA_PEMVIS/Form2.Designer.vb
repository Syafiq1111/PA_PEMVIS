<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()

        ' ── Kontrol asli (nama TIDAK boleh diubah) ───────────────────
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

        ' ── Kontrol UI baru ───────────────────────────────────────────
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
        lblLNik = New Label()
        lblLNama = New Label()
        lblLHubungan = New Label()
        lblLStatus = New Label()
        lblFormSec = New Label()
        lblTableSec = New Label()
        lblSearchIcon = New Label()
        lblPrintSec = New Label()

        CType(dgvTanggungan, ComponentModel.ISupportInitialize).BeginInit()
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
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnKaryawan, btnLogout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(980, 24)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 0, 0, 0)

        btnKaryawan.Name = "btnKaryawan"
        btnKaryawan.Text = "👤  Data Karyawan"
        btnKaryawan.ForeColor = Color.FromArgb(201, 168, 76)
        btnKaryawan.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        btnLogout.Name = "btnLogout"
        btnLogout.Text = "⏻  Logout"
        btnLogout.ForeColor = Color.FromArgb(242, 130, 130)
        btnLogout.Font = New Font("Segoe UI", 9)

        ' ═══════════════════════════════════════════════
        '  pnlHeader  –  bar judul navy
        ' ═══════════════════════════════════════════════
        pnlHeader.BackColor = Color.FromArgb(19, 41, 82)
        pnlHeader.Location = New Point(0, 24)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(980, 64)

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
        lblHeaderTitle.Size = New Size(500, 26)
        lblHeaderTitle.Text = "Data Tanggungan Karyawan"

        lblHeaderSub.AutoSize = False
        lblHeaderSub.Font = New Font("Segoe UI", 9)
        lblHeaderSub.ForeColor = Color.FromArgb(123, 141, 176)
        lblHeaderSub.Location = New Point(70, 36)
        lblHeaderSub.Size = New Size(500, 18)
        lblHeaderSub.Text = "Kelola data tanggungan (keluarga) yang terhubung ke karyawan via NIK"

        pnlHeaderSep.BackColor = Color.FromArgb(201, 168, 76)
        pnlHeaderSep.Location = New Point(0, 62)
        pnlHeaderSep.Size = New Size(980, 2)

        pnlHeader.Controls.Add(lblBrand)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(pnlHeaderSep)

        ' ═══════════════════════════════════════════════
        '  pnlLeft  –  panel form input
        ' ═══════════════════════════════════════════════
        pnlLeft.BackColor = Color.White
        pnlLeft.Location = New Point(0, 90)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(340, 570)

        ' ── Judul section ──
        pnlFormTitle.BackColor = Color.FromArgb(245, 247, 251)
        pnlFormTitle.Location = New Point(0, 0)
        pnlFormTitle.Size = New Size(340, 40)

        lblFormSec.AutoSize = False
        lblFormSec.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblFormSec.ForeColor = Color.FromArgb(11, 30, 61)
        lblFormSec.Location = New Point(14, 0)
        lblFormSec.Size = New Size(312, 40)
        lblFormSec.Text = "✏  FORM INPUT TANGGUNGAN"
        lblFormSec.TextAlign = ContentAlignment.MiddleLeft
        pnlFormTitle.Controls.Add(lblFormSec)

        Dim Px As Integer = 14

        ' ── NIK Karyawan ──
        lblLNik.AutoSize = True
        lblLNik.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLNik.ForeColor = Color.FromArgb(123, 141, 176)
        lblLNik.Location = New Point(Px, 52)
        lblLNik.Text = "NIK KARYAWAN"

        cbNik.BackColor = Color.FromArgb(245, 247, 251)
        cbNik.FlatStyle = FlatStyle.Flat
        cbNik.Font = New Font("Segoe UI", 10)
        cbNik.ForeColor = Color.FromArgb(11, 30, 61)
        cbNik.FormattingEnabled = True
        cbNik.Location = New Point(Px, 69)
        cbNik.Name = "cbNik"
        cbNik.Size = New Size(310, 28)
        cbNik.TabIndex = 4

        ' ── Nama Tanggungan ──
        lblLNama.AutoSize = True
        lblLNama.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLNama.ForeColor = Color.FromArgb(123, 141, 176)
        lblLNama.Location = New Point(Px, 110)
        lblLNama.Text = "NAMA TANGGUNGAN"

        txtNama.BackColor = Color.FromArgb(245, 247, 251)
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10)
        txtNama.ForeColor = Color.FromArgb(11, 30, 61)
        txtNama.Location = New Point(Px, 127)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama lengkap tanggungan"
        txtNama.Size = New Size(310, 30)
        txtNama.TabIndex = 6

        ' ── Hubungan ──
        lblLHubungan.AutoSize = True
        lblLHubungan.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLHubungan.ForeColor = Color.FromArgb(123, 141, 176)
        lblLHubungan.Location = New Point(Px, 168)
        lblLHubungan.Text = "HUBUNGAN"

        txtHubungan.BackColor = Color.FromArgb(245, 247, 251)
        txtHubungan.BorderStyle = BorderStyle.FixedSingle
        txtHubungan.Font = New Font("Segoe UI", 10)
        txtHubungan.ForeColor = Color.FromArgb(11, 30, 61)
        txtHubungan.Location = New Point(Px, 185)
        txtHubungan.Name = "txtHubungan"
        txtHubungan.PlaceholderText = "Istri / Suami / Anak ..."
        txtHubungan.Size = New Size(310, 30)
        txtHubungan.TabIndex = 7

        ' ── Status ──
        lblLStatus.AutoSize = True
        lblLStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblLStatus.ForeColor = Color.FromArgb(123, 141, 176)
        lblLStatus.Location = New Point(Px, 226)
        lblLStatus.Text = "STATUS"

        cbStatus.BackColor = Color.FromArgb(245, 247, 251)
        cbStatus.FlatStyle = FlatStyle.Flat
        cbStatus.Font = New Font("Segoe UI", 10)
        cbStatus.ForeColor = Color.FromArgb(11, 30, 61)
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Bekerja", "Tidak Bekerja", "Meninggal Dunia"})
        cbStatus.Location = New Point(Px, 243)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(220, 28)
        cbStatus.TabIndex = 5

        ' ── Garis pemisah ──
        pnlSepForm.BackColor = Color.FromArgb(230, 235, 245)
        pnlSepForm.Location = New Point(0, 292)
        pnlSepForm.Size = New Size(340, 1)

        ' ── Tombol CRUD ──
        btnSimpan.BackColor = Color.FromArgb(22, 160, 115)
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(14, 304)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 34)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "+ Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        btnSimpan.Cursor = Cursors.Hand

        btnUbah.BackColor = Color.FromArgb(59, 130, 246)
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(96, 304)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(72, 34)
        btnUbah.TabIndex = 10
        btnUbah.Text = "✎ Ubah"
        btnUbah.UseVisualStyleBackColor = False
        btnUbah.Cursor = Cursors.Hand

        btnHapus.BackColor = Color.FromArgb(220, 80, 80)
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(174, 304)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(72, 34)
        btnHapus.TabIndex = 11
        btnHapus.Text = "🗑 Hapus"
        btnHapus.UseVisualStyleBackColor = False
        btnHapus.Cursor = Cursors.Hand

        btnBatal.BackColor = Color.FromArgb(180, 188, 206)
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(252, 304)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(72, 34)
        btnBatal.TabIndex = 12
        btnBatal.Text = "✖ Batal"
        btnBatal.UseVisualStyleBackColor = False
        btnBatal.Cursor = Cursors.Hand

        ' ── Preview + Cetak ──
        btnPreviewCetak.BackColor = Color.FromArgb(11, 30, 61)
        btnPreviewCetak.FlatStyle = FlatStyle.Flat
        btnPreviewCetak.FlatAppearance.BorderSize = 0
        btnPreviewCetak.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnPreviewCetak.ForeColor = Color.White
        btnPreviewCetak.Location = New Point(14, 358)
        btnPreviewCetak.Name = "btnPreviewCetak"
        btnPreviewCetak.Size = New Size(110, 30)
        btnPreviewCetak.TabIndex = 26
        btnPreviewCetak.Text = "🔍 Preview"
        btnPreviewCetak.UseVisualStyleBackColor = False
        btnPreviewCetak.Cursor = Cursors.Hand

        btnCetak.BackColor = Color.FromArgb(201, 168, 76)
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnCetak.ForeColor = Color.FromArgb(11, 30, 61)
        btnCetak.Location = New Point(130, 358)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(90, 30)
        btnCetak.TabIndex = 25
        btnCetak.Text = "🖨 Cetak"
        btnCetak.UseVisualStyleBackColor = False
        btnCetak.Cursor = Cursors.Hand

        ' ── Rakit pnlLeft ──
        pnlLeft.Controls.Add(pnlFormTitle)
        pnlLeft.Controls.Add(lblLNik)
        pnlLeft.Controls.Add(cbNik)
        pnlLeft.Controls.Add(lblLNama)
        pnlLeft.Controls.Add(txtNama)
        pnlLeft.Controls.Add(lblLHubungan)
        pnlLeft.Controls.Add(txtHubungan)
        pnlLeft.Controls.Add(lblLStatus)
        pnlLeft.Controls.Add(cbStatus)
        pnlLeft.Controls.Add(pnlSepForm)
        pnlLeft.Controls.Add(btnSimpan)
        pnlLeft.Controls.Add(btnUbah)
        pnlLeft.Controls.Add(btnHapus)
        pnlLeft.Controls.Add(btnBatal)
        pnlLeft.Controls.Add(btnPreviewCetak)
        pnlLeft.Controls.Add(btnCetak)

        ' ═══════════════════════════════════════════════
        '  pnlDivider  –  garis vertikal
        ' ═══════════════════════════════════════════════
        pnlDivider.BackColor = Color.FromArgb(220, 228, 240)
        pnlDivider.Location = New Point(340, 90)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1, 570)

        ' ═══════════════════════════════════════════════
        '  pnlRight  –  panel tabel
        ' ═══════════════════════════════════════════════
        pnlRight.BackColor = Color.FromArgb(248, 250, 253)
        pnlRight.Location = New Point(341, 90)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(639, 570)

        ' ── Header tabel ──
        lblTableSec.AutoSize = False
        lblTableSec.BackColor = Color.FromArgb(245, 247, 251)
        lblTableSec.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblTableSec.ForeColor = Color.FromArgb(11, 30, 61)
        lblTableSec.Location = New Point(0, 0)
        lblTableSec.Size = New Size(639, 36)
        lblTableSec.Text = "   📊  TABEL DATA TANGGUNGAN — Klik baris untuk memuat ke form"
        lblTableSec.TextAlign = ContentAlignment.MiddleLeft

        ' ── Search bar ──
        pnlSearchBar.BackColor = Color.White
        pnlSearchBar.Location = New Point(0, 36)
        pnlSearchBar.Size = New Size(639, 44)

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
        txtCari.PlaceholderText = "Cari nama tanggungan atau hubungan..."
        txtCari.Size = New Size(570, 22)
        txtCari.TabIndex = 23

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

        dgvTanggungan.AlternatingRowsDefaultCellStyle = altStyle
        dgvTanggungan.BackgroundColor = Color.FromArgb(248, 250, 253)
        dgvTanggungan.BorderStyle = BorderStyle.None
        dgvTanggungan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTanggungan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTanggungan.ColumnHeadersDefaultCellStyle = hdrStyle
        dgvTanggungan.ColumnHeadersHeight = 38
        dgvTanggungan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTanggungan.DefaultCellStyle = rowStyle
        dgvTanggungan.EnableHeadersVisualStyles = False
        dgvTanggungan.GridColor = Color.FromArgb(225, 232, 245)
        dgvTanggungan.Location = New Point(0, 80)
        dgvTanggungan.Name = "dgvTanggungan"
        dgvTanggungan.RowHeadersVisible = False
        dgvTanggungan.RowTemplate.Height = 36
        dgvTanggungan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTanggungan.Size = New Size(639, 490)
        dgvTanggungan.TabIndex = 8

        ' ── Rakit pnlRight ──
        pnlRight.Controls.Add(lblTableSec)
        pnlRight.Controls.Add(pnlSearchBar)
        pnlRight.Controls.Add(dgvTanggungan)

        ' ── PrintDocument & Preview ──
        dlgPreview.AutoScrollMargin = New Size(0, 0)
        dlgPreview.AutoScrollMinSize = New Size(0, 0)
        dlgPreview.ClientSize = New Size(400, 300)
        dlgPreview.Enabled = True
        dlgPreview.Name = "dlgPreview"
        dlgPreview.Visible = False

        ' ═══════════════════════════════════════════════
        '  Form2  –  konfigurasi form
        ' ═══════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 242, 247)
        ClientSize = New Size(980, 660)
        Controls.Add(pnlRight)
        Controls.Add(pnlDivider)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(980, 660)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PA_PEMVIS — Data Tanggungan"

        CType(dgvTanggungan, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlFormTitle.ResumeLayout(False)
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        pnlRight.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' ── Deklarasi kontrol ASLI ────────────────────────────────────────
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

    ' ── Kontrol UI baru (private) ─────────────────────────────────────
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
    Private lblLNik As Label
    Private lblLNama As Label
    Private lblLHubungan As Label
    Private lblLStatus As Label
    Private lblFormSec As Label
    Private lblTableSec As Label
    Private lblSearchIcon As Label
    Private lblPrintSec As Label

End Class