Public Class spam
    Dim RandomPos As New Random
    Public Sub spammer_Tick(sender As Object, e As EventArgs) Handles spammer.Tick
        If DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080)) Then
            DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080))
            Beep()
        Else
            DesktopLocation = New Point(RandomPos.Next(1, 1920), RandomPos.Next(1, 1080))
        End If
    End Sub
    Private Sub spamform0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imgList As New List(Of Image)

        imgList.Add(My.Resources._error)
        imgList.Add(My.Resources.glitch)
        imgList.Add(My.Resources.glitch2)

        Dim rnd = New Random()
        Dim randomPic = imgList(rnd.Next(0, imgList.Count))

        spammer.Start()
    End Sub
End Class