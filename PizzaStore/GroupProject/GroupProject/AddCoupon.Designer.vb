<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCoupon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCoupon))
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.CouponBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CouponTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CouponCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountRateComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TickPictureBox = New System.Windows.Forms.PictureBox()
        Me.ErrorPictureBox = New System.Windows.Forms.PictureBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TickPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DuMegaDBDataSet
        '
        Me.DuMegaDBDataSet.DataSetName = "DuMegaDBDataSet"
        Me.DuMegaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CouponBindingSource
        '
        Me.CouponBindingSource.DataMember = "Coupon"
        Me.CouponBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'CouponTableAdapter
        '
        Me.CouponTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CouponTableAdapter = Me.CouponTableAdapter
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "EXPIRED ON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "DISCOUNT RATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "COUPON CODE"
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(139, 176)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 27)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "&Back"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(57, 176)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 27)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clea&r"
        Me.ClearButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CouponCodeTextBox
        '
        Me.CouponCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CouponCodeTextBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CouponCodeTextBox.ForeColor = System.Drawing.Color.Teal
        Me.CouponCodeTextBox.Location = New System.Drawing.Point(138, 20)
        Me.CouponCodeTextBox.MaxLength = 8
        Me.CouponCodeTextBox.Name = "CouponCodeTextBox"
        Me.CouponCodeTextBox.Size = New System.Drawing.Size(175, 30)
        Me.CouponCodeTextBox.TabIndex = 1
        Me.CouponCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiscountRateComboBox
        '
        Me.DiscountRateComboBox.BackColor = System.Drawing.Color.White
        Me.DiscountRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiscountRateComboBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountRateComboBox.FormattingEnabled = True
        Me.DiscountRateComboBox.Items.AddRange(New Object() {"5%", "10%", "15%", "20%", "25%", "30%"})
        Me.DiscountRateComboBox.Location = New System.Drawing.Point(138, 70)
        Me.DiscountRateComboBox.Name = "DiscountRateComboBox"
        Me.DiscountRateComboBox.Size = New System.Drawing.Size(175, 30)
        Me.DiscountRateComboBox.TabIndex = 2
        '
        'ExpiredDateTimePicker
        '
        Me.ExpiredDateTimePicker.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpiredDateTimePicker.Location = New System.Drawing.Point(138, 122)
        Me.ExpiredDateTimePicker.Name = "ExpiredDateTimePicker"
        Me.ExpiredDateTimePicker.Size = New System.Drawing.Size(175, 30)
        Me.ExpiredDateTimePicker.TabIndex = 3
        '
        'TickPictureBox
        '
        Me.TickPictureBox.Image = Global.GroupProject.My.Resources.Resources.tick
        Me.TickPictureBox.Location = New System.Drawing.Point(317, 21)
        Me.TickPictureBox.Name = "TickPictureBox"
        Me.TickPictureBox.Size = New System.Drawing.Size(28, 26)
        Me.TickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TickPictureBox.TabIndex = 73
        Me.TickPictureBox.TabStop = False
        Me.TickPictureBox.Visible = False
        '
        'ErrorPictureBox
        '
        Me.ErrorPictureBox.Image = Global.GroupProject.My.Resources.Resources._error
        Me.ErrorPictureBox.Location = New System.Drawing.Point(317, 22)
        Me.ErrorPictureBox.Name = "ErrorPictureBox"
        Me.ErrorPictureBox.Size = New System.Drawing.Size(28, 26)
        Me.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ErrorPictureBox.TabIndex = 74
        Me.ErrorPictureBox.TabStop = False
        Me.ErrorPictureBox.Visible = False
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageLabel.Location = New System.Drawing.Point(136, 53)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(223, 16)
        Me.MessageLabel.TabIndex = 75
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(238, 176)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 27)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'AddCoupon
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(371, 250)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ErrorPictureBox)
        Me.Controls.Add(Me.TickPictureBox)
        Me.Controls.Add(Me.ExpiredDateTimePicker)
        Me.Controls.Add(Me.DiscountRateComboBox)
        Me.Controls.Add(Me.CouponCodeTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddCoupon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Coupon"
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TickPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents CouponBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CouponTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CouponCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountRateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExpiredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TickPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
End Class
