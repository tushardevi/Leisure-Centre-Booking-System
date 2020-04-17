Public Class StaffArea_AddNewStaff
    Private Function Validation_and_Verification()


        Dim totalchecks As Integer ' a new variable to check if all the fields have been validated or not. 

        ' Presence check for all fields
        If StaffID_txtb.Text = "" Or Name_txtb.Text = "" Or Surname_txtb.Text = "" Or Mobile_txtb.Text = "" Or Role_txtb.Text = "" Or Password_txtb.Text = "" Or ReEnterPassword_txtb.Text = "" Then
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

        'comparing the two passwords.
        If Not Password_txtb.Text = ReEnterPassword_txtb.Text Then
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
    Private Sub AddingStaffDet_ToFile()
        'If the StaffID does Not exist Then procede To the Next Step
        If CheckStaffID() = False Then
            FileClose(1)  ' as there is no match found, close the file and procede to the next step (appending file)

            ' creating a message box for the user to confirm all their details.
            If (MessageBox.Show("Are you happy with all your details?", "Confirm", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                MsgBox("Congratulations! You are now a staff of TotalFitness") ' a new message box when the user confirmed all his details

                Dim NewStaffRecord As StaffType

            'storing each textbox value that is on the form to its corresponding record field
            With NewStaffRecord
                .StaffID = (StaffID_txtb.Text).ToLower ' staffID in lower caps
                .Name = Name_txtb.Text
                .Surname = Surname_txtb.Text
                .Mobile = Mobile_txtb.Text
                .Role = Role_txtb.Text
                .Password = Password_txtb.Text
            End With


            Dim StaffFile As String ' Setting up the location of the file 
                StaffFile = Application.StartupPath & "/Staff.dat"


                FileOpen(1, StaffFile, OpenMode.Random, , , Len(NewStaffRecord)) 'Opening the file in random mode

            Dim NumOfRecs As Integer
            NumOfRecs = LOF(1) / Len(StaffFile)    'Calculating the number of record in the file

            Dim RecPos As Integer
            RecPos = NumOfRecs + 1 ' finding the position where the file must be saved

            FilePut(1, NewStaffRecord, RecPos) 'Storing the new record into the file 
            FileClose(1) ' Closing the file



            ' empty all the fields in the form
            StaffID_txtb.Text = ""
                Name_txtb.Text = ""
                Surname_txtb.Text = ""
                Mobile_txtb.Text = ""
                Role_txtb.Text = ""
                Password_txtb.Text = ""
                ReEnterPassword_txtb.Text = ""

            End If
        End If
    End Sub
    Private Function CheckStaffID()

        Dim StaffDetails As StaffType ' create a new record to store staff details


        Dim StaffFile As String = Application.StartupPath & "/Staff.dat" ' find the file which has the member records

        FileOpen(1, StaffFile, OpenMode.Random,,, Len(StaffDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(StaffDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim Exists As Boolean = False ' boolean expression checks whether the item exists in the file or not

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, StaffDetails, RecPos) ' retrieve the file


            If Trim(StaffDetails.StaffID) = (StaffID_txtb.Text).ToLower Then  'if the StaffID matches then procede

                Exists = True ' set the exists to true. Meaning file an ID already exists in the file

            End If
        Next

        If Exists = True Then
            MsgBox("Username already exists", MsgBoxStyle.Critical) ' display error message

            Return True ' set the function to true
        Else
            Return False ' set the function to false

        End If

    End Function

    Private Sub SignUp_btn_Click(sender As Object, e As EventArgs) Handles SignUp_btn.Click
        If Validation_and_Verification() = True Then ' if the function equals to true (meaning all fields have been succesfully validated) then proceed to the next instruction

            Call AddingStaffDet_ToFile() ' calling the subroutine to add all the validated and verified staff details into the file

        End If
    End Sub

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Close()
        StaffArea_Login.Show()

    End Sub

    Private Sub StaffArea_AddNewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
    End Sub
End Class