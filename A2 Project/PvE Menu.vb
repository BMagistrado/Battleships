Public Class PvE_Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Intermediate.Click

    End Sub

    Private Sub btn_MainMenu_Click(sender As Object, e As EventArgs) Handles btn_MainMenu.Click
        My.Forms.MainMenu.Text = Now.ToString
        My.Forms.MainMenu.Show()
        My.Forms.PvE_Menu.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btn_Easy_Click(sender As Object, e As EventArgs) Handles btn_Easy.Click
        'My.Forms.PvEMatchEasy.Text = Now.ToString
        Dim pvematchwindow As New PvEMatchEasy
        pvematchwindow.Text = Now.ToString
        pvematchwindow.Show()
        ' My.Forms.PvEMatchEasy.Show()
        My.Forms.PvE_Menu.Hide()
    End Sub
End Class