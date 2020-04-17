Public Class StaffArea_EditExtra
    Public NewAvailPlaces As Integer  ' global variable
    Private Sub StaffArea_EditFacility2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
        Call Retriving_FaciityDetails()
    End Sub

    Private Sub Retriving_FaciityDetails()

        Dim FacilityDetails As FacilityType ' create a new record to store facility details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the members records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record




        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, FacilityDetails, RecPos) ' retrieve the file

            Dim FacilityID As String

            FacilityID = StaffArea_AvailableFacilities.FacilityID

            If Trim(FacilityDetails.FacilityID) = FacilityID Then ' if the FacilityID matches then procede

                FacilityID_txtb.Text = Trim(FacilityDetails.FacilityID)  ' display all the fields into the texboxes
                Name_txtb.Text = Trim(FacilityDetails.Name)
                ClassNo_txtb.Text = Trim(FacilityDetails.ClassNo)

                StaffID_txtb.Text = Trim(FacilityDetails.StaffID)


            End If
        Next


        FileClose(1) ' close the file
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        ' display all the fields into the texboxes
        Name_txtb.ReadOnly = False
        ClassNo_txtb.ReadOnly = False


    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click

        Dim Updated_FacilityDetails As FacilityType ' create a new record which to store the updated details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' declare the file location


        FileOpen(3, FacilityFile, OpenMode.Random,,, Len(Updated_FacilityDetails)) ' open the file in random mode


        Dim NumRecs As Integer = LOF(3) / Len(Updated_FacilityDetails) ' calculate the number of records in the file

        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(3, Updated_FacilityDetails, RecPos) ' retrieve the file

            If Trim(Updated_FacilityDetails.FacilityID) = FacilityID_txtb.Text Then ' if the facilityID matches then procede
                'If CheckForAvailablePlaces() = True Then
                FileClose(2)
                With Updated_FacilityDetails   ' copy the new details into the record
                    ' display all the fields into the texboxes
                    .Name = Name_txtb.Text
                    .ClassNo = ClassNo_txtb.Text

                    .StaffID = StaffID_txtb.Text

                End With

                FilePut(3, Updated_FacilityDetails, RecPos) ' replace all the old details with the new details

                MsgBox("All your details have been updated!", MsgBoxStyle.OkOnly) ' a message box displaying that the procedure has succesfully ended
            End If
            'End If

        Next

        'change status to read only
        Name_txtb.ReadOnly = True
        ClassNo_txtb.ReadOnly = True

        StaffID_txtb.ReadOnly = True

        FileClose(3) ' closing the file

    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Close()

        StaffArea_EditDateTime.Show()

    End Sub







End Class