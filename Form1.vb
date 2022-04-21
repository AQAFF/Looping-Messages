Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intAnswer As Integer = DialogResult.No
        Do
            intAnswer = MessageBox.Show("Choose Yes to exit, No to continue", "Do Loop example",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2)


        Loop While (intAnswer = DialogResult.No)
    End Sub
End Class
