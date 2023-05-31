'Author: Nathan
'Date modified: 29/07/2020
'Purpose: this section of code is used register a new account with the program
'-------- this also gives the user a personal file in which their video collection is stored

Imports System.IO

Public Class Register

    Dim counter As Integer = 0
    Dim verificationCheck1 As Boolean = True
    Dim verificationCheck2 As Boolean = True

#Region "Main Code"
    Public Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        verificationCheck1 = True
        verificationCheck2 = True

        If counter = 0 Then
            validation1()

            If verificationCheck1 = True Then
                BtnBack.Visible = True
                GbxPersonalInformation.Visible = False
                GbxTerms.Visible = True
                counter = counter + 1
                Exit Sub
            End If

        ElseIf counter = 1 Then
            validation2()

            If verificationCheck2 = True Then
                'access the file
                Dim UserFile As Object = "User Details Database.txt"
                Dim srdUserFile As IO.StreamWriter
                If Not File.Exists(UserFile) Then
                    MsgBox("Connection Failed")
                End If
                srdUserFile = New IO.StreamWriter("User Details Database.txt", True)

                'write into text file
                srdUserFile.WriteLine(TbxUsername.Text)
                srdUserFile.WriteLine(TbxPassword.Text)
                'UVC is 'user collectin database'
                srdUserFile.WriteLine("UVC" & (Format((Int(Login.MaxUVCFileNum) + 1), "0000")) & ".txt")
                srdUserFile.WriteLine("Authority 0")
                srdUserFile.WriteLine(TbxFirstName.Text)
                srdUserFile.WriteLine(TbxLastName.Text)
                srdUserFile.WriteLine(TbxEmail.Text)
                srdUserFile.WriteLine(TbxPhone.Text)
                srdUserFile.WriteLine(TbxAdress.Text)
                srdUserFile.WriteLine(DtpDob.Text)
                srdUserFile.Close()

                'this bit of code is used to create a video collection file for the user
                Dim UserVideoFile As Object = "UVC" & (Format((Int(Login.MaxUVCFileNum) + 1), "0000")) & ".txt"
                Dim srdUserVideoFile As IO.StreamWriter
                If Not File.Exists(UserFile) Then
                    MsgBox("Connection Failed")
                End If
                srdUserVideoFile = New IO.StreamWriter("UVC" & (Format((Int(Login.MaxUVCFileNum) + 1), "0000")) & ".txt", True)

                'clears text and returns to the login form
                Clear()
                Me.Hide()
                Login.Show()
                Login.Refresh()

                'resets all of the neccacery positions
                BtnBack.Visible = False
                GbxPersonalInformation.Visible = True
                GbxTerms.Visible = False
                counter = 0

                'displays a confirmation message
                'the message will not be sent to the email as of yet
                MsgBox("A verification Email Has Been Sent")
            End If
        End If
    End Sub
#End Region

#Region "Validation"
    Public Sub validation1()
        MsgBox(TbxEmail.Text.Substring(TbxEmail.Text.Length - 9, 9))
        If TbxUsername.Text = "" Then
            MsgBox("Please Enter a Username")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxUsername.Text.Length < 5 Then
            MsgBox("Please make sure username is at least 5 characters")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxPassword.Text = "" Then
            MsgBox("Please Enter a Password")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxPassword.Text.Length < 5 Then
            MsgBox("Please make sure Password is longer than 5 characters")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxFirstName.Text = "" Then
            MsgBox("Please Enter Your First Name")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxLastName.Text = "" Then
            MsgBox("Please Enter Your Last Name")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text = "" Then
            MsgBox("Please Enter Your Email")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text.Length < 10 Then
            MsgBox("Please Make Sure You Enter Your Full Email")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxEmail.Text.Substring(TbxEmail.Text.Length - 10, 10) <> "@gmail.com" Then
            MsgBox("Please Make Sure You Enter Your Full Email")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxPhone.Text = "" Then
            MsgBox("Please Enter Your Phone Number")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxPhone.Text.Length > 10 Then
            MsgBox("Your Phone Number Is Too Long")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf TbxAdress.Text = "" Then
            MsgBox("Please Enter Your Address")
            verificationCheck1 = False
            Focus()
            Exit Sub
        ElseIf DtpDob.Text = Today Then
            MsgBox("Please Enter Your Date of Birth")
            verificationCheck1 = False
            Focus()
            Exit Sub
        End If
    End Sub
    Private Sub validation2()
        If CbxAgree.Checked = False Then
            MsgBox("You Must Accept the Terms and Conditions")
            verificationCheck2 = False
            Focus()
            Exit Sub
        End If
    End Sub
#End Region

#Region "Misc"
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Hide()
        Login.Show()
        Clear()
        GbxPersonalInformation.Visible = True
        GbxTerms.Visible = False
        counter = 0
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        BtnBack.Visible = False
        GbxPersonalInformation.Visible = True
        GbxTerms.Visible = False
        counter = counter - 1
    End Sub
    Public Sub Clear()
        'clear all 
        TbxUsername.Text = ""
        TbxPassword.Text = ""
        TbxFirstName.Text = ""
        TbxLastName.Text = ""
        TbxEmail.Text = ""
        TbxAdress.Text = ""
        TbxPhone.Text = ""
        DtpDob.Text = Today
        CbxAgree.Checked = False
    End Sub
#End Region
End Class