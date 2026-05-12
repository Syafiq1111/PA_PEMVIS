Public Class Form1
    Private Sub Kosong()
        txtNama.Clear()
        txtNIK.Clear()
        txtEmail.Clear()
        mtbHP.Clear()
        ErrorProvider1.Clear()
    End Sub

    Private Sub TampilData()
        dgvKaryawan.DataSource = getAllKaryawan()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiKaryawan(ErrorProvider1, txtNIK, txtNama, txtEmail, mtbHP) Then Exit Sub

        Dim nik As String = txtNIK.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim hp As String = mtbHP.Text.Trim()

        If (nikSudahAda(nik)) Then
            MessageBox.Show("NIK sudah ada, silakan gunakan NIK lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK.Focus()
            Return
        End If

        If (emailSudahAda(email)) Then
            MessageBox.Show("Email sudah ada, silakan gunakan email lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If simpanKaraywan(nik, nama, email, hp) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        ErrorProvider1.Clear()
        If Not ValidasiKaryawan(ErrorProvider1, txtNIK, txtNama, txtEmail, mtbHP) Then Exit Sub

        Dim nik As String = txtNIK.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim hp As String = mtbHP.Text.Trim()

        If ubahKaryawan(nik, nama, email, hp) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtNIK.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus",
            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIK.Focus()
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?",
        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If hapusKaryawan(txtNIK.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
                If Form2.Visible Then
                    Form2.RefreshDataTanggungan()
                End If
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellClick

        If e.RowIndex >= 0 Then
            txtNIK.Text = dgvKaryawan.Rows(e.RowIndex).Cells("NIK").Value.ToString()
            txtNama.Text = dgvKaryawan.Rows(e.RowIndex).Cells("Nama").Value.ToString()
            txtEmail.Text = dgvKaryawan.Rows(e.RowIndex).Cells("Email").Value.ToString()
            mtbHP.Text = dgvKaryawan.Rows(e.RowIndex).Cells("HP").Value.ToString()
        End If
    End Sub

    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress

        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable =
            getNIK(txtNIK.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtNIK.Text =
                dt.Rows(0)("NIK").ToString()

                txtNama.Text = dt.Rows(0)("Nama").ToString()
                txtEmail.Text = dt.Rows(0)("Email").ToString()
                mtbHP.Text = dt.Rows(0)("HP").ToString()
            Else
                txtNama.Clear()
                txtEmail.Clear()
                mtbHP.Clear()
            End If
            txtNIK.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKaryawan.DataSource = SearchKaryawan(txtCari.Text.Trim())
        End If
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub
End Class
