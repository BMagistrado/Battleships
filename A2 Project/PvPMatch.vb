﻿Public Class PvPMatch
    Private player1 As New Player
    Private player2 As New Player


    Private player1grid(10, 10) As Boolean
    Private player2grid(10, 10) As Boolean
    Private Sub PvPMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1 = New Player
        player2 = New Player
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        btn_Start.Hide()
        btn_P1Enter.Hide()
        lbl_P1Username.Hide()
        lbl_Playerships.Hide()
        txtbox_playerships.Hide()
        txtbox_Username.Hide()

        Dim loopcounter As Integer = 0
        Dim sizeX, sizeY, nameX, nameY As String
        Dim x, y As Integer
        Dim Array(99) As GridItem
        x = 0
        y = 0
        sizeX = 30
        sizeY = 30
        nameX = 1
        nameY = 1

        'For Each griditemelement As GridItem In Array
        'griditemelement = New GridItem
        'Next

        Do
            Array(loopcounter) = New GridItem
            Array(loopcounter).gridx = nameX
            Array(loopcounter).gridy = nameY
            Array(loopcounter).Parent = Me
            Array(loopcounter).Name = nameX & "," & nameY
            Array(loopcounter).SetBounds(x, y, sizeX, sizeY)
            Array(loopcounter).Text = Array(loopcounter).Name
            If player1.Ships(nameX, nameY) Then
                Array(loopcounter).Text = "O"
            End If
            nameX = nameX + 1
            loopcounter = loopcounter + 1
            x = x + 30
            If loopcounter = 100 Then
                btn_Start.Visible = False

                Exit Do
            End If

            If nameX = 11 Then
                nameY += 1
                nameX = 1
                y += 30
                x = 0
            End If
        Loop While loopcounter <= 225

        'Dim player1 As New Player
        Dim transferloop1 As Integer = 0
        Dim transferloop2 As Integer = 0

        'Do
        'If Array(transferloop2).gridx = player1.Ships(transferloop2, transferloop2) Then
        'Array(transferloop2).Text = "O"
        'transferloop1 += 1
        'End If
        'transferloop2 += 1
        'Loop Until transferloop2 = 9
    End Sub

    Private Sub btn_P1Enter_Click(sender As Object, e As EventArgs) Handles btn_P1Enter.Click

        player1.Name = txtbox_Username.Text
        'MsgBox("Your username is " & Player1.Name)
        Dim shipcounterx As Integer = 0
        Dim shipcountery As Integer = 0
        'Player1.Ships(Player1.playerx, Player1.playery) = txtbox_playerships.Text
        'Do

        If txtbox_Username.Text = "testuser" Then
            ''Do
            'player1.Ships(shipcounterx, shipcountery) = player1.Ships(shipcounterx, shipcountery)
            'shipcounterx += 1
            'shipcountery += 1
            'Loop Until shipcounterx = 10
            For y As Integer = 0 To 10
                player1.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
                player2.Ships(CInt(Math.Ceiling(Rnd() * 10)), CInt(Math.Ceiling(Rnd() * 10))) = True
            Next
        Else
            player1.Ships(player1.playerx, player1.playery) = txtbox_playerships.Text
        End If



        'MsgBox("Your ships are: " & Player1.Ships(shipcounterx, shipcountery))


    End Sub


End Class