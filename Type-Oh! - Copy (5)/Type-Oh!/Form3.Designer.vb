<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnEndQuake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEndQuake
        '
        Me.btnEndQuake.Location = New System.Drawing.Point(45, 12)
        Me.btnEndQuake.Name = "btnEndQuake"
        Me.btnEndQuake.Size = New System.Drawing.Size(150, 46)
        Me.btnEndQuake.TabIndex = 0
        Me.btnEndQuake.Text = "End Earthquake"
        Me.btnEndQuake.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 72)
        Me.Controls.Add(Me.btnEndQuake)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEndQuake As Button
End Class
