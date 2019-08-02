Public Class ReportForm

    Private Sub ReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       LoadDatabase()
    End Sub

    Friend Sub LoadDatabase()
        Me.SalesReportTableAdapter.Fill(Me.DuMegaDBDataSet.SalesReport)
        Me.InvoiceTableAdapter.Fill(Me.DuMegaDBDataSet.Invoice)
        Me.SalesReportViewer.RefreshReport()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
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