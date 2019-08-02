Public Class MainWindow
    Friend UserIdInteger As Integer = 3
    Friend UserFirstName As String = ""
    Friend UserLastName As String = ""
    Private SpecialDiscountRate As Single = 0.0
    Private OrderIdString As String = 0
    Private OrderItemList As New List(Of OrderItem)
    Friend UserRoleString As String = "Employee"

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InvoiceTableAdapter.Fill(Me.DuMegaDBDataSet.Invoice)
        Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
        CustomizedView()
    End Sub

    'customized OrderListBox 1/3, user Environment.NewLine for a multiple line entry
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        OrderListBox.DrawMode = DrawMode.OwnerDrawVariable
        MyBase.OnLoad(e)
    End Sub

    'customized OrderListBox 2/3
    Private Sub OrderListBox_MeasureItem(ByVal sender As Object, ByVal e As MeasureItemEventArgs) Handles OrderListBox.MeasureItem
        e.ItemHeight = e.Graphics.MeasureString(OrderListBox.Items(e.Index).ToString, OrderListBox.Font).Height
    End Sub

    'customized OrderListBox 3/3
    Private Sub OrderListBox_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles OrderListBox.DrawItem
        e.DrawBackground()
        If e.Index >= 0 Then
            e.Graphics.DrawString(OrderListBox.Items(e.Index).ToString, OrderListBox.Font, Brushes.Black, e.Bounds)
        End If
    End Sub

    Friend Sub RefreshCoupon()
        Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
    End Sub

    

    Private Sub AddPizzaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPizzaButton.Click
        If CountToppingInteger() >= 3 Then
            Dim PizzaOrderItem As New OrderItem()
            Dim ToppingList As New List(Of Topping)
            Dim ToppingItem As New Topping()
            PizzaOrderItem.NameString = "Pizza"
            If SmallSizePizzaRadioButton.Checked Then
                PizzaOrderItem.SizeString = "SML"
                PizzaOrderItem.PriceDecimal = ValueHelper.PIZZA_SML_PRICE_Decimal
            ElseIf MediumSizePizzaRadioButton.Checked Then
                PizzaOrderItem.SizeString = "MED"
                PizzaOrderItem.PriceDecimal = ValueHelper.PIZZA_MED_PRICE_Decimal
            Else
                PizzaOrderItem.SizeString = "LRG"
                PizzaOrderItem.PriceDecimal = ValueHelper.PIZZA_LRG_PRICE_Decimal
            End If
            If FlambeeCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Flambee"
                ToppingItem.PriceDecimal = ValueHelper.FLAMBEE_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If

            If PepperoniCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Pepperoni"
                ToppingItem.PriceDecimal = ValueHelper.PEPPERONI_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If

            If ItalianSauceCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Italian Sauce"
                ToppingItem.PriceDecimal = ValueHelper.ITALIAN_SAUCE_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If SausageCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Sausage"
                ToppingItem.PriceDecimal = ValueHelper.SAUSAGE_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If BaconCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Bacon"
                ToppingItem.PriceDecimal = ValueHelper.BACON_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If OnionCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Onion"
                ToppingItem.PriceDecimal = ValueHelper.ONION_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If GreenPepperCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Green Pepper"
                ToppingItem.PriceDecimal = ValueHelper.GREEN_PEPPER_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If PineappleCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Pineapple"
                ToppingItem.PriceDecimal = ValueHelper.PINEAPPLE_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If MushroomCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Mushroom"
                ToppingItem.PriceDecimal = ValueHelper.MUSHROOM_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            If OliveCheckBox.Checked Then
                ToppingItem = New Topping()
                ToppingItem.NameString = "Olive"
                ToppingItem.PriceDecimal = ValueHelper.OLIVE_PRICE_Decimal
                ToppingList.Add(ToppingItem)
            End If
            PizzaOrderItem.ToppingList = ToppingList
            OrderItemList.Insert(0, PizzaOrderItem)
            OrderListBox.Items.Clear()
            For Each item As OrderItem In OrderItemList
                OrderListBox.Items.Add(item.PrintOut())
            Next
            NoneCokeRadioButton.Select()
            NoneBerrySmoothyRadioButton.Select()
            NoneBerrySmoothyRadioButton.Select()
        Else
            MessageBox.Show("Please select at least 3 toppings.")
        End If

        UpdateBottomLines()
    End Sub

    Private Sub AddDrinkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDrinkButton.Click
        If NoneCokeRadioButton.Checked = True And NoneBerrySmoothyRadioButton.Checked And NoneMochaMixRadioButton.Checked Then
            MessageBox.Show("Please select a drink.", "No drink is selected")
        Else
            Dim DrinkOrderItem As New OrderItem()
            'Coke adding
            If Not NoneCokeRadioButton.Checked Then
                DrinkOrderItem.NameString = "Coke"
                If RegularCokeRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "REG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.COKE_REG_PRICE_Decimal
                ElseIf LargeCokeRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "LRG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.COKE_LRG_PRICE_Decimal
                End If
                OrderItemList.Insert(0, DrinkOrderItem)
            End If
            'Berry Smoothy adding
            If Not NoneBerrySmoothyRadioButton.Checked Then
                DrinkOrderItem = New OrderItem()
                DrinkOrderItem.NameString = "Berry Smoothy"
                If RegularBerrySmoothyRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "REG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.BERRY_SMOOTHIE_REG_PRICE_Decimal
                ElseIf LargeBerrySmoothyRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "LRG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.BERRY_SMOOTHIE_LRG_PRICE_Decimal
                End If
                'OrderItemList.Add(DrinkOrderItem)
                OrderItemList.Insert(0, DrinkOrderItem)
            End If
            'Berry Smoothy adding
            If Not NoneMochaMixRadioButton.Checked Then
                DrinkOrderItem = New OrderItem()
                DrinkOrderItem.NameString = "Mocha Mix"
                If RegularMochaMixRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "REG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.MOCHA_MIX_REG_PRICE_Decimal
                ElseIf LargeMochaMixRadioButton.Checked Then
                    DrinkOrderItem.SizeString = "LRG"
                    DrinkOrderItem.PriceDecimal = ValueHelper.MOCHA_MIX_LRG_PRICE_Decimal
                End If
                DrinkOrderItem.IncludedWhippedCreamBoolean = WhippedCreamCheckBox.Checked
                'OrderItemList.Add(DrinkOrderItem)
                OrderItemList.Insert(0, DrinkOrderItem)
            End If
            OrderListBox.Items.Clear()
            For Each item As OrderItem In OrderItemList
                OrderListBox.Items.Add(item.PrintOut())
            Next
            NoneCokeRadioButton.Select()
            NoneBerrySmoothyRadioButton.Select()
            NoneMochaMixRadioButton.Select()
            UpdateBottomLines()
        End If
    End Sub

    Private Sub NoneMochaMixRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneMochaMixRadioButton.CheckedChanged
        WhippedCreamCheckBox.Checked = False
        WhippedCreamCheckBox.Visible = Not NoneMochaMixRadioButton.Checked
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Dim SelectedIndex As Integer = OrderListBox.SelectedIndex
        If SelectedIndex >= 0 Then
            OrderItemList.RemoveAt(SelectedIndex)
            OrderListBox.Items.Clear()
            For Each item As OrderItem In OrderItemList
                OrderListBox.Items.Add(item.PrintOut())
            Next
        End If
        UpdateBottomLines()
    End Sub

    Private Sub PlaceOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaceOrderButton.Click
        If CDec(TotalLabel.Text) > 0 Then
            Dim NewDataRowView As DataRowView = CType(InvoiceBindingSource.AddNew(), DataRowView)
            NewDataRowView("Invoice_Amount") = CDec(TotalLabel.Text).ToString
            NewDataRowView("Invoice_Date") = Now.ToShortDateString
            NewDataRowView("User_ID") = UserIdInteger.ToString
            persitent()
            Me.InvoiceTableAdapter.Fill(Me.DuMegaDBDataSet.Invoice)
            InvoiceBindingSource.MoveLast()
            OrderIdString = InvoiceBindingSource.Current("Invoice_ID")
            'PRINT OUT RECEIPT AND ORDER
            OrderPrintPreviewDialog.Document = OrderPrintDocument
            OrderPrintPreviewDialog.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            OrderPrintPreviewDialog.ShowDialog()
            'CLEAR LISTBOX AND ORDERITEM LIST
            ResetAll()
            'Refresh the report for manager
            ReportForm.LoadDatabase()
        Else
            MessageBox.Show("Incomple Order, please add item(s)")
        End If

    End Sub

    Private Sub persitent()
        Me.Validate()
        Me.InvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub PrintReceipt(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles OrderPrintDocument.PrintPage
        Dim PrintFont As New Font("Consolas", 18, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim PrintLineString As String = "    PIZZA DU MEGA"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        PrintFont = New Font("Consolas", 10)
        LineHeightSingle = PrintFont.GetHeight + 2
        VerticalPrintLocationSingle += LineHeightSingle + 6
        PrintLineString = "-------------------------------------" + Environment.NewLine
        PrintLineString += "   Order ID: " + OrderIdString + " at " + Now.ToString("MM/dd/yyyy HH:mm")
        PrintLineString += Environment.NewLine + "-------------------------------------"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 3 + 4
        For Each OrderItem In OrderItemList
            PrintLineString = OrderItem.PrintOut()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += (LineHeightSingle - 1) * CountLines(PrintLineString) + 2
        Next
        VerticalPrintLocationSingle -= (LineHeightSingle + 10)
        PrintLineString = "                            _________"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = JustifyRight(36, "Subtotal: " & SubTotalLabel.Text)
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = JustifyRight(36, "Discount: " & DiscountLabel.Text.Replace("$", ""))
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = JustifyRight(36, "Tax: " & TaxLabel.Text.Replace("$", ""))
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = JustifyRight(36, "Total: " & TotalLabel.Text)
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
    End Sub

    Private Function CountToppingInteger() As Integer
        Dim ToppingNumInteger As Integer = 0

        If FlambeeCheckBox.Checked Then
            ToppingNumInteger += 1
        End If

        If PepperoniCheckBox.Checked Then
            ToppingNumInteger += 1
        End If

        If ItalianSauceCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If SausageCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If BaconCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If OnionCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If GreenPepperCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If PineappleCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If MushroomCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        If OliveCheckBox.Checked Then
            ToppingNumInteger += 1
        End If
        Return ToppingNumInteger
    End Function

    Private Function CalculateSubTotal() As Decimal
        Dim SubTotalDecimal As Decimal = 0
        For Each item In OrderItemList
            SubTotalDecimal += item.CalculatePriceDouble()
        Next
        Return SubTotalDecimal
    End Function

    Private Sub UpdateBottomLines()
        Dim subTotal As Decimal = CalculateSubTotal()
        Dim DiscountDecimal As Decimal = CalculateDiscount(subTotal)
        Dim tax As Decimal = (subTotal - DiscountDecimal) * ValueHelper.TAX_RATE_Single
        SubTotalLabel.Text = subTotal.ToString("C2")
        DiscountLabel.Text = DiscountDecimal.ToString("C2")
        TaxLabel.Text = tax.ToString("C2")
        TotalLabel.Text = (subTotal + tax - DiscountDecimal).ToString("C2")
    End Sub

    Private Function CalculateDiscount(ByVal Amount As Decimal) As Decimal
        Dim DiscountDecimal = SpecialDiscountRate * Amount
        Return DiscountDecimal
    End Function

    Private Sub ResetAll()
        ResetToppings()
        NoneCokeRadioButton.Select()
        NoneBerrySmoothyRadioButton.Select()
        NoneMochaMixRadioButton.Select()
        OrderItemList.Clear()
        OrderListBox.Items.Clear()
        UpdateBottomLines()
        SpecialDiscountRate = 0.0
        CouponTextBox.Clear()
        RemoveCouponLinkLabel.Visible = False
    End Sub

    Private Sub CheckCouponButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCouponButton.Click
        If OrderListBox.Items.Count = 0 Then
            MessageBox.Show("Please fill order before apply coupon.")
        Else

            Dim CouponCode As String = CouponTextBox.Text.Trim
            If CouponCode = "" Or CouponCode.Length < 4 Then
                MessageBox.Show("Invalid coupon code")
            Else
                Dim DiscountRateSingle As Single = GetCouponDiscountRate(CouponCode)
                If DiscountRateSingle = 0.0 Then
                    MessageBox.Show("Unreal Coupon Code")
                Else
                    'Check coupon expiration
                    Dim PositionInteger As Integer = Me.CouponBindingSource.Find("Coupon_Code", CouponCode)
                    CouponBindingSource.Position = PositionInteger
                    Dim CouponItem As DataRowView = CouponBindingSource.Current
                    Dim ExpirationDate As Date = Date.Parse(CouponItem.Row("Expired_Date"))
                    If Date.Compare(ExpirationDate, Date.Today) >= 0 Then
                        SpecialDiscountRate = DiscountRateSingle
                        UpdateBottomLines()
                        CouponTextBox.Clear()
                        RemoveCouponLinkLabel.Visible = True
                    Else
                        MessageBox.Show("Coupon " & CouponCode & " expired on " & ExpirationDate.ToShortDateString)
                        CouponTextBox.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function GetCouponDiscountRate(ByVal CouponCode As String) As Single
        For Each drRow As DataRow In DuMegaDBDataSet.Coupon
            Dim CouponCodeInDB As String = drRow.Item("Coupon_Code").ToString
            If CouponCode = CouponCodeInDB Then
                Return Single.Parse(drRow.Item("Discount_Rate").ToString)
                Exit For
            End If
        Next
        Return 0.0
    End Function

    Private Sub CouponBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CouponBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Logout()
    End Sub

    Private Sub Logout()
        CenterForm(LoginForm)
        CenterForm(CouponBookForm)
        CenterForm(AddCoupon)
        CenterForm(CustomerRegistrationForm)
        CenterForm(Me)
        CenterForm(AboutDuMegaBox)
        CenterForm(ReportForm)
        CenterForm(UserEditingForm)
        CenterForm(ReportSalesForEmployee)
        UserIdInteger = 0
        LoginForm.Show()
        ResetAll()
        Visible = False
        UserRoleString = "Customer"
    End Sub

    'SOME HELPER METHOD
    Private Function CountLines(ByVal s As String) As Integer
        Dim count As Integer = If(Not s Is Nothing, s.Split(New String() {Environment.NewLine}, StringSplitOptions.None).Length, 0)
        Return count
    End Function

    Private Sub RemoveCouponLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RemoveCouponLinkLabel.LinkClicked
        SpecialDiscountRate = 0.0
        RemoveCouponLinkLabel.Visible = False
        UpdateBottomLines()
    End Sub


    Friend Function JustifyRight(ByVal RowWide As Integer, ByVal TextValue As String) As String
        Dim acc As String = ""
        Dim EmptySpaceInteger As Integer = RowWide - TextValue.Length
        Dim CountInteger As Integer
        For CountInteger = 0 To EmptySpaceInteger
            acc += " "
        Next CountInteger
        acc += TextValue
        Return acc
    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim ExitDialogResult As DialogResult
        'Manager has the right to exit the program
        ExitDialogResult = MessageBox.Show("Do you want to close the program?", "Exit confirmation",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ExitDialogResult = Windows.Forms.DialogResult.Yes Then
            ReportForm.SalesReportViewer.Dispose()
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
        Me.Visible = False
        CenterForm(UserEditingForm)
        UserEditingForm.Show()
    End Sub


    Private Sub CenterForm(ByVal aForm As Form)
        aForm.Left = (Screen.PrimaryScreen.WorkingArea.Width - aForm.Width) / 2
        aForm.Top = (Screen.PrimaryScreen.WorkingArea.Height - aForm.Height) / 2
    End Sub

    Private Sub CouponToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouponToolStripMenuItem.Click
        Me.Visible = False
        CouponBookForm.Show()
    End Sub

    Private Sub SaleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReportToolStripMenuItem.Click
        Me.Visible = False
        If UserRoleString = "Manager" Then
            ReportForm.SalesReportViewer.RefreshReport()
            ReportForm.Show()
        Else
            ReportSalesForEmployee.RefreshForm()
            ReportSalesForEmployee.ShowDialog()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutDuMegaBox.ShowDialog()
    End Sub

    Private Sub MainWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim ExitDialogResult As DialogResult
            'Log out if Role is either employee or customer
            If UserRoleString = "Employee" Or UserRoleString = "Customer" Then
                ExitDialogResult = MessageBox.Show("Do you want to sign out?", "Sign out confirmation",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ExitDialogResult = Windows.Forms.DialogResult.Yes Then
                    Logout()
                End If
            Else
                'Manager has the right to exit the program
                ExitDialogResult = MessageBox.Show("Do you want to close the program?", "Exit confirmation",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ExitDialogResult = Windows.Forms.DialogResult.Yes Then
                    ReportForm.SalesReportViewer.Dispose()
                    Me.Dispose()
                    End
                End If
            End If
        End If
    End Sub

    Friend Sub CustomizedView()
        If UserRoleString = "Customer" Then
            EditToolStripMenuItem.Visible = False
            ExitToolStripMenuItem.Visible = False
        ElseIf UserRoleString = "Employee" Then
            EditToolStripMenuItem.Visible = True
            CouponToolStripMenuItem.Visible = False
            CreateUserToolStripMenuItem.Visible = False
            ExitToolStripMenuItem.Visible = False
        Else
            EditToolStripMenuItem.Visible = True
            CouponToolStripMenuItem.Visible = True
            CreateUserToolStripMenuItem.Visible = True
            ExitToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ResetToppings()
        SmallSizePizzaRadioButton.Select()
        FlambeeCheckBox.Checked = False
        PepperoniCheckBox.Checked = False
        ItalianSauceCheckBox.Checked = False
        SausageCheckBox.Checked = False
        BaconCheckBox.Checked = False
        OnionCheckBox.Checked = False
        GreenPepperCheckBox.Checked = False
        PineappleCheckBox.Checked = False
        MushroomCheckBox.Checked = False
        OliveCheckBox.Checked = False
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        ResetToppings()
    End Sub
End Class
