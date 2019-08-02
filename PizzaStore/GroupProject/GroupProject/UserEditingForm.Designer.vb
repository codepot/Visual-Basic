<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEditingForm
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
        Dim User_LoginNameLabel As System.Windows.Forms.Label
        Dim User_PasswordLabel As System.Windows.Forms.Label
        Dim User_FirstnameLabel As System.Windows.Forms.Label
        Dim User_LastnameLabel As System.Windows.Forms.Label
        Dim User_Address1Label As System.Windows.Forms.Label
        Dim User_Address2Label As System.Windows.Forms.Label
        Dim User_CityLabel As System.Windows.Forms.Label
        Dim User_ZipcodeLabel As System.Windows.Forms.Label
        Dim User_PhoneLabel As System.Windows.Forms.Label
        Dim User_StateLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim User_RoleLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserEditingForm))
        Me.DuMegaDBDataSet = New GroupProject.DuMegaDBDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New GroupProject.DuMegaDBDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager()
        Me.UserLoginNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.RetypePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.User_RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LookUpButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RecordNumberLabel = New System.Windows.Forms.Label()
        Me.NewUserLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        User_LoginNameLabel = New System.Windows.Forms.Label()
        User_PasswordLabel = New System.Windows.Forms.Label()
        User_FirstnameLabel = New System.Windows.Forms.Label()
        User_LastnameLabel = New System.Windows.Forms.Label()
        User_Address1Label = New System.Windows.Forms.Label()
        User_Address2Label = New System.Windows.Forms.Label()
        User_CityLabel = New System.Windows.Forms.Label()
        User_ZipcodeLabel = New System.Windows.Forms.Label()
        User_PhoneLabel = New System.Windows.Forms.Label()
        User_StateLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        User_RoleLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_LoginNameLabel
        '
        User_LoginNameLabel.AutoSize = True
        User_LoginNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_LoginNameLabel.Location = New System.Drawing.Point(24, 315)
        User_LoginNameLabel.Name = "User_LoginNameLabel"
        User_LoginNameLabel.Size = New System.Drawing.Size(124, 19)
        User_LoginNameLabel.TabIndex = 25
        User_LoginNameLabel.Text = "User Login Name:"
        '
        'User_PasswordLabel
        '
        User_PasswordLabel.AutoSize = True
        User_PasswordLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PasswordLabel.Location = New System.Drawing.Point(24, 377)
        User_PasswordLabel.Name = "User_PasswordLabel"
        User_PasswordLabel.Size = New System.Drawing.Size(109, 19)
        User_PasswordLabel.TabIndex = 26
        User_PasswordLabel.Text = "User Password:"
        '
        'User_FirstnameLabel
        '
        User_FirstnameLabel.AutoSize = True
        User_FirstnameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_FirstnameLabel.Location = New System.Drawing.Point(24, 89)
        User_FirstnameLabel.Name = "User_FirstnameLabel"
        User_FirstnameLabel.Size = New System.Drawing.Size(83, 19)
        User_FirstnameLabel.TabIndex = 17
        User_FirstnameLabel.Text = "First Name:"
        '
        'User_LastnameLabel
        '
        User_LastnameLabel.AutoSize = True
        User_LastnameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_LastnameLabel.Location = New System.Drawing.Point(24, 118)
        User_LastnameLabel.Name = "User_LastnameLabel"
        User_LastnameLabel.Size = New System.Drawing.Size(82, 19)
        User_LastnameLabel.TabIndex = 18
        User_LastnameLabel.Text = "Last Name:"
        '
        'User_Address1Label
        '
        User_Address1Label.AutoSize = True
        User_Address1Label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_Address1Label.Location = New System.Drawing.Point(24, 147)
        User_Address1Label.Name = "User_Address1Label"
        User_Address1Label.Size = New System.Drawing.Size(77, 19)
        User_Address1Label.TabIndex = 19
        User_Address1Label.Text = "Address 1:"
        '
        'User_Address2Label
        '
        User_Address2Label.AutoSize = True
        User_Address2Label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_Address2Label.Location = New System.Drawing.Point(24, 175)
        User_Address2Label.Name = "User_Address2Label"
        User_Address2Label.Size = New System.Drawing.Size(77, 19)
        User_Address2Label.TabIndex = 20
        User_Address2Label.Text = "Address 2:"
        '
        'User_CityLabel
        '
        User_CityLabel.AutoSize = True
        User_CityLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_CityLabel.Location = New System.Drawing.Point(24, 203)
        User_CityLabel.Name = "User_CityLabel"
        User_CityLabel.Size = New System.Drawing.Size(38, 19)
        User_CityLabel.TabIndex = 21
        User_CityLabel.Text = "City:"
        '
        'User_ZipcodeLabel
        '
        User_ZipcodeLabel.AutoSize = True
        User_ZipcodeLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_ZipcodeLabel.Location = New System.Drawing.Point(24, 258)
        User_ZipcodeLabel.Name = "User_ZipcodeLabel"
        User_ZipcodeLabel.Size = New System.Drawing.Size(70, 19)
        User_ZipcodeLabel.TabIndex = 23
        User_ZipcodeLabel.Text = "Zip Code:"
        '
        'User_PhoneLabel
        '
        User_PhoneLabel.AutoSize = True
        User_PhoneLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PhoneLabel.Location = New System.Drawing.Point(24, 286)
        User_PhoneLabel.Name = "User_PhoneLabel"
        User_PhoneLabel.Size = New System.Drawing.Size(108, 19)
        User_PhoneLabel.TabIndex = 24
        User_PhoneLabel.Text = "Phone Number:"
        '
        'User_StateLabel1
        '
        User_StateLabel1.AutoSize = True
        User_StateLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_StateLabel1.Location = New System.Drawing.Point(24, 232)
        User_StateLabel1.Name = "User_StateLabel1"
        User_StateLabel1.Size = New System.Drawing.Size(46, 19)
        User_StateLabel1.TabIndex = 22
        User_StateLabel1.Text = "State:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Label1.Location = New System.Drawing.Point(117, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(251, 37)
        Label1.TabIndex = 30
        Label1.Text = "Pizza Du Mega"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Label2.Location = New System.Drawing.Point(152, 43)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(168, 28)
        Label2.TabIndex = 31
        Label2.Text = "Account Plus"
        Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(23, 408)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(129, 19)
        Label3.TabIndex = 27
        Label3.Text = "Re-type Password:"
        '
        'User_RoleLabel
        '
        User_RoleLabel.AutoSize = True
        User_RoleLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_RoleLabel.Location = New System.Drawing.Point(25, 345)
        User_RoleLabel.Name = "User_RoleLabel"
        User_RoleLabel.Size = New System.Drawing.Size(76, 19)
        User_RoleLabel.TabIndex = 31
        User_RoleLabel.Text = "User Role:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(384, 50)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 19)
        Label4.TabIndex = 42
        Label4.Text = "Record:"
        '
        'DuMegaDBDataSet
        '
        Me.DuMegaDBDataSet.DataSetName = "DuMegaDBDataSet"
        Me.DuMegaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.DuMegaDBDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CouponTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'UserLoginNameTextBox
        '
        Me.UserLoginNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_LoginName", True))
        Me.UserLoginNameTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLoginNameTextBox.Location = New System.Drawing.Point(158, 312)
        Me.UserLoginNameTextBox.Name = "UserLoginNameTextBox"
        Me.UserLoginNameTextBox.Size = New System.Drawing.Size(175, 27)
        Me.UserLoginNameTextBox.TabIndex = 9
        '
        'UserPasswordTextBox
        '
        Me.UserPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Password", True))
        Me.UserPasswordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPasswordTextBox.Location = New System.Drawing.Point(158, 372)
        Me.UserPasswordTextBox.Name = "UserPasswordTextBox"
        Me.UserPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPasswordTextBox.Size = New System.Drawing.Size(175, 27)
        Me.UserPasswordTextBox.TabIndex = 10
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Firstname", True))
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(158, 86)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(175, 27)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Lastname", True))
        Me.LastnameTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameTextBox.Location = New System.Drawing.Point(158, 115)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(175, 27)
        Me.LastnameTextBox.TabIndex = 2
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Address1", True))
        Me.Address1TextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(158, 144)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(175, 27)
        Me.Address1TextBox.TabIndex = 3
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Address2", True))
        Me.Address2TextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2TextBox.Location = New System.Drawing.Point(158, 172)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(175, 27)
        Me.Address2TextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(158, 200)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(175, 27)
        Me.CityTextBox.TabIndex = 5
        '
        'RetypePasswordTextBox
        '
        Me.RetypePasswordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetypePasswordTextBox.Location = New System.Drawing.Point(158, 401)
        Me.RetypePasswordTextBox.Name = "RetypePasswordTextBox"
        Me.RetypePasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RetypePasswordTextBox.Size = New System.Drawing.Size(175, 27)
        Me.RetypePasswordTextBox.TabIndex = 11
        '
        'StateComboBox
        '
        Me.StateComboBox.BackColor = System.Drawing.Color.White
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_State", True))
        Me.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Marianas Islands", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Virgin Islands", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.StateComboBox.Location = New System.Drawing.Point(158, 227)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(175, 27)
        Me.StateComboBox.TabIndex = 6
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Phone", True))
        Me.PhoneMaskedTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(158, 283)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(175, 27)
        Me.PhoneMaskedTextBox.TabIndex = 8
        '
        'ZipCodeMaskedTextBox
        '
        Me.ZipCodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Zipcode", True))
        Me.ZipCodeMaskedTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeMaskedTextBox.Location = New System.Drawing.Point(158, 255)
        Me.ZipCodeMaskedTextBox.Mask = "00000"
        Me.ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        Me.ZipCodeMaskedTextBox.Size = New System.Drawing.Size(175, 27)
        Me.ZipCodeMaskedTextBox.TabIndex = 7
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(177, 446)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 27)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clea&r"
        Me.ClearButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'User_RoleComboBox
        '
        Me.User_RoleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "User_Role", True))
        Me.User_RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.User_RoleComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_RoleComboBox.FormattingEnabled = True
        Me.User_RoleComboBox.Items.AddRange(New Object() {"Employee", "Manager", "User"})
        Me.User_RoleComboBox.Location = New System.Drawing.Point(158, 341)
        Me.User_RoleComboBox.Name = "User_RoleComboBox"
        Me.User_RoleComboBox.Size = New System.Drawing.Size(175, 27)
        Me.User_RoleComboBox.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GroupProject.My.Resources.Resources.Users
        Me.PictureBox1.Location = New System.Drawing.Point(24, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Image = Global.GroupProject.My.Resources.Resources.user_add
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(360, 248)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(97, 35)
        Me.AddButton.TabIndex = 33
        Me.AddButton.Text = "Su&bmit"
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddButton.UseVisualStyleBackColor = True
        Me.AddButton.Visible = False
        '
        'FirstButton
        '
        Me.FirstButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstButton.Image = Global.GroupProject.My.Resources.Resources.First
        Me.FirstButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FirstButton.Location = New System.Drawing.Point(360, 92)
        Me.FirstButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(97, 35)
        Me.FirstButton.TabIndex = 34
        Me.FirstButton.Text = "&First"
        Me.FirstButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastButton.Image = Global.GroupProject.My.Resources.Resources.Last
        Me.LastButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LastButton.Location = New System.Drawing.Point(360, 197)
        Me.LastButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(97, 35)
        Me.LastButton.TabIndex = 35
        Me.LastButton.Text = "&Last"
        Me.LastButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Image = Global.GroupProject.My.Resources.Resources.Next1
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextButton.Location = New System.Drawing.Point(360, 127)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(97, 35)
        Me.NextButton.TabIndex = 36
        Me.NextButton.Text = "&Next"
        Me.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousButton.Image = Global.GroupProject.My.Resources.Resources.Previous
        Me.PreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreviousButton.Location = New System.Drawing.Point(360, 162)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(97, 35)
        Me.PreviousButton.TabIndex = 37
        Me.PreviousButton.Text = "&Previous"
        Me.PreviousButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Image = Global.GroupProject.My.Resources.Resources.Remove1
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(360, 283)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(97, 35)
        Me.DeleteButton.TabIndex = 38
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Image = Global.GroupProject.My.Resources.Resources.Save
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(360, 318)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(97, 35)
        Me.SaveButton.TabIndex = 39
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LookUpButton
        '
        Me.LookUpButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpButton.Image = Global.GroupProject.My.Resources.Resources.Search
        Me.LookUpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LookUpButton.Location = New System.Drawing.Point(360, 353)
        Me.LookUpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LookUpButton.Name = "LookUpButton"
        Me.LookUpButton.Size = New System.Drawing.Size(97, 35)
        Me.LookUpButton.TabIndex = 40
        Me.LookUpButton.Text = "Loo&k Up"
        Me.LookUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LookUpButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(258, 446)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 27)
        Me.CloseButton.TabIndex = 41
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RecordNumberLabel
        '
        Me.RecordNumberLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordNumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RecordNumberLabel.Location = New System.Drawing.Point(353, 69)
        Me.RecordNumberLabel.Name = "RecordNumberLabel"
        Me.RecordNumberLabel.Size = New System.Drawing.Size(121, 23)
        Me.RecordNumberLabel.TabIndex = 44
        Me.RecordNumberLabel.Text = "Record Number"
        Me.RecordNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NewUserLinkLabel
        '
        Me.NewUserLinkLabel.AutoSize = True
        Me.NewUserLinkLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUserLinkLabel.Location = New System.Drawing.Point(379, 259)
        Me.NewUserLinkLabel.Name = "NewUserLinkLabel"
        Me.NewUserLinkLabel.Size = New System.Drawing.Size(63, 14)
        Me.NewUserLinkLabel.TabIndex = 45
        Me.NewUserLinkLabel.TabStop = True
        Me.NewUserLinkLabel.Text = "New User"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(360, 410)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.ShowPasswordCheckBox.TabIndex = 46
        Me.ShowPasswordCheckBox.Text = "Show password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'UserEditingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 496)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.NewUserLinkLabel)
        Me.Controls.Add(Me.RecordNumberLabel)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LookUpButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(User_RoleLabel)
        Me.Controls.Add(Me.User_RoleComboBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ZipCodeMaskedTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(User_StateLabel1)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(Me.RetypePasswordTextBox)
        Me.Controls.Add(User_LoginNameLabel)
        Me.Controls.Add(Me.UserLoginNameTextBox)
        Me.Controls.Add(User_PasswordLabel)
        Me.Controls.Add(Me.UserPasswordTextBox)
        Me.Controls.Add(User_FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(User_LastnameLabel)
        Me.Controls.Add(Me.LastnameTextBox)
        Me.Controls.Add(User_Address1Label)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(User_Address2Label)
        Me.Controls.Add(Me.Address2TextBox)
        Me.Controls.Add(User_CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(User_ZipcodeLabel)
        Me.Controls.Add(User_PhoneLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 534)
        Me.MinimumSize = New System.Drawing.Size(500, 534)
        Me.Name = "UserEditingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Editing"
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DuMegaDBDataSet As GroupProject.DuMegaDBDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As GroupProject.DuMegaDBDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As GroupProject.DuMegaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserLoginNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RetypePasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ZipCodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents User_RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents FirstButton As System.Windows.Forms.Button
    Friend WithEvents LastButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents LookUpButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents RecordNumberLabel As System.Windows.Forms.Label
    Friend WithEvents NewUserLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ShowPasswordCheckBox As System.Windows.Forms.CheckBox
End Class
