Public Class TwoRoomGameForm

    Private currentRoom As String
    Private inventory As New List(Of String)

    Private Sub TwoRoomGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentRoom = "Room1"
        UpdateRoomDescription()
    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim command As String = CommandTextBox.Text.Trim().ToLower()
        CommandTextBox.Clear()
        ProcessCommand(command)
    End Sub

    Private Sub ProcessCommand(command As String)
        Select Case command
            Case "go to room2"
                If currentRoom = "Room1" Then
                    currentRoom = "Room2"
                    ResponseTextBox.Text = "You move to Room 2."
                Else
                    ResponseTextBox.Text = "You're already in Room 2."
                End If
                UpdateRoomDescription()

            Case "go to room1"
                If currentRoom = "Room2" Then
                    currentRoom = "Room1"
                    ResponseTextBox.Text = "You move to Room 1."
                Else
                    ResponseTextBox.Text = "You're already in Room 1."
                End If
                UpdateRoomDescription()

            Case "look around"
                UpdateRoomDescription()

            Case "help"
                ResponseTextBox.Text = "Try: go to room1, go to room2, look around, help, pickup, inventory"

            Case "pickup"
                If currentRoom = "Room1" AndAlso Not inventory.Contains("flamethrower 🔥🔫") Then
                    inventory.Add("flamethrower 🔥🔫")
                    ResponseTextBox.Text = "You pickup the flamethrower 🔥🔫."
                Else
                    ResponseTextBox.Text = "There's nothing to pick up here."
                End If

            Case "inventory"
                If inventory.Count = 0 Then
                    ResponseTextBox.Text = "Your inventory is empty."
                Else
                    ResponseTextBox.Text = "You have: " & String.Join(", ", inventory)
                End If

            Case Else
                ResponseTextBox.Text = "I don’t understand that command, but I believe you'll figure it out! 💡"
        End Select
    End Sub

    'Private Sub UpdateRoomDescription()

    '    ResponseLabel.Text = String.Empty

    '    Select Case currentRoom
    '        Case "Room1"
    '            Dim itemText As String = If(inventory.Contains("flamethrower"), "", "There is a flamethrower 🔥🔫 here. ")
    '            ResponseLabel.Text &= vbCrLf & $"You are in Room 1. {itemText}There is a door leading to Room 2."

    '        Case "Room2"
    '            ResponseLabel.Text &= vbCrLf & "You are in Room 2. There is a door leading back to Room 1."
    '    End Select
    'End Sub
    Private Sub UpdateRoomDescription()
        ResponseTextBox.Text = DescribeRoom(currentRoom)
    End Sub
    Private Sub CommandTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CommandTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RunButton.PerformClick()
        End If
    End Sub


    Private Function DescribeRoom(roomName As String) As String
        Dim lines As New List(Of String)

        Select Case roomName
            Case "Room1"
                lines.Add("You are in Room 1.")
                If Not inventory.Contains("flamethrower 🔥🔫") Then
                    lines.Add("There is a flamethrower 🔥🔫 here.")
                End If
                lines.Add("There is a door leading to Room 2.")

            Case "Room2"
                lines.Add("You are in Room 2.")
                lines.Add("There is a door leading back to Room 1.")

            Case Else
                lines.Add("This room is unfamiliar. It might be a bug in the matrix 🧠.")
        End Select

        Return String.Join(vbCrLf, lines)
    End Function
End Class

































'Public Class TwoRoomGameForm

'    Private currentRoom As String

'    Private Sub TwoRoomGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Initialize the game in the first room
'        currentRoom = "Room1"
'        UpdateRoomDescription()
'    End Sub

'    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
'        ' Get the user's command
'        Dim command As String = CommandTextBox.Text.Trim().ToLower()
'        CommandTextBox.Clear()

'        ' Process the command
'        Select Case command
'            Case "go to room2"
'                If currentRoom = "Room1" Then
'                    currentRoom = "Room2"
'                    ResponseLabel.Text = "You move to Room 2."
'                Else
'                    ResponseLabel.Text = "You're already in Room 2."
'                End If
'            Case "go to room1"
'                If currentRoom = "Room2" Then
'                    currentRoom = "Room1"
'                    ResponseLabel.Text = "You move to Room 1."
'                Else
'                    ResponseLabel.Text = "You're already in Room 1."
'                End If
'            Case "look around"
'                UpdateRoomDescription()
'            Case "help"
'                ResponseLabel.Text = "Try: go to room1, go to room2, look around, help, pickup"
'            Case "pickup"
'                ResponseLabel.Text = "You pickup the flamethrower🔥🔫."
'            Case Else
'                ResponseLabel.Text = "I don’t understand that command."
'        End Select
'    End Sub

'    Private Sub UpdateRoomDescription()
'        Select Case currentRoom
'            Case "Room1"
'                ResponseLabel.Text = "You are in Room 1. There is a flamethrower and a door leading to Room 2."
'            Case "Room2"
'                ResponseLabel.Text = "You are in Room 2. There is a door leading back to Room 1."
'        End Select
'    End Sub

'    Private Sub CommandTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CommandTextBox.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            e.SuppressKeyPress = True ' Prevent the ding sound
'            RunButton.PerformClick() ' Simulate button click
'        End If
'    End Sub

'End Class
