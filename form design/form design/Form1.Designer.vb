<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.tabPlayerinput = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblcreateround = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.lblEnterAllPlayers = New System.Windows.Forms.Label()
        Me.lblAddPlayerSeededOrder = New System.Windows.Forms.Label()
        Me.txtEnterPlayerName = New System.Windows.Forms.TextBox()
        Me.btnRemoveMostRecent = New System.Windows.Forms.Button()
        Me.btnAddInOrder = New System.Windows.Forms.Button()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.tbaPlayerinput = New System.Windows.Forms.TabPage()
        Me.lbladdscores = New System.Windows.Forms.Label()
        Me.lblRoundInstructions = New System.Windows.Forms.Label()
        Me.lblHowRoundsWork = New System.Windows.Forms.Label()
        Me.btnscores = New System.Windows.Forms.Button()
        Me.lstplayerScores = New System.Windows.Forms.ListBox()
        Me.btncolorHistory = New System.Windows.Forms.Button()
        Me.lstcolorHistory = New System.Windows.Forms.ListBox()
        Me.btnplayerHistory = New System.Windows.Forms.Button()
        Me.lstplayerHistory = New System.Windows.Forms.ListBox()
        Me.lblHowColorsWork = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblHowTableWorks = New System.Windows.Forms.Label()
        Me.btnCopyTable = New System.Windows.Forms.Button()
        Me.lblLineInstructions = New System.Windows.Forms.Label()
        Me.txtRemovePlayer = New System.Windows.Forms.TextBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnPair = New System.Windows.Forms.Button()
        Me.btnAddNewPlayer = New System.Windows.Forms.Button()
        Me.lstCopiedPlayers = New System.Windows.Forms.ListBox()
        Me.txtAddNewPlayer = New System.Windows.Forms.TextBox()
        Me.tbaPlayerScores = New System.Windows.Forms.TabPage()
        Me.lblHowtoUseTab = New System.Windows.Forms.Label()
        Me.lblRoundButtonInstructions = New System.Windows.Forms.Label()
        Me.btnGetplayerscore = New System.Windows.Forms.Button()
        Me.lsttotalscores = New System.Windows.Forms.ListBox()
        Me.btnsaveScoresList = New System.Windows.Forms.Button()
        Me.btnCurrentRoundPlayers = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnaddByePlayer = New System.Windows.Forms.Button()
        Me.cmbByeScore = New System.Windows.Forms.ComboBox()
        Me.txtbyePlayer = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btncopiedRoundData = New System.Windows.Forms.Button()
        Me.lstcopiedRound = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBlackPoints = New System.Windows.Forms.ComboBox()
        Me.cmbWhitePoints = New System.Windows.Forms.ComboBox()
        Me.btnaddToDatabase = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBlackKey = New System.Windows.Forms.TextBox()
        Me.txtWhiteKey = New System.Windows.Forms.TextBox()
        Me.tbaOverview = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.Btnclearalldata = New System.Windows.Forms.Button()
        Me.lblTournamentOverview = New System.Windows.Forms.Label()
        Me.lstallplayers = New System.Windows.Forms.ListBox()
        Me.btngetallplayers = New System.Windows.Forms.Button()
        Me.btngetscores = New System.Windows.Forms.Button()
        Me.lstOverview = New System.Windows.Forms.ListBox()
        Me.tabPlayerinput.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tbaPlayerinput.SuspendLayout()
        Me.tbaPlayerScores.SuspendLayout()
        Me.tbaOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPlayerinput
        '
        Me.tabPlayerinput.Controls.Add(Me.TabPage2)
        Me.tabPlayerinput.Controls.Add(Me.tbaPlayerinput)
        Me.tabPlayerinput.Controls.Add(Me.tbaPlayerScores)
        Me.tabPlayerinput.Controls.Add(Me.tbaOverview)
        Me.tabPlayerinput.Location = New System.Drawing.Point(2, 2)
        Me.tabPlayerinput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabPlayerinput.Name = "tabPlayerinput"
        Me.tabPlayerinput.SelectedIndex = 0
        Me.tabPlayerinput.Size = New System.Drawing.Size(739, 340)
        Me.tabPlayerinput.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblcreateround)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnRead)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.btnSaveList)
        Me.TabPage2.Controls.Add(Me.lblEnterAllPlayers)
        Me.TabPage2.Controls.Add(Me.lblAddPlayerSeededOrder)
        Me.TabPage2.Controls.Add(Me.txtEnterPlayerName)
        Me.TabPage2.Controls.Add(Me.btnRemoveMostRecent)
        Me.TabPage2.Controls.Add(Me.btnAddInOrder)
        Me.TabPage2.Controls.Add(Me.lstPlayers)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(731, 314)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "All players"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblcreateround
        '
        Me.lblcreateround.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreateround.Location = New System.Drawing.Point(114, 134)
        Me.lblcreateround.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreateround.Name = "lblcreateround"
        Me.lblcreateround.Size = New System.Drawing.Size(95, 70)
        Me.lblcreateround.TabIndex = 10
        Me.lblcreateround.Text = "Go on the create round tab"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 263)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Use this button to get back the saved data"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(9, 278)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(94, 29)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read from file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 209)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 7
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(6, 209)
        Me.btnSaveList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(96, 29)
        Me.btnSaveList.TabIndex = 4
        Me.btnSaveList.Text = "Save List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'lblEnterAllPlayers
        '
        Me.lblEnterAllPlayers.AutoSize = True
        Me.lblEnterAllPlayers.Location = New System.Drawing.Point(52, 41)
        Me.lblEnterAllPlayers.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnterAllPlayers.Name = "lblEnterAllPlayers"
        Me.lblEnterAllPlayers.Size = New System.Drawing.Size(244, 13)
        Me.lblEnterAllPlayers.TabIndex = 10
        Me.lblEnterAllPlayers.Text = "Enter all players that will ever play in the tourament"
        '
        'lblAddPlayerSeededOrder
        '
        Me.lblAddPlayerSeededOrder.AutoSize = True
        Me.lblAddPlayerSeededOrder.Location = New System.Drawing.Point(52, 10)
        Me.lblAddPlayerSeededOrder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddPlayerSeededOrder.Name = "lblAddPlayerSeededOrder"
        Me.lblAddPlayerSeededOrder.Size = New System.Drawing.Size(281, 13)
        Me.lblAddPlayerSeededOrder.TabIndex = 10
        Me.lblAddPlayerSeededOrder.Text = "Add players in seeded order below ( Strongest to weakest)"
        '
        'txtEnterPlayerName
        '
        Me.txtEnterPlayerName.Location = New System.Drawing.Point(4, 63)
        Me.txtEnterPlayerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEnterPlayerName.MaxLength = 24
        Me.txtEnterPlayerName.Name = "txtEnterPlayerName"
        Me.txtEnterPlayerName.Size = New System.Drawing.Size(97, 20)
        Me.txtEnterPlayerName.TabIndex = 1
        '
        'btnRemoveMostRecent
        '
        Me.btnRemoveMostRecent.Location = New System.Drawing.Point(7, 122)
        Me.btnRemoveMostRecent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemoveMostRecent.Name = "btnRemoveMostRecent"
        Me.btnRemoveMostRecent.Size = New System.Drawing.Size(96, 70)
        Me.btnRemoveMostRecent.TabIndex = 3
        Me.btnRemoveMostRecent.Text = "Remove most recent player"
        Me.btnRemoveMostRecent.UseVisualStyleBackColor = True
        '
        'btnAddInOrder
        '
        Me.btnAddInOrder.Location = New System.Drawing.Point(104, 58)
        Me.btnAddInOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddInOrder.Name = "btnAddInOrder"
        Me.btnAddInOrder.Size = New System.Drawing.Size(137, 45)
        Me.btnAddInOrder.TabIndex = 2
        Me.btnAddInOrder.Text = "Add player in seeded order"
        Me.btnAddInOrder.UseVisualStyleBackColor = True
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.Location = New System.Drawing.Point(246, 58)
        Me.lstPlayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(468, 238)
        Me.lstPlayers.TabIndex = 0
        '
        'tbaPlayerinput
        '
        Me.tbaPlayerinput.Controls.Add(Me.lbladdscores)
        Me.tbaPlayerinput.Controls.Add(Me.lblRoundInstructions)
        Me.tbaPlayerinput.Controls.Add(Me.lblHowRoundsWork)
        Me.tbaPlayerinput.Controls.Add(Me.btnscores)
        Me.tbaPlayerinput.Controls.Add(Me.lstplayerScores)
        Me.tbaPlayerinput.Controls.Add(Me.btncolorHistory)
        Me.tbaPlayerinput.Controls.Add(Me.lstcolorHistory)
        Me.tbaPlayerinput.Controls.Add(Me.btnplayerHistory)
        Me.tbaPlayerinput.Controls.Add(Me.lstplayerHistory)
        Me.tbaPlayerinput.Controls.Add(Me.lblHowColorsWork)
        Me.tbaPlayerinput.Controls.Add(Me.Label12)
        Me.tbaPlayerinput.Controls.Add(Me.lblHowTableWorks)
        Me.tbaPlayerinput.Controls.Add(Me.btnCopyTable)
        Me.tbaPlayerinput.Controls.Add(Me.lblLineInstructions)
        Me.tbaPlayerinput.Controls.Add(Me.txtRemovePlayer)
        Me.tbaPlayerinput.Controls.Add(Me.BtnRemove)
        Me.tbaPlayerinput.Controls.Add(Me.BtnPair)
        Me.tbaPlayerinput.Controls.Add(Me.btnAddNewPlayer)
        Me.tbaPlayerinput.Controls.Add(Me.lstCopiedPlayers)
        Me.tbaPlayerinput.Controls.Add(Me.txtAddNewPlayer)
        Me.tbaPlayerinput.Location = New System.Drawing.Point(4, 22)
        Me.tbaPlayerinput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbaPlayerinput.Name = "tbaPlayerinput"
        Me.tbaPlayerinput.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbaPlayerinput.Size = New System.Drawing.Size(731, 314)
        Me.tbaPlayerinput.TabIndex = 0
        Me.tbaPlayerinput.Text = "Create round"
        Me.tbaPlayerinput.UseVisualStyleBackColor = True
        '
        'lbladdscores
        '
        Me.lbladdscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdscores.Location = New System.Drawing.Point(204, 86)
        Me.lbladdscores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbladdscores.Name = "lbladdscores"
        Me.lbladdscores.Size = New System.Drawing.Size(137, 81)
        Me.lbladdscores.TabIndex = 20
        Me.lbladdscores.Text = "Go to the add scores tab"
        '
        'lblRoundInstructions
        '
        Me.lblRoundInstructions.Location = New System.Drawing.Point(220, 44)
        Me.lblRoundInstructions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoundInstructions.Name = "lblRoundInstructions"
        Me.lblRoundInstructions.Size = New System.Drawing.Size(121, 59)
        Me.lblRoundInstructions.TabIndex = 19
        Me.lblRoundInstructions.Text = "All players in the player list on this list plays in the round"
        '
        'lblHowRoundsWork
        '
        Me.lblHowRoundsWork.Location = New System.Drawing.Point(220, 172)
        Me.lblHowRoundsWork.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowRoundsWork.Name = "lblHowRoundsWork"
        Me.lblHowRoundsWork.Size = New System.Drawing.Size(110, 121)
        Me.lblHowRoundsWork.TabIndex = 18
        Me.lblHowRoundsWork.Text = "If this is the first round only click get all players button if this is not the f" &
    "irst round then click the 3 buttons below the list box and the get all players."
        '
        'btnscores
        '
        Me.btnscores.Location = New System.Drawing.Point(664, 271)
        Me.btnscores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnscores.Name = "btnscores"
        Me.btnscores.Size = New System.Drawing.Size(64, 41)
        Me.btnscores.TabIndex = 9
        Me.btnscores.Text = "Get player scores"
        Me.btnscores.UseVisualStyleBackColor = True
        '
        'lstplayerScores
        '
        Me.lstplayerScores.FormattingEnabled = True
        Me.lstplayerScores.Location = New System.Drawing.Point(664, 42)
        Me.lstplayerScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstplayerScores.Name = "lstplayerScores"
        Me.lstplayerScores.Size = New System.Drawing.Size(65, 225)
        Me.lstplayerScores.TabIndex = 16
        '
        'btncolorHistory
        '
        Me.btncolorHistory.Location = New System.Drawing.Point(596, 270)
        Me.btncolorHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncolorHistory.Name = "btncolorHistory"
        Me.btncolorHistory.Size = New System.Drawing.Size(63, 43)
        Me.btncolorHistory.TabIndex = 8
        Me.btncolorHistory.Text = "Get color history"
        Me.btncolorHistory.UseVisualStyleBackColor = True
        '
        'lstcolorHistory
        '
        Me.lstcolorHistory.FormattingEnabled = True
        Me.lstcolorHistory.Location = New System.Drawing.Point(596, 43)
        Me.lstcolorHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstcolorHistory.Name = "lstcolorHistory"
        Me.lstcolorHistory.Size = New System.Drawing.Size(64, 225)
        Me.lstcolorHistory.TabIndex = 14
        '
        'btnplayerHistory
        '
        Me.btnplayerHistory.Location = New System.Drawing.Point(526, 271)
        Me.btnplayerHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnplayerHistory.Name = "btnplayerHistory"
        Me.btnplayerHistory.Size = New System.Drawing.Size(64, 42)
        Me.btnplayerHistory.TabIndex = 7
        Me.btnplayerHistory.Text = "Get player history"
        Me.btnplayerHistory.UseVisualStyleBackColor = True
        '
        'lstplayerHistory
        '
        Me.lstplayerHistory.FormattingEnabled = True
        Me.lstplayerHistory.Location = New System.Drawing.Point(527, 43)
        Me.lstplayerHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstplayerHistory.Name = "lstplayerHistory"
        Me.lstplayerHistory.Size = New System.Drawing.Size(65, 225)
        Me.lstplayerHistory.TabIndex = 12
        '
        'lblHowColorsWork
        '
        Me.lblHowColorsWork.Location = New System.Drawing.Point(8, 278)
        Me.lblHowColorsWork.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowColorsWork.Name = "lblHowColorsWork"
        Me.lblHowColorsWork.Size = New System.Drawing.Size(196, 34)
        Me.lblHowColorsWork.TabIndex = 10
        Me.lblHowColorsWork.Text = "Player on left of the list plays white player on the right of the list plays blac" &
    "k"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "LIST STARTS AT LINE 1"
        '
        'lblHowTableWorks
        '
        Me.lblHowTableWorks.Location = New System.Drawing.Point(229, 2)
        Me.lblHowTableWorks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowTableWorks.Name = "lblHowTableWorks"
        Me.lblHowTableWorks.Size = New System.Drawing.Size(232, 37)
        Me.lblHowTableWorks.TabIndex = 10
        Me.lblHowTableWorks.Text = "Table below should show how many people are going to play in the round"
        '
        'btnCopyTable
        '
        Me.btnCopyTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyTable.Location = New System.Drawing.Point(10, 15)
        Me.btnCopyTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCopyTable.Name = "btnCopyTable"
        Me.btnCopyTable.Size = New System.Drawing.Size(189, 46)
        Me.btnCopyTable.TabIndex = 1
        Me.btnCopyTable.Text = "Get all players"
        Me.btnCopyTable.UseVisualStyleBackColor = True
        '
        'lblLineInstructions
        '
        Me.lblLineInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineInstructions.Location = New System.Drawing.Point(120, 128)
        Me.lblLineInstructions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineInstructions.Name = "lblLineInstructions"
        Me.lblLineInstructions.Size = New System.Drawing.Size(80, 98)
        Me.lblLineInstructions.TabIndex = 10
        Me.lblLineInstructions.Text = "Specify the line to which to remove your player list starts at line 1"
        '
        'txtRemovePlayer
        '
        Me.txtRemovePlayer.Location = New System.Drawing.Point(10, 208)
        Me.txtRemovePlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRemovePlayer.MaxLength = 2
        Me.txtRemovePlayer.Name = "txtRemovePlayer"
        Me.txtRemovePlayer.Size = New System.Drawing.Size(106, 20)
        Me.txtRemovePlayer.TabIndex = 5
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(10, 128)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(105, 68)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "Remove Player"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnPair
        '
        Me.BtnPair.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPair.Location = New System.Drawing.Point(10, 232)
        Me.BtnPair.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPair.Name = "BtnPair"
        Me.BtnPair.Size = New System.Drawing.Size(189, 44)
        Me.BtnPair.TabIndex = 6
        Me.BtnPair.Text = "Pair for round"
        Me.BtnPair.UseVisualStyleBackColor = True
        '
        'btnAddNewPlayer
        '
        Me.btnAddNewPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewPlayer.Location = New System.Drawing.Point(10, 67)
        Me.btnAddNewPlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddNewPlayer.Name = "btnAddNewPlayer"
        Me.btnAddNewPlayer.Size = New System.Drawing.Size(192, 37)
        Me.btnAddNewPlayer.TabIndex = 2
        Me.btnAddNewPlayer.Text = "Add New player "
        Me.btnAddNewPlayer.UseVisualStyleBackColor = True
        '
        'lstCopiedPlayers
        '
        Me.lstCopiedPlayers.FormattingEnabled = True
        Me.lstCopiedPlayers.Location = New System.Drawing.Point(347, 44)
        Me.lstCopiedPlayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstCopiedPlayers.Name = "lstCopiedPlayers"
        Me.lstCopiedPlayers.Size = New System.Drawing.Size(176, 264)
        Me.lstCopiedPlayers.TabIndex = 10
        '
        'txtAddNewPlayer
        '
        Me.txtAddNewPlayer.Location = New System.Drawing.Point(14, 108)
        Me.txtAddNewPlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAddNewPlayer.MaxLength = 24
        Me.txtAddNewPlayer.Name = "txtAddNewPlayer"
        Me.txtAddNewPlayer.Size = New System.Drawing.Size(190, 20)
        Me.txtAddNewPlayer.TabIndex = 3
        '
        'tbaPlayerScores
        '
        Me.tbaPlayerScores.Controls.Add(Me.lblHowtoUseTab)
        Me.tbaPlayerScores.Controls.Add(Me.lblRoundButtonInstructions)
        Me.tbaPlayerScores.Controls.Add(Me.btnGetplayerscore)
        Me.tbaPlayerScores.Controls.Add(Me.lsttotalscores)
        Me.tbaPlayerScores.Controls.Add(Me.btnsaveScoresList)
        Me.tbaPlayerScores.Controls.Add(Me.btnCurrentRoundPlayers)
        Me.tbaPlayerScores.Controls.Add(Me.lstScores)
        Me.tbaPlayerScores.Controls.Add(Me.btnaddByePlayer)
        Me.tbaPlayerScores.Controls.Add(Me.cmbByeScore)
        Me.tbaPlayerScores.Controls.Add(Me.txtbyePlayer)
        Me.tbaPlayerScores.Controls.Add(Me.Label14)
        Me.tbaPlayerScores.Controls.Add(Me.btncopiedRoundData)
        Me.tbaPlayerScores.Controls.Add(Me.lstcopiedRound)
        Me.tbaPlayerScores.Controls.Add(Me.Label7)
        Me.tbaPlayerScores.Controls.Add(Me.cmbBlackPoints)
        Me.tbaPlayerScores.Controls.Add(Me.cmbWhitePoints)
        Me.tbaPlayerScores.Controls.Add(Me.btnaddToDatabase)
        Me.tbaPlayerScores.Controls.Add(Me.Label5)
        Me.tbaPlayerScores.Controls.Add(Me.Label2)
        Me.tbaPlayerScores.Controls.Add(Me.Label3)
        Me.tbaPlayerScores.Controls.Add(Me.Label4)
        Me.tbaPlayerScores.Controls.Add(Me.txtBlackKey)
        Me.tbaPlayerScores.Controls.Add(Me.txtWhiteKey)
        Me.tbaPlayerScores.Location = New System.Drawing.Point(4, 22)
        Me.tbaPlayerScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbaPlayerScores.Name = "tbaPlayerScores"
        Me.tbaPlayerScores.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbaPlayerScores.Size = New System.Drawing.Size(731, 314)
        Me.tbaPlayerScores.TabIndex = 1
        Me.tbaPlayerScores.Text = "Add scores"
        Me.tbaPlayerScores.UseVisualStyleBackColor = True
        '
        'lblHowtoUseTab
        '
        Me.lblHowtoUseTab.Location = New System.Drawing.Point(14, 229)
        Me.lblHowtoUseTab.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowtoUseTab.Name = "lblHowtoUseTab"
        Me.lblHowtoUseTab.Size = New System.Drawing.Size(236, 65)
        Me.lblHowtoUseTab.TabIndex = 14
        Me.lblHowtoUseTab.Text = "Click this button once all players in the round has played then go back to the cr" &
    "eate round tab and click the get all players button and get player scores button" &
    "."
        '
        'lblRoundButtonInstructions
        '
        Me.lblRoundButtonInstructions.Location = New System.Drawing.Point(386, 5)
        Me.lblRoundButtonInstructions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoundButtonInstructions.Name = "lblRoundButtonInstructions"
        Me.lblRoundButtonInstructions.Size = New System.Drawing.Size(120, 102)
        Me.lblRoundButtonInstructions.TabIndex = 14
        Me.lblRoundButtonInstructions.Text = "If this is first round click get round data and get all players. If not first rou" &
    "nd also click the get player scores button."
        '
        'btnGetplayerscore
        '
        Me.btnGetplayerscore.Location = New System.Drawing.Point(653, 273)
        Me.btnGetplayerscore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGetplayerscore.Name = "btnGetplayerscore"
        Me.btnGetplayerscore.Size = New System.Drawing.Size(74, 34)
        Me.btnGetplayerscore.TabIndex = 12
        Me.btnGetplayerscore.Text = "Get player scores"
        Me.btnGetplayerscore.UseVisualStyleBackColor = True
        '
        'lsttotalscores
        '
        Me.lsttotalscores.FormattingEnabled = True
        Me.lsttotalscores.Location = New System.Drawing.Point(653, 5)
        Me.lsttotalscores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lsttotalscores.Name = "lsttotalscores"
        Me.lsttotalscores.Size = New System.Drawing.Size(74, 264)
        Me.lsttotalscores.TabIndex = 23
        '
        'btnsaveScoresList
        '
        Me.btnsaveScoresList.Location = New System.Drawing.Point(80, 297)
        Me.btnsaveScoresList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsaveScoresList.Name = "btnsaveScoresList"
        Me.btnsaveScoresList.Size = New System.Drawing.Size(106, 19)
        Me.btnsaveScoresList.TabIndex = 9
        Me.btnsaveScoresList.Text = "Save scores list"
        Me.btnsaveScoresList.UseVisualStyleBackColor = True
        '
        'btnCurrentRoundPlayers
        '
        Me.btnCurrentRoundPlayers.Location = New System.Drawing.Point(511, 273)
        Me.btnCurrentRoundPlayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCurrentRoundPlayers.Name = "btnCurrentRoundPlayers"
        Me.btnCurrentRoundPlayers.Size = New System.Drawing.Size(138, 34)
        Me.btnCurrentRoundPlayers.TabIndex = 11
        Me.btnCurrentRoundPlayers.Text = "Get all players"
        Me.btnCurrentRoundPlayers.UseVisualStyleBackColor = True
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Location = New System.Drawing.Point(511, 5)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(139, 264)
        Me.lstScores.TabIndex = 20
        '
        'btnaddByePlayer
        '
        Me.btnaddByePlayer.Location = New System.Drawing.Point(190, 206)
        Me.btnaddByePlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnaddByePlayer.Name = "btnaddByePlayer"
        Me.btnaddByePlayer.Size = New System.Drawing.Size(64, 19)
        Me.btnaddByePlayer.TabIndex = 8
        Me.btnaddByePlayer.Text = "Add"
        Me.btnaddByePlayer.UseVisualStyleBackColor = True
        '
        'cmbByeScore
        '
        Me.cmbByeScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbByeScore.FormattingEnabled = True
        Me.cmbByeScore.Items.AddRange(New Object() {"0", "0.5", "1", "2", "3"})
        Me.cmbByeScore.Location = New System.Drawing.Point(91, 207)
        Me.cmbByeScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbByeScore.Name = "cmbByeScore"
        Me.cmbByeScore.Size = New System.Drawing.Size(92, 21)
        Me.cmbByeScore.TabIndex = 7
        '
        'txtbyePlayer
        '
        Me.txtbyePlayer.Location = New System.Drawing.Point(16, 207)
        Me.txtbyePlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbyePlayer.Name = "txtbyePlayer"
        Me.txtbyePlayer.Size = New System.Drawing.Size(72, 20)
        Me.txtbyePlayer.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 150)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(239, 55)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Enter player key below if player got a bye"
        '
        'btncopiedRoundData
        '
        Me.btncopiedRoundData.Location = New System.Drawing.Point(260, 273)
        Me.btncopiedRoundData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncopiedRoundData.Name = "btncopiedRoundData"
        Me.btncopiedRoundData.Size = New System.Drawing.Size(247, 34)
        Me.btncopiedRoundData.TabIndex = 10
        Me.btncopiedRoundData.Text = "Get round data from file"
        Me.btncopiedRoundData.UseVisualStyleBackColor = True
        '
        'lstcopiedRound
        '
        Me.lstcopiedRound.FormattingEnabled = True
        Me.lstcopiedRound.Location = New System.Drawing.Point(260, 109)
        Me.lstcopiedRound.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstcopiedRound.Name = "lstcopiedRound"
        Me.lstcopiedRound.Size = New System.Drawing.Size(248, 160)
        Me.lstcopiedRound.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Enter player number in text boxes"
        '
        'cmbBlackPoints
        '
        Me.cmbBlackPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlackPoints.FormattingEnabled = True
        Me.cmbBlackPoints.Items.AddRange(New Object() {"0", "0.5", "1", "2", "3"})
        Me.cmbBlackPoints.Location = New System.Drawing.Point(209, 76)
        Me.cmbBlackPoints.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbBlackPoints.Name = "cmbBlackPoints"
        Me.cmbBlackPoints.Size = New System.Drawing.Size(92, 21)
        Me.cmbBlackPoints.TabIndex = 3
        '
        'cmbWhitePoints
        '
        Me.cmbWhitePoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWhitePoints.FormattingEnabled = True
        Me.cmbWhitePoints.Items.AddRange(New Object() {"0", "0.5", "1", "2", "3"})
        Me.cmbWhitePoints.Location = New System.Drawing.Point(95, 76)
        Me.cmbWhitePoints.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbWhitePoints.Name = "cmbWhitePoints"
        Me.cmbWhitePoints.Size = New System.Drawing.Size(92, 21)
        Me.cmbWhitePoints.TabIndex = 2
        '
        'btnaddToDatabase
        '
        Me.btnaddToDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddToDatabase.Location = New System.Drawing.Point(16, 100)
        Me.btnaddToDatabase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnaddToDatabase.Name = "btnaddToDatabase"
        Me.btnaddToDatabase.Size = New System.Drawing.Size(239, 47)
        Me.btnaddToDatabase.TabIndex = 5
        Me.btnaddToDatabase.Text = "Add to list"
        Me.btnaddToDatabase.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Black player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "White player"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "points"
        '
        'txtBlackKey
        '
        Me.txtBlackKey.Location = New System.Drawing.Point(304, 76)
        Me.txtBlackKey.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBlackKey.MaxLength = 2
        Me.txtBlackKey.Name = "txtBlackKey"
        Me.txtBlackKey.Size = New System.Drawing.Size(76, 20)
        Me.txtBlackKey.TabIndex = 4
        '
        'txtWhiteKey
        '
        Me.txtWhiteKey.Location = New System.Drawing.Point(16, 77)
        Me.txtWhiteKey.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWhiteKey.MaxLength = 2
        Me.txtWhiteKey.Name = "txtWhiteKey"
        Me.txtWhiteKey.Size = New System.Drawing.Size(76, 20)
        Me.txtWhiteKey.TabIndex = 1
        '
        'tbaOverview
        '
        Me.tbaOverview.Controls.Add(Me.Label1)
        Me.tbaOverview.Controls.Add(Me.btnExit)
        Me.tbaOverview.Controls.Add(Me.lblReset)
        Me.tbaOverview.Controls.Add(Me.Btnclearalldata)
        Me.tbaOverview.Controls.Add(Me.lblTournamentOverview)
        Me.tbaOverview.Controls.Add(Me.lstallplayers)
        Me.tbaOverview.Controls.Add(Me.btngetallplayers)
        Me.tbaOverview.Controls.Add(Me.btngetscores)
        Me.tbaOverview.Controls.Add(Me.lstOverview)
        Me.tbaOverview.Location = New System.Drawing.Point(4, 22)
        Me.tbaOverview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbaOverview.Name = "tbaOverview"
        Me.tbaOverview.Size = New System.Drawing.Size(731, 314)
        Me.tbaOverview.TabIndex = 4
        Me.tbaOverview.Text = "Overview"
        Me.tbaOverview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(660, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Even if the program is closed all information will be saved"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(659, 277)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 34)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblReset
        '
        Me.lblReset.Location = New System.Drawing.Point(170, 200)
        Me.lblReset.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(155, 75)
        Me.lblReset.TabIndex = 6
        Me.lblReset.Text = "Use this button if you want to create a new tournament and reset this one. ONCE D" &
    "ATA IS DELETED IT CAN NOT BE GOTTEN BACK."
        '
        'Btnclearalldata
        '
        Me.Btnclearalldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclearalldata.Location = New System.Drawing.Point(170, 276)
        Me.Btnclearalldata.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btnclearalldata.Name = "Btnclearalldata"
        Me.Btnclearalldata.Size = New System.Drawing.Size(156, 34)
        Me.Btnclearalldata.TabIndex = 5
        Me.Btnclearalldata.Text = "Clear all data"
        Me.Btnclearalldata.UseVisualStyleBackColor = True
        '
        'lblTournamentOverview
        '
        Me.lblTournamentOverview.Location = New System.Drawing.Point(170, 119)
        Me.lblTournamentOverview.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTournamentOverview.Name = "lblTournamentOverview"
        Me.lblTournamentOverview.Size = New System.Drawing.Size(158, 76)
        Me.lblTournamentOverview.TabIndex = 4
        Me.lblTournamentOverview.Text = "Use this section when tournament is finished to see who scored what amount of poi" &
    "nts or use this midway through the tournament to see how each player is doing."
        '
        'lstallplayers
        '
        Me.lstallplayers.FormattingEnabled = True
        Me.lstallplayers.Location = New System.Drawing.Point(332, 8)
        Me.lstallplayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstallplayers.Name = "lstallplayers"
        Me.lstallplayers.Size = New System.Drawing.Size(321, 303)
        Me.lstallplayers.TabIndex = 3
        '
        'btngetallplayers
        '
        Me.btngetallplayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetallplayers.Location = New System.Drawing.Point(170, 46)
        Me.btngetallplayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btngetallplayers.Name = "btngetallplayers"
        Me.btngetallplayers.Size = New System.Drawing.Size(158, 71)
        Me.btngetallplayers.TabIndex = 2
        Me.btngetallplayers.Text = "Get all players"
        Me.btngetallplayers.UseVisualStyleBackColor = True
        '
        'btngetscores
        '
        Me.btngetscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetscores.Location = New System.Drawing.Point(170, 8)
        Me.btngetscores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btngetscores.Name = "btngetscores"
        Me.btngetscores.Size = New System.Drawing.Size(158, 35)
        Me.btngetscores.TabIndex = 1
        Me.btngetscores.Text = "Get scores"
        Me.btngetscores.UseVisualStyleBackColor = True
        '
        'lstOverview
        '
        Me.lstOverview.FormattingEnabled = True
        Me.lstOverview.Location = New System.Drawing.Point(8, 8)
        Me.lstOverview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstOverview.Name = "lstOverview"
        Me.lstOverview.Size = New System.Drawing.Size(158, 303)
        Me.lstOverview.TabIndex = 0
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 349)
        Me.Controls.Add(Me.tabPlayerinput)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "form1"
        Me.Text = "Chess tournament manager"
        Me.tabPlayerinput.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tbaPlayerinput.ResumeLayout(False)
        Me.tbaPlayerinput.PerformLayout()
        Me.tbaPlayerScores.ResumeLayout(False)
        Me.tbaPlayerScores.PerformLayout()
        Me.tbaOverview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPlayerinput As TabControl
    Friend WithEvents tbaPlayerScores As TabPage
    Friend WithEvents tbaPlayerinput As TabPage
    Friend WithEvents btnAddNewPlayer As Button
    Friend WithEvents lstCopiedPlayers As ListBox
    Friend WithEvents txtAddNewPlayer As TextBox
    Friend WithEvents btnaddToDatabase As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBlackKey As TextBox
    Friend WithEvents txtWhiteKey As TextBox
    Friend WithEvents BtnPair As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents lblLineInstructions As Label
    Friend WithEvents txtRemovePlayer As TextBox
    Friend WithEvents cmbBlackPoints As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblEnterAllPlayers As Label
    Friend WithEvents lblAddPlayerSeededOrder As Label
    Friend WithEvents txtEnterPlayerName As TextBox
    Friend WithEvents btnRemoveMostRecent As Button
    Friend WithEvents btnAddInOrder As Button
    Friend WithEvents lstPlayers As ListBox
    Friend WithEvents btnCopyTable As Button
    Friend WithEvents btnSaveList As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRead As Button
    Friend WithEvents lblHowTableWorks As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblHowColorsWork As Label
    Friend WithEvents btncopiedRoundData As Button
    Friend WithEvents lstcopiedRound As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbyePlayer As TextBox
    Friend WithEvents cmbByeScore As ComboBox
    Friend WithEvents btnaddByePlayer As Button
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnCurrentRoundPlayers As Button
    Friend WithEvents btnsaveScoresList As Button
    Friend WithEvents lstplayerHistory As ListBox
    Friend WithEvents btnplayerHistory As Button
    Friend WithEvents lstcolorHistory As ListBox
    Friend WithEvents lstplayerScores As ListBox
    Friend WithEvents btnscores As Button
    Friend WithEvents btncolorHistory As Button
    Friend WithEvents btnGetplayerscore As Button
    Friend WithEvents lsttotalscores As ListBox
    Friend WithEvents lblcreateround As Label
    Friend WithEvents lblHowRoundsWork As Label
    Friend WithEvents lblRoundButtonInstructions As Label
    Friend WithEvents lblRoundInstructions As Label
    Friend WithEvents lblHowtoUseTab As Label
    Friend WithEvents lbladdscores As Label
    Friend WithEvents tbaOverview As TabPage
    Friend WithEvents lstallplayers As ListBox
    Friend WithEvents btngetallplayers As Button
    Friend WithEvents btngetscores As Button
    Friend WithEvents lstOverview As ListBox
    Friend WithEvents lblTournamentOverview As Label
    Friend WithEvents Btnclearalldata As Button
    Friend WithEvents lblReset As Label
    Private WithEvents cmbWhitePoints As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
