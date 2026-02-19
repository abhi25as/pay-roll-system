<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        MenuStrip = New MenuStrip()
        AddEMPDetailsToolStripMenuItem = New ToolStripMenuItem()
        UpdateEMPToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(24, 24)
        MenuStrip.Items.AddRange(New ToolStripItem() {AddEMPDetailsToolStripMenuItem, UpdateEMPToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(10, 4, 0, 4)
        MenuStrip.Size = New Size(1053, 37)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' AddEMPDetailsToolStripMenuItem
        ' 
        AddEMPDetailsToolStripMenuItem.Name = "AddEMPDetailsToolStripMenuItem"
        AddEMPDetailsToolStripMenuItem.Size = New Size(160, 29)
        AddEMPDetailsToolStripMenuItem.Text = "Add EMP Details"
        ' 
        ' UpdateEMPToolStripMenuItem
        ' 
        UpdateEMPToolStripMenuItem.Name = "UpdateEMPToolStripMenuItem"
        UpdateEMPToolStripMenuItem.Size = New Size(126, 29)
        UpdateEMPToolStripMenuItem.Text = "Update EMP"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(24, 24)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 839)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(2, 0, 23, 0)
        StatusStrip.Size = New Size(1053, 32)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(60, 25)
        ToolStripStatusLabel.Text = "Status"
        ' 
        ' MDIParent1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1053, 871)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(5, 6, 5, 6)
        Name = "MDIParent1"
        Text = "MDIParent1"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AddEMPDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEMPToolStripMenuItem As ToolStripMenuItem

End Class
