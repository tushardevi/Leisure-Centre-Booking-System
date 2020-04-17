<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffArea_EditDateTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffArea_EditDateTime))
        Me.Date_lb = New System.Windows.Forms.Label()
        Me.DateAndTimes_lv = New System.Windows.Forms.ListView()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.Heading_lb = New System.Windows.Forms.Label()
        Me.Time_lb = New System.Windows.Forms.Label()
        Me.FacilityID_lb = New System.Windows.Forms.Label()
        Me.ID_lb = New System.Windows.Forms.Label()
        Me.Calendar = New System.Windows.Forms.DateTimePicker()
        Me.Times_cb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParticipationID_txtb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Spaces_txtb = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Other_btn = New System.Windows.Forms.Button()
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.AddNewDate_btn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_lb
        '
        Me.Date_lb.AutoSize = True
        Me.Date_lb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Date_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_lb.Location = New System.Drawing.Point(33, 558)
        Me.Date_lb.Name = "Date_lb"
        Me.Date_lb.Size = New System.Drawing.Size(55, 20)
        Me.Date_lb.TabIndex = 13
        Me.Date_lb.Text = "Date:"
        '
        'DateAndTimes_lv
        '
        Me.DateAndTimes_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAndTimes_lv.Location = New System.Drawing.Point(37, 84)
        Me.DateAndTimes_lv.Margin = New System.Windows.Forms.Padding(4)
        Me.DateAndTimes_lv.Name = "DateAndTimes_lv"
        Me.DateAndTimes_lv.Size = New System.Drawing.Size(1378, 370)
        Me.DateAndTimes_lv.TabIndex = 12
        Me.DateAndTimes_lv.UseCompatibleStateImageBehavior = False
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(1147, -45)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.Menu_btn.TabIndex = 11
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'Heading_lb
        '
        Me.Heading_lb.AutoSize = True
        Me.Heading_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading_lb.Location = New System.Drawing.Point(32, 9)
        Me.Heading_lb.Name = "Heading_lb"
        Me.Heading_lb.Size = New System.Drawing.Size(279, 20)
        Me.Heading_lb.TabIndex = 8
        Me.Heading_lb.Text = "All available dates and times of:"
        '
        'Time_lb
        '
        Me.Time_lb.AutoSize = True
        Me.Time_lb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Time_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Time_lb.Location = New System.Drawing.Point(313, 557)
        Me.Time_lb.Name = "Time_lb"
        Me.Time_lb.Size = New System.Drawing.Size(65, 25)
        Me.Time_lb.TabIndex = 15
        Me.Time_lb.Text = "Time:"
        '
        'FacilityID_lb
        '
        Me.FacilityID_lb.AutoSize = True
        Me.FacilityID_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_lb.Location = New System.Drawing.Point(33, 56)
        Me.FacilityID_lb.Name = "FacilityID_lb"
        Me.FacilityID_lb.Size = New System.Drawing.Size(107, 20)
        Me.FacilityID_lb.TabIndex = 18
        Me.FacilityID_lb.Text = "Facility ID: "
        '
        'ID_lb
        '
        Me.ID_lb.AutoSize = True
        Me.ID_lb.BackColor = System.Drawing.Color.Blue
        Me.ID_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_lb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ID_lb.Location = New System.Drawing.Point(136, 56)
        Me.ID_lb.Name = "ID_lb"
        Me.ID_lb.Size = New System.Drawing.Size(36, 20)
        Me.ID_lb.TabIndex = 20
        Me.ID_lb.Text = "xxx"
        '
        'Calendar
        '
        Me.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar.Location = New System.Drawing.Point(94, 556)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.Size = New System.Drawing.Size(200, 27)
        Me.Calendar.TabIndex = 21
        '
        'Times_cb
        '
        Me.Times_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Times_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Times_cb.FormattingEnabled = True
        Me.Times_cb.Location = New System.Drawing.Point(384, 555)
        Me.Times_cb.Name = "Times_cb"
        Me.Times_cb.Size = New System.Drawing.Size(131, 28)
        Me.Times_cb.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Add new date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(548, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To delete a particular date, please enter its ParticipationID:"
        '
        'ParticipationID_txtb
        '
        Me.ParticipationID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParticipationID_txtb.Location = New System.Drawing.Point(676, 537)
        Me.ParticipationID_txtb.Name = "ParticipationID_txtb"
        Me.ParticipationID_txtb.Size = New System.Drawing.Size(225, 27)
        Me.ParticipationID_txtb.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1089, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Click on ""Other"" to edit extra information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 613)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Spaces:"
        '
        'Spaces_txtb
        '
        Me.Spaces_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spaces_txtb.Location = New System.Drawing.Point(252, 610)
        Me.Spaces_txtb.Name = "Spaces_txtb"
        Me.Spaces_txtb.Size = New System.Drawing.Size(76, 27)
        Me.Spaces_txtb.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TotalFitness.My.Resources.Resources._65_3_1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 461)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 249)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Other_btn
        '
        Me.Other_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Other_btn.Image = CType(resources.GetObject("Other_btn.Image"), System.Drawing.Image)
        Me.Other_btn.Location = New System.Drawing.Point(1183, 522)
        Me.Other_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Other_btn.Name = "Other_btn"
        Me.Other_btn.Size = New System.Drawing.Size(168, 56)
        Me.Other_btn.TabIndex = 29
        Me.Other_btn.Text = "Other"
        Me.Other_btn.UseVisualStyleBackColor = True
        '
        'Back_btn
        '
        Me.Back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Back_btn.Image = CType(resources.GetObject("Back_btn.Image"), System.Drawing.Image)
        Me.Back_btn.Location = New System.Drawing.Point(1216, 25)
        Me.Back_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(80, 30)
        Me.Back_btn.TabIndex = 27
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'Delete_btn
        '
        Me.Delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Delete_btn.Image = CType(resources.GetObject("Delete_btn.Image"), System.Drawing.Image)
        Me.Delete_btn.Location = New System.Drawing.Point(701, 610)
        Me.Delete_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(168, 56)
        Me.Delete_btn.TabIndex = 26
        Me.Delete_btn.Text = "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Delete_btn.UseVisualStyleBackColor = True
        '
        'AddNewDate_btn
        '
        Me.AddNewDate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewDate_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewDate_btn.Image = CType(resources.GetObject("AddNewDate_btn.Image"), System.Drawing.Image)
        Me.AddNewDate_btn.Location = New System.Drawing.Point(378, 655)
        Me.AddNewDate_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddNewDate_btn.Name = "AddNewDate_btn"
        Me.AddNewDate_btn.Size = New System.Drawing.Size(137, 43)
        Me.AddNewDate_btn.TabIndex = 10
        Me.AddNewDate_btn.Text = "Add"
        Me.AddNewDate_btn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TotalFitness.My.Resources.Resources._65_3_1
        Me.PictureBox2.Location = New System.Drawing.Point(1046, 461)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(409, 249)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TotalFitness.My.Resources.Resources._65_3_1
        Me.PictureBox3.Location = New System.Drawing.Point(538, 461)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(502, 249)
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'StaffArea_EditDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1463, 722)
        Me.Controls.Add(Me.Spaces_txtb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Other_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Delete_btn)
        Me.Controls.Add(Me.ParticipationID_txtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Times_cb)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.ID_lb)
        Me.Controls.Add(Me.FacilityID_lb)
        Me.Controls.Add(Me.Time_lb)
        Me.Controls.Add(Me.Date_lb)
        Me.Controls.Add(Me.DateAndTimes_lv)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.AddNewDate_btn)
        Me.Controls.Add(Me.Heading_lb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "StaffArea_EditDateTime"
        Me.Text = "Edit Date & Time"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Date_lb As Label
    Friend WithEvents DateAndTimes_lv As ListView
    Friend WithEvents Menu_btn As Button
    Friend WithEvents AddNewDate_btn As Button
    Friend WithEvents Heading_lb As Label
    Friend WithEvents Time_lb As Label
    Friend WithEvents FacilityID_lb As Label
    Friend WithEvents ID_lb As Label
    Friend WithEvents Calendar As DateTimePicker
    Friend WithEvents Times_cb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ParticipationID_txtb As TextBox
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Back_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Other_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Spaces_txtb As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
