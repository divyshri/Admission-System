Public Class Fee_Submission
    Dim con As OleDb.OleDbConnection
    Public dr As OleDb.OleDbDataReader

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Fee_Submission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb"
        con = New OleDb.OleDbConnection(dd)
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "Select * from Record where app like '" & AppNoTextBox.Text & "'"
        DA = New OleDb.OleDbDataAdapter(sql, con)
        DA.Fill(DT)

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            Label7.Text = dr("name").ToString
            ' FatherNameLabel.Text = dr("fname").ToString
            ' DOBLabel.Text = dr("dob").ToString
            ' ContactLabel.Text = dr("contact_no").ToString

        End While
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label4.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        ' OnlineTRadioButton.Visible = True
        Label5.Visible = True
        TextBox3.Visible = True
    End Sub
End Class