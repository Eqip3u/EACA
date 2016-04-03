<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.box = New System.Windows.Forms.TextBox()
        Me.buttonGame = New System.Windows.Forms.Button()
        Me.exitGame = New System.Windows.Forms.Button()
        Me.replayGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueCyr", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(226, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Игра ""Угадай число""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Введите число от 1 до 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'box
        '
        Me.box.Location = New System.Drawing.Point(297, 128)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(100, 20)
        Me.box.TabIndex = 1
        '
        'buttonGame
        '
        Me.buttonGame.Location = New System.Drawing.Point(269, 207)
        Me.buttonGame.Name = "buttonGame"
        Me.buttonGame.Size = New System.Drawing.Size(150, 50)
        Me.buttonGame.TabIndex = 2
        Me.buttonGame.Text = "Пуск"
        Me.buttonGame.UseVisualStyleBackColor = True
        '
        'exitGame
        '
        Me.exitGame.Location = New System.Drawing.Point(511, 373)
        Me.exitGame.Name = "exitGame"
        Me.exitGame.Size = New System.Drawing.Size(95, 50)
        Me.exitGame.TabIndex = 3
        Me.exitGame.Text = "Выход"
        Me.exitGame.UseVisualStyleBackColor = True
        '
        'replayGame
        '
        Me.replayGame.Location = New System.Drawing.Point(105, 374)
        Me.replayGame.Name = "replayGame"
        Me.replayGame.Size = New System.Drawing.Size(106, 49)
        Me.replayGame.TabIndex = 4
        Me.replayGame.Text = "Повторить"
        Me.replayGame.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 485)
        Me.Controls.Add(Me.replayGame)
        Me.Controls.Add(Me.exitGame)
        Me.Controls.Add(Me.buttonGame)
        Me.Controls.Add(Me.box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents box As TextBox
    Friend WithEvents buttonGame As Button
    Friend WithEvents exitGame As Button
    Friend WithEvents replayGame As Button
End Class
