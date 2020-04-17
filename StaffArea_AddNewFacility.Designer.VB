<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffArea_AddNewFacility
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
        Me.FacilityID_lbl = New System.Windows.Forms.Label()
        Me.Name_lbl = New System.Windows.Forms.Label()
        Me.ClassNo_lbl = New System.Windows.Forms.Label()
        Me.StaffID_lbl = New System.Windows.Forms.Label()
        Me.Name_txtb = New System.Windows.Forms.TextBox()
        Me.ClassNo_txtb = New System.Windows.Forms.TextBox()
        Me.FacilityID_txtb = New System.Windows.Forms.TextBox()
        Me.StaffID_txtb = New System.Windows.Forms.TextBox()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.AvaiPlaces_lbl = New System.Windows.Forms.Label()
        Me.AvaiSpaces_txtb = New System.Windows.Forms.TextBox()
        Me.Date_lbl = New System.Windows.Forms.Label()
        Me.Time_lbl = New System.Windows.Forms.Label()
        Me.Date_txtb = New System.Windows.Forms.DateTimePicker()
        Me.Times_cb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_lbl.Location = New System.Drawing.Point(132, 62)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(89, 20)
        Me.FacilityID_lbl.TabIndex = 0
        Me.FacilityID_lbl.Text = "FacilityID"
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_lbl.Location = New System.Drawing.Point(132, 103)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(57, 20)
        Me.Name_lbl.TabIndex = 1
        Me.Name_lbl.Text = "Name"
        '
        'ClassNo_lbl
        '
        Me.ClassNo_lbl.AutoSize = True
        Me.ClassNo_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassNo_lbl.Location = New System.Drawing.Point(132, 146)
        Me.ClassNo_lbl.Name = "ClassNo_lbl"
        Me.ClassNo_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClassNo_lbl.Size = New System.Drawing.Size(128, 20)
        Me.ClassNo_lbl.TabIndex = 2
        Me.ClassNo_lbl.Text = "Class Number"
        '
        'StaffID_lbl
        '
        Me.StaffID_lbl.AutoSize = True
        Me.StaffID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffID_lbl.Location = New System.Drawing.Point(132, 234)
        Me.StaffID_lbl.Name = "StaffID_lbl"
        Me.StaffID_lbl.Size = New System.Drawing.Size(68, 20)
        Me.StaffID_lbl.TabIndex = 6
        Me.StaffID_lbl.Text = "StaffID"
        '
        'Name_txtb
        '
        Me.Name_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_txtb.Location = New System.Drawing.Point(300, 103)
        Me.Name_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name_txtb.Name = "Name_txtb"
        Me.Name_txtb.Size = New System.Drawing.Size(200, 27)
        Me.Name_txtb.TabIndex = 7
        '
        'ClassNo_txtb
        '
        Me.ClassNo_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassNo_txtb.Location = New System.Drawing.Point(300, 142)
        Me.ClassNo_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClassNo_txtb.Name = "ClassNo_txtb"
        Me.ClassNo_txtb.Size = New System.Drawing.Size(200, 27)
        Me.ClassNo_txtb.TabIndex = 8
        '
        'FacilityID_txtb
        '
        Me.FacilityID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_txtb.Location = New System.Drawing.Point(300, 58)
        Me.FacilityID_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FacilityID_txtb.Name = "FacilityID_txtb"
        Me.FacilityID_txtb.Size = New System.Drawing.Size(200, 27)
        Me.FacilityID_txtb.TabIndex = 9
        '
        'StaffID_txtb
        '
        Me.StaffID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffID_txtb.Location = New System.Drawing.Point(300, 231)
        Me.StaffID_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StaffID_txtb.Name = "StaffID_txtb"
        Me.StaffID_txtb.Size = New System.Drawing.Size(200, 27)
        Me.StaffID_txtb.TabIndex = 13
        '
        'Add_btn
        '
        Me.Add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Add_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Add_btn.Location = New System.Drawing.Point(300, 380)
        Me.Add_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(148, 57)
        Me.Add_btn.TabIndex = 15
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Back_btn
        '
        Me.Back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Back_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Back_btn.Location = New System.Drawing.Point(12, 12)
        Me.Back_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(91, 33)
        Me.Back_btn.TabIndex = 16
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'AvaiPlaces_lbl
        '
        Me.AvaiPlaces_lbl.AutoSize = True
        Me.AvaiPlaces_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvaiPlaces_lbl.Location = New System.Drawing.Point(132, 186)
        Me.AvaiPlaces_lbl.Name = "AvaiPlaces_lbl"
        Me.AvaiPlaces_lbl.Size = New System.Drawing.Size(148, 20)
        Me.AvaiPlaces_lbl.TabIndex = 3
        Me.AvaiPlaces_lbl.Text = "Available Places"
        '
        'AvaiSpaces_txtb
        '
        Me.AvaiSpaces_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvaiSpaces_txtb.Location = New System.Drawing.Point(300, 186)
        Me.AvaiSpaces_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvaiSpaces_txtb.Name = "AvaiSpaces_txtb"
        Me.AvaiSpaces_txtb.Size = New System.Drawing.Size(200, 27)
        Me.AvaiSpaces_txtb.TabIndex = 11
        '
        'Date_lbl
        '
        Me.Date_lbl.AutoSize = True
        Me.Date_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_lbl.Location = New System.Drawing.Point(132, 276)
        Me.Date_lbl.Name = "Date_lbl"
        Me.Date_lbl.Size = New System.Drawing.Size(49, 20)
        Me.Date_lbl.TabIndex = 17
        Me.Date_lbl.Text = "Date"
        '
        'Time_lbl
        '
        Me.Time_lbl.AutoSize = True
        Me.Time_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_lbl.Location = New System.Drawing.Point(135, 319)
        Me.Time_lbl.Name = "Time_lbl"
        Me.Time_lbl.Size = New System.Drawing.Size(56, 20)
        Me.Time_lbl.TabIndex = 18
        Me.Time_lbl.Text = "Time "
        '
        'Date_txtb
        '
        Me.Date_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_txtb.Location = New System.Drawing.Point(300, 271)
        Me.Date_txtb.Name = "Date_txtb"
        Me.Date_txtb.Size = New System.Drawing.Size(200, 27)
        Me.Date_txtb.TabIndex = 21
        '
        'Times_cb
        '
        Me.Times_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Times_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Times_cb.FormattingEnabled = True
        Me.Times_cb.Location = New System.Drawing.Point(300, 319)
        Me.Times_cb.Name = "Times_cb"
        Me.Times_cb.Size = New System.Drawing.Size(200, 28)
        Me.Times_cb.TabIndex = 24
        '
        'StaffArea_AddNewFacility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 457)
        Me.Controls.Add(Me.Times_cb)
        Me.Controls.Add(Me.Date_txtb)
        Me.Controls.Add(Me.Time_lbl)
        Me.Controls.Add(Me.Date_lbl)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.StaffID_txtb)
        Me.Controls.Add(Me.AvaiSpaces_txtb)
        Me.Controls.Add(Me.FacilityID_txtb)
        Me.Controls.Add(Me.ClassNo_txtb)
        Me.Controls.Add(Me.Name_txtb)
        Me.Controls.Add(Me.StaffID_lbl)
        Me.Controls.Add(Me.AvaiPlaces_lbl)
        Me.Controls.Add(Me.ClassNo_lbl)
        Me.Controls.Add(Me.Name_lbl)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StaffArea_AddNewFacility"
        Me.Text = "_16StaffArea_FacilitiesBtn_AddNewFacilityBtn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacilityID_lbl As Label
    Friend WithEvents Name_lbl As Label
    Friend WithEvents ClassNo_lbl As Label
    Friend WithEvents StaffID_lbl As Label
    Friend WithEvents Name_txtb As TextBox
    Friend WithEvents ClassNo_txtb As TextBox
    Friend WithEvents FacilityID_txtb As TextBox
    Friend WithEvents StaffID_txtb As TextBox
    Friend WithEvents Add_btn As Button
    Friend WithEvents Back_btn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AvaiPlaces_lbl As Label
    Friend WithEvents AvaiSpaces_txtb As TextBox
    Friend WithEvents Date_lbl As Label
    Friend WithEvents Time_lbl As Label
    Friend WithEvents Date_txtb As DateTimePicker
    Friend WithEvents Times_cb As ComboBox
End Class
