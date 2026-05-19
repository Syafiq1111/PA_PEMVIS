<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        txtIdentifier = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtIdentifier
        ' 
        txtIdentifier.Location = New Point(42, 142)
        txtIdentifier.Name = "txtIdentifier"
        txtIdentifier.Size = New Size(220, 23)
        txtIdentifier.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(42, 193)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(220, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(67), CByte(66), CByte(245))
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(42, 222)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(220, 30)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(299, 293)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtIdentifier)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents txtIdentifier As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
