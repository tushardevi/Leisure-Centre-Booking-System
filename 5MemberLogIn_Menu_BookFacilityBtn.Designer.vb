<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _5MemberLogIn_Menu_BookFacilityBtn
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
        Me.AllFacilities_lb = New System.Windows.Forms.ListBox()
        Me.SubHeader_lbl = New System.Windows.Forms.Label()
        Me.Message_lbl = New System.Windows.Forms.Label()
        Me.FacilityID_lbl = New System.Windows.Forms.Label()
        Me.FacilityID_txtb = New System.Windows.Forms.TextBox()
        Me.BookNow_btn = New System.Windows.Forms.Button()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AllFacilities_lb
        '
        Me.AllFacilities_lb.FormattingEnabled = True
        Me.AllFacilities_lb.Location = New System.Drawing.Point(34, 77)
        Me.AllFacilities_lb.Name = "AllFacilities_lb"
        Me.AllFacilities_lb.Size = New System.Drawing.Size(475, 147)
        Me.AllFacilities_lb.TabIndex = 0
        '
        'SubHeader_lbl
        '
        Me.SubHeader_lbl.AutoSize = True
        Me.SubHeader_lbl.Location = New System.Drawing.Point(42, 61)
        Me.SubHeader_lbl.Name = "SubHeader_lbl"
        Me.SubHeader_lbl.Size = New System.Drawing.Size(103, 13)
        Me.SubHeader_lbl.TabIndex = 1
        Me.SubHeader_lbl.Text = "All available facilities"
        '
        'Message_lbl
        '
        Me.Message_lbl.AutoSize = True
        Me.Message_lbl.Location = New System.Drawing.Point(42, 231)
        Me.Message_lbl.Name = "Message_lbl"
        Me.Message_lbl.Size = New System.Drawing.Size(316, 13)
        Me.Message_lbl.TabIndex = 2
        Me.Message_lbl.Text = "Type the ““Facility ID”” number in the box below to book that facility"
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Location = New System.Drawing.Point(121, 278)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(53, 13)
        Me.FacilityID_lbl.TabIndex = 3
        Me.FacilityID_lbl.Text = "Facility ID"
        '
        'FacilityID_txtb
        '
        Me.FacilityID_txtb.Location = New System.Drawing.Point(185, 275)
        Me.FacilityID_txtb.Name = "FacilityID_txtb"
        Me.FacilityID_txtb.Size = New System.Drawing.Size(100, 20)
        Me.FacilityID_txtb.TabIndex = 4
        '
        'BookNow_btn
        '
        Me.BookNow_btn.Location = New System.Drawing.Point(312, 273)
        Me.BookNow_btn.Name = "BookNow_btn"
        Me.BookNow_btn.Size = New System.Drawing.Size(75, 23)
        Me.BookNow_btn.TabIndex = 5
        Me.BookNow_btn.Text = "Book Now"
        Me.BookNow_btn.UseVisualStyleBackColor = True
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(453, 12)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.Menu_btn.TabIndex = 6
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        '_5MemberLogIn_Menu_BookFacilityBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 376)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.BookNow_btn)
        Me.Controls.Add(Me.FacilityID_txtb)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Controls.Add(Me.Message_lbl)
        Me.Controls.Add(Me.SubHeader_lbl)
        Me.Controls.Add(Me.AllFacilities_lb)
        Me.Name = "_5MemberLogIn_Menu_BookFacilityBtn"
        Me.Text = "_5MemberLogIn_Menu_BookFacilityBtn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllFacilities_lb As ListBox
    Friend WithEvents SubHeader_lbl As Label
    Friend WithEvents Message_lbl As Label
    Friend WithEvents FacilityID_lbl As Label
    Friend WithEvents FacilityID_txtb As TextBox
    Friend WithEvents BookNow_btn As Button
    Friend WithEvents Menu_btn As Button
End Class
