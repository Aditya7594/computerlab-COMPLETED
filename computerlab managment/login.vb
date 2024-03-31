Imports System.Data.SqlClient

Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya Nayak\source\repos\computerlab managment\computerlab managment\computerlab.mdf;Integrated Security=True"
        con.Open()

        If (txtUsername.Text = "" Or txtPassword.Text = "") Then
            MessageBox.Show("Please enter both username/email and password")
            Return
        End If

        cmd = New SqlCommand("SELECT * FROM students WHERE (txtName = @Username OR txtEmail = @Username) AND txtPassword = @Password", con)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read() ' Move to the first (and only) row
            MessageBox.Show("Login successful")
            ' Pass logged-in user's information to Welcome form
            Dim userInfo As New UserInfo(dr("txtName").ToString(), dr("txtEmail").ToString())
            Dim Welcome As New Welcome(userInfo)
            Welcome.Show()
            Me.Hide()
        End If


        dr.Close()
        con.Close()
    End Sub

    Public Class UserInfo
        Public Property UserName As String
        Public Property Email As String

        Public Sub New(ByVal userName As String, ByVal email As String)
            Me.UserName = userName
            Me.Email = email
        End Sub
    End Class

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        register.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Adminlogin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        intro.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
