Imports System.Drawing.Printing

Public Class Form1
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Memaksa semua form tersembunyi (termasuk FormLogin) ikut hancur dan melepas memori
        Application.Exit()
    End Sub

    Private Sub Kosong()
        txtNama.Clear()
        ' Jika user adalah karyawan, NIK tidak boleh dibersihkan/diubah karena mutlak milik dirinya
        If CurrentRole <> "karyawan" Then
            txtNIK.Clear()
            txtNIK.Enabled = True
        Else
            txtNIK.Text = CurrentNIK
            txtNIK.Enabled = False
        End If

        txtEmail.Clear()
        mtbHP.Clear()
        txtPassword.Clear()
        txtGaji.Clear()
        cbRole.SelectedIndex = -1

        ' === TAMBAHAN JENIS KELAMIN ===
        rdPria.Checked = False
        rdWanita.Checked = False

        ErrorProvider1.Clear()
    End Sub

    ' MENAMPILKAN DATA KE DATA GRID VIEW
    Private Sub TampilData()
        dgvKaryawan.DataSource = getAllKaryawan()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
        TerapkanHakAksesUI()
    End Sub

    ' OTORISASI BERDASARKAN ROLE
    Private Sub TerapkanHakAksesUI()
        If CurrentRole = "karyawan" Then
            ' Proteksi Struktural Karyawan
            btnSimpan.Enabled = False   ' Tidak boleh mendaftarkan karyawan baru
            btnHapus.Enabled = False    ' Tidak boleh menghapus akun
            txtCari.Enabled = False     ' Tidak boleh mencari data karyawan lain
            cbRole.Enabled = False      ' Tidak boleh mengubah role

            txtGaji.Enabled = False     ' (Karyawan HANYA BISA MELIHAT)

            ' Muat data profil diri secara langsung ke kolom input text
            AmbilProfilMandiri()
        ElseIf CurrentRole = "admin" Then
            ' Akses Penuh Admin
            txtNIK.Enabled = True
            btnSimpan.Enabled = True
            btnHapus.Enabled = True
            txtCari.Enabled = True
            cbRole.Enabled = True       ' Admin dapat memilih role

            txtGaji.Enabled = True      ' (Admin BISA MENGISI & MENGUBAH)
        End If
    End Sub

    ' METODE PENGAMBILAN DATA PROFIL MANDIRI KARYAWAN
    Private Sub AmbilProfilMandiri()
        Dim dt As DataTable = getNIK(CurrentNIK)
        If dt.Rows.Count > 0 Then
            txtNIK.Text = dt.Rows(0)("nik").ToString()
            txtNama.Text = dt.Rows(0)("nama").ToString()
            txtEmail.Text = dt.Rows(0)("email").ToString()
            mtbHP.Text = dt.Rows(0)("hp").ToString()
            txtPassword.Text = dt.Rows(0)("password").ToString()
            txtGaji.Text = dt.Rows(0)("gaji").ToString()

            ' === TAMBAHAN JENIS KELAMIN ===
            Dim jk As String = dt.Rows(0)("jenis_kelamin").ToString()
            If jk = "Pria" Then
                rdPria.Checked = True
            ElseIf jk = "Wanita" Then
                rdWanita.Checked = True
            End If

            ' --- ISI RUNTIME COMBOBOX ROLE ---
            cbRole.SelectedItem = dt.Rows(0)("role").ToString()
            cbRole.Enabled = False ' Kunci akses modifikasi langsung bagi karyawan
        End If
    End Sub

    ' LOGIKA TAMBAH DATA (CREATE)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiKaryawan(ErrorProvider1, txtNIK, txtNama, txtEmail, mtbHP, txtPassword, cbRole, txtGaji) Then
            Exit Sub
        End If

        Dim jenis_kelamin As String = ""
        If rdPria.Checked Then
            jenis_kelamin = "Pria"
        ElseIf rdWanita.Checked Then
            jenis_kelamin = "Wanita"
        Else
            MessageBox.Show("Silakan pilih Jenis Kelamin terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nik As String = txtNIK.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim hp As String = mtbHP.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cbRole.SelectedItem.ToString().Trim()

        Dim gaji As Integer = 0
        If txtGaji.Text.Trim() <> "" AndAlso IsNumeric(txtGaji.Text.Trim()) Then
            gaji = Convert.ToInt32(txtGaji.Text.Trim())
        End If

        If nikSudahAda(nik) Then
            MessageBox.Show("NIK sudah terdaftar di sistem, gunakan NIK lain.", "Peringatan Keamanan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK.Focus()
            Return
        End If

        If emailSudahAda(email) Then
            MessageBox.Show("Email sudah digunakan, gunakan alamat email lain.", "Peringatan Keamanan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        ' === PERHATIAN: Tambahkan parameter jenis_kelamin pada fungsi simpanKaryawan di Module ===
        If simpanKaryawan(nik, nama, email, hp, jenis_kelamin, gaji, password, role) Then
            MessageBox.Show("Data karyawan berhasil disimpan ke database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' LOGIKA UBAH DATA (UPDATE)
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiKaryawan(ErrorProvider1, txtNIK, txtNama, txtEmail, mtbHP, txtPassword, cbRole, txtGaji) Then
            Exit Sub
        End If

        Dim jenis_kelamin As String = ""
        If rdPria.Checked Then
            jenis_kelamin = "Pria"
        ElseIf rdWanita.Checked Then
            jenis_kelamin = "Wanita"
        Else
            MessageBox.Show("Silakan pilih Jenis Kelamin terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nik As String = txtNIK.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim hp As String = mtbHP.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim gaji As Integer = 0
        If txtGaji.Text.Trim() <> "" AndAlso IsNumeric(txtGaji.Text.Trim()) Then
            gaji = Convert.ToInt32(txtGaji.Text.Trim())
        End If

        Dim role As String = cbRole.SelectedItem.ToString().Trim().ToLower()

        If CurrentRole = "karyawan" Then
            role = "karyawan"
        End If


        If ubahKaryawan(nik, nama, email, hp, jenis_kelamin, gaji, password, role) Then
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilData()

            If CurrentRole = "karyawan" Then
                AmbilProfilMandiri()
            Else
                Kosong()
            End If
        Else
            MessageBox.Show("Gagal memperbarui data. Pastikan format input benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' LOGIKA HAPUS DATA (DELETE)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If CurrentRole = "karyawan" Then
            MessageBox.Show("Akses Ditolak: Karyawan dilarang menghapus akun mandiri/orang lain.", "Pelanggaran Hak Akses", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If txtNIK.Text.Trim() = "" Then
            MessageBox.Show("Pilih record data karyawan pada tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Menghapus data karyawan akan menghapus seluruh data tanggungannya secara permanen (CASCADE). Apakah Anda yakin?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If hapusKaryawan(txtNIK.Text.Trim()) Then
                MessageBox.Show("Data karyawan terhapus dengan sukses.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
                If Form2.Visible Then Form2.RefreshDataTanggungan()
            End If
        End If
    End Sub

    ' PEMBATALAN DAN RESET FORM
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
        TerapkanHakAksesUI()
    End Sub

    ' DATA BINDING GRID VIEW KE INPUT FIELD
    Private Sub dgvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedNIK As String = dgvKaryawan.Rows(e.RowIndex).Cells("NIK").Value.ToString()

            If CurrentRole = "admin" AndAlso selectedNIK = CurrentNIK Then
                MessageBox.Show("Anda tidak dapat mengubah atau menghapus data Anda sendiri.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If CurrentRole = "karyawan" AndAlso selectedNIK <> CurrentNIK Then
                MessageBox.Show("Anda tidak diizinkan mengakses data profile karyawan lain.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            txtNIK.Text = selectedNIK
            txtNama.Text = dgvKaryawan.Rows(e.RowIndex).Cells("Nama").Value.ToString()
            txtEmail.Text = dgvKaryawan.Rows(e.RowIndex).Cells("Email").Value.ToString()
            mtbHP.Text = dgvKaryawan.Rows(e.RowIndex).Cells("HP").Value.ToString()

            Dim dt As DataTable = getNIK(txtNIK.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtPassword.Text = dt.Rows(0)("password").ToString()
                cbRole.SelectedItem = dt.Rows(0)("role").ToString()
                txtGaji.Text = dt.Rows(0)("gaji").ToString()

                ' === TAMBAHAN JENIS KELAMIN ===
                Dim jk As String = dt.Rows(0)("jenis_kelamin").ToString()
                If jk = "Pria" Then
                    rdPria.Checked = True
                ElseIf jk = "Wanita" Then
                    rdWanita.Checked = True
                End If
            End If
        End If
    End Sub

    ' AKSES NAVIGASI KEYBOARD NIK PRESS ENTER
    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True

            If CurrentRole = "karyawan" AndAlso txtNIK.Text.Trim() <> CurrentNIK Then
                MessageBox.Show("Anda hanya dapat memuat profil data diri Anda sendiri.", "Batasan Hak Akses", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                AmbilProfilMandiri()
                Exit Sub
            End If

            Dim dt As DataTable = getNIK(txtNIK.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtNIK.Text = dt.Rows(0)("nik").ToString()
                txtNama.Text = dt.Rows(0)("nama").ToString()
                txtEmail.Text = dt.Rows(0)("email").ToString()
                mtbHP.Text = dt.Rows(0)("hp").ToString()
                txtPassword.Text = dt.Rows(0)("password").ToString()
                cbRole.SelectedItem = dt.Rows(0)("role").ToString()
                txtGaji.Text = dt.Rows(0)("gaji").ToString()

                ' === TAMBAHAN JENIS KELAMIN ===
                Dim jk As String = dt.Rows(0)("jenis_kelamin").ToString()
                If jk = "Pria" Then
                    rdPria.Checked = True
                ElseIf jk = "Wanita" Then
                    rdWanita.Checked = True
                End If
            Else
                Kosong() ' Panggil Kosong() agar lebih efisien mereset semua termasuk radio button
                MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txtNIK.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            btnUbah.Focus()
        End If
    End Sub

    Private Sub txtGaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGaji.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If CurrentRole = "karyawan" Then Exit Sub

        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKaryawan.DataSource = SearchKaryawan(txtCari.Text.Trim())
        End If
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogResult = DialogResult.Yes Then
            ClearSession()
            Kosong()
            ErrorProvider1.Clear()
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub

    ' ======================= FITUR CETAK LAPORAN KARYAWAN =======================
    Private Function SiapkanDataCetakKaryawan() As Boolean
        Dim dt As DataTable = DataModule.GetAllKaryawanUntukLaporan()
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data karyawan yang dapat dicetak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        PrintModule.SetLaporanData(dt, "Karyawan")
        Return True
    End Function

    Private Sub btnPreviewCetak_Click(sender As Object, e As EventArgs) Handles btnPreviewCetak.Click
        Try
            If Not SiapkanDataCetakKaryawan() Then Exit Sub
            docLaporan.DefaultPageSettings.Landscape = True   ' Bisa disesuaikan
            dlgPreview.Document = docLaporan
            dlgPreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menampilkan preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            If Not SiapkanDataCetakKaryawan() Then Exit Sub
            docLaporan.DefaultPageSettings.Landscape = True
            docLaporan.Print()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencetak dokumen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub docLaporan_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docLaporan.PrintPage
        ' Render sesuai tipe data yang sudah diset di PrintModule
        If PrintModule.LaporanTipe = "Karyawan" Then
            PrintModule.RenderLaporanKaryawan(e)
        Else
            ' Fallback
            Using f As New Font("Calibri", 12)
                e.Graphics.DrawString("Tipe laporan tidak dikenali.", f, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
        End If
    End Sub

    Private Sub rdPria_CheckedChanged(sender As Object, e As EventArgs) Handles rdPria.CheckedChanged

    End Sub

    Private Sub rdWanita_CheckedChanged(sender As Object, e As EventArgs) Handles rdWanita.CheckedChanged

    End Sub

    Private Sub mtbHP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbHP.MaskInputRejected

    End Sub
End Class