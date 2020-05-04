<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteStudent))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.BoardComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.CasteComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PercentageTextBox = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox = New System.Windows.Forms.TextBox()
        Me.FatherNameTextBox = New System.Windows.Forms.TextBox()
        Me.StdNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RankLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.EnrollLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.AppNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(556, 460)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(120, 43)
        Me.BackButton.TabIndex = 66
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(392, 460)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(120, 43)
        Me.RefreshButton.TabIndex = 67
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(224, 460)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(120, 38)
        Me.DeleteButton.TabIndex = 68
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'BoardComboBox
        '
        Me.BoardComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoardComboBox.FormattingEnabled = True
        Me.BoardComboBox.Items.AddRange(New Object() {"CBSE", "MP Board"})
        Me.BoardComboBox.Location = New System.Drawing.Point(176, 303)
        Me.BoardComboBox.Name = "BoardComboBox"
        Me.BoardComboBox.Size = New System.Drawing.Size(207, 27)
        Me.BoardComboBox.TabIndex = 61
        Me.BoardComboBox.Text = "Select Board"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(176, 233)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(144, 26)
        Me.DateTimePicker.TabIndex = 58
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(176, 268)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(144, 27)
        Me.GenderComboBox.TabIndex = 60
        Me.GenderComboBox.Text = "Select Gender"
        '
        'CasteComboBox
        '
        Me.CasteComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CasteComboBox.FormattingEnabled = True
        Me.CasteComboBox.Items.AddRange(New Object() {"GEN", "OBC", "SC", "ST"})
        Me.CasteComboBox.Location = New System.Drawing.Point(540, 235)
        Me.CasteComboBox.Name = "CasteComboBox"
        Me.CasteComboBox.Size = New System.Drawing.Size(144, 27)
        Me.CasteComboBox.TabIndex = 59
        Me.CasteComboBox.Text = "Select Caste"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(176, 388)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(269, 54)
        Me.AddressTextBox.TabIndex = 65
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDTextBox.Location = New System.Drawing.Point(176, 346)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(207, 26)
        Me.EmailIDTextBox.TabIndex = 63
        '
        'PercentageTextBox
        '
        Me.PercentageTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PercentageTextBox.Location = New System.Drawing.Point(540, 306)
        Me.PercentageTextBox.MaxLength = 3
        Me.PercentageTextBox.Name = "PercentageTextBox"
        Me.PercentageTextBox.Size = New System.Drawing.Size(144, 26)
        Me.PercentageTextBox.TabIndex = 62
        '
        'MotherNameTextBox
        '
        Me.MotherNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotherNameTextBox.Location = New System.Drawing.Point(176, 192)
        Me.MotherNameTextBox.Name = "MotherNameTextBox"
        Me.MotherNameTextBox.Size = New System.Drawing.Size(269, 26)
        Me.MotherNameTextBox.TabIndex = 57
        '
        'FatherNameTextBox
        '
        Me.FatherNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatherNameTextBox.Location = New System.Drawing.Point(176, 151)
        Me.FatherNameTextBox.Name = "FatherNameTextBox"
        Me.FatherNameTextBox.Size = New System.Drawing.Size(269, 26)
        Me.FatherNameTextBox.TabIndex = 56
        '
        'StdNameTextBox
        '
        Me.StdNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdNameTextBox.Location = New System.Drawing.Point(176, 110)
        Me.StdNameTextBox.Name = "StdNameTextBox"
        Me.StdNameTextBox.Size = New System.Drawing.Size(269, 26)
        Me.StdNameTextBox.TabIndex = 43
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.Location = New System.Drawing.Point(540, 349)
        Me.ContactTextBox.MaxLength = 10
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(144, 26)
        Me.ContactTextBox.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(413, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Caste"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(413, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 19)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "12th Percentage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(413, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 19)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Contact No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(55, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 19)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Gender"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 349)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 19)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Email ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(56, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "12th Board"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Date Of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Mother's Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(538, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 19)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Rank"
        '
        'RankLabel
        '
        Me.RankLabel.AutoSize = True
        Me.RankLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RankLabel.Location = New System.Drawing.Point(655, 151)
        Me.RankLabel.Name = "RankLabel"
        Me.RankLabel.Size = New System.Drawing.Size(0, 19)
        Me.RankLabel.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Father's Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(536, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 19)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Enrollment No."
        '
        'EnrollLabel
        '
        Me.EnrollLabel.AutoSize = True
        Me.EnrollLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollLabel.Location = New System.Drawing.Point(655, 110)
        Me.EnrollLabel.Name = "EnrollLabel"
        Me.EnrollLabel.Size = New System.Drawing.Size(0, 19)
        Me.EnrollLabel.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Student Name"
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(556, 53)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(118, 42)
        Me.SearchButton.TabIndex = 39
        Me.SearchButton.Text = "Search"
        Me.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'AppNoTextBox
        '
        Me.AppNoTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNoTextBox.Location = New System.Drawing.Point(363, 62)
        Me.AppNoTextBox.Name = "AppNoTextBox"
        Me.AppNoTextBox.Size = New System.Drawing.Size(149, 26)
        Me.AppNoTextBox.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Application No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(539, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*Only Addmitted Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 32)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Delete Student Record"
        '
        'DeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(847, 510)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.BoardComboBox)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.CasteComboBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.EmailIDTextBox)
        Me.Controls.Add(Me.PercentageTextBox)
        Me.Controls.Add(Me.MotherNameTextBox)
        Me.Controls.Add(Me.FatherNameTextBox)
        Me.Controls.Add(Me.StdNameTextBox)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.RankLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.EnrollLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.AppNoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents BoardComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CasteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StdNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RankLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents EnrollLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents AppNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
