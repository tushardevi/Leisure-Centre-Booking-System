Public Class Member_MyBookings
    Dim FacilityID As String ' global variable which stores the FacilityID as an integer
    Dim ParticipationID As String 'global variable
    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        'close current form and open a different one
        Me.Close()
        MemberLogIn_Menu.Show()
    End Sub
    Private Sub LvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub

    Public Sub Retrieving_MyBookings()

        'OPEN BOOKING DETAILS FILE

        Dim BookingDetails As BookingType = Nothing ' create a new record to store Booking details

        Dim BookingFile As String = Application.StartupPath & "/Bookings.dat" ' find the file which has the booking records

        FileOpen(1, BookingFile, OpenMode.Random,,, Len(BookingDetails)) ' open the file in random mode

        Dim BoookingNumRecs As Integer = LOF(1) / Len(BookingDetails) ' calculate the total number of records in the bookings file
        Dim BookingRecPos As Integer ' stores the position of the record

        'OPEN PARTICIPATION DATE AND TIME DETAILS FILE

        Dim ParticipationDetails As ParticipationDatesType = Nothing ' create a new record to store facility details

        Dim ParticipationFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the facility records

        FileOpen(2, ParticipationFile, OpenMode.Random,,, Len(ParticipationDetails)) ' open the file in random mode

        Dim PartiNumRecs As Integer = LOF(2) / Len(ParticipationDetails) ' calculate the total number of records in the facilities file
        Dim PartiRecPos As Integer ' stores the position of the record

        'OPEN FACILITY DETAILS FILE

        Dim FacilityDetails As FacilityType = Nothing ' create a new record to store facility details

        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(3, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim FaciNumRecs As Integer = LOF(3) / Len(ParticipationDetails) ' calculate the total number of records in the facilities file
        Dim FaciRecPos As Integer ' stores the position of the record


        ' LOOP THROUGH THREE FILES

        For BookingRecPos = 1 To BoookingNumRecs ' first loop through booking file to find all possible records until the end of file.
            FileGet(1, BookingDetails, BookingRecPos) ' retrieve the bookings file

            If Not Trim(Val(BookingDetails.BookingID)) = -1 Then ' check if the  BookingID field is not equal to -1

                If Trim(BookingDetails.MemberEmail) = MainPage.MyEmail Then  'if member's email matches then procede 



                    For PartiRecPos = 1 To PartiNumRecs ' loop through facilities file until the end of file 
                        FileGet(2, ParticipationDetails, PartiRecPos) ' retrive the facilities file

                        If Not Trim(Val(ParticipationDetails.FacilityID)) = -1 Then ' check if the  FacilityID field is equal -1

                            If Trim(ParticipationDetails.ParticipationID) = Trim(BookingDetails.ParticipationID) Then ' use the facilityID to look for a match in both files

                                For FaciRecPos = 1 To FaciNumRecs

                                    FileGet(3, FacilityDetails, FaciRecPos)

                                    If Not Trim(Val(FacilityDetails.FacilityID)) = -1 Then

                                        If Trim(FacilityDetails.FacilityID) = Trim(ParticipationDetails.FacilityID) Then
                                            ' add all essential details on the listview
                                            Dim Time As String
                                            Time = Microsoft.VisualBasic.Left(Trim(ParticipationDetails.Time), 2) + ":" + Microsoft.VisualBasic.Right(Trim(ParticipationDetails.Time), 2)
                                            LvwAddItem(MyBookings_lv, ParticipationDetails.Day, Time, BookingDetails.BookingID, FacilityDetails.Name, FacilityDetails.ClassNo)


                                        End If
                                    End If
                                Next


                            End If
                        End If

                    Next

                    MyBookings_lv.Sorting = SortOrder.Ascending ' sort the bookings by date

                End If
            End If
        Next

        FileClose(1) ' close  Booking File
        FileClose(2) ' close partcipation File
        FileClose(3) 'close facility file


    End Sub


    Private Sub MemberLogIn_Menu_MyBookingsBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.SkyBlue
        Call Retrieving_MyBookings() ' call the subroutine when the form loads

        With MyBookings_lv
            .View = View.Details   ' view all columns and other details inside the listview

            'add details to the listview
            .LabelEdit = False
            .HideSelection = False
            .GridLines = True
            .CheckBoxes = False
            .FullRowSelect = True


            ' add columns to the listview

            .Columns.Add("Date", 100)
            .Columns.Add("Time", 80)
            .Columns.Add("Booking ID", 100)
            .Columns.Add("Facility", 100)
            .Columns.Add("Class No", 80)




        End With


    End Sub

    Private Sub CancelBooking_btn_Click(sender As Object, e As EventArgs) Handles CancelBooking_btn.Click
        Dim BookingDetails As BookingType  ' create a new record to store Booking details


        Dim BookingFile As String = Application.StartupPath & "/Bookings.dat" ' find the file which has the facility records

        FileOpen(6, BookingFile, OpenMode.Random,,, Len(BookingDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(6) / Len(BookingDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim found As Boolean = False ' boolean expression

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
            FileGet(6, BookingDetails, RecPos) ' retrieve the file

            If Trim(BookingDetails.BookingID) = BookingID_txtb.Text Then
                ParticipationID = Trim(BookingDetails.ParticipationID) ' store the facilityID of the booking whose about to be deleted
                found = True ' set found  true

                BookingDetails.BookingID = "-1"  ' replace the value of the FacilityID to -1


                FilePut(6, BookingDetails, RecPos) ' replace the old FacilityID with the new value

                MsgBox("Your booking has been cancelled", MsgBoxStyle.OkOnly) ' a message box displaying that the Facility has been removed


            End If
        Next

        FileClose(6) ' close the file

        'output message when booking ID is not found
        If found = False Then
            MsgBox("Booking ID does not exist")

        Else


        End If
        ' if a booking is deleted then increment the available spaces by one
        If found = True Then
            Call IncrementPlaces()
        End If

        Call RefreshForm(e)

    End Sub

    Private Sub IncrementPlaces()

        '   OPEN FACILITY FILE
        Dim ParticipationDetails As ParticipationDatesType  ' create a new record to store Facility details


        Dim ParticipationFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the facility records

        FileOpen(4, ParticipationFile, OpenMode.Random,,, Len(ParticipationDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(4) / Len(ParticipationDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record
        Dim NewAvailPlaces As Integer ' stores available spaces left

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(4, ParticipationDetails, RecPos) ' retrieve the file

            ' If the member cancels a participation date, increase the number of spaces left by one
            If Trim(ParticipationDetails.ParticipationID) = ParticipationID Then ' if the facilityID match then procede

                NewAvailPlaces = Trim(ParticipationDetails.AvailSpaces) ' assign the variable to the original avaiable Places in the facility

                NewAvailPlaces = NewAvailPlaces + 1 ' increament the value by one

                With ParticipationDetails
                    .AvailSpaces = NewAvailPlaces ' write the new available places left
                End With

                FilePut(4, ParticipationDetails, RecPos) ' replace all the old details with the new details

            End If



        Next
        FileClose(4) ' close the file

    End Sub
    Private Sub RefreshForm(e)
        'refresh the form to show updated results

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MemberLogIn_Menu_MyBookingsBtn_Load(e, e) 'Load everything in your form load event again
    End Sub


End Class