Public Class StaffArea_AvailableFacilities
    Public FacilityID As String


    Private Sub StaffArea_AvailableFacilitiesBtn_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.BackColor = Color.SkyBlue
        Call Retrieving_AllFacilities()

        With AvailFacilities_lv
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
            .Columns.Add("ClassNo", 70)
            .Columns.Add("StaffID", 200)


        End With
    End Sub

    Private Sub LvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub
    Private Sub Retrieving_AllFacilities()
        Dim FacilityDetails As FacilityType  ' create a new record to store facility details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record


        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
            FileGet(1, FacilityDetails, RecPos) ' retrieve the file

            If Not Trim(Val(FacilityDetails.FacilityID)) = -1 Then ' check if the facilityID has a value of -1

                With FacilityDetails ' add each found item to listview (in different columns)
                    LvwAddItem(AvailFacilities_lv, .FacilityID, .Name, .ClassNo, .StaffID)

                End With
                AvailFacilities_lv.Sorting = SortOrder.Ascending ' sorting records by date

            End If
        Next


        FileClose(1) ' close the file
    End Sub

    Private Sub Menu_btn_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub RemoveFac_btn_Click(sender As Object, e As EventArgs) Handles RemoveFac_btn.Click
        If Validation_Verification() = True Then
            Call Delete_Facility() ' call to different subroutine to delete facility
            Call RefreshForm(e) ' refreh form
        End If
    End Sub
    Private Sub Delete_Facility()
        Dim FacilityDetails As FacilityType  ' create a new record to store facility details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record

        Dim found As Boolean = False


        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
            FileGet(1, FacilityDetails, RecPos) ' retrieve the file

            If Trim(FacilityDetails.FacilityID) = FacilityID_txtb.Text Then
                found = True

                FacilityDetails.FacilityID = "-1"  ' replace the value of the FacilityID to -1


                FilePut(1, FacilityDetails, RecPos) ' replace the old FacilityID with the new value

                MsgBox("The facility has been removed", MsgBoxStyle.OkOnly) ' a message box displaying that the Facility has been removed
            End If
        Next

        'show error message box if faiclity not found
        If found = False Then
            MsgBox("Facility does not exist")

        End If


        FileClose(1) ' close the file


    End Sub

    Private Sub AddFac_btn_Click(sender As Object, e As EventArgs) Handles AddFac_btn.Click
        Me.Close()
        StaffArea_AddNewFacility.Show()
    End Sub
    Private Sub RefreshForm(e)
        'refresh the form to show updated results

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        StaffArea_AvailableFacilitiesBtn_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click
        If Validation_Verification() = True Then
            FileClose(1)

            Dim FacilityDetails As FacilityType  ' create a new record to store facility details


            Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the facility records

            FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

            Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
            Dim RecPos As Integer ' stores the position of the record

            Dim found As Boolean = False

            FacilityID = FacilityID_txtb.Text

            For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
                FileGet(1, FacilityDetails, RecPos) ' retrieve the file

                If Trim(FacilityDetails.FacilityID) = FacilityID Then
                    found = True

                End If


            Next

            'show error message box if facility not found
            If found = True Then

                FacilityID = FacilityID



                FileClose(1) 'close file


                StaffArea_EditDateTime.Show()
                Me.Hide()



            End If


            If found = False Then
                MsgBox("Facility does not exist")

                FileClose(1) 'close file

            End If



        End If

        FileClose(1) 'close file

    End Sub

    Private Sub SignOut_btn_Click(sender As Object, e As EventArgs) Handles SignOut_btn.Click
        Me.Close()
        StaffArea_Login.Show()
    End Sub

    Function Validation_Verification()
        Dim checks As Integer = 0
        If FacilityID_txtb.Text = "" Then
            MsgBox("Space texbox is empty! Type a value")
        Else
            checks = checks + 1
        End If

        ' Type check for FacilityID 
        If Not IsNumeric(FacilityID_txtb.Text) And FacilityID_txtb.Text <> "" Then
            MsgBox("only integers allowed!")
        Else
            checks = checks + 1
        End If

        If checks = 2 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class