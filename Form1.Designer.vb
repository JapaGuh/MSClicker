<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnClicker = New Button()
        Label2 = New Label()
        lblClicks = New Label()
        btnBonus = New Button()
        btnCritMult = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnCritChance = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblBonus = New Label()
        lblBonusCost = New Label()
        lblCritMult = New Label()
        lblCritMultCost = New Label()
        lblCritChance = New Label()
        lblCritChanceCost = New Label()
        lblRecord = New Label()
        Label1 = New Label()
        lblTimesClicked = New Label()
        Label9 = New Label()
        btnFinish = New Button()
        btnReset = New Button()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Label10 = New Label()
        lblTimer = New Label()
        Label11 = New Label()
        lblBestTime = New Label()
        btnAuto = New Button()
        btnAutoPCost = New Button()
        Label12 = New Label()
        Label14 = New Label()
        lblAutoPCost = New Label()
        lblAutoP = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' btnClicker
        ' 
        btnClicker.BackColor = SystemColors.ActiveBorder
        btnClicker.Font = New Font("Segoe UI", 63.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClicker.Location = New Point(474, 212)
        btnClicker.Name = "btnClicker"
        btnClicker.Size = New Size(259, 245)
        btnClicker.TabIndex = 2
        btnClicker.Text = "Click"
        btnClicker.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label2.Location = New Point(504, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 3
        Label2.Text = "Clicks :"
        ' 
        ' lblClicks
        ' 
        lblClicks.AutoSize = True
        lblClicks.Location = New Point(588, 179)
        lblClicks.Name = "lblClicks"
        lblClicks.Size = New Size(24, 30)
        lblClicks.TabIndex = 4
        lblClicks.Text = "0"
        ' 
        ' btnBonus
        ' 
        btnBonus.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnBonus.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnBonus.Location = New Point(12, 119)
        btnBonus.Name = "btnBonus"
        btnBonus.Size = New Size(241, 127)
        btnBonus.TabIndex = 5
        btnBonus.Text = "More click power"
        btnBonus.UseVisualStyleBackColor = False
        ' 
        ' btnCritMult
        ' 
        btnCritMult.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCritMult.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnCritMult.Location = New Point(1012, 119)
        btnCritMult.Name = "btnCritMult"
        btnCritMult.Size = New Size(240, 192)
        btnCritMult.TabIndex = 6
        btnCritMult.Text = "More crit multiplier"
        btnCritMult.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label3.Location = New Point(2, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 25)
        Label3.TabIndex = 7
        Label3.Text = " Tota bonus :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label4.Location = New Point(919, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 25)
        Label4.TabIndex = 8
        Label4.Text = "Total crit multiplier :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label5.Location = New Point(940, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 25)
        Label5.TabIndex = 10
        Label5.Text = "Total crit chance :"
        ' 
        ' btnCritChance
        ' 
        btnCritChance.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCritChance.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnCritChance.Location = New Point(1012, 411)
        btnCritChance.Name = "btnCritChance"
        btnCritChance.Size = New Size(240, 192)
        btnCritChance.TabIndex = 9
        btnCritChance.Text = "More crit chance"
        btnCritChance.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label6.Location = New Point(73, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 25)
        Label6.TabIndex = 11
        Label6.Text = "Cost :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label7.Location = New Point(1050, 376)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 25)
        Label7.TabIndex = 12
        Label7.Text = "Cost :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label8.Location = New Point(1050, 88)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 25)
        Label8.TabIndex = 13
        Label8.Text = "Cost :"
        ' 
        ' lblBonus
        ' 
        lblBonus.AutoSize = True
        lblBonus.Location = New Point(149, 56)
        lblBonus.Name = "lblBonus"
        lblBonus.Size = New Size(24, 30)
        lblBonus.TabIndex = 14
        lblBonus.Text = "0"
        ' 
        ' lblBonusCost
        ' 
        lblBonusCost.AutoSize = True
        lblBonusCost.Location = New Point(149, 86)
        lblBonusCost.Name = "lblBonusCost"
        lblBonusCost.Size = New Size(24, 30)
        lblBonusCost.TabIndex = 15
        lblBonusCost.Text = "1"
        ' 
        ' lblCritMult
        ' 
        lblCritMult.AutoSize = True
        lblCritMult.Location = New Point(1121, 58)
        lblCritMult.Name = "lblCritMult"
        lblCritMult.Size = New Size(47, 30)
        lblCritMult.TabIndex = 16
        lblCritMult.Text = "0 %"
        ' 
        ' lblCritMultCost
        ' 
        lblCritMultCost.AutoSize = True
        lblCritMultCost.Location = New Point(1121, 86)
        lblCritMultCost.Name = "lblCritMultCost"
        lblCritMultCost.Size = New Size(24, 30)
        lblCritMultCost.TabIndex = 17
        lblCritMultCost.Text = "1"
        ' 
        ' lblCritChance
        ' 
        lblCritChance.AutoSize = True
        lblCritChance.Location = New Point(1121, 346)
        lblCritChance.Name = "lblCritChance"
        lblCritChance.Size = New Size(47, 30)
        lblCritChance.TabIndex = 18
        lblCritChance.Text = "0 %"
        ' 
        ' lblCritChanceCost
        ' 
        lblCritChanceCost.AutoSize = True
        lblCritChanceCost.Location = New Point(1121, 376)
        lblCritChanceCost.Name = "lblCritChanceCost"
        lblCritChanceCost.Size = New Size(24, 30)
        lblCritChanceCost.TabIndex = 19
        lblCritChanceCost.Text = "1"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Location = New Point(654, 460)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(24, 30)
        lblRecord.TabIndex = 20
        lblRecord.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label1.Location = New Point(520, 460)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 25)
        Label1.TabIndex = 21
        Label1.Text = "Total clicks :"
        ' 
        ' lblTimesClicked
        ' 
        lblTimesClicked.AutoSize = True
        lblTimesClicked.Location = New Point(654, 492)
        lblTimesClicked.Name = "lblTimesClicked"
        lblTimesClicked.Size = New Size(24, 30)
        lblTimesClicked.TabIndex = 22
        lblTimesClicked.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label9.Location = New Point(501, 492)
        Label9.Name = "Label9"
        Label9.Size = New Size(151, 25)
        Label9.TabIndex = 23
        Label9.Text = "Times clicked :"
        ' 
        ' btnFinish
        ' 
        btnFinish.BackColor = Color.LimeGreen
        btnFinish.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFinish.Location = New Point(687, 562)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(191, 66)
        btnFinish.TabIndex = 24
        btnFinish.Text = "Win"
        btnFinish.UseVisualStyleBackColor = False
        btnFinish.Visible = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.DodgerBlue
        btnReset.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(338, 562)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(191, 66)
        btnReset.TabIndex = 25
        btnReset.Text = "FreePlay"
        btnReset.UseVisualStyleBackColor = False
        btnReset.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(-10, -5)
        Button1.Name = "Button1"
        Button1.Size = New Size(1282, 696)
        Button1.TabIndex = 26
        Button1.Text = "Start Game"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 15.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(482, 45)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 25)
        Label10.TabIndex = 27
        Label10.Text = "Timer :"
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Location = New Point(561, 40)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(105, 30)
        lblTimer.TabIndex = 28
        lblTimer.Text = "0 seconds"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 15.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(448, 70)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 25)
        Label11.TabIndex = 29
        Label11.Text = "Best time :"
        ' 
        ' lblBestTime
        ' 
        lblBestTime.AutoSize = True
        lblBestTime.Location = New Point(561, 70)
        lblBestTime.Name = "lblBestTime"
        lblBestTime.Size = New Size(40, 30)
        lblBestTime.TabIndex = 30
        lblBestTime.Text = "???"
        ' 
        ' btnAuto
        ' 
        btnAuto.BackColor = Color.Silver
        btnAuto.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnAuto.Location = New Point(12, 307)
        btnAuto.Name = "btnAuto"
        btnAuto.Size = New Size(241, 127)
        btnAuto.TabIndex = 31
        btnAuto.Text = "AutoClicker"
        btnAuto.UseVisualStyleBackColor = False
        ' 
        ' btnAutoPCost
        ' 
        btnAutoPCost.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnAutoPCost.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnAutoPCost.Location = New Point(12, 498)
        btnAutoPCost.Name = "btnAutoPCost"
        btnAutoPCost.Size = New Size(241, 127)
        btnAutoPCost.TabIndex = 32
        btnAutoPCost.Text = "More AutoClicker speed"
        btnAutoPCost.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(86, 276)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 30)
        Label12.TabIndex = 36
        Label12.Text = "1000"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label14.Location = New Point(10, 279)
        Label14.Name = "Label14"
        Label14.Size = New Size(66, 25)
        Label14.TabIndex = 34
        Label14.Text = "Cost :"
        ' 
        ' lblAutoPCost
        ' 
        lblAutoPCost.AutoSize = True
        lblAutoPCost.Location = New Point(149, 467)
        lblAutoPCost.Name = "lblAutoPCost"
        lblAutoPCost.Size = New Size(57, 30)
        lblAutoPCost.TabIndex = 40
        lblAutoPCost.Text = "1000"
        ' 
        ' lblAutoP
        ' 
        lblAutoP.AutoSize = True
        lblAutoP.Location = New Point(149, 437)
        lblAutoP.Name = "lblAutoP"
        lblAutoP.Size = New Size(105, 30)
        lblAutoP.TabIndex = 39
        lblAutoP.Text = "1 seconds"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label18.Location = New Point(73, 470)
        Label18.Name = "Label18"
        Label18.Size = New Size(66, 25)
        Label18.TabIndex = 38
        Label18.Text = "Cost :"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Tahoma", 15.75F, FontStyle.Underline)
        Label19.Location = New Point(7, 442)
        Label19.Name = "Label19"
        Label19.Size = New Size(134, 25)
        Label19.TabIndex = 37
        Label19.Text = "Total speed :"
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Button1)
        Controls.Add(lblAutoPCost)
        Controls.Add(lblAutoP)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(Label14)
        Controls.Add(btnAutoPCost)
        Controls.Add(btnAuto)
        Controls.Add(btnReset)
        Controls.Add(btnFinish)
        Controls.Add(Label9)
        Controls.Add(lblTimesClicked)
        Controls.Add(Label1)
        Controls.Add(lblRecord)
        Controls.Add(lblCritChanceCost)
        Controls.Add(lblCritChance)
        Controls.Add(lblCritMultCost)
        Controls.Add(lblCritMult)
        Controls.Add(lblBonusCost)
        Controls.Add(lblBonus)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnCritChance)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnCritMult)
        Controls.Add(btnBonus)
        Controls.Add(lblClicks)
        Controls.Add(Label2)
        Controls.Add(btnClicker)
        Controls.Add(lblTimer)
        Controls.Add(Label10)
        Controls.Add(lblBestTime)
        Controls.Add(Label11)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MSClicker"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClicker As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblClicks As Label
    Friend WithEvents btnBonus As Button
    Friend WithEvents btnCritMult As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCritChance As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblBonusCost As Label
    Friend WithEvents lblCritMult As Label
    Friend WithEvents lblCritMultCost As Label
    Friend WithEvents lblCritChance As Label
    Friend WithEvents lblCritChanceCost As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTimesClicked As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBestTime As Label
    Friend WithEvents btnAuto As Button
    Friend WithEvents btnAutoPCost As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblAutoPCost As Label
    Friend WithEvents lblAutoP As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Timer2 As Timer

End Class
