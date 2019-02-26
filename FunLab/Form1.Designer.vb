<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFun
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
        Me.components = New System.ComponentModel.Container()
        Dim ToolTip1 As System.Windows.Forms.ToolTip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFun))
        Me.lblfun = New System.Windows.Forms.Label()
        Me.grpComboPlay = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lblpicked = New System.Windows.Forms.Label()
        Me.grpStyle = New System.Windows.Forms.GroupBox()
        Me.radSimple = New System.Windows.Forms.RadioButton()
        Me.radDropList = New System.Windows.Forms.RadioButton()
        Me.radDropDown = New System.Windows.Forms.RadioButton()
        Me.cboSubjects = New System.Windows.Forms.ComboBox()
        Me.btnplaymore = New System.Windows.Forms.Button()
        Me.Lbcount = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ColorChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToBluectrlBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToGreenctrlGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToRedctrlRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JumpToSecondFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbresult = New System.Windows.Forms.Label()
        Me.btnroll = New System.Windows.Forms.Button()
        Me.grpteltype = New System.Windows.Forms.GroupBox()
        Me.btnslower = New System.Windows.Forms.Button()
        Me.btnfaster = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtteletype = New System.Windows.Forms.TextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpComboPlay.SuspendLayout()
        Me.grpStyle.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grpteltype.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 200
        ToolTip1.IsBalloon = True
        ToolTip1.ReshowDelay = 100
        ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        ToolTip1.ToolTipTitle = "ToolTip"
        '
        'lblfun
        '
        Me.lblfun.AutoSize = True
        Me.lblfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfun.ForeColor = System.Drawing.Color.DarkRed
        Me.lblfun.Location = New System.Drawing.Point(157, 57)
        Me.lblfun.Name = "lblfun"
        Me.lblfun.Size = New System.Drawing.Size(306, 55)
        Me.lblfun.TabIndex = 1
        Me.lblfun.Text = "Lab 285 Fun"
        '
        'grpComboPlay
        '
        Me.grpComboPlay.Controls.Add(Me.Button3)
        Me.grpComboPlay.Controls.Add(Me.Button2)
        Me.grpComboPlay.Controls.Add(Me.Button1)
        Me.grpComboPlay.Controls.Add(Me.Lblpicked)
        Me.grpComboPlay.Controls.Add(Me.grpStyle)
        Me.grpComboPlay.Controls.Add(Me.cboSubjects)
        Me.grpComboPlay.Location = New System.Drawing.Point(12, 171)
        Me.grpComboPlay.Name = "grpComboPlay"
        Me.grpComboPlay.Size = New System.Drawing.Size(258, 251)
        Me.grpComboPlay.TabIndex = 2
        Me.grpComboPlay.TabStop = False
        Me.grpComboPlay.Text = "ComboBox play"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 25)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Reload combo box from array query"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 25)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Remove french from combo box"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add english to conbo box"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lblpicked
        '
        Me.Lblpicked.AutoSize = True
        Me.Lblpicked.Location = New System.Drawing.Point(32, 120)
        Me.Lblpicked.Name = "Lblpicked"
        Me.Lblpicked.Size = New System.Drawing.Size(61, 13)
        Me.Lblpicked.TabIndex = 5
        Me.Lblpicked.Text = "You picked"
        '
        'grpStyle
        '
        Me.grpStyle.Controls.Add(Me.radSimple)
        Me.grpStyle.Controls.Add(Me.radDropList)
        Me.grpStyle.Controls.Add(Me.radDropDown)
        Me.grpStyle.Location = New System.Drawing.Point(141, 19)
        Me.grpStyle.Name = "grpStyle"
        Me.grpStyle.Size = New System.Drawing.Size(93, 89)
        Me.grpStyle.TabIndex = 3
        Me.grpStyle.TabStop = False
        Me.grpStyle.Text = "Current Style"
        '
        'radSimple
        '
        Me.radSimple.AutoSize = True
        Me.radSimple.Location = New System.Drawing.Point(3, 65)
        Me.radSimple.Name = "radSimple"
        Me.radSimple.Size = New System.Drawing.Size(56, 17)
        Me.radSimple.TabIndex = 2
        Me.radSimple.Text = "Simple"
        Me.radSimple.UseVisualStyleBackColor = True
        '
        'radDropList
        '
        Me.radDropList.AutoSize = True
        Me.radDropList.Location = New System.Drawing.Point(3, 42)
        Me.radDropList.Name = "radDropList"
        Me.radDropList.Size = New System.Drawing.Size(92, 17)
        Me.radDropList.TabIndex = 1
        Me.radDropList.Text = "DropDownList"
        Me.radDropList.UseVisualStyleBackColor = True
        '
        'radDropDown
        '
        Me.radDropDown.AutoSize = True
        Me.radDropDown.Checked = True
        Me.radDropDown.Location = New System.Drawing.Point(3, 19)
        Me.radDropDown.Name = "radDropDown"
        Me.radDropDown.Size = New System.Drawing.Size(79, 17)
        Me.radDropDown.TabIndex = 0
        Me.radDropDown.TabStop = True
        Me.radDropDown.Text = "Drop Down"
        Me.radDropDown.UseVisualStyleBackColor = True
        '
        'cboSubjects
        '
        Me.cboSubjects.FormattingEnabled = True
        Me.cboSubjects.Items.AddRange(New Object() {"cis", "french", "history", "math"})
        Me.cboSubjects.Location = New System.Drawing.Point(15, 27)
        Me.cboSubjects.Name = "cboSubjects"
        Me.cboSubjects.Size = New System.Drawing.Size(120, 21)
        Me.cboSubjects.Sorted = True
        Me.cboSubjects.TabIndex = 0
        '
        'btnplaymore
        '
        Me.btnplaymore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplaymore.Location = New System.Drawing.Point(426, 127)
        Me.btnplaymore.Name = "btnplaymore"
        Me.btnplaymore.Size = New System.Drawing.Size(109, 34)
        Me.btnplaymore.TabIndex = 3
        Me.btnplaymore.Text = "More Play"
        Me.btnplaymore.UseVisualStyleBackColor = True
        '
        'Lbcount
        '
        Me.Lbcount.AutoSize = True
        Me.Lbcount.Location = New System.Drawing.Point(439, 190)
        Me.Lbcount.Name = "Lbcount"
        Me.Lbcount.Size = New System.Drawing.Size(62, 13)
        Me.Lbcount.TabIndex = 4
        Me.Lbcount.Text = "counter is 0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorChangeToolStripMenuItem, Me.JumpToSecondFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ColorChangeToolStripMenuItem
        '
        Me.ColorChangeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToBluectrlBToolStripMenuItem, Me.ToGreenctrlGToolStripMenuItem, Me.ToRedctrlRToolStripMenuItem})
        Me.ColorChangeToolStripMenuItem.Name = "ColorChangeToolStripMenuItem"
        Me.ColorChangeToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ColorChangeToolStripMenuItem.Text = "color change"
        '
        'ToBluectrlBToolStripMenuItem
        '
        Me.ToBluectrlBToolStripMenuItem.Name = "ToBluectrlBToolStripMenuItem"
        Me.ToBluectrlBToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToBluectrlBToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ToBluectrlBToolStripMenuItem.Text = "to blue(ctrl b)"
        '
        'ToGreenctrlGToolStripMenuItem
        '
        Me.ToGreenctrlGToolStripMenuItem.Name = "ToGreenctrlGToolStripMenuItem"
        Me.ToGreenctrlGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ToGreenctrlGToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ToGreenctrlGToolStripMenuItem.Text = "to green(ctrl G)"
        '
        'ToRedctrlRToolStripMenuItem
        '
        Me.ToRedctrlRToolStripMenuItem.Name = "ToRedctrlRToolStripMenuItem"
        Me.ToRedctrlRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToRedctrlRToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ToRedctrlRToolStripMenuItem.Text = "to red(ctrl R)"
        '
        'JumpToSecondFormToolStripMenuItem
        '
        Me.JumpToSecondFormToolStripMenuItem.Name = "JumpToSecondFormToolStripMenuItem"
        Me.JumpToSecondFormToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.JumpToSecondFormToolStripMenuItem.Text = "jump to second form"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FunLab.My.Resources.Resources.USAlogo
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbresult)
        Me.GroupBox3.Controls.Add(Me.btnroll)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 123)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dice Rolling Play"
        '
        'lbresult
        '
        Me.lbresult.AutoSize = True
        Me.lbresult.Location = New System.Drawing.Point(6, 87)
        Me.lbresult.Name = "lbresult"
        Me.lbresult.Size = New System.Drawing.Size(37, 13)
        Me.lbresult.TabIndex = 1
        Me.lbresult.Text = "Result"
        '
        'btnroll
        '
        Me.btnroll.Location = New System.Drawing.Point(7, 28)
        Me.btnroll.Name = "btnroll"
        Me.btnroll.Size = New System.Drawing.Size(110, 44)
        Me.btnroll.TabIndex = 0
        Me.btnroll.Text = "Roll the dice"
        Me.btnroll.UseVisualStyleBackColor = True
        '
        'grpteltype
        '
        Me.grpteltype.Controls.Add(Me.btnslower)
        Me.grpteltype.Controls.Add(Me.btnfaster)
        Me.grpteltype.Controls.Add(Me.btnStart)
        Me.grpteltype.Controls.Add(Me.txtteletype)
        Me.grpteltype.Location = New System.Drawing.Point(288, 259)
        Me.grpteltype.Name = "grpteltype"
        Me.grpteltype.Size = New System.Drawing.Size(247, 162)
        Me.grpteltype.TabIndex = 7
        Me.grpteltype.TabStop = False
        Me.grpteltype.Text = "teletype play(uses timer)"
        '
        'btnslower
        '
        Me.btnslower.Location = New System.Drawing.Point(19, 139)
        Me.btnslower.Name = "btnslower"
        Me.btnslower.Size = New System.Drawing.Size(207, 23)
        Me.btnslower.TabIndex = 3
        Me.btnslower.Text = "slower"
        Me.btnslower.UseVisualStyleBackColor = True
        '
        'btnfaster
        '
        Me.btnfaster.Location = New System.Drawing.Point(18, 95)
        Me.btnfaster.Name = "btnfaster"
        Me.btnfaster.Size = New System.Drawing.Size(207, 37)
        Me.btnfaster.TabIndex = 2
        Me.btnfaster.Text = "faster"
        Me.btnfaster.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(16, 55)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(210, 30)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "start it"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtteletype
        '
        Me.txtteletype.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtteletype.ForeColor = System.Drawing.Color.Lime
        Me.txtteletype.Location = New System.Drawing.Point(12, 19)
        Me.txtteletype.Name = "txtteletype"
        Me.txtteletype.Size = New System.Drawing.Size(215, 20)
        Me.txtteletype.TabIndex = 0
        Me.txtteletype.Text = "Working with VB controls and object is Fun"
        '
        'Timer1
        '
        '
        'FormFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 434)
        Me.Controls.Add(Me.grpteltype)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Lbcount)
        Me.Controls.Add(Me.btnplaymore)
        Me.Controls.Add(Me.grpComboPlay)
        Me.Controls.Add(Me.lblfun)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormFun"
        Me.Text = "Fun 285 by Rojeen Mulmi"
        Me.grpComboPlay.ResumeLayout(False)
        Me.grpComboPlay.PerformLayout()
        Me.grpStyle.ResumeLayout(False)
        Me.grpStyle.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpteltype.ResumeLayout(False)
        Me.grpteltype.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblfun As System.Windows.Forms.Label
    Friend WithEvents grpComboPlay As System.Windows.Forms.GroupBox
    Friend WithEvents grpStyle As System.Windows.Forms.GroupBox
    Friend WithEvents radSimple As System.Windows.Forms.RadioButton
    Friend WithEvents radDropList As System.Windows.Forms.RadioButton
    Friend WithEvents radDropDown As System.Windows.Forms.RadioButton
    Friend WithEvents cboSubjects As System.Windows.Forms.ComboBox
    Friend WithEvents Lblpicked As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnplaymore As System.Windows.Forms.Button
    Friend WithEvents Lbcount As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ColorChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToBluectrlBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToGreenctrlGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToRedctrlRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JumpToSecondFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbresult As System.Windows.Forms.Label
    Friend WithEvents btnroll As System.Windows.Forms.Button
    Friend WithEvents grpteltype As System.Windows.Forms.GroupBox
    Friend WithEvents btnslower As System.Windows.Forms.Button
    Friend WithEvents btnfaster As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtteletype As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
