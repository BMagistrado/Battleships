Public Class Player
    Dim x As Integer
    Dim y As Integer
    Private playerName As String
    Private playerShips(11, 11) As Boolean
    Private Shipname As String
    Private gridbuttons(99) As GridItem
    Private health As String = 5

    Public Property playergridbuttons As GridItem
        Get
            Return gridbuttons(99)
        End Get
        Set(value As GridItem)
            gridbuttons(99) = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return playerName
        End Get
        Set(value As String)
            playerName = value
        End Set
    End Property

    Public Property Ships(playerx, playery) As Boolean
        Get
            Return playerShips(playerx, playery)
        End Get
        Set(value As Boolean)
            playerShips(playerx, playery) = value

        End Set
    End Property

    Public Property playerx As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            If value > 10 Then
                x = 10
            Else
                x = value
            End If

        End Set
    End Property

    Public Property playery As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            If value > 10 Then
                y = 10
            Else
                y = value
            End If
        End Set
    End Property
End Class
