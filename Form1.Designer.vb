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

    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents btnLizard As System.Windows.Forms.Button
    Friend WithEvents btnSpock As System.Windows.Forms.Button
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
    Friend WithEvents lblMostChosen As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblPlayerChoice As System.Windows.Forms.Label
    Friend WithEvents lblComputerChoice As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.btnLizard = New System.Windows.Forms.Button()
        Me.btnSpock = New System.Windows.Forms.Button()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.lblMostChosen = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblPlayerChoice = New System.Windows.Forms.Label()
        Me.lblComputerChoice = New System.Windows.Forms.Label()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnRock
        '
        Me.btnRock.BackColor = System.Drawing.Color.Gray
        Me.btnRock.FlatAppearance.BorderSize = 0
        Me.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRock.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRock.ForeColor = System.Drawing.Color.White
        Me.btnRock.Location = New System.Drawing.Point(3, 12)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(120, 48)
        Me.btnRock.TabIndex = 0
        Me.btnRock.Text = "Rock"
        Me.toolTip1.SetToolTip(Me.btnRock, "Rock crushes Scissors and Lizard")
        Me.btnRock.UseVisualStyleBackColor = False
        '
        'btnPaper
        '
        Me.btnPaper.BackColor = System.Drawing.Color.Khaki
        Me.btnPaper.FlatAppearance.BorderSize = 0
        Me.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaper.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaper.ForeColor = System.Drawing.Color.Black
        Me.btnPaper.Location = New System.Drawing.Point(146, 12)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(120, 48)
        Me.btnPaper.TabIndex = 1
        Me.btnPaper.Text = "Paper"
        Me.toolTip1.SetToolTip(Me.btnPaper, "Paper covers Rock and disproves Spock")
        Me.btnPaper.UseVisualStyleBackColor = False
        '
        'btnScissors
        '
        Me.btnScissors.BackColor = System.Drawing.Color.IndianRed
        Me.btnScissors.FlatAppearance.BorderSize = 0
        Me.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScissors.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnScissors.ForeColor = System.Drawing.Color.White
        Me.btnScissors.Location = New System.Drawing.Point(297, 12)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(120, 48)
        Me.btnScissors.TabIndex = 2
        Me.btnScissors.Text = "Scissors"
        Me.toolTip1.SetToolTip(Me.btnScissors, "Scissors cuts Paper and decapitates Lizard")
        Me.btnScissors.UseVisualStyleBackColor = False
        '
        'btnLizard
        '
        Me.btnLizard.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnLizard.FlatAppearance.BorderSize = 0
        Me.btnLizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLizard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLizard.ForeColor = System.Drawing.Color.White
        Me.btnLizard.Location = New System.Drawing.Point(440, 12)
        Me.btnLizard.Name = "btnLizard"
        Me.btnLizard.Size = New System.Drawing.Size(120, 48)
        Me.btnLizard.TabIndex = 3
        Me.btnLizard.Text = "Lizard"
        Me.toolTip1.SetToolTip(Me.btnLizard, "Lizard poisons Spock and eats Paper")
        Me.btnLizard.UseVisualStyleBackColor = False
        '
        'btnSpock
        '
        Me.btnSpock.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSpock.FlatAppearance.BorderSize = 0
        Me.btnSpock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpock.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSpock.ForeColor = System.Drawing.Color.White
        Me.btnSpock.Location = New System.Drawing.Point(577, 12)
        Me.btnSpock.Name = "btnSpock"
        Me.btnSpock.Size = New System.Drawing.Size(120, 48)
        Me.btnSpock.TabIndex = 4
        Me.btnSpock.Text = "Spock"
        Me.toolTip1.SetToolTip(Me.btnSpock, "Spock vaporizes Rock and smashes Scissors")
        Me.btnSpock.UseVisualStyleBackColor = False
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayerScore.Location = New System.Drawing.Point(18, 90)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(86, 25)
        Me.lblPlayerScore.TabIndex = 5
        Me.lblPlayerScore.Text = "Player: 0"
        '
        'lblComputerScore
        '
        Me.lblComputerScore.AutoSize = True
        Me.lblComputerScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblComputerScore.Location = New System.Drawing.Point(159, 90)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(117, 25)
        Me.lblComputerScore.TabIndex = 6
        Me.lblComputerScore.Text = "Computer: 0"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblResult.Location = New System.Drawing.Point(18, 135)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(648, 30)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Make your move"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstHistory
        '
        Me.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHistory.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 22
        Me.lstHistory.Location = New System.Drawing.Point(18, 180)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(648, 156)
        Me.lstHistory.TabIndex = 10
        '
        'lblMostChosen
        '
        Me.lblMostChosen.AutoSize = True
        Me.lblMostChosen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblMostChosen.Location = New System.Drawing.Point(18, 360)
        Me.lblMostChosen.Name = "lblMostChosen"
        Me.lblMostChosen.Size = New System.Drawing.Size(173, 25)
        Me.lblMostChosen.TabIndex = 11
        Me.lblMostChosen.Text = "Most chosen move: -"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightGray
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.Location = New System.Drawing.Point(546, 352)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 30)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.toolTip1.SetToolTip(Me.btnReset, "Reset scores and history")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.IndianRed
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(381, 352)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(110, 30)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.toolTip1.SetToolTip(Me.btnQuit, "Exit the game")
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblPlayerChoice
        '
        Me.lblPlayerChoice.AutoSize = True
        Me.lblPlayerChoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPlayerChoice.Location = New System.Drawing.Point(18, 115)
        Me.lblPlayerChoice.Name = "lblPlayerChoice"
        Me.lblPlayerChoice.Size = New System.Drawing.Size(118, 25)
        Me.lblPlayerChoice.TabIndex = 7
        Me.lblPlayerChoice.Text = "Your choice: -"
        '
        'lblComputerChoice
        '
        Me.lblComputerChoice.AutoSize = True
        Me.lblComputerChoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblComputerChoice.Location = New System.Drawing.Point(159, 115)
        Me.lblComputerChoice.Name = "lblComputerChoice"
        Me.lblComputerChoice.Size = New System.Drawing.Size(163, 25)
        Me.lblComputerChoice.TabIndex = 8
        Me.lblComputerChoice.Text = "Computer choice: -"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(690, 400)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.btnLizard)
        Me.Controls.Add(Me.btnSpock)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblPlayerChoice)
        Me.Controls.Add(Me.lblComputerChoice)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstHistory)
        Me.Controls.Add(Me.lblMostChosen)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPSLS - Rock Paper Scissors Lizard Spock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip

End Class
