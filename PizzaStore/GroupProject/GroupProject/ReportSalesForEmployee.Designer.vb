<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSalesForEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSalesForEmployee))
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.TodaySalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TodaySalesTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.TodaySalesTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TodayLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalesLabel = New System.Windows.Forms.Label()
        Me.NumberOfTransactionLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmployeeIdLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodaySalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DuMegaDBDataSet
        '
        Me.DuMegaDBDataSet.DataSetName = "DuMegaDBDataSet"
        Me.DuMegaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TodaySalesBindingSource
        '
        Me.TodaySalesBindingSource.DataMember = "TodaySales"
        Me.TodaySalesBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'TodaySalesTableAdapter
        '
        Me.TodaySalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CouponTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "EMPLOYEE NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "EMPLOYEE ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "TODAY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 24)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "SALES REPORT"
        '
        'TodayLabel
        '
        Me.TodayLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodayLabel.Location = New System.Drawing.Point(162, 60)
        Me.TodayLabel.Name = "TodayLabel"
        Me.TodayLabel.Size = New System.Drawing.Size(179, 15)
        Me.TodayLabel.TabIndex = 72
        Me.TodayLabel.Text = "11/30/2012"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SalesLabel)
        Me.GroupBox1.Controls.Add(Me.NumberOfTransactionLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(45, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 121)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SALES INFO:"
        '
        'SalesLabel
        '
        Me.SalesLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesLabel.ForeColor = System.Drawing.Color.Green
        Me.SalesLabel.Location = New System.Drawing.Point(149, 63)
        Me.SalesLabel.Name = "SalesLabel"
        Me.SalesLabel.Size = New System.Drawing.Size(109, 30)
        Me.SalesLabel.TabIndex = 76
        Me.SalesLabel.Text = "$358.25"
        '
        'NumberOfTransactionLabel
        '
        Me.NumberOfTransactionLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfTransactionLabel.ForeColor = System.Drawing.Color.Green
        Me.NumberOfTransactionLabel.Location = New System.Drawing.Point(179, 26)
        Me.NumberOfTransactionLabel.Name = "NumberOfTransactionLabel"
        Me.NumberOfTransactionLabel.Size = New System.Drawing.Size(61, 30)
        Me.NumberOfTransactionLabel.TabIndex = 75
        Me.NumberOfTransactionLabel.Text = "25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(12, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 15)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "TOTAL SALES AMOUNT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 15)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "NUMBER OF TRANSACTIONS:"
        '
        'EmployeeIdLabel
        '
        Me.EmployeeIdLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdLabel.Location = New System.Drawing.Point(204, 91)
        Me.EmployeeIdLabel.Name = "EmployeeIdLabel"
        Me.EmployeeIdLabel.Size = New System.Drawing.Size(61, 30)
        Me.EmployeeIdLabel.TabIndex = 74
        Me.EmployeeIdLabel.Text = "#1"
        '
        'EmployeeNameLabel
        '
        Me.EmployeeNameLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameLabel.Location = New System.Drawing.Point(189, 126)
        Me.EmployeeNameLabel.Name = "EmployeeNameLabel"
        Me.EmployeeNameLabel.Size = New System.Drawing.Size(200, 33)
        Me.EmployeeNameLabel.TabIndex = 75
        Me.EmployeeNameLabel.Text = "LEE, SAKI"
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(134, 322)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 27)
        Me.CloseButton.TabIndex = 76
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ReportSalesForEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 385)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.EmployeeNameLabel)
        Me.Controls.Add(Me.EmployeeIdLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TodayLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(371, 423)
        Me.Name = "ReportSalesForEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodaySalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents TodaySalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TodaySalesTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.TodaySalesTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TodayLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EmployeeIdLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeNameLabel As System.Windows.Forms.Label
    Friend WithEvents SalesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfTransactionLabel As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
