<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button7 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        OnlineEnrollmentForm1 = New OnlineEnrollmentForm()
        CoursesForm1 = New CoursesForm()
        GoalAndObjectivesForm1 = New GoalAndObjectivesForm()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1001, 37)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(925, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 17)
        Label3.TabIndex = 11
        Label3.Text = "X"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(232, 500)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(233, 38)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(768, 529)
        Panel3.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 12)
        Label2.TabIndex = 10
        Label2.Text = "M.H. Del Pilar, Pinamalayan, Or. Min."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(78, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(17, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 15)
        Label1.TabIndex = 9
        Label1.Text = "Ema Emits Collge Philippines"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(0, 414)
        Button7.Name = "Button7"
        Button7.Size = New Size(232, 45)
        Button7.TabIndex = 8
        Button7.Text = "Login Admin"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(-2, 325)
        Button6.Name = "Button6"
        Button6.Size = New Size(232, 45)
        Button6.TabIndex = 6
        Button6.Text = "Online Enrollment"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(-2, 237)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 45)
        Button3.TabIndex = 5
        Button3.Text = "Goal and Objectives"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(-2, 281)
        Button4.Name = "Button4"
        Button4.Size = New Size(232, 45)
        Button4.TabIndex = 4
        Button4.Text = "Courses"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(-2, 193)
        Button2.Name = "Button2"
        Button2.Size = New Size(232, 45)
        Button2.TabIndex = 3
        Button2.Text = "Vision and Mission"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(82))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-2, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 45)
        Button1.TabIndex = 2
        Button1.Text = "About"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(190, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(799, 631)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(459, 427)
        Label5.Name = "Label5"
        Label5.Size = New Size(294, 18)
        Label5.TabIndex = 21
        Label5.Text = "M.H. Del Pilar, Pinamalayan, Or. Min."
        ' 
        ' OnlineEnrollmentForm1
        ' 
        OnlineEnrollmentForm1.BackColor = Color.White
        OnlineEnrollmentForm1.Location = New Point(232, 38)
        OnlineEnrollmentForm1.Name = "OnlineEnrollmentForm1"
        OnlineEnrollmentForm1.Size = New Size(723, 463)
        OnlineEnrollmentForm1.TabIndex = 12
        ' 
        ' CoursesForm1
        ' 
        CoursesForm1.BackColor = Color.White
        CoursesForm1.Location = New Point(232, 37)
        CoursesForm1.Name = "CoursesForm1"
        CoursesForm1.Size = New Size(723, 463)
        CoursesForm1.TabIndex = 12
        ' 
        ' GoalAndObjectivesForm1
        ' 
        GoalAndObjectivesForm1.BackColor = Color.White
        GoalAndObjectivesForm1.Location = New Point(232, 37)
        GoalAndObjectivesForm1.Name = "GoalAndObjectivesForm1"
        GoalAndObjectivesForm1.Size = New Size(723, 463)
        GoalAndObjectivesForm1.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(954, 500)
        Controls.Add(GoalAndObjectivesForm1)
        Controls.Add(CoursesForm1)
        Controls.Add(OnlineEnrollmentForm1)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OnlineEnrollmentForm1 As OnlineEnrollmentForm
    Friend WithEvents CoursesForm1 As CoursesForm
    Friend WithEvents GoalAndObjectivesForm1 As GoalAndObjectivesForm
End Class
