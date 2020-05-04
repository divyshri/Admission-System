Imports System.Data.OleDb
Public Class UpdateRegisterdStudent

    Dim con As OleDb.OleDbConnection
    Public dr As OleDbDataReader

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click

        Dim sql As String
        sql = "Select * from Record where app like '" & AppNoTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            MsgBox("Record Not Found", MsgBoxStyle.Exclamation)
        Else

            While dr.Read()
               
                CourseLabel.Text = dr("course").ToString
                StdNameTextBox.Text = dr("name").ToString
                FatherNameTextBox.Text = dr("father").ToString
                MotherNameTextBox.Text = dr("mother").ToString
                DOBLabel.Text = dr("dob").ToString
                CasteLabel.Text = dr("category").ToString
                GenderLabel.Text = dr("gender").ToString
                BoardComboBox.Text = dr("board").ToString
                PerLabel.Text = dr("per").ToString
                EmailIDTextBox.Text = dr("email").ToString
                ContactTextBox.Text = dr("mobile").ToString
                AddressTextBox.Text = dr("address").ToString

            End While
        End If
    End Sub


    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim str As String
        str = "UPDATE [Record] SET [name] = '" & StdNameTextBox.Text & "' , [father] = '" & FatherNameTextBox.Text & "', [mother] = '" & _
            MotherNameTextBox.Text & "', [board] = '" & BoardComboBox.Text & "', [email] = '" & EmailIDTextBox.Text & "', [mobile] = '" & _
            ContactTextBox.Text & "', [address] = '" & AddressTextBox.Text & "' where [app] =' " & AppNoTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Me.Refresh()
        MsgBox("Record Sucessfully Updated", MsgBoxStyle.Information)
    End Sub

    Private Sub Update_Student_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
        Dashboard.Show()
    End Sub

    Private Sub Update_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb"
        con = New OleDbConnection(dd)
        con.Open()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        con.Close()
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Refresh()
    End Sub
End Class