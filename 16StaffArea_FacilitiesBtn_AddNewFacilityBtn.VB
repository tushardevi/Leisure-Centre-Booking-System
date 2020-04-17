Public Class _16StaffArea_FacilitiesBtn_AddNewFacilityBtn
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click

        If Validation() = True Then 'If the Function equals To True (meaning all fields have been succesfully validated) Then proceed To the Next instruction

            Call AddingFacility_ToFile() 'Calling the subroutine to add all the validated And verified facility details into the file

        End If
    End Sub
    Private Function Validation()

        Dim totalchecks As Integer = 0 ' a new variable to check if all the fields have been validated or not. 

        ' Presence check for all fields
        If FacilityID_txtb.Text = "" Or Name_txtb.Text = "" Or ClassNo_txtb.Text = "" Or MaxCapacity_txtb.Text = "" Or StaffID_txtb.Text = "" Then
            MsgBox("Please fill all fields", MsgBoxStyle.Critical) ' checking if fields are empty or not
        Else
            totalchecks = totalchecks + 1 ' as the field is validated the "totalcheck" variable is incremented by 1
        End If

        ' Lenght check for Facility ID
        If Len(FacilityID_txtb.Text) <> 3 Then
            MsgBox("Facility ID must consist of just 3 integers") ' making sure that the mobile number length is only 11 digits long
        Else
            totalchecks = totalchecks + 1
        End If

        ' Type check for FacilityID 
        If Not IsNumeric(FacilityID_txtb.Text) Then
            MsgBox("FacilityID must only consist of numbers")
        Else
            totalchecks = totalchecks + 1
        End If

        ' Type check for Maximum capacity 
        If Not IsNumeric(MaxCapacity_txtb.Text) Then
            MsgBox("Invalid value for 'Maximum Capacity' textbox ")
        Else
            totalchecks = totalchecks + 1
        End If


        ' checks if all fields have been succesfully validated
        If totalchecks = 4 Then
            Return True
        Else
            Return False
        End If

        '' Format check for Classroom Name
        'Dim pattern As String
        'pattern = "^[_a-z0-9-]+(.[_a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)(.[a-z]{2,4})$" ' an email pattern that will be used to compare the email from the EmailTexbox

        'If Not System.Text.RegularExpressions.Regex.IsMatch(LCase(ClassNo_txtb.Text), pattern) Then ' if the pattern does not match then a message is sent to the user
        '    MsgBox("Invalid Classroom Name")
        'Else
        '    totalchecks = totalchecks + 1
        'End If




    End Function
    Private Sub AddingFacility_ToFile()

        ' If a facility ID does not exist then procede to the next step
        If CheckFacilityID() = False Then

            FileClose(1) ' as there is no match found, close the file and procede to the next step (appending file)

            ' Assigning all member details to a new record
            Dim FacilityDetails As FacilityType


            With FacilityDetails  ' storing each textbox value to its corresponding field

                .FacilityID = FacilityID_txtb.Text
                .Name = Name_txtb.Text
                .ClassNo = ClassNo_txtb.Text
                .MaxCapacity = MaxCapacity_txtb.Text
                .StaffID = StaffID_txtb.Text
            End With


            Dim FacilityFile As String ' Setting up the location of the file 

            FacilityFile = Application.StartupPath & "/Facilities.dat" ' path of file


            FileOpen(1, FacilityFile, OpenMode.Random, , , Len(FacilityDetails)) 'Opening the file in random mode



            Dim NumOfRecs As Integer
            NumOfRecs = LOF(1) / Len(FacilityDetails)    'Calculating the number of records in the file

            Dim RecPos As Integer
            RecPos = NumOfRecs + 1 ' finding the position where the file must be saved

            FilePut(1, FacilityDetails, RecPos) 'Storing the new record into the file 
            FileClose(1) ' Closing the file


            ' creating a message box for the admin to confirm all the details entered

            If (MessageBox.Show("Are you happy with all the details?", "Confirm", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                MsgBox("Facility has been successfully saved!") ' a new message box to show the admin that all the details has been saved

                ' empty all the fields in the form
                FacilityID_txtb.Text = ""
                Name_txtb.Text = ""
                ClassNo_txtb.Text = ""
                MaxCapacity_txtb.Text = ""
                StaffID_txtb.Text = ""

            End If
        Else
            FileClose(1) ' close the file when done with adding new facilities
        End If
    End Sub
    Private Function CheckFacilityID()

        Dim FacilityDetails As FacilityType ' create a new record to store facility details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim Exists As Boolean = False ' boolean expression checks whether the item exists in the file or not

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, FacilityDetails, RecPos) ' retrieve the file


            If Trim(FacilityDetails.FacilityID) = FacilityID_txtb.Text Then ' if the Facility ID matches then procede

                Exists = True ' set the exists to true. Meaning file an ID already exists in the file

            End If
        Next

        If Exists = True Then
            MsgBox("ID already exists", MsgBoxStyle.Critical) ' display error message

            Return True ' set the function to true
        Else
            Return False ' set the function to false

        End If
    End Function

End Class