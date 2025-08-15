Public Class Form6
    Dim WithEvents Timer1 As New Timer
    Dim WithEvents Timer2 As New Timer
    Dim WithEvents Timer3 As New Timer
    Dim Counter As Integer = 0

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1.Visible = False
        c2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox2.Top = 1300
        If Form4.Score1_2 > Form4.Score2_2 Then
            c1.Visible = True
        ElseIf Form4.Score2_2 > Form4.Score1_2 Then
            c2.Visible = True
            PictureBox1.Image = My.Resources.winner2
        End If
        Timer1.Interval = 2000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer2.Interval = 16
        Timer2.Start()
        PictureBox1.Visible = False
        c1.Visible = False
        c2.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Top -= 10
        If PictureBox2.Top < 300 Then
            Timer2.Stop()
            Timer3.Interval = 1300
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        Select Case Counter
            Case 1
                PictureBox5.Image = My.Resources.conv12
                PictureBox2.Image = My.Resources.tenshi3
            Case 2
                PictureBox5.Image = My.Resources.conv13
                PictureBox2.Image = My.Resources.tenshi2
            Case 3
                PictureBox5.Image = My.Resources.conv14
                PictureBox2.Image = My.Resources.tenshi3
            Case 4
                PictureBox5.Image = My.Resources.conv15
                PictureBox2.Image = My.Resources.tenshi1
            Case 5
                PictureBox5.Image = My.Resources.conv16
                PictureBox2.Image = My.Resources.tenshi5
            Case 6
                PictureBox5.Image = My.Resources.conv17_2
                PictureBox2.Image = My.Resources.tenshi2
            Case 7
                Me.Hide()
                Timer3.Stop()
        End Select
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Counter += 1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
    End Sub
End Class