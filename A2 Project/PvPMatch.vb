Public Class PvPMatch
    Private player1 As New Player
    Private player2 As New Player
    Dim playerturn As Integer = 0 'will be used to keep track of the whos turn it is.


    Private player1grid(10, 10) As Boolean
    Private player2grid(10, 10) As Boolean
    Private Sub PvPMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1 = New Player
        player2 = New Player
    End Sub
    Private Sub Butt_click(sender As System.Object, e As System.EventArgs)
        If TypeOf sender Is Button Then
            MsgBox(CType(sender, Button).Name)
        End If

        playerturn = playerturn Mod 2

    End Sub
    Private Sub PvPMatch()



    End Sub

    Private Sub GridGenerator(ByRef xtostart As Integer, ByRef TargetPlayer As Player)
        Btn_Start.Visible = False
        Dim loopcounter As Integer = 0
        Dim sizeX, sizeY, nameX, nameY As String
        Dim y As Integer
        Dim Array(99) As GridItem
        Dim xtostartinitial = xtostart
        y = 0
        sizeX = 30
        sizeY = 30
        nameX = 0
        nameY = 0

        For Each griditemelement As GridItem In Array
            griditemelement = New GridItem
            griditemelement.gridx = nameX
            griditemelement.gridy = nameY
            griditemelement.Parent = Me
            griditemelement.Name = nameX & "," & nameY
            griditemelement.SetBounds(xtostart, y, sizeX, sizeY)
            griditemelement.Text = griditemelement.Name

            nameX = nameX + 1
            loopcounter = loopcounter + 1
            xtostart = xtostart + 30

            If loopcounter Mod 10.0 = 0 And loopcounter <> 0 Then 'MOD operator returns remainder of loopcounter/10 to check if it is at the last button
                nameY += 1
                nameX = 0
                y += 30
                xtostart = xtostartinitial
            End If
            If TargetPlayer.Ships(nameX, nameY) Then
                griditemelement.Text = "O"
            End If
        Next
        PvPMatch()

    End Sub
    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Btn_Start.Hide()
        Btn_P1Enter.Hide()
        lbl_P1Username.Hide()
        lbl_Playerships.Hide()
        txtbox_playerships.Hide()
        txtbox_Username.Hide()
        'For y As Integer = 0 To 9
        ' player1.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
        'player2.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
        ' Next
        Dim r As New Random
        For y As Integer = 0 To 9
            player1.Ships(r.Next(0, 9), r.Next(0, 9)) = True
            player2.Ships(r.Next(0, 9), r.Next(0, 9)) = True
        Next
        GridGenerator(0, player1)
        GridGenerator(600, player2)

    End Sub

    Private Sub Btn_P1Enter_Click(sender As Object, e As EventArgs) Handles Btn_P1Enter.Click
        'player1.Name = "testuser"
        player1.Name = txtbox_Username.Text
        'MsgBox("Your username is " & Player1.Name)
        Dim shipcounterx As Integer = 0
        Dim shipcountery As Integer = 0
        'Player1.Ships(Player1.playerx, Player1.playery) = txtbox_playerships.Text
        'Do

        Dim r As Random = New Random
        For y As Integer = 0 To 9
            player1.Ships(r.Next(1, 10), r.Next(1, 10)) = True
            player2.Ships(r.Next(1, 10), r.Next(1, 10)) = True
        Next





        If txtbox_Username.Text = "" Then
            ''Do
            'player1.Ships(shipcounterx, shipcountery) = player1.Ships(shipcounterx, shipcountery)
            'shipcounterx += 1
            'shipcountery += 1
            'Loop Until shipcounterx = 10
            For y As Integer = 0 To 9
                player1.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
                player2.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
            Next
        Else
            player1.Ships(player1.playerx, player1.playery) = txtbox_playerships.Text
        End If



        'MsgBox("Your ships are: " & Player1.Ships(shipcounterx, shipcountery))


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class