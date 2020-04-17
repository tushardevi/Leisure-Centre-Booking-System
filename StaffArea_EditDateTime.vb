Public Class StaffArea_EditDateTime
    Private Sub LvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub

    Private Sub StaffArea_EditFacility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
        ID_lb.Text = StaffArea_AvailableFacilities.FacilityID

        Call Retrieving_ParticipationDatesAndTimes()

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

        'Adding times to the combobox
        Times_cb.Items.Add("08:00")
        Times_cb.Items.Add("09:00")
        Times_cb.Items.Add("10:00")
        Times_cb.Items.Add("11:00")
        Times_cb.Items.Add("12:00")
        Times_cb.Items.Add("13:00")
        Times_cb.Items.Add("14:00")
        Times_cb.Items.Add("15:00")
        Times_cb.Items.Add("16:00")
        Times_cb.Items.Add("17:00")
        Times_cb.Items.Add("18:00")
        Times_cb.Items.Add("19:00")


    End Sub
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

                If Trim(ParticipationDate.FacilityID) = StaffArea_AvailableFacilities.FacilityID Then  'if facilityID matches then procede 

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
    Private Sub RefreshForm(e)
        'refresh the form to show updated results

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        StaffArea_EditFacility_Load(e, e) 'Load everything in your form load event again
    End Sub

    Function Validation_Verification()
        Dim checks As Integer = 0
        If Spaces_txtb.Text = "" Then
            MsgBox("Space texbox is empty! Type a value")
        Else
            checks = checks + 1
        End If

        ' Type check for FacilityID 
        If Not IsNumeric(Spaces_txtb.Text) And Spaces_txtb.Text <> "" Then
            MsgBox("Only integers allowed!")
        Else
            checks = checks + 1
        End If

        If checks = 2 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub AddNewDate_btn_Click(sender As Object, e As EventArgs) Handles AddNewDate_btn.Click
        If Validation_Verification() = True Then
            Call AddNew_ParticipationDates_ToFile()
            Call RefreshForm(e)
        End If
    End Sub
    Private Sub AddNew_ParticipationDates_ToFile()

        Dim NewParticipationDate As ParticipationDatesType ' declare new ParticipationDateType which stores date and times of a particular facility

        ' Assigning new details into ParticipationDateType
        With NewParticipationDate
            Dim rn As New Random
            Dim RandomInt As String
            RandomInt = rn.Next(1, 9999) ' let the Random Integer be any random number between 1-9999

            ' upload all the details to the NewParticipation record
            .ParticipationID = RandomInt
            .FacilityID = ID_lb.Text
            .Day = Microsoft.VisualBasic.Left(Calendar.Value, 10)
            .Time = Replace(Times_cb.Text, ":", "")
            .AvailSpaces = Spaces_txtb.Text


        End With

        Dim ParticipationDatesFile As String ' Setting up the location of the file 
        ParticipationDatesFile = Application.StartupPath & "/ParticipationDates.dat"


        FileOpen(1, ParticipationDatesFile, OpenMode.Random, , , Len(NewParticipationDate)) 'Opening the file in random mode

        Dim NumOfRecs2 As Integer
        NumOfRecs2 = LOF(1) / Len(NewParticipationDate)    'Calculating the number of record in the file

        Dim RecPos2 As Integer
        RecPos2 = NumOfRecs2 + 1 ' finding the position where the file must be saved

        FilePut(1, NewParticipationDate, RecPos2) 'Storing the new record into the file 
        FileClose(1) ' Closing the file


    End Sub



    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Dim ParticipationDate As ParticipationDatesType ' create a new record to store Booking details


        Dim BookingFile As String = Application.StartupPath & "/ParticipationDates.dat" ' find the file which has the facility records

        FileOpen(1, BookingFile, OpenMode.Random,,, Len(ParticipationDate)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(ParticipationDate) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim found As Boolean = False ' boolean expression

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
            FileGet(1, ParticipationDate, RecPos) ' retrieve the file

            If Trim(ParticipationDate.ParticipationID) = ParticipationID_txtb.Text Then
                found = True ' set found  true

                ParticipationDate.ParticipationID = "-1"  ' replace the value of the FacilityID to -1


                FilePut(1, ParticipationDate, RecPos) ' replace the old FacilityID with the new value

                MsgBox("The ParticipationDate has been cancelled", MsgBoxStyle.OkOnly) ' a message box displaying that the Facility has been removed


            End If
        Next

        FileClose(1) ' close the file

        'output message when booking ID is not found
        If found = False Then
            MsgBox("Participation ID does not exist")

        Else
            found = True
        End If

        Call RefreshForm(e)
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        StaffArea_AvailableFacilities.Close()
        StaffArea_AvailableFacilities.Show()
        Me.Close()
    End Sub

    Private Sub Other_btn_Click(sender As Object, e As EventArgs) Handles Other_btn.Click
        Me.Hide()
        StaffArea_EditExtra.Show()
    End Sub
End Class