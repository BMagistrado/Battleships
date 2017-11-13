Public Class PvPMatch
    Private Sub PvPMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Player1 As New Player
        Dim Player2 As New Player





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click

        Dim loopcounter As Integer = 0
        Dim x, y, sizeX, sizeY, nameX, nameY As String
        Dim Array(99) As Button
        x = 0
        y = 0
        sizeX = 30
        sizeY = 30
        nameX = 0
        nameY = 0

        Do
            Array(loopcounter) = New Button
            Array(loopcounter).Parent = Me
            Array(loopcounter).Name = “X: “ & nameX & “Y: “ & nameY
            Array(loopcounter).SetBounds(x, y, sizeX, sizeY)
            Array(loopcounter).Text = ""
            nameX = nameX + 1
            loopcounter = loopcounter + 1
            x = x + 30
            If loopcounter = 100 Then
                btn_Start.Visible = False

                Exit Do
            End If

            If nameX = 10 Then
                nameY += 1
                nameX = 0
                y += 30
                x = 0
            End If
        Loop While loopcounter <= 225

    End Sub

    Private Sub btn_P1Enter_Click(sender As Object, e As EventArgs) Handles btn_P1Enter.Click
        Dim Player1 As New Player
        Player1.Name = txtbox_Username.Text
        'MsgBox("Your username is " & Player1.Name)

        Player1.Ships(Player1.playerx, Player1.playery) = TextBox1.Text

    End Sub

End Class