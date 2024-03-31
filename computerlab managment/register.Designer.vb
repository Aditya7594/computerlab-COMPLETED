<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        registerPanel = New Panel()
        Button1 = New Button()
        lblName = New Label()
        txtName = New TextBox()
        lblNumber = New Label()
        txtNumber = New TextBox()
        lblAddress = New Label()
        txtAddress = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        btnRegister = New Button()
        registerPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' registerPanel
        ' 
        registerPanel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        registerPanel.BorderStyle = BorderStyle.FixedSingle
        registerPanel.Controls.Add(Button1)
        registerPanel.Controls.Add(lblName)
        registerPanel.Controls.Add(txtName)
        registerPanel.Controls.Add(lblNumber)
        registerPanel.Controls.Add(txtNumber)
        registerPanel.Controls.Add(lblAddress)
        registerPanel.Controls.Add(txtAddress)
        registerPanel.Controls.Add(lblPassword)
        registerPanel.Controls.Add(txtPassword)
        registerPanel.Controls.Add(lblEmail)
        registerPanel.Controls.Add(txtEmail)
        registerPanel.Controls.Add(btnRegister)
        registerPanel.Location = New Point(153, 54)
        registerPanel.Name = "registerPanel"
        registerPanel.Size = New Size(464, 446)
        registerPanel.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(369, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "LoGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Arial", 10F)
        lblName.ForeColor = Color.White
        lblName.Location = New Point(44, 50)
        lblName.Name = "lblName"
        lblName.Size = New Size(47, 16)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtName.ForeColor = Color.White
        txtName.Location = New Point(140, 50)
        txtName.Name = "txtName"
        txtName.Size = New Size(176, 23)
        txtName.TabIndex = 1
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Arial", 10F)
        lblNumber.ForeColor = Color.White
        lblNumber.Location = New Point(44, 100)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(60, 16)
        lblNumber.TabIndex = 2
        lblNumber.Text = "Number:"
        ' 
        ' txtNumber
        ' 
        txtNumber.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtNumber.ForeColor = Color.White
        txtNumber.Location = New Point(140, 100)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(176, 23)
        txtNumber.TabIndex = 3
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Arial", 10F)
        lblAddress.ForeColor = Color.White
        lblAddress.Location = New Point(44, 150)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(63, 16)
        lblAddress.TabIndex = 4
        lblAddress.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtAddress.ForeColor = Color.White
        txtAddress.Location = New Point(140, 150)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(176, 60)
        txtAddress.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 10F)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(44, 230)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(72, 16)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(140, 230)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(176, 23)
        txtPassword.TabIndex = 7
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Arial", 10F)
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(44, 280)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(45, 16)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(140, 280)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(176, 23)
        txtEmail.TabIndex = 9
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(158, 328)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(105, 40)
        btnRegister.TabIndex = 10
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(760, 580)
        Controls.Add(registerPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "register"
        Text = "Register"
        registerPanel.ResumeLayout(False)
        registerPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents registerPanel As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Button1 As Button
End Class
