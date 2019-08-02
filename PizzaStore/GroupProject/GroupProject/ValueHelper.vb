Public Class ValueHelper

    Public Const TAX_RATE_Single As Single = 0.075

    'Price for Drinks
    Public Const COKE_REG_PRICE_Decimal As Decimal = 1.5
    Public Const COKE_LRG_PRICE_Decimal As Decimal = 2.25
    Public Const BERRY_SMOOTHIE_REG_PRICE_Decimal As Decimal = 2.5
    Public Const BERRY_SMOOTHIE_LRG_PRICE_Decimal As Decimal = 3.25
    Public Const MOCHA_MIX_REG_PRICE_Decimal As Decimal = 2.75
    Public Const MOCHA_MIX_LRG_PRICE_Decimal As Decimal = 3.25
    Public Const WHIPPED_CREAM_PRICE_Decimal As Decimal = 0.75

    'Price for Pizza
    Public Const PIZZA_SML_PRICE_Decimal As Decimal = 5.5
    Public Const PIZZA_MED_PRICE_Decimal As Decimal = 8.0
    Public Const PIZZA_LRG_PRICE_Decimal As Decimal = 10.0

    'Price for Toppings
    Public Const FLAMBEE_PRICE_Decimal As Decimal = 1.75
    Public Const PEPPERONI_PRICE_Decimal As Decimal = 1.25
    Public Const ITALIAN_SAUCE_PRICE_Decimal As Decimal = 1.5
    Public Const SAUSAGE_PRICE_Decimal As Decimal = 1.25
    Public Const BACON_PRICE_Decimal As Decimal = 1.25
    Public Const ONION_PRICE_Decimal As Decimal = 0.75
    Public Const GREEN_PEPPER_PRICE_Decimal As Decimal = 0.75
    Public Const PINEAPPLE_PRICE_Decimal As Decimal = 1.0
    Public Const MUSHROOM_PRICE_Decimal As Decimal = 1.0
    Public Const OLIVE_PRICE_Decimal As Decimal = 1.5

    Public Function JustifyRight(ByVal RowWide As Integer, ByVal TextValue As String) As String
        Dim acc As String = ""
        Dim EmptySpaceInteger As Integer = 32 - TextValue.Length
        Dim CountInteger As Integer
        For CountInteger = 0 To EmptySpaceInteger
            acc += " "
        Next CountInteger
        acc += TextValue
        Return acc
    End Function

    Public Function CountLines(ByVal s As String) As Integer
        Dim count As Integer = If(Not s Is Nothing, s.Split(New String() {Environment.NewLine}, StringSplitOptions.None).Length, 0)
        Return count
    End Function

End Class
