Public Class init
    Dim RandomPos As New Random
    Public Sub spammer_Tick(sender As Object, e As EventArgs) Handles spammer.Tick
        If DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080)) Then
            DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080))
        Else
            DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080))
        End If
    End Sub
    Private Sub ShowForm(WhichForm As Form)
        With WhichForm
            .Show()
            .BringToFront()
        End With
    End Sub
    Private Sub initimg_Click(sender As Object, e As EventArgs) Handles initimg.Click
        initimg.Image = My.Resources.init1
        spammer.Start()
        ShowForm(New spam)
    End Sub
End Class