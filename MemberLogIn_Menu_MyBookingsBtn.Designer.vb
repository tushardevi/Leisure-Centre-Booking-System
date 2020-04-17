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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'SubHeader_lbl
        '
        Me.SubHeader_lbl.AutoSize = True
        Me.SubHeader_lbl.Location = New System.Drawing.Point(32, 56)
        Me.SubHeader_lbl.Name = "SubHeader_lbl"
        Me.SubHeader_lbl.Size = New System.Drawing.Size(114, 17)
        Me.SubHeader_lbl.TabIndex = 0
        Me.SubHeader_lbl.Text = "All my bookings: "
        '
        'Message_lbl
        '
        Me.Message_lbl.AutoSize = True
        Me.Message_lbl.Location = New System.Drawing.Point(55, 290)
        Me.Message_lbl.Name = "Message_lbl"
        Me.Message_lbl.Size = New System.Drawing.Size(544, 17)
        Me.Message_lbl.TabIndex = 1
        Me.Message_lbl.Text = "To cancel a booking, please type below the facility ID and press on ““Cancel Booki" &
    "ng""."
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Location = New System.Drawing.Point(170, 335)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(68, 17)
        Me.FacilityID_lbl.TabIndex = 2
        Me.FacilityID_lbl.Text = "Facility ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(275, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(575, 12)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(88, 23)
        Me.Menu_btn.TabIndex = 5
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel Booking"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(35, 76)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(606, 200)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MemberLogIn_Menu_MyBookingsBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 445)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Controls.Add(Me.Message_lbl)
        Me.Controls.Add(Me.SubHeader_lbl)
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
    Friend WithEvents ListView1 As ListView
End Class
