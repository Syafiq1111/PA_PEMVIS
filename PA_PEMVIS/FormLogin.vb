Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim id As String = txtIdentifier.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()

        If id = "" Or pass = "" Then
            MessageBox.Show("Email/NIK dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Memanggil fungsi dari ConnectionModule untuk validasi login
        If ValidasiLogin(id, pass) Then
            MessageBox.Show("Selamat Datang, " & CurrentNama & " (" & CurrentRole & ")", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Buka Form Utama (Form1)
            Form1.Show()

            ' Sembunyikan Form Login agar tidak menutup aplikasi secara prematur
            Me.Hide()
        Else
            MessageBox.Show("Email/NIK atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtIdentifier.Focus()
        End If
    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Memastikan seluruh thread aplikasi berhenti saat form login ditutup
        Application.Exit()
    End Sub
End Class