<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member_MyBookings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SubHeader_lbl = New System.Windows.Forms.Label()
        Me.Message_lbl = New System.Windows.Forms.Label()
        Me.BookingID_txtb = New System.Windows.Forms.TextBox()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.CancelBooking_btn = New System.Windows.Forms.Button()
        Me.MyBookings_lv = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'SubHeader_lbl
        '
        Me.SubHeader_lbl.AutoSize = True
        Me.SubHeader_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubHeader_lbl.Location = New System.Drawing.Point(33, 41)
        Me.SubHeader_lbl.Name = "SubHeader_lbl"
        Me.SubHeader_lbl.Size = New System.Drawing.Size(277, 20)
        Me.SubHeader_lbl.TabIndex = 0
        Me.SubHeader_lbl.Text = "All the Facilities booked by you:"
        '
        'Message_lbl
        '
        Me.Message_lbl.AutoSize = True
        Me.Message_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message_lbl.Location = New System.Drawing.Point(484, 444)
        Me.Message_lbl.Name = "Message_lbl"
        Me.Message_lbl.Size = New System.Drawing.Size(414, 20)
        Me.Message_lbl.TabIndex = 1
        Me.Message_lbl.Text = "To cancel a booking, please type the Booking ID"
        '
        'BookingID_txtb
        '
        Me.BookingID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingID_txtb.Location = New System.Drawing.Point(553, 488)
        Me.BookingID_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BookingID_txtb.Name = "BookingID_txtb"
        Me.BookingID_txtb.Size = New System.Drawing.Size(177, 27)
        Me.BookingID_txtb.TabIndex = 3
        '
        'Menu_btn
        '
        Me.Menu_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Menu_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Menu_btn.Location = New System.Drawing.Point(1283, 11)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(94, 35)
        Me.Menu_btn.TabIndex = 5
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'CancelBooking_btn
        '
        Me.CancelBooking_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBooking_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelBooking_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.CancelBooking_btn.Location = New System.Drawing.Point(553, 539)
        Me.CancelBooking_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelBooking_btn.Name = "CancelBooking_btn"
        Me.CancelBooking_btn.Size = New System.Drawing.Size(165, 39)
        Me.CancelBooking_btn.TabIndex = 6
        Me.CancelBooking_btn.Text = "Cancel Booking"
        Me.CancelBooking_btn.UseVisualStyleBackColor = True
        '
        'MyBookings_lv
        '
        Me.MyBookings_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyBookings_lv.Location = New System.Drawing.Point(36, 71)
        Me.MyBookings_lv.Margin = New System.Windows.Forms.Padding(4)
        Me.MyBookings_lv.Name = "MyBookings_lv"
        Me.MyBookings_lv.Size = New System.Drawing.Size(1228, 341)
        Me.MyBookings_lv.TabIndex = 7
        Me.MyBookings_lv.UseCompatibleStateImageBehavior = False
        '
        'Member_MyBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 589)
        Me.Controls.Add(Me.MyBookings_lv)
        Me.Controls.Add(Me.CancelBooking_btn)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.BookingID_txtb)
        Me.Controls.Add(Me.Message_lbl)
        Me.Controls.Add(Me.SubHeader_lbl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Member_MyBookings"
        Me.Text = "Member_MyBookings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubHeader_lbl As Label
    Friend WithEvents Message_lbl As Label
    Friend WithEvents BookingID_txtb As TextBox
    Friend WithEvents Menu_btn As Button
    Friend WithEvents CancelBooking_btn As Button
    Friend WithEvents MyBookings_lv As ListView
End Class
