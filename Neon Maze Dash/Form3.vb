Public Class Form3
    Dim WithEvents Timer1 As New Timer
    Dim WithEvents TimerD As New Timer
    Dim WithEvents TimerW As New Timer
    Dim WithEvents TimerA As New Timer
    Dim WithEvents TimerS As New Timer
    Dim WithEvents TimerRt As New Timer
    Dim WithEvents TimerUp As New Timer
    Dim WithEvents TimerLt As New Timer
    Dim WithEvents TimerDn As New Timer
    Public Score1_1 As Integer = 0
    Public Score2_1 As Integer = 0

    Public Sub moveW(e As KeyEventArgs)
        If e.KeyCode = Keys.W Then
            TimerW.Interval = 16
            TimerW.Start()
        End If
    End Sub
    Public Sub moveS(e As KeyEventArgs)
        If e.KeyCode = Keys.S Then
            TimerS.Interval = 16
            TimerS.Start()
        End If
    End Sub
    Public Sub moveD(e As KeyEventArgs)
        If e.KeyCode = Keys.D Then
            TimerD.Interval = 16
            TimerD.Start()
        End If
    End Sub
    Public Sub moveA(e As KeyEventArgs)
        If e.KeyCode = Keys.A Then
            TimerA.Interval = 16
            TimerA.Start()
        End If
    End Sub
    Public Sub moveUp(e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            TimerUp.Interval = 16
            TimerUp.Start()
        End If
    End Sub
    Public Sub moveDn(e As KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            TimerDn.Interval = 16
            TimerDn.Start()
        End If
    End Sub
    Public Sub moveRt(e As KeyEventArgs)
        If e.KeyCode = Keys.Right Then
            TimerRt.Interval = 16
            TimerRt.Start()
        End If
    End Sub
    Public Sub moveLt(e As KeyEventArgs)
        If e.KeyCode = Keys.Left Then
            TimerLt.Interval = 16
            TimerLt.Start()
        End If
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.T
                c1.Top -= 25
            Case Keys.F
                c1.Left -= 25
            Case Keys.H
                c1.Left += 25
            Case Keys.G
                c1.Top += 25
            Case Keys.I
                c1.Top -= 1
            Case Keys.J
                c1.Left -= 1
            Case Keys.L
                c1.Left += 1
            Case Keys.K
                c1.Top += 1
        End Select

        If c2.Left = 261 AndAlso c2.Top = 357 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 332 AndAlso c2.Top = 332 Then
            moveUp(e)
            moveLt(e)
            moveDn(e)
        End If
        If c2.Left = 286 AndAlso c2.Top = 357 Then
            moveLt(e)
            moveUp(e)
        End If
        If c2.Left = 214 AndAlso c2.Top = 357 Then
            moveUp(e)
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 214 AndAlso c2.Top = 332 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 214 AndAlso c2.Top = 475 Then
            moveUp(e)
        End If

        If c2.Left = 452 AndAlso c2.Top = 309 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 404 AndAlso c2.Top = 309 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 286 AndAlso c2.Top = 309 Then
            moveDn(e)
            moveRt(e)
            moveLt(e)
        End If
        If c2.Left = 404 AndAlso c2.Top = 357 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 332 AndAlso c2.Top = 357 Then
            moveRt(e)
            moveUp(e)
        End If
        If c2.Left = 332 AndAlso c2.Top = 309 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 261 AndAlso c2.Top = 309 Then
            moveDn(e)
            moveRt(e)
        End If

        If c2.Left = 452 AndAlso c2.Top = 356 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 427 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 538 AndAlso c2.Top = 427 Then
            c2.Left = 404
            c2.Top = 22
        End If
        If c2.Left = 618 AndAlso c2.Top = 427 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 618 AndAlso c2.Top = 332 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 523 AndAlso c2.Top = 332 Then
            moveRt(e)
        End If
        If c2.Left = 452 AndAlso c2.Top = 356 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 427 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 538 AndAlso c2.Top = 427 Then
            c2.Left = 404
            c2.Top = 22
        End If
        If c2.Left = 618 AndAlso c2.Top = 427 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 618 AndAlso c2.Top = 332 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 523 AndAlso c2.Top = 332 Then
            moveRt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 285 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 332 Then
            moveRt(e)
            moveLt(e)
        End If
        If c2.Left = 524 AndAlso c2.Top = 285 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 524 AndAlso c2.Top = 256 Then
            moveRt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 356 Then
            moveLt(e)
            moveUp(e)
            moveDn(e)
        End If
        If c2.Left = 452 AndAlso c2.Top = 353 Then
            moveRt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 332 Then
            moveDn(e)
        End If
        If c2.Left = 524 AndAlso c2.Top = 332 Then
            moveRt(e)
            moveUp(e)
            moveDn(e)
        End If
        If c2.Left = 524 AndAlso c2.Top = 356 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 618 AndAlso c2.Top = 332 Then
            moveLt(e)
        End If
        If c2.Left = 404 AndAlso c2.Top = 93 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 404 AndAlso c2.Top = 22 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 498 AndAlso c2.Top = 93 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 498 AndAlso c2.Top = 22 Then
            moveLt(e)
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 641 AndAlso c2.Top = 22 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 641 AndAlso c2.Top = 118 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 619 AndAlso c2.Top = 118 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 619 AndAlso c2.Top = 213 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 213 Then
            moveRt(e)
            moveUp(e)
            moveDn(e)
        End If
        If c2.Left = 547 AndAlso c2.Top = 285 Then
            moveUp(e)
            moveLt(e)
        End If
        If c1.Left = 261 AndAlso c1.Top = 357 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 332 AndAlso c1.Top = 332 Then
            moveW(e)
            moveA(e)
            moveS(e)
        End If
        If c1.Left = 286 AndAlso c1.Top = 357 Then
            moveA(e)
            moveW(e)
        End If
        If c1.Left = 214 AndAlso c1.Top = 357 Then
            moveW(e)
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 214 AndAlso c1.Top = 332 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 214 AndAlso c1.Top = 475 Then
            moveW(e)
        End If

        If c1.Left = 452 AndAlso c1.Top = 309 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 404 AndAlso c1.Top = 309 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 286 AndAlso c1.Top = 309 Then
            moveS(e)
            moveD(e)
            moveA(e)
        End If
        If c1.Left = 404 AndAlso c1.Top = 357 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 332 AndAlso c1.Top = 357 Then
            moveD(e)
            moveW(e)
        End If
        If c1.Left = 332 AndAlso c1.Top = 309 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 261 AndAlso c1.Top = 309 Then
            moveS(e)
            moveD(e)
        End If

        If c1.Left = 452 AndAlso c1.Top = 356 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 427 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 538 AndAlso c1.Top = 427 Then
            c1.Left = 404
            c1.Top = 22
        End If
        If c1.Left = 618 AndAlso c1.Top = 427 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 618 AndAlso c1.Top = 332 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 523 AndAlso c1.Top = 332 Then
            moveD(e)
        End If
        If c1.Left = 452 AndAlso c1.Top = 356 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 427 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 538 AndAlso c1.Top = 427 Then
            c1.Left = 404
            c1.Top = 22
        End If
        If c1.Left = 618 AndAlso c1.Top = 427 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 618 AndAlso c1.Top = 332 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 523 AndAlso c1.Top = 332 Then
            moveD(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 285 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 332 Then
            moveD(e)
            moveA(e)
        End If
        If c1.Left = 524 AndAlso c1.Top = 285 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 524 AndAlso c1.Top = 256 Then
            moveD(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 356 Then
            moveA(e)
            moveW(e)
            moveS(e)
        End If
        If c1.Left = 452 AndAlso c1.Top = 353 Then
            moveD(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 332 Then
            moveS(e)
        End If
        If c1.Left = 524 AndAlso c1.Top = 332 Then
            moveD(e)
            moveW(e)
            moveS(e)
        End If
        If c1.Left = 524 AndAlso c1.Top = 356 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 618 AndAlso c1.Top = 332 Then
            moveA(e)
        End If
        If c1.Left = 404 AndAlso c1.Top = 93 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 404 AndAlso c1.Top = 22 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 498 AndAlso c1.Top = 93 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 498 AndAlso c1.Top = 22 Then
            moveA(e)
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 641 AndAlso c1.Top = 22 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 641 AndAlso c1.Top = 118 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 619 AndAlso c1.Top = 118 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 619 AndAlso c1.Top = 213 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 213 Then
            moveD(e)
            moveW(e)
            moveS(e)
        End If
        If c1.Left = 547 AndAlso c1.Top = 285 Then
            moveW(e)
            moveA(e)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label1.Text = $"x = {c1.Left} {vbNewLine} y = {c1.Top}"
        If Score1_1 = 1 Then
            PictureBox7.Image = My.Resources.p1_1
        End If
        If Score2_1 = 1 Then
            PictureBox8.Image = My.Resources.p2_1
        End If
        Timer1.Stop()
    End Sub

    Private Sub TimerW_Tick(sender As Object, e As EventArgs) Handles TimerW.Tick
        c1.Top -= 25
        If (c1.Left = 286) And (c1.Top > 268 And c1.Top < 309) Then
            c1.Left = 286
            c1.Top = 309
            TimerW.Stop()
        End If
        If (c1.Left = 452) And (c1.Top > 268 And c1.Top < 309) Then
            c1.Left = 452
            c1.Top = 309
            TimerW.Stop()
        End If
        If (c1.Left = 404) And (c1.Top > 268 And c1.Top < 309) Then
            c1.Left = 404
            c1.Top = 309
            TimerW.Stop()
        End If
        If (c1.Left = 332) And (c1.Top > 269 And c1.Top < 309) Then
            c1.Left = 332
            c1.Top = 309
            TimerW.Stop()
        End If
        If (c1.Left = 214) And (c1.Top > 293 And c1.Top < 332) Then
            c1.Left = 214
            c1.Top = 332
            TimerW.Stop()
        End If
        If (c1.Left = 261) And (c1.Top > 269 And c1.Top < 309) Then
            c1.Left = 261
            c1.Top = 309
            TimerW.Stop()
        End If
        If (c1.Left = 618) And (c1.Top > 292 And c1.Top < 332) Then
            c1.Left = 618
            c1.Top = 332
            TimerW.Stop()
        End If
        If (c1.Left = 524) And (c1.Top > 245 And c1.Top < 285) Then c1.Left = 524 : c1.Top = 285 : TimerW.Stop()
        If (c1.Left = 547) And (c1.Top > 292 And c1.Top < 332) Then c1.Left = 547 : c1.Top = 332 : TimerW.Stop()
        If (c1.Left = 641) And (c1.Top > -18 And c1.Top < 22) Then
            c1.Left = 641
            c1.Top = 22
            TimerW.Stop()
        End If
        If (c1.Left = 524) And (c1.Top > 245 And c1.Top < 285) Then
            c1.Left = 641
            c1.Top = 285
            TimerW.Stop()
        End If
        If (c1.Left = 619) And (c1.Top > 88 And c1.Top < 118) Then
            c1.Left = 619
            c1.Top = 118
            TimerW.Stop()
        End If
        If (c1.Left = 498) And (c1.Top > -18 And c1.Top < 22) Then
            c1.Left = 498
            c1.Top = 22
            TimerW.Stop()
        End If
        If (c1.Left = 404) And (c1.Top > -18 And c1.Top < 22) Then
            c1.Left = 404
            c1.Top = 22
            TimerW.Stop()
        End If
        ' 547 175 (SPIKY PART - Reset Position to 404, 22)
        If (c1.Left = 547) And (c1.Top > 135 And c1.Top < 175) Then
            c1.Left = 404 ' Reset to starting position
            c1.Top = 22
            TimerW.Stop()
        End If

    End Sub
    Private Sub TimerS_Tick(sender As Object, e As EventArgs) Handles TimerS.Tick
        c1.Top += 25
        If (c1.Left = 286) And (c1.Top > 357 And c1.Top < 397) Then
            c1.Left = 286
            c1.Top = 357
            TimerS.Stop()
        End If
        If (c1.Left = 261) And (c1.Top > 357 And c1.Top < 397) Then
            c1.Left = 261
            c1.Top = 357
            TimerS.Stop()
        End If
        If (c1.Left = 214) And (c1.Top > 475 And c1.Top < 515) Then
            c1.Left = 214
            c1.Top = 475
            TimerS.Stop()
            Form4.Score1_2 += 1
            Me.Hide()
            Form4.Show()
        End If
        If (c1.Left = 404) And (c1.Top > 357 And c1.Top < 397) Then
            c1.Left = 404
            c1.Top = 357
            TimerS.Stop()
        End If
        If (c1.Left = 332) And (c1.Top > 357 And c1.Top < 397) Then
            c1.Left = 332
            c1.Top = 357
            TimerS.Stop()
        End If
        If (c1.Left = 452) And (c1.Top > 356 And c1.Top < 396) Then
            c1.Left = 452
            c1.Top = 356
            TimerS.Stop()
        End If
        If (c1.Left = 547) And (c1.Top > 427 And c1.Top < 467) Then
            c1.Left = 547
            c1.Top = 427
            TimerS.Stop()
        End If
        If (c1.Left = 618) And (c1.Top > 427 And c1.Top < 467) Then
            c1.Left = 618
            c1.Top = 427
            TimerS.Stop()
        End If
        If (c1.Left = 547) And (c1.Top > 285 And c1.Top < 325) Then c1.Left = 547 : c1.Top = 285 : TimerS.Stop()
        If (c1.Left = 404) And (c1.Top > 93 And c1.Top < 133) Then
            c1.Left = 404
            c1.Top = 93
            TimerS.Stop()
        End If
        If (c1.Left = 547) And (c1.Top > 285 And c1.Top < 325) Then c1.Left = 547 : c1.Top = 285 : TimerS.Stop()
        If (c1.Left = 524) And (c1.Top > 356 And c1.Top < 369) Then
            c1.Left = 524
            c1.Top = 356
            TimerS.Stop()
        End If
        If (c1.Left = 498) And (c1.Top > 93 And c1.Top < 133) Then
            c1.Left = 498
            c1.Top = 93
            TimerS.Stop()
        End If
        If (c1.Left = 641) And (c1.Top > 118 And c1.Top < 158) Then
            c1.Left = 641
            c1.Top = 118
            TimerS.Stop()
        End If
        ' 619 213
        If (c1.Left = 619) And (c1.Top > 213 And c1.Top < 253) Then
            c1.Left = 619
            c1.Top = 213
            TimerS.Stop()
        End If

        ' 547 285
        If (c1.Left = 547) And (c1.Top > 285 And c1.Top < 325) Then
            c1.Left = 547
            c1.Top = 285
            TimerS.Stop()
        End If

    End Sub
    Private Sub TimerA_Tick(sender As Object, e As EventArgs) Handles TimerA.Tick
        c1.Left -= 25
        If (c1.Left < 214 And c1.Left > 174) And (c1.Top = 357) Then
            c1.Left = 214
            c1.Top = 357
            TimerA.Stop()
        End If
        If (c1.Left < 404 And c1.Left > 364) And (c1.Top = 309) Then
            c1.Left = 404
            c1.Top = 309
            TimerA.Stop()
        End If
        If (c1.Left < 332 And c1.Left > 293) And (c1.Top = 357) Then
            c1.Left = 332
            c1.Top = 357
            TimerA.Stop()
        End If
        If (c1.Left < 261 And c1.Left > 221) And (c1.Top = 309) Then
            c1.Left = 261
            c1.Top = 309
            TimerA.Stop()
        End If
        If (c1.Left < 452 And c1.Left > 412) And (c1.Top = 356) Then
            c1.Left = 452
            c1.Top = 356
            TimerA.Stop()
        End If
        If (c1.Left < 214) Then
            c1.Left = 214
            TimerA.Stop()
        End If
        If (c1.Left < 538 And c1.Left > 498) And (c1.Top = 427) Then
            c1.Left = 404
            c1.Top = 22
            TimerA.Stop()
        End If
        If (c1.Left < 523 And c1.Left > 483) And (c1.Top = 332) Then
            c1.Left = 523
            c1.Top = 332
            TimerA.Stop()
        End If
        If (c1.Left < 524 And c1.Left > 484) And (c1.Top = 285) Then c1.Left = 524 : c1.Top = 285 : TimerA.Stop()
        If (c1.Left < 452 And c1.Left > 412) And (c1.Top = 353) Then c1.Left = 452 : c1.Top = 353 : TimerA.Stop()
        If (c1.Left < 524 And c1.Left > 484) And (c1.Top = 332) Then c1.Left = 524 : c1.Top = 332 : TimerA.Stop()
        If (c1.Left < 404 And c1.Left > 364) And (c1.Top = 93) Then
            c1.Left = 404
            c1.Top = 93
            TimerA.Stop()
        End If
        If (c1.Left < 404 And c1.Left > 364) And (c1.Top = 22) Then
            c1.Left = 404
            c1.Top = 22
            TimerA.Stop()
        End If
        If (c1.Left < 619 And c1.Left > 589) And (c1.Top = 118) Then
            c1.Left = 619
            c1.Top = 118
            TimerA.Stop()
        End If
        ' 547 213
        If (c1.Left < 547 And c1.Left > 507) And (c1.Top = 213) Then
            c1.Left = 547
            c1.Top = 213
            TimerA.Stop()
        End If
        If (c1.Left < 452 And c1.Left > 412) And (c1.Top = 356) Then
            c1.Left = 452
            c1.Top = 356
            TimerA.Stop()
        End If
        If (c1.Left < 538 And c1.Left > 498) And (c1.Top = 427) Then
            c1.Left = 404
            c1.Top = 22
            TimerA.Stop()
        End If
        If (c1.Left < 523 And c1.Left > 483) And (c1.Top = 332) Then
            c1.Left = 523
            c1.Top = 332
            TimerA.Stop()
        End If
    End Sub
    Private Sub TimerD_Tick(sender As Object, e As EventArgs) Handles TimerD.Tick
        c1.Left += 25
        If (c1.Left < 326 And c1.Left > 286) And (c1.Top = 357) Then
            c1.Left = 286
            c1.Top = 357
            TimerD.Stop()
        End If
        If (c1.Left < 492 And c1.Left > 452) And (c1.Top = 309) Then
            c1.Left = 452
            c1.Top = 309
            TimerD.Stop()
        End If
        If (c1.Left < 372 And c1.Left > 332) And (c1.Top = 332) Then
            c1.Left = 332
            c1.Top = 332
            TimerD.Stop()
        End If
        If (c1.Left < 444 And c1.Left > 404) And (c1.Top = 357) Then
            c1.Left = 404
            c1.Top = 357
            TimerD.Stop()
        End If
        If (c1.Left < 373 And c1.Left > 332) And (c1.Top = 309) Then
            c1.Left = 332
            c1.Top = 309
            TimerD.Stop()
        End If
        If (c1.Left < 658 And c1.Left > 618) And (c1.Top = 427) Then
            c1.Left = 618
            c1.Top = 427
            TimerD.Stop()
        End If
        If (c1.Left < 658 And c1.Left > 618) And (c1.Top = 332) Then
            c1.Left = 618
            c1.Top = 332
            TimerD.Stop()
        End If
        If (c1.Left < 587 And c1.Left > 547) And (c1.Top = 285) Then c1.Left = 547 : c1.Top = 285 : TimerD.Stop()
        If (c1.Left < 587 And c1.Left > 547) And (c1.Top = 356) Then c1.Left = 547 : c1.Top = 356 : TimerD.Stop()
        If (c1.Left < 658 And c1.Left > 618) And (c1.Top = 332) Then c1.Left = 618 : c1.Top = 332 : TimerD.Stop()
        If (c1.Left < 659 And c1.Left > 619) And (c1.Top = 213) Then
            c1.Left = 619
            c1.Top = 213
            TimerD.Stop()
        End If

        ' 547 285
        If (c1.Left < 587 And c1.Left > 547) And (c1.Top = 285) Then
            c1.Left = 547
            c1.Top = 285
            TimerD.Stop()
        End If

        If (c1.Left < 538 And c1.Left > 498) And (c1.Top = 93) Then
            c1.Left = 498
            c1.Top = 93
            TimerD.Stop()
        End If
        If (c1.Left < 681 And c1.Left > 641) And (c1.Top = 22) Then
            c1.Left = 641
            c1.Top = 22
            TimerD.Stop()
        End If
        If (c1.Left < 681 And c1.Left > 641) And (c1.Top = 118) Then
            c1.Left = 641
            c1.Top = 118
            TimerD.Stop()
        End If
    End Sub

    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        c2.Top -= 25
        If (c2.Left = 286) And (c2.Top > 268 And c2.Top < 309) Then
            c2.Left = 286
            c2.Top = 309
            TimerUp.Stop()
        End If
        If (c2.Left = 452) And (c2.Top > 268 And c2.Top < 309) Then
            c2.Left = 452
            c2.Top = 309
            TimerUp.Stop()
        End If
        If (c2.Left = 404) And (c2.Top > 268 And c2.Top < 309) Then
            c2.Left = 404
            c2.Top = 309
            TimerUp.Stop()
        End If
        If (c2.Left = 332) And (c2.Top > 269 And c2.Top < 309) Then
            c2.Left = 332
            c2.Top = 309
            TimerUp.Stop()
        End If
        If (c2.Left = 214) And (c2.Top > 293 And c2.Top < 332) Then
            c2.Left = 214
            c2.Top = 332
            TimerUp.Stop()
        End If
        If (c2.Left = 261) And (c2.Top > 269 And c2.Top < 309) Then
            c2.Left = 261
            c2.Top = 309
            TimerUp.Stop()
        End If
        If (c2.Left = 618) And (c2.Top > 292 And c2.Top < 332) Then
            c2.Left = 618
            c2.Top = 332
            TimerUp.Stop()
        End If
        If (c2.Left = 524) And (c2.Top > 245 And c2.Top < 285) Then c2.Left = 524 : c2.Top = 285 : TimerUp.Stop()
        If (c2.Left = 547) And (c2.Top > 292 And c2.Top < 332) Then c2.Left = 547 : c2.Top = 332 : TimerUp.Stop()
        If (c2.Left = 641) And (c2.Top > -18 And c2.Top < 22) Then
            c2.Left = 641
            c2.Top = 22
            TimerUp.Stop()
        End If
        If (c2.Left = 524) And (c2.Top > 245 And c2.Top < 285) Then
            c2.Left = 641
            c2.Top = 285
            TimerUp.Stop()
        End If
        If (c2.Left = 619) And (c2.Top > 88 And c2.Top < 118) Then
            c2.Left = 619
            c2.Top = 118
            TimerUp.Stop()
        End If
        If (c2.Left = 498) And (c2.Top > -18 And c2.Top < 22) Then
            c2.Left = 498
            c2.Top = 22
            TimerUp.Stop()
        End If
        If (c2.Left = 404) And (c2.Top > -18 And c2.Top < 22) Then
            c2.Left = 404
            c2.Top = 22
            TimerUp.Stop()
        End If
        ' 547 175 (SPIKY PART - Reset Position to 404, 22)
        If (c2.Left = 547) And (c2.Top > 135 And c2.Top < 175) Then
            c2.Left = 404 ' Reset to starting position
            c2.Top = 22
            TimerUp.Stop()
        End If

    End Sub
    Private Sub TimerDn_Tick(sender As Object, e As EventArgs) Handles TimerDn.Tick
        c2.Top += 25
        If (c2.Left = 286) And (c2.Top > 357 And c2.Top < 397) Then
            c2.Left = 286
            c2.Top = 357
            TimerDn.Stop()
        End If
        If (c2.Left = 261) And (c2.Top > 357 And c2.Top < 397) Then
            c2.Left = 261
            c2.Top = 357
            TimerDn.Stop()
        End If
        If (c2.Left = 214) And (c2.Top > 475 And c2.Top < 515) Then
            c2.Left = 214
            c2.Top = 475
            TimerDn.Stop()
            Form4.Score2_2 += 1
            Me.Hide()
            Form4.Show()
        End If
        If (c2.Left = 404) And (c2.Top > 357 And c2.Top < 397) Then
            c2.Left = 404
            c2.Top = 357
            TimerDn.Stop()
        End If
        If (c2.Left = 332) And (c2.Top > 357 And c2.Top < 397) Then
            c2.Left = 332
            c2.Top = 357
            TimerDn.Stop()
        End If
        If (c2.Left = 452) And (c2.Top > 356 And c2.Top < 396) Then
            c2.Left = 452
            c2.Top = 356
            TimerDn.Stop()
        End If
        If (c2.Left = 547) And (c2.Top > 427 And c2.Top < 467) Then
            c2.Left = 547
            c2.Top = 427
            TimerDn.Stop()
        End If
        If (c2.Left = 618) And (c2.Top > 427 And c2.Top < 467) Then
            c2.Left = 618
            c2.Top = 427
            TimerDn.Stop()
        End If
        If (c2.Left = 547) And (c2.Top > 285 And c2.Top < 325) Then c2.Left = 547 : c2.Top = 285 : TimerDn.Stop()
        If (c2.Left = 404) And (c2.Top > 93 And c2.Top < 133) Then
            c2.Left = 404
            c2.Top = 93
            TimerDn.Stop()
        End If
        If (c2.Left = 547) And (c2.Top > 285 And c2.Top < 325) Then c2.Left = 547 : c2.Top = 285 : TimerDn.Stop()
        If (c2.Left = 524) And (c2.Top > 356 And c2.Top < 369) Then
            c2.Left = 524
            c2.Top = 356
            TimerDn.Stop()
        End If
        If (c2.Left = 498) And (c2.Top > 93 And c2.Top < 133) Then
            c2.Left = 498
            c2.Top = 93
            TimerDn.Stop()
        End If
        If (c2.Left = 641) And (c2.Top > 118 And c2.Top < 158) Then
            c2.Left = 641
            c2.Top = 118
            TimerDn.Stop()
        End If
        ' 619 213
        If (c2.Left = 619) And (c2.Top > 213 And c2.Top < 253) Then
            c2.Left = 619
            c2.Top = 213
            TimerDn.Stop()
        End If

        ' 547 285
        If (c2.Left = 547) And (c2.Top > 285 And c2.Top < 325) Then
            c2.Left = 547
            c2.Top = 285
            TimerDn.Stop()
        End If

    End Sub
    Private Sub TimerLt_Tick(sender As Object, e As EventArgs) Handles TimerLt.Tick
        c2.Left -= 25
        If (c2.Left < 214 And c2.Left > 174) And (c2.Top = 357) Then
            c2.Left = 214
            c2.Top = 357
            TimerLt.Stop()
        End If
        If (c2.Left < 404 And c2.Left > 364) And (c2.Top = 309) Then
            c2.Left = 404
            c2.Top = 309
            TimerLt.Stop()
        End If
        If (c2.Left < 332 And c2.Left > 293) And (c2.Top = 357) Then
            c2.Left = 332
            c2.Top = 357
            TimerLt.Stop()
        End If
        If (c2.Left < 261 And c2.Left > 221) And (c2.Top = 309) Then
            c2.Left = 261
            c2.Top = 309
            TimerLt.Stop()
        End If
        If (c2.Left < 452 And c2.Left > 412) And (c2.Top = 356) Then
            c2.Left = 452
            c2.Top = 356
            TimerLt.Stop()
        End If
        If (c2.Left < 214) Then
            c2.Left = 214
            TimerLt.Stop()
        End If
        If (c2.Left < 538 And c2.Left > 498) And (c2.Top = 427) Then
            c2.Left = 404
            c2.Top = 22
            TimerLt.Stop()
        End If
        If (c2.Left < 523 And c2.Left > 483) And (c2.Top = 332) Then
            c2.Left = 523
            c2.Top = 332
            TimerLt.Stop()
        End If
        If (c2.Left < 524 And c2.Left > 484) And (c2.Top = 285) Then c2.Left = 524 : c2.Top = 285 : TimerLt.Stop()
        If (c2.Left < 452 And c2.Left > 412) And (c2.Top = 353) Then c2.Left = 452 : c2.Top = 353 : TimerLt.Stop()
        If (c2.Left < 524 And c2.Left > 484) And (c2.Top = 332) Then c2.Left = 524 : c2.Top = 332 : TimerLt.Stop()
        If (c2.Left < 404 And c2.Left > 364) And (c2.Top = 93) Then
            c2.Left = 404
            c2.Top = 93
            TimerLt.Stop()
        End If
        If (c2.Left < 404 And c2.Left > 364) And (c2.Top = 22) Then
            c2.Left = 404
            c2.Top = 22
            TimerLt.Stop()
        End If
        If (c2.Left < 619 And c2.Left > 589) And (c2.Top = 118) Then
            c2.Left = 619
            c2.Top = 118
            TimerLt.Stop()
        End If
        ' 547 213
        If (c2.Left < 547 And c2.Left > 507) And (c2.Top = 213) Then
            c2.Left = 547
            c2.Top = 213
            TimerLt.Stop()
        End If
        If (c2.Left < 452 And c2.Left > 412) And (c2.Top = 356) Then
            c2.Left = 452
            c2.Top = 356
            TimerLt.Stop()
        End If
        If (c2.Left < 538 And c2.Left > 498) And (c2.Top = 427) Then
            c2.Left = 404
            c2.Top = 22
            TimerLt.Stop()
        End If
        If (c2.Left < 523 And c2.Left > 483) And (c2.Top = 332) Then
            c2.Left = 523
            c2.Top = 332
            TimerLt.Stop()
        End If
    End Sub
    Private Sub TimerRt_Tick(sender As Object, e As EventArgs) Handles TimerRt.Tick
        c2.Left += 25
        If (c2.Left < 326 And c2.Left > 286) And (c2.Top = 357) Then
            c2.Left = 286
            c2.Top = 357
            TimerRt.Stop()
        End If
        If (c2.Left < 492 And c2.Left > 452) And (c2.Top = 309) Then
            c2.Left = 452
            c2.Top = 309
            TimerRt.Stop()
        End If
        If (c2.Left < 372 And c2.Left > 332) And (c2.Top = 332) Then
            c2.Left = 332
            c2.Top = 332
            TimerRt.Stop()
        End If
        If (c2.Left < 444 And c2.Left > 404) And (c2.Top = 357) Then
            c2.Left = 404
            c2.Top = 357
            TimerRt.Stop()
        End If
        If (c2.Left < 373 And c2.Left > 332) And (c2.Top = 309) Then
            c2.Left = 332
            c2.Top = 309
            TimerRt.Stop()
        End If
        If (c2.Left < 658 And c2.Left > 618) And (c2.Top = 427) Then
            c2.Left = 618
            c2.Top = 427
            TimerRt.Stop()
        End If
        If (c2.Left < 658 And c2.Left > 618) And (c2.Top = 332) Then
            c2.Left = 618
            c2.Top = 332
            TimerRt.Stop()
        End If
        If (c2.Left < 587 And c2.Left > 547) And (c2.Top = 285) Then c2.Left = 547 : c2.Top = 285 : TimerRt.Stop()
        If (c2.Left < 587 And c2.Left > 547) And (c2.Top = 356) Then c2.Left = 547 : c2.Top = 356 : TimerRt.Stop()
        If (c2.Left < 658 And c2.Left > 618) And (c2.Top = 332) Then c2.Left = 618 : c2.Top = 332 : TimerRt.Stop()
        If (c2.Left < 659 And c2.Left > 619) And (c2.Top = 213) Then
            c2.Left = 619
            c2.Top = 213
            TimerRt.Stop()
        End If

        ' 547 285
        If (c2.Left < 587 And c2.Left > 547) And (c2.Top = 285) Then
            c2.Left = 547
            c2.Top = 285
            TimerRt.Stop()
        End If

        If (c2.Left < 538 And c2.Left > 498) And (c2.Top = 93) Then
            c2.Left = 498
            c2.Top = 93
            TimerRt.Stop()
        End If
        If (c2.Left < 681 And c2.Left > 641) And (c2.Top = 22) Then
            c2.Left = 641
            c2.Top = 22
            TimerRt.Stop()
        End If
        If (c2.Left < 681 And c2.Left > 641) And (c2.Top = 118) Then
            c2.Left = 641
            c2.Top = 118
            TimerRt.Stop()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Score1 = Score1_1
        Form2.Score2 = Score2_1
        Score1_1 = Form2.Score1
        c1.Location = New Point(404, 22)
        Timer1.Interval = 16
        Timer1.Start()
        c2.Location = New Point(404, 22)
    End Sub
End Class