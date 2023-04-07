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
        btn_Roll = New Button()
        lsb_Dice = New ListBox()
        tbx_Cash = New TextBox()
        tbx_Bank = New TextBox()
        btn_Reset = New Button()
        btn_Close = New Button()
        tbx_BetAmount = New TextBox()
        cmb_RollValue = New ComboBox()
        cmb_DifficultyLevel = New ComboBox()
        lbl_RollValue = New Label()
        lbl_DifficultyLevel = New Label()
        SuspendLayout()
        ' 
        ' btn_Roll
        ' 
        btn_Roll.Location = New Point(127, 944)
        btn_Roll.Name = "btn_Roll"
        btn_Roll.Size = New Size(101, 46)
        btn_Roll.TabIndex = 0
        btn_Roll.Text = "Roll"
        btn_Roll.UseVisualStyleBackColor = True
        ' 
        ' lsb_Dice
        ' 
        lsb_Dice.FormattingEnabled = True
        lsb_Dice.ItemHeight = 32
        lsb_Dice.Location = New Point(127, 163)
        lsb_Dice.Name = "lsb_Dice"
        lsb_Dice.Size = New Size(443, 740)
        lsb_Dice.TabIndex = 1
        ' 
        ' tbx_Cash
        ' 
        tbx_Cash.Location = New Point(370, 948)
        tbx_Cash.Name = "tbx_Cash"
        tbx_Cash.ReadOnly = True
        tbx_Cash.Size = New Size(200, 39)
        tbx_Cash.TabIndex = 2
        ' 
        ' tbx_Bank
        ' 
        tbx_Bank.Location = New Point(370, 1037)
        tbx_Bank.Name = "tbx_Bank"
        tbx_Bank.ReadOnly = True
        tbx_Bank.Size = New Size(200, 39)
        tbx_Bank.TabIndex = 3
        ' 
        ' btn_Reset
        ' 
        btn_Reset.Location = New Point(245, 944)
        btn_Reset.Name = "btn_Reset"
        btn_Reset.Size = New Size(101, 46)
        btn_Reset.TabIndex = 4
        btn_Reset.Text = "Reset"
        btn_Reset.UseVisualStyleBackColor = True
        ' 
        ' btn_Close
        ' 
        btn_Close.Location = New Point(127, 1033)
        btn_Close.Name = "btn_Close"
        btn_Close.Size = New Size(101, 46)
        btn_Close.TabIndex = 5
        btn_Close.Text = "Close"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' tbx_BetAmount
        ' 
        tbx_BetAmount.Location = New Point(245, 1037)
        tbx_BetAmount.Name = "tbx_BetAmount"
        tbx_BetAmount.Size = New Size(101, 39)
        tbx_BetAmount.TabIndex = 6
        ' 
        ' cmb_RollValue
        ' 
        cmb_RollValue.FormattingEnabled = True
        cmb_RollValue.Location = New Point(127, 90)
        cmb_RollValue.Name = "cmb_RollValue"
        cmb_RollValue.Size = New Size(171, 40)
        cmb_RollValue.TabIndex = 7
        ' 
        ' cmb_DifficultyLevel
        ' 
        cmb_DifficultyLevel.FormattingEnabled = True
        cmb_DifficultyLevel.Location = New Point(328, 90)
        cmb_DifficultyLevel.Name = "cmb_DifficultyLevel"
        cmb_DifficultyLevel.Size = New Size(242, 40)
        cmb_DifficultyLevel.TabIndex = 9
        ' 
        ' lbl_RollValue
        ' 
        lbl_RollValue.AutoSize = True
        lbl_RollValue.Location = New Point(128, 55)
        lbl_RollValue.Name = "lbl_RollValue"
        lbl_RollValue.Size = New Size(169, 32)
        lbl_RollValue.TabIndex = 10
        lbl_RollValue.Text = "Lucky Number"' 
        ' lbl_DifficultyLevel
        ' 
        lbl_DifficultyLevel.AutoSize = True
        lbl_DifficultyLevel.Location = New Point(365, 55)
        lbl_DifficultyLevel.Name = "lbl_DifficultyLevel"
        lbl_DifficultyLevel.Size = New Size(172, 32)
        lbl_DifficultyLevel.TabIndex = 11
        lbl_DifficultyLevel.Text = "Difficulty Level"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 1191)
        Controls.Add(lbl_DifficultyLevel)
        Controls.Add(lbl_RollValue)
        Controls.Add(cmb_DifficultyLevel)
        Controls.Add(cmb_RollValue)
        Controls.Add(tbx_BetAmount)
        Controls.Add(btn_Close)
        Controls.Add(btn_Reset)
        Controls.Add(tbx_Bank)
        Controls.Add(tbx_Cash)
        Controls.Add(lsb_Dice)
        Controls.Add(btn_Roll)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Roll As Button
    Friend WithEvents lsb_Dice As ListBox
    Friend WithEvents tbx_Cash As TextBox
    Friend WithEvents tbx_Bank As TextBox
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents tbx_BetAmount As TextBox
    Friend WithEvents cmb_RollValue As ComboBox
    Friend WithEvents cmb_DifficultyLevel As ComboBox
    Friend WithEvents lbl_RollValue As Label
    Friend WithEvents lbl_DifficultyLevel As Label
End Class
