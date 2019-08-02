<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AverageTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountedAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalBooksTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 99)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(100, 69)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.PriceTextBox.TabIndex = 5
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(101, 45)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(161, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(103, 16)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(74, 20)
        Me.QuantityTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Quantity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 112)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DiscountedPriceTextBox
        '
        Me.DiscountedPriceTextBox.Location = New System.Drawing.Point(198, 76)
        Me.DiscountedPriceTextBox.Name = "DiscountedPriceTextBox"
        Me.DiscountedPriceTextBox.ReadOnly = True
        Me.DiscountedPriceTextBox.Size = New System.Drawing.Size(101, 20)
        Me.DiscountedPriceTextBox.TabIndex = 5
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(201, 50)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(98, 20)
        Me.DiscountTextBox.TabIndex = 4
        '
        'ExtendedPriceTextBox
        '
        Me.ExtendedPriceTextBox.Location = New System.Drawing.Point(201, 18)
        Me.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox"
        Me.ExtendedPriceTextBox.ReadOnly = True
        Me.ExtendedPriceTextBox.Size = New System.Drawing.Size(99, 20)
        Me.ExtendedPriceTextBox.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Discounted Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "15% Discount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Extended Price"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(21, 418)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(108, 418)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(294, 418)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AverageTextBox)
        Me.GroupBox3.Controls.Add(Me.TotalDiscountedAmountTextBox)
        Me.GroupBox3.Controls.Add(Me.TotalDiscountTextBox)
        Me.GroupBox3.Controls.Add(Me.TotalBooksTextBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 145)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'AverageTextBox
        '
        Me.AverageTextBox.Location = New System.Drawing.Point(183, 98)
        Me.AverageTextBox.Name = "AverageTextBox"
        Me.AverageTextBox.ReadOnly = True
        Me.AverageTextBox.Size = New System.Drawing.Size(147, 20)
        Me.AverageTextBox.TabIndex = 7
        '
        'TotalDiscountedAmountTextBox
        '
        Me.TotalDiscountedAmountTextBox.Location = New System.Drawing.Point(183, 72)
        Me.TotalDiscountedAmountTextBox.Name = "TotalDiscountedAmountTextBox"
        Me.TotalDiscountedAmountTextBox.ReadOnly = True
        Me.TotalDiscountedAmountTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TotalDiscountedAmountTextBox.TabIndex = 6
        '
        'TotalDiscountTextBox
        '
        Me.TotalDiscountTextBox.Location = New System.Drawing.Point(183, 46)
        Me.TotalDiscountTextBox.Name = "TotalDiscountTextBox"
        Me.TotalDiscountTextBox.ReadOnly = True
        Me.TotalDiscountTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TotalDiscountTextBox.TabIndex = 5
        '
        'TotalBooksTextBox
        '
        Me.TotalBooksTextBox.Location = New System.Drawing.Point(183, 17)
        Me.TotalBooksTextBox.Name = "TotalBooksTextBox"
        Me.TotalBooksTextBox.ReadOnly = True
        Me.TotalBooksTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TotalBooksTextBox.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Average Discounts"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Discounted Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Discounts Given"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Number of Books"
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(209, 418)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearAllButton.TabIndex = 8
        Me.ClearAllButton.Text = "Clear &All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(395, 475)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountedPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtendedPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AverageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscountedAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBooksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button

End Class
