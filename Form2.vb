Public Class Form2
    ' Declare variables here so ALL buttons/subs can see them
    Dim enam As String
    Dim dep As String
    Dim sal As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can initialize things here if needed, but leave the "Dim" lines above
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' For Strings, do NOT use Val(). Just use .Text
        enam = TextBox1.Text
        dep = TextBox2.Text

        ' For numbers, Val() is fine
        sal = Val(TextBox3.Text)

        MessageBox.Show("ADDED " & "EMPLOY NAME" & enam & "EMPLOY  DEPARTMENT " & dep & "EMPLOY SALARY")
    End Sub
End Class

