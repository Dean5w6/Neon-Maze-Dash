Public Class Form2
    Dim WithEvents Timer1 As New Timer
    Dim WithEvents TimerD As New Timer
    Dim WithEvents TimerW As New Timer
    Dim WithEvents TimerA As New Timer
    Dim WithEvents TimerS As New Timer
    Dim WithEvents TimerRt As New Timer
    Dim WithEvents TimerUp As New Timer
    Dim WithEvents TimerLt As New Timer
    Dim WithEvents TimerDn As New Timer
    Public Score1 As Integer = 0
    Public Score2 As Integer = 0

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

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If c1.Left = 362 AndAlso c1.Top = 457 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 307 AndAlso c1.Top = 457 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 362 AndAlso c1.Top = 333 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 413 AndAlso c1.Top = 333 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 413 AndAlso c1.Top = 372 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 482 AndAlso c1.Top = 372 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 482 AndAlso c1.Top = 248 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 411 AndAlso c1.Top = 248 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 411 AndAlso c1.Top = 301 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 447 AndAlso c1.Top = 301 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 447 AndAlso c1.Top = 161 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 412 AndAlso c1.Top = 161 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 412 AndAlso c1.Top = 110 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 465 AndAlso c1.Top = 110 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 465 AndAlso c1.Top = 25 Then
            moveS(e)
        End If
        If c1.Left = 307 AndAlso c1.Top = 403 Then
            moveD(e)
            moveS(e)
        End If
        If c1.Left = 307 AndAlso c1.Top = 457 Then
            moveD(e)
            moveW(e)
        End If
        If c1.Left = 444 AndAlso c1.Top = 423 Then
            moveW(e)
            moveD(e)
            moveS(e)
        End If
        If c1.Left = 444 AndAlso c1.Top = 403 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 550 AndAlso c1.Top = 454 Then
            moveS(e)
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 462 AndAlso c1.Top = 454 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 550 AndAlso c1.Top = 423 Then
            moveS(e)
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 497 AndAlso c1.Top = 423 Then
            moveD(e)
            moveA(e)
            moveW(e)
        End If
        If c1.Left = 497 AndAlso c1.Top = 403 Then
            moveS(e)
            moveD(e)
        End If

        If c1.Left = 550 AndAlso c1.Top = 403 Then
            moveS(e)
            moveA(e)
        End If

        If c1.Left = 462 AndAlso c1.Top = 491 Then
            moveW(e)
            moveD(e)
        End If

        If c1.Left = 550 AndAlso c1.Top = 491 Then
            moveA(e)
            moveW(e)
        End If

        If c1.Left = 550 AndAlso c1.Top = 391 Then
            moveW(e)
            moveA(e)
        End If

        If c2.Left = 362 AndAlso c2.Top = 457 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 307 AndAlso c2.Top = 457 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 362 AndAlso c2.Top = 333 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 413 AndAlso c2.Top = 333 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 413 AndAlso c2.Top = 372 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 482 AndAlso c2.Top = 372 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 482 AndAlso c2.Top = 248 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 411 AndAlso c2.Top = 248 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 411 AndAlso c2.Top = 301 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 447 AndAlso c2.Top = 301 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 447 AndAlso c2.Top = 161 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 412 AndAlso c2.Top = 161 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 412 AndAlso c2.Top = 110 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 465 AndAlso c2.Top = 110 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 465 AndAlso c2.Top = 25 Then
            moveDn(e)
        End If
        If c2.Left = 307 AndAlso c2.Top = 403 Then
            moveRt(e)
            moveDn(e)
        End If
        If c2.Left = 307 AndAlso c2.Top = 457 Then
            moveRt(e)
            moveUp(e)
        End If
        If c2.Left = 444 AndAlso c2.Top = 423 Then
            moveUp(e)
            moveRt(e)
            moveDn(e)
        End If
        If c2.Left = 444 AndAlso c2.Top = 403 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 550 AndAlso c2.Top = 454 Then
            moveDn(e)
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 462 AndAlso c2.Top = 454 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 550 AndAlso c2.Top = 423 Then
            moveDn(e)
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 497 AndAlso c2.Top = 423 Then
            moveRt(e)
            moveLt(e)
            moveUp(e)
        End If
        If c2.Left = 497 AndAlso c2.Top = 403 Then
            moveDn(e)
            moveRt(e)
        End If

        If c2.Left = 550 AndAlso c2.Top = 403 Then
            moveDn(e)
            moveLt(e)
        End If

        If c2.Left = 462 AndAlso c2.Top = 491 Then
            moveUp(e)
            moveRt(e)
        End If

        If c2.Left = 550 AndAlso c2.Top = 491 Then
            moveLt(e)
            moveUp(e)
        End If

        If c2.Left = 550 AndAlso c2.Top = 391 Then
            moveUp(e)
            moveLt(e)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1.Location = New Point(462, 491)
        Timer1.Interval = 16
        Timer1.Start()
        c2.Location = New Point(462, 491)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label1.Text = $"x = {c1.Left} {vbNewLine} y = {c1.Top}"
    End Sub

    Private Sub TimerW_Tick(sender As Object, e As EventArgs) Handles TimerW.Tick
        c1.Top -= 20
        If (c1.Left = 307) And (c1.Top > 443 And c1.Top < 403) Then
            c1.Left = 307
            c1.Top = 403
            TimerW.Stop()
        End If

        If (c1.Left = 362) And (c1.Top > 293 And c1.Top < 333) Then
            c1.Left = 362
            c1.Top = 333
            TimerW.Stop()
        End If
        If (c1.Left = 413) And (c1.Top > 293 And c1.Top < 333) Then
            c1.Left = 413
            c1.Top = 333
            TimerW.Stop()
        End If
        If (c1.Left = 482) And (c1.Top > 208 And c1.Top < 248) Then
            c1.Left = 482
            c1.Top = 248
            TimerW.Stop()
        End If
        If (c1.Left = 411) And (c1.Top > 208 And c1.Top < 248) Then
            c1.Left = 411
            c1.Top = 248
            TimerW.Stop()
        End If
        If (c1.Left = 447) And (c1.Top > 121 And c1.Top < 161) Then
            c1.Left = 447
            c1.Top = 161
            TimerW.Stop()
        End If
        If (c1.Left = 412) And (c1.Top > 70 And c1.Top < 110) Then
            c1.Left = 412
            c1.Top = 110
            TimerW.Stop()
        End If
        If (c1.Left = 465) And (c1.Top > -15 And c1.Top < 25) Then
            c1.Left = 465
            c1.Top = 25
            TimerW.Stop()
            Form3.Score1_1 += 1
            Form4.Score1_2 += 1
            Me.Hide()
            Form3.Show()
        End If
        If (c1.Left = 307) And (c1.Top > 363 And c1.Top < 403) Then
            c1.Left = 307
            c1.Top = 403
            TimerW.Stop()
        End If
        If (c1.Left = 362) And (c1.Top > 300 And c1.Top < 333) Then
            c1.Left = 307
            c1.Top = 403
            TimerW.Stop()
        End If
        If (c1.Left = 444) And (c1.Top > 363 And c1.Top < 403) Then
            c1.Left = 444
            c1.Top = 403
            TimerW.Stop()
        End If
        If c1.Left = 550 And c1.Top = 391 Then
            c1.Left = 550
            c1.Top = 403
            TimerW.Stop()
        End If
        If c1.Left = 550 And c1.Top = 394 Then
            c1.Left = 550
            c1.Top = 403
            TimerW.Stop()
        End If
        If c1.Left = 462 And c1.Top = 451 Then
            c1.Left = 462
            c1.Top = 454
            TimerW.Stop()
        End If
        If c1.Left = 497 And c1.Top = 403 Then
            TimerW.Stop()
        End If
        If c1.Left = 550 And c1.Top = 403 Then
            TimerW.Stop()
        End If
    End Sub

    Private Sub TimerD_Tick(sender As Object, e As EventArgs) Handles TimerD.Tick
        c1.Left += 20
        If (c1.Left < 453 And c1.Left > 413) And (c1.Top = 333) Then
            c1.Left = 413
            c1.Top = 333
            TimerD.Stop()
        End If
        If (c1.Left < 522 And c1.Left > 482) And (c1.Top = 248) Then
            c1.Left = 482
            c1.Top = 248
            TimerD.Stop()
        End If
        If (c1.Left < 487 And c1.Left > 447) And (c1.Top = 301) Then
            c1.Left = 447
            c1.Top = 301
            TimerD.Stop()
        End If
        If (c1.Left < 487 And c1.Left > 447) And (c1.Top = 161) Then
            c1.Left = 447
            c1.Top = 161
            TimerD.Stop()
        End If
        If (c1.Left < 505 And c1.Left > 465) And (c1.Top = 110) Then
            c1.Left = 465
            c1.Top = 110
            TimerD.Stop()
        End If
        If (c1.Left < 402 And c1.Left > 362) And (c1.Top = 457) Then
            c1.Left = 362
            c1.Top = 457
            TimerD.Stop()
        End If
        If (c1.Left < 522 And c1.Left > 482) And (c1.Top = 372) Then
            c1.Left = 482
            c1.Top = 372
            TimerD.Stop()
        End If
        If (c1.Left < 484 And c1.Left > 444) And (c1.Top = 403) Then
            c1.Left = 444
            c1.Top = 403
            TimerD.Stop()
        End If
        If (c1.Left < 402 And c1.Left > 362) And (c1.Top = 457) Then
            c1.Left = 362
            c1.Top = 457
            TimerD.Stop()
        End If
        If (c1.Left < 590 And c1.Left > 550) And (c1.Top = 423) Then
            c1.Left = 550
            c1.Top = 423
            TimerD.Stop()
        End If
        If c1.Left = 450 And c1.Top = 454 Then
            c1.Left = 462
            c1.Top = 454
            TimerD.Stop()
        End If
        If c1.Left = 562 And c1.Top = 491 Then
            c1.Left = 550
            c1.Top = 491
            TimerD.Stop()
        End If
        If c1.Left = 557 And c1.Top = 403 Then
            c1.Left = 550
            c1.Top = 403
            TimerD.Stop()
        End If
        If c1.Left = 557 And c1.Top = 423 Then
            c1.Left = 550
            c1.Top = 423
            TimerD.Stop()
        End If
        If c1.Left = 562 And c1.Top = 454 Then
            c1.Left = 550
            c1.Top = 454
            TimerD.Stop()
        End If
    End Sub

    Private Sub TimerS_Tick(sender As Object, e As EventArgs) Handles TimerS.Tick
        c1.Top += 20
        If (c1.Left = 362) And (c1.Top > 457 And c1.Top < 497) Then
            c1.Left = 362
            c1.Top = 457
            TimerS.Stop()
        End If
        If (c1.Left = 307) And (c1.Top > 457 And c1.Top < 497) Then
            c1.Left = 307
            c1.Top = 457
            TimerS.Stop()
        End If
        If (c1.Left = 413) And (c1.Top > 372 And c1.Top < 412) Then
            c1.Left = 413
            c1.Top = 372
            TimerS.Stop()
        End If
        If (c1.Left = 482) And (c1.Top > 372 And c1.Top < 412) Then
            c1.Left = 482
            c1.Top = 372
            TimerS.Stop()
        End If
        If (c1.Left = 411) And (c1.Top > 301 And c1.Top < 341) Then
            c1.Left = 411
            c1.Top = 301
            TimerS.Stop()
        End If
        If (c1.Left = 447) And (c1.Top > 301 And c1.Top < 341) Then
            c1.Left = 447
            c1.Top = 301
            TimerS.Stop()
        End If
        If (c1.Left = 412) And (c1.Top > 161 And c1.Top < 201) Then
            c1.Left = 412
            c1.Top = 161
            TimerS.Stop()
        End If
        If c1.Left = 307 And (c1.Top > 457 And c1.Top < 497) Then
            c1.Left = 307
            c1.Top = 457
            TimerS.Stop()
        End If
        If c1.Left = 444 And (c1.Top > 423 And c1.Top < 463) Then
            c1.Left = 444
            c1.Top = 423
            TimerS.Stop()
        End If
        If c1.Left = 550 And (c1.Top > 491 And c1.Top < 531) Then
            c1.Left = 550
            c1.Top = 491
            TimerS.Stop()
        End If
        If c1.Left = 550 And c1.Top = 503 Then
            c1.Left = 550
            c1.Top = 491
            TimerS.Stop()
        End If
        If c1.Left = 497 And c1.Top = 423 Then
            TimerS.Stop()
        End If
        If c1.Left = 462 And c1.Top = 494 Then
            c1.Left = 462
            c1.Top = 491
            TimerS.Stop()
        End If
        If c1.Left = 550 And c1.Top = 491 Then
            TimerS.Stop()
        End If
        If c1.Left = 462 And c1.Top = 454 Then
            TimerS.Stop()
        End If
    End Sub

    Private Sub TimerA_Tick(sender As Object, e As EventArgs) Handles TimerA.Tick
        c1.Left -= 20
        If (c1.Left < 307 And c1.Left > 266) And (c1.Top = 457) Then
            c1.Left = 307
            c1.Top = 457
            TimerA.Stop()
        End If
        If (c1.Left < 362 And c1.Left > 322) And (c1.Top = 333) Then
            c1.Left = 362
            c1.Top = 333
            TimerA.Stop()
        End If
        If (c1.Left < 411 And c1.Left > 371) And (c1.Top = 248) Then
            c1.Left = 411
            c1.Top = 248
            TimerA.Stop()
        End If
        If (c1.Left < 412 And c1.Left > 372) And (c1.Top = 161) Then
            c1.Left = 412
            c1.Top = 161
            TimerA.Stop()
        End If
        If (c1.Left < 412 And c1.Left > 372) And (c1.Top = 110) Then
            c1.Left = 412
            c1.Top = 110
            TimerA.Stop()
        End If
        If (c1.Left < 411 And c1.Left > 371) And (c1.Top = 301) Then
            c1.Left = 411
            c1.Top = 301
            TimerA.Stop()
        End If
        If (c1.Left < 413 And c1.Left > 373) And (c1.Top = 372) Then
            c1.Left = 413
            c1.Top = 372
            TimerA.Stop()
        End If
        If (c1.Left < 307 And c1.Left > 267) And (c1.Top = 403) Then
            c1.Left = 307
            c1.Top = 403
            TimerA.Stop()
        End If
        If c1.Left = 450 And c1.Top = 491 Then
            c1.Left = 462
            c1.Top = 491
            TimerA.Stop()
        End If
        If c1.Left = 490 And c1.Top = 403 Then
            c1.Left = 497
            c1.Top = 403
            TimerA.Stop()
        End If
        If (c1.Left < 444 And c1.Left > 404) And (c1.Top = 423) Then
            c1.Left = 444
            c1.Top = 423
            TimerA.Stop()
        End If
        If (c1.Left < 462 And c1.Left > 422) And (c1.Top = 454) Then
            c1.Left = 462
            c1.Top = 454
            TimerA.Stop()
        End If
    End Sub

    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        c2.Top -= 20
        If (c2.Left = 307) And (c2.Top > 443 And c2.Top < 403) Then
            c2.Left = 307
            c2.Top = 403
            TimerUp.Stop()
        End If
        If (c2.Left = 362) And (c2.Top > 293 And c2.Top < 333) Then
            c2.Left = 362
            c2.Top = 333
            TimerUp.Stop()
        End If
        If (c2.Left = 413) And (c2.Top > 293 And c2.Top < 333) Then
            c2.Left = 413
            c2.Top = 333
            TimerUp.Stop()
        End If
        If (c2.Left = 482) And (c2.Top > 208 And c2.Top < 248) Then
            c2.Left = 482
            c2.Top = 248
            TimerUp.Stop()
        End If
        If (c2.Left = 411) And (c2.Top > 208 And c2.Top < 248) Then
            c2.Left = 411
            c2.Top = 248
            TimerUp.Stop()
        End If
        If (c2.Left = 447) And (c2.Top > 121 And c2.Top < 161) Then
            c2.Left = 447
            c2.Top = 161
            TimerUp.Stop()
        End If
        If (c2.Left = 412) And (c2.Top > 70 And c2.Top < 110) Then
            c2.Left = 412
            c2.Top = 110
            TimerUp.Stop()
        End If
        If (c2.Left = 465) And (c2.Top > -15 And c2.Top < 25) Then
            c2.Left = 465
            c2.Top = 25
            TimerUp.Stop()
            Form3.Score2_1 += 1
            Form4.Score2_2 += 1
            Me.Hide()
            Form3.Show()
        End If
        If (c2.Left = 307) And (c2.Top > 363 And c2.Top < 403) Then
            c2.Left = 307
            c2.Top = 403
            TimerUp.Stop()
        End If
        If (c2.Left = 362) And (c2.Top > 300 And c2.Top < 333) Then
            c2.Left = 307
            c2.Top = 403
            TimerUp.Stop()
        End If
        If (c2.Left = 444) And (c2.Top > 363 And c2.Top < 403) Then
            c2.Left = 444
            c2.Top = 403
            TimerUp.Stop()
        End If
        If c2.Left = 550 And c2.Top = 391 Then
            c2.Left = 550
            c2.Top = 403
            TimerUp.Stop()
        End If
        If c2.Left = 550 And c2.Top = 394 Then
            c2.Left = 550
            c2.Top = 403
            TimerUp.Stop()
        End If
        If c2.Left = 462 And c2.Top = 451 Then
            c2.Left = 462
            c2.Top = 454
            TimerUp.Stop()
        End If
        If c2.Left = 497 And c2.Top = 403 Then
            TimerUp.Stop()
        End If
        If c2.Left = 550 And c2.Top = 403 Then
            TimerUp.Stop()
        End If
    End Sub
    Private Sub TimerRt_Tick(sender As Object, e As EventArgs) Handles TimerRt.Tick
        c2.Left += 20
        If (c2.Left < 453 And c2.Left > 413) And (c2.Top = 333) Then
            c2.Left = 413
            c2.Top = 333
            TimerRt.Stop()
        End If
        If (c2.Left < 522 And c2.Left > 482) And (c2.Top = 248) Then
            c2.Left = 482
            c2.Top = 248
            TimerRt.Stop()
        End If
        If (c2.Left < 487 And c2.Left > 447) And (c2.Top = 301) Then
            c2.Left = 447
            c2.Top = 301
            TimerRt.Stop()
        End If
        If (c2.Left < 487 And c2.Left > 447) And (c2.Top = 161) Then
            c2.Left = 447
            c2.Top = 161
            TimerRt.Stop()
        End If
        If (c2.Left < 505 And c2.Left > 465) And (c2.Top = 110) Then
            c2.Left = 465
            c2.Top = 110
            TimerRt.Stop()
        End If
        If (c2.Left < 402 And c2.Left > 362) And (c2.Top = 457) Then
            c2.Left = 362
            c2.Top = 457
            TimerRt.Stop()
        End If
        If (c2.Left < 522 And c2.Left > 482) And (c2.Top = 372) Then
            c2.Left = 482
            c2.Top = 372
            TimerRt.Stop()
        End If
        If (c2.Left < 484 And c2.Left > 444) And (c2.Top = 403) Then
            c2.Left = 444
            c2.Top = 403
            TimerRt.Stop()
        End If
        If (c2.Left < 402 And c2.Left > 362) And (c2.Top = 457) Then
            c2.Left = 362
            c2.Top = 457
            TimerRt.Stop()
        End If
        If (c2.Left < 590 And c2.Left > 550) And (c2.Top = 423) Then
            c2.Left = 550
            c2.Top = 423
            TimerRt.Stop()
        End If
        If c2.Left = 450 And c2.Top = 454 Then
            c2.Left = 462
            c2.Top = 454
            TimerRt.Stop()
        End If
        If c2.Left = 562 And c2.Top = 491 Then
            c2.Left = 550
            c2.Top = 491
            TimerRt.Stop()
        End If
        If c2.Left = 557 And c2.Top = 403 Then
            c2.Left = 550
            c2.Top = 403
            TimerRt.Stop()
        End If
        If c2.Left = 557 And c2.Top = 423 Then
            c2.Left = 550
            c2.Top = 423
            TimerRt.Stop()
        End If
        If c2.Left = 562 And c2.Top = 454 Then
            c2.Left = 550
            c2.Top = 454
            TimerRt.Stop()
        End If
    End Sub

    Private Sub TimerDn_Tick(sender As Object, e As EventArgs) Handles TimerDn.Tick
        c2.Top += 20
        If (c2.Left = 362) And (c2.Top > 457 And c2.Top < 497) Then
            c2.Left = 362
            c2.Top = 457
            TimerDn.Stop()
        End If
        If (c2.Left = 307) And (c2.Top > 457 And c2.Top < 497) Then
            c2.Left = 307
            c2.Top = 457
            TimerDn.Stop()
        End If
        If (c2.Left = 413) And (c2.Top > 372 And c2.Top < 412) Then
            c2.Left = 413
            c2.Top = 372
            TimerDn.Stop()
        End If
        If (c2.Left = 482) And (c2.Top > 372 And c2.Top < 412) Then
            c2.Left = 482
            c2.Top = 372
            TimerDn.Stop()
        End If
        If (c2.Left = 411) And (c2.Top > 301 And c2.Top < 341) Then
            c2.Left = 411
            c2.Top = 301
            TimerDn.Stop()
        End If
        If (c2.Left = 447) And (c2.Top > 301 And c2.Top < 341) Then
            c2.Left = 447
            c2.Top = 301
            TimerDn.Stop()
        End If
        If (c2.Left = 412) And (c2.Top > 161 And c2.Top < 201) Then
            c2.Left = 412
            c2.Top = 161
            TimerDn.Stop()
        End If
        If c2.Left = 307 And (c2.Top > 457 And c2.Top < 497) Then
            c2.Left = 307
            c2.Top = 457
            TimerDn.Stop()
        End If
        If c2.Left = 444 And (c2.Top > 423 And c2.Top < 463) Then
            c2.Left = 444
            c2.Top = 423
            TimerDn.Stop()
        End If
        If c2.Left = 550 And (c2.Top > 491 And c2.Top < 531) Then
            c2.Left = 550
            c2.Top = 491
            TimerDn.Stop()
        End If
        If c2.Left = 550 And c2.Top = 503 Then
            c2.Left = 550
            c2.Top = 491
            TimerDn.Stop()
        End If
        If c2.Left = 497 And c2.Top = 423 Then
            TimerDn.Stop()
        End If
        If c2.Left = 462 And c2.Top = 494 Then
            c2.Left = 462
            c2.Top = 491
            TimerDn.Stop()
        End If
        If c2.Left = 550 And c2.Top = 491 Then
            TimerDn.Stop()
        End If
        If c2.Left = 462 And c2.Top = 454 Then
            TimerDn.Stop()
        End If
    End Sub

    Private Sub TimerLt_Tick(sender As Object, e As EventArgs) Handles TimerLt.Tick
        c2.Left -= 20
        If (c2.Left < 307 And c2.Left > 266) And (c2.Top = 457) Then
            c2.Left = 307
            c2.Top = 457
            TimerLt.Stop()
        End If
        If (c2.Left < 362 And c2.Left > 322) And (c2.Top = 333) Then
            c2.Left = 362
            c2.Top = 333
            TimerLt.Stop()
        End If
        If (c2.Left < 411 And c2.Left > 371) And (c2.Top = 248) Then
            c2.Left = 411
            c2.Top = 248
            TimerLt.Stop()
        End If
        If (c2.Left < 412 And c2.Left > 372) And (c2.Top = 161) Then
            c2.Left = 412
            c2.Top = 161
            TimerLt.Stop()
        End If
        If (c2.Left < 412 And c2.Left > 372) And (c2.Top = 110) Then
            c2.Left = 412
            c2.Top = 110
            TimerLt.Stop()
        End If
        If (c2.Left < 411 And c2.Left > 371) And (c2.Top = 301) Then
            c2.Left = 411
            c2.Top = 301
            TimerLt.Stop()
        End If
        If (c2.Left < 413 And c2.Left > 373) And (c2.Top = 372) Then
            c2.Left = 413
            c2.Top = 372
            TimerLt.Stop()
        End If
        If (c2.Left < 307 And c2.Left > 267) And (c2.Top = 403) Then
            c2.Left = 307
            c2.Top = 403
            TimerLt.Stop()
        End If
        If c2.Left = 450 And c2.Top = 491 Then
            c2.Left = 462
            c2.Top = 491
            TimerLt.Stop()
        End If
        If c2.Left = 490 And c2.Top = 403 Then
            c2.Left = 497
            c2.Top = 403
            TimerLt.Stop()
        End If
        If (c2.Left < 444 And c2.Left > 404) And (c2.Top = 423) Then
            c2.Left = 444
            c2.Top = 423
            TimerLt.Stop()
        End If
        If (c2.Left < 462 And c2.Left > 422) And (c2.Top = 454) Then
            c2.Left = 462
            c2.Top = 454
            TimerLt.Stop()
        End If
    End Sub

End Class