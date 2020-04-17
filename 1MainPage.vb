Imports System.IO
Public Class MainPage
    Public MyEmail As String ' new variable to store the email of a member who has succesfully loged in into the system
    Public Sub Check_LogIn_Details()
        Dim LogInDetails As MemberRecord ' use the member file to find the email and password

        Dim CustomerFile As String = Application.StartupPath & "/memberDetails.dat" ' find the file which has the members' records

        FileOpen(1, CustomerFile, OpenMode.Random,,, Len(LogInDetails)) ' open the file in random mode


        Dim NumRecs As Integer = LOF(1) / Len(LogInDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' create variable for the record position

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, LogInDetails, RecPos) ' retrieve the next record

            If Trim(LogInDetails.Email) = Email_txtb.Text And Trim(LogInDetails.Password) = Password_txtb.Text Then ' check if the email and password match

                MyEmail = Trim(LogInDetails.Email)

                Me.Hide() ' hide the current form

                MemberLogIn_Menu.Show() ' show the main member page
                MsgBox("Welcome" & " " & Trim(LogInDetails.Name)) ' greeting the user with his or her name



            ElseIf RecPos = NumRecs And Trim(LogInDetails.Email) <> Email_txtb.Text And Trim(LogInDetails.Password) <> Password_txtb.Text Then
                MsgBox("please try again!")

            End If

        Next

        FileClose(1) ' closing the file




    End Sub
    Private Sub LogIn_btn_Click(sender As Object, e As EventArgs) Handles LogIn_btn.Click
        Call Check_LogIn_Details()
        
    End Sub

    Private Sub SignUp_ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUp_ll.LinkClicked
        RegistrationForm.Show() ' Show the Registration Form
        Me.Hide() ' Hide the current window
    End Sub

    Private Sub StaffArea_ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles StaffArea_ll.LinkClicked
        StaffArea_Login.Show() ' Show the staff area 
        Me.Hide() 'Hide the current window

    End Sub


End Class
