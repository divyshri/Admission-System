Public Class Dashboard

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Search_Student.Show()

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Rank_Calculation.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Login_Form.Close()
        Me.Close()
    End Sub

    Private Sub LogOutButton_Click(sender As System.Object, e As System.EventArgs) Handles LogOutButton.Click
        Me.Close()
        Login_Form.Show()
    End Sub

    Private Sub UpdateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateLabel.Click
        Me.Close()
        Update_Student.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        RankList.Show()
    End Sub

    Private Sub DltAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DltAd.Click
        DeleteStudent.Show()
        Me.Hide()
    End Sub

    Private Sub Import_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Import_Label.Click
        Import_Student_Record.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Import_Entance_Marks.Click
        Import_Entrance_marks.Show()

    End Sub

    Private Sub FeeSubmitLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeSubmitLabel.Click
        Fee_data_import.Show()
        Me.Hide()
    End Sub
    
    Private Sub Label555_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label555.Click
        Records_Form.Show()

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        AdmittedStudentListForm.Show()

    End Sub

    Private Sub Enroll_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enroll_Label.Click
        Import_Enroll_No.Show()
        Me.Hide()
    End Sub

    Private Sub UpdtRgstrdStudentLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdtRgstrdStudentLabel.Click
        UpdateRegisterdStudent.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class