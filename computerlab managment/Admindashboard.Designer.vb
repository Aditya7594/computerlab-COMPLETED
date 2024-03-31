<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admindashboard
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
        Panel1 = New Panel()
        btnFeedbacks = New Button()
        btnStudents = New Button()
        Students1 = New Students()
        Feedbacks1 = New Feedbacks()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnFeedbacks)
        Panel1.Controls.Add(btnStudents)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(167, 452)
        Panel1.TabIndex = 0
        ' 
        ' btnFeedbacks
        ' 
        btnFeedbacks.BackColor = Color.Red
        btnFeedbacks.FlatAppearance.BorderSize = 0
        btnFeedbacks.FlatStyle = FlatStyle.Popup
        btnFeedbacks.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnFeedbacks.ForeColor = Color.White
        btnFeedbacks.Location = New Point(14, 134)
        btnFeedbacks.Name = "btnFeedbacks"
        btnFeedbacks.Size = New Size(138, 52)
        btnFeedbacks.TabIndex = 4
        btnFeedbacks.Text = "Feedbacks"
        btnFeedbacks.UseVisualStyleBackColor = False
        ' 
        ' btnStudents
        ' 
        btnStudents.BackColor = Color.Red
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatStyle = FlatStyle.Popup
        btnStudents.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudents.ForeColor = Color.White
        btnStudents.Location = New Point(14, 62)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(138, 52)
        btnStudents.TabIndex = 3
        btnStudents.Text = "Students"
        btnStudents.UseVisualStyleBackColor = False
        ' 
        ' Students1
        ' 
        Students1.BackColor = Color.Cyan
        Students1.Location = New Point(156, -1)
        Students1.Name = "Students1"
        Students1.Size = New Size(648, 452)
        Students1.TabIndex = 1
        ' 
        ' Feedbacks1
        ' 
        Feedbacks1.BackColor = Color.Lime
        Feedbacks1.Location = New Point(156, -1)
        Feedbacks1.Name = "Feedbacks1"
        Feedbacks1.Size = New Size(648, 452)
        Feedbacks1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(14, 387)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 52)
        Button1.TabIndex = 5
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Admindashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Feedbacks1)
        Controls.Add(Students1)
        Controls.Add(Panel1)
        Name = "Admindashboard"
        Text = "Admindashboard"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnFeedbacks As Button
    Friend WithEvents Students1 As Students
    Friend WithEvents Feedbacks1 As Feedbacks
    Friend WithEvents Button1 As Button
End Class
