<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
    Inherits System.Windows.Forms.Form

    Friend WithEvents pnlOptions As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents Button1 As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        pnlOptions = New Panel()
        Button1 = New Button()
        btnFeedback = New Button()
        btnProfile = New Button()
        btnAboutUs = New Button()
        lblWelcome = New Label()
        About1 = New About()
        Feedback1 = New Feedback()
        pnlProfile = New Panel()
        Panel1 = New Panel()
        lbltime = New Label()
        lblsystem = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        lbldate = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblUserName = New Label()
        pnlOptions.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOptions
        ' 
        pnlOptions.BackColor = Color.Blue
        pnlOptions.Controls.Add(Button1)
        pnlOptions.Controls.Add(btnFeedback)
        pnlOptions.Controls.Add(btnProfile)
        pnlOptions.Controls.Add(btnAboutUs)
        pnlOptions.Controls.Add(lblWelcome)
        pnlOptions.Dock = DockStyle.Left
        pnlOptions.Location = New Point(0, 0)
        pnlOptions.Name = "pnlOptions"
        pnlOptions.Size = New Size(153, 636)
        pnlOptions.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 543)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 54)
        Button1.TabIndex = 7
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnFeedback
        ' 
        btnFeedback.BackColor = Color.Blue
        btnFeedback.FlatAppearance.BorderSize = 0
        btnFeedback.FlatStyle = FlatStyle.Popup
        btnFeedback.ForeColor = Color.White
        btnFeedback.Location = New Point(12, 240)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.Size = New Size(123, 54)
        btnFeedback.TabIndex = 6
        btnFeedback.Text = "Feedback"
        btnFeedback.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Blue
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Popup
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(12, 74)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(123, 52)
        btnProfile.TabIndex = 3
        btnProfile.Text = "View Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnAboutUs
        ' 
        btnAboutUs.BackColor = Color.Blue
        btnAboutUs.FlatAppearance.BorderSize = 0
        btnAboutUs.FlatStyle = FlatStyle.Popup
        btnAboutUs.ForeColor = Color.White
        btnAboutUs.Location = New Point(12, 162)
        btnAboutUs.Name = "btnAboutUs"
        btnAboutUs.Size = New Size(123, 54)
        btnAboutUs.TabIndex = 5
        btnAboutUs.Text = "About Us"
        btnAboutUs.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Blue
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(8, 20)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(60, 15)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome!"
        ' 
        ' About1
        ' 
        About1.BackColor = Color.Lime
        About1.Location = New Point(159, 0)
        About1.Name = "About1"
        About1.Size = New Size(793, 639)
        About1.TabIndex = 1
        ' 
        ' Feedback1
        ' 
        Feedback1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Feedback1.Location = New Point(159, 0)
        Feedback1.Name = "Feedback1"
        Feedback1.Size = New Size(793, 639)
        Feedback1.TabIndex = 2
        ' 
        ' pnlProfile
        ' 
        pnlProfile.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        pnlProfile.Controls.Add(Panel1)
        pnlProfile.Controls.Add(lbldate)
        pnlProfile.Controls.Add(Label1)
        pnlProfile.Controls.Add(PictureBox1)
        pnlProfile.Controls.Add(lblUserName)
        pnlProfile.Location = New Point(159, 1)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(793, 635)
        pnlProfile.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lime
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lbltime)
        Panel1.Controls.Add(lblsystem)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(3, 208)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(787, 427)
        Panel1.TabIndex = 6
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltime.Location = New Point(32, 76)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(77, 30)
        lbltime.TabIndex = 11
        lbltime.Text = "Label7"
        ' 
        ' lblsystem
        ' 
        lblsystem.AutoSize = True
        lblsystem.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsystem.Location = New Point(32, 37)
        lblsystem.Name = "lblsystem"
        lblsystem.Size = New Size(77, 30)
        lblsystem.TabIndex = 10
        lblsystem.Text = "Label7"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(115, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(256, 105)
        Label6.TabIndex = 9
        Label6.Text = "Windows 7 2007" & vbCrLf & "Intel Xe-LP Integrated Graphics" & vbCrLf & "8 GB ram ,256 Gb SSD" & vbCrLf & "Gigabyte Z490 AORUS ELITE AC" & vbCrLf & "Dell S3221QS 32-inch 4K Monitor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(115, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(268, 126)
        Label5.TabIndex = 8
        Label5.Text = "Visual Studio" & vbCrLf & "Visual Basic 6.0 (VB6)" & vbCrLf & "Visual Basic for Applications (VBA)" & vbCrLf & "SharpDevelop" & vbCrLf & "MonoDevelop" & vbCrLf & "Notepad++"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 25)
        Label3.TabIndex = 7
        Label3.Text = "Hardware:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 2
        Label4.Text = "Software:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Lime
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(-2, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(207, 32)
        Label2.TabIndex = 5
        Label2.Text = "Your System info"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(626, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 124)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbldate.Location = New Point(612, 19)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(57, 25)
        lbldate.TabIndex = 4
        lbldate.Text = "Label"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HP Simplified Hans", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 33)
        Label1.TabIndex = 3
        Label1.Text = "Greetings!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(37, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 110)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUserName.Location = New Point(188, 61)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(73, 30)
        lblUserName.TabIndex = 0
        lblUserName.Text = "Label1"
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(950, 636)
        Controls.Add(pnlProfile)
        Controls.Add(Feedback1)
        Controls.Add(About1)
        Controls.Add(pnlOptions)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Welcome"
        Text = "Dashboard"
        pnlOptions.ResumeLayout(False)
        pnlOptions.PerformLayout()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

        ' Add more hardware and software details as needed...

    End Sub
    Friend WithEvents About1 As About
    Friend WithEvents Feedback1 As Feedback
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents lblUserName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lblsystem As Label
End Class
