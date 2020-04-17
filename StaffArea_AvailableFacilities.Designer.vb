<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffArea_AvailableFacilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffArea_AvailableFacilities))
        Me.Heading_btn = New System.Windows.Forms.Label()
        Me.AddFac_btn = New System.Windows.Forms.Button()
        Me.RemoveFac_btn = New System.Windows.Forms.Button()
        Me.AvailFacilities_lv = New System.Windows.Forms.ListView()
        Me.FacilityID_txtb = New System.Windows.Forms.TextBox()
        Me.Edit_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SignOut_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Heading_btn
        '
        Me.Heading_btn.AutoSize = True
        Me.Heading_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading_btn.Location = New System.Drawing.Point(12, 79)
        Me.Heading_btn.Name = "Heading_btn"
        Me.Heading_btn.Size = New System.Drawing.Size(196, 20)
        Me.Heading_btn.TabIndex = 0
        Me.Heading_btn.Text = "All Available Facilities"
        '
        'AddFac_btn
        '
        Me.AddFac_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFac_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddFac_btn.Image = CType(resources.GetObject("AddFac_btn.Image"), System.Drawing.Image)
        Me.AddFac_btn.Location = New System.Drawing.Point(1296, 428)
        Me.AddFac_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddFac_btn.Name = "AddFac_btn"
        Me.AddFac_btn.Size = New System.Drawing.Size(215, 55)
        Me.AddFac_btn.TabIndex = 2
        Me.AddFac_btn.Text = "Add New Facility"
        Me.AddFac_btn.UseVisualStyleBackColor = True
        '
        'RemoveFac_btn
        '
        Me.RemoveFac_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveFac_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveFac_btn.Image = CType(resources.GetObject("RemoveFac_btn.Image"), System.Drawing.Image)
        Me.RemoveFac_btn.Location = New System.Drawing.Point(26, 628)
        Me.RemoveFac_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveFac_btn.Name = "RemoveFac_btn"
        Me.RemoveFac_btn.Size = New System.Drawing.Size(272, 65)
        Me.RemoveFac_btn.TabIndex = 3
        Me.RemoveFac_btn.Text = "Remove Facility"
        Me.RemoveFac_btn.UseVisualStyleBackColor = True
        '
        'AvailFacilities_lv
        '
        Me.AvailFacilities_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailFacilities_lv.Location = New System.Drawing.Point(13, 103)
        Me.AvailFacilities_lv.Margin = New System.Windows.Forms.Padding(4)
        Me.AvailFacilities_lv.Name = "AvailFacilities_lv"
        Me.AvailFacilities_lv.Size = New System.Drawing.Size(1276, 380)
        Me.AvailFacilities_lv.TabIndex = 5
        Me.AvailFacilities_lv.UseCompatibleStateImageBehavior = False
        '
        'FacilityID_txtb
        '
        Me.FacilityID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_txtb.Location = New System.Drawing.Point(176, 562)
        Me.FacilityID_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FacilityID_txtb.Name = "FacilityID_txtb"
        Me.FacilityID_txtb.Size = New System.Drawing.Size(305, 27)
        Me.FacilityID_txtb.TabIndex = 7
        '
        'Edit_btn
        '
        Me.Edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Edit_btn.Image = CType(resources.GetObject("Edit_btn.Image"), System.Drawing.Image)
        Me.Edit_btn.Location = New System.Drawing.Point(330, 628)
        Me.Edit_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_btn.Name = "Edit_btn"
        Me.Edit_btn.Size = New System.Drawing.Size(272, 65)
        Me.Edit_btn.TabIndex = 8
        Me.Edit_btn.Text = "Edit"
        Me.Edit_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "To edit facility details or remove facility, please enter the facility ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SignOut_btn
        '
        Me.SignOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SignOut_btn.Image = CType(resources.GetObject("SignOut_btn.Image"), System.Drawing.Image)
        Me.SignOut_btn.Location = New System.Drawing.Point(1394, 12)
        Me.SignOut_btn.Name = "SignOut_btn"
        Me.SignOut_btn.Size = New System.Drawing.Size(117, 34)
        Me.SignOut_btn.TabIndex = 10
        Me.SignOut_btn.Text = "Sign Out"
        Me.SignOut_btn.UseVisualStyleBackColor = True
        '
        'StaffArea_AvailableFacilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1523, 704)
        Me.Controls.Add(Me.SignOut_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Edit_btn)
        Me.Controls.Add(Me.FacilityID_txtb)
        Me.Controls.Add(Me.RemoveFac_btn)
        Me.Controls.Add(Me.AddFac_btn)
        Me.Controls.Add(Me.Heading_btn)
        Me.Controls.Add(Me.AvailFacilities_lv)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StaffArea_AvailableFacilities"
        Me.Text = "StaffArea_AvailableFacilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Heading_btn As Label
    Friend WithEvents AddFac_btn As Button
    Friend WithEvents RemoveFac_btn As Button
    Friend WithEvents AvailFacilities_lv As ListView
    Friend WithEvents FacilityID_txtb As TextBox
    Friend WithEvents Edit_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SignOut_btn As Button
End Class
