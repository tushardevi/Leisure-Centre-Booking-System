<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberLogIn_Menu_MyBookingsBtn
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
        Me.SubHeader_lbl = New System.Windows.Forms.Label()
        Me.Message_lbl = New System.Windows.Forms.Label()
        Me.FacilityID_lbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AllFacilities_lv = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'SubHeader_lbl
        '
        Me.SubHeader_lbl.AutoSize = True
        Me.SubHeader_lbl.Location = New System.Drawing.Point(24, 46)
        Me.SubHeader_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SubHeader_lbl.Name = "SubHeader_lbl"
        Me.SubHeader_lbl.Size = New System.Drawing.Size(86, 13)
        Me.SubHeader_lbl.TabIndex = 0
        Me.SubHeader_lbl.Text = "All my bookings: "
        '
        'Message_lbl
        '
        Me.Message_lbl.AutoSize = True
        Me.Message_lbl.Location = New System.Drawing.Point(41, 236)
        Me.Message_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Message_lbl.Name = "Message_lbl"
        Me.Message_lbl.Size = New System.Drawing.Size(415, 13)
        Me.Message_lbl.TabIndex = 1
        Me.Message_lbl.Text = "To cancel a booking, please type below the facility ID and press on ""Cancel Booki" &
    "ng""."
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Location = New System.Drawing.Point(128, 272)
        Me.FacilityID_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(53, 13)
        Me.FacilityID_lbl.TabIndex = 2
        Me.FacilityID_lbl.Text = "Facility ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(206, 270)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(431, 10)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(66, 19)
        Me.Menu_btn.TabIndex = 5
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 308)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel Booking"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AllFacilities_lv
        '
        Me.AllFacilities_lv.Location = New System.Drawing.Point(27, 62)
        Me.AllFacilities_lv.Name = "AllFacilities_lv"
        Me.AllFacilities_lv.Size = New System.Drawing.Size(448, 161)
        Me.AllFacilities_lv.TabIndex = 7
        Me.AllFacilities_lv.UseCompatibleStateImageBehavior = False
        '
        'MemberLogIn_Menu_MyBookingsBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 362)
        Me.Controls.Add(Me.AllFacilities_lv)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Controls.Add(Me.Message_lbl)
        Me.Controls.Add(Me.SubHeader_lbl)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MemberLogIn_Menu_MyBookingsBtn"
        Me.Text = "MemberLogIn_Menu_MyBookingsBtn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubHeader_lbl As Label
    Friend WithEvents Message_lbl As Label
    Friend WithEvents FacilityID_lbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Menu_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AllFacilities_lv As ListView
End Class
