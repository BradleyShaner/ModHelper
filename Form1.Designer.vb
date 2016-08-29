<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lstDir = New System.Windows.Forms.ListBox()
        Me.txtModDir = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.cbMaps = New System.Windows.Forms.ComboBox()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.chkMap = New System.Windows.Forms.CheckBox()
        Me.cbGame = New System.Windows.Forms.ComboBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnGame = New System.Windows.Forms.Button()
        Me.chkType = New System.Windows.Forms.CheckBox()
        Me.chkLobby = New System.Windows.Forms.CheckBox()
        Me.btnHost = New System.Windows.Forms.Button()
        Me.numMax = New System.Windows.Forms.NumericUpDown()
        Me.numMin = New System.Windows.Forms.NumericUpDown()
        Me.btnPlayers = New System.Windows.Forms.Button()
        Me.chkDiehard = New System.Windows.Forms.CheckBox()
        Me.numXP = New System.Windows.Forms.NumericUpDown()
        Me.btnXP = New System.Windows.Forms.Button()
        Me.chkMod = New System.Windows.Forms.CheckBox()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.numScore = New System.Windows.Forms.NumericUpDown()
        Me.numTime = New System.Windows.Forms.NumericUpDown()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.chkVidRestart = New System.Windows.Forms.RadioButton()
        Me.chkMapRestart = New System.Windows.Forms.RadioButton()
        Me.txtCustom = New System.Windows.Forms.TextBox()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.chkTimer = New System.Windows.Forms.CheckBox()
        Me.chkStart = New System.Windows.Forms.CheckBox()
        Me.btnFoV = New System.Windows.Forms.Button()
        Me.numTimer = New System.Windows.Forms.NumericUpDown()
        CType(Me.numMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 225)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(202, 106)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        '
        'lstDir
        '
        Me.lstDir.FormattingEnabled = True
        Me.lstDir.Location = New System.Drawing.Point(12, 12)
        Me.lstDir.Name = "lstDir"
        Me.lstDir.Size = New System.Drawing.Size(202, 199)
        Me.lstDir.TabIndex = 1
        '
        'txtModDir
        '
        Me.txtModDir.Location = New System.Drawing.Point(12, 13)
        Me.txtModDir.Name = "txtModDir"
        Me.txtModDir.Size = New System.Drawing.Size(145, 20)
        Me.txtModDir.TabIndex = 2
        Me.txtModDir.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(174, 14)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(26, 20)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.Visible = False
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(227, 311)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(184, 20)
        Me.txtResult.TabIndex = 4
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(224, 299)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(40, 13)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Result:"
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(417, 301)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(86, 30)
        Me.btnLaunch.TabIndex = 6
        Me.btnLaunch.Text = "Execute"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'cbMaps
        '
        Me.cbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaps.FormattingEnabled = True
        Me.cbMaps.Location = New System.Drawing.Point(227, 12)
        Me.cbMaps.Name = "cbMaps"
        Me.cbMaps.Size = New System.Drawing.Size(184, 21)
        Me.cbMaps.Sorted = True
        Me.cbMaps.TabIndex = 9
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(417, 12)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(86, 22)
        Me.btnMap.TabIndex = 10
        Me.btnMap.Text = "Change Map"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'chkMap
        '
        Me.chkMap.AutoSize = True
        Me.chkMap.Location = New System.Drawing.Point(227, 34)
        Me.chkMap.Name = "chkMap"
        Me.chkMap.Size = New System.Drawing.Size(127, 17)
        Me.chkMap.TabIndex = 11
        Me.chkMap.Text = "Add to Execute result"
        Me.chkMap.UseVisualStyleBackColor = True
        '
        'cbGame
        '
        Me.cbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGame.FormattingEnabled = True
        Me.cbGame.Location = New System.Drawing.Point(227, 57)
        Me.cbGame.Name = "cbGame"
        Me.cbGame.Size = New System.Drawing.Size(184, 21)
        Me.cbGame.TabIndex = 12
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(417, 240)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(86, 22)
        Me.btnRestart.TabIndex = 13
        Me.btnRestart.Text = "Restart Map"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnGame
        '
        Me.btnGame.Location = New System.Drawing.Point(417, 57)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(86, 22)
        Me.btnGame.TabIndex = 14
        Me.btnGame.Text = "Change Type"
        Me.btnGame.UseVisualStyleBackColor = True
        '
        'chkType
        '
        Me.chkType.AutoSize = True
        Me.chkType.Location = New System.Drawing.Point(227, 79)
        Me.chkType.Name = "chkType"
        Me.chkType.Size = New System.Drawing.Size(127, 17)
        Me.chkType.TabIndex = 15
        Me.chkType.Text = "Add to Execute result"
        Me.chkType.UseVisualStyleBackColor = True
        '
        'chkLobby
        '
        Me.chkLobby.AutoSize = True
        Me.chkLobby.Location = New System.Drawing.Point(417, 34)
        Me.chkLobby.Name = "chkLobby"
        Me.chkLobby.Size = New System.Drawing.Size(82, 17)
        Me.chkLobby.TabIndex = 16
        Me.chkLobby.Text = "I'm in Lobby"
        Me.chkLobby.UseVisualStyleBackColor = True
        '
        'btnHost
        '
        Me.btnHost.Location = New System.Drawing.Point(417, 268)
        Me.btnHost.Name = "btnHost"
        Me.btnHost.Size = New System.Drawing.Size(86, 28)
        Me.btnHost.TabIndex = 17
        Me.btnHost.Text = "Force Host"
        Me.btnHost.UseVisualStyleBackColor = True
        '
        'numMax
        '
        Me.numMax.Location = New System.Drawing.Point(406, 146)
        Me.numMax.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.numMax.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numMax.Name = "numMax"
        Me.numMax.Size = New System.Drawing.Size(51, 20)
        Me.numMax.TabIndex = 18
        Me.numMax.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'numMin
        '
        Me.numMin.Location = New System.Drawing.Point(349, 146)
        Me.numMin.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.numMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMin.Name = "numMin"
        Me.numMin.Size = New System.Drawing.Size(51, 20)
        Me.numMin.TabIndex = 19
        Me.numMin.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnPlayers
        '
        Me.btnPlayers.Location = New System.Drawing.Point(227, 147)
        Me.btnPlayers.Name = "btnPlayers"
        Me.btnPlayers.Size = New System.Drawing.Size(108, 20)
        Me.btnPlayers.TabIndex = 20
        Me.btnPlayers.Text = "Min/Max Players"
        Me.btnPlayers.UseVisualStyleBackColor = True
        '
        'chkDiehard
        '
        Me.chkDiehard.AutoSize = True
        Me.chkDiehard.Location = New System.Drawing.Point(319, 256)
        Me.chkDiehard.Name = "chkDiehard"
        Me.chkDiehard.Size = New System.Drawing.Size(92, 17)
        Me.chkDiehard.TabIndex = 21
        Me.chkDiehard.Text = "Diehard mode"
        Me.chkDiehard.UseVisualStyleBackColor = True
        '
        'numXP
        '
        Me.numXP.Location = New System.Drawing.Point(349, 225)
        Me.numXP.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numXP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numXP.Name = "numXP"
        Me.numXP.Size = New System.Drawing.Size(51, 20)
        Me.numXP.TabIndex = 22
        Me.numXP.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnXP
        '
        Me.btnXP.Location = New System.Drawing.Point(227, 225)
        Me.btnXP.Name = "btnXP"
        Me.btnXP.Size = New System.Drawing.Size(108, 20)
        Me.btnXP.TabIndex = 23
        Me.btnXP.Text = "Set XP Multiplier"
        Me.btnXP.UseVisualStyleBackColor = True
        '
        'chkMod
        '
        Me.chkMod.AutoSize = True
        Me.chkMod.Location = New System.Drawing.Point(227, 256)
        Me.chkMod.Name = "chkMod"
        Me.chkMod.Size = New System.Drawing.Size(86, 17)
        Me.chkMod.TabIndex = 24
        Me.chkMod.Text = "Change mod"
        Me.chkMod.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(227, 173)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(108, 20)
        Me.btnTime.TabIndex = 27
        Me.btnTime.Text = "Set Timelimit"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'numScore
        '
        Me.numScore.Location = New System.Drawing.Point(349, 199)
        Me.numScore.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numScore.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numScore.Name = "numScore"
        Me.numScore.Size = New System.Drawing.Size(51, 20)
        Me.numScore.TabIndex = 26
        Me.numScore.Value = New Decimal(New Integer() {7500, 0, 0, 0})
        '
        'numTime
        '
        Me.numTime.Location = New System.Drawing.Point(349, 173)
        Me.numTime.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numTime.Name = "numTime"
        Me.numTime.Size = New System.Drawing.Size(51, 20)
        Me.numTime.TabIndex = 25
        Me.numTime.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(227, 199)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(108, 20)
        Me.btnScore.TabIndex = 28
        Me.btnScore.Text = "Set Scorelimit"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'chkVidRestart
        '
        Me.chkVidRestart.AutoSize = True
        Me.chkVidRestart.Checked = True
        Me.chkVidRestart.Location = New System.Drawing.Point(227, 279)
        Me.chkVidRestart.Name = "chkVidRestart"
        Me.chkVidRestart.Size = New System.Drawing.Size(74, 17)
        Me.chkVidRestart.TabIndex = 29
        Me.chkVidRestart.TabStop = True
        Me.chkVidRestart.Text = "vid_restart"
        Me.chkVidRestart.UseVisualStyleBackColor = True
        '
        'chkMapRestart
        '
        Me.chkMapRestart.AutoSize = True
        Me.chkMapRestart.Location = New System.Drawing.Point(319, 279)
        Me.chkMapRestart.Name = "chkMapRestart"
        Me.chkMapRestart.Size = New System.Drawing.Size(80, 17)
        Me.chkMapRestart.TabIndex = 30
        Me.chkMapRestart.Text = "map_restart"
        Me.chkMapRestart.UseVisualStyleBackColor = True
        '
        'txtCustom
        '
        Me.txtCustom.Location = New System.Drawing.Point(227, 97)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(181, 20)
        Me.txtCustom.TabIndex = 31
        Me.txtCustom.Text = "say ""^4Excessive use of 'noob weapons' (GL, Shotgun, G18) will result in a kick.""" &
    ""
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(417, 97)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(86, 20)
        Me.btnCustom.TabIndex = 32
        Me.btnCustom.Text = "Exec Custom"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 60000
        '
        'chkTimer
        '
        Me.chkTimer.AutoSize = True
        Me.chkTimer.Location = New System.Drawing.Point(417, 120)
        Me.chkTimer.Name = "chkTimer"
        Me.chkTimer.Size = New System.Drawing.Size(70, 17)
        Me.chkTimer.TabIndex = 33
        Me.chkTimer.Text = "Every XX"
        Me.chkTimer.UseVisualStyleBackColor = True
        '
        'chkStart
        '
        Me.chkStart.AutoSize = True
        Me.chkStart.Checked = True
        Me.chkStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStart.Location = New System.Drawing.Point(417, 189)
        Me.chkStart.Name = "chkStart"
        Me.chkStart.Size = New System.Drawing.Size(77, 17)
        Me.chkStart.TabIndex = 34
        Me.chkStart.Text = "Start MW2"
        Me.chkStart.UseVisualStyleBackColor = True
        '
        'btnFoV
        '
        Me.btnFoV.Location = New System.Drawing.Point(417, 212)
        Me.btnFoV.Name = "btnFoV"
        Me.btnFoV.Size = New System.Drawing.Size(86, 22)
        Me.btnFoV.TabIndex = 35
        Me.btnFoV.Text = "Set FoV 80"
        Me.btnFoV.UseVisualStyleBackColor = True
        '
        'numTimer
        '
        Me.numTimer.Location = New System.Drawing.Point(357, 120)
        Me.numTimer.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numTimer.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTimer.Name = "numTimer"
        Me.numTimer.Size = New System.Drawing.Size(51, 20)
        Me.numTimer.TabIndex = 36
        Me.numTimer.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 343)
        Me.Controls.Add(Me.numTimer)
        Me.Controls.Add(Me.btnFoV)
        Me.Controls.Add(Me.chkStart)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.chkTimer)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.txtCustom)
        Me.Controls.Add(Me.chkMapRestart)
        Me.Controls.Add(Me.chkVidRestart)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.numScore)
        Me.Controls.Add(Me.numTime)
        Me.Controls.Add(Me.chkMod)
        Me.Controls.Add(Me.btnXP)
        Me.Controls.Add(Me.numXP)
        Me.Controls.Add(Me.chkDiehard)
        Me.Controls.Add(Me.btnPlayers)
        Me.Controls.Add(Me.numMin)
        Me.Controls.Add(Me.numMax)
        Me.Controls.Add(Me.btnHost)
        Me.Controls.Add(Me.chkLobby)
        Me.Controls.Add(Me.chkType)
        Me.Controls.Add(Me.btnGame)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.cbGame)
        Me.Controls.Add(Me.chkMap)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(Me.cbMaps)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtModDir)
        Me.Controls.Add(Me.lstDir)
        Me.Controls.Add(Me.txtLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ModHelper"
        CType(Me.numMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents lstDir As System.Windows.Forms.ListBox
    Friend WithEvents txtModDir As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents cbMaps As System.Windows.Forms.ComboBox
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents chkMap As System.Windows.Forms.CheckBox
    Friend WithEvents cbGame As System.Windows.Forms.ComboBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnGame As System.Windows.Forms.Button
    Friend WithEvents chkType As System.Windows.Forms.CheckBox
    Friend WithEvents chkLobby As System.Windows.Forms.CheckBox
    Friend WithEvents btnHost As System.Windows.Forms.Button
    Friend WithEvents numMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPlayers As System.Windows.Forms.Button
    Friend WithEvents chkDiehard As System.Windows.Forms.CheckBox
    Friend WithEvents numXP As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnXP As System.Windows.Forms.Button
    Friend WithEvents chkMod As System.Windows.Forms.CheckBox
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents numScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents numTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnScore As System.Windows.Forms.Button
    Friend WithEvents chkVidRestart As System.Windows.Forms.RadioButton
    Friend WithEvents chkMapRestart As System.Windows.Forms.RadioButton
    Friend WithEvents txtCustom As System.Windows.Forms.TextBox
    Friend WithEvents btnCustom As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents chkTimer As System.Windows.Forms.CheckBox
    Friend WithEvents chkStart As System.Windows.Forms.CheckBox
    Friend WithEvents btnFoV As System.Windows.Forms.Button
    Friend WithEvents numTimer As System.Windows.Forms.NumericUpDown

End Class
