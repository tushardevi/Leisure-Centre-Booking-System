<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_BookDateTime
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
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.BookNow_btn = New System.Windows.Forms.Button()
        Me.ParticipationID_txtb = New System.Windows.Forms.TextBox()
        Me.ID_lb = New System.Windows.Forms.Label()
        Me.FacilityID_lb = New System.Windows.Forms.Label()
        Me.DateAndTimes_lv = New System.Windows.Forms.ListView()
        Me.Heading_lb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Back_btn
        '
        Me.Back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Back_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Back_btn.Location = New System.Drawing.Point(908, 17)
        Me.Back_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(68, 34)
        Me.Back_btn.TabIndex = 43
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'BookNow_btn
        '
        Me.BookNow_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNow_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BookNow_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.BookNow_btn.Location = New System.Drawing.Point(394, 478)
        Me.BookNow_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BookNow_btn.Name = "BookNow_btn"
        Me.BookNow_btn.Size = New System.Drawing.Size(126, 46)
        Me.BookNow_btn.TabIndex = 42
        Me.BookNow_btn.Text = "Book Now"
        Me.BookNow_btn.UseVisualStyleBackColor = True
        '
        'ParticipationID_txtb
        '
        Me.ParticipationID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParticipationID_txtb.Location = New System.Drawing.Point(374, 440)
        Me.ParticipationID_txtb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ParticipationID_txtb.Name = "ParticipationID_txtb"
        Me.ParticipationID_txtb.Size = New System.Drawing.Size(170, 26)
        Me.ParticipationID_txtb.TabIndex = 41
        '
        'ID_lb
        '
        Me.ID_lb.AutoSize = True
        Me.ID_lb.BackColor = System.Drawing.Color.Blue
        Me.ID_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_lb.ForeColor = System.Drawing.Color.AliceBlue
        Me.ID_lb.Location = New System.Drawing.Point(126, 81)
        Me.ID_lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_lb.Name = "ID_lb"
        Me.ID_lb.Size = New System.Drawing.Size(33, 20)
        Me.ID_lb.TabIndex = 36
        Me.ID_lb.Text = "xxx"
        '
        'FacilityID_lb
        '
        Me.FacilityID_lb.AutoSize = True
        Me.FacilityID_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_lb.Location = New System.Drawing.Point(41, 81)
        Me.FacilityID_lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FacilityID_lb.Name = "FacilityID_lb"
        Me.FacilityID_lb.Size = New System.Drawing.Size(99, 20)
        Me.FacilityID_lb.TabIndex = 35
        Me.FacilityID_lb.Text = "Facility ID: "
        '
        'DateAndTimes_lv
        '
        Me.DateAndTimes_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAndTimes_lv.Location = New System.Drawing.Point(46, 104)
        Me.DateAndTimes_lv.Name = "DateAndTimes_lv"
        Me.DateAndTimes_lv.Size = New System.Drawing.Size(831, 294)
        Me.DateAndTimes_lv.TabIndex = 32
        Me.DateAndTimes_lv.UseCompatibleStateImageBehavior = False
        '
        'Heading_lb
        '
        Me.Heading_lb.AutoSize = True
        Me.Heading_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading_lb.Location = New System.Drawing.Point(42, 43)
        Me.Heading_lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Heading_lb.Name = "Heading_lb"
        Me.Heading_lb.Size = New System.Drawing.Size(263, 20)
        Me.Heading_lb.TabIndex = 30
        Me.Heading_lb.Text = "All available dates and times of:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 408)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Type the Participation ID and click on Book Now"
        '
        'Member_BookDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 540)
        Me.Controls.Add(Me.DateAndTimes_lv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.BookNow_btn)
        Me.Controls.Add(Me.ParticipationID_txtb)
        Me.Controls.Add(Me.ID_lb)
        Me.Controls.Add(Me.FacilityID_lb)
        Me.Controls.Add(Me.Heading_lb)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Member_BookDateTime"
        Me.Text = "Choose Date & Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_btn As Button
    Friend WithEvents BookNow_btn As Button
    Friend WithEvents ParticipationID_txtb As TextBox
    Friend WithEvents ID_lb As Label
    Friend WithEvents FacilityID_lb As Label
    Friend WithEvents DateAndTimes_lv As ListView
    Friend WithEvents Heading_lb As Label
    Friend WithEvents Label1 As Label
End Class
