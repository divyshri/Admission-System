Imports System.Data.OleDb
Public Class DeleteStudent

    Dim con As OleDb.OleDbConnection

    Public dr As OleDbDataReader

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        Dim sql As String
        sql = "Select * from Admission where app like '" & AppNoTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            MsgBox("Record Not Found", MsgBoxStyle.Exclamation)
        Else

            While dr.Read()
                EnrollLabel.Text = dr("enroll").ToString
                RankLabel.Text = dr("rank").ToString
                StdNameTextBox.Text = dr("name").ToString
                FatherNameTextBox.Text = dr("father").ToString
                MotherNameTextBox.Text = dr("mother").ToString
                DateTimePicker.Text = dr("dob").ToString
                CasteComboBox.Text = dr("category").ToString
                GenderComboBox.Text = dr("gender").ToString
                BoardComboBox.Text = dr("board").ToString
                PercentageTextBox.Text = dr("per").ToString
                EmailIDTextBox.Text = dr("email").ToString
                ContactTextBox.Text = dr("mobile").ToString
                AddressTextBox.Text = dr("address").ToString

            End While
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim str As String
        str = "delete * from Admission where [app] ='" & AppNoTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        EnrollLabel.Text = ""
        RankLabel.Text = ""
        StdNameTextBox.Text = ""
        FatherNameTextBox.Text = ""
        MotherNameTextBox.Text = ""
        DateTimePicker.Text = ""
        CasteComboBox.Text = ""
        GenderComboBox.Text = ""
        BoardComboBox.Text = ""
        PercentageTextBox.Text = ""
        EmailIDTextBox.Text = ""
        ContactTextBox.Text = ""
        AddressTextBox.Text = ""
        Me.Show()
        MsgBox("Record Sucessfully Deleted", MsgBoxStyle.Information)
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.Refresh()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        con.Close()
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub DeleteStudent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
        Dashboard.Show()
    End Sub

    Private Sub DeleteStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb"
        con = New OleDbConnection(dd)
        con.Open()
    End Sub
End Class