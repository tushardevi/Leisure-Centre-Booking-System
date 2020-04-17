Public Class StaffArea_Login
    Public staffID As String
    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        MainPage.Show() 'Show main menu
        Me.Close() ' Hide current window
    End Sub

    Private Sub AddNewStaff_ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddNewStaff_ll.LinkClicked
        Me.Hide() ' hide current window
        StaffArea_AddNewStaff.Show() ' show Add New Staff form
    End Sub

    Private Sub LogIn_btn_Click(sender As Object, e As EventArgs) Handles LogIn_btn.Click
        Call Check_LogIn_Details() 'call the subroutine
        StaffID_txtb.Text = ""
        Password_txtb.Text = ""
    End Sub
    Public Sub Check_LogIn_Details()
        Dim LogInDetails As StaffType ' use the staff file to find the staffID and password

        Dim StaffFile As String = Application.StartupPath & "/Staff.dat" ' find the file which has the staff's records

        FileOpen(5, StaffFile, OpenMode.Random,,, Len(LogInDetails)) ' open the file in random mode


        Dim NumRecs As Integer = LOF(5) / Len(LogInDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' create variable for the record position

        Dim found As Boolean = False ' variable which stores a boolean expression

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(5, LogInDetails, RecPos) ' retrieve the next record

            If Trim(LogInDetails.StaffID) = (StaffID_txtb.Text).ToLower And Trim(LogInDetails.Password) = Password_txtb.Text Then ' check if the email and password match

                staffID = Trim(LogInDetails.StaffID)

                Me.Hide() ' hide the current form

                StaffArea_AvailableFacilities.Show() ' show the main member page
                MsgBox("Welcome" & " " & Trim(LogInDetails.Name)) ' greet the user with his or her name
                found = True ' set the variable to true
            End If
        Next

        ' send error message when staff not found
        If found = False Then
            MsgBox("please try again!")
        End If

        FileClose(5) ' closing the file
    End Sub

    Private Sub StaffArea_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
    End Sub
End Class