Public Class Form3

    Dim enam As String
    Dim dep As String
    Dim sal As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        enam = Val(TextBox1.Text)
        dep = Val(TextBox2.Text)


        sal = Val(TextBox3.Text)



        MessageBox.Show("Saved: " & enam & " from " & dep)
    End Sub
End Class