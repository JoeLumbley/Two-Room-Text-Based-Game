<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TwoRoomGameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        RunButton = New Button()
        CommandTextBox = New TextBox()
        ResponseTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' RunButton
        ' 
        RunButton.FlatStyle = FlatStyle.Flat
        RunButton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RunButton.ForeColor = Color.White
        RunButton.Location = New Point(704, 529)
        RunButton.Margin = New Padding(3, 4, 3, 4)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(169, 95)
        RunButton.TabIndex = 1
        RunButton.Text = "Run"
        RunButton.UseVisualStyleBackColor = True
        ' 
        ' CommandTextBox
        ' 
        CommandTextBox.BackColor = Color.Black
        CommandTextBox.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CommandTextBox.ForeColor = Color.White
        CommandTextBox.Location = New Point(55, 529)
        CommandTextBox.Margin = New Padding(3, 4, 3, 4)
        CommandTextBox.Name = "CommandTextBox"
        CommandTextBox.Size = New Size(539, 87)
        CommandTextBox.TabIndex = 0
        ' 
        ' ResponseTextBox
        ' 
        ResponseTextBox.BackColor = Color.Black
        ResponseTextBox.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResponseTextBox.ForeColor = Color.White
        ResponseTextBox.Location = New Point(55, 73)
        ResponseTextBox.Margin = New Padding(3, 4, 3, 4)
        ResponseTextBox.Multiline = True
        ResponseTextBox.Name = "ResponseTextBox"
        ResponseTextBox.Size = New Size(1163, 413)
        ResponseTextBox.TabIndex = 2
        ' 
        ' TwoRoomGameForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1924, 1055)
        Controls.Add(ResponseTextBox)
        Controls.Add(CommandTextBox)
        Controls.Add(RunButton)
        Margin = New Padding(3, 4, 3, 4)
        Name = "TwoRoomGameForm"
        Text = "Two Room Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RunButton As Button
    Friend WithEvents CommandTextBox As TextBox
    Friend WithEvents ResponseTextBox As TextBox

End Class
