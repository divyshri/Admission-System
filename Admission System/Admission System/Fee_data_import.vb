Imports System.Data.OleDb
Public Class Fee_data_import

    Dim con As System.Data.OleDb.OleDbConnection
    Dim ds As System.Data.DataSet
    Dim da As System.Data.OleDb.OleDbDataAdapter

    Private Sub Fee_data_import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Users\\Divyashu\\Desktop\\DAVV.xls';Extended Properties=Excel 8.0;")
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [FEES$]", con)
        ds = New System.Data.DataSet
        da.Fill(ds)
        DataGridView.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub ImportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportButton.Click
        Timer1.Start()
        Dim com As New OleDbCommand

        Dim conn As New OleDbConnection
        da = New System.Data.OleDb.OleDbDataAdapter("select * from [FEES$]", con)
        conn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\addmission.mdb")
        Dim app, course, aluminifee, portalfee, totalfee, paidstatus, transid As String
        conn.Open()


        Try

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    ProgressBar1.Increment(1)
                    app = row.Cells(0).Value.ToString
                    course = row.Cells(1).Value.ToString
                    aluminifee = row.Cells(2).Value.ToString
                    portalfee = row.Cells(3).Value.ToString
                    totalfee = row.Cells(4).Value.ToString
                    paidstatus = row.Cells(5).Value.ToString
                    transid = row.Cells(6).Value.ToString


                    Dim command As OleDbCommand
                    command = New OleDbCommand(" INSERT into Admission([app],[rank],[course],[name],[father],[mother],[dob],[category],[gender],[address],[email],[mobile],[board],[year],[per],[marks]) SELECT * FROM rank where [app] = '" & app & " '", conn)
                    command.ExecuteNonQuery()
                    command.Dispose()
                    Dim str As String
                    str = "Update [Admission] set [alumnifee] = '" & aluminifee & "', [portalfee] = '" & portalfee & "', [totalfee] = '" & totalfee & "', [paidstatus] = '" & paidstatus & "', [transid] = '" & transid & "' WHERE [app] = '" & app & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Me.Refresh()

                End If

            Next

            conn.Close()

            MessageBox.Show("Registered Successfully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Stop()
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click

        Dashboard.Show()
        Me.Close()
    End Sub

    
   
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class