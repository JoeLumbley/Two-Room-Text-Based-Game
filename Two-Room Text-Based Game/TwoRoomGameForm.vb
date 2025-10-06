' Two-Room Text-Based Game

' MIT License

' Copyright (c) 2025 Joseph W. Lumbley

' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
' copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:

' The above copyright notice and this permission notice shall be included in all
' copies or substantial portions of the Software.

' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
' SOFTWARE.

Public Class TwoRoomGameForm

    Private currentRoom As String
    Private inventory As New List(Of String)
    Private Const Flamethrower As String = "flamethrower 🔥🔫"
    Private Const Monster As String = "grumpy monster 👹"

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

            Case "goto room 2"

                If currentRoom = "Room1" Then
                    currentRoom = "Room2"
                    ResponseTextBox.Text = "You move to Room 2."
                Else
                    ResponseTextBox.Text = "You're already in Room 2."
                End If

                UpdateRoomDescription()

            Case "goto room 1"

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

                ResponseTextBox.Text = "Try: goto room 1, goto room 2, look around, help, pickup, inventory, fight"

            Case "pickup"

                If currentRoom = "Room1" AndAlso Not inventory.Contains(Flamethrower) Then
                    inventory.Add(Flamethrower)
                    ResponseTextBox.Text = $"You pickup the {Flamethrower}."
                Else
                    ResponseTextBox.Text = "There's nothing to pick up here."
                End If

            Case "inventory"

                If inventory.Count = 0 Then
                    ResponseTextBox.Text = "Your inventory is empty."
                Else
                    ResponseTextBox.Text = "You have: " & String.Join(", ", inventory)
                End If

            Case "fight"
                If inventory.Contains(Flamethrower) Then
                    If currentRoom = "Room2" Then
                        ResponseTextBox.Text = "You use the flamethrower to scare away the grumpy monster! You win! 🎉"
                        inventory.Remove(Flamethrower)
                    Else
                        ResponseTextBox.Text = "There's nothing to use the flamethrower on here."
                    End If
                Else
                    ResponseTextBox.Text = "You don't have a flamethrower to use."
                End If

            Case Else

                ResponseTextBox.Text = "I don’t understand that command, but I believe you'll figure it out! 💡"

        End Select

    End Sub

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
                If Not inventory.Contains(Flamethrower) Then
                    lines.Add($"There is a {Flamethrower} here.")
                End If
                lines.Add("There is a door leading to Room 2.")

            Case "Room2"
                lines.Add("You are in Room 2.")
                lines.Add($"A {Monster} is lurking in the corner!")
                lines.Add("There is a door leading back to Room 1.")

            Case Else
                lines.Add("This room is unfamiliar. It might be a bug in the matrix 🧠.")
        End Select

        Return String.Join(vbCrLf, lines)
    End Function

End Class
