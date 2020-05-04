Public Class RankList

    Private Sub CommonButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommonButton.Click
        CommonRankListForm.Show()
    End Sub

    Private Sub GENButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENButton.Click
        GENCandidateRankListForm.Show()
    End Sub

    Private Sub OBCButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBCButton.Click
        OBCCandidatesRankListForm.Show()
    End Sub

    Private Sub SCButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCButton.Click
        SCCandidateRankListForm.Show()
    End Sub

    Private Sub STButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STButton.Click
        STCandidateRankListForm.Show()
    End Sub
End Class