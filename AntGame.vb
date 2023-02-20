Public Class AntGame
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
        PictureBox2.Top -= 5
        PictureBox3.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then
            Me.Dispose()
            MsgBox("Game Over")
            Form1.Show()

        End If
        Label1.Text = score
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score = score + 1
        Label1.Text = score
        PictureBox1.Location = New Point(200, 400)
        My.Computer.Audio.Play(My.Resources.y2mate_com___Squish__Sound_Effect, AudioPlayMode.Background)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        score = score + 1
        Label1.Text = score
        PictureBox2.Location = New Point(200, 400)
        My.Computer.Audio.Play(My.Resources.y2mate_com___Squish__Sound_Effect, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        score = score + 1
        Label1.Text = score
        PictureBox3.Location = New Point(200, 400)
        My.Computer.Audio.Play(My.Resources.y2mate_com___Squish__Sound_Effect, AudioPlayMode.Background)
    End Sub

    Private Sub AntGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.y2mate_com___Elevator_Music__Gaming_Background_Music_HD, AudioPlayMode.BackgroundLoop)

    End Sub
End Class