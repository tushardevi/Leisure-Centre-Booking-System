Public Class StaffArea_AddNewFacility
    Dim FacilityID As String
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click

        If Validation() = True Then 'If the Function equals To True (meaning all fields have been succesfully validated) Then proceed To the Next instruction

            Call AddingFacility_ToFile() 'Calling the subroutine to add all the validated And verified facility details into the file
            Call Adding_ParticipationDates_ToFile()




        End If
        ' clear all fields
        FacilityID_txtb.Text = ""
        Name_txtb.Text = ""
        ClassNo_txtb.Text = ""
        AvaiSpaces_txtb.Text = ""
        Times_cb.Text = ""



    End Sub
    Private Function Validation()

        Dim totalchecks As Integer = 0 ' a new variable to check if all the fields have been validated or not. 

        ' Presence check for all fields
        If FacilityID_txtb.Text = "" Or Name_txtb.Text = "" Or ClassNo_txtb.Text = "" Or AvaiSpaces_txtb.Text = "" Or StaffID_txtb.Text = "" Then
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

        'Range check for FacilityID
        Dim FacilityID As String = FacilityID_txtb.Text

        If Val(FacilityID) < 0 Then
            MsgBox("FacilityID must be a postive number")
        Else
            totalchecks = totalchecks + 1
        End If

        ' Type check for Available Spaces 
        If Not IsNumeric(AvaiSpaces_txtb.Text) Then
            MsgBox("Invalid value for 'Available Spaces textbox ")
        Else
            totalchecks = totalchecks + 1
        End If
        'Range check for Available Space
        If Val(AvaiSpaces_txtb.Text) < 1 Then
            MsgBox("Available Spaces must be 1 or more")
        Else
            totalchecks = totalchecks + 1
        End If

        'Range check for date
        If Microsoft.VisualBasic.Left(Date_txtb.Value, 10) < Today.Date Then
            MsgBox("Invalid date")
        Else
            totalchecks = totalchecks + 1
        End If

        'If facility is booked for the present day but the time happens to be lower than the present time then produce an error
        If Microsoft.VisualBasic.Left(Date_txtb.Value, 10) = Today.Date And Val(Times_cb.Text) <= Val(TimeOfDay) Then
            MsgBox("Invalid time")
        Else
            totalchecks = totalchecks + 1
        End If

        ' checks if all fields have been succesfully validated
        If totalchecks = 8 Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub AddingFacility_ToFile()

        ' If a facility ID does not exist then procede to the next step
        If CheckFacilityID() = False Then

            ' creating a message box for the admin to confirm all the details entered
            If (MessageBox.Show("Are you happy with all the details?", "Confirm", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel) Then
                FileClose(1) ' as there is no match found, close the file and procede to the next step (appending file)
            Else

                FileClose(1) ' as there is no match found, close the file and procede to the next step (appending file)

                ' Assigning all member details to a new record
                Dim FacilityDetails As FacilityType


                With FacilityDetails  ' storing each textbox value to its corresponding field

                    .FacilityID = FacilityID_txtb.Text
                    .Name = Name_txtb.Text
                    .ClassNo = ClassNo_txtb.Text
                    .StaffID = StaffID_txtb.Text

                End With


                Dim FacilityFile As String ' Setting up the location of the file 

                FacilityFile = Application.StartupPath & "/Facilities.dat" ' path of file


                FileOpen(1, FacilityFile, OpenMode.Random, , , Len(FacilityDetails)) 'Opening the file in random mode



                Dim NumOfRecs1 As Integer
                NumOfRecs1 = LOF(1) / Len(FacilityDetails)    'Calculating the number of records in the file

                Dim RecPos1 As Integer
                RecPos1 = NumOfRecs1 + 1 ' finding the position where the file must be saved

                FilePut(1, FacilityDetails, RecPos1) 'Storing the new record into the file 




                FileClose(1) ' close the file when done with adding new facilities

                MsgBox("Facility has been successfully saved!") ' a new message box to show the admin that all the details has been saved

                FacilityID = FacilityID_txtb.Text



            End If


        End If
        ' empty all the fields in the form

        FileClose(1)


    End Sub
    Private Sub Adding_ParticipationDates_ToFile()

        Dim NewParticipationDate As ParticipationDatesType ' declare new ParticipationDateType which stores date and times of a particular facility

        ' Assigning new details into ParticipationDateType
        With NewParticipationDate
            Dim rn As New Random
            Dim RandomInt As String
            RandomInt = rn.Next(1, 9999) ' let the Random Integer be any random number between 1-9999

            ' upload all the details to the NewParticipation record
            .Day = Microsoft.VisualBasic.Left(Date_txtb.Value, 10)
            .ParticipationID = RandomInt
            .FacilityID = FacilityID
            .Time = Replace(Times_cb.Text, ":", "")
            .AvailSpaces = AvaiSpaces_txtb.Text

        End With

        Dim ParticipationDatesFile As String ' Setting up the location of the file 
        ParticipationDatesFile = Application.StartupPath & "/ParticipationDates.dat"


        FileOpen(2, ParticipationDatesFile, OpenMode.Random, , , Len(NewParticipationDate)) 'Opening the file in random mode

        Dim NumOfRecs2 As Integer
        NumOfRecs2 = LOF(2) / Len(NewParticipationDate)    'Calculating the number of record in the file

        Dim RecPos2 As Integer
        RecPos2 = NumOfRecs2 + 1 ' finding the position where the file must be saved

        FilePut(2, NewParticipationDate, RecPos2) 'Storing the new record into the file 
        FileClose(2) ' Closing the file
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
            MsgBox("FacilityID already exists", MsgBoxStyle.Critical) ' display error message

            Return True ' set the function to true

        Else
            Return False ' set the function to false

        End If
        FileClose(1)
    End Function

    Private Sub _16StaffArea_FacilitiesBtn_AddNewFacilityBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
        Times_cb.Items.Add("8.00")
        Times_cb.Items.Add("9.00")
        Times_cb.Items.Add("10.00")
        Times_cb.Items.Add("11.00")
        Times_cb.Items.Add("12.00")
        Times_cb.Items.Add("13.00")
        Times_cb.Items.Add("14.00")
        Times_cb.Items.Add("15.00")
        Times_cb.Items.Add("16.00")
        Times_cb.Items.Add("17.00")
        Times_cb.Items.Add("18.00")
        Times_cb.Items.Add("19.00")
        StaffID_txtb.ReadOnly = True ' disable the staffID textbox 
        StaffID_txtb.Text = StaffArea_Login.staffID ' Automatically write the StaffID of the staff who has just logged in

    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Close()

        StaffArea_AvailableFacilities.Show()

    End Sub

End Class