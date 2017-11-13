<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvPMatch
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
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.txtbox_Username = New System.Windows.Forms.TextBox()
        Me.lbl_P1Username = New System.Windows.Forms.Label()
        Me.btn_P1Enter = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Start.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_Start.Location = New System.Drawing.Point(374, 518)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(171, 51)
        Me.btn_Start.TabIndex = 0
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = False
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
        'btn_P1Enter
        '
        Me.btn_P1Enter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_P1Enter.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_P1Enter.ForeColor = System.Drawing.Color.Red
        Me.btn_P1Enter.Location = New System.Drawing.Point(16, 98)
        Me.btn_P1Enter.Name = "btn_P1Enter"
        Me.btn_P1Enter.Size = New System.Drawing.Size(148, 29)
        Me.btn_P1Enter.TabIndex = 3
        Me.btn_P1Enter.Text = "Enter"
        Me.btn_P1Enter.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(326, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 20)
        Me.TextBox1.TabIndex = 4
        '
        'PvPMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Battleship_Background__6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 614)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_P1Enter)
        Me.Controls.Add(Me.lbl_P1Username)
        Me.Controls.Add(Me.txtbox_Username)
        Me.Controls.Add(Me.btn_Start)
        Me.Name = "PvPMatch"
        Me.Text = "PvPMatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Start As Button
    Friend WithEvents txtbox_Username As TextBox
    Friend WithEvents lbl_P1Username As Label
    Friend WithEvents btn_P1Enter As Button
    Friend WithEvents TextBox1 As TextBox
End Class
