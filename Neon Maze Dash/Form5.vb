Public Class Form5
    Dim WithEvents Timer1 As New Timer
    Dim WithEvents Timer2 As New Timer
    Public Counter As Integer = 0
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 16
        Timer1.Start()
        PictureBox1.Top = 1300
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label1.Text = $"x = {PictureBox1.Left} {vbNewLine} y = {PictureBox1.Top}"
        PictureBox1.Top -= 10
        If PictureBox1.Top < 300 Then
            Timer1.Stop()
            Timer2.Interval = 1300
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        Timer2.Stop()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Counter += 1
        Select Case Counter
            Case 1
                PictureBox2.Image = My.Resources.conv2
            Case 2
                PictureBox2.Image = My.Resources.conv3
                PictureBox1.Image = My.Resources.tenshi2
            Case 3
                PictureBox2.Image = My.Resources.conv4
                PictureBox6.Visible = True
                PictureBox7.Visible = True
                PictureBox1.Image = My.Resources.tenshi1
            Case 4
                PictureBox2.Image = My.Resources.conv5
                PictureBox5.Visible = True
                PictureBox8.Visible = True
                PictureBox1.Image = My.Resources.tenshi1
            Case 5
                PictureBox2.Image = My.Resources.conv6
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox1.Image = My.Resources.tenshi2
            Case 6
                PictureBox2.Image = My.Resources.conv7
                PictureBox1.Image = My.Resources.tenshi1
            Case 7
                PictureBox2.Image = My.Resources.conv8
                PictureBox1.Image = My.Resources.tenshi4
            Case 8
                PictureBox2.Image = My.Resources.conv9
                PictureBox1.Image = My.Resources.tenshi3
            Case 9
                PictureBox2.Image = My.Resources.conv10
                PictureBox1.Image = My.Resources.tenshi1
            Case 10
                Me.Hide()
                Form2.Show()
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class