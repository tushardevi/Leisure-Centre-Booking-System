Public Class MemberLogIn_Menu_MyDetailsBtn
    Private Sub MemberLogIn_Menu_MyDetailsBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Retriving_MemberDet() ' Call the subroutine to retrive member's details
    End Sub
    Private Sub Retriving_MemberDet()
        Dim MemberRecord As MemberRecord

        Dim Name As String ' create new variables to store all member's details
        Dim Surname As String
        Dim Gender As String
        Dim DOB As String
        Dim Mobile As String
        Dim Email As String

        Dim CustomerFile As String = Application.StartupPath & "/memberDetails.dat" ' find the file which has the members records

        FileOpen(1, CustomerFile, OpenMode.Random,,, Len(MemberRecord)) ' open the file in random mode

        Dim NumRecs As Integer = LOF(1) / Len(MemberRecord) ' calculate the total number of records in the file
        Dim RecPos As Integer




        For RecPos = 1 To NumRecs ' loop through all possible records until the end of file.
            FileGet(1, MemberRecord, RecPos) ' open the file

            If Trim(MemberRecord.Email) = MainPage.MyEmail Then

                Name = Trim(MemberRecord.Name)
                Surname = Trim(MemberRecord.Surname)
                Gender = Trim(MemberRecord.Gender)
                DOB = Trim(MemberRecord.DOB)
                Mobile = Trim(MemberRecord.Mobile)
                Email = Trim(MemberRecord.Email)

                Name_txtb.Text = Name
                Surname_txtb.Text = Surname
                Gender_txtb.Text = Gender
                DOB_txtb.Text = DOB
                Mobile_txtb.Text = Mobile
                Email_txtb.Text = Email
            End If
        Next
        FileClose(1)

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Name_txtb.ReadOnly = False
        Surname_txtb.ReadOnly = False
        Mobile_txtb.ReadOnly = False

    End Sub
End Class