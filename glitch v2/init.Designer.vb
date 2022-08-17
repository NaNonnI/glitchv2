<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class init
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(init))
        Me.initimg = New System.Windows.Forms.PictureBox()
        Me.spammer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.initimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'initimg
        '
        Me.initimg.Image = CType(resources.GetObject("initimg.Image"), System.Drawing.Image)
        Me.initimg.Location = New System.Drawing.Point(-1, -116)
        Me.initimg.Name = "initimg"
        Me.initimg.Size = New System.Drawing.Size(843, 651)
        Me.initimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.initimg.TabIndex = 0
        Me.initimg.TabStop = False
        '
        'spammer
        '
        Me.spammer.Interval = 1
        '
        'init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.initimg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "init"
        Me.Text = "g̴̘̈͛l̵̰͚̈́͛i̸̯͕͛t̴͍̳̀c̶̯͌̈ḩ̴̱̋ ̷̍͜͝v̸̮͒̾2̸̖́  | init"
        CType(Me.initimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents initimg As PictureBox
    Friend WithEvents spammer As Timer
End Class
