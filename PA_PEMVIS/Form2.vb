Imports System.Drawing.Printing

Public Class Form2
    Private selectedId As Integer = 0

    Private Sub Kosong()
        txtNama.Clear()
        txtHubungan.Clear()
        cbStatus.SelectedIndex = -1
        selectedId = 0

        If CurrentRole = "karyawan" Then
            cbNik.SelectedValue = CurrentNIK
            cbNik.Enabled = False
        Else
            cbNik.SelectedIndex = -1
            cbNik.Enabled = True
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
    Public Sub RefreshDataTanggungan()
        LoadNik()
        TampilTanggungan()
        Kosong()
    End Sub
    Private Sub TampilTanggungan()
        If CurrentRole = "admin" Then
            dgvTanggungan.DataSource = getAllTanggunganData()
        Else
            dgvTanggungan.DataSource = getAllTanggungan(CurrentNIK)
        End If
    End Sub
    Private Sub LoadNik()
        Dim dt As DataTable = getAllKaryawan()
        cbNik.DataSource = dt
        cbNik.DisplayMember = "nik"
        cbNik.ValueMember = "nik"
        cbNik.SelectedIndex = -1
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiTanggungan(ErrorProvider1, cbNik, txtNama, cbStatus, txtHubungan) Then
            MessageBox.Show("Silakan lengkapi seluruh field data tanggungan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim targetNIK As String = If(CurrentRole = "karyawan", CurrentNIK, cbNik.Text.Trim())

        If simpanTanggungan(targetNIK, txtNama.Text.Trim(), txtHubungan.Text.Trim(), cbStatus.Text.Trim()) Then
            MessageBox.Show("Data tanggungan berhasil direkam ke dalam database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih record tanggungan dari tabel yang ingin Anda ubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ErrorProvider1.Clear()
        If Not ValidasiTanggungan(ErrorProvider1, cbNik, txtNama, cbStatus, txtHubungan) Then Return

        Dim targetNIK As String = If(CurrentRole = "karyawan", CurrentNIK, cbNik.Text.Trim())

        If ubahTanggungan(selectedId, targetNIK, txtNama.Text.Trim(), txtHubungan.Text.Trim(), cbStatus.Text.Trim()) Then
            MessageBox.Show("Data tanggungan berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        Else
            MessageBox.Show("Gagal mengubah data. Anda tidak memiliki otoritas atas record tanggungan ini.", "Akses Terlarang", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
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
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilTanggungan()
        Else
            dgvTanggungan.DataSource = SearchTanggungan(txtCari.Text.Trim())
        End If
    End Sub
    Private Sub dgvTanggungan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTanggungan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTanggungan.Rows(e.RowIndex)
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

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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
    Private Function SiapkanDataCetakTanggungan() As Boolean
        Dim dt As DataTable
        If CurrentRole = "admin" Then
            dt = DataModule.GetAllTanggunganUntukLaporan()
        Else
            dt = DataModule.GetAllTanggunganUntukLaporan(CurrentNIK)
        End If

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data tanggungan yang dapat dicetak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        PrintModule.SetLaporanData(dt, "Tanggungan")
        Return True
    End Function

    Private Sub btnPreviewCetak_Click(sender As Object, e As EventArgs) Handles btnPreviewCetak.Click
        Try
            If Not SiapkanDataCetakTanggungan() Then Exit Sub
            docLaporan.DefaultPageSettings.Landscape = True
            dlgPreview.Document = docLaporan
            dlgPreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menampilkan preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            If Not SiapkanDataCetakTanggungan() Then Exit Sub
            docLaporan.DefaultPageSettings.Landscape = True
            docLaporan.Print()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencetak dokumen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub docLaporan_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docLaporan.PrintPage
        If PrintModule.LaporanTipe = "Tanggungan" Then
            PrintModule.RenderLaporanTanggungan(e)
        Else
            Using f As New Font("Calibri", 12)
                e.Graphics.DrawString("Tipe laporan tidak dikenali.", f, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
        End If
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        If CurrentRole <> "karyawan" Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class