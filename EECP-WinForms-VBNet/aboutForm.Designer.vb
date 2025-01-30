<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(aboutForm))
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(26, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(677, 255)
        Label3.TabIndex = 13
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(26, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(398, 17)
        Label4.TabIndex = 14
        Label4.Text = "From EMA to EMITS to EMA EMITS College Philippines"
        ' 
        ' aboutForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "aboutForm"
        Size = New Size(723, 463)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
