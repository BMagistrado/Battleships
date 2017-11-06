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
        Me.SuspendLayout()
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Start.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_Start.Location = New System.Drawing.Point(148, 149)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(171, 51)
        Me.btn_Start.TabIndex = 0
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'PvPMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A2_Project.My.Resources.Resources.Battleship_Background__6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 614)
        Me.Controls.Add(Me.btn_Start)
        Me.Name = "PvPMatch"
        Me.Text = "PvPMatch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Start As Button
End Class
