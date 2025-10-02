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
        ResponseLabel = New Label()
        CommandTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' RunButton
        ' 
        RunButton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RunButton.Location = New Point(614, 239)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(148, 71)
        RunButton.TabIndex = 0
        RunButton.Text = "Run"
        RunButton.UseVisualStyleBackColor = True
        ' 
        ' ResponseLabel
        ' 
        ResponseLabel.AutoSize = True
        ResponseLabel.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResponseLabel.Location = New Point(100, 127)
        ResponseLabel.Name = "ResponseLabel"
        ResponseLabel.Size = New Size(239, 65)
        ResponseLabel.TabIndex = 1
        ResponseLabel.Text = "Response:"
        ' 
        ' CommandTextBox
        ' 
        CommandTextBox.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CommandTextBox.Location = New Point(100, 239)
        CommandTextBox.Name = "CommandTextBox"
        CommandTextBox.Size = New Size(472, 71)
        CommandTextBox.TabIndex = 2
        ' 
        ' TwoRoomGameForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(CommandTextBox)
        Controls.Add(ResponseLabel)
        Controls.Add(RunButton)
        Name = "TwoRoomGameForm"
        Text = "Two Room Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RunButton As Button
    Friend WithEvents ResponseLabel As Label
    Friend WithEvents CommandTextBox As TextBox

End Class
