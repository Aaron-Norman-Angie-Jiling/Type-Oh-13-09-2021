<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCopytxt = New System.Windows.Forms.Label()
        Me.btnNewText = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnGetApi = New System.Windows.Forms.Button()
        Me.lblNotAt = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrShake = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.tmrBlackOut = New System.Windows.Forms.Timer(Me.components)
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.btnRead = New System.Windows.Forms.Button()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCopytxt
        '
        Me.lblCopytxt.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCopytxt.Location = New System.Drawing.Point(135, 36)
        Me.lblCopytxt.Name = "lblCopytxt"
        Me.lblCopytxt.Size = New System.Drawing.Size(924, 164)
        Me.lblCopytxt.TabIndex = 0
        Me.lblCopytxt.Text = " "
        '
        'btnNewText
        '
        Me.btnNewText.Location = New System.Drawing.Point(462, 634)
        Me.btnNewText.Name = "btnNewText"
        Me.btnNewText.Size = New System.Drawing.Size(191, 59)
        Me.btnNewText.TabIndex = 1
        Me.btnNewText.Text = "Get a text"
        Me.btnNewText.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Enabled = False
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.Location = New System.Drawing.Point(133, 280)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(926, 220)
        Me.txtInput.TabIndex = 2
        Me.txtInput.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(474, 733)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(150, 46)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(988, 747)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 46)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(79, 705)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 46)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(513, 538)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(98, 32)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score: 0"
        '
        'btnGetApi
        '
        Me.btnGetApi.Location = New System.Drawing.Point(183, 538)
        Me.btnGetApi.Name = "btnGetApi"
        Me.btnGetApi.Size = New System.Drawing.Size(150, 46)
        Me.btnGetApi.TabIndex = 7
        Me.btnGetApi.Text = "Fetch API"
        Me.btnGetApi.UseVisualStyleBackColor = True
        '
        'lblNotAt
        '
        Me.lblNotAt.AutoSize = True
        Me.lblNotAt.Location = New System.Drawing.Point(771, 538)
        Me.lblNotAt.Name = "lblNotAt"
        Me.lblNotAt.Size = New System.Drawing.Size(254, 32)
        Me.lblNotAt.TabIndex = 8
        Me.lblNotAt.Text = "Words Not Attempted:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(60, 781)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 46)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'tmrTime
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(966, 230)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(120, 32)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "0 seconds"
        '
        'tmrShake
        '
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Showcard Gothic", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(172, 290)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(853, 198)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = "Press ""Get a text"" or ""Fetch API"" to begin!"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrBlackOut
        '
        '
        'picBox
        '
        Me.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBox.Location = New System.Drawing.Point(683, 612)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(299, 204)
        Me.picBox.TabIndex = 12
        Me.picBox.TabStop = False
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(805, 144)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(150, 46)
        Me.btnRead.TabIndex = 13
        Me.btnRead.Text = "Read Aloud"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1199, 863)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblNotAt)
        Me.Controls.Add(Me.btnGetApi)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnNewText)
        Me.Controls.Add(Me.lblCopytxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopytxt As Label
    Friend WithEvents btnNewText As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents btnGetApi As Button
    Friend WithEvents lblNotAt As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents tmrTime As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrShake As Timer
    Friend WithEvents lblInstructions As Label
    Friend WithEvents tmrBlackOut As Timer
    Friend WithEvents picBox As PictureBox
    Friend WithEvents btnRead As Button
End Class
