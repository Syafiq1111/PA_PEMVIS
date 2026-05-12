Public Class Form2
    Private selectedId As Integer = 0

    Private Sub Kosong()
        cbNik.SelectedIndex = -1
        txtNama.Clear()
        txtHubungan.Clear()
        cbStatus.SelectedIndex = -1
        cbNik.Focus()
        selectedId = 0
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilTanggungan()
        LoadNik()
    End Sub

    Public Sub RefreshDataTanggungan()
        TampilTanggungan()
        LoadNik()
        Kosong()
    End Sub

    Private Sub TampilTanggungan()
        dgvTanggungan.DataSource = getAllTanggunganData()
    End Sub

    Private Sub LoadNik()
        Dim dt As DataTable = getAllKaryawan()
        cbNik.DataSource = dt
        cbNik.DisplayMember = "nik"
        cbNik.ValueMember = "nik"
        cbNik.SelectedIndex = -1
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbNik.SelectedIndex = -1 Or txtNama.Text = "" Or txtHubungan.Text = "" Or cbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Silakan lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If simpanTanggungan(cbNik.Text, txtNama.Text, txtHubungan.Text, cbStatus.Text) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = 0 Then
            MessageBox.Show("Silakan pilih data yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbNik.SelectedIndex = -1 Or txtNama.Text = "" Or txtHubungan.Text = "" Or cbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Silakan lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ubahTanggungan(selectedId, cbNik.Text, txtNama.Text, txtHubungan.Text, cbStatus.Text) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilTanggungan()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = 0 Then
            MessageBox.Show("Silakan pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dialogResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            If hapusTanggungan(selectedId) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilTanggungan()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvTanggungan.DataSource = SearchTanggungan(txtCari.Text)
    End Sub

    Private Sub dgvTanggungan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTanggungan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTanggungan.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id_tanggungan").Value)
            cbNik.Text = row.Cells("nik_karyawan").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtHubungan.Text = row.Cells("hubungan").Value.ToString()
            cbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub
End Class