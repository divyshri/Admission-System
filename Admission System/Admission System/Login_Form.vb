Public Class Login_Form

    Private Sub Login_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Btn.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please enter username and password", MsgBoxStyle.Critical, "Invalid")
            Exit Sub
        End If
        If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then

            Dashboard.Show()
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""

        Else
            MsgBox("Invalid User Name or Password", MsgBoxStyle.Critical, "Information")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub

    Private Sub Login_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
