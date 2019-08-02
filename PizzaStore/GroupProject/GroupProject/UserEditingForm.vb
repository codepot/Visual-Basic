Public Class UserEditingForm

    Private NewDataRowView As DataRowView
    Private ValidationBoolean As Boolean = False
    Private CreatingBoolean As Boolean = False
    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)

    End Sub

    Private Sub CustomerRegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DuMegaDBDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DuMegaDBDataSet.User)
        UpdateRecordNo()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        FirstnameTextBox.Clear()
        LastnameTextBox.Clear()
        Address1TextBox.Clear()
        Address2TextBox.Clear()
        CityTextBox.Clear()
        StateComboBox.SelectedIndex = 5
        ZipCodeMaskedTextBox.Clear()
        PhoneMaskedTextBox.Clear()
        UserLoginNameTextBox.Clear()
        UserPasswordTextBox.Clear()
        RetypePasswordTextBox.Clear()
        FirstnameTextBox.Focus()
        User_RoleComboBox.SelectedIndex = 0
    End Sub

    Private Function DoesLoginNameExist(ByVal LoginNameString As String) As Boolean
        For Each drRow As DataRow In DuMegaDBDataSet.Tables(1).Rows
            Dim UserInDBString = drRow("User_LoginName")
            If UserInDBString = LoginNameString Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click
        Me.UserBindingSource.MoveFirst()
        UpdateRecordNo()
    End Sub

    Private Sub UpdateRecordNo()
        RecordNumberLabel.Text = Me.UserBindingSource.Position + 1 & "/" & Me.UserBindingSource.Count
    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        Me.UserBindingSource.MoveNext()
        UpdateRecordNo()
    End Sub

    Private Sub PreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        Me.UserBindingSource.MovePrevious()
        UpdateRecordNo()
    End Sub

    Private Sub LastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButton.Click
        Me.UserBindingSource.MoveLast()
        UpdateRecordNo()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If Me.UserBindingSource.Count > 0 Then
            Me.UserBindingSource.RemoveCurrent()
            UpdateRecordNo()
        Else
            MessageBox.Show("There is no more record in the database")
        End If
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub persitent()
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        ClearButton.Enabled = False
        persitent()
        Me.UserTableAdapter.Fill(Me.DuMegaDBDataSet.User)
    End Sub

    Private Sub LookUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpButton.Click
        Dim InputString As String
        Dim PositionInteger As Integer
        Try
            InputString = Microsoft.VisualBasic.InputBox("Please enter a User ID", "", "0")

            If IsNumeric(InputString) Then
                PositionInteger = Me.UserBindingSource.Find("User_ID", InputString)
                If PositionInteger = -1 Then
                    MessageBox.Show("No such user with that ID number", "Invalid Data")
                Else
                    Me.UserBindingSource.Position = PositionInteger
                End If
                UpdateRecordNo()
            Else
                MessageBox.Show("Please enter the User ID", "Integer Input")
            End If
        Catch ex As Exception
            MessageBox.Show("You are requested to enter integer only", "Invalid Data")
        End Try
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim FirstNameString As String = FirstnameTextBox.Text
        Dim LastNameString As String = LastnameTextBox.Text
        Dim Address1String As String = Address1TextBox.Text.Trim
        Dim Address2String As String = Address2TextBox.Text.Trim
        Dim CityString As String = CityTextBox.Text.Trim
        Dim StateString As String = StateComboBox.SelectedItem.ToString
        Dim ZipCodeString As String = ZipCodeMaskedTextBox.Text.Replace("-", "")
        Dim PhoneString As String = PhoneMaskedTextBox.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim
        Dim UserLoginString As String = UserLoginNameTextBox.Text
        Dim PasswordString As String = UserPasswordTextBox.Text
        Dim RetypePasswordString As String = RetypePasswordTextBox.Text
        If FirstNameString.Trim.Length > 0 Then
            If LastNameString.Trim.Length > 0 Then
                If ZipCodeString.Trim.Length = 5 Or ZipCodeString.Trim.Length = 9 Then
                    If PhoneString.Length = 10 Then
                        If UserLoginString.Trim.Length >= 4 Then
                            If Not DoesLoginNameExist(UserLoginString) Then
                                If PasswordString.Length >= 4 Then
                                    If PasswordString = RetypePasswordString Then
                                        'add record here 
                                        'Dim NewDataRowView As DataRowView = CType(UserBindingSource.AddNew(), DataRowView)
                                        NewDataRowView("User_Role") = User_RoleComboBox.SelectedItem.ToString
                                        NewDataRowView("User_LoginName") = UserLoginString
                                        NewDataRowView("User_Password") = PasswordString
                                        NewDataRowView("User_Firstname") = FirstNameString
                                        NewDataRowView("User_Lastname") = LastNameString
                                        NewDataRowView("User_Register_Date") = Now.ToShortDateString
                                        NewDataRowView("User_Address1") = Address1String
                                        NewDataRowView("User_Address2") = Address2String
                                        NewDataRowView("User_City") = CityString
                                        NewDataRowView("User_State") = StateComboBox.SelectedItem.ToString
                                        NewDataRowView("User_Zipcode") = ZipCodeString
                                        NewDataRowView("User_Phone") = PhoneString
                                        persitent()
                                        MessageBox.Show("The account has just been created.")
                                        ValidationBoolean = True
                                        NewUserLinkLabel.Visible = True
                                        AddButton.Visible = False
                                        persitent()
                                        LoginForm.UpdateUsers()
                                        EnableButtons()
                                        CreatingBoolean = False
                                        If Not ValidationBoolean Then
                                            NewDataRowView = Nothing
                                            UserBindingSource.RemoveCurrent()
                                            UpdateRecordNo()
                                            ValidationBoolean = False
                                            Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
                                        End If
                                    Else
                                        MessageBox.Show("Password and re-typed password do not match.")
                                        RetypePasswordTextBox.Focus()
                                    End If
                                Else
                                    MessageBox.Show("Password must contain at least 4 characters.")
                                    UserPasswordTextBox.Focus()
                                End If
                            Else
                                MessageBox.Show("Oop! " & UserLoginString & "is chosen as someone's login name" & Environment.NewLine & "Please enter another one.")
                                UserLoginNameTextBox.Focus()
                            End If
                        Else
                            MessageBox.Show("Login name must contain at least 4 characters.")
                            UserLoginNameTextBox.Focus()
                        End If
                    Else
                        MessageBox.Show("Please enter a valid phone number.")
                        PhoneMaskedTextBox.Focus()
                    End If

                Else
                    MessageBox.Show("Please enter a zip code.")
                    ZipCodeMaskedTextBox.Focus()
                End If
            Else
                MessageBox.Show("Please enter a valid last name.")
                LastnameTextBox.Focus()
            End If
        Else
            MessageBox.Show("Please enter a valid first name.")
            FirstnameTextBox.Focus()
        End If
        

    End Sub

    Private Sub NewUserLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewUserLinkLabel.LinkClicked
        NewDataRowView = CType(UserBindingSource.AddNew(), DataRowView)
        CreatingBoolean = True
        NewUserLinkLabel.Visible = False
        AddButton.Visible = True
        StateComboBox.SelectedIndex = 5
        User_RoleComboBox.SelectedIndex = 0
        UpdateRecordNo()
        DisableButtons()
        ClearButton.Enabled = True
    End Sub

    Private Sub DisableButtons()
        FirstButton.Enabled = False
        LastButton.Enabled = False
        NextButton.Enabled = False
        PreviousButton.Enabled = False
        DeleteButton.Enabled = False
        SaveButton.Enabled = False
        LookUpButton.Enabled = False
    End Sub

    Private Sub EnableButtons()
        FirstButton.Enabled = True
        LastButton.Enabled = True
        NextButton.Enabled = True
        PreviousButton.Enabled = True
        DeleteButton.Enabled = True
        SaveButton.Enabled = True
        LookUpButton.Enabled = True
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        CloseForm()
    End Sub

    Private Sub CloseForm()
        If CreatingBoolean Then
            NewDataRowView = Nothing
            UserBindingSource.RemoveCurrent()
            UpdateRecordNo()
            ValidationBoolean = False
            Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
            LoginForm.Refresh()

        End If
        Me.Visible = False
        MainWindow.Show()
        NewUserLinkLabel.Visible = True
        AddButton.Visible = False
        EnableButtons()
        ClearButton.Enabled = False
    End Sub

    Private Sub UserEditing_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            CloseForm()
        End If
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked Then
            UserPasswordTextBox.PasswordChar = Chr(0)
        Else
            UserPasswordTextBox.PasswordChar = "*"
        End If
    End Sub
End Class