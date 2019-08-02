<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouponBookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CouponBookForm))
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.CouponBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CouponTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ValidCouponListBox = New System.Windows.Forms.ListBox()
        Me.NewCouponLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RemoveCouponLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ValidCouponListBox
        '
        Me.ValidCouponListBox.BackColor = System.Drawing.SystemColors.Control
        Me.ValidCouponListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidCouponListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidCouponListBox.ForeColor = System.Drawing.Color.Teal
        Me.ValidCouponListBox.FormattingEnabled = True
        Me.ValidCouponListBox.ItemHeight = 19
        Me.ValidCouponListBox.Location = New System.Drawing.Point(21, 37)
        Me.ValidCouponListBox.Name = "ValidCouponListBox"
        Me.ValidCouponListBox.Size = New System.Drawing.Size(444, 114)
        Me.ValidCouponListBox.TabIndex = 57
        '
        'NewCouponLinkLabel
        '
        Me.NewCouponLinkLabel.AutoSize = True
        Me.NewCouponLinkLabel.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCouponLinkLabel.Location = New System.Drawing.Point(358, 154)
        Me.NewCouponLinkLabel.Name = "NewCouponLinkLabel"
        Me.NewCouponLinkLabel.Size = New System.Drawing.Size(77, 14)
        Me.NewCouponLinkLabel.TabIndex = 60
        Me.NewCouponLinkLabel.TabStop = True
        Me.NewCouponLinkLabel.Text = "&Add Coupon"
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(194, 179)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 27)
        Me.CloseButton.TabIndex = 61
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "DISCOUNT RATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "EXPIRED ON"
        '
        'RemoveCouponLinkLabel
        '
        Me.RemoveCouponLinkLabel.AutoSize = True
        Me.RemoveCouponLinkLabel.Font = New System.Drawing.Font("Consolas", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveCouponLinkLabel.Location = New System.Drawing.Point(21, 154)
        Me.RemoveCouponLinkLabel.Name = "RemoveCouponLinkLabel"
        Me.RemoveCouponLinkLabel.Size = New System.Drawing.Size(161, 14)
        Me.RemoveCouponLinkLabel.TabIndex = 65
        Me.RemoveCouponLinkLabel.TabStop = True
        Me.RemoveCouponLinkLabel.Text = "&Delete Selected Coupon"
        Me.RemoveCouponLinkLabel.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(477, 218)
        Me.ShapeContainer1.TabIndex = 66
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Teal
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 433
        Me.LineShape2.Y1 = 152
        Me.LineShape2.Y2 = 152
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Teal
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 433
        Me.LineShape1.Y1 = 36
        Me.LineShape1.Y2 = 36
        '
        'CouponBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(477, 218)
        Me.Controls.Add(Me.RemoveCouponLinkLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NewCouponLinkLabel)
        Me.Controls.Add(Me.ValidCouponListBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CouponBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon Book"
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents CouponBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CouponTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ValidCouponListBox As System.Windows.Forms.ListBox
    Friend WithEvents NewCouponLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RemoveCouponLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
