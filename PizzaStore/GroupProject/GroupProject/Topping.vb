Public Class Topping
    Private _NameString As String
    Private _PriceDecimal As Decimal

    Public Property NameString() As String
        Get
            Return _NameString
        End Get
        Set(ByVal value As String)
            _NameString = value
        End Set
    End Property

    Public Property PriceDecimal() As Decimal
        Get
            Return _PriceDecimal
        End Get
        Set(ByVal value As Decimal)
            _PriceDecimal = value
        End Set
    End Property

    Public Function PrintOut() As String
        Dim acc As String = ""
        acc += Environment.NewLine + FormatString("    + " + NameString, PriceDecimal.ToString("N2"))
        Return acc
    End Function

    Private Function FormatString(ByVal String1 As String, ByVal String2 As String) As String
        Dim acc As String = ""
        Dim EmptySpaceInteger As Integer = 40 - String1.Length - String2.Length
        acc += String1
        Dim CountInteger As Integer
        For CountInteger = 0 To EmptySpaceInteger
            acc += " "
        Next CountInteger
        acc += String2
        Return acc
    End Function

End Class
