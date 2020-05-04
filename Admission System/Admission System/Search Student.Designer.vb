<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Student))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppNoTextBox = New System.Windows.Forms.TextBox()
        Me.AppNoSearchButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Student"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AppNoTextBox
        '
        Me.AppNoTextBox.Location = New System.Drawing.Point(122, 84)
        Me.AppNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AppNoTextBox.Name = "AppNoTextBox"
        Me.AppNoTextBox.Size = New System.Drawing.Size(160, 23)
        Me.AppNoTextBox.TabIndex = 1
        '
        'AppNoSearchButton
        '
        Me.AppNoSearchButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNoSearchButton.Location = New System.Drawing.Point(314, 78)
        Me.AppNoSearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AppNoSearchButton.Name = "AppNoSearchButton"
        Me.AppNoSearchButton.Size = New System.Drawing.Size(78, 30)
        Me.AppNoSearchButton.TabIndex = 2
        Me.AppNoSearchButton.Text = "Search"
        Me.AppNoSearchButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 194)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(793, 283)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Application No."
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(121, 144)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(160, 23)
        Me.NameTextBox.TabIndex = 5
        '
        'NameButton
        '
        Me.NameButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameButton.Location = New System.Drawing.Point(313, 138)
        Me.NameButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NameButton.Name = "NameButton"
        Me.NameButton.Size = New System.Drawing.Size(78, 30)
        Me.NameButton.TabIndex = 6
        Me.NameButton.Text = "Search"
        Me.NameButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Student Name"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(676, 137)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 35)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Search_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(815, 488)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.AppNoSearchButton)
        Me.Controls.Add(Me.AppNoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Search_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search_Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AppNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppNoSearchButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
