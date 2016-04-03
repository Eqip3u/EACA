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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeftBox = New System.Windows.Forms.TextBox()
        Me.RightBox = New System.Windows.Forms.TextBox()
        Me.LeftList = New System.Windows.Forms.ListBox()
        Me.RightList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Результат"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Сложение целочисленных чисел"
        '
        'LeftBox
        '
        Me.LeftBox.Location = New System.Drawing.Point(64, 179)
        Me.LeftBox.Name = "LeftBox"
        Me.LeftBox.Size = New System.Drawing.Size(140, 20)
        Me.LeftBox.TabIndex = 2
        '
        'RightBox
        '
        Me.RightBox.Location = New System.Drawing.Point(377, 179)
        Me.RightBox.Name = "RightBox"
        Me.RightBox.Size = New System.Drawing.Size(150, 20)
        Me.RightBox.TabIndex = 3
        '
        'LeftList
        '
        Me.LeftList.FormattingEnabled = True
        Me.LeftList.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.LeftList.Location = New System.Drawing.Point(86, 210)
        Me.LeftList.Name = "LeftList"
        Me.LeftList.Size = New System.Drawing.Size(51, 69)
        Me.LeftList.TabIndex = 4
        '
        'RightList
        '
        Me.RightList.FormattingEnabled = True
        Me.RightList.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.RightList.Location = New System.Drawing.Point(430, 210)
        Me.RightList.Name = "RightList"
        Me.RightList.Size = New System.Drawing.Size(51, 69)
        Me.RightList.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "+"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 418)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RightList)
        Me.Controls.Add(Me.LeftList)
        Me.Controls.Add(Me.RightBox)
        Me.Controls.Add(Me.LeftBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LeftBox As TextBox
    Friend WithEvents RightBox As TextBox
    Friend WithEvents LeftList As ListBox
    Friend WithEvents RightList As ListBox
    Friend WithEvents Label2 As Label
End Class
