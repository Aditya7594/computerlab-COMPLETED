<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Feedname = New TextBox()
        Feeddesc = New RichTextBox()
        Feedsumbit = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 32)
        Label1.TabIndex = 0
        Label1.Text = "FeedBack"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 30)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 30)
        Label3.TabIndex = 2
        Label3.Text = "Description:"
        ' 
        ' Feedname
        ' 
        Feedname.Location = New Point(41, 111)
        Feedname.Name = "Feedname"
        Feedname.Size = New Size(160, 23)
        Feedname.TabIndex = 3
        ' 
        ' Feeddesc
        ' 
        Feeddesc.Location = New Point(41, 185)
        Feeddesc.Name = "Feeddesc"
        Feeddesc.Size = New Size(722, 259)
        Feeddesc.TabIndex = 4
        Feeddesc.Text = ""
        ' 
        ' Feedsumbit
        ' 
        Feedsumbit.Location = New Point(621, 478)
        Feedsumbit.Name = "Feedsumbit"
        Feedsumbit.Size = New Size(75, 23)
        Feedsumbit.TabIndex = 5
        Feedsumbit.Text = "Sumbit"
        Feedsumbit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(790, 46)
        Panel1.TabIndex = 6
        ' 
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Controls.Add(Panel1)
        Controls.Add(Feedsumbit)
        Controls.Add(Feeddesc)
        Controls.Add(Feedname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Feedback"
        Size = New Size(800, 636)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Feedname As TextBox
    Friend WithEvents Feeddesc As RichTextBox
    Friend WithEvents Feedsumbit As Button
    Friend WithEvents Panel1 As Panel

End Class
