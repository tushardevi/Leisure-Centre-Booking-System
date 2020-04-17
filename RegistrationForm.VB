Imports System.IO
Public Class RegistrationForm

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        MainPage.Show() 'show Main Menu
        Me.Close() ' Hide the current window
    End Sub
    Private Function Validation_and_Verification()

        Dim totalchecks As Integer ' a new variable to check if all the fields have been validated or not. 

        ' Presence check for all fields
        If Name_txtb.Text = "" Or Surname_txtb.Text = "" Or DOB_txtb.Text = "" Or Mobile_txtb.Text = "" Or Email_txtb.Text = "" Or Password_txtb.Text = "" Or ReEnterPassword_txtb.Text = "" Then
            MsgBox("Please fill all fields", MsgBoxStyle.Critical) ' checking if fields are empty or not
        Else
            totalchecks = totalchecks + 1 ' as the field is validated the "totalcheck" variable is incremented by 1
        End If

        ' Lenght check for mobile number
        If Len(Mobile_txtb.Text) <> 11 Then
            MsgBox("Invalid mobile number") ' making sure that the mobile number length is only 11 digits long
        Else
            totalchecks = totalchecks + 1
        End If

        ' Range check for password
        If Len(Password_txtb.Text) < 8 Then
            MsgBox("Please type a password containing at least 8 characters") ' making sure that the password has atleast 8 characters
        Else
            totalchecks = totalchecks + 1
        End If


        If Not Password_txtb.Text = ReEnterPassword_txtb.Text Then ' comparing the two passwords.
            MsgBox("Password Do Not match")
            Password_txtb.Text = ""
            ReEnterPassword_txtb.Text = ""
        Else
            totalchecks = totalchecks + 1

        End If



        ' checks if all fields have been succesfully validated
        If totalchecks = 4 Then
            Return True
        Else
            Return False
        End If


    End Function
    Private Sub AddingCustDet_ToFile()
        'If the email address does not exist then procede to the next step
        If CheckEmail() = False Then
            FileClose(1)  ' as there is no match found, close the file and procede to the next step (appending file)

            ' creating a message box for the user to confirm all their details.
            If (MessageBox.Show("Are you happy with all your details?", "Confirm", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                MsgBox("Congratulations! You are now a member of TotalFitness") ' a new message box when the user confirmed all his details
                ' empty all the fields in the form


                ' Assigning all member details to a new record
                Dim NewMemberRecord As MemberType

            'storing each textbox value that is on the form to its corresponding record field
            With NewMemberRecord
                .Name = Name_txtb.Text
                .Surname = Surname_txtb.Text

                If Male_rb.Checked Then
                    .Gender = Male_rb.Text
                End If
                ' Storing the correct gender for that particular member
                If Female_rb.Checked Then
                    .Gender = Female_rb.Text
                End If

                .DOB = DOB_txtb.Text
                .Mobile = Mobile_txtb.Text
                .Email = (Email_txtb.Text).ToLower
                .Password = Password_txtb.Text
            End With


            Dim NewMemberFile As String ' Setting up the location of the file 
                NewMemberFile = Application.StartupPath & "/Members.dat"


                FileOpen(1, NewMemberFile, OpenMode.Random, , , Len(NewMemberRecord)) 'Opening the file in random mode

            Dim NumOfRecs As Integer
            NumOfRecs = LOF(1) / Len(NewMemberRecord)    'Calculating the number of record in the file

            Dim RecPos As Integer
            RecPos = NumOfRecs + 1 ' finding the position where the file must be saved

            FilePut(1, NewMemberRecord, RecPos) 'Storing the new record into the file 
            FileClose(1) ' Closing the file

                Name_txtb.Text = ""
                Surname_txtb.Text = ""
                Male_rb.Checked = False
                Female_rb.Checked = False
                DOB_txtb.Text = ""
                Mobile_txtb.Text = ""
                Email_txtb.Text = ""
                Password_txtb.Text = ""
                ReEnterPassword_txtb.Text = ""

            End If
        End If
    End Sub
    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click


        If Validation_and_Verification() = True Then ' if the function equals to true (meaning all fields have been succesfully validated) then proceed to the next instruction

            Call AddingCustDet_ToFile() ' calling the subroutine to add all the validated and verified customer details into the file

        End If
    End Sub

    Private Sub Calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateChanged

        DOB_txtb.Text = Calendar.SelectionStart ' Sends the selected date to the "Date of Birth" textbox
    End Sub
    Private Function CheckEmail()

        Dim MemberDetails As MemberType ' create a new record to store facility details


        Dim MemberFile As String = Application.StartupPath & "/Members.dat" ' find the file which has the member records

        FileOpen(1, MemberFile, OpenMode.Random,,, Len(MemberDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(MemberDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim Exists As Boolean = False ' boolean expression checks whether the item exists in the file or not

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, MemberDetails, RecPos) ' retrieve the file


            If Trim(MemberDetails.Email) = (Email_txtb.Text).ToLower Then  'if the E-mail matches then procede

                Exists = True ' set the exists to true. Meaning file an ID already exists in the file

            End If
        Next

        If Exists = True Then
            MsgBox("Email Address already exists", MsgBoxStyle.Critical) ' display error message

            Return True ' set the function to true
        Else
            Return False ' set the function to false

        End If

    End Function

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
    End Sub
End Class