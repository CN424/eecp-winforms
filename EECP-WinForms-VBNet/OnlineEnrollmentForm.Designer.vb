<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlineEnrollmentForm
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
        Button1 = New Button()
        Label10 = New Label()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(243, 387)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 45)
        Button1.TabIndex = 55
        Button1.Text = "Enroll"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(434, 302)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 17)
        Label10.TabIndex = 54
        Label10.Text = "Year Level:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(434, 322)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(164, 23)
        ComboBox2.TabIndex = 53
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(139, 302)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 17)
        Label9.TabIndex = 52
        Label9.Text = "Course/Strand:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(139, 322)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(164, 23)
        ComboBox1.TabIndex = 51
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(518, 232)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(171, 23)
        TextBox6.TabIndex = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(518, 212)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 17)
        Label8.TabIndex = 49
        Label8.Text = "City:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(279, 232)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(171, 23)
        TextBox5.TabIndex = 48
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(279, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 17)
        Label7.TabIndex = 47
        Label7.Text = "Barangay:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(28, 232)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(171, 23)
        TextBox4.TabIndex = 46
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(28, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 17)
        Label6.TabIndex = 45
        Label6.Text = "Contact Number:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(518, 145)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(171, 23)
        TextBox3.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(518, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 17)
        Label5.TabIndex = 43
        Label5.Text = "Last Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(279, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(171, 23)
        TextBox2.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(279, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 17)
        Label3.TabIndex = 41
        Label3.Text = "Middle Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 145)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(171, 23)
        TextBox1.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(28, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 39
        Label4.Text = "First Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(257, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 28)
        Label1.TabIndex = 37
        Label1.Text = "Online Enrollment"
        ' 
        ' OnlineEnrollmentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Button1)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(Label9)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(Label8)
        Controls.Add(TextBox5)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "OnlineEnrollmentForm"
        Size = New Size(723, 463)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
