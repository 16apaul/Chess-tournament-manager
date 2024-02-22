Imports System.IO

Public Class form1
    Dim uniqueId As Integer = 1 ' keeps track of how many people play in whole the tournament 
    Dim tempuniqueid As Integer ' keeps track of how many players play in the current round

    'this needs to be global as different parts of the program will use this counter to know how many players are in the tournament.
    'assigns them a number

    'Adds a unique id to a player name
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' these buttons and lables will show once the user clicked certain buttons to guide them
        lblcreateround.Hide()
        lbladdscores.Hide()
        btnSaveList.Hide()

    End Sub
    Sub Listtoarray(listbox, array) 'puts contents of list box to an array

        For i = 0 To listbox.Items.Count - 1
            array(i) = listbox.Items.Item(i)


        Next

    End Sub
    Sub Writefile(filename As String, listbox As Object) ' writes data from listbox to file

        FileOpen(1, Path.Combine(Application.StartupPath, filename), OpenMode.Output)

        For counter = 0 To listbox.Items.Count - 1
            PrintLine(1, listbox.Items.Item(counter))
        Next
        FileClose(1)

    End Sub
    Sub Readfile(filename As String, listbox As Object) ' this subroutine reads from a file and outsputs the data to a list box
        listbox.Items.Clear()
        FileOpen(1, Path.Combine(Application.StartupPath, filename), OpenMode.Input)
        While Not EOF(1)
            listbox.Items.Add(LineInput(1))


        End While
        FileClose(1)
    End Sub
    Sub Clearfile(filename As String) 'subroutine to clear files 

        FileOpen(1, Path.Combine(Application.StartupPath, filename), OpenMode.Output)

        FileClose(1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddNewPlayer.Click


        Dim newPlayer As String = txtAddNewPlayer.Text + " (" + uniqueId.ToString + ")" ' every player needs a uniwue id to their name
        Dim filename_savedData As String ' how the players data is stores
        Dim file_playerscores As String 'the score of the new player will be 0
        Dim newScore As String ' shows to the user the score will be 0

        If txtAddNewPlayer.Text.Contains("1") Or txtAddNewPlayer.Text.Contains("2") Or txtAddNewPlayer.Text.Contains("3") Or txtAddNewPlayer.Text.Contains("4") Or txtAddNewPlayer.Text.Contains("5") Or txtAddNewPlayer.Text.Contains("6") Or txtAddNewPlayer.Text.Contains("7") Or txtAddNewPlayer.Text.Contains("8") Or txtAddNewPlayer.Text.Contains("9") Or txtAddNewPlayer.Text.Contains("0") Then ' error trapping to make sure user does not enter number
            MessageBox.Show("Make sure to not enter number")

        Else
            If lstCopiedPlayers.Items.Count = 0 Then ' Error trapping to check if the user clicked the get all players button
                MessageBox.Show("Please click the get all players button or go to the all players tab and save list.")
            ElseIf IsNumeric(txtAddNewPlayer.Text) Then
                MessageBox.Show("Make sure to not enter number")
            Else
                tempuniqueid += 1
                lstCopiedPlayers.Items.Add(txtAddNewPlayer.Text + " (" + uniqueId.ToString + ")")
                If lstplayerScores.Items.Count = 0 Then

                Else
                    lstplayerScores.Items.Add(uniqueId.ToString + ")" + "0") ' new players that join midway through the tornament will have 0 points


                    newScore = uniqueId.ToString + ")0"
                    file_playerscores = Path.Combine(Application.StartupPath, "Scores.txt")

                    FileOpen(1, file_playerscores, OpenMode.Append)
                    PrintLine(1, newScore)
                    FileClose(1)


                End If
            End If
            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")


            FileOpen(1, filename_savedData, OpenMode.Append)
            PrintLine(1, newPlayer)
            FileClose(1)

            uniqueId += 1

        End If


    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddInOrder.Click

        'every time this button is click it adds 1 to unique id and saves it
        'it also outuputs all the players in the list box provided.
        btnSaveList.Show()
        If txtEnterPlayerName.Text.Contains("1") Or txtEnterPlayerName.Text.Contains("2") Or txtEnterPlayerName.Text.Contains("3") Or txtEnterPlayerName.Text.Contains("4") Or txtEnterPlayerName.Text.Contains("5") Or txtEnterPlayerName.Text.Contains("6") Or txtEnterPlayerName.Text.Contains("7") Or txtEnterPlayerName.Text.Contains("8") Or txtEnterPlayerName.Text.Contains("9") Or txtEnterPlayerName.Text.Contains("0") Then 'error trapping so user cant enter number and text
            MessageBox.Show("Make sure the text box above has no numbers ")

        Else

            If IsNumeric(txtEnterPlayerName.Text) Then 'validation check
                MessageBox.Show("Make sure the text box above has no numbers ")
            Else
                lstPlayers.Items.Add(txtEnterPlayerName.Text + " (" + uniqueId.ToString + ")")
                uniqueId += 1
                txtEnterPlayerName.Clear()
            End If
        End If
    End Sub

    Private Sub btnRemoveMostRecent_Click(sender As Object, e As EventArgs) Handles btnRemoveMostRecent.Click
        ' everytime this button is clicked it removes 1 from player id and saves it also it remove the most recent item in the list box
        If lstPlayers.Items.Count = 0 Then
            MessageBox.Show("Please make sure there are players in the list box to remove.")
        Else
            If uniqueId > 0 Then
                lstPlayers.Items.RemoveAt(uniqueId - 2)
                uniqueId -= 1
            End If
        End If
    End Sub

    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click


        If lstPlayers.Items.Count = 0 Then
            MessageBox.Show("Please enter some players")
        Else
            'user can not edit players once list is saved
            txtEnterPlayerName.Hide()
            btnAddInOrder.Hide()
            btnRemoveMostRecent.Hide()
            lblcreateround.Show()
        End If


        Dim TotalPlayers As Integer 'shows all players playing in the tournament
        TotalPlayers = lstPlayers.Items.Count
        Dim players(TotalPlayers - 1) As String
        'makes the array the exact same length as the number of people in the tournament


        ' code below assigns each row with the appropiate array value so the array value is the same as the unique id

        For Counter = 0 To lstPlayers.Items.Count - 1
            players(Counter) = lstPlayers.Items.Item(Counter)
        Next

        ' next line of code outputs whole contents of player(counter) in files
        Writefile("Players.txt", lstPlayers)


    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim filename_savedData As String ' the file shows all players playing in the tournament
        Dim totalPlayers As Integer ' shows all players playing in the tournament
        Dim counter As Integer = 0
        If lstPlayers.Items.Count = 0 Then
            MessageBox.Show("Please enter some players before saving")
        Else
            txtEnterPlayerName.Hide()
            btnAddInOrder.Hide()
            btnRemoveMostRecent.Hide()
            uniqueId = 1
            'code below adds one to the totalplayers variable so i know how long the array should be.
            'code below read the file and adds 1 to the total players variable everyline there is text
            'if the program is closed and starts up the program will know how many players are playing in the tournament

            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")
            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)

                LineInput(1)
                totalPlayers += 1
                uniqueId += 1 'if program is closed and then starts up again the value of unique id will not be lost 
            End While
            FileClose(1)

            Dim player(totalPlayers - 1) As String 'assigns the value to the array so array is the exact length as the 
            'Number of players in the tournament


            'code below assigns each line in the file to the array
            'since the array and file are the same length all avaliable space in the array should get filled
            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)
                player(counter) = LineInput(1)

                counter += 1
            End While
            FileClose(1)

            lstPlayers.Items.Clear()

            For i = 0 To player.Length - 1
                lstPlayers.Items.Add(player(i))

            Next
        End If


    End Sub

    Private Sub btnCopyTable_Click(sender As Object, e As EventArgs) Handles btnCopyTable.Click
        BtnPair.Show()
        lbladdscores.Hide()
        BtnRemove.Show()
        btnAddNewPlayer.Show()
        Dim filename_savedData As String ' file shows all players playing in the tournament 
        Dim totalPlayers As Integer ' all players playing in the game
        Dim counter As Integer = 0 ' to assign values to the array

        uniqueId = 1
        'code below adds one to totalplayers so i know how long the array should be

        filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")


        FileOpen(1, filename_savedData, OpenMode.Input)
        While Not EOF(1)

            LineInput(1)
            totalPlayers += 1
            uniqueId += 1 'if program is closed and then starts up again the value of unique id will not be lost 
        End While
        FileClose(1)
        tempuniqueid = uniqueId ' temp unique id will be unique id snce all players are starting to play in the tornament

        Dim player(totalPlayers - 1) As String 'assigns the value to the array so array is the exact length as the 
        'Number of players in the tournament


        'code below assigns each line in the file to the array
        'since the array and file are the same length all avaliable space in the array should get filled
        FileOpen(1, filename_savedData, OpenMode.Input)
        While Not EOF(1)
            player(counter) = LineInput(1)

            counter += 1
        End While
        FileClose(1)

        lstCopiedPlayers.Items.Clear()

        For i = 0 To player.Length - 1
            lstCopiedPlayers.Items.Add(player(i))

        Next

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If lstCopiedPlayers.Items.Count = 0 Or IsNothing(txtRemovePlayer.Text) Or Not IsNumeric(txtRemovePlayer.Text) Then ' validation checks
            MessageBox.Show("Make sure the you clicked Get all players and entered a number in the remove player box.")

        ElseIf txtRemovePlayer.Text < 1 Or txtRemovePlayer.Text > tempuniqueid - 1 Then
            MessageBox.Show("Please enter a number above 0 and below " & tempuniqueid & " to remove a player at that line")

        Else
            tempuniqueid -= 1

            lstCopiedPlayers.Items.RemoveAt(txtRemovePlayer.Text - 1) ' removes the player at the specified line

            If lstplayerScores.Items.Count = 0 Then ' only removes if there is something in the list box

            Else
                lstplayerScores.Items.RemoveAt(txtRemovePlayer.Text - 1)
            End If

        End If


    End Sub

    Private Sub BtnPair_Click(sender As Object, e As EventArgs) Handles BtnPair.Click
        If lstCopiedPlayers.Items.Count = 0 Then
            MessageBox.Show("make sure get all players button is clicked")

            Dim filename_savedData As String ' file is where all the player is stored
            Dim totalPlayers As Integer ' shows all players playing in the tournament

            Dim counter As Integer = 0 ' assigns values to the array

            uniqueId = 1
            'code below adds one to totalplayers so i know how long the array should be

            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")

            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)

                LineInput(1)
                totalPlayers += 1
            End While
            FileClose(1)

            Dim player(totalPlayers - 1) As String 'assigns the value to the array so array is the exact length as the 
            'Number of players in the tournament

            'code below assigns each line in the file to the array
            'since the array and file are the same length all avaliable space in the array should get filled

            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)
                player(counter) = LineInput(1)

                counter += 1
            End While
            FileClose(1)

            lstCopiedPlayers.Items.Clear()

            For i = 0 To player.Length - 1
                lstCopiedPlayers.Items.Add(player(i))

            Next


        Else
            lbladdscores.Show()
            BtnPair.Hide()
            BtnRemove.Hide()
            btnAddNewPlayer.Hide()


        End If
        If lstplayerHistory.Items.Count = 0 Or lstcolorHistory.Items.Count = 0 Or lstplayerScores.Items.Count = 0 Then


            Dim totalPlayers As Integer = lstCopiedPlayers.Items.Count - 1  'makes the array the same length as the players 
            Dim playerRound(totalPlayers) As String 'array for storing players playing in the round
            Dim uniqueID As Integer = 1 ' every player is given an ID
            Dim filename_savedData As String ' file for all players playing in the tournament

            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")


            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)

                LineInput(1)

                uniqueID += 1 'if program is closed and then starts up again the value of unique id will not be lost 
            End While
            FileClose(1)


            ' code below copies array to the list
            For i = 0 To lstCopiedPlayers.Items.Count - 1

                playerRound(i) = lstCopiedPlayers.Items.Item(i)


            Next

            Writefile("Players in round.txt", lstCopiedPlayers) ' copies the list to the file




            lstCopiedPlayers.Items.Clear()

            ' code below pairs first half with bottom half with the second half with each half alternating color

            If playerRound.Length Mod 2 = 0 Then ' this if statment is needed so if there is an odd number of players the last player gets a bye

                For i = 0 To (playerRound.Length / 2) - 1

                    ' this statment is needed so the code below alternates

                    If i Mod 2 = 0 Then
                        lstCopiedPlayers.Items.Add(playerRound(i) + " vs " + playerRound((playerRound.Length / 2) + i))

                    Else
                        lstCopiedPlayers.Items.Add(playerRound((playerRound.Length / 2) + i) + " vs " + playerRound(i))


                    End If
                Next
            Else
                For i = 0 To (playerRound.Length - 3) / 2
                    If i Mod 2 = 0 Then
                        lstCopiedPlayers.Items.Add(playerRound(i) + " vs " + playerRound(((playerRound.Length - 1) / 2) + i))

                    Else
                        lstCopiedPlayers.Items.Add(playerRound(((playerRound.Length - 1) / 2) + i) + " vs " + playerRound(i))
                    End If
                Next
                lstCopiedPlayers.Items.Add(playerRound(playerRound.Length - 1) + " gets a bye")
            End If


            ' makes a new file and outputs the value of the list to the file
            Writefile("Round.txt", lstCopiedPlayers)



            Dim filenameplayerHistory As String ' need to make a file that stores who plays who so same player does
            'not play same opponent twice

            filenameplayerHistory = Path.Combine(Application.StartupPath, "Player History.txt")


            ' code below will show 2 numbers a row and those numbers are the pairs of games people played
            If lstplayerHistory.Items.Count = 0 Then ' checks if list is empty 

                For counter = 0 To lstCopiedPlayers.Items.Count - 1 'first loop is supposed to go through each row of copied players list
                    Dim currentPlayerRow As String ' gets a specific row of the copied players table

                    currentPlayerRow = lstCopiedPlayers.Items.Item(counter)


                    For i = 0 To currentPlayerRow.Length - 4 ' Second loop goes through each character of the row and only ouputs the numbers

                        If IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(i + 1)) And IsNumeric(currentPlayerRow(currentPlayerRow.Length - 3)) And IsNumeric(currentPlayerRow.Chars(currentPlayerRow.Length - 2)) Then ' checks if there are 2 numbers next to each other at the beginning and at the end of the list


                            lstplayerHistory.Items.Add(currentPlayerRow.Substring(i, 2) + "v" + currentPlayerRow.Chars(currentPlayerRow.Length - 3) + currentPlayerRow(currentPlayerRow.Length - 2))
                            lstplayerHistory.Items.Add(currentPlayerRow.Chars(currentPlayerRow.Length - 3) + currentPlayerRow(currentPlayerRow.Length - 2) + "v" + currentPlayerRow.Substring(i, i))

                        ElseIf IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(i + 1)) Then
                            lstplayerHistory.Items.Add(currentPlayerRow.Substring(i, 2) + "v" + currentPlayerRow(currentPlayerRow.Length - 2))
                            lstplayerHistory.Items.Add(currentPlayerRow(currentPlayerRow.Length - 2) + "v" + currentPlayerRow.Substring(i, 2))

                        ElseIf IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(currentPlayerRow.Length - 3)) And IsNumeric(currentPlayerRow.Chars(currentPlayerRow.Length - 2)) Then
                            lstplayerHistory.Items.Add(currentPlayerRow.Chars(i) + "v" + currentPlayerRow.Chars(currentPlayerRow.Length - 3) + currentPlayerRow(currentPlayerRow.Length - 2))
                            lstplayerHistory.Items.Add(currentPlayerRow.Chars(currentPlayerRow.Length - 3) + currentPlayerRow(currentPlayerRow.Length - 2) + "v" + currentPlayerRow.Chars(i))

                        ElseIf IsNumeric(currentPlayerRow(i)) Then
                            If IsNumeric(currentPlayerRow(i - 1)) Then ' if statement here to check that number before is not an integer

                            Else
                                lstplayerHistory.Items.Add(currentPlayerRow.Chars(i) + "v" + currentPlayerRow(currentPlayerRow.Length - 2))
                                lstplayerHistory.Items.Add(currentPlayerRow(currentPlayerRow.Length - 2) + "v" + currentPlayerRow.Chars(i))

                            End If

                        End If

                    Next

                Next

                Writefile("Player history.txt", lstplayerHistory) ' copies data from the list to the file

            Else


            End If

            ' code below will show player id with color next to it
            If lstcolorHistory.Items.Count = 0 Then ' checks if list is empty 

                For counter = 0 To lstCopiedPlayers.Items.Count - 1 'first loop is supposed to go through each row of copied players list
                    Dim currentPlayerRow As String ' gets a specific row of the copied players table

                    currentPlayerRow = lstCopiedPlayers.Items.Item(counter)


                    For i = 0 To currentPlayerRow.Length - 4 ' Second loop goes through each character of the row and only ouputs the numbers

                        If IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(i + 1)) And IsNumeric(currentPlayerRow(currentPlayerRow.Length - 3)) And IsNumeric(currentPlayerRow.Chars(currentPlayerRow.Length - 2)) Then ' checks if there are 2 numbers next to each other at the beginning and at the end of the list


                            lstcolorHistory.Items.Add(currentPlayerRow.Substring(i, 2) + "W")
                            lstcolorHistory.Items.Add(currentPlayerRow(currentPlayerRow.Length - 3) + currentPlayerRow.Chars(currentPlayerRow.Length - 2) + "B")


                        ElseIf IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(i + 1)) And IsNumeric(currentPlayerRow.Chars(currentPlayerRow.Length - 2)) Then
                            lstcolorHistory.Items.Add(currentPlayerRow.Substring(i, 2) + "W")
                            lstcolorHistory.Items.Add(currentPlayerRow(currentPlayerRow.Length - 2) + "B")

                        ElseIf IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(currentPlayerRow.Length - 3)) And IsNumeric(currentPlayerRow.Chars(currentPlayerRow.Length - 2)) Then
                            lstcolorHistory.Items.Add(currentPlayerRow.Chars(i) + "W")
                            lstcolorHistory.Items.Add(currentPlayerRow.Chars(currentPlayerRow.Length - 3) + currentPlayerRow(currentPlayerRow.Length - 2) + "B")


                        ElseIf IsNumeric(currentPlayerRow(i)) And IsNumeric(currentPlayerRow(i + 1)) And currentPlayerRow(currentPlayerRow.Length - 2) = "y" Then ' to check if player got a bye
                            lstcolorHistory.Items.Add(currentPlayerRow(i) + currentPlayerRow(i + 1) + "y")

                        ElseIf IsNumeric(currentPlayerRow(i)) Then

                            If currentPlayerRow(currentPlayerRow.Length - 2) = "y" Then ' if stament to check if last player has a bye
                            Else
                                If IsNumeric(currentPlayerRow(i - 1)) Then ' if statement here to check that number before is not an integer

                                Else
                                    lstcolorHistory.Items.Add(currentPlayerRow.Chars(i) + "W")
                                    lstcolorHistory.Items.Add(currentPlayerRow(currentPlayerRow.Length - 2) + "B")



                                End If

                            End If

                        End If
                    Next
                Next

                Writefile("Color history.txt", lstcolorHistory)
            Else
            End If


        Else
            ' code below adds players score to the array and the index of the array is the id - 1
            Dim totalPlayers As String = lstplayerScores.Items.Count - 1
            Dim sortScores(totalPlayers) As String
            Dim players(totalPlayers) As String ' players playing in round
            Dim listRow As String

            For i = 0 To lstplayerScores.Items.Count - 1

                listRow = lstplayerScores.Items.Item(i)

                If IsNumeric(listRow.Last) And IsNumeric(listRow(listRow.Length - 2)) Then ' to check if player score is greater than 2 digits

                    sortScores(i) = listRow.Substring(listRow.Length - 2, 1) 'last item in the listrow is the score
                    players(i) = listRow.Substring(0, listRow.Count - 2) ' first item in the list row is the player id

                Else

                    sortScores(i) = listRow.Last 'last item in the listrow is the score

                    players(i) = listRow.Substring(0, listRow.Count - 1) ' first item in the list row is the player id

                End If

            Next

            ' code below sorts the scores and outputs them in order
            Dim temp As String ' temporarily stores the value getting swapped
            ' whenever the scores get swapped the id gets swapped this means that the scores will always be linked with the ids
            For ii = 0 To lstplayerScores.Items.Count - 2 ' need two loops to make sure everything gets swapped
                For i = 0 To lstplayerScores.Items.Count - 2

                    If sortScores(i) < sortScores(i + 1) Then

                        temp = sortScores(i)
                        sortScores(i) = sortScores(i + 1)
                        sortScores(i + 1) = temp
                        temp = players(i)
                        players(i) = players(i + 1)
                        players(i + 1) = temp


                    End If


                Next
            Next


            ' the way the list outputs data is that the number on the left is the player id and the number on the right is the points
            lstplayerScores.Items.Clear()

            For i = 0 To sortScores.Length - 1

                lstplayerScores.Items.Add(players(i) + sortScores(i))

            Next

            uniqueId = 1
            Dim total As Integer
            total = lstCopiedPlayers.Items.Count - 1
            Dim playersCurrentround(total) As String ' puts everyone playing in the round in an array
            Dim filename_savedData As String ' file where all the players playing in the tournament
            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")

            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)

                LineInput(1)

                uniqueId += 1 'if program is closed and then starts up again the value of unique id will not be lost 
            End While
            FileClose(1)
            Dim allplayers As String
            allplayers = uniqueId - 2
            Dim playerscores(total) As String ' puts everyone playing in the current tournament round in an array
            Listtoarray(lstCopiedPlayers, playersCurrentround)

            Listtoarray(lstplayerScores, playerscores)
            lstCopiedPlayers.Items.Clear()
            Dim playercolor As String ' stores the current player color
            'code below pairs the highest score with the second highest scores
            'code below pairs two peple with similar scores and makes sure that the colors alternate
            If playersCurrentround.Length Mod 2 = 0 Then ' to check if there is an odd or even number playing in the round


                For i = 0 To playerscores.Length - 2


                    If IsNumeric(playerscores(i).Substring(0, 2)) And IsNumeric(playerscores(i + 1).Substring(0, 2)) Then ' checks if first 2 characters are integeres and first 2 characters of the next array are integers
                        'code below checks if the player has played whit if they have that  player will play black
                        playercolor = playerscores(i).Substring(0, 2) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 2) + "v" + playerscores(i).Substring(0, 2))

                        Else

                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 2) + "v" + playerscores(i + 1).Substring(0, 2))

                        End If

                        i += 1

                    ElseIf IsNumeric(playerscores(i).Substring(0, 2)) And IsNumeric(playerscores(i + 1).First) Then ' checks if first 2 characters are integers and first character of the next item in the array is an integer
                        playercolor = playerscores(i).Substring(0, 2) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then

                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 1) + "v" + playerscores(i).Substring(0, 2))

                        Else

                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 2) + "v" + playerscores(i + 1).Substring(0, 1))

                        End If

                        i += 1
                    ElseIf IsNumeric(playerscores(i).First) And IsNumeric(playerscores(i + 1).Substring(0, 2)) Then
                        playercolor = playerscores(i).Substring(0, 1) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then

                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 2) + "v" + playerscores(i).Substring(0, 1))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 1) + "v" + playerscores(i + 1).Substring(0, 2))

                        End If

                        i += 1
                    ElseIf IsNumeric(playerscores(i).First) Then
                        playercolor = playerscores(i).Substring(0, 1) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 1) + "v" + playerscores(i).Substring(0, 1))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 1) + "v" + playerscores(i + 1).Substring(0, 1))

                        End If

                        i += 1


                    End If
                Next
            Else

                For i = 0 To playerscores.Length - 2


                    If IsNumeric(playerscores(i).Substring(0, 2)) And IsNumeric(playerscores(i + 1).Substring(0, 2)) Then ' checks if first 2 characters are integeres and first 2 characters of the next array are integers

                        playercolor = playerscores(i).Substring(0, 2) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 2) + "v" + playerscores(i).Substring(0, 2))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 2) + "v" + playerscores(i + 1).Substring(0, 2))

                        End If

                        i += 1

                    ElseIf IsNumeric(playerscores(i).Substring(0, 2)) And IsNumeric(playerscores(i + 1).First) Then ' checks if first 2 characters are integers and first character of the next item inn the array is an integer
                        playercolor = playerscores(i).Substring(0, 2) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 1) + "v" + playerscores(i).Substring(0, 2))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 2) + "v" + playerscores(i + 1).Substring(0, 1))

                        End If

                        i += 1
                    ElseIf IsNumeric(playerscores(i).First) And IsNumeric(playerscores(i + 1).First) And IsNumeric(playerscores(i + 1).Substring(1, 1)) Then
                        playercolor = playerscores(i).Substring(0, 1) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 2) + "v" + playerscores(i).Substring(0, 1))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 1) + "v" + playerscores(i + 1).Substring(0, 2))

                        End If

                        i += 1
                    ElseIf IsNumeric(playerscores(i).First) Then
                        playercolor = playerscores(i).Substring(0, 1) + "W"

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(i + 1).Substring(0, 1) + "v" + playerscores(i).Substring(0, 1))

                        Else
                            lstCopiedPlayers.Items.Add(playerscores(i).Substring(0, 1) + "v" + playerscores(i + 1).Substring(0, 1))

                        End If

                        i += 1


                    End If
                Next
                Dim l = 1 ' needed to give playes who have not got a bye a bye


                If IsNumeric(playerscores(playerscores.Length - 1).First) And IsNumeric(playerscores(playerscores.Length - 1).Substring(1, 1)) Then

                    playercolor = playerscores(playerscores.Length - 1).Substring(0, 2) + "vy"
                    Do While lstcolorHistory.Items.Contains(playercolor)

                        If lstcolorHistory.Items.Contains(playercolor) Then
                            lstCopiedPlayers.Items.Add(playerscores(playerscores.Length - l).Substring(0, 2) + "vy")
                            l -= 1
                        Else
                            lstCopiedPlayers.Items.Add(playerscores(playerscores.Length - 1).Substring(0, 2) + "vy")
                        End If
                    Loop
                Else
                    lstCopiedPlayers.Items.Add(playerscores(playerscores.Length - 1).Substring(0, 1) + "vy")

                End If

            End If

            ' code below saves all the information from the listbox to the round file  
            Writefile("Round.txt", lstCopiedPlayers)




            ' code below will give all the players the color they played last round
            lstcolorHistory.Items.Clear()
            Dim currentrow As String
            For i = 0 To lstCopiedPlayers.Items.Count - 1
                currentrow = lstCopiedPlayers.Items.Item(i)
                If IsNumeric(currentrow.Substring(0, 2)) And IsNumeric(currentrow.Substring(currentrow.Length - 2, 2)) Then

                    lstcolorHistory.Items.Add(currentrow.Substring(0, 2) + "W")
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 2, 2) + "B")

                ElseIf IsNumeric(currentrow.Substring(0, 2)) And IsNumeric(currentrow.Substring(currentrow.Length - 1, 1)) Then
                    lstcolorHistory.Items.Add(currentrow.Substring(0, 2) + "W")
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 1, 1) + "B")


                ElseIf IsNumeric(currentrow.Substring(0, 1)) And IsNumeric(currentrow.Substring(currentrow.Length - 2, 2)) Then
                    lstcolorHistory.Items.Add(currentrow.Substring(0, 1) + "W")
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 2, 2) + "B")
                ElseIf IsNumeric(currentrow.Substring(0, 1)) And IsNumeric(currentrow.Substring(currentrow.Length - 1, 1)) Then
                    lstcolorHistory.Items.Add(currentrow.Substring(0, 1) + "W")
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 1, 1) + "B")



                End If


            Next

            ' code below saves the information on who plays who so same player should not play twice

            For i = 0 To lstCopiedPlayers.Items.Count - 1

                currentrow = lstCopiedPlayers.Items(i)
                If IsNumeric(currentrow.Substring(0, 2)) And IsNumeric(currentrow.Substring(currentrow.Length - 2, 2)) Then
                    lstplayerHistory.Items.Add(currentrow)
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 2, 2) + "v" + currentrow.Substring(0, 2))


                ElseIf IsNumeric(currentrow.Substring(0, 2)) And IsNumeric(currentrow.Substring(currentrow.Length - 1, 1)) Then

                    lstplayerHistory.Items.Add(currentrow)
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 1, 1) + "v" + currentrow.Substring(0, 2))


                ElseIf IsNumeric(currentrow.Substring(0, 1)) And IsNumeric(currentrow.Substring(currentrow.Length - 2, 2)) Then

                    lstplayerHistory.Items.Add(currentrow)
                    lstcolorHistory.Items.Add(currentrow.Substring(currentrow.Length - 2, 2) + "v" + currentrow.Substring(0, 1))

                ElseIf IsNumeric(currentrow.Substring(0, 1)) And IsNumeric(currentrow.Substring(currentrow.Length - 1, 1)) Then

                    lstplayerHistory.Items.Add(currentrow)
                    lstplayerHistory.Items.Add(currentrow.Substring(currentrow.Length - 1, 1) + "v" + currentrow.Substring(0, 1))



                End If


            Next

            ' code below saves all the information(about player color and player history) to files

            Writefile("Color history.txt", lstcolorHistory)
            Writefile("Player history.txt", lstplayerHistory)


        End If
    End Sub



    Private Sub btncopiedRoundData_Click(sender As Object, e As EventArgs) Handles btncopiedRoundData.Click

        ' when this button is clicked all the information about the round gets outputted to a list box
        Readfile("Round.txt", lstcopiedRound)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnaddToDatabase.Click



        Dim currentRoundPlayers(lstScores.Items.Count - 1) As String
        Dim whiteKey As String ' unique id to represent a white player
        Dim blackKey As String ' unique id to represent a black player
        Dim whitePoints As String ' to store white player points
        Dim blackPoints As String ' to store black player points

        whiteKey = txtWhiteKey.Text
        blackKey = txtBlackKey.Text
        whitePoints = cmbWhitePoints.Text
        blackPoints = cmbBlackPoints.Text

        Dim filename_savedData As String ' file for all players playing in the tournament


        uniqueId = 0

        filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")


        FileOpen(1, filename_savedData, OpenMode.Input)
        While Not EOF(1)

            LineInput(1)

            uniqueId += 1 'if program is closed and then starts up again the value of unique id will not be lost 
        End While
        FileClose(1)

        If lstcopiedRound.Items.Count = 0 Or lstScores.Items.Count = 0 Then ' validation checks

            MessageBox.Show("Make sure the get round data and get all players button is clicked")
        ElseIf Not IsNumeric(blackKey) And Not IsNumeric(whiteKey) Then
            MessageBox.Show("Please enter a number")
        ElseIf whiteKey <= 0 Or blackKey <= 0 Or whiteKey > uniqueId Or blackKey > uniqueId Then
            MessageBox.Show("Please enter a number above 0 and below " & uniqueId + 1)
        Else
            ' code below inserts the scores at the index of the list and removes the original this keeps the index constant

            lstScores.Items.Insert(whiteKey, "(" + whiteKey + ")" + " " + whitePoints)
            lstScores.Items.RemoveAt(whiteKey - 1)
            lstScores.Items.Insert(blackKey, "(" + blackKey + ")" + " " + blackPoints)
            lstScores.Items.RemoveAt(blackKey - 1)

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCurrentRoundPlayers.Click
        Readfile("Players.txt", lstScores)



    End Sub

    Private Sub btnaddByePlayer_Click(sender As Object, e As EventArgs) Handles btnaddByePlayer.Click

        Dim byeKey As String ' unique id of the bye player
        Dim byePoints As String ' how many points the bye player got

        byeKey = txtbyePlayer.Text
        byePoints = cmbByeScore.Text
        If IsNumeric(txtbyePlayer.Text) And Not IsNothing(txtbyePlayer.Text) And lstScores.Items.Count > 0 Then
            If txtbyePlayer.Text > 0 Then
                lstScores.Items.Insert(byeKey, "(" + byeKey + ")" + " " + byePoints)
                lstScores.Items.RemoveAt(byeKey - 1)
            Else
                MessageBox.Show("Enter a number above 0")
            End If
        Else
            MessageBox.Show("make sure you entered a number and the list is not empty")
        End If
        ' gives players without a game points and outputs it

    End Sub

    Private Sub btnsaveScoresList_Click(sender As Object, e As EventArgs) Handles btnsaveScoresList.Click
        Dim totalPlayers As Integer = 0 ' shows total players plaing in the tournament
        Dim filename_savedData As String ' file stores all players playing in tournament
        Dim currentItem As String 'represents each line in the score list
        If lstcopiedRound.Items.Count = 0 Or lstScores.Items.Count = 0 Then 'error trapping
            MessageBox.Show("make sure get round data button and get all players is clicked")

        Else


            lstcopiedRound.Items.Clear()

            filename_savedData = Path.Combine(Application.StartupPath, "Players.txt")


            FileOpen(1, filename_savedData, OpenMode.Input)
            While Not EOF(1)

                LineInput(1)
                totalPlayers += 1
                uniqueId += 1
            End While
            FileClose(1)

            Dim scores(totalPlayers) As String 'stores scores of all the players First player in the scores(0) should be unique id 1 etc... e.g scores(7) would be unique id 8

            For i = 0 To lstScores.Items.Count - 1
                currentItem = lstScores.Items.Item(i)

                If currentItem.Last = ")" Then ' if statement is here so if player does not put anything scores is zero

                    scores(i) = 0
                Else

                    scores(i) = currentItem.Last

                End If

            Next

            For i = 0 To scores.Length - 2

                lstcopiedRound.Items.Add((i + 1).ToString + ")" + scores(i)) ' first item in the list will be the id the second item is score


            Next
            Writefile("Scores.txt", lstcopiedRound)


            Dim playerID As String ' gets the id of all players
            Dim scoresfromround As String ' scores of current round
            Dim scoresfromprevround As String ' scores of previous rounf
            Dim totalscores As Integer 'scores of new round + scores of previous round

            If lsttotalscores.Items.Count = 0 Then

            Else
                For i = 0 To lstcopiedRound.Items.Count - 1
                    scoresfromround = lstcopiedRound.Items(i)
                    scoresfromprevround = lsttotalscores.Items(i)
                    If IsNumeric(scoresfromround.Substring(0, 2)) Then ' checks if first 2 characters of player id is numberic if it is player id >=10
                        playerID = scoresfromround.Substring(0, 2)

                        If IsNumeric(scoresfromprevround.Substring(scoresfromprevround.Length - 2, 1)) Then

                            totalscores = Integer.Parse((scoresfromprevround.Substring(scoresfromprevround.Length - 2, 2)) + Integer.Parse(scoresfromround.Last))
                            lsttotalscores.Items.Add(playerID + ")" + totalscores.ToString)

                        Else
                            totalscores = Integer.Parse((scoresfromprevround.Substring(scoresfromprevround.Length - 1)) + Integer.Parse(scoresfromround.Last))
                            lsttotalscores.Items.Add(playerID + ")" + totalscores.ToString)


                        End If

                    Else
                        playerID = scoresfromround.First 'if the first character is only a number then player id is one character long
                        If IsNumeric(scoresfromprevround.Substring(scoresfromprevround.Length - 2, 1)) Then

                            totalscores = Integer.Parse((scoresfromprevround.Substring(scoresfromprevround.Length - 2, 2)) + Integer.Parse(scoresfromround.Last))
                            lsttotalscores.Items.Add(playerID + ")" + totalscores.ToString)

                        Else
                            totalscores = Integer.Parse((scoresfromprevround.Substring(scoresfromprevround.Length - 1)) + Integer.Parse(scoresfromround.Last))
                            lsttotalscores.Items.Add(playerID + ")" + totalscores.ToString)


                        End If

                    End If
                Next

                For i = 1 To lsttotalscores.Items.Count / 2
                    lsttotalscores.Items.RemoveAt(0)


                Next

                Writefile("Scores.txt", lsttotalscores) ' copes the total scoreslist to the specified file

            End If
        End If

    End Sub

    Private Sub btnplayerHistory_Click(sender As Object, e As EventArgs) Handles btnplayerHistory.Click

        ' outputs the contents of the file player history to a list. 
        'player history consists of 2 numbers which represent The player id
        'If those numbers are in the file that means they played each other
        Readfile("player history.txt", lstplayerHistory)

    End Sub

    Private Sub btncolorHistory_Click(sender As Object, e As EventArgs) Handles btncolorHistory.Click
        ' gets the color history from the file and outputs it to the specified list box
        Readfile("Color history.txt", lstcolorHistory)

    End Sub


    Private Sub btnscores_Click(sender As Object, e As EventArgs) Handles btnscores.Click
        ' gets the scores from the file and outputs it
        Readfile("Scores.txt", lstplayerScores)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnGetplayerscore.Click
        ' gets the scores from the file and outputs it
        Readfile("Scores.txt", lsttotalscores)
    End Sub

    Private Sub btngetscores_Click(sender As Object, e As EventArgs) Handles btngetscores.Click
        ' gets the scores from the file and out puts it
        Readfile("Scores.txt", lstOverview)
    End Sub

    Private Sub btngetallplayers_Click(sender As Object, e As EventArgs) Handles btngetallplayers.Click
        ' gets all players playing in round from files and outputs it
        Readfile("Players.txt", lstallplayers)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Btnclearalldata.Click
        Dim result As DialogResult 'to know what dialog option the user clicked
        result = MessageBox.Show("You can not get your data back.", "Are you sure?", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            btnAddInOrder.Show()
            btnRemoveMostRecent.Show()
            txtEnterPlayerName.Show()
            lstPlayers.Items.Clear()
            lstCopiedPlayers.Items.Clear()
            lstcolorHistory.Items.Clear()
            lstplayerHistory.Items.Clear()
            lstplayerScores.Items.Clear()
            lstcopiedRound.Items.Clear()
            lsttotalscores.Items.Clear()
            lstScores.Items.Clear()
            btnAddNewPlayer.Show()
            BtnRemove.Show()

            uniqueId = 1 'since there are no players in the tournament
            ' All code below opens all files and empties them 
            Clearfile("Players.txt")
            Clearfile("Scores.txt")
            Clearfile("Color history.txt")
            Clearfile("Player history.txt")
            Clearfile("Round.txt")
            Clearfile("Players in round.txt")




        End If
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the program?", "Click yes to close", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
