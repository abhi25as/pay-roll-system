Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub AddEMPDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEMPDetailsToolStripMenuItem.Click, MyBase.BackgroundImageChanged
        Form2.Show()

    End Sub

    Private Sub UpdateEMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEMPToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
