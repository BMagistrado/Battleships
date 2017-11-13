Public Class Player
    Dim x As Integer
    Dim y As Integer
    Private playerName As String
    Private playerShips(x, y) As Integer

    Public Property Name() As String
        Get
            Return playerName
        End Get
        Set(value As String)
            playerName = value
        End Set
    End Property

    Public Property Ships(x, y) As Integer
        Get
            Return playerShips(x, y)
        End Get
        Set(value As Integer)
            playerShips(x, y) = value

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
