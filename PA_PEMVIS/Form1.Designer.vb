<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNama = New TextBox()
        txtNIK = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvKaryawan = New DataGridView()
        txtEmail = New TextBox()
        Label4 = New Label()
        mtbHP = New MaskedTextBox()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        Label5 = New Label()
        txtPassword = New TextBox()
        Label6 = New Label()
        MenuStrip1 = New MenuStrip()
        btnForm2 = New ToolStripMenuItem()
        btnLogin = New ToolStripMenuItem()
        cbRole = New ComboBox()
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 15)
        Label2.TabIndex = 1
        Label2.Text = "NIK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(130, 65)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(445, 23)
        txtNama.TabIndex = 3
        ' 
        ' txtNIK
        ' 
        txtNIK.Location = New Point(130, 34)
        txtNIK.Margin = New Padding(3, 2, 3, 2)
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(445, 23)
        txtNIK.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(297, 207)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(368, 207)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(65, 26)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(439, 207)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(510, 207)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvKaryawan
        ' 
        dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKaryawan.Location = New Point(17, 280)
        dgvKaryawan.Margin = New Padding(3, 2, 3, 2)
        dgvKaryawan.Name = "dgvKaryawan"
        dgvKaryawan.RowHeadersWidth = 51
        dgvKaryawan.Size = New Size(558, 158)
        dgvKaryawan.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(130, 99)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(445, 23)
        txtEmail.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 12
        Label4.Text = "No. HP"
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(130, 134)
        mtbHP.Mask = "000000000000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(178, 23)
        mtbHP.TabIndex = 13
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(17, 246)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nik atau nama karyawan "
        txtCari.Size = New Size(219, 23)
        txtCari.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 17
        Label5.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(130, 171)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(445, 23)
        txtPassword.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 19
        Label6.Text = "Role"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnForm2, btnLogin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(598, 24)
        MenuStrip1.TabIndex = 21
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnForm2
        ' 
        btnForm2.Name = "btnForm2"
        btnForm2.Size = New Size(84, 20)
        btnForm2.Text = "tanggungan"
        ' 
        ' btnLogin
        ' 
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(54, 20)
        btnLogin.Text = "logout"
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Location = New Point(130, 207)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(121, 23)
        cbRole.TabIndex = 22
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 449)
        Controls.Add(cbRole)
        Controls.Add(Label6)
        Controls.Add(txtPassword)
        Controls.Add(Label5)
        Controls.Add(txtCari)
        Controls.Add(mtbHP)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(dgvKaryawan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtNIK)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Sistem Manajemen Data Karyawan PT.XYZ"
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnLogin As ToolStripMenuItem
    Friend WithEvents btnForm2 As ToolStripMenuItem
    Friend WithEvents cbRole As ComboBox

End Class
