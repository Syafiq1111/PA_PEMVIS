Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String = "Server=localhost;Port=3306;Database=db_kantor;UserID=root;Password=;"

    ' SESSION STATE GLOBAL
    ' Variabel-variabel ini bakalan menyimpan data pengguna yang berhasil login
    Public CurrentNIK As String = ""
    Public CurrentNama As String = ""
    Public CurrentRole As String = "" ' admin atau karyawan

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    ' Fungsi untuk membersihkan sesi saat pengguna logout
    Public Sub ClearSession()
        CurrentNIK = ""
        CurrentNama = ""
        CurrentRole = ""
    End Sub
End Module