Public Class Member_BookFacility
    Public FacilityID As String ' global variable

    Private Sub Member_BookFacility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
        Call Retrieving_AllFacilities() ' call different subroutine of the same class

        With AllFacilities_lv
            .View = View.Details   ' view all columns and other details inside the listview

            'add details to the listview
            .LabelEdit = False
            .HideSelection = False
            .GridLines = True
            .CheckBoxes = False
            .FullRowSelect = True


            ' add columns to the listview
            .Columns.Add("FacilityID", 70)
            .Columns.Add("Name", 200)
            .Columns.Add("ClassNo", 100)


        End With
    End Sub
    Private Sub LvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub
    Private Sub Retrieving_AllFacilities()
        Dim FacilityDetails As FacilityType  ' create a new record to store Facility details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record





        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, FacilityDetails, RecPos) ' retrieve the file

            If Not Trim(Val(FacilityDetails.FacilityID)) = -1 Then ' check if the facilityID field is equal to -1

                With FacilityDetails ' add each found item to listview (in different columns)
                    LvwAddItem(AllFacilities_lv, .FacilityID, .Name, .ClassNo)

                End With
            End If

        Next

        AllFacilities_lv.Sorting = SortOrder.Ascending ' sorting records by date

        FileClose(1) ' close the file
    End Sub

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        ' close current form and open a different one
        Me.Close()
        MemberLogIn_Menu.Show()
    End Sub

    Private Function CheckForFacilityID()

        Dim FacilityID As String = FacilityID_txtb.Text ' store the value which is in the FacilityID textbox

        Dim itm As ListViewItem ' store each item in facility view list


        ' check if FacilityID exists inside the viewlist
        With AllFacilities_lv

            itm = .FindItemWithText(FacilityID, True, 0, True)

            If Not itm Is Nothing Then ' if it exists then return true

                Return True

            Else
                MsgBox("Facility ID is not recognised, please try again") ' output an error message 
                Return False
            End If

        End With

        itm = Nothing ' make itm equal to NULL



    End Function

    Private Function IsFacilityAlreadyBooked()

        Dim BookingDetails As BookingType = Nothing ' create a new record to store booking details


        Dim BookingFile As String = Application.StartupPath & "/Bookings.dat" ' find the file which has the member records

        FileOpen(1, BookingFile, OpenMode.Random,,, Len(BookingDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(BookingDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim Exists As Boolean = False ' boolean expression checks whether the item exists in the file or not

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.


            FileGet(1, BookingDetails, RecPos) ' retrieve the file


            If Trim(BookingDetails.MemberEmail) = MainPage.MyEmail And Trim(BookingDetails.FacilityID) = FacilityID_txtb.Text And Trim(Val(BookingDetails.BookingID)) <> -1 Then  'if the FacilityID has been already booked by the member then procede

                Exists = True ' set the exists to true. Meaning the facilityID already exists in the file under the member email address whose booking it

            End If

        Next

        If Exists = True Then
            MsgBox("You have already booked this Facility", MsgBoxStyle.Critical) ' display error message

            Return True ' set the function to true
        Else
            Return False ' set the function to false

        End If

        FileClose(1)
    End Function



    Private Function Validation()
        Dim totalchecks As Integer ' a new variable to check if all the fields have been validated or not. 

        'type check
        If IsNumeric(FacilityID_txtb.Text) Then
            totalchecks = totalchecks + 1

        Else

        End If

        'Lenght check
        If Len(FacilityID_txtb.Text) <> 3 Then

        Else
            totalchecks = totalchecks + 1
        End If


        ' checks if all fields have been succesfully validated
        If totalchecks = 2 Then
            Return True

        Else
            MsgBox("Facility ID does is not recognised, please try again")
            Return False

        End If


    End Function



    Private Sub RefreshForm(e)
        'refresh the form to show updated results
        Me.Controls.Clear() 'remove all the controls on the form
        InitializeComponent() 'load all the controls again
        Member_BookFacility_Load(e, e) 'Load everything in your form again
    End Sub

    Private Sub Next_btn_Click(sender As Object, e As EventArgs) Handles Next_btn.Click

        If Validation() = True Then  ' call this function to check for all validations
            If CheckForFacilityID() = True Then ' call this function to check if the facilityID exists in the listview

                FileClose(1) ' close the file after the check

                    FacilityID = FacilityID_txtb.Text
                    Me.Hide()
                    Member_BookDateTime.Show()


                End If
            End If







    End Sub
End Class