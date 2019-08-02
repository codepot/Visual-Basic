<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.PizzaGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddDrinkButton = New System.Windows.Forms.Button()
        Me.WhippedCreamCheckBox = New System.Windows.Forms.CheckBox()
        Me.MyGroupBox3 = New GroupProject.MyGroupBox()
        Me.LargeMochaMixRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneMochaMixRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegularMochaMixRadioButton = New System.Windows.Forms.RadioButton()
        Me.MyGroupBox2 = New GroupProject.MyGroupBox()
        Me.LargeBerrySmoothyRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneBerrySmoothyRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegularBerrySmoothyRadioButton = New System.Windows.Forms.RadioButton()
        Me.MyGroupBox1 = New GroupProject.MyGroupBox()
        Me.LargeCokeRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneCokeRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegularCokeRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouponToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OliveCheckBox = New System.Windows.Forms.CheckBox()
        Me.MushroomCheckBox = New System.Windows.Forms.CheckBox()
        Me.PineappleCheckBox = New System.Windows.Forms.CheckBox()
        Me.GreenPepperCheckBox = New System.Windows.Forms.CheckBox()
        Me.OnionCheckBox = New System.Windows.Forms.CheckBox()
        Me.BaconCheckBox = New System.Windows.Forms.CheckBox()
        Me.SausageCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItalianSauceCheckBox = New System.Windows.Forms.CheckBox()
        Me.PepperoniCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlambeeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddPizzaButton = New System.Windows.Forms.Button()
        Me.MyGroupBox6 = New GroupProject.MyGroupBox()
        Me.LargeSizePizzaRadioButton = New System.Windows.Forms.RadioButton()
        Me.SmallSizePizzaRadioButton = New System.Windows.Forms.RadioButton()
        Me.MediumSizePizzaRadioButton = New System.Windows.Forms.RadioButton()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.CouponTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckCouponButton = New System.Windows.Forms.Button()
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.CouponBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CouponTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.InvoiceTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.InvoiceTableAdapter()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.OrderPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.RemoveCouponLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PizzaGroupBox.SuspendLayout()
        Me.MyGroupBox3.SuspendLayout()
        Me.MyGroupBox2.SuspendLayout()
        Me.MyGroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MyGroupBox6.SuspendLayout()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PizzaGroupBox
        '
        Me.PizzaGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PizzaGroupBox.Controls.Add(Me.AddDrinkButton)
        Me.PizzaGroupBox.Controls.Add(Me.WhippedCreamCheckBox)
        Me.PizzaGroupBox.Controls.Add(Me.MyGroupBox3)
        Me.PizzaGroupBox.Controls.Add(Me.MyGroupBox2)
        Me.PizzaGroupBox.Controls.Add(Me.MyGroupBox1)
        Me.PizzaGroupBox.Controls.Add(Me.Label6)
        Me.PizzaGroupBox.Controls.Add(Me.Label5)
        Me.PizzaGroupBox.Controls.Add(Me.Label4)
        Me.PizzaGroupBox.Controls.Add(Me.Label3)
        Me.PizzaGroupBox.Controls.Add(Me.Label2)
        Me.PizzaGroupBox.Controls.Add(Me.Label1)
        Me.PizzaGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PizzaGroupBox.ForeColor = System.Drawing.Color.Black
        Me.PizzaGroupBox.Location = New System.Drawing.Point(8, 339)
        Me.PizzaGroupBox.Name = "PizzaGroupBox"
        Me.PizzaGroupBox.Size = New System.Drawing.Size(367, 221)
        Me.PizzaGroupBox.TabIndex = 0
        Me.PizzaGroupBox.TabStop = False
        Me.PizzaGroupBox.Text = "Drink"
        '
        'AddDrinkButton
        '
        Me.AddDrinkButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrinkButton.Location = New System.Drawing.Point(269, 172)
        Me.AddDrinkButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddDrinkButton.Name = "AddDrinkButton"
        Me.AddDrinkButton.Size = New System.Drawing.Size(86, 31)
        Me.AddDrinkButton.TabIndex = 11
        Me.AddDrinkButton.Text = "Add &Drink"
        Me.AddDrinkButton.UseVisualStyleBackColor = True
        '
        'WhippedCreamCheckBox
        '
        Me.WhippedCreamCheckBox.AutoSize = True
        Me.WhippedCreamCheckBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhippedCreamCheckBox.Location = New System.Drawing.Point(32, 180)
        Me.WhippedCreamCheckBox.Name = "WhippedCreamCheckBox"
        Me.WhippedCreamCheckBox.Size = New System.Drawing.Size(177, 19)
        Me.WhippedCreamCheckBox.TabIndex = 10
        Me.WhippedCreamCheckBox.Text = "Whipped Cream Mocha Mix"
        Me.WhippedCreamCheckBox.UseVisualStyleBackColor = True
        Me.WhippedCreamCheckBox.Visible = False
        '
        'MyGroupBox3
        '
        Me.MyGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyGroupBox3.Controls.Add(Me.LargeMochaMixRadioButton)
        Me.MyGroupBox3.Controls.Add(Me.NoneMochaMixRadioButton)
        Me.MyGroupBox3.Controls.Add(Me.RegularMochaMixRadioButton)
        Me.MyGroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox3.Location = New System.Drawing.Point(115, 128)
        Me.MyGroupBox3.Name = "MyGroupBox3"
        Me.MyGroupBox3.Size = New System.Drawing.Size(247, 32)
        Me.MyGroupBox3.TabIndex = 9
        Me.MyGroupBox3.TabStop = False
        '
        'LargeMochaMixRadioButton
        '
        Me.LargeMochaMixRadioButton.AutoSize = True
        Me.LargeMochaMixRadioButton.Location = New System.Drawing.Point(179, 9)
        Me.LargeMochaMixRadioButton.Name = "LargeMochaMixRadioButton"
        Me.LargeMochaMixRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.LargeMochaMixRadioButton.TabIndex = 2
        Me.LargeMochaMixRadioButton.UseVisualStyleBackColor = True
        '
        'NoneMochaMixRadioButton
        '
        Me.NoneMochaMixRadioButton.AutoSize = True
        Me.NoneMochaMixRadioButton.Checked = True
        Me.NoneMochaMixRadioButton.Location = New System.Drawing.Point(25, 9)
        Me.NoneMochaMixRadioButton.Name = "NoneMochaMixRadioButton"
        Me.NoneMochaMixRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.NoneMochaMixRadioButton.TabIndex = 0
        Me.NoneMochaMixRadioButton.TabStop = True
        Me.NoneMochaMixRadioButton.UseVisualStyleBackColor = True
        '
        'RegularMochaMixRadioButton
        '
        Me.RegularMochaMixRadioButton.AutoSize = True
        Me.RegularMochaMixRadioButton.Location = New System.Drawing.Point(103, 9)
        Me.RegularMochaMixRadioButton.Name = "RegularMochaMixRadioButton"
        Me.RegularMochaMixRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.RegularMochaMixRadioButton.TabIndex = 1
        Me.RegularMochaMixRadioButton.UseVisualStyleBackColor = True
        '
        'MyGroupBox2
        '
        Me.MyGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyGroupBox2.Controls.Add(Me.LargeBerrySmoothyRadioButton)
        Me.MyGroupBox2.Controls.Add(Me.NoneBerrySmoothyRadioButton)
        Me.MyGroupBox2.Controls.Add(Me.RegularBerrySmoothyRadioButton)
        Me.MyGroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox2.Location = New System.Drawing.Point(114, 86)
        Me.MyGroupBox2.Name = "MyGroupBox2"
        Me.MyGroupBox2.Size = New System.Drawing.Size(247, 32)
        Me.MyGroupBox2.TabIndex = 8
        Me.MyGroupBox2.TabStop = False
        '
        'LargeBerrySmoothyRadioButton
        '
        Me.LargeBerrySmoothyRadioButton.AutoSize = True
        Me.LargeBerrySmoothyRadioButton.Location = New System.Drawing.Point(179, 9)
        Me.LargeBerrySmoothyRadioButton.Name = "LargeBerrySmoothyRadioButton"
        Me.LargeBerrySmoothyRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.LargeBerrySmoothyRadioButton.TabIndex = 2
        Me.LargeBerrySmoothyRadioButton.UseVisualStyleBackColor = True
        '
        'NoneBerrySmoothyRadioButton
        '
        Me.NoneBerrySmoothyRadioButton.AutoSize = True
        Me.NoneBerrySmoothyRadioButton.Checked = True
        Me.NoneBerrySmoothyRadioButton.Location = New System.Drawing.Point(25, 9)
        Me.NoneBerrySmoothyRadioButton.Name = "NoneBerrySmoothyRadioButton"
        Me.NoneBerrySmoothyRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.NoneBerrySmoothyRadioButton.TabIndex = 0
        Me.NoneBerrySmoothyRadioButton.TabStop = True
        Me.NoneBerrySmoothyRadioButton.UseVisualStyleBackColor = True
        '
        'RegularBerrySmoothyRadioButton
        '
        Me.RegularBerrySmoothyRadioButton.AutoSize = True
        Me.RegularBerrySmoothyRadioButton.Location = New System.Drawing.Point(103, 9)
        Me.RegularBerrySmoothyRadioButton.Name = "RegularBerrySmoothyRadioButton"
        Me.RegularBerrySmoothyRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.RegularBerrySmoothyRadioButton.TabIndex = 1
        Me.RegularBerrySmoothyRadioButton.UseVisualStyleBackColor = True
        '
        'MyGroupBox1
        '
        Me.MyGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyGroupBox1.Controls.Add(Me.LargeCokeRadioButton)
        Me.MyGroupBox1.Controls.Add(Me.NoneCokeRadioButton)
        Me.MyGroupBox1.Controls.Add(Me.RegularCokeRadioButton)
        Me.MyGroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox1.Location = New System.Drawing.Point(114, 44)
        Me.MyGroupBox1.Name = "MyGroupBox1"
        Me.MyGroupBox1.Size = New System.Drawing.Size(247, 32)
        Me.MyGroupBox1.TabIndex = 7
        Me.MyGroupBox1.TabStop = False
        '
        'LargeCokeRadioButton
        '
        Me.LargeCokeRadioButton.AutoSize = True
        Me.LargeCokeRadioButton.Location = New System.Drawing.Point(179, 9)
        Me.LargeCokeRadioButton.Name = "LargeCokeRadioButton"
        Me.LargeCokeRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.LargeCokeRadioButton.TabIndex = 2
        Me.LargeCokeRadioButton.UseVisualStyleBackColor = True
        '
        'NoneCokeRadioButton
        '
        Me.NoneCokeRadioButton.AutoSize = True
        Me.NoneCokeRadioButton.Checked = True
        Me.NoneCokeRadioButton.Location = New System.Drawing.Point(25, 9)
        Me.NoneCokeRadioButton.Name = "NoneCokeRadioButton"
        Me.NoneCokeRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.NoneCokeRadioButton.TabIndex = 0
        Me.NoneCokeRadioButton.TabStop = True
        Me.NoneCokeRadioButton.UseVisualStyleBackColor = True
        '
        'RegularCokeRadioButton
        '
        Me.RegularCokeRadioButton.AutoSize = True
        Me.RegularCokeRadioButton.Location = New System.Drawing.Point(103, 9)
        Me.RegularCokeRadioButton.Name = "RegularCokeRadioButton"
        Me.RegularCokeRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.RegularCokeRadioButton.TabIndex = 1
        Me.RegularCokeRadioButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mocha Mix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Berry Smoothy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Coke"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Large"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Regular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "None"
        '
        'OrderListBox
        '
        Me.OrderListBox.BackColor = System.Drawing.Color.White
        Me.OrderListBox.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderListBox.FormattingEnabled = True
        Me.OrderListBox.ItemHeight = 17
        Me.OrderListBox.Location = New System.Drawing.Point(389, 69)
        Me.OrderListBox.Name = "OrderListBox"
        Me.OrderListBox.Size = New System.Drawing.Size(393, 378)
        Me.OrderListBox.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogoutToolStripMenuItem.Text = "Log &out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateUserToolStripMenuItem, Me.SaleReportToolStripMenuItem, Me.CouponToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CreateUserToolStripMenuItem.Text = "&User"
        '
        'SaleReportToolStripMenuItem
        '
        Me.SaleReportToolStripMenuItem.Name = "SaleReportToolStripMenuItem"
        Me.SaleReportToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SaleReportToolStripMenuItem.Text = "&Report"
        '
        'CouponToolStripMenuItem
        '
        Me.CouponToolStripMenuItem.Name = "CouponToolStripMenuItem"
        Me.CouponToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CouponToolStripMenuItem.Text = "&Coupon"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ResetButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AddPizzaButton)
        Me.GroupBox1.Controls.Add(Me.MyGroupBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 296)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pizza"
        '
        'ResetButton
        '
        Me.ResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ResetButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(16, 250)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(86, 31)
        Me.ResetButton.TabIndex = 14
        Me.ResetButton.Text = "Re&set"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OliveCheckBox)
        Me.GroupBox2.Controls.Add(Me.MushroomCheckBox)
        Me.GroupBox2.Controls.Add(Me.PineappleCheckBox)
        Me.GroupBox2.Controls.Add(Me.GreenPepperCheckBox)
        Me.GroupBox2.Controls.Add(Me.OnionCheckBox)
        Me.GroupBox2.Controls.Add(Me.BaconCheckBox)
        Me.GroupBox2.Controls.Add(Me.SausageCheckBox)
        Me.GroupBox2.Controls.Add(Me.ItalianSauceCheckBox)
        Me.GroupBox2.Controls.Add(Me.PepperoniCheckBox)
        Me.GroupBox2.Controls.Add(Me.FlambeeCheckBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 183)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'OliveCheckBox
        '
        Me.OliveCheckBox.AutoSize = True
        Me.OliveCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OliveCheckBox.Location = New System.Drawing.Point(205, 143)
        Me.OliveCheckBox.Name = "OliveCheckBox"
        Me.OliveCheckBox.Size = New System.Drawing.Size(63, 23)
        Me.OliveCheckBox.TabIndex = 19
        Me.OliveCheckBox.Text = "Olive"
        Me.OliveCheckBox.UseVisualStyleBackColor = True
        '
        'MushroomCheckBox
        '
        Me.MushroomCheckBox.AutoSize = True
        Me.MushroomCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MushroomCheckBox.Location = New System.Drawing.Point(205, 116)
        Me.MushroomCheckBox.Name = "MushroomCheckBox"
        Me.MushroomCheckBox.Size = New System.Drawing.Size(103, 23)
        Me.MushroomCheckBox.TabIndex = 18
        Me.MushroomCheckBox.Text = "Mushroom"
        Me.MushroomCheckBox.UseVisualStyleBackColor = True
        '
        'PineappleCheckBox
        '
        Me.PineappleCheckBox.AutoSize = True
        Me.PineappleCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PineappleCheckBox.Location = New System.Drawing.Point(205, 89)
        Me.PineappleCheckBox.Name = "PineappleCheckBox"
        Me.PineappleCheckBox.Size = New System.Drawing.Size(96, 23)
        Me.PineappleCheckBox.TabIndex = 17
        Me.PineappleCheckBox.Text = "Pineapple"
        Me.PineappleCheckBox.UseVisualStyleBackColor = True
        '
        'GreenPepperCheckBox
        '
        Me.GreenPepperCheckBox.AutoSize = True
        Me.GreenPepperCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenPepperCheckBox.Location = New System.Drawing.Point(205, 62)
        Me.GreenPepperCheckBox.Name = "GreenPepperCheckBox"
        Me.GreenPepperCheckBox.Size = New System.Drawing.Size(122, 23)
        Me.GreenPepperCheckBox.TabIndex = 16
        Me.GreenPepperCheckBox.Text = "Green Pepper"
        Me.GreenPepperCheckBox.UseVisualStyleBackColor = True
        '
        'OnionCheckBox
        '
        Me.OnionCheckBox.AutoSize = True
        Me.OnionCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnionCheckBox.Location = New System.Drawing.Point(205, 35)
        Me.OnionCheckBox.Name = "OnionCheckBox"
        Me.OnionCheckBox.Size = New System.Drawing.Size(70, 23)
        Me.OnionCheckBox.TabIndex = 15
        Me.OnionCheckBox.Text = "Onion"
        Me.OnionCheckBox.UseVisualStyleBackColor = True
        '
        'BaconCheckBox
        '
        Me.BaconCheckBox.AutoSize = True
        Me.BaconCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaconCheckBox.Location = New System.Drawing.Point(19, 143)
        Me.BaconCheckBox.Name = "BaconCheckBox"
        Me.BaconCheckBox.Size = New System.Drawing.Size(70, 23)
        Me.BaconCheckBox.TabIndex = 14
        Me.BaconCheckBox.Text = "Bacon"
        Me.BaconCheckBox.UseVisualStyleBackColor = True
        '
        'SausageCheckBox
        '
        Me.SausageCheckBox.AutoSize = True
        Me.SausageCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SausageCheckBox.Location = New System.Drawing.Point(19, 116)
        Me.SausageCheckBox.Name = "SausageCheckBox"
        Me.SausageCheckBox.Size = New System.Drawing.Size(83, 23)
        Me.SausageCheckBox.TabIndex = 13
        Me.SausageCheckBox.Text = "Sausage"
        Me.SausageCheckBox.UseVisualStyleBackColor = True
        '
        'ItalianSauceCheckBox
        '
        Me.ItalianSauceCheckBox.AutoSize = True
        Me.ItalianSauceCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalianSauceCheckBox.Location = New System.Drawing.Point(19, 89)
        Me.ItalianSauceCheckBox.Name = "ItalianSauceCheckBox"
        Me.ItalianSauceCheckBox.Size = New System.Drawing.Size(115, 23)
        Me.ItalianSauceCheckBox.TabIndex = 12
        Me.ItalianSauceCheckBox.Text = "Italian Sauce"
        Me.ItalianSauceCheckBox.UseVisualStyleBackColor = True
        '
        'PepperoniCheckBox
        '
        Me.PepperoniCheckBox.AutoSize = True
        Me.PepperoniCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PepperoniCheckBox.Location = New System.Drawing.Point(19, 62)
        Me.PepperoniCheckBox.Name = "PepperoniCheckBox"
        Me.PepperoniCheckBox.Size = New System.Drawing.Size(99, 23)
        Me.PepperoniCheckBox.TabIndex = 11
        Me.PepperoniCheckBox.Text = "Pepperoni"
        Me.PepperoniCheckBox.UseVisualStyleBackColor = True
        '
        'FlambeeCheckBox
        '
        Me.FlambeeCheckBox.AutoSize = True
        Me.FlambeeCheckBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlambeeCheckBox.Location = New System.Drawing.Point(19, 35)
        Me.FlambeeCheckBox.Name = "FlambeeCheckBox"
        Me.FlambeeCheckBox.Size = New System.Drawing.Size(85, 23)
        Me.FlambeeCheckBox.TabIndex = 10
        Me.FlambeeCheckBox.Text = "Flambée"
        Me.FlambeeCheckBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Size"
        '
        'AddPizzaButton
        '
        Me.AddPizzaButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPizzaButton.Location = New System.Drawing.Point(269, 250)
        Me.AddPizzaButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddPizzaButton.Name = "AddPizzaButton"
        Me.AddPizzaButton.Size = New System.Drawing.Size(86, 31)
        Me.AddPizzaButton.TabIndex = 11
        Me.AddPizzaButton.Text = "Add &Pizz&a"
        Me.AddPizzaButton.UseVisualStyleBackColor = True
        '
        'MyGroupBox6
        '
        Me.MyGroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MyGroupBox6.Controls.Add(Me.LargeSizePizzaRadioButton)
        Me.MyGroupBox6.Controls.Add(Me.SmallSizePizzaRadioButton)
        Me.MyGroupBox6.Controls.Add(Me.MediumSizePizzaRadioButton)
        Me.MyGroupBox6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyGroupBox6.Location = New System.Drawing.Point(96, 18)
        Me.MyGroupBox6.Name = "MyGroupBox6"
        Me.MyGroupBox6.Size = New System.Drawing.Size(265, 29)
        Me.MyGroupBox6.TabIndex = 7
        Me.MyGroupBox6.TabStop = False
        '
        'LargeSizePizzaRadioButton
        '
        Me.LargeSizePizzaRadioButton.AutoSize = True
        Me.LargeSizePizzaRadioButton.Location = New System.Drawing.Point(173, 5)
        Me.LargeSizePizzaRadioButton.Name = "LargeSizePizzaRadioButton"
        Me.LargeSizePizzaRadioButton.Size = New System.Drawing.Size(55, 19)
        Me.LargeSizePizzaRadioButton.TabIndex = 2
        Me.LargeSizePizzaRadioButton.Text = "Large"
        Me.LargeSizePizzaRadioButton.UseVisualStyleBackColor = True
        '
        'SmallSizePizzaRadioButton
        '
        Me.SmallSizePizzaRadioButton.AutoSize = True
        Me.SmallSizePizzaRadioButton.Checked = True
        Me.SmallSizePizzaRadioButton.Location = New System.Drawing.Point(9, 5)
        Me.SmallSizePizzaRadioButton.Name = "SmallSizePizzaRadioButton"
        Me.SmallSizePizzaRadioButton.Size = New System.Drawing.Size(54, 19)
        Me.SmallSizePizzaRadioButton.TabIndex = 0
        Me.SmallSizePizzaRadioButton.TabStop = True
        Me.SmallSizePizzaRadioButton.Text = "Small"
        Me.SmallSizePizzaRadioButton.UseVisualStyleBackColor = True
        '
        'MediumSizePizzaRadioButton
        '
        Me.MediumSizePizzaRadioButton.AutoSize = True
        Me.MediumSizePizzaRadioButton.Location = New System.Drawing.Point(91, 5)
        Me.MediumSizePizzaRadioButton.Name = "MediumSizePizzaRadioButton"
        Me.MediumSizePizzaRadioButton.Size = New System.Drawing.Size(71, 19)
        Me.MediumSizePizzaRadioButton.TabIndex = 1
        Me.MediumSizePizzaRadioButton.Text = "Medium"
        Me.MediumSizePizzaRadioButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(391, 32)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(108, 31)
        Me.RemoveButton.TabIndex = 13
        Me.RemoveButton.Text = "&Remove Item"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOrderButton.Location = New System.Drawing.Point(672, 32)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(108, 31)
        Me.PlaceOrderButton.TabIndex = 14
        Me.PlaceOrderButton.Text = "&Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(605, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Subtotal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(635, 508)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(605, 484)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Discount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(626, 533)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total:"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(655, 459)
        Me.SubTotalLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(99, 22)
        Me.SubTotalLabel.TabIndex = 19
        Me.SubTotalLabel.Text = "$0.00"
        Me.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaxLabel
        '
        Me.TaxLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxLabel.Location = New System.Drawing.Point(655, 505)
        Me.TaxLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(98, 22)
        Me.TaxLabel.TabIndex = 20
        Me.TaxLabel.Text = "$0.00"
        Me.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DiscountLabel
        '
        Me.DiscountLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(656, 481)
        Me.DiscountLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(98, 22)
        Me.DiscountLabel.TabIndex = 21
        Me.DiscountLabel.Text = "$0.00"
        Me.DiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalLabel
        '
        Me.TotalLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalLabel.Location = New System.Drawing.Point(656, 530)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(98, 22)
        Me.TotalLabel.TabIndex = 22
        Me.TotalLabel.Text = "$0.00"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CouponTextBox
        '
        Me.CouponTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CouponTextBox.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CouponTextBox.ForeColor = System.Drawing.Color.Teal
        Me.CouponTextBox.Location = New System.Drawing.Point(391, 481)
        Me.CouponTextBox.MaxLength = 8
        Me.CouponTextBox.Name = "CouponTextBox"
        Me.CouponTextBox.Size = New System.Drawing.Size(134, 30)
        Me.CouponTextBox.TabIndex = 23
        Me.CouponTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(388, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Coupon:"
        '
        'CheckCouponButton
        '
        Me.CheckCouponButton.BackgroundImage = Global.GroupProject.My.Resources.Resources.check
        Me.CheckCouponButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckCouponButton.Location = New System.Drawing.Point(529, 480)
        Me.CheckCouponButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckCouponButton.Name = "CheckCouponButton"
        Me.CheckCouponButton.Size = New System.Drawing.Size(34, 32)
        Me.CheckCouponButton.TabIndex = 25
        Me.CheckCouponButton.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.UpdateOrder = GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'OrderPrintDocument
        '
        '
        'OrderPrintPreviewDialog
        '
        Me.OrderPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.OrderPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.OrderPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.OrderPrintPreviewDialog.Enabled = True
        Me.OrderPrintPreviewDialog.Icon = CType(resources.GetObject("OrderPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.OrderPrintPreviewDialog.Name = "OrderPrintPreviewDialog"
        Me.OrderPrintPreviewDialog.Visible = False
        '
        'RemoveCouponLinkLabel
        '
        Me.RemoveCouponLinkLabel.AutoSize = True
        Me.RemoveCouponLinkLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveCouponLinkLabel.LinkColor = System.Drawing.Color.DodgerBlue
        Me.RemoveCouponLinkLabel.Location = New System.Drawing.Point(391, 512)
        Me.RemoveCouponLinkLabel.Name = "RemoveCouponLinkLabel"
        Me.RemoveCouponLinkLabel.Size = New System.Drawing.Size(87, 14)
        Me.RemoveCouponLinkLabel.TabIndex = 26
        Me.RemoveCouponLinkLabel.TabStop = True
        Me.RemoveCouponLinkLabel.Text = "Remove Coupon"
        Me.RemoveCouponLinkLabel.Visible = False
        '
        'MainWindow
        '
        Me.AcceptButton = Me.CheckCouponButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.CancelButton = Me.ResetButton
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.RemoveCouponLinkLabel)
        Me.Controls.Add(Me.CheckCouponButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CouponTextBox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OrderListBox)
        Me.Controls.Add(Me.PizzaGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Du Mega Main Window"
        Me.PizzaGroupBox.ResumeLayout(False)
        Me.PizzaGroupBox.PerformLayout()
        Me.MyGroupBox3.ResumeLayout(False)
        Me.MyGroupBox3.PerformLayout()
        Me.MyGroupBox2.ResumeLayout(False)
        Me.MyGroupBox2.PerformLayout()
        Me.MyGroupBox1.ResumeLayout(False)
        Me.MyGroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MyGroupBox6.ResumeLayout(False)
        Me.MyGroupBox6.PerformLayout()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouponBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PizzaGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OrderListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LargeCokeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RegularCokeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoneCokeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AddDrinkButton As System.Windows.Forms.Button
    Friend WithEvents WhippedCreamCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MyGroupBox3 As GroupProject.MyGroupBox
    Friend WithEvents LargeMochaMixRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoneMochaMixRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RegularMochaMixRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MyGroupBox2 As GroupProject.MyGroupBox
    Friend WithEvents LargeBerrySmoothyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoneBerrySmoothyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RegularBerrySmoothyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MyGroupBox1 As GroupProject.MyGroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddPizzaButton As System.Windows.Forms.Button
    Friend WithEvents FlambeeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LargeSizePizzaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SmallSizePizzaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MediumSizePizzaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MyGroupBox6 As GroupProject.MyGroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OliveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MushroomCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PineappleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GreenPepperCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OnionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BaconCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SausageCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ItalianSauceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PepperoniCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents PlaceOrderButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents CouponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckCouponButton As System.Windows.Forms.Button
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents CouponBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CouponTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.CouponTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoiceTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents OrderPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents RemoveCouponLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CouponToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetButton As System.Windows.Forms.Button

End Class
