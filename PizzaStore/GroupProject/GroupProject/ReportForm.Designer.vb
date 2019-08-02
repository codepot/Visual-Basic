<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.SalesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.SalesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SalesReportTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.SalesReportTableAdapter()
        CType(Me.SalesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesReportBindingSource
        '
        Me.SalesReportBindingSource.DataMember = "SalesReport"
        Me.SalesReportBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'DuMegaDBDataSet
        '
        Me.DuMegaDBDataSet.DataSetName = "DuMegaDBDataSet"
        Me.DuMegaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CouponTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.UpdateOrder = GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'SalesReportViewer
        '
        ReportDataSource1.Name = "SalesReport"
        ReportDataSource1.Value = Me.SalesReportBindingSource
        Me.SalesReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.SalesReportViewer.LocalReport.ReportEmbeddedResource = "GroupProject.Report2.rdlc"
        Me.SalesReportViewer.Location = New System.Drawing.Point(7, 56)
        Me.SalesReportViewer.Name = "SalesReportViewer"
        Me.SalesReportViewer.Size = New System.Drawing.Size(773, 342)
        Me.SalesReportViewer.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(697, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 27)
        Me.BackButton.TabIndex = 70
        Me.BackButton.Text = "&Back"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SalesReportTableAdapter
        '
        Me.SalesReportTableAdapter.ClearBeforeFill = True
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(784, 410)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SalesReportViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.SalesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SalesReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesReportTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.SalesReportTableAdapter
End Class
