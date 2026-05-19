Public Class Form2
    Private selectedId As Integer = 0

    Private Sub Kosong()
        txtNama.Clear()
        txtHubungan.Clear()
        cbStatus.SelectedIndex = -1
        selectedId = 0

        If CurrentRole = "karyawan" Then
            cbNik.SelectedValue = CurrentNIK
            cbNik.Enabled = False ' Kunci paksa kontrol input agar tidak memalsukan relasi karyawan lain
        Else
            cbNik.SelectedIndex = -1
            cbNik.Enabled = True  ' Admin bebas memilih asosiasi NIK manapun
            cbNik.Focus()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNik()
        TampilTanggungan()
        Kosong()
        
        If CurrentRole = "karyawan" Then
            btnKaryawan.Visible = False
        Else
            btnKaryawan.Visible = True
        End If
    End Sub

    ' REFRESH HUB SYNCHRONIZATION
    Public Sub RefreshDataTanggungan()
        LoadNik()
        TampilTanggungan()
        Kosong()
    End Sub

    ' FETCH DATA TANGGUNGAN
    Private Sub TampilTanggungan()
        ' Pengecekan Otoritas Alur Tampilan
        If CurrentRole = "admin" Then
            ' Mengambil semua data tanggungan tanpa filter klausa WHERE nik
            dgvTanggungan.DataSource = getAllTanggunganData()
        Else
            ' Karyawan ditundukkan ke fungsi filter data berbasis parameter CurrentNIK
            dgvTanggungan.DataSource = getAllTanggungan(CurrentNIK)
        End If
    End Sub

    ' PENGISIAN DATA COMBOBOX NIK KARYAWAN
    Private Sub LoadNik()
        ' Fungsi getAllKaryawan() otomatis mereturn daftar aman sesuai hak akses
        Dim dt As DataTable = getAllKaryawan()
        cbNik.DataSource = dt
        cbNik.DisplayMember = "nik"
        cbNik.ValueMember = "nik"
        cbNik.SelectedIndex = -1
    End Sub

    ' SIMPAN (CREATE)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Memeriksa validasi data input menggunakan modul validasi terpusat
        ErrorProvider1.Clear()
        If Not ValidasiTanggungan(ErrorProvider1, cbNik, txtNama, cbStatus, txtHubungan) Then
            MessageBox.Show("Silakan lengkapi seluruh field data tanggungan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Eksekusi penyimpanan data tanggungan
        Dim targetNIK As String = If(CurrentRole = "karyawan", CurrentNIK, cbNik.Text.Trim())

        If simpanTanggungan(targetNIK, txtNama.Text.Trim(), txtHubungan.Text.Trim(), cbStatus.Text.Trim()) Then
            MessageBox.Show("Data tanggungan berhasil direkam ke dalam database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        End If
    End Sub

    ' UBAH (UPDATE)
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih record tanggungan dari tabel yang ingin Anda ubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi form
        ErrorProvider1.Clear()
        If Not ValidasiTanggungan(ErrorProvider1, cbNik, txtNama, cbStatus, txtHubungan) Then Return

        Dim targetNIK As String = If(CurrentRole = "karyawan", CurrentNIK, cbNik.Text.Trim())

        ' Eksekusi ke database via modul data dengan perlindungan RBAC
        If ubahTanggungan(selectedId, targetNIK, txtNama.Text.Trim(), txtHubungan.Text.Trim(), cbStatus.Text.Trim()) Then
            MessageBox.Show("Data tanggungan berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        Else
            MessageBox.Show("Gagal mengubah data. Anda tidak memiliki otoritas atas record tanggungan ini.", "Akses Terlarang", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    ' HAPUS (DELETE)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih record tanggungan dari tabel yang ingin Anda hapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dialogResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data tanggungan ini?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            If hapusTanggungan(selectedId) Then
                MessageBox.Show("Data tanggungan berhasil dihapus dari sistem.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilTanggungan()
                Kosong()
            Else
                MessageBox.Show("Gagal menghapus data. Pengoperasian diblokir oleh subsistem keamanan.", "Akses Terlarang", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    ' OPERASI CANCEL EVENT
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    ' LIVE SEARCHING DATA TANGGUNGAN VIA TEXTBOX
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilTanggungan()
        Else
            ' Fungsi SearchTanggungan otomatis memfilter visual berdasarkan konteks role akun yang aktif
            dgvTanggungan.DataSource = SearchTanggungan(txtCari.Text.Trim())
        End If
    End Sub

    ' EVENT CELL CLICK SELECTION DATA GRID VIEW
    Private Sub dgvTanggungan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTanggungan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTanggungan.Rows(e.RowIndex)

            ' Mencegah manipulasi ID jika record bukan miliknya (kebocoran runtime)
            If CurrentRole = "karyawan" AndAlso row.Cells("nik_karyawan").Value.ToString() <> CurrentNIK Then
                MessageBox.Show("Akses Terlarang: Anda tidak berhak memodifikasi data relasi karyawan lain.", "Pelanggaran Otoritas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Kosong()
                Exit Sub
            End If

            selectedId = Convert.ToInt32(row.Cells("id_tanggungan").Value)
            cbNik.Text = row.Cells("nik_karyawan").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtHubungan.Text = row.Cells("hubungan").Value.ToString()
            cbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    ' MEMASTIKAN APLIKASI BERSIH DARI MEMORI SAAT FORM DITUTUP
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Jika ditutup, kembalikan fokus atau pastikan thread terlepas
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogResult = DialogResult.Yes Then
            ClearSession()

            Kosong()
            ErrorProvider1.Clear()

            FormLogin.Show()

            Me.Close()
        End If
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        If CurrentRole <> "karyawan" Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class