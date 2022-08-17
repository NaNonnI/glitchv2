<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spam
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(spam))
        Me.spammer = New System.Windows.Forms.Timer(Me.components)
        Me.spamimg = New System.Windows.Forms.PictureBox()
        CType(Me.spamimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spammer
        '
        Me.spammer.Interval = 1
        '
        'spamimg
        '
        Me.spamimg.Image = Global.glitch_v2.My.Resources.Resources._error
        Me.spamimg.Location = New System.Drawing.Point(-2, -6)
        Me.spamimg.Name = "spamimg"
        Me.spamimg.Size = New System.Drawing.Size(540, 303)
        Me.spamimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.spamimg.TabIndex = 0
        Me.spamimg.TabStop = False
        '
        'spam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 291)
        Me.Controls.Add(Me.spamimg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "spam"
        Me.ShowInTaskbar = False
        Me.Text = "g̴̘̈͛l̵̰͚̈́͛i̸̯͕͛t̴͍̳̀c̶̯͌̈ḩ̴̱̋ ̷̍͜͝v̸̮͒̾2̸̖́  | spam"
        CType(Me.spamimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spammer As Timer
    Friend WithEvents spamimg As PictureBox
End Class
