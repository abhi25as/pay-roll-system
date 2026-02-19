<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Label1.Location = New Point(560, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 0
        Label1.Text = "ENTER NAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Label2.Location = New Point(560, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 1
        Label2.Text = "DEPARTMENT:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(737, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(737, 269)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(737, 197)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Label3.Location = New Point(564, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 5
        Label3.Text = "SALARY:"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Button1.Location = New Point(656, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "ADDED"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Image = My.Resources.Resources.Screenshot_2026_02_16_171953
        Label4.Location = New Point(359, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(723, 60)
        Label4.TabIndex = 7
        Label4.Text = "ADD EMPLOY DETAIL JOINING"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_02_16_171953
        ClientSize = New Size(1437, 581)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
