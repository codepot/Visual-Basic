Public Class CustomerRegistrationForm

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)

    End Sub

    Private Sub CustomerRegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DuMegaDBDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DuMegaDBDataSet.User)
        StateComboBox.SelectedIndex = 5
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearForm()
    End Sub

    Friend Sub ClearForm()
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
        With FirstnameTextBox
            .Clear()
            .Focus()
        End With
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

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click

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
                                        Dim NewDataRowView As DataRowView = CType(UserBindingSource.AddNew(), DataRowView)
                                        NewDataRowView("User_Role") = "Customer"
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
                                        ClearForm()
                                        MessageBox.Show("Your account has just been created." & Environment.NewLine & "Your're requested to log in.")
                                        Me.Visible = False
                                        LoginForm.UpdateUsers()
                                        LoginForm.Show()
                                        LoginForm.UsernameTextBox.Text = UserLoginString
                                        LoginForm.PasswordTextBox.Focus()
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

    Private Sub persitent()
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Private Sub CustomerRegistrationForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visible = False
        LoginForm.ShowDialog()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Visible = False
        'LoginForm.ShowDialog()
    End Sub
    
End Class