'Author: Nathan
'Date modified: 7/09/2020
'Purpose: this section of code is used to modify or delete data from a specific video and then overwrite the file with the new information
'-------- this secton works with the edit form to assist in the modification or deletion process

Imports System.IO

Public Class UpdateDelete

#Region "Dims"
    Dim Title() As String
    Dim Genre() As String
    Dim ReleaseDate() As Integer
    Dim Classification() As String

    Dim verificationCheck As Boolean = True
    Dim counterReleaseDate = 0
    Dim counterGenre = 0
#End Region

#Region "Load Information"
    Public Sub LoadInformation()
        'update the textboxes to the current videos information
        TbxTitle.Text = Edit.Title(Edit.a)
        TbxGenre.Text = Edit.Genre(Edit.a)
        TbxReleaseDate.Text = Edit.ReleaseDate(Edit.a)

        'the correct classification visable
        If Edit.Classification(Edit.a) = "G" Then
            CbxClassification.SelectedIndex = 0
            PbxG.Visible = True
            PbxPG.Visible = False
            PbxM.Visible = False
            PbxMA.Visible = False
            PbxR.Visible = False
            PbxCTC.Visible = False
        ElseIf Edit.Classification(Edit.a) = "PG" Then
            CbxClassification.SelectedIndex = 1
            PbxG.Visible = False
            PbxPG.Visible = True
            PbxM.Visible = False
            PbxMA.Visible = False
            PbxR.Visible = False
            PbxCTC.Visible = False
        ElseIf Edit.Classification(Edit.a) = "M" Then
            CbxClassification.SelectedIndex = 2
            PbxG.Visible = False
            PbxPG.Visible = False
            PbxM.Visible = True
            PbxMA.Visible = False
            PbxR.Visible = False
            PbxCTC.Visible = False
        ElseIf Edit.Classification(Edit.a) = "MA 15+" Then
            CbxClassification.SelectedIndex = 3
            PbxG.Visible = False
            PbxPG.Visible = False
            PbxM.Visible = False
            PbxMA.Visible = True
            PbxR.Visible = False
            PbxCTC.Visible = False
        ElseIf Edit.Classification(Edit.a) = "R 18+" Then
            CbxClassification.SelectedIndex = 4
            PbxG.Visible = False
            PbxPG.Visible = False
            PbxM.Visible = False
            PbxMA.Visible = False
            PbxR.Visible = True
            PbxCTC.Visible = False
        End If
    End Sub
#End Region

#Region "Main Code"
#Region "Funtionality"
#Region "Genre"
    Private Sub BtnGenre_Click(sender As Object, e As EventArgs) Handles BtnGenre.Click
        Select Case CbxGenre.SelectedIndex
            'all genres
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23
                If TbxGenre.Text = "" Or TbxGenre.Text = "XXX, YYY, ZZZ" Then
                    TbxGenre.Text = CbxGenre.Text
                    counterGenre = counterGenre + 1
                Else
                    TbxGenre.Text = (TbxGenre.Text & ", " & CbxGenre.Text)
                End If
        End Select
    End Sub
#End Region

#Region "Classifications"
    Private Sub CbxRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClassification.SelectedIndexChanged
        Select Case CbxClassification.SelectedIndex
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

#Region "Update Video List"
#Region "Add Video"
    Public Sub BtnUpdateVideo_Click(sender As Object, e As EventArgs) Handles BtnUpdateVideo.Click
        'connect to the file
        'and save the information into the corrosponding arrays
        Dim VideoListFile As Object = (Login.UsersFile)
        Dim srdVideoList As IO.StreamWriter
        If Not File.Exists(VideoListFile) Then
            MsgBox("Connection Failed")
            Exit Sub
        End If
        srdVideoList = New IO.StreamWriter(Login.UsersFile)

        'writes all the infomation in the arrays back into the text file
        'including the updated information in the array
        'validates that the users input is still valid
        Validation()
        If verificationCheck = True Then
            Dim ConfirmMsg As Integer
            ConfirmMsg = MessageBox.Show("Confirm Video Information", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ConfirmMsg = vbYes Then

                'updates the video information inside of edit froms' arrays
                Edit.Title(Edit.a) = TbxTitle.Text
                Edit.Genre(Edit.a) = TbxGenre.Text
                Edit.ReleaseDate(Edit.a) = TbxReleaseDate.Text
                Edit.Classification(Edit.a) = CbxClassification.Text

                For a = 0 To Login.MaxUVCFileNum - 1
                    'write in the variable into the file
                    srdVideoList.WriteLine(Edit.Title(a))
                    srdVideoList.WriteLine(Edit.Genre(a))
                    srdVideoList.WriteLine(Edit.ReleaseDate(a))
                    srdVideoList.WriteLine(Edit.Classification(a))
                Next
                srdVideoList.Close()
                Clear()

                'confimation message serves to confirm with the user that the modifcation was made
                MsgBox("Your Video Was Added")

                'send the user back to the edit form where they can edit other files or use the program
                Edit.Show()
                Me.Hide()
                Edit.LoadInformation()
            Else : Exit Sub
            End If
        Else : srdVideoList.Close()
        End If
    End Sub
#End Region
#End Region

#Region "Delete From Video List"
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'connect to the file
        'and save the information into the corrosponding arrays
        Dim VideoListFile As Object = (Login.UsersFile)
        Dim srdVideoList As IO.StreamWriter
        If Not File.Exists(VideoListFile) Then
            MsgBox("Connection Failed")
            Exit Sub
        End If
        srdVideoList = New IO.StreamWriter(Login.UsersFile)


        'validates that the users input is still valid
        'writes all the infomation in the arrays back into the text file
        'including the updated information in the array
        Validation()
        If verificationCheck = True Then
            Dim ConfirmMsg As Integer
            ConfirmMsg = MessageBox.Show("Confirm Video Information", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ConfirmMsg = vbYes Then
                For a = 0 To Login.MaxUVCFileNum - 1
                    'write in the variable into the file
                    If a <> Edit.a Then         ' -- this will make it so when the deleted item will be skipped in the writing
                        srdVideoList.WriteLine(Edit.Title(a))
                        srdVideoList.WriteLine(Edit.Genre(a))
                        srdVideoList.WriteLine(Edit.ReleaseDate(a))
                        srdVideoList.WriteLine(Edit.Classification(a))
                    End If
                Next
                srdVideoList.Close()
                Clear()

                'confimation message serves to confirm with the user that the modifcation was made
                MsgBox("Your Video Was Added")

                'send the user back to the edit form where they can edit other files or use the program
                Edit.Show()
                Me.Hide()
                Edit.LoadInformation()
            Else : Exit Sub
            End If
        Else : srdVideoList.Close()
        End If
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
        ElseIf IsNumeric(TbxGenre.Text) Then
            verificationCheck = False
            MsgBox("Please Ensure Genre's Do Not Include Numbers")
            Exit Sub
        ElseIf TbxReleaseDate.Text = "" Then
            verificationCheck = False
            MsgBox("Please Add The Release Date")
            Exit Sub
        ElseIf TbxReleaseDate.Text.Length < 4 Then
            verificationCheck = False
            MsgBox("Please Add The Full Year")
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
        Clear() '-- reset all of the data entered
    End Sub
    Sub Clear()

        Dim ConfirmMsg As Integer
        ConfirmMsg = MessageBox.Show("Clear Video Information", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ConfirmMsg = vbYes Then
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
        End If
    End Sub

    'returns the the edit form without editing or deleting the video
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Edit.Show()
        Me.Hide()
        Edit.Refresh()
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

End Class