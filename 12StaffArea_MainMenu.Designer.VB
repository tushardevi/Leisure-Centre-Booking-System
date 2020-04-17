<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffArea_MainMenu
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
        Me.ActiveAcc_btn = New System.Windows.Forms.Button()
        Me.MemberDet_btn = New System.Windows.Forms.Button()
        Me.Facilities_btn = New System.Windows.Forms.Button()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ActiveAcc_btn
        '
        Me.ActiveAcc_btn.Location = New System.Drawing.Point(131, 56)
        Me.ActiveAcc_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ActiveAcc_btn.Name = "ActiveAcc_btn"
        Me.ActiveAcc_btn.Size = New System.Drawing.Size(124, 72)
        Me.ActiveAcc_btn.TabIndex = 0
        Me.ActiveAcc_btn.Text = "Activate Account"
        Me.ActiveAcc_btn.UseVisualStyleBackColor = True
        '
        'MemberDet_btn
        '
        Me.MemberDet_btn.Location = New System.Drawing.Point(131, 153)
        Me.MemberDet_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MemberDet_btn.Name = "MemberDet_btn"
        Me.MemberDet_btn.Size = New System.Drawing.Size(124, 74)
        Me.MemberDet_btn.TabIndex = 1
        Me.MemberDet_btn.Text = "Member Details"
        Me.MemberDet_btn.UseVisualStyleBackColor = True
        '
        'Facilities_btn
        '
        Me.Facilities_btn.Location = New System.Drawing.Point(131, 267)
        Me.Facilities_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Facilities_btn.Name = "Facilities_btn"
        Me.Facilities_btn.Size = New System.Drawing.Size(124, 73)
        Me.Facilities_btn.TabIndex = 2
        Me.Facilities_btn.Text = "Facilities"
        Me.Facilities_btn.UseVisualStyleBackColor = True
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(345, 10)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(56, 23)
        Me.Menu_btn.TabIndex = 3
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'StaffArea_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 399)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.Facilities_btn)
        Me.Controls.Add(Me.MemberDet_btn)
        Me.Controls.Add(Me.ActiveAcc_btn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "StaffArea_MainMenu"
        Me.Text = "StaffArea_MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActiveAcc_btn As Button
    Friend WithEvents MemberDet_btn As Button
    Friend WithEvents Facilities_btn As Button
    Friend WithEvents Menu_btn As Button
End Class
