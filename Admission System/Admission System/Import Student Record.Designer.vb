<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import_Student_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Import_Student_Record))
        Me.Import_Button = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Import_Button
        '
        Me.Import_Button.Location = New System.Drawing.Point(370, 10)
        Me.Import_Button.Name = "Import_Button"
        Me.Import_Button.Size = New System.Drawing.Size(128, 34)
        Me.Import_Button.TabIndex = 0
        Me.Import_Button.Text = "Import Data"
        Me.Import_Button.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(11, 64)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(951, 451)
        Me.DataGridView.TabIndex = 1
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(827, 15)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(119, 28)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Import_Student_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 527)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Import_Button)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Import_Student_Record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import_Student_Record"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Import_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
