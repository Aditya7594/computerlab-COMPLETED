Public Class Admindashboard


    Private Sub btnFeedbacks_Click(sender As Object, e As EventArgs) Handles btnFeedbacks.Click
        Feedbacks1.Show
        Students1.Hide
        Feedbacks1.BringToFront
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Feedbacks1.Hide()
        Students1.Show()
        Students1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        intro.Show()
    End Sub
End Class