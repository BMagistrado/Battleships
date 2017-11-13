Public Class Ship
    Public Property shipX As Integer

    Public Property shipY As Integer

    Enum shipsizes As Byte
        shipsmall = 2
        shipmedium = 4
        shiplarge = 6


    End Enum


    Public Property shipsize As shipsizes
    Public Property health As Integer

    Public Sub New(newshipsize As shipsizes)
        shipsize = newshipsize

        health = newshipsize / 2

    End Sub

End Class
