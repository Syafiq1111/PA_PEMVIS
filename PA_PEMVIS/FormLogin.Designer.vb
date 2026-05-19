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
        lblIdentifier = New Label()
        txtIdentifier = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblIdentifier
        ' 
        lblIdentifier.AutoSize = True
        lblIdentifier.Location = New Point(34, 40)
        lblIdentifier.Name = "lblIdentifier"
        lblIdentifier.Size = New Size(84, 20)
        lblIdentifier.TabIndex = 0
        lblIdentifier.Text = "NIK / Email"
        ' 
        ' txtIdentifier
        ' 
        txtIdentifier.Location = New Point(34, 67)
        txtIdentifier.Margin = New Padding(3, 4, 3, 4)
        txtIdentifier.Name = "txtIdentifier"
        txtIdentifier.Size = New Size(251, 27)
        txtIdentifier.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(34, 120)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(70, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(34, 147)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(251, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(34, 213)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(251, 40)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 308)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtIdentifier)
        Controls.Add(lblIdentifier)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblIdentifier As Label
    Friend WithEvents txtIdentifier As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
