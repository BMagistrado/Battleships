<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvE_Menu
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
        Me.lbl_PvEMode = New System.Windows.Forms.Label()
        Me.lbl_PvEDesc = New System.Windows.Forms.Label()
        Me.btn_Easy = New System.Windows.Forms.Button()
        Me.btn_Intermediate = New System.Windows.Forms.Button()
        Me.btn_advanced = New System.Windows.Forms.Button()
        Me.btn_MainMenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_PvEMode
        '
        Me.lbl_PvEMode.AutoSize = True
        Me.lbl_PvEMode.BackColor = System.Drawing.Color.Black
        Me.lbl_PvEMode.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvEMode.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PvEMode.Location = New System.Drawing.Point(53, 44)
        Me.lbl_PvEMode.Name = "lbl_PvEMode"
        Me.lbl_PvEMode.Size = New System.Drawing.Size(697, 75)
        Me.lbl_PvEMode.TabIndex = 0
        Me.lbl_PvEMode.Text = "Welcome to PvE Mode"
        '
        'lbl_PvEDesc
        '
        Me.lbl_PvEDesc.AutoSize = True
        Me.lbl_PvEDesc.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_PvEDesc.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvEDesc.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PvEDesc.Location = New System.Drawing.Point(82, 151)
        Me.lbl_PvEDesc.Name = "lbl_PvEDesc"
        Me.lbl_PvEDesc.Size = New System.Drawing.Size(636, 112)
        Me.lbl_PvEDesc.TabIndex = 1
        Me.lbl_PvEDesc.Text = "It is recommended that users who have little to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no experience with battleships " &
    "to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "play against the Easy AI while the hardened " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "veterans can put the advanced" &
    " AI to the test!"
        '
        'btn_Easy
        '
        Me.btn_Easy.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Easy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Easy.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Easy.ForeColor = System.Drawing.Color.Lime
        Me.btn_Easy.Location = New System.Drawing.Point(50, 302)
        Me.btn_Easy.Name = "btn_Easy"
        Me.btn_Easy.Size = New System.Drawing.Size(167, 79)
        Me.btn_Easy.TabIndex = 2
        Me.btn_Easy.Text = "Easy"
        Me.btn_Easy.UseVisualStyleBackColor = False
        '
        'btn_Intermediate
        '
        Me.btn_Intermediate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Intermediate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Intermediate.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Intermediate.ForeColor = System.Drawing.Color.Gold
        Me.btn_Intermediate.Location = New System.Drawing.Point(323, 302)
        Me.btn_Intermediate.Name = "btn_Intermediate"
        Me.btn_Intermediate.Size = New System.Drawing.Size(167, 79)
        Me.btn_Intermediate.TabIndex = 3
        Me.btn_Intermediate.Text = "Intermediate"
        Me.btn_Intermediate.UseVisualStyleBackColor = False
        '
        'btn_advanced
        '
        Me.btn_advanced.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_advanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_advanced.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_advanced.ForeColor = System.Drawing.Color.Red
        Me.btn_advanced.Location = New System.Drawing.Point(583, 302)
        Me.btn_advanced.Name = "btn_advanced"
        Me.btn_advanced.Size = New System.Drawing.Size(167, 79)
        Me.btn_advanced.TabIndex = 4
        Me.btn_advanced.Text = "Advanced"
        Me.btn_advanced.UseVisualStyleBackColor = False
        '
        'btn_MainMenu
        '
        Me.btn_MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_MainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MainMenu.ForeColor = System.Drawing.Color.SkyBlue
        Me.btn_MainMenu.Location = New System.Drawing.Point(182, 462)
        Me.btn_MainMenu.Name = "btn_MainMenu"
        Me.btn_MainMenu.Size = New System.Drawing.Size(179, 47)
        Me.btn_MainMenu.TabIndex = 5
        Me.btn_MainMenu.Text = "Main Menu"
        Me.btn_MainMenu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(450, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 47)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PvE_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Project_Background__5_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 560)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_MainMenu)
        Me.Controls.Add(Me.btn_advanced)
        Me.Controls.Add(Me.btn_Intermediate)
        Me.Controls.Add(Me.btn_Easy)
        Me.Controls.Add(Me.lbl_PvEDesc)
        Me.Controls.Add(Me.lbl_PvEMode)
        Me.Name = "PvE_Menu"
        Me.Text = "PvE_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_PvEMode As Label
    Friend WithEvents lbl_PvEDesc As Label
    Friend WithEvents btn_Easy As Button
    Friend WithEvents btn_Intermediate As Button
    Friend WithEvents btn_advanced As Button
    Friend WithEvents btn_MainMenu As Button
    Friend WithEvents Button1 As Button
End Class
