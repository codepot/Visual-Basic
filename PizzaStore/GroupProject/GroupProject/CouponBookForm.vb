Public Class CouponBookForm

    Private Sub CouponBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CouponBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)

    End Sub

    Private Sub CouponEditingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DuMegaDBDataSet.Coupon' table. You can move, or remove it, as needed.

        GetValidCoupons()
    End Sub


    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        MainWindow.Show()
    End Sub

   

    Friend Sub GetValidCoupons()
        Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
        ValidCouponListBox.Items.Clear()
        For Each drRow As DataRow In DuMegaDBDataSet.Coupon
            If drRow("Expired_Date") >= Date.Today Then
                Dim CouponItemString As String = FormatCouponItem(drRow.Item("Coupon_Code"), (CDec(drRow.Item("Discount_Rate")) * 100).ToString("N0") + "%")
                ValidCouponListBox.Items.Add(CouponItemString & " ............ " & DateValue(drRow.Item("Expired_Date")).ToString("MM/dd/yyyy"))

            End If
        Next
    End Sub


    Private Function FormatCouponItem(ByVal CouponCode As String, ByVal DiscountRate As String) As String
        Dim acc As String = CouponCode + " "
        Dim EmptySpaceInteger As Integer = 18 - CouponCode.Length - DiscountRate.Length
        Dim CountInteger As Integer
        For CountInteger = 0 To EmptySpaceInteger
            acc += "."
        Next CountInteger
        acc += " " + DiscountRate
        Return acc
    End Function



   
    Private Sub RemoveCouponLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RemoveCouponLinkLabel.LinkClicked
        Dim SelectedItem As String = ValidCouponListBox.SelectedItem.ToString
        Dim CouponCode As String = SelectedItem.Substring(0, SelectedItem.IndexOf(" "))
        Dim PositionInteger As Integer = Me.CouponBindingSource.Find("Coupon_Code", CouponCode)
        CouponBindingSource.Position = PositionInteger
        CouponBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
        Me.CouponTableAdapter.Fill(Me.DuMegaDBDataSet.Coupon)
        GetValidCoupons()
    End Sub

    Private Sub persitent()
        Me.Validate()
        Me.CouponBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub CloseButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        CloseForm()
    End Sub

    Private Sub CloseForm()
        MainWindow.Show()
        Me.Visible = False
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
        RemoveCouponLinkLabel.Visible = False
        ValidCouponListBox.SelectedIndex = -1
    End Sub

    Private Sub CouponBook_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            CloseForm()
        End If
    End Sub

    Private Sub ValidCouponListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidCouponListBox.SelectedIndexChanged
        If ValidCouponListBox.SelectedIndex >= 0 Then
            RemoveCouponLinkLabel.Visible = True
        Else
            RemoveCouponLinkLabel.Visible = False
        End If
    End Sub

    Private Sub NewCouponLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewCouponLinkLabel.LinkClicked
        Me.Visible = False
        AddCoupon.Show()
    End Sub
End Class