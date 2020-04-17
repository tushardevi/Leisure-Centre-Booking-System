<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_BookFacility
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
        Me.FacilityID_txtb = New System.Windows.Forms.TextBox()
        Me.Next_btn = New System.Windows.Forms.Button()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.AllFacilities_lv = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'SubHeader_lbl
        '
        Me.SubHeader_lbl.AutoSize = True
        Me.SubHeader_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubHeader_lbl.Location = New System.Drawing.Point(42, 65)
        Me.SubHeader_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubHeader_lbl.Name = "SubHeader_lbl"
        Me.SubHeader_lbl.Size = New System.Drawing.Size(189, 20)
        Me.SubHeader_lbl.TabIndex = 1
        Me.SubHeader_lbl.Text = "All available facilities"
        '
        'Message_lbl
        '
        Me.Message_lbl.AutoSize = True
        Me.Message_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message_lbl.Location = New System.Drawing.Point(457, 474)
        Me.Message_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Message_lbl.Name = "Message_lbl"
        Me.Message_lbl.Size = New System.Drawing.Size(564, 20)
        Me.Message_lbl.TabIndex = 2
        Me.Message_lbl.Text = "Type the ""Facility ID"" number in the box below to book that facility"
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_lbl.Location = New System.Drawing.Point(533, 526)
        Me.FacilityID_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(95, 20)
        Me.FacilityID_lbl.TabIndex = 3
        Me.FacilityID_lbl.Text = "Facility ID"
        '
        'FacilityID_txtb
        '
        Me.FacilityID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityID_txtb.Location = New System.Drawing.Point(633, 523)
        Me.FacilityID_txtb.Margin = New System.Windows.Forms.Padding(4)
        Me.FacilityID_txtb.Name = "FacilityID_txtb"
        Me.FacilityID_txtb.Size = New System.Drawing.Size(132, 27)
        Me.FacilityID_txtb.TabIndex = 4
        '
        'Next_btn
        '
        Me.Next_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Next_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Next_btn.Location = New System.Drawing.Point(797, 520)
        Me.Next_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Next_btn.Name = "Next_btn"
        Me.Next_btn.Size = New System.Drawing.Size(113, 36)
        Me.Next_btn.TabIndex = 5
        Me.Next_btn.Text = "Next"
        Me.Next_btn.UseVisualStyleBackColor = True
        '
        'Menu_btn
        '
        Me.Menu_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Menu_btn.Image = Global.TotalFitness.My.Resources.Resources.backgrounds_blank_blue_953214
        Me.Menu_btn.Location = New System.Drawing.Point(1404, 13)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(102, 32)
        Me.Menu_btn.TabIndex = 6
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'AllFacilities_lv
        '
        Me.AllFacilities_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllFacilities_lv.Location = New System.Drawing.Point(45, 85)
        Me.AllFacilities_lv.Name = "AllFacilities_lv"
        Me.AllFacilities_lv.Size = New System.Drawing.Size(1431, 377)
        Me.AllFacilities_lv.TabIndex = 7
        Me.AllFacilities_lv.UseCompatibleStateImageBehavior = False
        '
        'Member_BookFacility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 569)
        Me.Controls.Add(Me.AllFacilities_lv)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.Next_btn)
        Me.Controls.Add(Me.FacilityID_txtb)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Controls.Add(Me.Message_lbl)
        Me.Controls.Add(Me.SubHeader_lbl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Member_BookFacility"
        Me.Text = "Member_BookFacility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubHeader_lbl As Label
    Friend WithEvents Message_lbl As Label
    Friend WithEvents FacilityID_lbl As Label
    Friend WithEvents FacilityID_txtb As TextBox
    Friend WithEvents Next_btn As Button
    Friend WithEvents Menu_btn As Button
    Friend WithEvents AllFacilities_lv As ListView
End Class
