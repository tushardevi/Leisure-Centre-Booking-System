<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffArea_FacilitiesBtn
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
        Me.Heading_btn = New System.Windows.Forms.Label()
        Me.AddFac_btn = New System.Windows.Forms.Button()
        Me.RemoveFac_btn = New System.Windows.Forms.Button()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Heading_btn
        '
        Me.Heading_btn.AutoSize = True
        Me.Heading_btn.Location = New System.Drawing.Point(65, 61)
        Me.Heading_btn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Heading_btn.Name = "Heading_btn"
        Me.Heading_btn.Size = New System.Drawing.Size(107, 13)
        Me.Heading_btn.TabIndex = 0
        Me.Heading_btn.Text = "All Available Facilities"
        '
        'AddFac_btn
        '
        Me.AddFac_btn.Location = New System.Drawing.Point(218, 431)
        Me.AddFac_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddFac_btn.Name = "AddFac_btn"
        Me.AddFac_btn.Size = New System.Drawing.Size(170, 87)
        Me.AddFac_btn.TabIndex = 2
        Me.AddFac_btn.Text = "Add New Facility"
        Me.AddFac_btn.UseVisualStyleBackColor = True
        '
        'RemoveFac_btn
        '
        Me.RemoveFac_btn.Location = New System.Drawing.Point(616, 431)
        Me.RemoveFac_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveFac_btn.Name = "RemoveFac_btn"
        Me.RemoveFac_btn.Size = New System.Drawing.Size(178, 87)
        Me.RemoveFac_btn.TabIndex = 3
        Me.RemoveFac_btn.Text = "Remove Facility"
        Me.RemoveFac_btn.UseVisualStyleBackColor = True
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(905, 24)
        Me.Menu_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(56, 19)
        Me.Menu_btn.TabIndex = 4
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(50, 77)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(854, 326)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'StaffArea_FacilitiesBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 549)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.RemoveFac_btn)
        Me.Controls.Add(Me.AddFac_btn)
        Me.Controls.Add(Me.Heading_btn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffArea_FacilitiesBtn"
        Me.Text = "StaffArea_Facilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Heading_btn As Label
    Friend WithEvents AddFac_btn As Button
    Friend WithEvents RemoveFac_btn As Button
    Friend WithEvents Menu_btn As Button
    Friend WithEvents ListView1 As ListView
End Class
