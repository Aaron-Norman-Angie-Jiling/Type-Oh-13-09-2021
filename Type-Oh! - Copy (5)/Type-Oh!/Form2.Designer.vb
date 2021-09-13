<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnToGame = New System.Windows.Forms.Button()
        Me.btnShake = New System.Windows.Forms.Button()
        Me.btnBlackOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnToGame
        '
        Me.btnToGame.Location = New System.Drawing.Point(416, 479)
        Me.btnToGame.Name = "btnToGame"
        Me.btnToGame.Size = New System.Drawing.Size(150, 46)
        Me.btnToGame.TabIndex = 0
        Me.btnToGame.Text = "Play game"
        Me.btnToGame.UseVisualStyleBackColor = True
        '
        'btnShake
        '
        Me.btnShake.Location = New System.Drawing.Point(691, 478)
        Me.btnShake.Name = "btnShake"
        Me.btnShake.Size = New System.Drawing.Size(150, 46)
        Me.btnShake.TabIndex = 1
        Me.btnShake.Text = "Button1"
        Me.btnShake.UseVisualStyleBackColor = True
        '
        'btnBlackOut
        '
        Me.btnBlackOut.Location = New System.Drawing.Point(105, 478)
        Me.btnBlackOut.Name = "btnBlackOut"
        Me.btnBlackOut.Size = New System.Drawing.Size(177, 72)
        Me.btnBlackOut.TabIndex = 2
        Me.btnBlackOut.Text = "Blackout Mode"
        Me.btnBlackOut.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 733)
        Me.Controls.Add(Me.btnBlackOut)
        Me.Controls.Add(Me.btnShake)
        Me.Controls.Add(Me.btnToGame)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnToGame As Button
    Friend WithEvents btnShake As Button
    Friend WithEvents btnBlackOut As Button
End Class
