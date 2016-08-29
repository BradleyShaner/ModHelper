Public Class Form1
    Dim AppDir As String = System.AppDomain.CurrentDomain.BaseDirectory()
    Dim ModDir As String = "mods/"

    Dim arrGames As Array = New String() {"war", _
                                           "dm", _
                                           "dom", _
                                            "dem", _
                                            "sab", _
                                            "arena", _
                                            "sd", _
                                            "ctf", _
                                            "oneflag", _
                                            "gtnw", _
                                            "koth", _
                                            "oitc"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Log("ModHelper v" & Application.ProductVersion & " by Dragoon", True)
        txtModDir.Text = ModDir
        If LoadDir(AppDir & ModDir) = False Then
            If LoadDir(AppDir & "mods/mp/") = True Then
                ModDir = "mods/mp/"
            Else
                MsgBox("Please put this in your MW2 folder and put all your mods in the 'mods' folder.")
            End If

        End If

        EnumMaps()
        EnumGames()
        EnumTooltips()
    End Sub

    Private Sub EnumTooltips()
        Dim tt As ToolTip = New System.Windows.Forms.ToolTip(Me.components)

        With tt
            .SetToolTip(chkMapRestart, "This must be used when you're already playing a game and NOT in the lobby.")
            .SetToolTip(chkVidRestart, "This must be used when you're in the menus or a lobby and NOT while playing in a game.")
            .SetToolTip(chkLobby, "This will change the command to ui_mapname when in the lobby instead of instantly changing the map.")
            .SetToolTip(chkMap, "Change the map change when pressing Execute at the bottom, also exuctes all other commands.")
            .SetToolTip(chkType, "Change the gametype when pressing Execute at the bottom, also exuctes all other commands.")
            .SetToolTip(btnRestart, "Restart the current map/level.")
            .SetToolTip(btnGame, "Sets the gametype.")
            .SetToolTip(btnCustom, "Sends the custom text immediately.")
            .SetToolTip(btnHost, "Execute the commands to force host.")
            .SetToolTip(btnLaunch, "Executes the commands in the Results box on the left.")
            .SetToolTip(btnPlayers, "Modifies Min and Max players")
            .SetToolTip(btnMap, "Changes the map.")
            .SetToolTip(btnXP, "Sets the XP multipler.")
            .SetToolTip(btnTime, "Sets the timelimit of the match.")
            .SetToolTip(btnScore, "Sets the scorelimit of the match")
            .SetToolTip(chkDiehard, "Enabled Diehard mode (Last Stand, team mates can revive)")
            .SetToolTip(chkMod, "Update the mod that is loaded on Execute.")
            .SetToolTip(chkStart, "If MW2 is not running, it will be started if this box is checked.")
            '.SetToolTip(lstDir, "This is a list of the mods detected, click one to choose it and then click Execute to launch it in MW2.")
            Log("--------------------------------------------------")
            Log("The list above are the mods found. Select one, change other commands on the right, then click Execute to launch it in MW2.")
            Log("Hover over things for a description!")

            .Active = True
        End With

    End Sub


    Public Sub Log(ByVal Message As String, Optional ByVal NoNewLine As Boolean = False)
        If NoNewLine = True Then
            txtLog.Text += Message
            SetPos(Message, True)
        Else
            txtLog.Text += vbCrLf & Message
            SetPos(Message, False)
        End If
    End Sub

    Private Sub SetPos(ByVal Message As String, Optional ByVal NoNewLine As Boolean = False)
        Dim strLen As Long = Len(txtLog.Text)
        Dim strMsgLen As Long = Len(Message)

        If strLen + strMsgLen > 2048 Then
            txtLog.Text = ""
            strLen = strMsgLen
            'If NoNewLine = True Then
            txtLog.Text += Message
            'Else
            '    txtLog.Text += Message & vbCrLf
            'End If
        End If

        With txtLog
            .SelectionLength = 0
            .SelectionStart = strLen
            .ScrollToCaret()
        End With
    End Sub

    Public Function LoadDir(ByVal Dir As String) As Boolean

        Try
            lstDir.Items.Clear()
            ' make a reference to a directory
            Dim di As New IO.DirectoryInfo(Dir)
            'for every subdirectory in the folder, add its name to the listbox
            For Each subdi As IO.DirectoryInfo In di.GetDirectories
                lstDir.Items.Add(subdi.Name)
            Next

            If lstDir.Items.Count <= 1 Then
                Return False
                'Log("You've got no mods?!")
            Else
                lstDir.SelectedIndex = 0
            End If

        Catch e As Exception : Log("Error: " & Replace(e.Message, AppDir, "")) : Return False
        End Try
        Return True
    End Function

    Public Sub EnumMaps()
        Dim arrMaps As Array = New String() {"mp_afghan", _
                                                "mp_boneyard", _
                                                "mp_brecourt", _
                                                "mp_checkpoint", _
                                                "mp_derail", _
                                                "mp_estate", _
                                                "mp_favela", _
                                                "mp_highrise", _
                                                "mp_nightshift", _
                                                "mp_invasion", _
                                                "mp_quarry", _
                                                "mp_rundown", _
                                                "mp_rust", _
                                                "mp_subbase", _
                                                "mp_terminal", _
                                                "mp_underpass", _
                                                "mp_complex", _
                                                "mp_compact", _
                                                "mp_crash", _
                                                "mp_overgrown", _
                                                "mp_storm", _
                                                "mp_fuel2", _
                                                "mp_abandon", _
                                                "mp_strike", _
                                                "mp_trailerpark", _
                                                "mp_vacant"}

        For Each strArr In arrMaps
            cbMaps.Items.Add(strArr)
        Next
        cbMaps.SelectedIndex = 0
    End Sub


    Private Sub EnumGames()
        Dim arr As Array = New String() {"Team Dethmatch", _
                                   "FFA", _
                                   "Domination", _
                                    "Demolitiont", _
                                    "Sabotage", _
                                    "Arena", _
                                    "Search 'n' Destroy", _
                                    "CTF", _
                                    "One Flag", _
                                    "Glob Therm Nuc War", _
                                    "Headquarters", _
                                    "One In The Chamber"}

        For Each strArr In arr
            cbGame.Items.Add(strArr)
        Next
        cbGame.SelectedIndex = 0
    End Sub

    Public Sub SendCmd(ByVal strCMD As String)
        If ConnectionManager.CheckProcess = True Then
            Application.DoEvents()
            ConnectionManager.Handle(strCMD, True)
            Application.DoEvents()
        Else
            Application.DoEvents()
            ConnectionManager.Handle(strCMD, False)
            Application.DoEvents()
        End If
    End Sub

    Private Sub SetResult()
        Dim strResult As String
        If chkMod.Checked = True Then strResult = "fs_game " & ModDir & lstDir.Text & ";"

        If chkType.Checked = True Then strResult += "g_gametype " & arrGames(cbGame.SelectedIndex) & ";"
        If chkDiehard.Checked = True Then strResult += "scr_diehard " & """" & "1" & """" & ";"
        If chkMap.Checked = True Then If chkLobby.Checked = True Then strResult += "ui_mapname " & cbMaps.Text & ";" Else strResult += "map " & cbMaps.Text & ";"
        If chkVidRestart.Checked = True Then strResult += "vid_restart;"
        If chkMapRestart.Checked = True Then strResult += "map_restart;"

        txtResult.Text = strResult
    End Sub

    Private Sub lstDir_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDir.SelectedIndexChanged
        chkMod.Checked = True
        SetResult()
    End Sub

    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    '    Dim strDir As String
    '    Folder.RootFolder = Environment.SpecialFolder.Desktop
    '    Folder.SelectedPath = AppDir
    '    Folder.Description = ("Select your MW2 folder.")
    '    Folder.ShowDialog()
    '    strDir = Folder.SelectedPath
    '    LoadDir(strDir)
    'End Sub

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        SendCmd(txtResult.Text)
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        SendCmd("map_restart")
    End Sub

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click
        Log("Changing map to" & cbMaps.Text & ";")
        If chkLobby.Checked = True Then
            SendCmd("ui_mapname " & cbMaps.Text)
        Else
            SendCmd("map " & cbMaps.Text)
        End If

    End Sub

    Private Sub btnGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame.Click
        Log("Changing game type to " & arrGames(cbGame.SelectedIndex))
        SendCmd("g_gametype " & arrGames(cbGame.SelectedIndex))
    End Sub

    Private Sub chkMap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMap.CheckedChanged
        With btnMap
            If .Enabled = True Then .Enabled = False Else .Enabled = True
        End With
        SetResult()
    End Sub

    Private Sub chkType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkType.CheckedChanged
        With btnGame
            If .Enabled = True Then .Enabled = False Else .Enabled = True
        End With
        SetResult()
    End Sub

    Private Sub btnHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHost.Click
        SendCmd("party_hostmigration 0; party_connecttimeout 1; badhost_endgameifisuck 0")
    End Sub

    Private Sub btnPlayers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayers.Click
        SendCmd("party_minplayers " & """" & numMin.Value & """" & ";" & "party_maxplayers " & """" & numMax.Value & """" & ";") 'party_minplayers "2"
        'party_maxplayers "18"
    End Sub

    Private Sub chkDiehard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDiehard.CheckedChanged
        SetResult()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXP.Click
        SendCmd("scr_xpscale " & numXP.Value)
    End Sub

    Private Sub chkMod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMod.CheckedChanged
        SetResult()
    End Sub

    Private Sub chkLobby_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLobby.CheckedChanged
        SetResult()
    End Sub

    Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click
        SendCmd("scr_" & arrGames(cbGame.SelectedIndex) & "_timelimit " & numTime.Value)
    End Sub

    Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
        SendCmd("scr_" & arrGames(cbGame.SelectedIndex) & "_scorelimit " & numScore.Value)
    End Sub

    Private Sub cbMaps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMaps.SelectedIndexChanged
        SetResult()

    End Sub

    Private Sub cbGame_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGame.SelectedIndexChanged
        SetResult()
    End Sub

    Private Sub chkMapRestart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMapRestart.CheckedChanged
        SetResult()
    End Sub

    Private Sub chkVidRestart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVidRestart.CheckedChanged
        SetResult()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Not txtCustom.Text = "" Then If ConnectionManager.CheckProcess = True Then SendCmd(txtCustom.Text)
    End Sub

    Private Sub btnCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustom.Click
        If Not txtCustom.Text = "" Then SendCmd(txtCustom.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTimer.CheckedChanged
        Timer.Enabled = chkTimer.checked
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Log(".")
    '    Me.Text = Len(txtLog.Text)
    'End Sub

    Private Sub btnFov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoV.Click
        SendCmd("cg_fov " & """" & "80" & """")
    End Sub

    Private Sub numTimer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numTimer.ValueChanged
        Timer.Interval = numTimer.Value * 1000
        chkTimer.Text = "Every " & numTimer.Value & " secs"
    End Sub
End Class
