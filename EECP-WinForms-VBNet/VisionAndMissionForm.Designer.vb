<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisionAndMissionForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(VisionAndMissionForm))
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(60, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 18)
        Label4.TabIndex = 19
        Label4.Text = "Vision"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(60, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(606, 45)
        Label3.TabIndex = 18
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(326, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(253, 24)
        Label2.TabIndex = 17
        Label2.Text = "M.H. Del Pilar, Pinamalayan, Oriental Mindoro" & vbCrLf & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(326, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 17)
        Label1.TabIndex = 16
        Label1.Text = "Ema Emits Collge Philippines"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(202, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(60, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 18)
        Label5.TabIndex = 21
        Label5.Text = "Mission"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(60, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(641, 120)
        Label6.TabIndex = 20
        Label6.Text = resources.GetString("Label6.Text")
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(60, 444)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 18)
        Label7.TabIndex = 22
        Label7.Text = "Core Values"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(60, 471)
        Label8.Name = "Label8"
        Label8.Size = New Size(658, 15)
        Label8.TabIndex = 23
        Label8.Text = "EMA EMITS COLLEGE PHILIPPINES is guided by its core values which are LOVE, FAITH, and JUSTICE." & vbCrLf
        ' 
        ' VisionAndMissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "VisionAndMissionForm"
        Size = New Size(770, 531)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
