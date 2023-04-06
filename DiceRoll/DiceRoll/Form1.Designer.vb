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
        tbx_Count = New TextBox()
        tbx_Money = New TextBox()
        btn_Reset = New Button()
        btn_Close = New Button()
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
        ' tbx_Count
        ' 
        tbx_Count.Location = New Point(370, 948)
        tbx_Count.Name = "tbx_Count"
        tbx_Count.Size = New Size(200, 39)
        tbx_Count.TabIndex = 2
        ' 
        ' tbx_Money
        ' 
        tbx_Money.Location = New Point(370, 1033)
        tbx_Money.Name = "tbx_Money"
        tbx_Money.Size = New Size(200, 39)
        tbx_Money.TabIndex = 3
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
        btn_Close.Size = New Size(219, 46)
        btn_Close.TabIndex = 5
        btn_Close.Text = "Close"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 1191)
        Controls.Add(btn_Close)
        Controls.Add(btn_Reset)
        Controls.Add(tbx_Money)
        Controls.Add(tbx_Count)
        Controls.Add(lsb_Dice)
        Controls.Add(btn_Roll)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Roll As Button
    Friend WithEvents lsb_Dice As ListBox
    Friend WithEvents tbx_Count As TextBox
    Friend WithEvents tbx_Money As TextBox
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Close As Button
End Class
