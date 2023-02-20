Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AntGame.Show()
        My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.Background)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutAnt.Show()
        My.Computer.Audio.Play(My.Resources.Fact_about_an_ant, AudioPlayMode.Background)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Welcome_to_ant_game, AudioPlayMode.Background)
    End Sub
End Class
