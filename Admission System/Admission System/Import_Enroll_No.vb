Imports System.Data.OleDb
Public Class Import_Enroll_No
    Dim con As System.Data.OleDb.OleDbConnection
    Dim ds As System.Data.DataSet
    Dim da As System.Data.OleDb.OleDbDataAdapter

    Private Sub AddMarksButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMarksButton.Click
        Timer1.Start()
        Dim com As New OleDbCommand

        Dim conn As New OleDbConnection
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [DAVV$]", con)
        conn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb")
        Dim app, marks As String
        conn.Open()


        Try
            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    ProgressBar1.Increment(1)
                    app = row.Cells(0).Value.ToString
                    marks = row.Cells(1).Value.ToString


                    Dim str As String
                    str = "Update [Admission] set [enroll] = '" & marks & "'WHERE [app] like '" & app & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Me.Refresh()


                End If

            Next
            MsgBox("Record Sucessfully Updated", MsgBoxStyle.Information)
            conn.Close()
            Timer1.Stop()
            MessageBox.Show("Registered Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Sub

    Private Sub Import_Enroll_No_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Users\\Divyashu\\Desktop\\DAVV.xls';Extended Properties=Excel 8.0;")
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [ENROLL$]", con)
        ds = New System.Data.DataSet
        da.Fill(ds)
        DataGridView.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class