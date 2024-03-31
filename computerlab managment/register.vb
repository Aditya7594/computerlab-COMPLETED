Imports System.Data.SqlClient

Public Class register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya Nayak\source\repos\computerlab managment\computerlab managment\computerlab.mdf;Integrated Security=True"
        con.Open()

        If (txtName.Text = "" Or txtNumber.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtPassword.Text = "") Then
            MessageBox.Show("Please enter all the details")
        Else
            cmd = New SqlCommand("INSERT INTO students (txtName, txtNumber, txtAddress, txtPassword, txtEmail) VALUES (@txtName, @txtNumber, @txtAddress, @txtPassword, @txtEmail)", con)
            cmd.Parameters.AddWithValue("@txtName", txtName.Text)
            cmd.Parameters.AddWithValue("@txtNumber", txtNumber.Text)
            cmd.Parameters.AddWithValue("@txtAddress", txtAddress.Text)
            cmd.Parameters.AddWithValue("@txtPassword", txtPassword.Text) ' Hash the password here
            cmd.Parameters.AddWithValue("@txtEmail", txtEmail.Text)


            cmd.ExecuteNonQuery() ' Execute the query to insert data into the database
            MessageBox.Show("Successfully registered")
            txtName.Clear()
            txtNumber.Clear()
            txtAddress.Clear()
            txtPassword.Clear()
            txtEmail.Clear()
        End If

        con.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
