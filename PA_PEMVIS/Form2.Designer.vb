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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Me.cbNik = New ComboBox()
        Me.cbStatus = New ComboBox()
        Me.txtNama = New TextBox()
        txtHubungan = New TextBox()
        dgvTanggungan = New DataGridView()
        btnSimpan = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        txtCari = New TextBox()
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 2
        Label3.Text = "Hubungan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Status"
        ' 
        ' cbNik
        ' 
        Me.cbNik.FormattingEnabled = True
        Me.cbNik.Location = New Point(119, 23)
        Me.cbNik.Name = "cbNik"
        Me.cbNik.Size = New Size(336, 23)
        Me.cbNik.TabIndex = 4
        ' 
        ' cbStatus
        ' 
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Bekerja", "TIdak Bekerja", "Meninggal Dunia"})
        Me.cbStatus.Location = New Point(119, 124)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New Size(178, 23)
        Me.cbStatus.TabIndex = 5
        ' 
        ' txtNama
        ' 
        Me.txtNama.Location = New Point(119, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New Size(336, 23)
        Me.txtNama.TabIndex = 6
        ' 
        ' txtHubungan
        ' 
        txtHubungan.Location = New Point(119, 90)
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
        btnSimpan.Location = New Point(481, 20)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(481, 124)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(481, 90)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(481, 57)
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 411)
        Controls.Add(txtCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvTanggungan)
        Controls.Add(txtHubungan)
        Controls.Add(Me.txtNama)
        Controls.Add(Me.cbStatus)
        Controls.Add(Me.cbNik)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvTanggungan, ComponentModel.ISupportInitialize).EndInit()
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
End Class
