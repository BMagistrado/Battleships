Public Class MainMenu
    Private Sub btn_PvE_Click(sender As Object, e As EventArgs) Handles btn_PvE.Click
        My.Forms.PvE_Menu.Text = Now.ToString
        My.Forms.PvE_Menu.Show()
        My.Forms.MainMenu.Hide()

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_PvPMode_Click(sender As Object, e As EventArgs) Handles btn_PvPMode.Click
        My.Forms.PvPMenu.Text = Now.ToString
        My.Forms.PvPMenu.Show()
        My.Forms.MainMenu.Hide()
    End Sub
End Class