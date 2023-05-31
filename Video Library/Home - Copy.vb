Public Class Home

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        AddVideo.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Me.Hide()
        Search.Show()
    End Sub


    
End Class
