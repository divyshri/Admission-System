<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RankList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Common_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CommonButton = New System.Windows.Forms.Button()
        Me.GENButton = New System.Windows.Forms.Button()
        Me.OBCButton = New System.Windows.Forms.Button()
        Me.SCButton = New System.Windows.Forms.Button()
        Me.STButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Rank List"
        '
        'Common_Label
        '
        Me.Common_Label.AutoSize = True
        Me.Common_Label.Location = New System.Drawing.Point(189, 124)
        Me.Common_Label.Name = "Common_Label"
        Me.Common_Label.Size = New System.Drawing.Size(125, 17)
        Me.Common_Label.TabIndex = 38
        Me.Common_Label.Text = "Common Rank List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Rank List of GEN Candidate only"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Rank List of OBC Candidate only"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Rank List of SC Candidate Only"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Rank List of ST Candidate Only"
        '
        'CommonButton
        '
        Me.CommonButton.Location = New System.Drawing.Point(555, 117)
        Me.CommonButton.Name = "CommonButton"
        Me.CommonButton.Size = New System.Drawing.Size(89, 31)
        Me.CommonButton.TabIndex = 39
        Me.CommonButton.Text = "Generate"
        Me.CommonButton.UseVisualStyleBackColor = True
        '
        'GENButton
        '
        Me.GENButton.Location = New System.Drawing.Point(555, 169)
        Me.GENButton.Name = "GENButton"
        Me.GENButton.Size = New System.Drawing.Size(89, 31)
        Me.GENButton.TabIndex = 39
        Me.GENButton.Text = "Generate"
        Me.GENButton.UseVisualStyleBackColor = True
        '
        'OBCButton
        '
        Me.OBCButton.Location = New System.Drawing.Point(555, 221)
        Me.OBCButton.Name = "OBCButton"
        Me.OBCButton.Size = New System.Drawing.Size(89, 31)
        Me.OBCButton.TabIndex = 39
        Me.OBCButton.Text = "Generate"
        Me.OBCButton.UseVisualStyleBackColor = True
        '
        'SCButton
        '
        Me.SCButton.Location = New System.Drawing.Point(555, 273)
        Me.SCButton.Name = "SCButton"
        Me.SCButton.Size = New System.Drawing.Size(89, 31)
        Me.SCButton.TabIndex = 39
        Me.SCButton.Text = "Generate"
        Me.SCButton.UseVisualStyleBackColor = True
        '
        'STButton
        '
        Me.STButton.Location = New System.Drawing.Point(555, 325)
        Me.STButton.Name = "STButton"
        Me.STButton.Size = New System.Drawing.Size(89, 31)
        Me.STButton.TabIndex = 39
        Me.STButton.Text = "Generate"
        Me.STButton.UseVisualStyleBackColor = True
        '
        'RankList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 463)
        Me.Controls.Add(Me.STButton)
        Me.Controls.Add(Me.SCButton)
        Me.Controls.Add(Me.OBCButton)
        Me.Controls.Add(Me.GENButton)
        Me.Controls.Add(Me.CommonButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Common_Label)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RankList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RankList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Common_Label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CommonButton As System.Windows.Forms.Button
    Friend WithEvents GENButton As System.Windows.Forms.Button
    Friend WithEvents OBCButton As System.Windows.Forms.Button
    Friend WithEvents SCButton As System.Windows.Forms.Button
    Friend WithEvents STButton As System.Windows.Forms.Button
End Class
