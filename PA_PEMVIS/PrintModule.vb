Imports System.Drawing.Printing
Imports System.Drawing

Module PrintModule

    Public LaporanData As DataTable = Nothing
    Public CurrentRow As Integer = 0
    Public LaporanTipe As String = ""

    Public Sub SetLaporanData(data As DataTable, tipe As String)
        LaporanData = data
        CurrentRow = 0
        LaporanTipe = tipe
    End Sub

    Public Sub RenderLaporanKaryawan(e As PrintPageEventArgs)
        If LaporanData Is Nothing OrElse LaporanData.Rows.Count = 0 Then
            Using fontKosong As New Font("Segoe UI", 12, FontStyle.Regular)
                e.Graphics.DrawString("Tidak ada data karyawan yang dapat dicetak.", fontKosong, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
            Return
        End If

        Dim area As Rectangle = e.MarginBounds
        Dim currentY As Integer = area.Top
        Dim rowHeight As Integer = 32

        ' Setup Gaya Visual Modern
        Dim warnaTema As Color = Color.FromArgb(0, 120, 215)
        Using fontJudul As New Font("Segoe UI", 20, FontStyle.Bold),
              fontSubJudul As New Font("Segoe UI", 10, FontStyle.Italic),
              fontHeader As New Font("Segoe UI", 10, FontStyle.Bold),
              fontIsi As New Font("Segoe UI", 10, FontStyle.Regular),
              penaGarisTebal As New Pen(warnaTema, 2),
              penaTabel As New Pen(Color.LightGray, 1),
              brushHeaderBg As New SolidBrush(warnaTema),
              brushHeaderTeks As New SolidBrush(Color.White),
              brushTeks As New SolidBrush(Color.FromArgb(40, 40, 40))

            e.Graphics.DrawString("LAPORAN DATA KARYAWAN", fontJudul, brushHeaderBg, area.Left, currentY)
            currentY += 35
            e.Graphics.DrawString("Perpustakaan - Hasil Cetak Sistem", fontSubJudul, Brushes.Gray, area.Left, currentY)
            currentY += 25

            e.Graphics.DrawLine(penaGarisTebal, area.Left, currentY, area.Right, currentY)
            currentY += 15

            Dim kolom() As String = {"NIK", "Nama", "Email", "HP", "JK", "Gaji", "Role"}
            Dim lebar() As Integer = {150, 170, 220, 130, 60, 120, 100}
            Dim x As Integer = area.Left

            For i As Integer = 0 To kolom.Length - 1
                Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                DrawCell(e.Graphics, kolom(i), fontHeader, brushHeaderTeks, penaTabel, rect, StringAlignment.Center, brushHeaderBg)
                x += lebar(i)
            Next
            currentY += rowHeight

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

                Dim brushBaris As SolidBrush = If(CurrentRow Mod 2 = 0, New SolidBrush(Color.White), New SolidBrush(Color.FromArgb(245, 247, 250)))

                For i As Integer = 0 To isi.Length - 1
                    Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                    Dim alignment As StringAlignment = If(i = 0 Or i = 5, StringAlignment.Center, StringAlignment.Near)
                    DrawCell(e.Graphics, isi(i), fontIsi, brushTeks, penaTabel, rect, alignment, brushBaris)
                    x += lebar(i)
                Next

                brushBaris.Dispose()
                currentY += rowHeight
                CurrentRow += 1
            End While

            currentY += 10
            e.Graphics.DrawString("Total Data: " & LaporanData.Rows.Count.ToString() & " Karyawan",
                                  New Font("Segoe UI", 9, FontStyle.Italic),
                                  Brushes.Gray, area.Left, currentY)
        End Using
        e.HasMorePages = False
    End Sub

    Public Sub RenderLaporanTanggungan(e As PrintPageEventArgs)
        If LaporanData Is Nothing OrElse LaporanData.Rows.Count = 0 Then
            Using fontKosong As New Font("Segoe UI", 12, FontStyle.Regular)
                e.Graphics.DrawString("Tidak ada data tanggungan yang dapat dicetak.", fontKosong, Brushes.Black, 50, 50)
            End Using
            e.HasMorePages = False
            Return
        End If

        Dim area As Rectangle = e.MarginBounds
        Dim currentY As Integer = area.Top
        Dim rowHeight As Integer = 32

        Dim warnaTema As Color = Color.FromArgb(0, 120, 215)
        Using fontJudul As New Font("Segoe UI", 20, FontStyle.Bold),
              fontSubJudul As New Font("Segoe UI", 10, FontStyle.Italic),
              fontHeader As New Font("Segoe UI", 10, FontStyle.Bold),
              fontIsi As New Font("Segoe UI", 10, FontStyle.Regular),
              penaGarisTebal As New Pen(warnaTema, 2),
              penaTabel As New Pen(Color.LightGray, 1),
              brushHeaderBg As New SolidBrush(warnaTema),
              brushHeaderTeks As New SolidBrush(Color.White),
              brushTeks As New SolidBrush(Color.FromArgb(40, 40, 40))

            e.Graphics.DrawString("LAPORAN DATA TANGGUNGAN", fontJudul, brushHeaderBg, area.Left, currentY)
            currentY += 35
            e.Graphics.DrawString("Perpustakaan - Hasil Cetak Sistem", fontSubJudul, Brushes.Gray, area.Left, currentY)
            currentY += 25
            e.Graphics.DrawLine(penaGarisTebal, area.Left, currentY, area.Right, currentY)
            currentY += 15

            Dim kolom() As String = {"NIK Karyawan", "Nama Karyawan", "Nama Tanggungan", "Hubungan", "Status"}
            Dim lebar() As Integer = {130, 170, 170, 100, 100}
            Dim x As Integer = area.Left

            For i As Integer = 0 To kolom.Length - 1
                Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                DrawCell(e.Graphics, kolom(i), fontHeader, brushHeaderTeks, penaTabel, rect, StringAlignment.Center, brushHeaderBg)
                x += lebar(i)
            Next
            currentY += rowHeight

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

                Dim brushBaris As SolidBrush = If(CurrentRow Mod 2 = 0, New SolidBrush(Color.White), New SolidBrush(Color.FromArgb(245, 247, 250)))

                For i As Integer = 0 To isi.Length - 1
                    Dim rect As New Rectangle(x, currentY, lebar(i), rowHeight)
                    DrawCell(e.Graphics, isi(i), fontIsi, brushTeks, penaTabel, rect, StringAlignment.Near, brushBaris)
                    x += lebar(i)
                Next

                brushBaris.Dispose()
                currentY += rowHeight
                CurrentRow += 1
            End While

            currentY += 10
            e.Graphics.DrawString("Total Data: " & LaporanData.Rows.Count.ToString() & " Tanggungan",
                                  New Font("Segoe UI", 9, FontStyle.Italic),
                                  Brushes.Gray, area.Left, currentY)
        End Using
        e.HasMorePages = False
    End Sub

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

        Dim innerRect As New Rectangle(rect.X + 6, rect.Y, rect.Width - 12, rect.Height)
        g.DrawString(text, font, brush, innerRect, sf)
    End Sub

End Module