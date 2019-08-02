<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerRegistrationForm))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
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
        CType(Me.DuMegaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_LoginNameLabel
        '
        User_LoginNameLabel.AutoSize = True
        User_LoginNameLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_LoginNameLabel.Location = New System.Drawing.Point(30, 314)
        User_LoginNameLabel.Name = "User_LoginNameLabel"
        User_LoginNameLabel.Size = New System.Drawing.Size(153, 19)
        User_LoginNameLabel.TabIndex = 25
        User_LoginNameLabel.Text = "User Login Name:"
        '
        'User_PasswordLabel
        '
        User_PasswordLabel.AutoSize = True
        User_PasswordLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PasswordLabel.Location = New System.Drawing.Point(30, 343)
        User_PasswordLabel.Name = "User_PasswordLabel"
        User_PasswordLabel.Size = New System.Drawing.Size(135, 19)
        User_PasswordLabel.TabIndex = 26
        User_PasswordLabel.Text = "User Password:"
        '
        'User_FirstnameLabel
        '
        User_FirstnameLabel.AutoSize = True
        User_FirstnameLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_FirstnameLabel.Location = New System.Drawing.Point(30, 89)
        User_FirstnameLabel.Name = "User_FirstnameLabel"
        User_FirstnameLabel.Size = New System.Drawing.Size(108, 19)
        User_FirstnameLabel.TabIndex = 17
        User_FirstnameLabel.Text = "First Name:"
        '
        'User_LastnameLabel
        '
        User_LastnameLabel.AutoSize = True
        User_LastnameLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_LastnameLabel.Location = New System.Drawing.Point(30, 118)
        User_LastnameLabel.Name = "User_LastnameLabel"
        User_LastnameLabel.Size = New System.Drawing.Size(99, 19)
        User_LastnameLabel.TabIndex = 18
        User_LastnameLabel.Text = "Last Name:"
        '
        'User_Address1Label
        '
        User_Address1Label.AutoSize = True
        User_Address1Label.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_Address1Label.Location = New System.Drawing.Point(30, 146)
        User_Address1Label.Name = "User_Address1Label"
        User_Address1Label.Size = New System.Drawing.Size(99, 19)
        User_Address1Label.TabIndex = 19
        User_Address1Label.Text = "Address 1:"
        '
        'User_Address2Label
        '
        User_Address2Label.AutoSize = True
        User_Address2Label.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_Address2Label.Location = New System.Drawing.Point(30, 174)
        User_Address2Label.Name = "User_Address2Label"
        User_Address2Label.Size = New System.Drawing.Size(99, 19)
        User_Address2Label.TabIndex = 20
        User_Address2Label.Text = "Address 2:"
        '
        'User_CityLabel
        '
        User_CityLabel.AutoSize = True
        User_CityLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_CityLabel.Location = New System.Drawing.Point(30, 202)
        User_CityLabel.Name = "User_CityLabel"
        User_CityLabel.Size = New System.Drawing.Size(54, 19)
        User_CityLabel.TabIndex = 21
        User_CityLabel.Text = "City:"
        '
        'User_ZipcodeLabel
        '
        User_ZipcodeLabel.AutoSize = True
        User_ZipcodeLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_ZipcodeLabel.Location = New System.Drawing.Point(30, 257)
        User_ZipcodeLabel.Name = "User_ZipcodeLabel"
        User_ZipcodeLabel.Size = New System.Drawing.Size(90, 19)
        User_ZipcodeLabel.TabIndex = 23
        User_ZipcodeLabel.Text = "Zip Code:"
        '
        'User_PhoneLabel
        '
        User_PhoneLabel.AutoSize = True
        User_PhoneLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_PhoneLabel.Location = New System.Drawing.Point(30, 285)
        User_PhoneLabel.Name = "User_PhoneLabel"
        User_PhoneLabel.Size = New System.Drawing.Size(126, 19)
        User_PhoneLabel.TabIndex = 24
        User_PhoneLabel.Text = "Phone Number:"
        '
        'User_StateLabel1
        '
        User_StateLabel1.AutoSize = True
        User_StateLabel1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_StateLabel1.Location = New System.Drawing.Point(30, 231)
        User_StateLabel1.Name = "User_StateLabel1"
        User_StateLabel1.Size = New System.Drawing.Size(63, 19)
        User_StateLabel1.TabIndex = 22
        User_StateLabel1.Text = "State:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Label1.Location = New System.Drawing.Point(159, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(251, 37)
        Label1.TabIndex = 30
        Label1.Text = "Pizza Du Mega"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Teal
        Label2.Location = New System.Drawing.Point(221, 43)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(155, 28)
        Label2.TabIndex = 31
        Label2.Text = "New Account"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(29, 368)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(162, 19)
        Label3.TabIndex = 27
        Label3.Text = "Re-type Password:"
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
        Me.UserLoginNameTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLoginNameTextBox.Location = New System.Drawing.Point(192, 311)
        Me.UserLoginNameTextBox.Name = "UserLoginNameTextBox"
        Me.UserLoginNameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.UserLoginNameTextBox.TabIndex = 9
        '
        'UserPasswordTextBox
        '
        Me.UserPasswordTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPasswordTextBox.Location = New System.Drawing.Point(192, 338)
        Me.UserPasswordTextBox.Name = "UserPasswordTextBox"
        Me.UserPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPasswordTextBox.Size = New System.Drawing.Size(200, 26)
        Me.UserPasswordTextBox.TabIndex = 10
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(192, 86)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameTextBox.Location = New System.Drawing.Point(192, 115)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LastnameTextBox.TabIndex = 2
        '
        'Address1TextBox
        '
        Me.Address1TextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(192, 143)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address1TextBox.TabIndex = 3
        '
        'Address2TextBox
        '
        Me.Address2TextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2TextBox.Location = New System.Drawing.Point(192, 171)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address2TextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(192, 199)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CityTextBox.TabIndex = 5
        '
        'RetypePasswordTextBox
        '
        Me.RetypePasswordTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetypePasswordTextBox.Location = New System.Drawing.Point(192, 365)
        Me.RetypePasswordTextBox.Name = "RetypePasswordTextBox"
        Me.RetypePasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RetypePasswordTextBox.Size = New System.Drawing.Size(200, 26)
        Me.RetypePasswordTextBox.TabIndex = 11
        '
        'StateComboBox
        '
        Me.StateComboBox.BackColor = System.Drawing.Color.White
        Me.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateComboBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Marianas Islands", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Virgin Islands", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.StateComboBox.Location = New System.Drawing.Point(192, 226)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(200, 27)
        Me.StateComboBox.TabIndex = 6
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(192, 283)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PhoneMaskedTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GroupProject.My.Resources.Resources.PizzaDuMega
        Me.PictureBox1.Location = New System.Drawing.Point(50, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ZipCodeMaskedTextBox
        '
        Me.ZipCodeMaskedTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeMaskedTextBox.Location = New System.Drawing.Point(192, 255)
        Me.ZipCodeMaskedTextBox.Mask = "00000-9999"
        Me.ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        Me.ZipCodeMaskedTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ZipCodeMaskedTextBox.TabIndex = 7
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(198, 409)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 27)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clea&r Form"
        Me.ClearButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(299, 409)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 27)
        Me.SubmitButton.TabIndex = 12
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(63, 409)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 27)
        Me.BackButton.TabIndex = 32
        Me.BackButton.Text = "&Cancel"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CustomerRegistrationForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackButton
        Me.ClientSize = New System.Drawing.Size(431, 459)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SubmitButton)
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
        Me.MaximumSize = New System.Drawing.Size(467, 497)
        Me.Name = "CustomerRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Customer Registration"
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ZipCodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
