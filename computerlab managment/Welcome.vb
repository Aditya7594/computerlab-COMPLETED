Imports System.Runtime.CompilerServices
Imports computerlab_managment.login

Public Class Welcome
    Private userInfo As UserInfo

    Public Sub New(ByVal userInfo As UserInfo)
        InitializeComponent()

        Me.userInfo = userInfo

        ' Display the logged-in user's information
        lblWelcome.Text = "Welcome, " & userInfo.UserName
        ' Populate profile panel controls with user data
        lblUserName.Text = userInfo.UserName
        Dim currentDate As DateTime = DateTime.Now

        ' Display the date in a label
        lbldate.Text = "Date: " & currentDate.ToShortDateString()
        lblsystem.Text = "System Name:" & " " & userInfo.UserName & " " & "System"
        lbltime.Text = "Time:" & " " & DateTime.Now.ToString("HH:mm:ss")

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        pnlProfile.Show()
        About1.Hide()
        Feedback1.Hide()
        pnlProfile.BringToFront()

    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click

        About1.Show()
        Feedback1.Hide()
        About1.BringToFront()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click

        About1.Hide()
        Feedback1.Show()
        Feedback1.BringToFront()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub
End Class
