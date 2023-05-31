'Author: Nathan
'Date modified: 5/08/2020
'Purpose: this section of code is used to add videos to the users private video collection

Imports System.IO

Public Class AddVideo

#Region "Dims"
    Dim verificationCheck As Boolean = True
    Dim counterReleaseDate = 0
    Dim counterGenre = 0
#End Region

#Region "Main Code"
#Region "Add Video"
    Private Sub BtnAddVideo_Click(sender As Object, e As EventArgs) Handles BtnAddVideo.Click
        'establishes a link to the text file
        Dim VideoListFile As Object = (Login.UsersFile)
        Dim srdVideoList As IO.StreamWriter

        If Not File.Exists(VideoListFile) Then
            MsgBox("Connection Failed")
            Exit Sub
        End If
        srdVideoList = New IO.StreamWriter(Login.UsersFile, True)

        'validates the user input
        'then writes it into a text file
        Validation()
        If verificationCheck = True Then
            Dim ConfirmMsg As Integer
            ConfirmMsg = MessageBox.Show("Confirm Video Information", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ConfirmMsg = vbYes Then

                'write in the variable into the file
                srdVideoList.WriteLine(TbxTitle.Text)
                srdVideoList.WriteLine(TbxGenre.Text)
                srdVideoList.WriteLine(TbxReleaseDate.Text)
                srdVideoList.WriteLine(CbxClassification.Text)

                srdVideoList.Close()

                'clear info and message confirming the adding of the video 
                Clear()
                MsgBox("Your Video Was Added")
            Else : Exit Sub
            End If
        Else : srdVideoList.Close()
        End If

    End Sub
#End Region

#Region "Genre"
    Private Sub BtnAddGenre_Click(sender As Object, e As EventArgs) Handles BtnAddGenre.Click
        Select Case CbxGenre.SelectedIndex
            'all genres
            'if it is the first entry replace the text with the added genre
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23
                If TbxGenre.Text = "" Or TbxGenre.Text = "XXX, YYY, ZZZ" Then
                    TbxGenre.Text = CbxGenre.Text
                    counterGenre = counterGenre + 1
                Else
                    'else add the genre onto the end with a comma seperation
                    TbxGenre.Text = (TbxGenre.Text & ", " & CbxGenre.Text)
                End If
        End Select
    End Sub
#End Region

#Region "Classifications"
    Private Sub CbxRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClassification.SelectedIndexChanged
        Select Case CbxClassification.SelectedIndex
            'this code changes what picure is being shown depending on the classification selected

            'Classification G
            Case 0
                PbxG.Visible = True
                PbxPG.Visible = False
                PbxM.Visible = False
                PbxMA.Visible = False
                PbxR.Visible = False
                PbxCTC.Visible = False

                'Classification PG
            Case 1
                PbxG.Visible = False
                PbxPG.Visible = True
                PbxM.Visible = False
                PbxMA.Visible = False
                PbxR.Visible = False
                PbxCTC.Visible = False

                'Classification M
            Case 2
                PbxG.Visible = False
                PbxPG.Visible = False
                PbxM.Visible = True
                PbxMA.Visible = False
                PbxR.Visible = False
                PbxCTC.Visible = False

                'Classification MA
            Case 3
                PbxG.Visible = False
                PbxPG.Visible = False
                PbxM.Visible = False
                PbxMA.Visible = True
                PbxR.Visible = False
                PbxCTC.Visible = False

                'Classification R
            Case 4
                PbxG.Visible = False
                PbxPG.Visible = False
                PbxM.Visible = False
                PbxMA.Visible = False
                PbxR.Visible = True
                PbxCTC.Visible = False
        End Select
    End Sub
#End Region

#End Region

#Region "Validation"
    Sub Validation()
        If TbxTitle.Text = "" Then
            verificationCheck = False
            MsgBox("Please Add The Title")
            Exit Sub
        ElseIf TbxGenre.Text = "" Or TbxGenre.Text = "XXX, YYY, ZZZ" Then
            verificationCheck = False
            MsgBox("Please Add The Genre")
            Exit Sub
        ElseIf IsNumeric(TbxGenre.Text) = True Then
            verificationCheck = False
            MsgBox("Please Ensure Genre's Do Not Include Numbers")
            Exit Sub
        ElseIf TbxReleaseDate.Text = "" Or TbxReleaseDate.Text = "YYYY" Then
            verificationCheck = False
            MsgBox("Please Add The Release Date")
            Exit Sub
        ElseIf TbxReleaseDate.Text.Length < 4 Then
            verificationCheck = False
            MsgBox("Please Add The Full Year")
            Exit Sub
        ElseIf IsNumeric(TbxReleaseDate.Text) = False Then
            verificationCheck = False
            MsgBox("Please only enter the year")
            Exit Sub
        ElseIf TbxReleaseDate.Text > Year(Today) Then
            verificationCheck = False
            MsgBox("The Movie Cannot Be Release in The Future")
            Exit Sub
        ElseIf CbxClassification.SelectedIndex = -1 Then
            verificationCheck = False
            MsgBox("Please Select The Movie Classification")
            Exit Sub
        End If
    End Sub
#End Region

#Region "Misc"
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'clear all data from the form
        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Confirm Clear All", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
            Clear()
        End If
    End Sub
    Sub Clear()
        'clear all text boxes
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        CbxClassification.SelectedIndex = -1
        CbxGenre.SelectedIndex = -1
        TbxGenre.Text = "XXX, YYY, ZZZ"
        TbxReleaseDate.Text = "YYYY"
        counterGenre = 0
        counterReleaseDate = 0

        'reset the picture Boxes
        PbxG.Visible = False
        PbxPG.Visible = False
        PbxM.Visible = False
        PbxMA.Visible = False
        PbxR.Visible = False
        PbxCTC.Visible = True
    End Sub

    'this allows for suggested formatting for the text on the form
    Private Sub TbxReleaseDate_MouseClick(sender As Object, e As MouseEventArgs) Handles TbxReleaseDate.MouseClick
        If counterReleaseDate = 0 Then
            TbxReleaseDate.Text = ""
            counterReleaseDate += 1
        End If
    End Sub
    'this allows for suggested formatting for the text on the form
    Private Sub TbxGenre_MouseClick(sender As Object, e As MouseEventArgs) Handles TbxGenre.MouseClick
        If counterGenre = 0 Then
            TbxGenre.Text = ""
            counterGenre += 1
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
        Me.Show()
        Me.Refresh()
        Me.Clear()
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
        Me.Show()
        Me.Refresh()
        Me.Clear()
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