Public Class Member_MyDetails
    Private Sub MemberLogIn_Menu_MyDetailsBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
        Call Retriving_MemberDetails() ' Call the subroutine to retrive member's details


    End Sub
    Private Sub Retriving_MemberDetails()
        Dim MemberDetails As MemberType ' create a new record to store member details


        Dim CustomerFile As String = Application.StartupPath & "/Members.dat" ' find the file which has the members records

        FileOpen(1, CustomerFile, OpenMode.Random,,, Len(MemberDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(MemberDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record




        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, MemberDetails, RecPos) ' retrieve the file

            If Trim(MemberDetails.Email) = MainPage.MyEmail Then ' if the email matches then procede

                Name_txtb.Text = Trim(MemberDetails.Name)  ' display all the fields into the texboxes
                Surname_txtb.Text = Trim(MemberDetails.Surname)
                Gender_txtb.Text = Trim(MemberDetails.Gender)
                DOB_txtb.Text = Trim(MemberDetails.DOB)
                Mobile_txtb.Text = Trim(MemberDetails.Mobile)
                Email_txtb.Text = Trim(MemberDetails.Email)
            End If
        Next
        FileClose(1) ' close the file

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Name_txtb.ReadOnly = False
        Surname_txtb.ReadOnly = False
        Mobile_txtb.ReadOnly = False

    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click

        Dim Updated_MemberDetails As MemberType ' create a new record which to store the updated details


        Dim CustomerFile As String = Application.StartupPath & "/Members.dat" ' declare the file location


        FileOpen(1, CustomerFile, OpenMode.Random,,, Len(Updated_MemberDetails)) ' open the file in random mode


        Dim NumRecs As Integer = LOF(1) / Len(Updated_MemberDetails) ' calculate the number of records in the file

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, Updated_MemberDetails, RecPos) ' retrieve the file

            If Trim(Updated_MemberDetails.Email) = MainPage.MyEmail And IsMobileValid() = True Then ' if the email matches with the current member's email then procede

                With Updated_MemberDetails   ' copy the new details into the record
                    .Name = Name_txtb.Text
                    .Surname = Surname_txtb.Text
                    .Gender = Gender_txtb.Text
                    .DOB = DOB_txtb.Text
                    .Email = Email_txtb.Text


                    .Mobile = Mobile_txtb.Text


                End With

                FilePut(1, Updated_MemberDetails, RecPos) ' replace all the old details with the new details


                MsgBox("All your details have been updated!", MsgBoxStyle.OkOnly) ' a message box displaying that the procedure has succesfully ended

            End If
        Next

        FileClose(1) ' closing the file

    End Sub

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        Me.Close()
        MemberLogIn_Menu.Show()
    End Sub
    Function IsMobileValid()

        Dim Result As Boolean = False
        ' Lenght check for mobile number
        If Len(Mobile_txtb.Text) <> 11 Then
            MsgBox("Invalid mobile number") ' making sure that the mobile number length is only 11 digits long
            Return False
        Else
            Return True
        End If


    End Function
End Class