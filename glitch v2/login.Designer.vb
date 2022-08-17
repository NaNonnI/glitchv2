<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.ketxt = New System.Windows.Forms.Label()
        Me.lbutton = New System.Windows.Forms.Button()
        Me.rbutton = New System.Windows.Forms.Button()
        Me.txtenter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ketxt
        '
        Me.ketxt.AutoSize = True
        Me.ketxt.Location = New System.Drawing.Point(12, 9)
        Me.ketxt.Name = "ketxt"
        Me.ketxt.Size = New System.Drawing.Size(303, 13)
        Me.ketxt.TabIndex = 0
        Me.ketxt.Text = "Entrez la clé de dévérouillage et de consentement (voir règles)."
        '
        'lbutton
        '
        Me.lbutton.Location = New System.Drawing.Point(12, 55)
        Me.lbutton.Name = "lbutton"
        Me.lbutton.Size = New System.Drawing.Size(148, 23)
        Me.lbutton.TabIndex = 1
        Me.lbutton.Text = "Login"
        Me.lbutton.UseVisualStyleBackColor = True
        '
        'rbutton
        '
        Me.rbutton.Location = New System.Drawing.Point(166, 55)
        Me.rbutton.Name = "rbutton"
        Me.rbutton.Size = New System.Drawing.Size(149, 23)
        Me.rbutton.TabIndex = 2
        Me.rbutton.Text = "Règles"
        Me.rbutton.UseVisualStyleBackColor = True
        '
        'txtenter
        '
        Me.txtenter.Location = New System.Drawing.Point(12, 29)
        Me.txtenter.Name = "txtenter"
        Me.txtenter.Size = New System.Drawing.Size(303, 20)
        Me.txtenter.TabIndex = 3
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 86)
        Me.Controls.Add(Me.txtenter)
        Me.Controls.Add(Me.rbutton)
        Me.Controls.Add(Me.lbutton)
        Me.Controls.Add(Me.ketxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "g̴̘̈͛l̵̰͚̈́͛i̸̯͕͛t̴͍̳̀c̶̯͌̈ḩ̴̱̋ ̷̍͜͝v̸̮͒̾2̸̖́  | login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ketxt As Label
    Friend WithEvents lbutton As Button
    Friend WithEvents rbutton As Button
    Friend WithEvents txtenter As TextBox
End Class
