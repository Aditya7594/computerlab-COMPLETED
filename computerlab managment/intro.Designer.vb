' In Welcome.Designer.vb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class intro
    Inherits System.Windows.Forms.Form

    'Designer code here

    ' Add your controls and their properties here
    Private Sub InitializeComponent()
        lblProjectName = New Label()
        mainPanel = New Panel()
        btnLogin = New Button()
        btnRegister = New Button()
        lblText = New Label()
        Button1 = New Button()
        Button2 = New Button()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblProjectName
        ' 
        lblProjectName.AutoSize = True
        lblProjectName.Font = New Font("Arial", 16F, FontStyle.Bold)
        lblProjectName.Location = New Point(44, 20)
        lblProjectName.Name = "lblProjectName"
        lblProjectName.Size = New Size(293, 26)
        lblProjectName.TabIndex = 0
        lblProjectName.Text = "Computer Lab Management"
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.White
        mainPanel.Controls.Add(btnLogin)
        mainPanel.Controls.Add(btnRegister)
        mainPanel.Controls.Add(lblText)
        mainPanel.Location = New Point(80, 90)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(555, 264)
        mainPanel.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(143, 200)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 30)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(344, 200)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(88, 30)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.Font = New Font("Arial", 12F)
        lblText.Location = New Point(131, 80)
        lblText.Name = "lblText"
        lblText.Size = New Size(346, 18)
        lblText.TabIndex = 2
        lblText.Text = "Welcome to Computer Lab Management System"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(519, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 34)
        Button1.TabIndex = 2
        Button1.Text = "Admin Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(519, 381)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 30)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' intro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(700, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblProjectName)
        Controls.Add(mainPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "intro"
        Text = "Welcome"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Event handler for login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        ' Add your login logic here
        MessageBox.Show("Login button clicked")
    End Sub

    ' Event handler for registration button click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        ' Add your registration logic here
        MessageBox.Show("Register button clicked")
    End Sub

    Friend WithEvents lblProjectName As Label
    Friend WithEvents mainPanel As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
