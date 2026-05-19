<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cbNik = New ComboBox()
        cbStatus = New ComboBox()
        txtNama = New TextBox()
        txtHubungan = New TextBox()
        dgvTanggungan = New DataGridView()
        btnSimpan = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1 = New MenuStrip()
        btnKaryawan = New ToolStripMenuItem()
        btnLogout = New ToolStripMenuItem()
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 2
        Label3.Text = "Hubungan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Status"
        ' 
        ' cbNik
        ' 
        cbNik.FormattingEnabled = True
        cbNik.Location = New Point(119, 32)
        cbNik.Name = "cbNik"
        cbNik.Size = New Size(336, 23)
        cbNik.TabIndex = 4
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Bekerja", "TIdak Bekerja", "Meninggal Dunia"})
        cbStatus.Location = New Point(119, 133)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(178, 23)
        cbStatus.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(119, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(336, 23)
        txtNama.TabIndex = 6
        ' 
        ' txtHubungan
        ' 
        txtHubungan.Location = New Point(119, 99)
        txtHubungan.Name = "txtHubungan"
        txtHubungan.Size = New Size(336, 23)
        txtHubungan.TabIndex = 7
        ' 
        ' dgvTanggungan
        ' 
        dgvTanggungan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTanggungan.Location = New Point(27, 216)
        dgvTanggungan.Name = "dgvTanggungan"
        dgvTanggungan.Size = New Size(519, 172)
        dgvTanggungan.TabIndex = 8
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(481, 29)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(481, 133)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(481, 99)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(481, 66)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(65, 26)
        btnUbah.TabIndex = 10
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(27, 176)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(519, 23)
        txtCari.TabIndex = 23
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnKaryawan, btnLogout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(578, 24)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnKaryawan
        ' 
        btnKaryawan.Name = "btnKaryawan"
        btnKaryawan.Size = New Size(69, 20)
        btnKaryawan.Text = "karyawan"
        ' 
        ' btnLogout
        ' 
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(57, 20)
        btnLogout.Text = "Logout"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 411)
        Controls.Add(txtCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvTanggungan)
        Controls.Add(txtHubungan)
        Controls.Add(txtNama)
        Controls.Add(cbStatus)
        Controls.Add(cbNik)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Sistem Manajemen Data Karyawan PT.XYZ"
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbNik As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHubungan As TextBox
    Friend WithEvents dgvTanggungan As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnLogout As ToolStripMenuItem
    Friend WithEvents btnKaryawan As ToolStripMenuItem
End Class
