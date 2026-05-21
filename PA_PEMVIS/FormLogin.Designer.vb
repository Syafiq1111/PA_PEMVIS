<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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

        ' ── Kontrol asli (jangan ubah nama) ──────────────────────────
        txtIdentifier = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()

        ' ── Kontrol UI tambahan (private, tidak perlu WithEvents) ─────
        pnlNavy = New Panel()
        pnlCard = New Panel()
        pnlAccent = New Panel()
        pnlSepTop = New Panel()
        lblBrand = New Label()
        lblTagline = New Label()
        lblNIK = New Label()
        lblPwd = New Label()
        lblFooter = New Label()
        lblIkon = New Label()

        pnlNavy.SuspendLayout()
        pnlCard.SuspendLayout()
        SuspendLayout()

        ' ═══════════════════════════════════════════════
        '  pnlNavy  –  latar belakang navy penuh
        ' ═══════════════════════════════════════════════
        pnlNavy.BackColor = Color.FromArgb(11, 30, 61)
        pnlNavy.Dock = DockStyle.Fill
        pnlNavy.Location = New Point(0, 0)
        pnlNavy.Name = "pnlNavy"
        pnlNavy.Size = New Size(440, 560)

        ' ═══════════════════════════════════════════════
        '  pnlCard  –  kartu putih di tengah
        ' ═══════════════════════════════════════════════
        pnlCard.BackColor = Color.White
        pnlCard.Location = New Point(30, 50)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(380, 460)

        ' ── Ikon dekoratif (huruf "PA") ──
        lblIkon.AutoSize = False
        lblIkon.BackColor = Color.FromArgb(201, 168, 76)
        lblIkon.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblIkon.ForeColor = Color.FromArgb(11, 30, 61)
        lblIkon.Location = New Point(28, 28)
        lblIkon.Size = New Size(52, 52)
        lblIkon.Text = "PA"
        lblIkon.TextAlign = ContentAlignment.MiddleCenter

        ' ── Judul brand ──
        lblBrand.AutoSize = False
        lblBrand.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(11, 30, 61)
        lblBrand.Location = New Point(90, 28)
        lblBrand.Size = New Size(260, 34)
        lblBrand.Text = "PA_PEMVIS"

        ' ── Tagline ──
        lblTagline.AutoSize = False
        lblTagline.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblTagline.ForeColor = Color.FromArgb(123, 141, 176)
        lblTagline.Location = New Point(90, 60)
        lblTagline.Size = New Size(260, 20)
        lblTagline.Text = "Sistem Informasi Karyawan"

        ' ── Garis pemisah gold ──
        pnlSepTop.BackColor = Color.FromArgb(201, 168, 76)
        pnlSepTop.Location = New Point(28, 102)
        pnlSepTop.Size = New Size(324, 2)

        ' ── Label NIK ──
        lblNIK.AutoSize = True
        lblNIK.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblNIK.ForeColor = Color.FromArgb(123, 141, 176)
        lblNIK.Location = New Point(28, 122)
        lblNIK.Text = "NIK / USERNAME"

        ' ── txtIdentifier ──
        txtIdentifier.BackColor = Color.FromArgb(245, 247, 251)
        txtIdentifier.BorderStyle = BorderStyle.FixedSingle
        txtIdentifier.Font = New Font("Segoe UI", 10)
        txtIdentifier.ForeColor = Color.FromArgb(11, 30, 61)
        txtIdentifier.Location = New Point(28, 143)
        txtIdentifier.Name = "txtIdentifier"
        txtIdentifier.PlaceholderText = "Masukkan NIK karyawan"
        txtIdentifier.Size = New Size(324, 30)
        txtIdentifier.TabIndex = 1

        ' ── Label Password ──
        lblPwd.AutoSize = True
        lblPwd.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblPwd.ForeColor = Color.FromArgb(123, 141, 176)
        lblPwd.Location = New Point(28, 192)
        lblPwd.Text = "PASSWORD"

        ' ── txtPassword ──
        txtPassword.BackColor = Color.FromArgb(245, 247, 251)
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10)
        txtPassword.ForeColor = Color.FromArgb(11, 30, 61)
        txtPassword.Location = New Point(28, 213)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Masukkan password"
        txtPassword.Size = New Size(324, 30)
        txtPassword.TabIndex = 3

        ' ── Garis aksen gold kiri pada tombol ──
        pnlAccent.BackColor = Color.FromArgb(201, 168, 76)
        pnlAccent.Location = New Point(28, 264)
        pnlAccent.Size = New Size(4, 46)

        ' ── btnLogin ──
        btnLogin.BackColor = Color.FromArgb(201, 168, 76)
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnLogin.ForeColor = Color.FromArgb(11, 30, 61)
        btnLogin.Location = New Point(32, 264)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(320, 46)
        btnLogin.TabIndex = 4
        btnLogin.Text = "MASUK KE SISTEM  →"
        btnLogin.TextAlign = ContentAlignment.MiddleCenter
        btnLogin.UseVisualStyleBackColor = False
        btnLogin.Cursor = Cursors.Hand

        ' ── Footer ──
        lblFooter.AutoSize = False
        lblFooter.Font = New Font("Segoe UI", 8)
        lblFooter.ForeColor = Color.FromArgb(180, 190, 210)
        lblFooter.Location = New Point(28, 332)
        lblFooter.Size = New Size(324, 18)
        lblFooter.Text = "© 2026 PA_PEMVIS — Sistem Informasi Karyawan"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter

        ' ── Rakit pnlCard ──
        pnlCard.Controls.Add(lblIkon)
        pnlCard.Controls.Add(lblBrand)
        pnlCard.Controls.Add(lblTagline)
        pnlCard.Controls.Add(pnlSepTop)
        pnlCard.Controls.Add(lblNIK)
        pnlCard.Controls.Add(txtIdentifier)
        pnlCard.Controls.Add(lblPwd)
        pnlCard.Controls.Add(txtPassword)
        pnlCard.Controls.Add(pnlAccent)
        pnlCard.Controls.Add(btnLogin)
        pnlCard.Controls.Add(lblFooter)

        ' ── Rakit pnlNavy ──
        pnlNavy.Controls.Add(pnlCard)

        ' ═══════════════════════════════════════════════
        '  FormLogin
        ' ═══════════════════════════════════════════════
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(11, 30, 61)
        ClientSize = New Size(440, 560)
        Controls.Add(pnlNavy)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PA_PEMVIS — Login"

        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlNavy.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' ── Deklarasi kontrol (nama harus sama dengan .vb) ──────────────
    Friend WithEvents txtIdentifier As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button

    ' ── Kontrol UI tambahan (private) ────────────────────────────────
    Private pnlNavy As Panel
    Private pnlCard As Panel
    Private pnlAccent As Panel
    Private pnlSepTop As Panel
    Private lblBrand As Label
    Private lblTagline As Label
    Private lblNIK As Label
    Private lblPwd As Label
    Private lblFooter As Label
    Private lblIkon As Label

End Class