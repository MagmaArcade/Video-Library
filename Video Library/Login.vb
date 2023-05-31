'Author: Nathan
'Date modified: 23/07/2020
'Purpose: this section of code is used as a safeguard to protect the users private data
'-------- this code also works to identify which users data need to be opened and displayed

Imports System.IO

Public Class Login
#Region "Dim's"
    Dim ValidationCheck As Boolean = True
    Public MaxUVCFileNum As Integer
    Public UsersFile As String
    Public User As Integer

    'the text file inforamtion
    Public UserName() As String
    Public Password() As String
    Public UVCFileId() As String
    Public Authority() As String
    Public FirstName() As String
    Public LastName() As String
    Public Email() As String
    Public Phone() As Integer
    Public Adress() As String
    Public Dob() As String

    'validation checks
    Dim UserNameValidation As Boolean = False
    Dim PasswordValidation As Boolean = False
    Dim LoginValidation As Boolean = False


    'other dims
    Dim Count As String
    Dim i As Integer = 0
#End Region

#Region "On Load"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connect the file
        Dim UserFile As Object = "User Details Database.txt"
        Dim srdUserFile As IO.StreamReader
        If Not File.Exists(UserFile) Then
            MsgBox("Connection Failed")
        End If
        srdUserFile = New IO.StreamReader("User Details Database.txt")

        Do While Not srdUserFile.EndOfStream
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            Count = srdUserFile.ReadLine()
            i = i + 1
        Loop
        srdUserFile.Close()

        'redim all items
        ReDim UserName(i)
        ReDim Password(i)
        ReDim UVCFileId(i)
        ReDim Authority(i)
        ReDim FirstName(i)
        ReDim LastName(i)
        ReDim Email(i)
        ReDim Phone(i)
        ReDim Adress(i)
        ReDim Dob(i)

        MaxUVCFileNum = i

        'reads and stores all items
        srdUserFile = New IO.StreamReader("User Details Database.txt")

        For a = 0 To i - 1
            UserName(a) = srdUserFile.ReadLine()
            Password(a) = srdUserFile.ReadLine()
            UVCFileId(a) = srdUserFile.ReadLine()
            Authority(a) = srdUserFile.ReadLine()
            FirstName(a) = srdUserFile.ReadLine()
            LastName(a) = srdUserFile.ReadLine()
            Email(a) = srdUserFile.ReadLine()
            Phone(a) = srdUserFile.ReadLine()
            Adress(a) = srdUserFile.ReadLine()
            Dob(a) = srdUserFile.ReadLine()
        Next
        srdUserFile.Close()
    End Sub
#End Region

#Region "Main Code"
    Public Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Validation()
        If ValidationCheck = True Then

            For b = 0 To i - 1
                If UserName(b) = TbxUsername.Text Then
                    UserNameValidation = True
                End If
                If Password(b) = TbxPassword.Text Then
                    PasswordValidation = True
                End If

                If UserNameValidation = True And PasswordValidation = True Then
                    LoginValidation = True
                    User = b
                    UsersFile = UVCFileId(b)
                    Exit For
                End If
            Next

            'Enter the main form

            If LoginValidation = True Then
                'clear the text box
                BtnClear_Click(sender, e)

                'personal touch

                'open main form
                Me.Hide()
                Home.Show()
                Exit Sub
            Else
                MsgBox("Username or Password is Incorrect")
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "Validation"
    Private Sub Validation()
        If TbxUsername.Text = "" Or TbxPassword.Text = "" Then
            MsgBox("Wrong Username or Password")
            ValidationCheck = False
            Exit Sub
        End If
        If TbxUsername.Text.Length < 5 Or TbxPassword.Text.Length < 5 Then
            MsgBox("Wrong Username or Password")
            ValidationCheck = False
            Exit Sub
        End If
    End Sub

#End Region

#Region "Register"

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.Hide()
        Register.Show()
        Register.Clear()
        Register.GbxPersonalInformation.Visible = True
        Register.GbxTerms.Visible = False
    End Sub
#End Region

#Region "Misc"
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        If TbxPassword.PasswordChar = "•" Then
            TbxPassword.PasswordChar = ""
            Exit Sub
        Else
            TbxPassword.PasswordChar = "•"
        End If
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TbxPassword.Text = ""
        TbxUsername.Text = ""
    End Sub
#End Region
End Class
