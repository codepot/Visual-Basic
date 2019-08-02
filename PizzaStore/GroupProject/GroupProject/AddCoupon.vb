Public Class AddCoupon

    Private Sub CouponBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CouponBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub AddCoupon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DuMegaDBDataSet.Coupon' table. You can move, or remove it, as needed.
        Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
        DiscountRateComboBox.SelectedIndex = 1
        CouponCodeTextBox.Focus()
    End Sub

    Private Sub CouponCodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouponCodeTextBox.TextChanged
        Dim CodeString As String = CouponCodeTextBox.Text
        Try
            If CodeString.Trim <> "" Then
                Dim PositionInteger As Integer = Me.CouponBindingSource.Find("Coupon_Code", CodeString)
                If CodeString.Trim.Length < 4 Then
                    ErrorPictureBox.Visible = True
                    TickPictureBox.Visible = False
                    MessageLabel.Text = "The code must be at least 4 letters"
                    SubmitButton.Enabled = False
                ElseIf PositionInteger >= 0 Then
                    ErrorPictureBox.Visible = True
                    TickPictureBox.Visible = False
                    MessageLabel.Text = "This code exists in the system"
                    SubmitButton.Enabled = False
                Else
                    ErrorPictureBox.Visible = False
                    TickPictureBox.Visible = True
                    MessageLabel.Text = ""
                    SubmitButton.Enabled = True
                End If
            End If
        Catch
        End Try
    End Sub

   
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        CloseForm()
    End Sub

    Private Sub CloseForm()
       ResetForm()
        Me.Visible = False
        CouponBookForm.Show()
    End Sub

    Private Sub AddCoupon_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            CloseForm()
        End If
    End Sub

    Private Sub ResetForm()
        MessageLabel.Text = ""
        DiscountRateComboBox.SelectedIndex = 1
        ExpiredDateTimePicker.Value = Now
        SubmitButton.Enabled = False
        ErrorPictureBox.Visible = False
        TickPictureBox.Visible = False
        With CouponCodeTextBox
            .Text = ""
            .Focus()
        End With
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ResetForm()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Dim ExpiredDate As Date = ExpiredDateTimePicker.Value
        If ExpiredDate <= Date.Today Then
            MessageBox.Show("Please pick an expired date in the future.")
        Else
            Dim NewDataRowView As DataRowView = CType(CouponBindingSource.AddNew(), DataRowView)
            NewDataRowView("Coupon_Code") = CouponCodeTextBox.Text
            NewDataRowView("Expired_Date") = ExpiredDateTimePicker.Value.ToShortDateString
            Dim RateString As String = DiscountRateComboBox.SelectedItem.ToString
            NewDataRowView("Discount_Rate") = CDec(RateString.Replace("%", "")) / 100
            MessageBox.Show("Coupon " & CouponCodeTextBox.Text & " has just been created")
            persitent()
            Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
            MainWindow.RefreshCoupon()
            CouponBookForm.GetValidCoupons()
            ResetForm()
        End If
    End Sub

    Private Sub persitent()
        Me.Validate()
        Me.CouponBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

   
End Class