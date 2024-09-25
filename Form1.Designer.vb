<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbHorse = New System.Windows.Forms.GroupBox()
        Me.rdoBtn5 = New System.Windows.Forms.RadioButton()
        Me.rdoBtn4 = New System.Windows.Forms.RadioButton()
        Me.rdoBtn3 = New System.Windows.Forms.RadioButton()
        Me.rdoBtn2 = New System.Windows.Forms.RadioButton()
        Me.rdoBtn1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxStartMoney = New System.Windows.Forms.TextBox()
        Me.lblCurrentBet = New System.Windows.Forms.Label()
        Me.txtBoxCurrentBet = New System.Windows.Forms.TextBox()
        Me.lblCurrentMoney = New System.Windows.Forms.Label()
        Me.txtBoxCurrentMoney = New System.Windows.Forms.TextBox()
        Me.lblRoundNumber = New System.Windows.Forms.Label()
        Me.btnPlaceBet = New System.Windows.Forms.Button()
        Me.btnStartRace = New System.Windows.Forms.Button()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pbHorse1 = New System.Windows.Forms.ProgressBar()
        Me.pbHorse2 = New System.Windows.Forms.ProgressBar()
        Me.pbHorse3 = New System.Windows.Forms.ProgressBar()
        Me.pbHorse4 = New System.Windows.Forms.ProgressBar()
        Me.pbHorse5 = New System.Windows.Forms.ProgressBar()
        Me.lblHorse1 = New System.Windows.Forms.Label()
        Me.lblHorse2 = New System.Windows.Forms.Label()
        Me.lblHorse3 = New System.Windows.Forms.Label()
        Me.lblHorse4 = New System.Windows.Forms.Label()
        Me.lblHorse5 = New System.Windows.Forms.Label()
        Me.lblStanding = New System.Windows.Forms.Label()
        Me.txtBoxHorse1Standing = New System.Windows.Forms.TextBox()
        Me.txtBoxHorse2Standing = New System.Windows.Forms.TextBox()
        Me.txtBoxHorse3Standing = New System.Windows.Forms.TextBox()
        Me.txtBoxHorse4Standing = New System.Windows.Forms.TextBox()
        Me.txtBoxHorse5Standing = New System.Windows.Forms.TextBox()
        Me.gbHorse.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbHorse
        '
        Me.gbHorse.BackColor = System.Drawing.Color.DarkGreen
        Me.gbHorse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbHorse.Controls.Add(Me.rdoBtn5)
        Me.gbHorse.Controls.Add(Me.rdoBtn4)
        Me.gbHorse.Controls.Add(Me.rdoBtn3)
        Me.gbHorse.Controls.Add(Me.rdoBtn2)
        Me.gbHorse.Controls.Add(Me.rdoBtn1)
        Me.gbHorse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbHorse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbHorse.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorse.ForeColor = System.Drawing.Color.Gold
        Me.gbHorse.Location = New System.Drawing.Point(98, 33)
        Me.gbHorse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbHorse.Name = "gbHorse"
        Me.gbHorse.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbHorse.Size = New System.Drawing.Size(204, 294)
        Me.gbHorse.TabIndex = 0
        Me.gbHorse.TabStop = False
        Me.gbHorse.Text = "Choose Your Horse"
        '
        'rdoBtn5
        '
        Me.rdoBtn5.AutoSize = True
        Me.rdoBtn5.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBtn5.Location = New System.Drawing.Point(48, 244)
        Me.rdoBtn5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdoBtn5.Name = "rdoBtn5"
        Me.rdoBtn5.Size = New System.Drawing.Size(123, 31)
        Me.rdoBtn5.TabIndex = 4
        Me.rdoBtn5.TabStop = True
        Me.rdoBtn5.Text = "Horse 5"
        Me.rdoBtn5.UseVisualStyleBackColor = True
        '
        'rdoBtn4
        '
        Me.rdoBtn4.AutoSize = True
        Me.rdoBtn4.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBtn4.Location = New System.Drawing.Point(48, 195)
        Me.rdoBtn4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdoBtn4.Name = "rdoBtn4"
        Me.rdoBtn4.Size = New System.Drawing.Size(123, 31)
        Me.rdoBtn4.TabIndex = 3
        Me.rdoBtn4.TabStop = True
        Me.rdoBtn4.Text = "Horse 4"
        Me.rdoBtn4.UseVisualStyleBackColor = True
        '
        'rdoBtn3
        '
        Me.rdoBtn3.AutoSize = True
        Me.rdoBtn3.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBtn3.Location = New System.Drawing.Point(48, 148)
        Me.rdoBtn3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdoBtn3.Name = "rdoBtn3"
        Me.rdoBtn3.Size = New System.Drawing.Size(123, 31)
        Me.rdoBtn3.TabIndex = 2
        Me.rdoBtn3.TabStop = True
        Me.rdoBtn3.Text = "Horse 3"
        Me.rdoBtn3.UseVisualStyleBackColor = True
        '
        'rdoBtn2
        '
        Me.rdoBtn2.AutoSize = True
        Me.rdoBtn2.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBtn2.Location = New System.Drawing.Point(48, 104)
        Me.rdoBtn2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdoBtn2.Name = "rdoBtn2"
        Me.rdoBtn2.Size = New System.Drawing.Size(123, 31)
        Me.rdoBtn2.TabIndex = 1
        Me.rdoBtn2.TabStop = True
        Me.rdoBtn2.Text = "Horse 2"
        Me.rdoBtn2.UseVisualStyleBackColor = True
        '
        'rdoBtn1
        '
        Me.rdoBtn1.AutoSize = True
        Me.rdoBtn1.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBtn1.Location = New System.Drawing.Point(48, 65)
        Me.rdoBtn1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdoBtn1.Name = "rdoBtn1"
        Me.rdoBtn1.Size = New System.Drawing.Size(123, 31)
        Me.rdoBtn1.TabIndex = 0
        Me.rdoBtn1.TabStop = True
        Me.rdoBtn1.Text = "Horse 1"
        Me.rdoBtn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(326, 257)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 71)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Starting Money"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBoxStartMoney
        '
        Me.txtBoxStartMoney.BackColor = System.Drawing.Color.DarkGreen
        Me.txtBoxStartMoney.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxStartMoney.Enabled = False
        Me.txtBoxStartMoney.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxStartMoney.Location = New System.Drawing.Point(326, 289)
        Me.txtBoxStartMoney.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxStartMoney.Name = "txtBoxStartMoney"
        Me.txtBoxStartMoney.Size = New System.Drawing.Size(228, 55)
        Me.txtBoxStartMoney.TabIndex = 2
        Me.txtBoxStartMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentBet
        '
        Me.lblCurrentBet.BackColor = System.Drawing.Color.Black
        Me.lblCurrentBet.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBet.ForeColor = System.Drawing.Color.White
        Me.lblCurrentBet.Location = New System.Drawing.Point(854, 257)
        Me.lblCurrentBet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentBet.Name = "lblCurrentBet"
        Me.lblCurrentBet.Size = New System.Drawing.Size(228, 71)
        Me.lblCurrentBet.TabIndex = 5
        Me.lblCurrentBet.Text = "Your Bet"
        Me.lblCurrentBet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBoxCurrentBet
        '
        Me.txtBoxCurrentBet.BackColor = System.Drawing.Color.DarkGreen
        Me.txtBoxCurrentBet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCurrentBet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBoxCurrentBet.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCurrentBet.ForeColor = System.Drawing.Color.White
        Me.txtBoxCurrentBet.Location = New System.Drawing.Point(854, 289)
        Me.txtBoxCurrentBet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxCurrentBet.Name = "txtBoxCurrentBet"
        Me.txtBoxCurrentBet.Size = New System.Drawing.Size(228, 55)
        Me.txtBoxCurrentBet.TabIndex = 6
        Me.txtBoxCurrentBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentMoney
        '
        Me.lblCurrentMoney.BackColor = System.Drawing.Color.Black
        Me.lblCurrentMoney.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMoney.ForeColor = System.Drawing.Color.White
        Me.lblCurrentMoney.Location = New System.Drawing.Point(588, 257)
        Me.lblCurrentMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentMoney.Name = "lblCurrentMoney"
        Me.lblCurrentMoney.Size = New System.Drawing.Size(228, 71)
        Me.lblCurrentMoney.TabIndex = 7
        Me.lblCurrentMoney.Text = "Money Left"
        Me.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBoxCurrentMoney
        '
        Me.txtBoxCurrentMoney.BackColor = System.Drawing.Color.DarkGreen
        Me.txtBoxCurrentMoney.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCurrentMoney.Enabled = False
        Me.txtBoxCurrentMoney.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCurrentMoney.ForeColor = System.Drawing.Color.White
        Me.txtBoxCurrentMoney.Location = New System.Drawing.Point(588, 289)
        Me.txtBoxCurrentMoney.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxCurrentMoney.Name = "txtBoxCurrentMoney"
        Me.txtBoxCurrentMoney.Size = New System.Drawing.Size(228, 55)
        Me.txtBoxCurrentMoney.TabIndex = 8
        Me.txtBoxCurrentMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRoundNumber
        '
        Me.lblRoundNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRoundNumber.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundNumber.ForeColor = System.Drawing.Color.Gold
        Me.lblRoundNumber.Location = New System.Drawing.Point(1168, 33)
        Me.lblRoundNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoundNumber.Name = "lblRoundNumber"
        Me.lblRoundNumber.Size = New System.Drawing.Size(200, 135)
        Me.lblRoundNumber.TabIndex = 9
        Me.lblRoundNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlaceBet
        '
        Me.btnPlaceBet.BackColor = System.Drawing.Color.DarkGreen
        Me.btnPlaceBet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlaceBet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlaceBet.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceBet.ForeColor = System.Drawing.Color.Gold
        Me.btnPlaceBet.Location = New System.Drawing.Point(1168, 257)
        Me.btnPlaceBet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPlaceBet.Name = "btnPlaceBet"
        Me.btnPlaceBet.Size = New System.Drawing.Size(200, 94)
        Me.btnPlaceBet.TabIndex = 10
        Me.btnPlaceBet.Text = "Place Your Bet"
        Me.btnPlaceBet.UseVisualStyleBackColor = False
        '
        'btnStartRace
        '
        Me.btnStartRace.BackColor = System.Drawing.Color.DarkGreen
        Me.btnStartRace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartRace.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStartRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartRace.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartRace.ForeColor = System.Drawing.Color.Gold
        Me.btnStartRace.Location = New System.Drawing.Point(1168, 617)
        Me.btnStartRace.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStartRace.Name = "btnStartRace"
        Me.btnStartRace.Size = New System.Drawing.Size(200, 50)
        Me.btnStartRace.TabIndex = 11
        Me.btnStartRace.Text = "Start Race"
        Me.btnStartRace.UseVisualStyleBackColor = False
        '
        'lblRace
        '
        Me.lblRace.BackColor = System.Drawing.Color.Transparent
        Me.lblRace.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRace.ForeColor = System.Drawing.Color.Gold
        Me.lblRace.Location = New System.Drawing.Point(98, 499)
        Me.lblRace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(888, 249)
        Me.lblRace.TabIndex = 12
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DarkGreen
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Gold
        Me.btnNext.Location = New System.Drawing.Point(1168, 699)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 50)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next Race"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pbHorse1
        '
        Me.pbHorse1.BackColor = System.Drawing.Color.DarkGreen
        Me.pbHorse1.Location = New System.Drawing.Point(326, 571)
        Me.pbHorse1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pbHorse1.Name = "pbHorse1"
        Me.pbHorse1.Size = New System.Drawing.Size(644, 38)
        Me.pbHorse1.TabIndex = 14
        '
        'pbHorse2
        '
        Me.pbHorse2.BackColor = System.Drawing.Color.DarkGreen
        Me.pbHorse2.Location = New System.Drawing.Point(326, 527)
        Me.pbHorse2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pbHorse2.Name = "pbHorse2"
        Me.pbHorse2.Size = New System.Drawing.Size(644, 38)
        Me.pbHorse2.TabIndex = 15
        '
        'pbHorse3
        '
        Me.pbHorse3.BackColor = System.Drawing.Color.DarkGreen
        Me.pbHorse3.Location = New System.Drawing.Point(326, 617)
        Me.pbHorse3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pbHorse3.Name = "pbHorse3"
        Me.pbHorse3.Size = New System.Drawing.Size(644, 38)
        Me.pbHorse3.TabIndex = 16
        '
        'pbHorse4
        '
        Me.pbHorse4.BackColor = System.Drawing.Color.DarkGreen
        Me.pbHorse4.Location = New System.Drawing.Point(326, 661)
        Me.pbHorse4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pbHorse4.Name = "pbHorse4"
        Me.pbHorse4.Size = New System.Drawing.Size(644, 38)
        Me.pbHorse4.TabIndex = 17
        '
        'pbHorse5
        '
        Me.pbHorse5.BackColor = System.Drawing.Color.DarkGreen
        Me.pbHorse5.Location = New System.Drawing.Point(326, 705)
        Me.pbHorse5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pbHorse5.Name = "pbHorse5"
        Me.pbHorse5.Size = New System.Drawing.Size(644, 38)
        Me.pbHorse5.TabIndex = 18
        '
        'lblHorse1
        '
        Me.lblHorse1.BackColor = System.Drawing.Color.DarkGreen
        Me.lblHorse1.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorse1.ForeColor = System.Drawing.Color.Gold
        Me.lblHorse1.Location = New System.Drawing.Point(158, 535)
        Me.lblHorse1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorse1.Name = "lblHorse1"
        Me.lblHorse1.Size = New System.Drawing.Size(112, 37)
        Me.lblHorse1.TabIndex = 19
        Me.lblHorse1.Text = "Horse 1"
        Me.lblHorse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorse2
        '
        Me.lblHorse2.BackColor = System.Drawing.Color.DarkGreen
        Me.lblHorse2.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorse2.ForeColor = System.Drawing.Color.Gold
        Me.lblHorse2.Location = New System.Drawing.Point(158, 578)
        Me.lblHorse2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorse2.Name = "lblHorse2"
        Me.lblHorse2.Size = New System.Drawing.Size(112, 37)
        Me.lblHorse2.TabIndex = 20
        Me.lblHorse2.Text = "Horse 2"
        Me.lblHorse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorse3
        '
        Me.lblHorse3.BackColor = System.Drawing.Color.DarkGreen
        Me.lblHorse3.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorse3.ForeColor = System.Drawing.Color.Gold
        Me.lblHorse3.Location = New System.Drawing.Point(158, 623)
        Me.lblHorse3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorse3.Name = "lblHorse3"
        Me.lblHorse3.Size = New System.Drawing.Size(112, 37)
        Me.lblHorse3.TabIndex = 21
        Me.lblHorse3.Text = "Horse 3"
        Me.lblHorse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorse4
        '
        Me.lblHorse4.BackColor = System.Drawing.Color.DarkGreen
        Me.lblHorse4.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorse4.ForeColor = System.Drawing.Color.Gold
        Me.lblHorse4.Location = New System.Drawing.Point(158, 666)
        Me.lblHorse4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorse4.Name = "lblHorse4"
        Me.lblHorse4.Size = New System.Drawing.Size(112, 37)
        Me.lblHorse4.TabIndex = 22
        Me.lblHorse4.Text = "Horse 4"
        Me.lblHorse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorse5
        '
        Me.lblHorse5.BackColor = System.Drawing.Color.DarkGreen
        Me.lblHorse5.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorse5.ForeColor = System.Drawing.Color.Gold
        Me.lblHorse5.Location = New System.Drawing.Point(158, 710)
        Me.lblHorse5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorse5.Name = "lblHorse5"
        Me.lblHorse5.Size = New System.Drawing.Size(112, 37)
        Me.lblHorse5.TabIndex = 23
        Me.lblHorse5.Text = "Horse 5"
        Me.lblHorse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStanding
        '
        Me.lblStanding.BackColor = System.Drawing.Color.Black
        Me.lblStanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStanding.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStanding.ForeColor = System.Drawing.Color.White
        Me.lblStanding.Location = New System.Drawing.Point(1006, 499)
        Me.lblStanding.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStanding.Name = "lblStanding"
        Me.lblStanding.Size = New System.Drawing.Size(140, 249)
        Me.lblStanding.TabIndex = 24
        Me.lblStanding.Text = "Standing"
        Me.lblStanding.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBoxHorse1Standing
        '
        Me.txtBoxHorse1Standing.BackColor = System.Drawing.Color.Black
        Me.txtBoxHorse1Standing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHorse1Standing.Enabled = False
        Me.txtBoxHorse1Standing.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHorse1Standing.ForeColor = System.Drawing.Color.Red
        Me.txtBoxHorse1Standing.Location = New System.Drawing.Point(1006, 527)
        Me.txtBoxHorse1Standing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxHorse1Standing.Name = "txtBoxHorse1Standing"
        Me.txtBoxHorse1Standing.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxHorse1Standing.TabIndex = 25
        Me.txtBoxHorse1Standing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxHorse2Standing
        '
        Me.txtBoxHorse2Standing.BackColor = System.Drawing.Color.Black
        Me.txtBoxHorse2Standing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHorse2Standing.Enabled = False
        Me.txtBoxHorse2Standing.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHorse2Standing.ForeColor = System.Drawing.Color.Red
        Me.txtBoxHorse2Standing.Location = New System.Drawing.Point(1006, 571)
        Me.txtBoxHorse2Standing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxHorse2Standing.Name = "txtBoxHorse2Standing"
        Me.txtBoxHorse2Standing.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxHorse2Standing.TabIndex = 26
        Me.txtBoxHorse2Standing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxHorse3Standing
        '
        Me.txtBoxHorse3Standing.BackColor = System.Drawing.Color.Black
        Me.txtBoxHorse3Standing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHorse3Standing.Enabled = False
        Me.txtBoxHorse3Standing.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHorse3Standing.ForeColor = System.Drawing.Color.Red
        Me.txtBoxHorse3Standing.Location = New System.Drawing.Point(1006, 617)
        Me.txtBoxHorse3Standing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxHorse3Standing.Name = "txtBoxHorse3Standing"
        Me.txtBoxHorse3Standing.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxHorse3Standing.TabIndex = 27
        Me.txtBoxHorse3Standing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxHorse4Standing
        '
        Me.txtBoxHorse4Standing.BackColor = System.Drawing.Color.Black
        Me.txtBoxHorse4Standing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHorse4Standing.Enabled = False
        Me.txtBoxHorse4Standing.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHorse4Standing.ForeColor = System.Drawing.Color.Red
        Me.txtBoxHorse4Standing.Location = New System.Drawing.Point(1006, 661)
        Me.txtBoxHorse4Standing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxHorse4Standing.Name = "txtBoxHorse4Standing"
        Me.txtBoxHorse4Standing.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxHorse4Standing.TabIndex = 28
        Me.txtBoxHorse4Standing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxHorse5Standing
        '
        Me.txtBoxHorse5Standing.BackColor = System.Drawing.Color.Black
        Me.txtBoxHorse5Standing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHorse5Standing.Enabled = False
        Me.txtBoxHorse5Standing.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHorse5Standing.ForeColor = System.Drawing.Color.Red
        Me.txtBoxHorse5Standing.Location = New System.Drawing.Point(1006, 705)
        Me.txtBoxHorse5Standing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBoxHorse5Standing.Name = "txtBoxHorse5Standing"
        Me.txtBoxHorse5Standing.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxHorse5Standing.TabIndex = 29
        Me.txtBoxHorse5Standing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1466, 851)
        Me.Controls.Add(Me.txtBoxHorse5Standing)
        Me.Controls.Add(Me.txtBoxHorse4Standing)
        Me.Controls.Add(Me.txtBoxHorse3Standing)
        Me.Controls.Add(Me.txtBoxHorse2Standing)
        Me.Controls.Add(Me.txtBoxHorse1Standing)
        Me.Controls.Add(Me.lblStanding)
        Me.Controls.Add(Me.lblHorse5)
        Me.Controls.Add(Me.lblHorse4)
        Me.Controls.Add(Me.lblHorse3)
        Me.Controls.Add(Me.lblHorse2)
        Me.Controls.Add(Me.lblHorse1)
        Me.Controls.Add(Me.pbHorse5)
        Me.Controls.Add(Me.pbHorse4)
        Me.Controls.Add(Me.pbHorse3)
        Me.Controls.Add(Me.pbHorse2)
        Me.Controls.Add(Me.pbHorse1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.btnStartRace)
        Me.Controls.Add(Me.btnPlaceBet)
        Me.Controls.Add(Me.lblRoundNumber)
        Me.Controls.Add(Me.txtBoxCurrentMoney)
        Me.Controls.Add(Me.lblCurrentMoney)
        Me.Controls.Add(Me.txtBoxCurrentBet)
        Me.Controls.Add(Me.lblCurrentBet)
        Me.Controls.Add(Me.txtBoxStartMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbHorse)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "HorseRacing!!"
        Me.gbHorse.ResumeLayout(False)
        Me.gbHorse.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbHorse As GroupBox
    Friend WithEvents rdoBtn3 As RadioButton
    Friend WithEvents rdoBtn2 As RadioButton
    Friend WithEvents rdoBtn1 As RadioButton
    Friend WithEvents rdoBtn5 As RadioButton
    Friend WithEvents rdoBtn4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxStartMoney As TextBox
    Friend WithEvents lblCurrentBet As Label
    Friend WithEvents txtBoxCurrentBet As TextBox
    Friend WithEvents lblCurrentMoney As Label
    Friend WithEvents txtBoxCurrentMoney As TextBox
    Friend WithEvents lblRoundNumber As Label
    Friend WithEvents btnPlaceBet As Button
    Friend WithEvents btnStartRace As Button
    Friend WithEvents lblRace As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents pbHorse1 As ProgressBar
    Friend WithEvents pbHorse2 As ProgressBar
    Friend WithEvents pbHorse3 As ProgressBar
    Friend WithEvents pbHorse4 As ProgressBar
    Friend WithEvents pbHorse5 As ProgressBar
    Friend WithEvents lblHorse1 As Label
    Friend WithEvents lblHorse2 As Label
    Friend WithEvents lblHorse3 As Label
    Friend WithEvents lblHorse4 As Label
    Friend WithEvents lblHorse5 As Label
    Friend WithEvents lblStanding As Label
    Friend WithEvents txtBoxHorse1Standing As TextBox
    Friend WithEvents txtBoxHorse2Standing As TextBox
    Friend WithEvents txtBoxHorse3Standing As TextBox
    Friend WithEvents txtBoxHorse4Standing As TextBox
    Friend WithEvents txtBoxHorse5Standing As TextBox
End Class
