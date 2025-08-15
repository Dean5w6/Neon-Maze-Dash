Public Class Form1
    Private WithEvents flickerTimer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flickerTimer.Interval = 500
        flickerTimer.Start()
    End Sub

    Private Sub flickerTimer_Tick(sender As Object, e As EventArgs) Handles flickerTimer.Tick
        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim form5 As Form5
        form5 = New Form5()
        form5.Show()
    End Sub
End Class