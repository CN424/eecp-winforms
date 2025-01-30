<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoursesForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(91, 317)
        Label7.Name = "Label7"
        Label7.Size = New Size(429, 18)
        Label7.TabIndex = 31
        Label7.Text = "Bachelor of Science in Elementary Education (BEED)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(91, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(401, 18)
        Label5.TabIndex = 30
        Label5.Text = "Bachelor of Science in Computer Science (BSCS)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(91, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 75)
        Label6.TabIndex = 29
        Label6.Text = "-Major in English" & vbCrLf & "-Major in Filipino" & vbCrLf & "-Major in Mathematics" & vbCrLf & "-Major in Science" & vbCrLf & "-Major in Social Studies"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(91, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(447, 18)
        Label4.TabIndex = 28
        Label4.Text = "Bachelor of Science in Business Administration (BSBA)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(91, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 30)
        Label3.TabIndex = 27
        Label3.Text = "-Major in Financial Management" & vbCrLf & "-Major in Marketing Management"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(91, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(425, 18)
        Label9.TabIndex = 33
        Label9.Text = "Bachelor of Science in Secondary Education (BSED)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(91, 352)
        Label8.Name = "Label8"
        Label8.Size = New Size(544, 18)
        Label8.TabIndex = 35
        Label8.Text = "Bachelor of Science in Hotel and Restaurant Management (BSHRM)"
        ' 
        ' CoursesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "CoursesForm"
        Size = New Size(723, 463)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
