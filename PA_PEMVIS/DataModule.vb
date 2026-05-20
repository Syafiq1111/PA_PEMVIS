Imports MySqlConnector

Module DataModule
    Public Function ValidasiLogin(identifier As String, password As String) As Boolean
        Dim query As String = "SELECT nik, nama, role FROM karyawan WHERE (email = @id OR nik = @id) AND password = @password"

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", identifier)
                cmd.Parameters.AddWithValue("@password", password)

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            CurrentNIK = reader("nik").ToString()
                            CurrentNama = reader("nama").ToString()
                            CurrentRole = reader("role").ToString()
                            Return True
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("Kesalahan Database: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End Using
        End Using
        Return False
    End Function

    Public Function getAllKaryawan() As DataTable
        Dim dt As New DataTable()
        Dim query As String = ""

        If CurrentRole = "admin" Then
            query = "SELECT nik AS NIK, nama AS Nama, email AS Email, jenis_kelamin AS 'Jenis Kelamin', hp AS HP, gaji AS Gaji, role AS Role FROM karyawan"
        Else
            query = "SELECT nik AS NIK, nama AS Nama, email AS Email, jenis_kelamin AS 'Jenis Kelamin', hp AS HP, gaji AS Gaji, role AS Role FROM karyawan WHERE nik = @nik"
        End If

        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If CurrentRole <> "admin" Then
                    cmd.Parameters.AddWithValue("@nik", CurrentNIK)
                End If

                Try
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                Catch ex As Exception
                    MsgBox("Gagal memuat data karyawan: " & ex.Message, MsgBoxStyle.Critical, "Eror Database")
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchKaryawan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = ""

        If CurrentRole = "admin" Then
            query = "SELECT nik AS NIK, nama AS Nama, email AS Email, jenis_kelamin AS 'Jenis Kelamin', hp AS HP, gaji AS Gaji, role AS Role FROM karyawan WHERE nama LIKE @keyword OR nik LIKE @keyword ORDER BY nama ASC"
        Else
            query = "SELECT nik AS NIK, nama AS Nama, email AS Email, jenis_kelamin AS 'Jenis Kelamin', hp AS HP, gaji AS Gaji, role AS Role FROM karyawan WHERE (nik = @nik) AND (nama LIKE @keyword OR nik LIKE @keyword) ORDER BY nama ASC"
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    If CurrentRole <> "admin" Then
                        cmd.Parameters.AddWithValue("@nik", CurrentNIK)
                    End If
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function getNIK(nik As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM karyawan WHERE nik = @nik"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@nik", nik)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function nikSudahAda(nik As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM karyawan WHERE nik = @nik"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function emailSudahAda(email As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM karyawan WHERE email = @email"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@email", email)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function simpanKaryawan(nik As String, nama As String, email As String, hp As String, jenis_kelamin As String, gaji As Integer, password As String, role As String) As Boolean
        Try
            Dim query As String = "INSERT INTO karyawan (nik, nama, email, jenis_kelamin, hp, gaji, password, role) VALUES (@nik, @nama, @email, @jenis_kelamin, @hp, @gaji, @password, @role)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@gaji", gaji)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@role", role)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ubahKaryawan(nik As String, nama As String, email As String, hp As String, jenis_kelamin As String, gaji As Integer, password As String, role As String) As Boolean
        Dim query As String = "UPDATE karyawan SET nama = @nama, email = @email, jenis_kelamin = @jenis_kelamin, hp = @hp, gaji = @gaji, password = @password, role = @role WHERE nik = @nik"
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nik", nik)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
                cmd.Parameters.AddWithValue("@hp", hp)
                cmd.Parameters.AddWithValue("@gaji", gaji)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@role", role)
                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                Catch ex As Exception
                    MsgBox("Gagal memperbarui data di database: " & ex.Message, MsgBoxStyle.Critical, "Eror Update")
                    Return False
                End Try
            End Using
        End Using
    End Function

    Public Function hapusKaryawan(nik As String) As Boolean
        Try
            Dim query As String = "DELETE FROM karyawan WHERE nik = @nik"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function getAllTanggungan(nik As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_tanggungan, nik_karyawan, nama, hubungan, status FROM tanggungan WHERE nik_karyawan = @nik"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@nik", nik)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function getAllTanggunganData() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_tanggungan, nik_karyawan, nama, hubungan, status FROM tanggungan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTanggungan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = ""

        If CurrentRole = "admin" Then
            query = "SELECT id_tanggungan, nik_karyawan, nama, hubungan, status FROM tanggungan WHERE nama LIKE @keyword OR hubungan LIKE @keyword OR status LIKE @keyword OR nik_karyawan LIKE @keyword"
        Else
            query = "SELECT id_tanggungan, nik_karyawan, nama, hubungan, status FROM tanggungan WHERE nik_karyawan = @nik AND (nama LIKE @keyword OR hubungan LIKE @keyword OR status LIKE @keyword)"
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    If CurrentRole <> "admin" Then
                        da.SelectCommand.Parameters.AddWithValue("@nik", CurrentNIK)
                    End If
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function simpanTanggungan(nik_karyawan As String, nama As String, hubungan As String, status As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tanggungan (nik_karyawan, nama, hubungan, status) VALUES (@nik, @nama, @hubungan, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik_karyawan)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hubungan", hubungan)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ubahTanggungan(id As Integer, nik_karyawan As String, nama As String, hubungan As String, status As String) As Boolean
        Try
            Dim query As String = ""
            If CurrentRole = "admin" Then
                query = "UPDATE tanggungan SET nik_karyawan = @nik, nama = @nama, hubungan = @hubungan, status = @status WHERE id_tanggungan = @id"
            Else
                query = "UPDATE tanggungan SET nama = @nama, hubungan = @hubungan, status = @status WHERE id_tanggungan = @id AND nik_karyawan = @nik"
            End If

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nik", nik_karyawan)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hubungan", hubungan)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function hapusTanggungan(id As Integer) As Boolean
        Try
            Dim query As String = ""
            If CurrentRole = "admin" Then
                query = "DELETE FROM tanggungan WHERE id_tanggungan = @id"
            Else
                query = "DELETE FROM tanggungan WHERE id_tanggungan = @id AND nik_karyawan = @nik"
            End If

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    If CurrentRole <> "admin" Then
                        cmd.Parameters.AddWithValue("@nik", CurrentNIK)
                    End If
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function GetAllKaryawanUntukLaporan() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT nik, nama, email, hp, jenis_kelamin, gaji, role FROM karyawan ORDER BY nik ASC"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data laporan karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function GetAllTanggunganUntukLaporan(Optional ByVal filterNIK As String = "") As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT t.id_tanggungan, t.nik_karyawan, k.nama AS nama_karyawan, t.nama AS nama_tanggungan, t.hubungan, t.status FROM tanggungan t INNER JOIN karyawan k ON t.nik_karyawan = k.nik"
        If filterNIK <> "" Then
            query &= " WHERE t.nik_karyawan = @nik"
        End If
        query &= " ORDER BY t.nik_karyawan, t.nama"
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    If filterNIK <> "" Then
                        cmd.Parameters.AddWithValue("@nik", filterNIK)
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data laporan tanggungan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module