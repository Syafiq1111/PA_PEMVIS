Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String = "Server=localhost;Port=3306;Database=db_posttest_pemvis;UserID=root;Password=;"

    Public CurrentNIK As String = ""
    Public CurrentNama As String = ""
    Public CurrentRole As String = ""

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