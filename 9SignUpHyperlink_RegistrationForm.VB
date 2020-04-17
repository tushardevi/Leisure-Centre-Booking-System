Imports System.IO
Public Class _9SignUpHyperlink_RegistrationForm

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        MainPage.Show() 'show Main Menu
        Me.Hide() ' Hide the current window
    End Sub
    Private Function Validation_and_Verification()
        '------------------------------------------------------------------------------------------------------------
        '                                'VALIDATION AND VERIFICATION 

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

        ' Lenght check for password
        If Len(Password_txtb.Text) < 8 Then
            MsgBox("Please type a password containing at least 8 characters") ' making sure that the password has atleast 8 characters
        Else
            totalchecks = totalchecks + 1
        End If

        ' Format check for email
        Dim pattern As String
        pattern = "^[_a-z0-9-]+(.[_a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)(.[a-z]{2,4})$" ' an email pattern that will be used to compare the email from the EmailTexbox

        If Not System.Text.RegularExpressions.Regex.IsMatch(LCase(Email_txtb.Text), pattern) Then ' if the pattern does not match then a message is sent to the user
            MsgBox("Invalid Email")
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
        '------------------------------------------------------------------------------------------------------------
        If totalchecks = 5 Then ' if all the fields are succesfully validated then the function returns a true value 
            Return True
        Else
            Return False ' else it returns a false value
        End If


    End Function
    Private Sub AddingCustDet_ToFile()
        ' Assigning all member details to a new record
        Dim MemberRecord As MemberType

        With MemberRecord
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
            .Email = Email_txtb.Text
            .Password = Password_txtb.Text
        End With


        Dim NewMemberFile As String ' Setting up the location of the file 
        NewMemberFile = Application.StartupPath & "/memberDetails.dat"


        FileOpen(1, NewMemberFile, OpenMode.Random, , , Len(Expression:=MemberRecord)) 'Opening the file in random mode

        Dim NumOfRecs As Integer
        NumOfRecs = LOF(1) / Len(NewMemberFile)    'Calculating the number of record in the file

        Dim RecPos As Integer
        RecPos = NumOfRecs + 1 ' finding the position where the file must be saved

        FilePut(1, MemberRecord, RecPos) 'Storing the new record into the file 
        FileClose(1) ' Closing the file


        ' creating a message box for the user to confirm all their details.
        If (MessageBox.Show("Are you happy with all your details?", "Confirm", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
            MsgBox("Congratulations! You are now a member of TotalFitness") ' a new message box when the user confirmed all his details
            ' empty all the fields in the form
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
    End Sub
    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click


        If Validation_and_Verification() = True Then ' if the function equals to true (meaning all fields have been succesfully validated) then proceed to the next instruction

            Call AddingCustDet_ToFile() ' calling the subroutine to add all the validated and verified customer details into the file

        End If
    End Sub

    Private Sub Calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateChanged

            DOB_txtb.Text = Calendar.SelectionStart ' Sends the selected date to the "Date of Birth" textbox
        End Sub
    End Class