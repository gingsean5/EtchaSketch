<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SketchyEtchy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.MiddleColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WaveformsButton = New System.Windows.Forms.Button()
        Me.ColorSelectButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagicToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(776, 348)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        Me.MagicToolTip.SetToolTip(Me.DisplayPictureBox, "Draw on this surface with left click")
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(407, 366)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(178, 72)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.MagicToolTip.SetToolTip(Me.ClearButton, "Shakes and erases the Etch A Sketch")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(610, 366)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(178, 72)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.MagicToolTip.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'WaveformsButton
        '
        Me.WaveformsButton.Location = New System.Drawing.Point(12, 366)
        Me.WaveformsButton.Name = "WaveformsButton"
        Me.WaveformsButton.Size = New System.Drawing.Size(178, 72)
        Me.WaveformsButton.TabIndex = 0
        Me.WaveformsButton.Text = "Draw &WaveForms"
        Me.MagicToolTip.SetToolTip(Me.WaveformsButton, "Draws a sine, cosine, and tangent waves")
        Me.WaveformsButton.UseVisualStyleBackColor = True
        '
        'ColorSelectButton
        '
        Me.ColorSelectButton.Location = New System.Drawing.Point(211, 366)
        Me.ColorSelectButton.Name = "ColorSelectButton"
        Me.ColorSelectButton.Size = New System.Drawing.Size(178, 72)
        Me.ColorSelectButton.TabIndex = 1
        Me.ColorSelectButton.Text = "&Select Color"
        Me.MagicToolTip.SetToolTip(Me.ColorSelectButton, "Selects the drawing color for left clicks")
        Me.ColorSelectButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(111, 76)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenu, Me.EditTopMenu, Me.HelpTopMenu})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.TopMenuStrip.TabIndex = 7
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenu
        '
        Me.FileTopMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitTopMenu})
        Me.FileTopMenu.Name = "FileTopMenu"
        Me.FileTopMenu.Size = New System.Drawing.Size(46, 24)
        Me.FileTopMenu.Text = "File"
        Me.FileTopMenu.ToolTipText = "Exit"
        '
        'ExitTopMenu
        '
        Me.ExitTopMenu.Name = "ExitTopMenu"
        Me.ExitTopMenu.Size = New System.Drawing.Size(224, 26)
        Me.ExitTopMenu.Text = "Exit"
        Me.ExitTopMenu.ToolTipText = "Exits the program"
        '
        'EditTopMenu
        '
        Me.EditTopMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorTopMenu, Me.DrawWaveformsTopMenu, Me.ClearTopMenu})
        Me.EditTopMenu.Name = "EditTopMenu"
        Me.EditTopMenu.Size = New System.Drawing.Size(49, 24)
        Me.EditTopMenu.Text = "Edit"
        Me.EditTopMenu.ToolTipText = "Select Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Waveforms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clear"
        '
        'SelectColorTopMenu
        '
        Me.SelectColorTopMenu.Name = "SelectColorTopMenu"
        Me.SelectColorTopMenu.Size = New System.Drawing.Size(224, 26)
        Me.SelectColorTopMenu.Text = "Select Color"
        Me.SelectColorTopMenu.ToolTipText = "Selects the drawing color for left clicks"
        '
        'DrawWaveformsTopMenu
        '
        Me.DrawWaveformsTopMenu.Name = "DrawWaveformsTopMenu"
        Me.DrawWaveformsTopMenu.Size = New System.Drawing.Size(224, 26)
        Me.DrawWaveformsTopMenu.Text = "Draw Waveforms"
        Me.DrawWaveformsTopMenu.ToolTipText = "Draws a sine, cosine, and tangent waves"
        '
        'ClearTopMenu
        '
        Me.ClearTopMenu.Name = "ClearTopMenu"
        Me.ClearTopMenu.Size = New System.Drawing.Size(224, 26)
        Me.ClearTopMenu.Text = "Clear"
        Me.ClearTopMenu.ToolTipText = "Shakes and erases the Etch A Sketch"
        '
        'HelpTopMenu
        '
        Me.HelpTopMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenu})
        Me.HelpTopMenu.Name = "HelpTopMenu"
        Me.HelpTopMenu.Size = New System.Drawing.Size(55, 24)
        Me.HelpTopMenu.Text = "Help"
        Me.HelpTopMenu.ToolTipText = "About"
        '
        'AboutTopMenu
        '
        Me.AboutTopMenu.Name = "AboutTopMenu"
        Me.AboutTopMenu.Size = New System.Drawing.Size(224, 26)
        Me.AboutTopMenu.Text = "About"
        Me.AboutTopMenu.ToolTipText = "Learn the secrets of the universe"
        '
        'SketchyEtchy
        '
        Me.AcceptButton = Me.WaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.ColorSelectButton)
        Me.Controls.Add(Me.WaveformsButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "SketchyEtchy"
        Me.Text = "Etch A Sketch"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents MiddleColorDialog As ColorDialog
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents WaveformsButton As Button
    Friend WithEvents ColorSelectButton As Button
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenu As ToolStripMenuItem
    Friend WithEvents ExitTopMenu As ToolStripMenuItem
    Friend WithEvents EditTopMenu As ToolStripMenuItem
    Friend WithEvents SelectColorTopMenu As ToolStripMenuItem
    Friend WithEvents DrawWaveformsTopMenu As ToolStripMenuItem
    Friend WithEvents ClearTopMenu As ToolStripMenuItem
    Friend WithEvents HelpTopMenu As ToolStripMenuItem
    Friend WithEvents AboutTopMenu As ToolStripMenuItem
    Friend WithEvents MagicToolTip As ToolTip
End Class
