<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Label1.Location = New Point(413, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(712, 60)
        Label1.TabIndex = 0
        Label1.Text = "PAY ROLL SYSTEM OF EMPLOY"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Button1.Location = New Point(631, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 34)
        Button1.TabIndex = 1
        Button1.Text = "CLICK ON ME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        BackgroundImage = My.Resources.Resources.Screenshot_2026_02_16_171953
        ClientSize = New Size(1448, 583)
        Controls.Add(Button1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ButtonFace
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class
