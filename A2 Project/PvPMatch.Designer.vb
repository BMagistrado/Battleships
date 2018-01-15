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
        Me.txtbox_playerships = New System.Windows.Forms.TextBox()
        Me.lbl_Playerships = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
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
        Me.Btn_P1Enter.Location = New System.Drawing.Point(16, 110)
        Me.Btn_P1Enter.Name = "Btn_P1Enter"
        Me.Btn_P1Enter.Size = New System.Drawing.Size(148, 29)
        Me.Btn_P1Enter.TabIndex = 3
        Me.Btn_P1Enter.Text = "Enter"
        Me.Btn_P1Enter.UseVisualStyleBackColor = False
        '
        'txtbox_playerships
        '
        Me.txtbox_playerships.Location = New System.Drawing.Point(358, 71)
        Me.txtbox_playerships.Name = "txtbox_playerships"
        Me.txtbox_playerships.Size = New System.Drawing.Size(270, 20)
        Me.txtbox_playerships.TabIndex = 4
        Me.txtbox_playerships.Visible = False
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(348, 414)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(234, 116)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'PvPMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Battleship_Background__6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 561)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lbl_Playerships)
        Me.Controls.Add(Me.txtbox_playerships)
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
    Friend WithEvents txtbox_playerships As TextBox
    Friend WithEvents lbl_Playerships As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
