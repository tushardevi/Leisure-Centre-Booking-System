Public Class MemberLogIn_Menu
    Private Sub Mydetails_btn_Click(sender As Object, e As EventArgs) Handles Mydetails_btn.Click
        ' go to mydetails form
        Member_MyDetails.Show()
        Me.Hide()

    End Sub

    Private Sub SignOut_btn_Click(sender As Object, e As EventArgs) Handles SignOut_btn.Click
        ' go back to main page
        Me.Hide()
        MainPage.Show()

    End Sub

    Private Sub BookFacility_btn_Click(sender As Object, e As EventArgs) Handles BookFacility_btn.Click
        Me.Hide()
        Member_BookFacility.Show()
    End Sub

    Private Sub MyBookings_btn_Click(sender As Object, e As EventArgs) Handles MyBookings_btn.Click
        Me.Hide()
        Member_MyBookings.Show()

    End Sub

    Private Sub MemberLogIn_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.SkyBlue
    End Sub
End Class