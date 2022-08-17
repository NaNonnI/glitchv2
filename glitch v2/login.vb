Public Class login
    Private Sub ShowForm(WhichForm As Form)
        With WhichForm
            .Show()
            .BringToFront()
        End With
    End Sub
    Private Sub rbutton_Click(sender As Object, e As EventArgs) Handles rbutton.Click
        ShowForm(New rules)
    End Sub

    Private Sub lbutton_Click(sender As Object, e As EventArgs) Handles lbutton.Click
        If txtenter.Text = "1973" Then
            Me.Hide()
            MsgBox("Access Key successfully validated.")
            ShowForm(New loading)
        Else
            MsgBox("Bad Access Key.")
        End If
    End Sub
End Class