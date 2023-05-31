'Author: Nathan
'Date modified: 1/08/2020
'Purpose: this section of code is used as a centural hub that provides information baout the program

Public Class Home

#Region "Menu Buttons"
    'Menu Buttons
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Me.Show()
        Me.Refresh()
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
        Me.Show()
        Me.Refresh()
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
        Me.Show()
        Me.Hide()
        Me.Refresh()
    End Sub
    Private Sub LblMenu_Click(sender As Object, e As EventArgs) Handles LblMenu.Click
        Me.Show()
        Me.Hide()
        Me.Refresh()
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
