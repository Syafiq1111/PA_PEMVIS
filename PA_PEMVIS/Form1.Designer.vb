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
        Label7 = New Label()
        txtGaji = New TextBox()
        Label8 = New Label()
        rdPria = New RadioButton()
        rdWanita = New RadioButton()
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 20)
        Label2.TabIndex = 1
        Label2.Text = "NIK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(149, 87)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(508, 27)
        txtNama.TabIndex = 3
        ' 
        ' txtNIK
        ' 
        txtNIK.Location = New Point(149, 45)
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(508, 27)
        txtNIK.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(336, 414)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(74, 35)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(418, 414)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(74, 35)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(499, 414)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(74, 35)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(580, 414)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(74, 35)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvKaryawan
        ' 
        dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKaryawan.Location = New Point(19, 483)
        dgvKaryawan.Name = "dgvKaryawan"
        dgvKaryawan.RowHeadersWidth = 51
        dgvKaryawan.Size = New Size(638, 211)
        dgvKaryawan.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(149, 132)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(508, 27)
        txtEmail.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 12
        Label4.Text = "No. HP"
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(149, 231)
        mtbHP.Margin = New Padding(3, 4, 3, 4)
        mtbHP.Mask = "000000000000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(203, 27)
        mtbHP.TabIndex = 13
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(19, 450)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nik atau nama karyawan "
        txtCari.Size = New Size(250, 27)
        txtCari.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 322)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 17
        Label5.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(149, 318)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(508, 27)
        txtPassword.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 363)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 19
        Label6.Text = "Role"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnForm2, btnLogin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(683, 30)
        MenuStrip1.TabIndex = 21
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnForm2
        ' 
        btnForm2.Name = "btnForm2"
        btnForm2.Size = New Size(103, 24)
        btnForm2.Text = "tanggungan"
        ' 
        ' btnLogin
        ' 
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(67, 24)
        btnLogin.Text = "logout"
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"karyawan", "admin"})
        cbRole.Location = New Point(149, 360)
        cbRole.Margin = New Padding(3, 4, 3, 4)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(138, 28)
        cbRole.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 20)
        Label7.TabIndex = 23
        Label7.Text = "Gaji"
        ' 
        ' txtGaji
        ' 
        txtGaji.Location = New Point(149, 277)
        txtGaji.Name = "txtGaji"
        txtGaji.Size = New Size(203, 27)
        txtGaji.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 182)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 20)
        Label8.TabIndex = 25
        Label8.Text = "Jenis Kelamin"
        ' 
        ' rdPria
        ' 
        rdPria.AutoSize = True
        rdPria.Location = New Point(149, 182)
        rdPria.Name = "rdPria"
        rdPria.Size = New Size(55, 24)
        rdPria.TabIndex = 26
        rdPria.TabStop = True
        rdPria.Text = "Pria"
        rdPria.UseVisualStyleBackColor = True
        ' 
        ' rdWanita
        ' 
        rdWanita.AutoSize = True
        rdWanita.Location = New Point(223, 182)
        rdWanita.Name = "rdWanita"
        rdWanita.Size = New Size(76, 24)
        rdWanita.TabIndex = 27
        rdWanita.TabStop = True
        rdWanita.Text = "Wanita"
        rdWanita.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 706)
        Controls.Add(rdWanita)
        Controls.Add(rdPria)
        Controls.Add(Label8)
        Controls.Add(txtGaji)
        Controls.Add(Label7)
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
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rdWanita As RadioButton
    Friend WithEvents rdPria As RadioButton
    Friend WithEvents Label8 As Label

End Class
