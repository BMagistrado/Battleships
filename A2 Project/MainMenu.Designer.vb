<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lbl_Battleships = New System.Windows.Forms.Label()
        Me.lbl_MainMenu = New System.Windows.Forms.Label()
        Me.btn_PvE = New System.Windows.Forms.Button()
        Me.lbl_PvEDesc = New System.Windows.Forms.Label()
        Me.btn_PvPMode = New System.Windows.Forms.Button()
        Me.lbl_PvPDesc = New System.Windows.Forms.Label()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Battleships
        '
        Me.lbl_Battleships.AutoSize = True
        Me.lbl_Battleships.BackColor = System.Drawing.Color.Black
        Me.lbl_Battleships.Font = New System.Drawing.Font("Consolas", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Battleships.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Battleships.Location = New System.Drawing.Point(149, 9)
        Me.lbl_Battleships.Name = "lbl_Battleships"
        Me.lbl_Battleships.Size = New System.Drawing.Size(630, 112)
        Me.lbl_Battleships.TabIndex = 0
        Me.lbl_Battleships.Text = "Battleships"
        '
        'lbl_MainMenu
        '
        Me.lbl_MainMenu.AutoSize = True
        Me.lbl_MainMenu.BackColor = System.Drawing.Color.Black
        Me.lbl_MainMenu.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MainMenu.ForeColor = System.Drawing.Color.SkyBlue
        Me.lbl_MainMenu.Location = New System.Drawing.Point(379, 145)
        Me.lbl_MainMenu.Name = "lbl_MainMenu"
        Me.lbl_MainMenu.Size = New System.Drawing.Size(179, 37)
        Me.lbl_MainMenu.TabIndex = 1
        Me.lbl_MainMenu.Text = "Main Menu"
        '
        'btn_PvE
        '
        Me.btn_PvE.BackColor = System.Drawing.Color.Black
        Me.btn_PvE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PvE.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PvE.ForeColor = System.Drawing.Color.Lime
        Me.btn_PvE.Location = New System.Drawing.Point(12, 222)
        Me.btn_PvE.Name = "btn_PvE"
        Me.btn_PvE.Size = New System.Drawing.Size(255, 93)
        Me.btn_PvE.TabIndex = 2
        Me.btn_PvE.Text = "PvE"
        Me.btn_PvE.UseVisualStyleBackColor = False
        '
        'lbl_PvEDesc
        '
        Me.lbl_PvEDesc.AutoSize = True
        Me.lbl_PvEDesc.BackColor = System.Drawing.Color.Black
        Me.lbl_PvEDesc.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvEDesc.ForeColor = System.Drawing.Color.Lime
        Me.lbl_PvEDesc.Location = New System.Drawing.Point(324, 193)
        Me.lbl_PvEDesc.Name = "lbl_PvEDesc"
        Me.lbl_PvEDesc.Size = New System.Drawing.Size(580, 154)
        Me.lbl_PvEDesc.TabIndex = 3
        Me.lbl_PvEDesc.Text = resources.GetString("lbl_PvEDesc.Text")
        '
        'btn_PvPMode
        '
        Me.btn_PvPMode.BackColor = System.Drawing.Color.Black
        Me.btn_PvPMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PvPMode.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PvPMode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btn_PvPMode.Location = New System.Drawing.Point(12, 427)
        Me.btn_PvPMode.Name = "btn_PvPMode"
        Me.btn_PvPMode.Size = New System.Drawing.Size(255, 93)
        Me.btn_PvPMode.TabIndex = 4
        Me.btn_PvPMode.Text = "PvP"
        Me.btn_PvPMode.UseVisualStyleBackColor = False
        '
        'lbl_PvPDesc
        '
        Me.lbl_PvPDesc.AutoSize = True
        Me.lbl_PvPDesc.BackColor = System.Drawing.Color.Black
        Me.lbl_PvPDesc.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvPDesc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_PvPDesc.Location = New System.Drawing.Point(324, 391)
        Me.lbl_PvPDesc.Name = "lbl_PvPDesc"
        Me.lbl_PvPDesc.Size = New System.Drawing.Size(560, 154)
        Me.lbl_PvPDesc.TabIndex = 5
        Me.lbl_PvPDesc.Text = "PvP Mode pits you against another user for same-screen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "offline PvP." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Features i" &
    "nclude:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Turn Based Combat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Randomised Fleet Setups" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Weapons to change the ti" &
    "de of battle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Offline Mode"
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Black
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Red
        Me.btn_Exit.Location = New System.Drawing.Point(12, 561)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(68, 23)
        Me.btn_Exit.TabIndex = 6
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Project_Main_Menu_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 596)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.lbl_PvPDesc)
        Me.Controls.Add(Me.btn_PvPMode)
        Me.Controls.Add(Me.lbl_PvEDesc)
        Me.Controls.Add(Me.btn_PvE)
        Me.Controls.Add(Me.lbl_MainMenu)
        Me.Controls.Add(Me.lbl_Battleships)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Battleships As Label
    Friend WithEvents lbl_MainMenu As Label
    Friend WithEvents btn_PvE As Button
    Friend WithEvents lbl_PvEDesc As Label
    Friend WithEvents btn_PvPMode As Button
    Friend WithEvents lbl_PvPDesc As Label
    Friend WithEvents btn_Exit As Button
End Class
