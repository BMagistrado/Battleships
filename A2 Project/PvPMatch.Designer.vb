<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PvPMatch
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
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.txtbox_Username = New System.Windows.Forms.TextBox()
        Me.lbl_P1Username = New System.Windows.Forms.Label()
        Me.Btn_P1Enter = New System.Windows.Forms.Button()
        Me.txtbox_playershipx = New System.Windows.Forms.TextBox()
        Me.lbl_Playerships = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_playershipy = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Start
        '
        Me.Btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Start.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Start.ForeColor = System.Drawing.Color.LimeGreen
        Me.Btn_Start.Location = New System.Drawing.Point(358, 157)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(171, 51)
        Me.Btn_Start.TabIndex = 0
        Me.Btn_Start.Text = "Start"
        Me.Btn_Start.UseVisualStyleBackColor = False
        '
        'txtbox_Username
        '
        Me.txtbox_Username.Location = New System.Drawing.Point(326, 12)
        Me.txtbox_Username.Name = "txtbox_Username"
        Me.txtbox_Username.Size = New System.Drawing.Size(142, 20)
        Me.txtbox_Username.TabIndex = 1
        '
        'lbl_P1Username
        '
        Me.lbl_P1Username.AutoSize = True
        Me.lbl_P1Username.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_P1Username.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_P1Username.ForeColor = System.Drawing.Color.Red
        Me.lbl_P1Username.Location = New System.Drawing.Point(12, 9)
        Me.lbl_P1Username.Name = "lbl_P1Username"
        Me.lbl_P1Username.Size = New System.Drawing.Size(298, 24)
        Me.lbl_P1Username.TabIndex = 2
        Me.lbl_P1Username.Text = "Enter Player 1 Username:"
        '
        'Btn_P1Enter
        '
        Me.Btn_P1Enter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_P1Enter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_P1Enter.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_P1Enter.ForeColor = System.Drawing.Color.Red
        Me.Btn_P1Enter.Location = New System.Drawing.Point(478, 426)
        Me.Btn_P1Enter.Name = "Btn_P1Enter"
        Me.Btn_P1Enter.Size = New System.Drawing.Size(148, 29)
        Me.Btn_P1Enter.TabIndex = 3
        Me.Btn_P1Enter.Text = "Enter"
        Me.Btn_P1Enter.UseVisualStyleBackColor = False
        '
        'txtbox_playershipx
        '
        Me.txtbox_playershipx.Location = New System.Drawing.Point(358, 432)
        Me.txtbox_playershipx.Name = "txtbox_playershipx"
        Me.txtbox_playershipx.Size = New System.Drawing.Size(27, 20)
        Me.txtbox_playershipx.TabIndex = 4
        '
        'lbl_Playerships
        '
        Me.lbl_Playerships.AutoSize = True
        Me.lbl_Playerships.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Playerships.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Playerships.ForeColor = System.Drawing.Color.Red
        Me.lbl_Playerships.Location = New System.Drawing.Point(8, 53)
        Me.lbl_Playerships.Name = "lbl_Playerships"
        Me.lbl_Playerships.Size = New System.Drawing.Size(333, 38)
        Me.lbl_Playerships.TabIndex = 5
        Me.lbl_Playerships.Text = "Enter the coordinates for your ships" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "one at a time:"
        Me.lbl_Playerships.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 455)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "x:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 455)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "y:"
        '
        'txtbox_playershipy
        '
        Me.txtbox_playershipy.Location = New System.Drawing.Point(417, 432)
        Me.txtbox_playershipy.Name = "txtbox_playershipy"
        Me.txtbox_playershipy.Size = New System.Drawing.Size(27, 20)
        Me.txtbox_playershipy.TabIndex = 8
        '
        'PvPMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Battleship_Background__6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 561)
        Me.Controls.Add(Me.txtbox_playershipy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Playerships)
        Me.Controls.Add(Me.txtbox_playershipx)
        Me.Controls.Add(Me.Btn_P1Enter)
        Me.Controls.Add(Me.lbl_P1Username)
        Me.Controls.Add(Me.txtbox_Username)
        Me.Controls.Add(Me.Btn_Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PvPMatch"
        Me.Text = "PvPMatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Start As Button
    Friend WithEvents txtbox_Username As TextBox
    Friend WithEvents lbl_P1Username As Label
    Friend WithEvents Btn_P1Enter As Button
    Friend WithEvents txtbox_playershipx As TextBox
    Friend WithEvents lbl_Playerships As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_playershipy As TextBox
End Class
