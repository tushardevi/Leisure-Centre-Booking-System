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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberLogIn_Menu))
        Me.Mydetails_btn = New System.Windows.Forms.Button()
        Me.MyBookings_btn = New System.Windows.Forms.Button()
        Me.BookFacility_btn = New System.Windows.Forms.Button()
        Me.SignOut_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Mydetails_btn
        '
        Me.Mydetails_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mydetails_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Mydetails_btn.Image = CType(resources.GetObject("Mydetails_btn.Image"), System.Drawing.Image)
        Me.Mydetails_btn.Location = New System.Drawing.Point(41, 73)
        Me.Mydetails_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Mydetails_btn.Name = "Mydetails_btn"
        Me.Mydetails_btn.Size = New System.Drawing.Size(130, 68)
        Me.Mydetails_btn.TabIndex = 0
        Me.Mydetails_btn.Text = "My Details"
        Me.Mydetails_btn.UseVisualStyleBackColor = True
        '
        'MyBookings_btn
        '
        Me.MyBookings_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyBookings_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyBookings_btn.Image = CType(resources.GetObject("MyBookings_btn.Image"), System.Drawing.Image)
        Me.MyBookings_btn.Location = New System.Drawing.Point(231, 73)
        Me.MyBookings_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MyBookings_btn.Name = "MyBookings_btn"
        Me.MyBookings_btn.Size = New System.Drawing.Size(139, 68)
        Me.MyBookings_btn.TabIndex = 1
        Me.MyBookings_btn.Text = "My Bookings"
        Me.MyBookings_btn.UseVisualStyleBackColor = True
        '
        'BookFacility_btn
        '
        Me.BookFacility_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookFacility_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BookFacility_btn.Image = CType(resources.GetObject("BookFacility_btn.Image"), System.Drawing.Image)
        Me.BookFacility_btn.Location = New System.Drawing.Point(143, 180)
        Me.BookFacility_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BookFacility_btn.Name = "BookFacility_btn"
        Me.BookFacility_btn.Size = New System.Drawing.Size(130, 70)
        Me.BookFacility_btn.TabIndex = 2
        Me.BookFacility_btn.Text = "Book Facility"
        Me.BookFacility_btn.UseVisualStyleBackColor = True
        '
        'SignOut_btn
        '
        Me.SignOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SignOut_btn.Image = CType(resources.GetObject("SignOut_btn.Image"), System.Drawing.Image)
        Me.SignOut_btn.Location = New System.Drawing.Point(336, 11)
        Me.SignOut_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SignOut_btn.Name = "SignOut_btn"
        Me.SignOut_btn.Size = New System.Drawing.Size(90, 40)
        Me.SignOut_btn.TabIndex = 5
        Me.SignOut_btn.Text = "Sign Out"
        Me.SignOut_btn.UseVisualStyleBackColor = True
        '
        'MemberLogIn_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 291)
        Me.Controls.Add(Me.SignOut_btn)
        Me.Controls.Add(Me.BookFacility_btn)
        Me.Controls.Add(Me.MyBookings_btn)
        Me.Controls.Add(Me.Mydetails_btn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MemberLogIn_Menu"
        Me.Text = "MemberLogIn_Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mydetails_btn As Button
    Friend WithEvents MyBookings_btn As Button
    Friend WithEvents BookFacility_btn As Button
    Friend WithEvents SignOut_btn As Button
End Class
