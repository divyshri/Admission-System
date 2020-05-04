Imports System.Data.OleDb

Public Class Rank_Calculation

    Dim con As OleDb.OleDbConnection

    Private Sub Rank_Calculation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
        Dashboard.Show()
    End Sub

    Private Sub Rank_Calculation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dd As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\addmission.mdb"
        con = New OleDbConnection(dd)
        con.Open()
    End Sub

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        Dim Command As OleDbCommand
        Command = New OleDbCommand(" INSERT INTO rank SELECT * FROM Record ORDER BY marks desc ", con)
        Command.ExecuteNonQuery()
        Command.Dispose()

        MsgBox("Records Added Successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub ShowButton_Click(sender As System.Object, e As System.EventArgs) Handles ShowButton.Click
        Dim DT As New DataTable
        Dim DS As New DataSet
        DS.Tables.Add(DT)
        Dim DA As New OleDbDataAdapter

        DA = New OleDbDataAdapter("SELECT * FROM rank ", con)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView

    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        con.Close()
        Me.Close()
        Dashboard.Show()
    End Sub

   
End Class