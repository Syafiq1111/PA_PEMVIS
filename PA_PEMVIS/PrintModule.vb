Imports System.Drawing.Printing
Imports System.Drawing

Module PrintModule

    ' Data yang akan dicetak
    Public LaporanData As DataTable = Nothing
    Public CurrentRow As Integer = 0
    Public LaporanTipe As String = ""   ' "Karyawan" atau "Tanggungan"

    Public Sub SetLaporanData(data As DataTable, tipe As String)
        LaporanData = data
        CurrentRow = 0
        LaporanTipe = tipe
    End Sub

    ' ======================= RENDER LAPORAN KARYAWAN =======================
    Public Sub RenderLaporanKaryawan(e As PrintPageEventArgs)
        If LaporanData Is Nothing OrElse LaporanData.Rows.Count = 0 Then
            Using fontKosong As New Font("Calibri", 12, FontStyle.Regular)
                e.Graphics.DrawString("Tidak ada data karyawan yang dapat dicetak.", fontKosong, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
            Return
        End If

        Dim area As Rectangle = e.MarginBounds
        Dim currentY As Integer = area.Top
        Dim rowHeight As Integer = 28

        Using fontJudul As New Font("Times New Roman", 18, FontStyle.Bold),
              fontSubJudul As New Font("Calibri", 10, FontStyle.Italic),
              fontHeader As New Font("Calibri", 10, FontStyle.Bold),
              fontIsi As New Font("Calibri", 10, FontStyle.Regular),
              penaTabel As New Pen(Color.Black, 1),
              brushHeader As New SolidBrush(Color.Gainsboro)

            ' Judul
            e.Graphics.DrawString("LAPORAN DATA KARYAWAN", fontJudul, Brushes.Black, area.Left, currentY)
            currentY += 30
            e.Graphics.DrawString("Perpustakaan - Hasil Cetak Sistem", fontSubJudul, Brushes.Gray, area.Left, currentY)
            currentY += 20
            e.Graphics.DrawLine(penaTabel, area.Left, currentY, area.Right, currentY)
            currentY += 10

            ' Header tabel
            Dim kolom() As String = {"NIK", "Nama", "Email", "HP", "JK", "Gaji", "Role"}
            Dim lebar() As Integer = {100, 150, 180, 100, 50, 100, 100}
            Dim x As Integer = area.Left

            For i As Integer = 0 To kolom.Length - 1
                Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                DrawCell(e.Graphics, kolom(i), fontHeader, Brushes.Black, penaTabel, rect, StringAlignment.Center, brushHeader)
                x += lebar(i)
            Next
            currentY += rowHeight

            ' Isi data
            While CurrentRow < LaporanData.Rows.Count
                If currentY + rowHeight > area.Bottom - 30 Then
                    e.HasMorePages = True
                    Return
                End If

                Dim row As DataRow = LaporanData.Rows(CurrentRow)
                Dim isi() As String = {
                    row("nik").ToString(),
                    row("nama").ToString(),
                    row("email").ToString(),
                    row("hp").ToString(),
                    row("jenis_kelamin").ToString(),
                    FormatNumber(Convert.ToDouble(row("gaji")), 0),
                    row("role").ToString()
                }
                x = area.Left
                For i As Integer = 0 To isi.Length - 1
                    Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                    Dim alignment As StringAlignment = If(i = 0 Or i = 5, StringAlignment.Center, StringAlignment.Near)
                    DrawCell(e.Graphics, isi(i), fontIsi, Brushes.Black, penaTabel, rect, alignment)
                    x += lebar(i)
                Next
                currentY += rowHeight
                CurrentRow += 1
            End While

            ' Footer total data
            e.Graphics.DrawString("Total Data: " & LaporanData.Rows.Count.ToString(),
                                  New Font("Calibri", 9, FontStyle.Italic),
                                  Brushes.Black, area.Left, currentY + 8)
        End Using
        e.HasMorePages = False
    End Sub

    ' ======================= RENDER LAPORAN TANGGUNGAN =======================
    Public Sub RenderLaporanTanggungan(e As PrintPageEventArgs)
        If LaporanData Is Nothing OrElse LaporanData.Rows.Count = 0 Then
            Using fontKosong As New Font("Calibri", 12, FontStyle.Regular)
                e.Graphics.DrawString("Tidak ada data tanggungan yang dapat dicetak.", fontKosong, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
            Return
        End If

        Dim area As Rectangle = e.MarginBounds
        Dim currentY As Integer = area.Top
        Dim rowHeight As Integer = 28

        Using fontJudul As New Font("Times New Roman", 18, FontStyle.Bold),
              fontSubJudul As New Font("Calibri", 10, FontStyle.Italic),
              fontHeader As New Font("Calibri", 10, FontStyle.Bold),
              fontIsi As New Font("Calibri", 10, FontStyle.Regular),
              penaTabel As New Pen(Color.Black, 1),
              brushHeader As New SolidBrush(Color.Gainsboro)

            ' Judul
            e.Graphics.DrawString("LAPORAN DATA TANGGUNGAN KARYAWAN", fontJudul, Brushes.Black, area.Left, currentY)
            currentY += 30
            e.Graphics.DrawString("Perpustakaan - Hasil Cetak Sistem", fontSubJudul, Brushes.Gray, area.Left, currentY)
            currentY += 20
            e.Graphics.DrawLine(penaTabel, area.Left, currentY, area.Right, currentY)
            currentY += 10

            ' Header tabel
            Dim kolom() As String = {"NIK Karyawan", "Nama Karyawan", "Nama Tanggungan", "Hubungan", "Status"}
            Dim lebar() As Integer = {100, 150, 150, 100, 100}
            Dim x As Integer = area.Left

            For i As Integer = 0 To kolom.Length - 1
                Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                DrawCell(e.Graphics, kolom(i), fontHeader, Brushes.Black, penaTabel, rect, StringAlignment.Center, brushHeader)
                x += lebar(i)
            Next
            currentY += rowHeight

            ' Isi data
            While CurrentRow < LaporanData.Rows.Count
                If currentY + rowHeight > area.Bottom - 30 Then
                    e.HasMorePages = True
                    Return
                End If

                Dim row As DataRow = LaporanData.Rows(CurrentRow)
                Dim isi() As String = {
                    row("nik_karyawan").ToString(),
                    row("nama_karyawan").ToString(),
                    row("nama_tanggungan").ToString(),
                    row("hubungan").ToString(),
                    row("status").ToString()
                }
                x = area.Left
                For i As Integer = 0 To isi.Length - 1
                    Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                    DrawCell(e.Graphics, isi(i), fontIsi, Brushes.Black, penaTabel, rect, StringAlignment.Near)
                    x += lebar(i)
                Next
                currentY += rowHeight
                CurrentRow += 1
            End While

            ' Footer total data
            e.Graphics.DrawString("Total Data: " & LaporanData.Rows.Count.ToString(),
                                  New Font("Calibri", 9, FontStyle.Italic),
                                  Brushes.Black, area.Left, currentY + 8)
        End Using
        e.HasMorePages = False
    End Sub

    ' ======================= FUNGSI BANTU MENGGAMBAR SEL =======================
    Private Sub DrawCell(g As Graphics, text As String, font As Font, brush As Brush, pen As Pen,
                         rect As Rectangle, alignment As StringAlignment, Optional fillBrush As Brush = Nothing)
        If fillBrush IsNot Nothing Then
            g.FillRectangle(fillBrush, rect)
        End If
        g.DrawRectangle(pen, rect)

        Dim sf As New StringFormat()
        sf.Alignment = alignment
        sf.LineAlignment = StringAlignment.Center
        sf.Trimming = StringTrimming.EllipsisCharacter

        Dim innerRect As New Rectangle(rect.X + 4, rect.Y + 2, rect.Width - 8, rect.Height - 4)
        g.DrawString(text, font, brush, innerRect, sf)
    End Sub

End Module