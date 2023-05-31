'Author: Nathan
'Date modified: 11/08/2020
'Purpose: this section of code is used to find a specific video within their private collection
'-------- this is programed to have a range of methods to find the desired video, through name, genre, and release date search filters

Imports System.IO

Public Class Search
#Region "dims"
    Dim Title() As String
    Dim Genre() As String
    Dim ReleaseDate() As Integer
    Dim Classification() As String

    Dim z As Integer = 0
    Dim i As Integer = 0
    Dim l As Integer = 0
    Dim NumOfVideos As Integer = 0
    Dim SearchBox As String
    Dim Count As Integer
    Dim Counter As String

    Dim verificationCheck As Boolean = True
#End Region

#Region "on load"
    Public Sub LoadInformation()
        CbxSearchBy.SelectedIndex = 0

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
        z = i

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
    End Sub
#End Region

#Region "Main Code"
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LbxVideos.Items.Clear()
        Count = 0

        'the if statment allows to view all videos without a search entery
        If CbxSearchBy.SelectedIndex <> 0 Then
            Validation()
        End If


        If verificationCheck = True Then
            'search and sort
            Select Case CbxSearchBy.SelectedIndex
                'all
                Case 0
                    'Perform a selection sort on title
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
                        LbxVideos.Items.Add((Title(f)))
                        LbxVideos.Items.Add(ReleaseDate(f) & " | " & Classification(f))
                        LbxVideos.Items.Add(Genre(f))
                        LbxVideos.Items.Add("------------------------")
                        Count += 1
                    Next
                    If Count = 0 Then
                        LbxVideos.Items.Add("Sorry There Are No Videos Found")
                    End If

                    'title
                Case 1
                    For a = 1 To i
                        If Title(a) = TbxSearch.Text Then
                            LbxVideos.Items.Add(Title(a))
                            LbxVideos.Items.Add(ReleaseDate(a) & " | " & Classification(a))
                            LbxVideos.Items.Add(Genre(a))
                            LbxVideos.Items.Add("------------------------")
                            Count += 1
                        End If
                    Next
                    If Count = 0 Then
                        LbxVideos.Items.Add("Sorry There Are No Videos Found by The Name of '" & TbxSearch.Text & "'")
                    End If

                    'genre
                Case 2
                    Dim GenreTemp As String

                    For b = 0 To i - 1
                        GenreTemp = Genre(b)
                        Dim GenreReader() As String = Split(GenreTemp, ",")

                        For Each Word In GenreReader
                            Trim(Word)
                            If Word = TbxSearch.Text Then
                                LbxVideos.Items.Add(Title(b))
                                LbxVideos.Items.Add(ReleaseDate(b) & " | " & Classification(b))
                                LbxVideos.Items.Add(Genre(b))
                                LbxVideos.Items.Add("------------------------")
                                Count += 1
                            End If
                        Next
                    Next
                    If Count = 0 Then
                        LbxVideos.Items.Add("Sorry There Are No Videos With The Genre of '" & TbxSearch.Text & "'")
                    End If

                    'release date
                Case 3
                    For c = 0 To i - 1
                        If ReleaseDate(c) = TbxSearch.Text Then
                            LbxVideos.Items.Add(Title(c))
                            LbxVideos.Items.Add(ReleaseDate(c) & " | " & Classification(c))
                            LbxVideos.Items.Add(Genre(c))
                            LbxVideos.Items.Add("------------------------")
                            Count += 1
                        End If
                    Next
                    If Count = 0 Then
                        LbxVideos.Items.Add("Sorry There Are No Videos Released in '" & TbxSearch.Text & "'")
                    End If
            End Select
        End If
    End Sub
#End Region

#Region "Validation"
    Public Sub Validation()
        'title validation
        If CbxSearchBy.SelectedIndex = 1 Then
            'existence check
            If TbxSearch.Text = "" Then
                verificationCheck = False
                MsgBox("Please Enter A Title")
                Exit Sub
            End If
            'genre validation
        ElseIf CbxSearchBy.SelectedIndex = 2 Then
            'existence check
            If TbxSearch.Text = "" Then
                verificationCheck = False
                MsgBox("Please Enter A Genre")
                Exit Sub
                'Numeric Check
                'genre should not contain any numbers
            ElseIf IsNumeric(TbxSearch.Text) = True Then
                verificationCheck = False
                MsgBox("Genre's Must Not Include Numbers")
                Exit Sub
            End If
            'release date validation
        ElseIf CbxSearchBy.SelectedIndex = 3 Then
            'existence check
            If TbxSearch.Text = "" Then
                verificationCheck = False
                MsgBox("Please Enter A Release Date")
                Exit Sub
                'Length Check
                'they search should only be the year of release
            ElseIf TbxSearch.Text.Length <> 4 Then
                verificationCheck = False
                MsgBox("Please Only Enter The Year of Release")
                Exit Sub
                'Numeric Check
                'year should not contain any letters
            ElseIf IsNumeric(TbxSearch.Text) = False Then
                verificationCheck = False
                MsgBox("Please Only Enter The Year of Release")
                Exit Sub
            ElseIf TbxSearch.Text > Year(Today) Then
                verificationCheck = False
                MsgBox("The Movie Cannot Be Release in The Future")
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "Menu Buttons"
    'Menu Buttons
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Home.Show()
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
#End Region

End Class