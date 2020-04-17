<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _18StaffArea_FacilitiesBtn_RemoveFacilityBtn
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
        Me.FacilityID_lbl = New System.Windows.Forms.Label()
        Me.FacilityID_txtb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FacilityID_lbl
        '
        Me.FacilityID_lbl.AutoSize = True
        Me.FacilityID_lbl.Location = New System.Drawing.Point(48, 115)
        Me.FacilityID_lbl.Name = "FacilityID_lbl"
        Me.FacilityID_lbl.Size = New System.Drawing.Size(64, 17)
        Me.FacilityID_lbl.TabIndex = 0
        Me.FacilityID_lbl.Text = "FacilityID"
        '
        'FacilityID_txtb
        '
        Me.FacilityID_txtb.Location = New System.Drawing.Point(134, 115)
        Me.FacilityID_txtb.Name = "FacilityID_txtb"
        Me.FacilityID_txtb.Size = New System.Drawing.Size(132, 22)
        Me.FacilityID_txtb.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(12, 12)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.Menu_btn.TabIndex = 3
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        '_18StaffArea_FacilitiesBtn_RemoveFacilityBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 313)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FacilityID_txtb)
        Me.Controls.Add(Me.FacilityID_lbl)
        Me.Name = "_18StaffArea_FacilitiesBtn_RemoveFacilityBtn"
        Me.Text = "_17StaffArea_FacilitiesBtn_RemoveFacilityBtn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacilityID_lbl As Label
    Friend WithEvents FacilityID_txtb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Menu_btn As Button
End Class
