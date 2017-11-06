Public Class PvEMatchEasy
    'Version 0.1, a working UI:
    'KEY: * = completed, SS# = screenshot number
    'edit1: change number of squares in grid from 15x15 to 10x10, mention that 10x10 is a good middle ground between 5x5 and 15x15 which you have already
    'tested. SS: 1
    'edit2: removed lines 26 to 30 as it was used just to test if the grid had spawned. SS:2
    'future edit:* Make another 10x10 grid to show the AI's battlefield, show no outputs if user clicks on their own battlefield. *
    'edit3: split one shared screen into two interchangable forms as program could not process 200 buttons on one form window. SS: 3
    Private Sub PvEMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loopcounter As Integer = 0
        Dim loopcounterAI As Integer = 0
        Dim x, y, sizeX, sizeY, nameX, nameY As String
        Dim buttons As New List(Of ButtonState)
        Dim Array(120) As Button 'logic error, put in 225 instead of 224, did not account for 0 as the start,

        x = 0
        y = 0
        sizeX = 30
        sizeY = 30
        nameX = 0
        nameY = 0

        'buttons.Add()

        Do
            Array(loopcounter) = New Button
            Array(loopcounter).Parent = Me
            Array(loopcounter).Name = "X: " & nameX & "Y: " & nameY
            Array(loopcounter).SetBounds(x, y, sizeX, sizeY)
            Array(loopcounter).Text = ""
            x = x + 30

            If x = 300 Then
                nameY += 1
                nameX = 0
                y += 30
                x = 0
            End If
            loopcounter += 1
        Loop Until loopcounter = 100

        'Drawgrid()
        Dim loopcounter As Integer = 0
        Dim loopcounterAI As Integer = 0
        Dim x, y, sizeX, sizeY, nameX, nameY As String
        Dim Array(99) As Button 'logic error, put in 225 instead of 224, did not account for 0 as the start,
        'produced an extra button
        Dim AIArray(99) As Button
        x = 0
        y = 0
        AIx = 600
        AIy = 0
        sizeX = 30
        sizeY = 30
        AInameX = 0
        AInameY = 0
        nameX = 0
        nameY = 0
        Do
        'Array(loopcounter) = New Button
        'Array(loopcounter).Parent = Me
        'Array(loopcounter).Name = "X: " & nameX & "Y: " & nameY
        'Array(loopcounter).SetBounds(x, y, sizeX, sizeY)
        'Array(loopcounter).Text = ""
        'x = x + 30
        '
        'If x = 300 Then
        'nameY += 1
        'nameX = 0
        'y += 30
        'x = 0
        'End If
        'Loop Until loopcounter = 100

        'Do
        'AIArray(loopcounterAI) = New Button
        'AIArray(loopcounterAI).Parent = Me
        'AIArray(loopcounterAI).Name = “X: “ & AInameX & “Y: “ & AInameY
        'AIArray(loopcounterAI).SetBounds(AIx, AIy, sizeX, sizeY)
        'AIArray(loopcounterAI).Text = ""
        'AInameX = AInameX + 1
        'loopcounterAI = loopcounterAI + 1
        'AIx = AIx + 30
        'If loopcounter = 225 Then
        'btn_Start.Visible = False

        'Exit Do
        'End If

        'If AIx = 900 Then 'changed from If nameX = 15 to x = 450 (15*30, space between 15 buttons) essetially the same thing
        '        AInameY += 1
        '   AInameX = 0
        '  AIy += 30
        ' AIx = 600
        'End If
        'Loop Until loopcounterAI = 100



    End Sub
    Private Sub Drawgrid()
        Dim loopcounter As Integer = 0
        Dim loopcounterAI As Integer = 0
        Dim x, y, sizeX, sizeY, nameX, nameY As String
        Dim Array(99) As Button 'logic error, put in 225 instead of 224, did not account for 0 as the start,


        x = 0
        y = 0
        sizeX = 30
        sizeY = 30
        nameX = 0
        nameY = 0

        Do
            Array(loopcounter) = New Button
            Array(loopcounter).Parent = Me
            Array(loopcounter).Name = "X: " & nameX & "Y: " & nameY
            Array(loopcounter).SetBounds(x, y, sizeX, sizeY)
            Array(loopcounter).Text = ""
            x = x + 30

            If x = 300 Then
                nameY += 1
                nameX = 0
                y += 30
                x = 0
            End If
        Loop Until loopcounter = 100
    End Sub


End Class