<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvPMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PvPMenu))
        Me.lbl_PvPMode = New System.Windows.Forms.Label()
        Me.lbl_PvPDesc = New System.Windows.Forms.Label()
        Me.btn_Classic = New System.Windows.Forms.Button()
        Me.btn_Turbo = New System.Windows.Forms.Button()
        Me.btn_MainMenu = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_PvPMode
        '
        Me.lbl_PvPMode.AutoSize = True
        Me.lbl_PvPMode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_PvPMode.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvPMode.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PvPMode.Location = New System.Drawing.Point(48, 45)
        Me.lbl_PvPMode.Name = "lbl_PvPMode"
        Me.lbl_PvPMode.Size = New System.Drawing.Size(697, 75)
        Me.lbl_PvPMode.TabIndex = 0
        Me.lbl_PvPMode.Text = "Welcome to PvP Mode"
        '
        'lbl_PvPDesc
        '
        Me.lbl_PvPDesc.AutoSize = True
        Me.lbl_PvPDesc.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_PvPDesc.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PvPDesc.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PvPDesc.Location = New System.Drawing.Point(27, 132)
        Me.lbl_PvPDesc.Name = "lbl_PvPDesc"
        Me.lbl_PvPDesc.Size = New System.Drawing.Size(736, 144)
        Me.lbl_PvPDesc.TabIndex = 1
        Me.lbl_PvPDesc.Text = resources.GetString("lbl_PvPDesc.Text")
        '
        'btn_Classic
        '
        Me.btn_Classic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Classic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Classic.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Classic.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_Classic.Location = New System.Drawing.Point(136, 330)
        Me.btn_Classic.Name = "btn_Classic"
        Me.btn_Classic.Size = New System.Drawing.Size(191, 71)
        Me.btn_Classic.TabIndex = 2
        Me.btn_Classic.Text = "Classic Mode"
        Me.btn_Classic.UseVisualStyleBackColor = False
        '
        'btn_Turbo
        '
        Me.btn_Turbo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Turbo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Turbo.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Turbo.ForeColor = System.Drawing.Color.Red
        Me.btn_Turbo.Location = New System.Drawing.Point(464, 330)
        Me.btn_Turbo.Name = "btn_Turbo"
        Me.btn_Turbo.Size = New System.Drawing.Size(191, 71)
        Me.btn_Turbo.TabIndex = 3
        Me.btn_Turbo.Text = "Turbo Mode"
        Me.btn_Turbo.UseVisualStyleBackColor = False
        '
        'btn_MainMenu
        '
        Me.btn_MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_MainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MainMenu.ForeColor = System.Drawing.Color.SkyBlue
        Me.btn_MainMenu.Location = New System.Drawing.Point(202, 471)
        Me.btn_MainMenu.Name = "btn_MainMenu"
        Me.btn_MainMenu.Size = New System.Drawing.Size(125, 43)
        Me.btn_MainMenu.TabIndex = 4
        Me.btn_MainMenu.Text = "Main Menu"
        Me.btn_MainMenu.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Red
        Me.btn_Exit.Location = New System.Drawing.Point(464, 471)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(125, 43)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'PvPMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Battleship_Background__4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 550)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_MainMenu)
        Me.Controls.Add(Me.btn_Turbo)
        Me.Controls.Add(Me.btn_Classic)
        Me.Controls.Add(Me.lbl_PvPDesc)
        Me.Controls.Add(Me.lbl_PvPMode)
        Me.Name = "PvPMenu"
        Me.Text = "PvPMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_PvPMode As Label
    Friend WithEvents lbl_PvPDesc As Label
    Friend WithEvents btn_Classic As Button
    Friend WithEvents btn_Turbo As Button
    Friend WithEvents btn_MainMenu As Button
    Friend WithEvents btn_Exit As Button
End Class
