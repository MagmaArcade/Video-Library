'Author: Nathan
'Date modified: 17/08/2020
'Purpose: this section of code is used to modify the users personal data if i need updating or they wish to change it
'-------- as long as the new infomation is proofed by the validation the data itself holds no value, just makes some aspect feel more personal

Imports System.IO

Public Class Settings

#Region "Dims"
    Dim UserName() As String
    Dim Password() As String
    Dim UVCFileId() As String
    Dim Authority() As String
    Dim FirstName() As String
    Dim LastName() As String
    Dim Email() As String
    Dim Phone() As Integer
    Dim Adress() As String
    Dim Dob() As String

    Dim i As Integer = 0
    Dim Count As String

    Dim verificationCheck As Boolean = True
#End Region

#Region "On Load"
    Public Sub LoadInformation()
        'takes the information loaded in login form
        'and displays them here
        TbxUsername.Text = Login.UserName(Login.User)
        TbxPassword.Text = Login.Password(Login.User)
        TbxFirstName.Text = Login.FirstName(Login.User)
        TbxLastName.Text = Login.LastName(Login.User)
        TbxEmail.Text = Login.Email(Login.User)
        TbxPhoneNum.Text = Login.Phone(Login.User)
        TbxAdress.Text = Login.Adress(Login.User)
        DtpDob.Text = Login.Dob(Login.User)
    End Sub
#End Region

#Region "UpdatePersonalInformation"
    'read the text on the form 
    'saves over the existing information in the file
    Private Sub BtnUpdatePersonalInformation_Click(sender As Object, e As EventArgs) Handles BtnUpdatePersonalInformation.Click
        Validation()

        If verificationCheck = True Then
            Dim ConfirmMsg As Integer
            ConfirmMsg = MessageBox.Show("Are You Sure You Want to Update Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ConfirmMsg = vbYes Then
                'Save the updated information back into the login form
                'overwriting the existing information
                Login.UserName(Login.User) = TbxUsername.Text
                Login.Password(Login.User) = TbxPassword.Text
                Login.FirstName(Login.User) = TbxFirstName.Text
                Login.LastName(Login.User) = TbxLastName.Text
                Login.Email(Login.User) = TbxEmail.Text
                Login.Phone(Login.User) = TbxPhoneNum.Text
                Login.Adress(Login.User) = TbxAdress.Text
                Login.Dob(Login.User) = DtpDob.Text

                'this will rewrite everything in the User Details Database to accommodate the updated information
                'access the file
                Dim UserFile As Object = "User Details Database.txt"
                Dim srdUserFile As IO.StreamWriter
                If Not File.Exists(UserFile) Then
                    MsgBox("Connection Failed")
                End If
                srdUserFile = New IO.StreamWriter("User Details Database.txt")

                'for statment allow to write all user back into the file, using the max number
                'write into text file
                For a = 0 To Login.MaxUVCFileNum - 1
                    srdUserFile.WriteLine(Login.UserName(a))
                    srdUserFile.WriteLine(Login.Password(a))
                    srdUserFile.WriteLine(Login.UVCFileId(a))
                    srdUserFile.WriteLine(Login.Authority(a))
                    srdUserFile.WriteLine(Login.FirstName(a))
                    srdUserFile.WriteLine(Login.LastName(a))
                    srdUserFile.WriteLine(Login.Email(a))
                    srdUserFile.WriteLine(Login.Phone(a))
                    srdUserFile.WriteLine(Login.Adress(a))
                    srdUserFile.WriteLine(Login.Dob(a))
                Next
                srdUserFile.Close()

                'displays a confirmation message
                MsgBox("Personal Information Updated")
            End If
        End If
    End Sub
#End Region

#Region "Validation"
    Sub validation()
        If TbxUsername.Text = "" Then
            MsgBox("Please Enter a Username")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxPassword.Text = "" Then
            MsgBox("Please Enter a Password")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxUsername.Text.Length < 5 Then
            MsgBox("Please make sure username is longer than 5 characters")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxPassword.Text.Length < 5 Then
            MsgBox("Please make sure Password is longer than 5 characters")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxFirstName.Text = "" Then
            MsgBox("Please Enter Your First Name")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxLastName.Text = "" Then
            MsgBox("Please Enter Your Last Name")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text = "" Then
            MsgBox("Please Enter Your Email")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text.Length < 10 Then
            MsgBox("Please Make Sure You Enter Your Full Email")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text.Substring(TbxEmail.Text.Length - 10, 10) <> "@gmail.com" Then
            MsgBox("Please Make Sure You Enter Your Full Email")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxPhoneNum.Text = "" Then
            MsgBox("Please Enter Your Phone Number")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxPhoneNum.Text.Length > 10 Then
            MsgBox("Your Phone Number Is Too Long")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf TbxAdress.Text = "" Then
            MsgBox("Please Enter Your Adress")
            verificationCheck = False
            Focus()
            Exit Sub
        ElseIf DtpDob.Text = Today Then
            MsgBox("Please Enter Your Date of Birth")
            verificationCheck = False
            Focus()
            Exit Sub
        End If
    End Sub
#End Region

#Region "Menu Buttons"
    'Menu Buttons
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Home.Show()
        Home.Refresh()
    End Sub
    Private Sub BtnExplore_Click(sender As Object, e As EventArgs) Handles BtnExplore.Click
        Me.Hide()
        Explore.Show()
        Explore.Refresh()
        Explore.LoadInformation()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Hide()
        AddVideo.Show()
        AddVideo.Refresh()
        AddVideo.Clear()
    End Sub
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Me.Hide()
        Edit.Show()
        Edit.Refresh()
        Edit.LoadInformation()
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Are you sure you want to Log-Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
            MsgBox("Bye For Now")
            Me.Hide()
            Login.Show()
            Login.Refresh()
        End If
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
            MsgBox("Bye For Now")
            End
        End If
    End Sub

    'Menu picture boxes
    Private Sub PbxExit_Click(sender As Object, e As EventArgs) Handles PbxExit.Click
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
            MsgBox("Bye For Now")
            End
        End If
    End Sub
    Private Sub PbxHome_Click(sender As Object, e As EventArgs) Handles PbxHome.Click
        Me.Hide()
        Home.Show()
        Home.Refresh()
    End Sub
    Private Sub PbxSettings_Click(sender As Object, e As EventArgs) Handles PbxSettings.Click
        Me.Hide()
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
    End Sub
    Private Sub PbxEdit_Click(sender As Object, e As EventArgs) Handles PbxEdit.Click
        Me.Hide()
        Edit.Refresh()
        Edit.LoadInformation()
    End Sub
    Private Sub PbxAdd_Click(sender As Object, e As EventArgs) Handles PbxAdd.Click
        Me.Hide()
        AddVideo.Show()
        AddVideo.Refresh()
        AddVideo.Clear()
    End Sub
    Private Sub PbxExplore_Click(sender As Object, e As EventArgs) Handles PbxExplore.Click
        Me.Hide()
        Explore.Show()
        Explore.Refresh()
        Explore.LoadInformation()
    End Sub
    Private Sub PbxSignOut_Click(sender As Object, e As EventArgs) Handles PbxSignOut.Click
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Are you sure you want to Sign-Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
            MsgBox("Bye For Now")
            Me.Hide()
            Login.Show()
            Login.Refresh()
        End If
    End Sub

    'Other Methods to return to Home
    Private Sub PbxLogo_Click(sender As Object, e As EventArgs) Handles PbxLogo.Click
        Home.Show()
        Me.Hide()
        Home.Refresh()
    End Sub
    Private Sub LblMenu_Click(sender As Object, e As EventArgs) Handles LblMenu.Click
        Home.Show()
        Me.Hide()
        Home.Refresh()
    End Sub

    'search button
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.Hide()
        Search.Show()
        Search.Refresh()
        Search.LoadInformation()

        If TbxSearch.Text <> "" Then
            Search.TbxSearch.Text = TbxSearch.Text
        End If
    End Sub
#End Region

End Class