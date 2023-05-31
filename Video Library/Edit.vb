'Author: Nathan
'Date modified: 5/09/2020
'Purpose: this section of code is used to modify or delete data from a specific video and then overwrite the file with the new information
'-------- this secton works with the UpdateDelete form to assist in the modification or deletion process

Imports System.IO

Public Class Edit

#Region "Dims"
    Public Title() As String
    Public Genre() As String
    Public ReleaseDate() As Integer
    Public Classification() As String

    Dim count As Integer
    Dim counter As String
    Dim i As Integer
    Dim selecteditem As Integer

    Public a As Integer = 0
#End Region

#Region "On Load"
    Public Sub LoadInformation()
        LbxVideos.Items.Clear()
        'connect to the file
        'and save the information into the corrosponding arrays
        Dim VideoListFile As Object = (Login.UsersFile)
        Dim srdVideoList As IO.StreamReader
        If Not File.Exists(VideoListFile) Then
            MsgBox("Connection Failed")
        End If
        srdVideoList = New IO.StreamReader(Login.UsersFile)

        Do While Not srdVideoList.EndOfStream
            counter = srdVideoList.ReadLine()
            counter = srdVideoList.ReadLine()
            counter = srdVideoList.ReadLine()
            counter = srdVideoList.ReadLine()

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


        'sort through all of the data and display it in alphabetical order
        Dim lowerbound As Integer = LBound(Title) '--start index of array. 
        Dim upperbound As Integer = UBound(Title) '--end Index of Array. 
        Dim k As Integer = 0   '--Main Loop Counter for array processing. 
        Dim j As Integer = 0   '--Index counter Value to shuffle along 1 index step. 
        Dim intMinValueIndex As Integer     '--Index to move Minimum Value to.   
        Dim intSwapValueIndex As Integer    '--Index Value that Min Value is found at. 

        Dim intSwapValueTitle As String         '--Actual value of the found Minimum. 
        Dim intSwapValueGenre As String         '--Actual value of the found Minimum. 
        Dim intSwapValueReleaseDate As String         '--Actual value of the found Minimum. 
        Dim intSwapValueClassification As String         '--Actual value of the found Minimum. 


        '--Now Use a Loop to go through the array doing Selection Sort Passes.  
        For k = lowerbound To upperbound
            intMinValueIndex = k
            '--Reset the saved Swap Values from the last Pass of the Array. 
            intSwapValueTitle = "@"
            intSwapValueIndex = 0

            For j = k + 1 To upperbound
                '--Search and find the lowest value remaining in the array for this sort pass of the Array.  
                If Title(j) < Title(intMinValueIndex) Then
                    '--A value smaller than the current min position value has been found 
                    '--so possibly store its value and its position in the array. 
                    '--HOWEVER we may already have the smallest one sitting there stored. 
                    '--So only overwrite and store it if it is smaller than the stored one, 
                    '--except for if this is the first time a smaller found this pass. 
                    '--First check for first time finding a smaller value,  
                    '--then check if smallest so far. 
                    If intSwapValueTitle = "@" Then
                        intSwapValueTitle = Title(j)
                        intSwapValueGenre = Genre(j)
                        intSwapValueReleaseDate = ReleaseDate(j)
                        intSwapValueClassification = Classification(j)
                        intSwapValueIndex = j
                    Else
                        If Title(j) < intSwapValueTitle Then
                            intSwapValueTitle = Title(j)
                            intSwapValueGenre = Genre(j)
                            intSwapValueReleaseDate = ReleaseDate(j)
                            intSwapValueClassification = Classification(j)
                            intSwapValueIndex = j
                        End If
                    End If
                End If
            Next j

            If intSwapValueTitle <> "@" Then
                '--During the current pass we have found a smaller value in the remaining array. 
                '--We need to swap the value at min index to where the found swap value is 
                '--and move the saved found swap value to the current min index.       
                Title(intSwapValueIndex) = Title(intMinValueIndex)
                Title(intMinValueIndex) = intSwapValueTitle

                Genre(intSwapValueIndex) = Genre(intMinValueIndex)
                Genre(intMinValueIndex) = intSwapValueGenre

                ReleaseDate(intSwapValueIndex) = ReleaseDate(intMinValueIndex)
                ReleaseDate(intMinValueIndex) = intSwapValueReleaseDate

                Classification(intSwapValueIndex) = Classification(intMinValueIndex)
                Classification(intMinValueIndex) = intSwapValueClassification
            End If
        Next k
        For f = 1 To i
            LbxVideos.Items.Add(Title(f))
            count += 1
        Next
        If count = 0 Then
            LbxVideos.Items.Add("Sorry There Are No Videos Found")
        End If
    End Sub
#End Region

#Region "Open Edit/Delete Form"
    Private Sub LbxVideos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LbxVideos.MouseDoubleClick
        '--this is used to find the number in the array where the name shows up to allow for the editing or deletion of the video
        For b = 0 To count
            If LbxVideos.SelectedItem.ToString = Title(b) Then
                a = b
                UpdateDelete.Show()
                UpdateDelete.Refresh()
                UpdateDelete.LoadInformation()
                Me.Hide()
                Exit Sub
            End If
        Next
    End Sub
    Private Sub BtnEditDelete_Click(sender As Object, e As EventArgs) Handles BtnEditDelete.Click
        '--this is used to find the number in the array where the name shows up to allow for the editing or deletion of the video
        For b = 0 To count
            If LbxVideos.SelectedItem.ToString = Title(b) Then
                a = b
                UpdateDelete.Show()
                UpdateDelete.Refresh()
                UpdateDelete.LoadInformation()
                Me.Hide()
                Exit Sub
            End If
        Next
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
        Settings.Show()
        Settings.Refresh()
        Settings.LoadInformation()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Me.Hide()
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
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
        Me.Show()
        Me.Refresh()
        Me.LoadInformation()
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