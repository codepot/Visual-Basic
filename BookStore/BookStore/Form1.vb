Public Class Form1
    Private TotalQuantityInteger As Integer
    Private TotalDiscountDecimal As Decimal
    Private TotalDiscountedAmountDecimal As Decimal
    Private TotalCountInteger As Integer

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        QuantityTextBox.Clear()
        TitleTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        DiscountTextBox.Clear()
        DiscountedPriceTextBox.Clear()
        QuantityTextBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        Dim QuantityInteger As Integer
        Dim PriceDecimal As Decimal
        Dim ExtendedPriceDecimal As Decimal
        Const DISCOUNT_RATE_SINGLE As Single = 0.15
        Dim DiscountDecimal As Decimal
        Dim DiscountedPriceDecimal As Decimal
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            PriceDecimal = Decimal.Parse(PriceTextBox.Text)
            ExtendedPriceDecimal = QuantityInteger * PriceDecimal
            ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("c2")
            DiscountDecimal = ExtendedPriceDecimal * DISCOUNT_RATE_SINGLE
            DiscountTextBox.Text = DiscountDecimal.ToString("C2")
            DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal
            DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C2")

            'Calculate summary information
            TotalQuantityInteger += QuantityInteger
            TotalBooksTextBox.Text = TotalQuantityInteger.ToString("N0")

            TotalDiscountDecimal += DiscountDecimal
            TotalDiscountTextBox.Text = TotalDiscountDecimal.ToString("C2")

            'complete calculation for discounted amount
            TotalDiscountedAmountDecimal += DiscountedPriceDecimal
            TotalDiscountedAmountTextBox.Text = TotalDiscountedAmountDecimal.ToString("c2")
            TotalCountInteger += 1
            AverageTextBox.Text = (TotalDiscountDecimal / TotalCountInteger).ToString("C2")
        Catch
            MessageBox.Show("please input numbers only", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            QuantityTextBox.Focus()
        End Try
    End Sub

    Private Sub ClearAllButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearAllButton.Click

        ClearButton_Click(sender, e)

        'Clear off 4 textboxes in summary area
        TotalBooksTextBox.Clear()
        TotalDiscountedAmountTextBox.Clear()
        TotalDiscountTextBox.Clear()
        AverageTextBox.Clear()

        'reset all total variables
        TotalQuantityInteger = 0
        TotalDiscountDecimal = 0.0
        TotalDiscountedAmountDecimal = 0.0
        TotalCountInteger = 0

    End Sub
End Class
