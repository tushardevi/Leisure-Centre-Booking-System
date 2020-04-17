Public Class StaffArea_FacilitiesBtn


    Private Sub AddFac_btn_Click(sender As Object, e As EventArgs) Handles AddFac_btn.Click
        Me.Hide()
        _16StaffArea_FacilitiesBtn_AddNewFacilityBtn.Show()
    End Sub

    Private Sub StaffArea_FacilitiesBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call Retrieving_AllFacilities()

    End Sub

    Public Sub lvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))      ' adding subitems to the listview
        End With
    End Sub
    Private Sub Retrieving_AllFacilities()
        Dim FacilityDetails As FacilityType ' create a new record to store member details


        Dim FacilityFile As String = Application.StartupPath & "/Facilities.dat" ' find the file which has the members records

        FileOpen(1, FacilityFile, OpenMode.Random,,, Len(FacilityDetails)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(FacilityDetails) ' calculate the total number of records in the file
        Dim RecPos As Integer ' stores the position of the record



        With ListView1
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
            .Columns.Add("MaxCapcacity", 70)
            .Columns.Add("StaffID", 200)
        End With


        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.

            FileGet(1, FacilityDetails, RecPos) ' retrieve the file

            With FacilityDetails ' add each found item to listview (in different columns)
                lvwAddItem(ListView1, .FacilityID, .Name, .ClassNo, .MaxCapacity, .StaffID)
            End With

        Next

        FileClose(1) ' close the file
    End Sub






End Class