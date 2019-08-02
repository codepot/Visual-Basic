Public Class ReportSalesForEmployee
    Private TransactionNumberInteger As Integer = 0
    Private Sub ReportSalesForEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DuMegaDBDataSet.TodaySales' table. You can move, or remove it, as needed.
        RefreshForm()
        CloseButton.Focus()
    End Sub

    Friend Sub RefreshForm()
        TransactionNumberInteger = 0
        Me.TodaySalesTableAdapter.Fill(Me.DuMegaDBDataSet.TodaySales)
        TodayLabel.Text = Now.ToShortDateString
        EmployeeIdLabel.Text = "#" + MainWindow.UserIdInteger.ToString("N0")
        EmployeeNameLabel.Text = (MainWindow.UserLastName + ", " + MainWindow.UserFirstName).ToUpper()
        Dim SalesTotalDecimal As Decimal = CalculateTotalSale()
        SalesLabel.Text = SalesTotalDecimal.ToString("C2")
        NumberOfTransactionLabel.Text = TransactionNumberInteger.ToString("N0")
    End Sub

    Private Function CalculateTotalSale() As Decimal
        Dim UserIdInteger As Integer = MainWindow.UserIdInteger
        Dim TotalDecimal As Decimal = 0.0
        For Each drRow As DataRow In DuMegaDBDataSet.TodaySales
            If CInt(drRow.Item("User_ID")) = UserIdInteger Then
                TotalDecimal += CDec(drRow.Item("Invoice_Amount"))
                TransactionNumberInteger += 1
            End If
        Next
        Return TotalDecimal
    End Function

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Visible = False
        MainWindow.Show()
    End Sub

    Private Sub ReportSalesForEmployee_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Visible = False
            MainWindow.Show()
        End If
    End Sub
End Class