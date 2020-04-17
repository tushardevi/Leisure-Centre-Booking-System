Public Class Member_BookDateTime
    Private Sub Member_BookDateTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID_lb.Text = Member_BookFacility.FacilityID
        Me.BackColor = Color.SkyBlue
        Call Retrieving_ParticipationDatesAndTimes() ' call different subroutine of the same class

        With DateAndTimes_lv
            .View = View.Details   ' view all columns and other details inside the listview

            'add details to the listview
            .LabelEdit = False
            .HideSelection = False
            .GridLines = True
            .CheckBoxes = False
            .FullRowSelect = True


            ' add columns to the listview
            .Columns.Add("Date", 120)
            .Columns.Add("Time", 70)
            .Columns.Add("ParticipationID", 120)
            .Columns.Add("Available Spaces", 120)
        End With

    End Sub
    Private Sub LvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub

    Private Function CheckForParticipationID()

        Dim ParticipationID As String = ParticipationID_txtb.Text ' store the value which is in the ParticpationID textbox

        Dim itm As ListViewItem ' store each item in facility view list


        ' check if FacilityID exists inside the viewlist
        With DateAndTimes_lv

            itm = .FindItemWithText(ParticipationID, True, 0, True)

            If Not itm Is Nothing Then ' if it exists then return true

                Return True

            Else
                MsgBox("Particpation ID is not recognised, please try again") ' output an error message 
                Return False
            End If

        End With

        itm = Nothing ' make itm equal to NULL



    End Function


    Private Sub Retrieving_ParticipationDatesAndTimes()

        'OPEN PARTICIPATION_DATES FILE

        Dim ParticipationDate As ParticipationDatesType = Nothing ' create a new record to store Booking details

        Dim ParticipationDatesFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the booking records

        FileOpen(1, ParticipationDatesFile, OpenMode.Random,,, Len(ParticipationDate)) ' open the file in random mode

        Dim PartiNumRecs As Integer = LOF(1) / Len(ParticipationDate) ' calculate the total number of records in the bookings file
        Dim ParitRecPos As Integer = 0 'stores the position of the record

        'OPEN FACILITY DETAILS FILE

        Dim FacilityDetails As FacilityType = Nothing ' create a new record to store facility details

        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(2, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim FacilityNumRecs As Integer = LOF(2) / Len(FacilityDetails) ' calculate the total number of records in the facilities file
        Dim FacilityRecPos As Integer ' stores the position of the record


        ' LOOP THROUGH BOTH FILES

        For PartiRecPos = 1 To PartiNumRecs ' first loop through ParticipationDate file to find all possible records until the end of file.
            FileGet(1, ParticipationDate, PartiRecPos) ' retrieve the ParticipationDate file

            If Not Trim(Val(ParticipationDate.ParticipationID)) = -1 Then ' check if the  ParticipationID field is equal to -1

                If Trim(ParticipationDate.FacilityID) = Member_BookFacility.FacilityID Then  'if facilityID matches then procede 

                    For FacilityRecPos = 1 To FacilityNumRecs ' loop through facilities file until the end of file 
                        FileGet(2, FacilityDetails, FacilityRecPos) ' retrive the facilities file

                        If Not Trim(Val(FacilityDetails.FacilityID)) = -1 Then ' check if the  FacilityID field is equal -1

                            If Trim(FacilityDetails.FacilityID) = Trim(ParticipationDate.FacilityID) Then ' use the facilityID to look for a match in both files


                                Dim Time As String

                                Time = Microsoft.VisualBasic.Left(ParticipationDate.Time, 2) + ":" + Microsoft.VisualBasic.Right(Trim(ParticipationDate.Time), 2)



                                ' add all essential details on the listview
                                LvwAddItem(DateAndTimes_lv, ParticipationDate.Day, Time, ParticipationDate.ParticipationID, ParticipationDate.AvailSpaces)


                            End If

                        End If

                    Next

                    DateAndTimes_lv.Sorting = SortOrder.Ascending ' sort the participationDates by date

                End If
            End If
        Next

        FileClose(1) ' close  ParticipationDate File
        FileClose(2) ' close Facility File

    End Sub


    Private Sub BookNow_btn_Click(sender As Object, e As EventArgs) Handles BookNow_btn.Click
        If CheckForParticipationID() = True Then

            If IsDateAndTimeAlreadyBooked() = False Then ' call this function to check if the member has already booked the facility
                FileClose(1)
                Dim NewBooking As BookingType ' declare new bookingtype which stores booking details

                ' Assigning new details into bookingType
                With NewBooking
                    Dim rn As New Random
                    Dim RandomInt As String
                    RandomInt = rn.Next(1, 9999) ' let the Random Integer be any random number between 1-9999

                    ' upload all the details to the Newbooking record
                    .BookingID = RandomInt
                    .FacilityID = Member_BookFacility.FacilityID
                    .MemberEmail = (MainPage.MyEmail).ToLower
                    .ParticipationID = ParticipationID_txtb.Text

                End With

                Dim BookingFile As String ' Setting up the location of the file 
                BookingFile = Application.StartupPath & "/Bookings.dat"


                FileOpen(2, BookingFile, OpenMode.Random, , , Len(NewBooking)) 'Opening the file in random mode

                Dim NumOfRecs As Integer
                NumOfRecs = LOF(2) / Len(NewBooking)    'Calculating the number of record in the file

                Dim RecPos As Integer
                RecPos = NumOfRecs + 1 ' finding the position where the file must be saved

                FilePut(2, NewBooking, RecPos) 'Storing the new record into the file 
                FileClose(1) ' Closing the file

                MsgBox("Congratulations! Your booking has been made") ' output friendly friendly message to the user

                Call DecrementPlaces() ' decrease the number of spaces in the facility



            End If
        End If
        FileClose(2) ' close the file
        Call RefreshForm(e)
    End Sub

    Private Sub DecrementPlaces()
        Dim ParticipationDetails As ParticipationDatesType  ' create a new record to store Facility details


        Dim ParticipationFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the facility records

        FileOpen(1, ParticipationFile, OpenMode.Random,,, Len(ParticipationDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(ParticipationDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record
        Dim NewAvailPlaces As Integer ' stores available spaces left

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, ParticipationDetails, RecPos) ' retrieve the file

            ' If the member books on a particular date, deacrease the number of spaces left by one
            If Trim(ParticipationDetails.ParticipationID) = ParticipationID_txtb.Text Then ' if the facilityID match then procde

                NewAvailPlaces = Trim(ParticipationDetails.AvailSpaces) ' assign the new variable to the avaiableSpces

                NewAvailPlaces = NewAvailPlaces - 1 ' decreament the value by one

                With ParticipationDetails
                    .AvailSpaces = NewAvailPlaces ' write the new avaiable spaces left
                End With

                FilePut(1, ParticipationDetails, RecPos) ' replace all the old details with the new details

            End If


        Next
        FileClose(1)
    End Sub
    Private Function SpacesAvail()
        Dim available As Boolean = True  ' boolean expression to find if there is a space left in a facility

        Dim PartcipationDetails As ParticipationDatesType  ' create a new record to store Facility details


        Dim ParticipationFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the facility records

        FileOpen(2, ParticipationFile, OpenMode.Random,,, Len(PartcipationDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(2) / Len(PartcipationDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(2, PartcipationDetails, RecPos) ' retrieve the file

            ' check if the are available spaces in the facility
            If Trim(PartcipationDetails.ParticipationID) = ParticipationID_txtb.Text Then
                If Trim(Val(PartcipationDetails.AvailSpaces)) = 0 Then ' if the facilityID does not have any spaces left
                    available = False

                End If
            End If

        Next

        FileClose(2) ' close the file
        If available = False Then
            MsgBox("facility fully booked")
            Return False
        Else
            Return True
        End If



    End Function


    Private Function IsDateAndTimeAlreadyBooked()

        Dim BookingDetails As BookingType = Nothing ' create a new record to store booking details


        Dim BookingFile As String = Application.StartupPath & "/Bookings.dat" ' find the file which has the member records

        FileOpen(1, BookingFile, OpenMode.Random,,, Len(BookingDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(BookingDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim Exists As Boolean = False ' boolean expression checks whether the item exists in the file or not

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.


            FileGet(1, BookingDetails, RecPos) ' retrieve the file


            If Trim(BookingDetails.MemberEmail) = MainPage.MyEmail And Trim(BookingDetails.ParticipationID) = ParticipationID_txtb.Text And Trim(Val(BookingDetails.BookingID)) <> -1 Then  'if the FacilityID has been already booked by the member then procede

                Exists = True ' set the exists to true. Meaning the facilityID already exists in the file under the member email address whose booking it

            End If

        Next

        If Exists = True Then
            MsgBox("You have already booked the facility for this date and time", MsgBoxStyle.Critical) ' display error message
            FileClose(1)
            Return True ' set the function to true
        Else
            Return False ' set the function to false
            FileClose(1)

        End If

        FileClose(1)
    End Function
    Private Sub RefreshForm(e)
        'refresh the form to show updated results
        Me.Controls.Clear() 'remove all the controls on the form
        InitializeComponent() 'load all the controls again
        Member_BookDateTime_Load(e, e)

    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Close()
        Member_BookFacility.Show()
    End Sub
End Class