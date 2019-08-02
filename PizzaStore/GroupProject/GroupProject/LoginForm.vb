Public Class LoginForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim LoginResultBoolean As Boolean = False
        Dim UserIdInteger As Integer = 0
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please enter your username and password", "Warning!")
        Else
            Dim UserRoleString As String = "Customer"
            For Each drRow As DataRow In DuMegaDBDataSet.User
                Dim UserNameString As String = drRow.Item("User_LoginName").ToString
                Dim UserPasswordString As String = drRow.Item("User_Password").ToString
                If UserNameString = UsernameTextBox.Text Then
                    If UserPasswordString = PasswordTextBox.Text Then
                        LoginResultBoolean = True
                        UserIdInteger = drRow.Item("User_ID").ToString
                        UserRoleString = drRow.Item("User_Role").ToString
                        If LoginResultBoolean Then
                            MessageBox.Show("Login successfully!", "Welcome!")
                            UsernameTextBox.Focus()
                            UsernameTextBox.Text = ""
                            PasswordTextBox.Text = ""
                            MainWindow.UserIdInteger = UserIdInteger
                            MainWindow.UserRoleString = UserRoleString
                            MainWindow.UserFirstName = drRow.Item("User_Firstname")
                            MainWindow.UserLastName = drRow.Item("User_Lastname")
                            MainWindow.CustomizedView()
                            'TO DO - direct to main screen
                            Me.Visible = False
                            MainWindow.Show()
                        Else
                            MessageBox.Show("Login Failed", "Error")
                            UsernameTextBox.Focus()
                        End If
                    Else
                        MessageBox.Show("Username or Password is incorrect!", "Warning!")
                        UsernameTextBox.Focus()
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        PasswordTextBox.Clear()
        With UsernameTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DuMegaDBDataSet)
    End Sub

    Friend Sub UpdateUsers()
        Me.UserTableAdapter.Fill(Me.DuMegaDBDataSet.User)
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateUsers()
    End Sub

    
    Private Sub NewCustomerLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewCustomerLinkLabel.LinkClicked
        ClearForm()
        CustomerRegistrationForm.Show()
    End Sub


    Private Sub Login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            MessageBox.Show("Only manager may close this program", "Warning!")
        End If
    End Sub
End Class
