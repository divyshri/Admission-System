Imports System.Data.OleDb

Public Class Import_Student_Record

    Dim con As System.Data.OleDb.OleDbConnection
    Dim ds As System.Data.DataSet
    Dim da As System.Data.OleDb.OleDbDataAdapter

    Private Sub Import_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Import_Button.Click

        Dim com As New OleDbCommand

        Dim conn As New OleDbConnection
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [DAVV$]", con)
        conn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb")
        Dim app, course, name, father, mother, dob, gender, category, address, email, mobile, board, year, per As String
        conn.Open()


        Try
            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then

                    If row.Cells(1).Value.ToString Like "BCA" Then
                        app = row.Cells(0).Value.ToString
                        course = row.Cells(1).Value.ToString
                        name = row.Cells(2).Value.ToString
                        father = row.Cells(3).Value.ToString
                        mother = row.Cells(4).Value.ToString
                        dob = row.Cells(5).Value.ToString
                        category = row.Cells(6).Value.ToString
                        gender = row.Cells(7).Value.ToString
                        address = row.Cells(8).Value.ToString
                        email = row.Cells(9).Value.ToString
                        mobile = row.Cells(10).Value.ToString
                        board = row.Cells(11).Value.ToString
                        year = row.Cells(12).Value.ToString
                        per = row.Cells(13).Value.ToString



                        com = New OleDbCommand("insert into Record ([app],[course],[name],[father],[mother],[dob],[category],[gender],[address],[email],[mobile],[board],[year],[per]) values ('" & app & "' ,'" & course & "', '" & name & "' ,'" & father & " ', '" & mother & "', '" & dob & "', '" & category & "','" & gender & "','" & address & "','" & email & "','" & mobile & "','" & board & "','" & year & "','" & per & "')", conn)
                        com.ExecuteNonQuery()

                    End If

                End If

            Next
            conn.Close()

            MessageBox.Show("Registered Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub Import_Student_Record_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dashboard.Show()
    End Sub

    Private Sub Import_Student_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Users\\Divyashu\\Desktop\\DAVV.xls';Extended Properties=Excel 8.0;")
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [DAVV$]", con)
        ds = New System.Data.DataSet
        da.Fill(ds)
        DataGridView.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class