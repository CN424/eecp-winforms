Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                  "Exit Application",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question)
        ' Check the user's choice
        If result = DialogResult.Yes Then
            Application.Exit() ' Exit the application
        End If
    End Sub
End Class
