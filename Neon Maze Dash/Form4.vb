Public Class Form4
    Dim WithEvents Timer1 As New Timer
    Dim WithEvents TimerD As New Timer
    Dim WithEvents TimerW As New Timer
    Dim WithEvents TimerA As New Timer
    Dim WithEvents TimerS As New Timer
    Dim WithEvents TimerRt As New Timer
    Dim WithEvents TimerUp As New Timer
    Dim WithEvents TimerLt As New Timer
    Dim WithEvents TimerDn As New Timer
    Public bg4 As Integer = 0
    Public Counter As Integer = 0
    Public Score1_2 As Integer
    Public Score2_2 As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Score1_1 = Score1_2
        Form3.Score2_1 = Score2_2
        If Score1_2 = 1 Then
            PictureBox7.Image = My.Resources.p1_1
        End If
        If Score2_2 = 1 Then
            PictureBox8.Image = My.Resources.p2_1
        End If
        If Score1_2 = 2 Then
            PictureBox7.Image = My.Resources.p1_2
        End If
        If Score2_2 = 2 Then
            PictureBox8.Image = My.Resources.p2_2
        End If
        c1.Location = New Point(356, 490)
        c2.Location = New Point(356, 490)
        Timer1.Interval = 2000
        Timer1.Start()
        Me.BackgroundImage = My.Resources.level4bg
        bg4 = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'sLabel1.Text = $"x = {c1.Left} {vbNewLine} y = {c1.Top}"
        Me.BackgroundImage = My.Resources.bg4_2
        bg4 = 1
        Counter += 1
        If Counter Mod 2 = 1 Then
            Me.BackgroundImage = My.Resources.level4bg
            bg4 = 0
        End If
    End Sub

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

        If c1.Left = 455 AndAlso c1.Top = 64 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 327 Then
            moveW(e)
            moveD(e)
            moveA(e)
            If bg4 = 1 Then
                moveS(e)
            End If
        End If
        If c1.Left = 488 AndAlso c1.Top = 294 Then
            moveS(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 455 AndAlso c1.Top = 47 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 405 AndAlso c1.Top = 47 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 405 AndAlso c1.Top = 64 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 373 AndAlso c1.Top = 64 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 373 AndAlso c1.Top = 146 Then
            moveW(e)
            moveA(e)
            moveS(e)
        End If
        If c1.Left = 324 AndAlso c1.Top = 146 Then
            moveD(e)
            moveS(e)
        End If
        If c1.Left = 324 AndAlso c1.Top = 211 Then
            moveW(e)
        End If

        If c1.Left = 537 AndAlso c1.Top = 343 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 570 AndAlso c1.Top = 343 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 570 AndAlso c1.Top = 178 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 520 AndAlso c1.Top = 178 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 520 AndAlso c1.Top = 113 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 422 AndAlso c1.Top = 113 Then
            moveD(e)
            moveS(e)
        End If
        If c1.Left = 422 AndAlso c1.Top = 178 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 178 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 64 Then
            moveS(e)
            moveA(e)
        End If

        If c1.Left = 504 AndAlso c1.Top = 327 Then
            moveA(e)
            moveW(e)
            moveS(e)
        End If

        If c1.Left = 406 AndAlso c1.Top = 278 Then
            moveA(e)
            moveW(e)
            moveS(e)
        End If
        If c1.Left = 373 AndAlso c1.Top = 278 Then
            If bg4 = 0 Then
                moveS(e)
                moveD(e)
            Else
                moveA(e)
                moveS(e)
                moveD(e)
            End If
        End If
        If c1.Left = 488 AndAlso c1.Top = 211 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 228 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 520 AndAlso c1.Top = 228 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 406 AndAlso c1.Top = 228 Then
            moveD(e)
        End If
        If c1.Left = 520 AndAlso c1.Top = 261 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 537 AndAlso c1.Top = 261 Then
            moveA(e)
            moveS(e)
        End If

        If c1.Left = 471 AndAlso c1.Top = 358 Then
            moveD(e)
        End If
        If c1.Left = 504 AndAlso c1.Top = 358 Then
            moveA(e)
        End If
        If c1.Left = 406 AndAlso c1.Top = 327 Then
            moveW(e)
            moveA(e)
            moveD(e)
        End If
        If c1.Left = 406 AndAlso c1.Top = 211 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 373 AndAlso c1.Top = 327 Then
            moveW(e)
            moveD(e)
        End If

        If c1.Left = 471 AndAlso c1.Top = 376 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 471 AndAlso c1.Top = 358 Then
            moveW(e)
            moveS(e)
        End If
        If c1.Left = 504 AndAlso c1.Top = 376 Then
            moveW(e)
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 504 AndAlso c1.Top = 408 Then
            moveA(e)
            moveD(e)
            moveW(e)
        End If
        If c1.Left = 504 AndAlso c1.Top = 358 Then
            moveW(e)
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 504 AndAlso c1.Top = 294 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 471 AndAlso c1.Top = 294 Then
            moveA(e)
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 406 AndAlso c1.Top = 294 Then
            moveW(e)
            moveS(e)
            moveD(e)
            If bg4 = 1 Then
                moveA(e)
            End If
        End If

        If c1.Left = 406 AndAlso c1.Top = 441 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 441 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 474 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 553 AndAlso c1.Top = 474 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 553 AndAlso c1.Top = 408 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 408 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 488 AndAlso c1.Top = 358 Then
            moveA(e)
            moveS(e)
            moveD(e)
            If bg4 = 1 Then
                moveW(e)
            End If
        End If

        If c1.Left = 340 AndAlso c1.Top = 490 Then
            moveD(e)
            moveA(e)
            moveW(e)
        End If
        If c1.Left = 356 AndAlso c1.Top = 441 Then
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 356 AndAlso c1.Top = 490 Then
            moveW(e)
            moveA(e)
        End If
        If c1.Left = 292 AndAlso c1.Top = 441 Then
            moveW(e)
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 292 AndAlso c1.Top = 425 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 292 AndAlso c1.Top = 490 Then
            moveW(e)
            moveD(e)
        End If
        If c1.Left = 340 AndAlso c1.Top = 425 Then
            moveW(e)
            moveS(e)
            moveA(e)
        End If
        If c1.Left = 340 AndAlso c1.Top = 392 Then
            moveS(e)
            moveD(e)
        End If
        If c1.Left = 406 AndAlso c1.Top = 392 Then
            moveA(e)
            moveS(e)
        End If

        If c2.Left = 455 AndAlso c2.Top = 64 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 327 Then
            moveUp(e)
            moveRt(e)
            moveLt(e)
            If bg4 = 1 Then
                moveDn(e)
            End If
        End If
        If c2.Left = 488 AndAlso c2.Top = 294 Then
            moveDn(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 455 AndAlso c2.Top = 47 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 405 AndAlso c2.Top = 47 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 405 AndAlso c2.Top = 64 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 373 AndAlso c2.Top = 64 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 373 AndAlso c2.Top = 146 Then
            moveUp(e)
            moveLt(e)
            moveDn(e)
        End If
        If c2.Left = 324 AndAlso c2.Top = 146 Then
            moveRt(e)
            moveDn(e)
        End If
        If c2.Left = 324 AndAlso c2.Top = 211 Then
            moveUp(e)
        End If

        If c2.Left = 537 AndAlso c2.Top = 343 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 570 AndAlso c2.Top = 343 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 570 AndAlso c2.Top = 178 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 520 AndAlso c2.Top = 178 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 520 AndAlso c2.Top = 113 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 422 AndAlso c2.Top = 113 Then
            moveRt(e)
            moveDn(e)
        End If
        If c2.Left = 422 AndAlso c2.Top = 178 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 178 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 64 Then
            moveDn(e)
            moveLt(e)
        End If

        If c2.Left = 504 AndAlso c2.Top = 327 Then
            moveLt(e)
            moveUp(e)
            moveDn(e)
        End If

        If c2.Left = 406 AndAlso c2.Top = 278 Then
            moveLt(e)
            moveUp(e)
            moveDn(e)
        End If
        If c2.Left = 373 AndAlso c2.Top = 278 Then
            If bg4 = 0 Then
                moveDn(e)
                moveRt(e)
            Else
                moveLt(e)
                moveDn(e)
                moveRt(e)
            End If
        End If
        If c2.Left = 488 AndAlso c2.Top = 211 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 228 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 520 AndAlso c2.Top = 228 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 406 AndAlso c2.Top = 228 Then
            moveRt(e)
        End If
        If c2.Left = 520 AndAlso c2.Top = 261 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 537 AndAlso c2.Top = 261 Then
            moveLt(e)
            moveDn(e)
        End If

        If c2.Left = 471 AndAlso c2.Top = 358 Then
            moveRt(e)
        End If
        If c2.Left = 504 AndAlso c2.Top = 358 Then
            moveLt(e)
        End If
        If c2.Left = 406 AndAlso c2.Top = 327 Then
            moveUp(e)
            moveLt(e)
            moveRt(e)
        End If
        If c2.Left = 406 AndAlso c2.Top = 211 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 373 AndAlso c2.Top = 327 Then
            moveUp(e)
            moveRt(e)
        End If

        If c2.Left = 471 AndAlso c2.Top = 376 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 471 AndAlso c2.Top = 358 Then
            moveUp(e)
            moveDn(e)
        End If
        If c2.Left = 504 AndAlso c2.Top = 376 Then
            moveUp(e)
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 504 AndAlso c2.Top = 408 Then
            moveLt(e)
            moveRt(e)
            moveUp(e)
        End If
        If c2.Left = 504 AndAlso c2.Top = 358 Then
            moveUp(e)
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 504 AndAlso c2.Top = 294 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 471 AndAlso c2.Top = 294 Then
            moveLt(e)
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 406 AndAlso c2.Top = 294 Then
            moveUp(e)
            moveDn(e)
            moveRt(e)
            If bg4 = 1 Then
                moveLt(e)
            End If
        End If

        If c2.Left = 406 AndAlso c2.Top = 441 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 441 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 474 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 553 AndAlso c2.Top = 474 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 553 AndAlso c2.Top = 408 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 408 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 488 AndAlso c2.Top = 358 Then
            moveLt(e)
            moveDn(e)
            moveRt(e)
            If bg4 = 1 Then
                moveUp(e)
            End If
        End If

        If c2.Left = 340 AndAlso c2.Top = 490 Then
            moveRt(e)
            moveLt(e)
            moveUp(e)
        End If
        If c2.Left = 356 AndAlso c2.Top = 441 Then
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 356 AndAlso c2.Top = 490 Then
            moveUp(e)
            moveLt(e)
        End If
        If c2.Left = 292 AndAlso c2.Top = 441 Then
            moveUp(e)
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 292 AndAlso c2.Top = 425 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 292 AndAlso c2.Top = 490 Then
            moveUp(e)
            moveRt(e)
        End If
        If c2.Left = 340 AndAlso c2.Top = 425 Then
            moveUp(e)
            moveDn(e)
            moveLt(e)
        End If
        If c2.Left = 340 AndAlso c2.Top = 392 Then
            moveDn(e)
            moveRt(e)
        End If
        If c2.Left = 406 AndAlso c2.Top = 392 Then
            moveLt(e)
            moveDn(e)
        End If

    End Sub

    Private Sub TimerW_Tick(sender As Object, e As EventArgs) Handles TimerW.Tick
        c1.Top -= 25
        If (c1.Left = 455) And (c1.Top > 7 And c1.Top < 47) Then
            c1.Left = 455
            c1.Top = 47
            TimerW.Stop()
        End If
        If (c1.Left = 405) And (c1.Top > 7 And c1.Top < 47) Then
            c1.Left = 405
            c1.Top = 47
            TimerW.Stop()
        End If
        If (c1.Left = 373) And (c1.Top > 24 And c1.Top < 64) Then
            c1.Left = 373
            c1.Top = 64
            TimerW.Stop()
        End If
        If (c1.Left = 570) And (c1.Top > 138 And c1.Top < 178) Then
            c1.Left = 570
            c1.Top = 178
            TimerW.Stop()
        End If
        If (c1.Left = 520) And (c1.Top > 73 And c1.Top < 113) Then
            c1.Left = 520
            c1.Top = 113
            TimerW.Stop()
        End If
        If (c1.Left = 422) And (c1.Top > 73 And c1.Top < 113) Then
            c1.Left = 422
            c1.Top = 113
            TimerW.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 24 And c1.Top < 64) Then
            c1.Left = 488
            c1.Top = 64
            TimerW.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 171 And c1.Top < 211) Then
            c1.Left = 488
            c1.Top = 211
            TimerW.Stop()
        End If
        If (c1.Left = 373) And (c1.Top > 238 And c1.Top < 278) Then
            c1.Left = 373
            c1.Top = 278
            TimerW.Stop()
        End If
        If (c1.Left = 520) And (c1.Top > 188 And c1.Top < 228) Then
            c1.Left = 520
            c1.Top = 228
            TimerW.Stop()
        End If
        If (c1.Left = 537) And (c1.Top > 221 And c1.Top < 261) Then
            c1.Left = 537
            c1.Top = 261
            TimerW.Stop()
        End If
        If (c1.Left = 406) And (c1.Top > 171 And c1.Top < 211) Then
            c1.Left = 406
            c1.Top = 211
            TimerW.Stop()
        End If
        If (c1.Left = 504) And (c1.Top > 254 And c1.Top < 294) Then
            c1.Left = 504
            c1.Top = 294
            TimerW.Stop()
        End If
        If (c1.Left = 471) And (c1.Top > 254 And c1.Top < 294) Then
            c1.Left = 471
            c1.Top = 294
            TimerW.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 401 And c1.Top < 441) Then
            c1.Left = 488
            c1.Top = 441
            TimerW.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 254 And c1.Top < 294) Then
            c1.Left = 488
            c1.Top = 294
            TimerW.Stop()
        End If
        If (c1.Left = 553) And (c1.Top > 368 And c1.Top < 408) Then
            c1.Left = 553
            c1.Top = 408
            TimerW.Stop()
        End If
        If ((c1.Left = 488) And (c1.Top > 318 And c1.Top < 358)) And bg4 = 0 Then
            c1.Left = 488
            c1.Top = 358
            TimerW.Stop()
        End If
        If (c1.Left = 356) And (c1.Top > 401 And c1.Top < 441) Then
            c1.Left = 356
            c1.Top = 441
            TimerW.Stop()
        End If
        If (c1.Left = 292) And (c1.Top > 385 And c1.Top < 425) Then
            c1.Left = 292
            c1.Top = 425
            TimerW.Stop()
        End If
        If (c1.Left = 340) And (c1.Top > 352 And c1.Top < 392) Then
            c1.Left = 340
            c1.Top = 392
            TimerW.Stop()
        End If
        If (c1.Left = 406) And (c1.Top > 352 And c1.Top < 392) Then
            c1.Left = 406
            c1.Top = 392
            TimerW.Stop()
        End If
        If (c1.Left = 537) And (c1.Top > 201 And c1.Top < 261) Then
            c1.Left = 537
            c1.Top = 261
            TimerW.Stop()
        End If
    End Sub
    Private Sub TimerA_Tick(sender As Object, e As EventArgs) Handles TimerA.Tick
        c1.Left -= 25
        If c1.Left < -19 Then
            c1.Location = New Point(356, 490)
            TimerA.Stop()
        End If
        If (c1.Left < 455 And c1.Left > 415) And (c1.Top = 64) Then
            c1.Left = 455
            c1.Top = 64
            TimerA.Stop()
        End If
        If (c1.Left < 405 And c1.Left > 365) And (c1.Top = 47) Then
            c1.Left = 405
            c1.Top = 47
            TimerA.Stop()
        End If
        If (c1.Left < 373 And c1.Left > 333) And (c1.Top = 64) Then
            c1.Left = 373
            c1.Top = 64
            TimerA.Stop()
        End If
        If (c1.Left < 324 And c1.Left > 284) And (c1.Top = 146) Then
            c1.Left = 324
            c1.Top = 146
            TimerA.Stop()
        End If
        If (c1.Left < 537 And c1.Left > 497) And (c1.Top = 343) Then
            c1.Left = 537
            c1.Top = 343
            TimerA.Stop()
        End If
        If (c1.Left < 520 And c1.Left > 480) And (c1.Top = 178) Then
            c1.Left = 520
            c1.Top = 178
            TimerA.Stop()
        End If
        If (c1.Left < 422 And c1.Left > 382) And (c1.Top = 113) Then
            c1.Left = 422
            c1.Top = 113
            TimerA.Stop()
        End If
        If (c1.Left < 422 And c1.Left > 382) And (c1.Top = 178) Then
            c1.Left = 422
            c1.Top = 178
            TimerA.Stop()
        End If
        If (c1.Left < 406 And c1.Left > 366) And (c1.Top = 228) Then
            c1.Left = 406
            c1.Top = 228
            TimerA.Stop()
        End If
        If ((c1.Left < 373 And c1.Left > 343) And (c1.Top = 278)) And bg4 = 0 Then
            c1.Left = 373
            c1.Top = 278
            TimerA.Stop()
        End If
        If (c1.Left < 520 And c1.Left > 480) And (c1.Top = 261) Then
            c1.Left = 520
            c1.Top = 261
            TimerA.Stop()
        End If
        If (c1.Left < 471 And c1.Left > 431) And (c1.Top = 358) Then
            c1.Left = 471
            c1.Top = 358
            TimerA.Stop()
        End If
        If (c1.Left < 471 And c1.Left > 431) And (c1.Top = 376) Then
            c1.Left = 471
            c1.Top = 376
            TimerA.Stop()
        End If
        If (c1.Left < 406 And c1.Left > 366) And (c1.Top = 211) Then
            c1.Left = 406
            c1.Top = 211
            TimerA.Stop()
        End If
        If (c1.Left < 373 And c1.Left > 333) And (c1.Top = 327) Then
            c1.Left = 373
            c1.Top = 327
            TimerA.Stop()
        End If
        If ((c1.Left < 406 And c1.Left > 366) And (c1.Top = 294)) And bg4 = 0 Then
            c1.Left = 406
            c1.Top = 294
            TimerA.Stop()
        End If
        If (c1.Left < 292 And c1.Left > 259) And (c1.Top = 441) Then
            c1.Left = 292
            c1.Top = 441
            TimerA.Stop()
        End If
        If (c1.Left < 292 And c1.Left > 252) And (c1.Top = 425) Then
            c1.Left = 292
            c1.Top = 425
            TimerA.Stop()
        End If
        If (c1.Left < 292 And c1.Left > 252) And (c1.Top = 490) Then
            c1.Left = 292
            c1.Top = 490
            TimerA.Stop()
        End If
        If (c1.Left < 340 And c1.Left > 300) And (c1.Top = 392) Then
            c1.Left = 340
            c1.Top = 392
            TimerA.Stop()
        End If
        If (c1.Left < 406 And c1.Left > 366) And (c1.Top = 441) Then
            c1.Left = 406
            c1.Top = 441
            TimerA.Stop()
        End If
        If (c1.Left < 488 And c1.Left > 448) And (c1.Top = 474) Then
            c1.Left = 488
            c1.Top = 474
            TimerA.Stop()
        End If
        If (c1.Left < 488 And c1.Left > 448) And (c1.Top = 408) Then
            c1.Left = 488
            c1.Top = 408
            TimerA.Stop()
        End If
    End Sub
    Private Sub TimerS_Tick(sender As Object, e As EventArgs) Handles TimerS.Tick
        c1.Top += 25
        If (c1.Left = 455) And (c1.Top > 64 And c1.Top < 104) Then
            c1.Left = 455
            c1.Top = 64
            TimerS.Stop()
        End If
        If (c1.Left = 405) And (c1.Top > 64 And c1.Top < 104) Then
            c1.Left = 405
            c1.Top = 64
            TimerS.Stop()
        End If
        If (c1.Left = 373) And (c1.Top > 146 And c1.Top < 186) Then
            c1.Left = 373
            c1.Top = 146
            TimerS.Stop()
        End If
        If (c1.Left = 324) And (c1.Top > 211 And c1.Top < 251) Then
            c1.Left = 324
            c1.Top = 211
            TimerS.Stop()
            Score1_2 += 1
            Me.Hide()
            Form6.Show()
        End If
        If (c1.Left = 537) And (c1.Top > 303 And c1.Top < 343) Then
            c1.Left = 537
            c1.Top = 343
            TimerS.Stop()
        End If
        If (c1.Left = 570) And (c1.Top > 303 And c1.Top < 343) Then
            c1.Left = 570
            c1.Top = 343
            TimerS.Stop()
        End If
        If (c1.Left = 520) And (c1.Top > 138 And c1.Top < 178) Then
            c1.Left = 520
            c1.Top = 178
            TimerS.Stop()
        End If
        If (c1.Left = 422) And (c1.Top > 138 And c1.Top < 178) Then
            c1.Left = 422
            c1.Top = 178
            TimerS.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 138 And c1.Top < 178) Then
            c1.Left = 488
            c1.Top = 178
            TimerS.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 228 And c1.Top < 268) Then
            c1.Left = 488
            c1.Top = 228
            TimerS.Stop()
        End If
        If (c1.Left = 520) And (c1.Top > 261 And c1.Top < 301) Then
            c1.Left = 520
            c1.Top = 261
            TimerS.Stop()
        End If
        If (c1.Left = 406) And (c1.Top > 327 And c1.Top < 367) Then
            c1.Left = 406
            c1.Top = 327
            TimerS.Stop()
        End If
        If (c1.Left = 504) And (c1.Top > 408 And c1.Top < 448) Then
            c1.Left = 504
            c1.Top = 408
            TimerS.Stop()
        End If
        If (c1.Left = 373) And (c1.Top > 327 And c1.Top < 367) Then
            c1.Left = 373
            c1.Top = 327
            TimerS.Stop()
        End If
        If bg4 = 0 And ((c1.Left < 406 And c1.Left > 366) And (c1.Top = 294)) Then
            c1.Left = 406
            c1.Top = 294
            TimerA.Stop()
        End If
        If (c1.Left = 406) And (c1.Top > 441 And c1.Top < 481) Then
            c1.Left = 406
            c1.Top = 441
            TimerS.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 474 And c1.Top < 514) Then
            c1.Left = 488
            c1.Top = 474
            TimerS.Stop()
        End If
        If (c1.Left = 471) And (c1.Top > 376 And c1.Top < 416) Then
            c1.Left = 471
            c1.Top = 376
            TimerS.Stop()
        End If
        If (c1.Left = 553) And (c1.Top > 474 And c1.Top < 514) Then
            c1.Left = 553
            c1.Top = 474
            TimerS.Stop()
        End If
        If (c1.Left = 488) And (c1.Top > 408 And c1.Top < 448) Then
            c1.Left = 488
            c1.Top = 408
            TimerS.Stop()
        End If
        If (c1.Left = 292) And (c1.Top > 490 And c1.Top < 530) Then
            c1.Left = 292
            c1.Top = 490
            TimerS.Stop()
        End If
        If (c1.Top > 490) Then
            c1.Top = 490
            TimerS.Stop()
        End If
        If (c1.Left = 356) And (c1.Top > 490 And c1.Top < 530) Then
            c1.Left = 356
            c1.Top = 490
            TimerS.Stop()
        End If
        If ((c1.Left = 488) And (c1.Top > 327 And c1.Top < 367)) And bg4 = 0 Then
            c1.Left = 488
            c1.Top = 327
            TimerS.Stop()
        End If
    End Sub
    Private Sub TimerD_Tick(sender As Object, e As EventArgs) Handles TimerD.Tick
        c1.Left += 25
        If (c1.Left < 495 And c1.Left > 455) And (c1.Top = 47) Then
            c1.Left = 455
            c1.Top = 47
            TimerD.Stop()
        End If
        If (c1.Left < 445 And c1.Left > 405) And (c1.Top = 64) Then
            c1.Left = 405
            c1.Top = 64
            TimerD.Stop()
        End If
        If (c1.Left < 413 And c1.Left > 373) And (c1.Top = 146) Then
            c1.Left = 373
            c1.Top = 146
            TimerD.Stop()
        End If
        If (c1.Left < 610 And c1.Left > 570) And (c1.Top = 343) Then
            c1.Left = 570
            c1.Top = 343
            TimerD.Stop()
        End If
        If (c1.Left < 610 And c1.Left > 570) And (c1.Top = 178) Then
            c1.Left = 570
            c1.Top = 178
            TimerD.Stop()
        End If
        If (c1.Left < 560 And c1.Left > 520) And (c1.Top = 113) Then
            c1.Left = 520
            c1.Top = 113
            TimerD.Stop()
        End If
        If (c1.Left < 528 And c1.Left > 488) And (c1.Top = 178) Then
            c1.Left = 488
            c1.Top = 178
            TimerD.Stop()
        End If
        If (c1.Left < 528 And c1.Left > 488) And (c1.Top = 64) Then
            c1.Left = 488
            c1.Top = 64
            TimerD.Stop()
        End If
        If (c1.Left < 544 And c1.Left > 504) And (c1.Top = 327) Then
            c1.Left = 504
            c1.Top = 327
            TimerD.Stop()
        End If
        If (c1.Left < 446 And c1.Left > 406) And (c1.Top = 278) Then
            c1.Left = 406
            c1.Top = 278
            TimerD.Stop()
        End If
        If (c1.Left < 527 And c1.Left > 488) And (c1.Top = 211) Then
            c1.Left = 488
            c1.Top = 211
            TimerD.Stop()
        End If
        If (c1.Left < 560 And c1.Left > 520) And (c1.Top = 228) Then
            c1.Left = 520
            c1.Top = 228
            TimerD.Stop()
        End If
        If (c1.Left < 576 And c1.Left > 537) And (c1.Top = 261) Then
            c1.Left = 537
            c1.Top = 261
            TimerD.Stop()
        End If
        If (c1.Left < 544 And c1.Left > 504) And (c1.Top = 358) Then
            c1.Left = 504
            c1.Top = 358
            TimerD.Stop()
        End If
        If (c1.Left < 544 And c1.Left > 504) And (c1.Top = 376) Then
            c1.Left = 504
            c1.Top = 376
            TimerD.Stop()
        End If
        If (c1.Left < 544 And c1.Left > 504) And (c1.Top = 376) Then
            c1.Left = 504
            c1.Top = 376
            TimerD.Stop()
        End If
        If (c1.Left < 544 And c1.Left > 504) And (c1.Top = 294) Then
            c1.Left = 504
            c1.Top = 294
            TimerD.Stop()
        End If
        If (c1.Left < 528 And c1.Left > 488) And (c1.Top = 441) Then
            c1.Left = 488
            c1.Top = 441
            TimerD.Stop()
        End If
        If (c1.Left < 593 And c1.Left > 553) And (c1.Top = 474) Then
            c1.Left = 553
            c1.Top = 474
            TimerD.Stop()
        End If
        If (c1.Left < 593 And c1.Left > 553) And (c1.Top = 408) Then
            c1.Left = 553
            c1.Top = 408
            TimerD.Stop()
        End If
        If (c1.Left < 396 And c1.Left > 356) And (c1.Top = 441) Then
            c1.Left = 356
            c1.Top = 441
            TimerD.Stop()
        End If
        If (c1.Left < 380 And c1.Left > 340) And (c1.Top = 425) Then
            c1.Left = 340
            c1.Top = 425
            TimerD.Stop()
        End If
        If (c1.Left < 446 And c1.Left > 406) And (c1.Top = 392) Then
            c1.Left = 406
            c1.Top = 392
            TimerD.Stop()
        End If
        If (c1.Left < 396 And c1.Left > 356) And (c1.Top = 490) Then
            c1.Left = 356
            c1.Top = 490
            TimerD.Stop()
        End If
    End Sub
    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        c2.Top -= 25
        If (c2.Left = 455) And (c2.Top > 7 And c2.Top < 47) Then
            c2.Left = 455
            c2.Top = 47
            TimerUp.Stop()
        End If
        If (c2.Left = 405) And (c2.Top > 7 And c2.Top < 47) Then
            c2.Left = 405
            c2.Top = 47
            TimerUp.Stop()
        End If
        If (c2.Left = 373) And (c2.Top > 24 And c2.Top < 64) Then
            c2.Left = 373
            c2.Top = 64
            TimerUp.Stop()
        End If
        If (c2.Left = 570) And (c2.Top > 138 And c2.Top < 178) Then
            c2.Left = 570
            c2.Top = 178
            TimerUp.Stop()
        End If
        If (c2.Left = 520) And (c2.Top > 73 And c2.Top < 113) Then
            c2.Left = 520
            c2.Top = 113
            TimerUp.Stop()
        End If
        If (c2.Left = 422) And (c2.Top > 73 And c2.Top < 113) Then
            c2.Left = 422
            c2.Top = 113
            TimerUp.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 24 And c2.Top < 64) Then
            c2.Left = 488
            c2.Top = 64
            TimerUp.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 171 And c2.Top < 211) Then
            c2.Left = 488
            c2.Top = 211
            TimerUp.Stop()
        End If
        If (c2.Left = 373) And (c2.Top > 238 And c2.Top < 278) Then
            c2.Left = 373
            c2.Top = 278
            TimerUp.Stop()
        End If
        If (c2.Left = 520) And (c2.Top > 188 And c2.Top < 228) Then
            c2.Left = 520
            c2.Top = 228
            TimerUp.Stop()
        End If
        If (c2.Left = 537) And (c2.Top > 221 And c2.Top < 261) Then
            c2.Left = 537
            c2.Top = 261
            TimerUp.Stop()
        End If
        If (c2.Left = 406) And (c2.Top > 171 And c2.Top < 211) Then
            c2.Left = 406
            c2.Top = 211
            TimerUp.Stop()
        End If
        If (c2.Left = 504) And (c2.Top > 254 And c2.Top < 294) Then
            c2.Left = 504
            c2.Top = 294
            TimerUp.Stop()
        End If
        If (c2.Left = 471) And (c2.Top > 254 And c2.Top < 294) Then
            c2.Left = 471
            c2.Top = 294
            TimerUp.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 401 And c2.Top < 441) Then
            c2.Left = 488
            c2.Top = 441
            TimerUp.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 254 And c2.Top < 294) Then
            c2.Left = 488
            c2.Top = 294
            TimerUp.Stop()
        End If
        If (c2.Left = 553) And (c2.Top > 368 And c2.Top < 408) Then
            c2.Left = 553
            c2.Top = 408
            TimerUp.Stop()
        End If
        If ((c2.Left = 488) And (c2.Top > 318 And c2.Top < 358)) And bg4 = 0 Then
            c2.Left = 488
            c2.Top = 358
            TimerUp.Stop()
        End If
        If (c2.Left = 356) And (c2.Top > 401 And c2.Top < 441) Then
            c2.Left = 356
            c2.Top = 441
            TimerUp.Stop()
        End If
        If (c2.Left = 292) And (c2.Top > 385 And c2.Top < 425) Then
            c2.Left = 292
            c2.Top = 425
            TimerUp.Stop()
        End If
        If (c2.Left = 340) And (c2.Top > 352 And c2.Top < 392) Then
            c2.Left = 340
            c2.Top = 392
            TimerUp.Stop()
        End If
        If (c2.Left = 406) And (c2.Top > 352 And c2.Top < 392) Then
            c2.Left = 406
            c2.Top = 392
            TimerUp.Stop()
        End If
        If (c2.Left = 537) And (c2.Top > 201 And c2.Top < 261) Then
            c2.Left = 537
            c2.Top = 261
            TimerUp.Stop()
        End If
    End Sub
    Private Sub TimerLt_Tick(sender As Object, e As EventArgs) Handles TimerLt.Tick
        c2.Left -= 25
        If c2.Left < -19 Then
            c2.Location = New Point(356, 490)
            TimerLt.Stop()
        End If
        If (c2.Left < 455 And c2.Left > 415) And (c2.Top = 64) Then
            c2.Left = 455
            c2.Top = 64
            TimerLt.Stop()
        End If
        If (c2.Left < 405 And c2.Left > 365) And (c2.Top = 47) Then
            c2.Left = 405
            c2.Top = 47
            TimerLt.Stop()
        End If
        If (c2.Left < 373 And c2.Left > 333) And (c2.Top = 64) Then
            c2.Left = 373
            c2.Top = 64
            TimerLt.Stop()
        End If
        If (c2.Left < 324 And c2.Left > 284) And (c2.Top = 146) Then
            c2.Left = 324
            c2.Top = 146
            TimerLt.Stop()
        End If
        If (c2.Left < 537 And c2.Left > 497) And (c2.Top = 343) Then
            c2.Left = 537
            c2.Top = 343
            TimerLt.Stop()
        End If
        If (c2.Left < 520 And c2.Left > 480) And (c2.Top = 178) Then
            c2.Left = 520
            c2.Top = 178
            TimerLt.Stop()
        End If
        If (c2.Left < 422 And c2.Left > 382) And (c2.Top = 113) Then
            c2.Left = 422
            c2.Top = 113
            TimerLt.Stop()
        End If
        If (c2.Left < 422 And c2.Left > 382) And (c2.Top = 178) Then
            c2.Left = 422
            c2.Top = 178
            TimerLt.Stop()
        End If
        If (c2.Left < 406 And c2.Left > 366) And (c2.Top = 228) Then
            c2.Left = 406
            c2.Top = 228
            TimerLt.Stop()
        End If
        If ((c2.Left < 373 And c2.Left > 343) And (c2.Top = 278)) And bg4 = 0 Then
            c2.Left = 373
            c2.Top = 278
            TimerLt.Stop()
        End If
        If (c2.Left < 520 And c2.Left > 480) And (c2.Top = 261) Then
            c2.Left = 520
            c2.Top = 261
            TimerLt.Stop()
        End If
        If (c2.Left < 471 And c2.Left > 431) And (c2.Top = 358) Then
            c2.Left = 471
            c2.Top = 358
            TimerLt.Stop()
        End If
        If (c2.Left < 471 And c2.Left > 431) And (c2.Top = 376) Then
            c2.Left = 471
            c2.Top = 376
            TimerLt.Stop()
        End If
        If (c2.Left < 406 And c2.Left > 366) And (c2.Top = 211) Then
            c2.Left = 406
            c2.Top = 211
            TimerLt.Stop()
        End If
        If (c2.Left < 373 And c2.Left > 333) And (c2.Top = 327) Then
            c2.Left = 373
            c2.Top = 327
            TimerLt.Stop()
        End If
        If ((c2.Left < 406 And c2.Left > 366) And (c2.Top = 294)) And bg4 = 0 Then
            c2.Left = 406
            c2.Top = 294
            TimerLt.Stop()
        End If
        If (c2.Left < 292 And c2.Left > 259) And (c2.Top = 441) Then
            c2.Left = 292
            c2.Top = 441
            TimerLt.Stop()
        End If
        If (c2.Left < 292 And c2.Left > 252) And (c2.Top = 425) Then
            c2.Left = 292
            c2.Top = 425
            TimerLt.Stop()
        End If
        If (c2.Left < 292 And c2.Left > 252) And (c2.Top = 490) Then
            c2.Left = 292
            c2.Top = 490
            TimerLt.Stop()
        End If
        If (c2.Left < 340 And c2.Left > 300) And (c2.Top = 392) Then
            c2.Left = 340
            c2.Top = 392
            TimerLt.Stop()
        End If
        If (c2.Left < 406 And c2.Left > 366) And (c2.Top = 441) Then
            c2.Left = 406
            c2.Top = 441
            TimerLt.Stop()
        End If
        If (c2.Left < 488 And c2.Left > 448) And (c2.Top = 474) Then
            c2.Left = 488
            c2.Top = 474
            TimerLt.Stop()
        End If
        If (c2.Left < 488 And c2.Left > 448) And (c2.Top = 408) Then
            c2.Left = 488
            c2.Top = 408
            TimerLt.Stop()
        End If
    End Sub
    Private Sub TimerDn_Tick(sender As Object, e As EventArgs) Handles TimerDn.Tick
        c2.Top += 25
        If (c2.Left = 455) And (c2.Top > 64 And c2.Top < 104) Then
            c2.Left = 455
            c2.Top = 64
            TimerDn.Stop()
        End If
        If (c2.Left = 405) And (c2.Top > 64 And c2.Top < 104) Then
            c2.Left = 405
            c2.Top = 64
            TimerDn.Stop()
        End If
        If (c2.Left = 373) And (c2.Top > 146 And c2.Top < 186) Then
            c2.Left = 373
            c2.Top = 146
            TimerDn.Stop()
        End If
        If (c2.Left = 324) And (c2.Top > 211 And c2.Top < 251) Then
            c2.Left = 324
            c2.Top = 211
            TimerDn.Stop()
            Score2_2 += 1
            Me.Hide()
            Form6.Show()
        End If
        If (c2.Left = 537) And (c2.Top > 303 And c2.Top < 343) Then
            c2.Left = 537
            c2.Top = 343
            TimerDn.Stop()
        End If
        If (c2.Left = 570) And (c2.Top > 303 And c2.Top < 343) Then
            c2.Left = 570
            c2.Top = 343
            TimerDn.Stop()
        End If
        If (c2.Left = 520) And (c2.Top > 138 And c2.Top < 178) Then
            c2.Left = 520
            c2.Top = 178
            TimerDn.Stop()
        End If
        If (c2.Left = 422) And (c2.Top > 138 And c2.Top < 178) Then
            c2.Left = 422
            c2.Top = 178
            TimerDn.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 138 And c2.Top < 178) Then
            c2.Left = 488
            c2.Top = 178
            TimerDn.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 228 And c2.Top < 268) Then
            c2.Left = 488
            c2.Top = 228
            TimerDn.Stop()
        End If
        If (c2.Left = 520) And (c2.Top > 261 And c2.Top < 301) Then
            c2.Left = 520
            c2.Top = 261
            TimerDn.Stop()
        End If
        If (c2.Left = 406) And (c2.Top > 327 And c2.Top < 367) Then
            c2.Left = 406
            c2.Top = 327
            TimerDn.Stop()
        End If
        If (c2.Left = 504) And (c2.Top > 408 And c2.Top < 448) Then
            c2.Left = 504
            c2.Top = 408
            TimerDn.Stop()
        End If
        If (c2.Left = 373) And (c2.Top > 327 And c2.Top < 367) Then
            c2.Left = 373
            c2.Top = 327
            TimerDn.Stop()
        End If
        If bg4 = 0 And ((c2.Left < 406 And c2.Left > 366) And (c2.Top = 294)) Then
            c2.Left = 406
            c2.Top = 294
            TimerLt.Stop()
        End If
        If (c2.Left = 406) And (c2.Top > 441 And c2.Top < 481) Then
            c2.Left = 406
            c2.Top = 441
            TimerDn.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 474 And c2.Top < 514) Then
            c2.Left = 488
            c2.Top = 474
            TimerDn.Stop()
        End If
        If (c2.Left = 471) And (c2.Top > 376 And c2.Top < 416) Then
            c2.Left = 471
            c2.Top = 376
            TimerDn.Stop()
        End If
        If (c2.Left = 553) And (c2.Top > 474 And c2.Top < 514) Then
            c2.Left = 553
            c2.Top = 474
            TimerDn.Stop()
        End If
        If (c2.Left = 488) And (c2.Top > 408 And c2.Top < 448) Then
            c2.Left = 488
            c2.Top = 408
            TimerDn.Stop()
        End If
        If (c2.Left = 292) And (c2.Top > 490 And c2.Top < 530) Then
            c2.Left = 292
            c2.Top = 490
            TimerDn.Stop()
        End If
        If (c2.Top > 490) Then
            c2.Top = 490
            TimerDn.Stop()
        End If
        If (c2.Left = 356) And (c2.Top > 490 And c2.Top < 530) Then
            c2.Left = 356
            c2.Top = 490
            TimerDn.Stop()
        End If
        If ((c2.Left = 488) And (c2.Top > 327 And c2.Top < 367)) And bg4 = 0 Then
            c2.Left = 488
            c2.Top = 327
            TimerDn.Stop()
        End If
    End Sub
    Private Sub TimerRt_Tick(sender As Object, e As EventArgs) Handles TimerRt.Tick
        c2.Left += 25
        If (c2.Left < 495 And c2.Left > 455) And (c2.Top = 47) Then
            c2.Left = 455
            c2.Top = 47
            TimerRt.Stop()
        End If
        If (c2.Left < 445 And c2.Left > 405) And (c2.Top = 64) Then
            c2.Left = 405
            c2.Top = 64
            TimerRt.Stop()
        End If
        If (c2.Left < 413 And c2.Left > 373) And (c2.Top = 146) Then
            c2.Left = 373
            c2.Top = 146
            TimerRt.Stop()
        End If
        If (c2.Left < 610 And c2.Left > 570) And (c2.Top = 343) Then
            c2.Left = 570
            c2.Top = 343
            TimerRt.Stop()
        End If
        If (c2.Left < 610 And c2.Left > 570) And (c2.Top = 178) Then
            c2.Left = 570
            c2.Top = 178
            TimerRt.Stop()
        End If
        If (c2.Left < 560 And c2.Left > 520) And (c2.Top = 113) Then
            c2.Left = 520
            c2.Top = 113
            TimerRt.Stop()
        End If
        If (c2.Left < 528 And c2.Left > 488) And (c2.Top = 178) Then
            c2.Left = 488
            c2.Top = 178
            TimerRt.Stop()
        End If
        If (c2.Left < 528 And c2.Left > 488) And (c2.Top = 64) Then
            c2.Left = 488
            c2.Top = 64
            TimerRt.Stop()
        End If
        If (c2.Left < 544 And c2.Left > 504) And (c2.Top = 327) Then
            c2.Left = 504
            c2.Top = 327
            TimerRt.Stop()
        End If
        If (c2.Left < 446 And c2.Left > 406) And (c2.Top = 278) Then
            c2.Left = 406
            c2.Top = 278
            TimerRt.Stop()
        End If
        If (c2.Left < 527 And c2.Left > 488) And (c2.Top = 211) Then
            c2.Left = 488
            c2.Top = 211
            TimerRt.Stop()
        End If
        If (c2.Left < 560 And c2.Left > 520) And (c2.Top = 228) Then
            c2.Left = 520
            c2.Top = 228
            TimerRt.Stop()
        End If
        If (c2.Left < 576 And c2.Left > 537) And (c2.Top = 261) Then
            c2.Left = 537
            c2.Top = 261
            TimerRt.Stop()
        End If
        If (c2.Left < 544 And c2.Left > 504) And (c2.Top = 358) Then
            c2.Left = 504
            c2.Top = 358
            TimerRt.Stop()
        End If
        If (c2.Left < 544 And c2.Left > 504) And (c2.Top = 376) Then
            c2.Left = 504
            c2.Top = 376
            TimerRt.Stop()
        End If
        If (c2.Left < 544 And c2.Left > 504) And (c2.Top = 376) Then
            c2.Left = 504
            c2.Top = 376
            TimerRt.Stop()
        End If
        If (c2.Left < 544 And c2.Left > 504) And (c2.Top = 294) Then
            c2.Left = 504
            c2.Top = 294
            TimerRt.Stop()
        End If
        If (c2.Left < 528 And c2.Left > 488) And (c2.Top = 441) Then
            c2.Left = 488
            c2.Top = 441
            TimerRt.Stop()
        End If
        If (c2.Left < 593 And c2.Left > 553) And (c2.Top = 474) Then
            c2.Left = 553
            c2.Top = 474
            TimerRt.Stop()
        End If
        If (c2.Left < 593 And c2.Left > 553) And (c2.Top = 408) Then
            c2.Left = 553
            c2.Top = 408
            TimerRt.Stop()
        End If
        If (c2.Left < 396 And c2.Left > 356) And (c2.Top = 441) Then
            c2.Left = 356
            c2.Top = 441
            TimerRt.Stop()
        End If
        If (c2.Left < 380 And c2.Left > 340) And (c2.Top = 425) Then
            c2.Left = 340
            c2.Top = 425
            TimerRt.Stop()
        End If
        If (c2.Left < 446 And c2.Left > 406) And (c2.Top = 392) Then
            c2.Left = 406
            c2.Top = 392
            TimerRt.Stop()
        End If
        If (c2.Left < 396 And c2.Left > 356) And (c2.Top = 490) Then
            c2.Left = 356
            c2.Top = 490
            TimerRt.Stop()
        End If
    End Sub

End Class