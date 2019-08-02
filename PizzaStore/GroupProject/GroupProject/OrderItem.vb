Public Class OrderItem
    Private _NameString As String
    Private _SizeString As String
    Private _IncludedWhippedCreamBoolean As Boolean = False
    Private _PriceDecimal As Decimal
    Private _ToppingList As New List(Of Topping)

    Public Property SizeString() As String
        Get
            Return _SizeString
        End Get
        Set(ByVal value As String)
            _SizeString = value
        End Set
    End Property

    Public Property ToppingList() As List(Of Topping)
        Get
            Return _ToppingList
        End Get
        Set(ByVal value As List(Of Topping))
            _ToppingList = value
        End Set
    End Property


    Public Property NameString() As String
        Get
            Return _NameString
        End Get
        Set(ByVal value As String)
            _NameString = value
        End Set
    End Property

    Public Property IncludedWhippedCreamBoolean() As Boolean
        Get
            Return _IncludedWhippedCreamBoolean
        End Get
        Set(ByVal value As Boolean)
            _IncludedWhippedCreamBoolean = value
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
        Dim NameAndSizeString As String
        Dim PriceString As String = PriceDecimal.ToString("N2")
        If NameString = "Pizza" Then
            'printout for Pizza here
            NameAndSizeString = NameString + "(" + SizeString + "), toppings:"
            acc += FormatString(NameAndSizeString, PriceString)
            For Each item As Topping In ToppingList
                acc += Environment.NewLine + FormatString("    + " + item.NameString, item.PriceDecimal.ToString("N2"))
            Next
            
        Else
            NameAndSizeString = NameString + "(" + SizeString + ")"

            acc += FormatString(NameAndSizeString, PriceString)
            If IncludedWhippedCreamBoolean Then
                acc += Environment.NewLine + FormatString("    + Whipped cream", ValueHelper.WHIPPED_CREAM_PRICE_Decimal.ToString("N2"))
            End If

        End If
        acc += Environment.NewLine + " "
        Return acc
    End Function

    Private Function FormatString(ByVal String1 As String, ByVal String2 As String) As String
        Dim acc As String = ""
        Dim EmptySpaceInteger As Integer = 36 - String1.Length - String2.Length
        acc += String1
        Dim CountInteger As Integer
        For CountInteger = 0 To EmptySpaceInteger
            acc += " "
        Next CountInteger
        acc += String2
        Return acc
    End Function

    'Calculate Price for each order Item (either Pizza or Drink)
    Friend Function CalculatePriceDouble() As Double
        Dim PriceDouble As Double = 0
        PriceDouble += PriceDecimal
        If NameString = "Pizza" Then
            For Each item In ToppingList
                PriceDouble += item.PriceDecimal
            Next
        Else
            If IncludedWhippedCreamBoolean Then
                PriceDouble += ValueHelper.WHIPPED_CREAM_PRICE_Decimal
            End If
        End If
        Return PriceDouble
    End Function

End Class
