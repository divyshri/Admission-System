Imports System.Data.OleDb
Public Class Search_Student

    Dim con As New OleDb.OleDbConnection

    
    
    Private Sub AppNoSearchButton_Click(sender As System.Object, e As System.EventArgs) Handles AppNoSearchButton.Click
        If AppNoTextBox.Text = Nothing Then
            MsgBox("Enter Application No. to search", MessageBoxIcon.Information)
        Else

            Dim DT As New DataTable
            Dim DS As New DataSet
            DS.Tables.Add(DT)
            Dim DA As New OleDbDataAdapter
            DA = New OleDbDataAdapter("Select * from Record where app like '" & AppNoTextBox.Text & "'", con)


            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView


        End If
    End Sub

    

    Private Sub NameButton_Click(sender As System.Object, e As System.EventArgs) Handles NameButton.Click
        If NameTextBox.Text = Nothing Then
            MsgBox("Enter Student name to search", MessageBoxIcon.Information)
        Else
            Dim DT As New DataTable
            Dim DS As New DataSet
            DS.Tables.Add(DT)
            Dim DA As New OleDbDataAdapter


            DA = New OleDbDataAdapter("Select * from Record where name like '%" & NameTextBox.Text & "%'", con)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If

    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        con.Close()
        Me.Close()
        Dashboard.Show()

    End Sub

    Private Sub Search_Student_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
        Dashboard.Show()
      
    End Sub

    Private Sub Search_Student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dd As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\addmission.mdb"
        con = New OleDbConnection(dd)
        con.Open()
    End Sub

  
End Class