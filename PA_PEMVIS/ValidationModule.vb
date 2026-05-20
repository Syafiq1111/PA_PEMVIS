Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbx As ComboBox, pesan As String) As Boolean
        If cbx.SelectedIndex = -1 OrElse cbx.SelectedItem Is Nothing Then
            ep.SetError(cbx, pesan)
            Return False
        Else
            ep.SetError(cbx, "")
            Return True
        End If
    End Function

    Public Function ValidasiKaryawan(ep As ErrorProvider, txtNIK As TextBox, txtNama As TextBox, txtEmail As TextBox, txtHP As MaskedTextBox, txtPassword As TextBox, cbRole As ComboBox, txtGaji As TextBox) As Boolean

        Dim nikValid As Boolean = ValidasiTextBox(ep, txtNIK, "NIK tidak boleh kosong")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim emailValid As Boolean = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
        Dim hpValid As Boolean = ValidasiMaskedTextBox(ep, txtHP, "HP tidak boleh kosong")
        Dim passValid As Boolean = ValidasiTextBox(ep, txtPassword, "Password tidak boleh kosong")
        Dim roleValid As Boolean = ValidasiComboBox(ep, cbRole, "Role tidak boleh kosong")

        Dim gajiValid As Boolean = ValidasiTextBox(ep, txtGaji, "Gaji tidak boleh kosong")

        Return nikValid And namaValid And emailValid And hpValid And passValid And roleValid And gajiValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiTanggungan(ep As ErrorProvider, cbNik As ComboBox, txtNama As TextBox, cbStatus As ComboBox, txtHubungan As TextBox) As Boolean
        Dim nikValid As Boolean = ValidasiComboBox(ep, cbNik, "Pilih NIK karyawan")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim statusValid As Boolean = ValidasiComboBox(ep, cbStatus, "Pilih status tanggungan")
        Dim hubunganValid As Boolean = ValidasiTextBox(ep, txtHubungan, "Hubungan tidak boleh kosong")
        Return nikValid And namaValid And statusValid And hubunganValid
    End Function

End Module