'Author: Nathan
'Date modified: 26/08/2020
'Purpose: this section of code is used to view a random selection of 10 videos from the users file

Imports System.IO

Public Class Explore

#Region "Dims"
    Dim Title() As String
    Dim Genre() As String
    Dim ReleaseDate() As Integer
    Dim Classification() As String

    Dim Counter As String
    Dim i As Integer

    'random value dims
    Dim RandomArrayNum As Integer
#End Region

#Region "On Load"
    Public Sub LoadInformation()
        'connect to the file
        Dim VideoListFile As Object = (Login.UsersFile)
        Dim srdVideoList As IO.StreamReader
        If Not File.Exists(VideoListFile) Then
            MsgBox("Connection Failed")
        End If
        srdVideoList = New IO.StreamReader(Login.UsersFile)

        Do While Not srdVideoList.EndOfStream
            Counter = srdVideoList.ReadLine()
            Counter = srdVideoList.ReadLine()
            Counter = srdVideoList.ReadLine()
            Counter = srdVideoList.ReadLine()

            i = i + 1
        Loop
        srdVideoList.Close()

        'redim all items
        ReDim Title(i)
        ReDim Genre(i)
        ReDim ReleaseDate(i)
        ReDim Classification(i)

        'reads and stores all items
        srdVideoList = New IO.StreamReader(Login.UsersFile)

        For x = 0 To i - 1
            Title(x) = srdVideoList.ReadLine()
            Genre(x) = srdVideoList.ReadLine()
            ReleaseDate(x) = srdVideoList.ReadLine()
            Classification(x) = srdVideoList.ReadLine()
        Next
        srdVideoList.Close()

        RandomList()
    End Sub
#End Region

#Region "RandomeList"
    Sub RandomList()
        LbxVideos.Items.Clear()

        Dim Rnd As New Random
        Dim UsedList As New List(Of Integer)
        Dim count As Integer = 0

        For a = 0 To 30  '-- the issue was it went through the whole list without randomly generating 10 numbers that were valid
            ' for smaller list this is an issue but when i increade the size of the list the number of displayed 
            ' items became 10 more frequently
            If count < 10 Then
                RandomArrayNum = Rnd.Next(0, i - 1)     ' -- generates a random number between 0 and file number count

                If UsedList.Contains(RandomArrayNum) Then
                    'we will try again 

                Else
                    'this round is complete -- found a unique number
                    'adds the corrosponding video to the list box
                    'LbxVideos.Items.Add(RandomArrayNum)            '-- this line is used to check if the numbers are being read correctly
                    LbxVideos.Items.Add((Title(RandomArrayNum)))
                    LbxVideos.Items.Add(ReleaseDate(RandomArrayNum) & " | " & Classification(RandomArrayNum))
                    LbxVideos.Items.Add(Genre(RandomArrayNum))
                    LbxVideos.Items.Add("------------------------")

                    UsedList.Add(RandomArrayNum)
                    count += 1
                End If
            Else : Exit For
            End If
        Next
    End Sub
#End Region

#Region "Misc"
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RandomList()
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
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Hide()
        AddVideo.Show()
        AddVideo.Refresh()
        AddVideo.Clear()
    End Sub
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Settings.Show()
        Settings.Refresh()
        Settings.LoadInformation()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Me.Hide()
        Edit.Show()
        Edit.Refresh()
        Edit.LoadInformation()
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Are you sure you want to Sign-Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
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
        Settings.Show()
        Settings.Refresh()
        Settings.LoadInformation()
    End Sub
    Private Sub PbxEdit_Click(sender As Object, e As EventArgs) Handles PbxEdit.Click
        Me.Hide()
        Edit.Show()
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
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
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