Public Class PvPMenu
    Private Sub btn_MainMenu_Click(sender As Object, e As EventArgs) Handles btn_MainMenu.Click
        My.Forms.MainMenu.Text = Now.ToString
        My.Forms.MainMenu.Show()
        My.Forms.PvPMenu.Hide()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_Classic_Click(sender As Object, e As EventArgs) Handles btn_Classic.Click
        My.Forms.PvPMatch.Text = Now.ToString
        My.Forms.PvPMatch.Show()
        My.Forms.PvPMenu.Hide()
    End Sub
End Class