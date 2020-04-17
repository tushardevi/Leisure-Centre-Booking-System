Public Class StaffArea_Login
    Private Sub Menu_btn_Click(sender As Object, e As EventArgs) Handles Menu_btn.Click
        MainPage.Show() 'Show main menu
        Me.Hide() ' Hide current window
    End Sub

    Private Sub AddNewStaff_ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddNewStaff_ll.LinkClicked
        Me.Hide() ' hide current window
        StaffArea_AddNewStaff.Show() ' show Add New Staff form
    End Sub
End Class