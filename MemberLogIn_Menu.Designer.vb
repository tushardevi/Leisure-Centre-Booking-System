<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberLogIn_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Mydetails_btn = New System.Windows.Forms.Button()
        Me.MyBookings_btn = New System.Windows.Forms.Button()
        Me.BookFacility_btn = New System.Windows.Forms.Button()
        Me.HirePT_btn = New System.Windows.Forms.Button()
        Me.BookSH_btn = New System.Windows.Forms.Button()
        Me.SignOut_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Mydetails_btn
        '
        Me.Mydetails_btn.Location = New System.Drawing.Point(72, 62)
        Me.Mydetails_btn.Name = "Mydetails_btn"
        Me.Mydetails_btn.Size = New System.Drawing.Size(134, 53)
        Me.Mydetails_btn.TabIndex = 0
        Me.Mydetails_btn.Text = "My Details"
        Me.Mydetails_btn.UseVisualStyleBackColor = True
        '
        'MyBookings_btn
        '
        Me.MyBookings_btn.Location = New System.Drawing.Point(305, 62)
        Me.MyBookings_btn.Name = "MyBookings_btn"
        Me.MyBookings_btn.Size = New System.Drawing.Size(136, 53)
        Me.MyBookings_btn.TabIndex = 1
        Me.MyBookings_btn.Text = "My Bookings"
        Me.MyBookings_btn.UseVisualStyleBackColor = True
        '
        'BookFacility_btn
        '
        Me.BookFacility_btn.Location = New System.Drawing.Point(194, 143)
        Me.BookFacility_btn.Name = "BookFacility_btn"
        Me.BookFacility_btn.Size = New System.Drawing.Size(119, 55)
        Me.BookFacility_btn.TabIndex = 2
        Me.BookFacility_btn.Text = "Book Facility"
        Me.BookFacility_btn.UseVisualStyleBackColor = True
        '
        'HirePT_btn
        '
        Me.HirePT_btn.Location = New System.Drawing.Point(72, 217)
        Me.HirePT_btn.Name = "HirePT_btn"
        Me.HirePT_btn.Size = New System.Drawing.Size(124, 57)
        Me.HirePT_btn.TabIndex = 3
        Me.HirePT_btn.Text = "Hire Personal Trainer"
        Me.HirePT_btn.UseVisualStyleBackColor = True
        '
        'BookSH_btn
        '
        Me.BookSH_btn.Location = New System.Drawing.Point(305, 220)
        Me.BookSH_btn.Name = "BookSH_btn"
        Me.BookSH_btn.Size = New System.Drawing.Size(136, 54)
        Me.BookSH_btn.TabIndex = 4
        Me.BookSH_btn.Text = "Book Sports Hall"
        Me.BookSH_btn.UseVisualStyleBackColor = True
        '
        'SignOut_btn
        '
        Me.SignOut_btn.Location = New System.Drawing.Point(486, 12)
        Me.SignOut_btn.Name = "SignOut_btn"
        Me.SignOut_btn.Size = New System.Drawing.Size(75, 23)
        Me.SignOut_btn.TabIndex = 5
        Me.SignOut_btn.Text = "Sign Out"
        Me.SignOut_btn.UseVisualStyleBackColor = True
        '
        'MemberLogIn_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 358)
        Me.Controls.Add(Me.SignOut_btn)
        Me.Controls.Add(Me.BookSH_btn)
        Me.Controls.Add(Me.HirePT_btn)
        Me.Controls.Add(Me.BookFacility_btn)
        Me.Controls.Add(Me.MyBookings_btn)
        Me.Controls.Add(Me.Mydetails_btn)
        Me.Name = "MemberLogIn_Menu"
        Me.Text = "MemberLogIn_Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mydetails_btn As Button
    Friend WithEvents MyBookings_btn As Button
    Friend WithEvents BookFacility_btn As Button
    Friend WithEvents HirePT_btn As Button
    Friend WithEvents BookSH_btn As Button
    Friend WithEvents SignOut_btn As Button
End Class
