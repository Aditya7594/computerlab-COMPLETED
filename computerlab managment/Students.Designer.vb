<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        studentname = New TextBox()
        Panel1 = New Panel()
        lblAddress = New Label()
        lblNumber = New Label()
        lblEmail = New Label()
        lblname = New Label()
        search = New Button()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' studentname
        ' 
        studentname.Location = New Point(58, 62)
        studentname.Name = "studentname"
        studentname.Size = New Size(127, 23)
        studentname.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblNumber)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblname)
        Panel1.Location = New Point(55, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(216, 282)
        Panel1.TabIndex = 1
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(70, 187)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(60, 21)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Label4"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumber.Location = New Point(70, 137)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(60, 21)
        lblNumber.TabIndex = 2
        lblNumber.Text = "Label3"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(70, 81)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(60, 21)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Label2"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblname.Location = New Point(70, 32)
        lblname.Name = "lblname"
        lblname.Size = New Size(60, 21)
        lblname.TabIndex = 0
        lblname.Text = "Label1"
        ' 
        ' search
        ' 
        search.Location = New Point(193, 61)
        search.Name = "search"
        search.Size = New Size(75, 23)
        search.TabIndex = 2
        search.Text = "Search"
        search.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 32)
        Label5.TabIndex = 3
        Label5.Text = "Search Student"
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        Controls.Add(Label5)
        Controls.Add(search)
        Controls.Add(Panel1)
        Controls.Add(studentname)
        Name = "Students"
        Size = New Size(636, 452)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studentname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblname As Label
    Friend WithEvents search As Button
    Friend WithEvents Label5 As Label

End Class
