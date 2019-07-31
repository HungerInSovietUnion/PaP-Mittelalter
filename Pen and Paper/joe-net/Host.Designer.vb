<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Host
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menue_Panel = New System.Windows.Forms.Panel()
        Me.Spieler_Button = New System.Windows.Forms.Button()
        Me.Chat_Button = New System.Windows.Forms.Button()
        Me.Beenden_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menue_Button = New System.Windows.Forms.Button()
        Me.Chat_Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chat_Sende_Button = New System.Windows.Forms.Button()
        Me.Chat_Sendebox = New System.Windows.Forms.TextBox()
        Me.Chat_Box = New System.Windows.Forms.RichTextBox()
        Me.Spieler_Panel = New System.Windows.Forms.Panel()
        Me.Kick_Button9 = New System.Windows.Forms.Button()
        Me.Kick_Button10 = New System.Windows.Forms.Button()
        Me.Kick_Button8 = New System.Windows.Forms.Button()
        Me.Kick_Button7 = New System.Windows.Forms.Button()
        Me.Kick_Button6 = New System.Windows.Forms.Button()
        Me.Kick_Button5 = New System.Windows.Forms.Button()
        Me.Kick_Button4 = New System.Windows.Forms.Button()
        Me.Kick_Button3 = New System.Windows.Forms.Button()
        Me.Kick_Button2 = New System.Windows.Forms.Button()
        Me.Status_Box10 = New System.Windows.Forms.TextBox()
        Me.Name_Box10 = New System.Windows.Forms.TextBox()
        Me.Status_Box9 = New System.Windows.Forms.TextBox()
        Me.Name_Box9 = New System.Windows.Forms.TextBox()
        Me.Status_Box8 = New System.Windows.Forms.TextBox()
        Me.Name_Box8 = New System.Windows.Forms.TextBox()
        Me.Status_Box7 = New System.Windows.Forms.TextBox()
        Me.Name_Box7 = New System.Windows.Forms.TextBox()
        Me.Status_Box6 = New System.Windows.Forms.TextBox()
        Me.Name_Box6 = New System.Windows.Forms.TextBox()
        Me.Status_Box5 = New System.Windows.Forms.TextBox()
        Me.Name_Box5 = New System.Windows.Forms.TextBox()
        Me.Status_Box4 = New System.Windows.Forms.TextBox()
        Me.Name_Box4 = New System.Windows.Forms.TextBox()
        Me.Status_Box3 = New System.Windows.Forms.TextBox()
        Me.Name_Box3 = New System.Windows.Forms.TextBox()
        Me.Status_Box2 = New System.Windows.Forms.TextBox()
        Me.Name_Box2 = New System.Windows.Forms.TextBox()
        Me.Status_Box1 = New System.Windows.Forms.TextBox()
        Me.Name_Box1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PingPong = New System.Windows.Forms.Timer(Me.components)
        Me.Player_Refresh = New System.Windows.Forms.Timer(Me.components)
        Me.PingPong2 = New System.Windows.Forms.Timer(Me.components)
        Me.Menue_Panel.SuspendLayout()
        Me.Chat_Panel.SuspendLayout()
        Me.Spieler_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menue_Panel
        '
        Me.Menue_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Menue_Panel.Controls.Add(Me.Spieler_Button)
        Me.Menue_Panel.Controls.Add(Me.Chat_Button)
        Me.Menue_Panel.Controls.Add(Me.Beenden_Button)
        Me.Menue_Panel.Controls.Add(Me.Label1)
        Me.Menue_Panel.Location = New System.Drawing.Point(93, 0)
        Me.Menue_Panel.Name = "Menue_Panel"
        Me.Menue_Panel.Size = New System.Drawing.Size(478, 46)
        Me.Menue_Panel.TabIndex = 1
        Me.Menue_Panel.Visible = False
        '
        'Spieler_Button
        '
        Me.Spieler_Button.Location = New System.Drawing.Point(238, 12)
        Me.Spieler_Button.Name = "Spieler_Button"
        Me.Spieler_Button.Size = New System.Drawing.Size(75, 23)
        Me.Spieler_Button.TabIndex = 4
        Me.Spieler_Button.Text = "Spieler"
        Me.Spieler_Button.UseVisualStyleBackColor = True
        '
        'Chat_Button
        '
        Me.Chat_Button.Location = New System.Drawing.Point(319, 12)
        Me.Chat_Button.Name = "Chat_Button"
        Me.Chat_Button.Size = New System.Drawing.Size(75, 23)
        Me.Chat_Button.TabIndex = 3
        Me.Chat_Button.Text = "Chat "
        Me.Chat_Button.UseVisualStyleBackColor = True
        '
        'Beenden_Button
        '
        Me.Beenden_Button.Location = New System.Drawing.Point(400, 12)
        Me.Beenden_Button.Name = "Beenden_Button"
        Me.Beenden_Button.Size = New System.Drawing.Size(75, 23)
        Me.Beenden_Button.TabIndex = 2
        Me.Beenden_Button.Text = "Beenden"
        Me.Beenden_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menü:"
        '
        'Menue_Button
        '
        Me.Menue_Button.Location = New System.Drawing.Point(12, 12)
        Me.Menue_Button.Name = "Menue_Button"
        Me.Menue_Button.Size = New System.Drawing.Size(75, 23)
        Me.Menue_Button.TabIndex = 0
        Me.Menue_Button.Text = "Menü"
        Me.Menue_Button.UseVisualStyleBackColor = True
        '
        'Chat_Panel
        '
        Me.Chat_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Chat_Panel.Controls.Add(Me.Label3)
        Me.Chat_Panel.Controls.Add(Me.Chat_Sende_Button)
        Me.Chat_Panel.Controls.Add(Me.Chat_Sendebox)
        Me.Chat_Panel.Controls.Add(Me.Chat_Box)
        Me.Chat_Panel.Location = New System.Drawing.Point(508, 52)
        Me.Chat_Panel.Name = "Chat_Panel"
        Me.Chat_Panel.Size = New System.Drawing.Size(314, 295)
        Me.Chat_Panel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Chat:"
        '
        'Chat_Sende_Button
        '
        Me.Chat_Sende_Button.Location = New System.Drawing.Point(236, 268)
        Me.Chat_Sende_Button.Name = "Chat_Sende_Button"
        Me.Chat_Sende_Button.Size = New System.Drawing.Size(75, 23)
        Me.Chat_Sende_Button.TabIndex = 2
        Me.Chat_Sende_Button.Text = "Senden"
        Me.Chat_Sende_Button.UseVisualStyleBackColor = True
        '
        'Chat_Sendebox
        '
        Me.Chat_Sendebox.Location = New System.Drawing.Point(3, 268)
        Me.Chat_Sendebox.Name = "Chat_Sendebox"
        Me.Chat_Sendebox.Size = New System.Drawing.Size(227, 20)
        Me.Chat_Sendebox.TabIndex = 1
        '
        'Chat_Box
        '
        Me.Chat_Box.Location = New System.Drawing.Point(3, 23)
        Me.Chat_Box.Name = "Chat_Box"
        Me.Chat_Box.Size = New System.Drawing.Size(308, 239)
        Me.Chat_Box.TabIndex = 0
        Me.Chat_Box.Text = ""
        '
        'Spieler_Panel
        '
        Me.Spieler_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button9)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button10)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button8)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button7)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button6)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button5)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button4)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button3)
        Me.Spieler_Panel.Controls.Add(Me.Kick_Button2)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box10)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box10)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box9)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box9)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box8)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box8)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box7)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box7)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box6)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box6)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box5)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box5)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box4)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box4)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box3)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box3)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box2)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box2)
        Me.Spieler_Panel.Controls.Add(Me.Status_Box1)
        Me.Spieler_Panel.Controls.Add(Me.Name_Box1)
        Me.Spieler_Panel.Controls.Add(Me.Label6)
        Me.Spieler_Panel.Controls.Add(Me.Label5)
        Me.Spieler_Panel.Controls.Add(Me.Label4)
        Me.Spieler_Panel.Controls.Add(Me.Label2)
        Me.Spieler_Panel.Location = New System.Drawing.Point(12, 52)
        Me.Spieler_Panel.Name = "Spieler_Panel"
        Me.Spieler_Panel.Size = New System.Drawing.Size(490, 314)
        Me.Spieler_Panel.TabIndex = 3
        '
        'Kick_Button9
        '
        Me.Kick_Button9.Location = New System.Drawing.Point(348, 255)
        Me.Kick_Button9.Name = "Kick_Button9"
        Me.Kick_Button9.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button9.TabIndex = 36
        Me.Kick_Button9.Text = "X"
        Me.Kick_Button9.UseVisualStyleBackColor = True
        '
        'Kick_Button10
        '
        Me.Kick_Button10.Location = New System.Drawing.Point(348, 281)
        Me.Kick_Button10.Name = "Kick_Button10"
        Me.Kick_Button10.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button10.TabIndex = 35
        Me.Kick_Button10.Text = "X"
        Me.Kick_Button10.UseVisualStyleBackColor = True
        '
        'Kick_Button8
        '
        Me.Kick_Button8.Location = New System.Drawing.Point(348, 229)
        Me.Kick_Button8.Name = "Kick_Button8"
        Me.Kick_Button8.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button8.TabIndex = 34
        Me.Kick_Button8.Text = "X"
        Me.Kick_Button8.UseVisualStyleBackColor = True
        '
        'Kick_Button7
        '
        Me.Kick_Button7.Location = New System.Drawing.Point(348, 203)
        Me.Kick_Button7.Name = "Kick_Button7"
        Me.Kick_Button7.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button7.TabIndex = 33
        Me.Kick_Button7.Text = "X"
        Me.Kick_Button7.UseVisualStyleBackColor = True
        '
        'Kick_Button6
        '
        Me.Kick_Button6.Location = New System.Drawing.Point(348, 177)
        Me.Kick_Button6.Name = "Kick_Button6"
        Me.Kick_Button6.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button6.TabIndex = 32
        Me.Kick_Button6.Text = "X"
        Me.Kick_Button6.UseVisualStyleBackColor = True
        '
        'Kick_Button5
        '
        Me.Kick_Button5.Location = New System.Drawing.Point(348, 151)
        Me.Kick_Button5.Name = "Kick_Button5"
        Me.Kick_Button5.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button5.TabIndex = 31
        Me.Kick_Button5.Text = "X"
        Me.Kick_Button5.UseVisualStyleBackColor = True
        '
        'Kick_Button4
        '
        Me.Kick_Button4.Location = New System.Drawing.Point(348, 125)
        Me.Kick_Button4.Name = "Kick_Button4"
        Me.Kick_Button4.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button4.TabIndex = 30
        Me.Kick_Button4.Text = "X"
        Me.Kick_Button4.UseVisualStyleBackColor = True
        '
        'Kick_Button3
        '
        Me.Kick_Button3.Location = New System.Drawing.Point(348, 99)
        Me.Kick_Button3.Name = "Kick_Button3"
        Me.Kick_Button3.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button3.TabIndex = 29
        Me.Kick_Button3.Text = "X"
        Me.Kick_Button3.UseVisualStyleBackColor = True
        '
        'Kick_Button2
        '
        Me.Kick_Button2.Location = New System.Drawing.Point(348, 73)
        Me.Kick_Button2.Name = "Kick_Button2"
        Me.Kick_Button2.Size = New System.Drawing.Size(28, 23)
        Me.Kick_Button2.TabIndex = 28
        Me.Kick_Button2.Text = "X"
        Me.Kick_Button2.UseVisualStyleBackColor = True
        '
        'Status_Box10
        '
        Me.Status_Box10.Enabled = False
        Me.Status_Box10.Location = New System.Drawing.Point(170, 281)
        Me.Status_Box10.Name = "Status_Box10"
        Me.Status_Box10.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box10.TabIndex = 26
        '
        'Name_Box10
        '
        Me.Name_Box10.Enabled = False
        Me.Name_Box10.Location = New System.Drawing.Point(7, 281)
        Me.Name_Box10.Name = "Name_Box10"
        Me.Name_Box10.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box10.TabIndex = 25
        '
        'Status_Box9
        '
        Me.Status_Box9.Enabled = False
        Me.Status_Box9.Location = New System.Drawing.Point(170, 255)
        Me.Status_Box9.Name = "Status_Box9"
        Me.Status_Box9.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box9.TabIndex = 24
        '
        'Name_Box9
        '
        Me.Name_Box9.Enabled = False
        Me.Name_Box9.Location = New System.Drawing.Point(7, 255)
        Me.Name_Box9.Name = "Name_Box9"
        Me.Name_Box9.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box9.TabIndex = 23
        '
        'Status_Box8
        '
        Me.Status_Box8.Enabled = False
        Me.Status_Box8.Location = New System.Drawing.Point(172, 229)
        Me.Status_Box8.Name = "Status_Box8"
        Me.Status_Box8.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box8.TabIndex = 22
        '
        'Name_Box8
        '
        Me.Name_Box8.Enabled = False
        Me.Name_Box8.Location = New System.Drawing.Point(9, 229)
        Me.Name_Box8.Name = "Name_Box8"
        Me.Name_Box8.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box8.TabIndex = 21
        '
        'Status_Box7
        '
        Me.Status_Box7.Enabled = False
        Me.Status_Box7.Location = New System.Drawing.Point(172, 203)
        Me.Status_Box7.Name = "Status_Box7"
        Me.Status_Box7.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box7.TabIndex = 20
        '
        'Name_Box7
        '
        Me.Name_Box7.Enabled = False
        Me.Name_Box7.Location = New System.Drawing.Point(9, 203)
        Me.Name_Box7.Name = "Name_Box7"
        Me.Name_Box7.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box7.TabIndex = 19
        '
        'Status_Box6
        '
        Me.Status_Box6.Enabled = False
        Me.Status_Box6.Location = New System.Drawing.Point(172, 177)
        Me.Status_Box6.Name = "Status_Box6"
        Me.Status_Box6.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box6.TabIndex = 18
        '
        'Name_Box6
        '
        Me.Name_Box6.Enabled = False
        Me.Name_Box6.Location = New System.Drawing.Point(9, 177)
        Me.Name_Box6.Name = "Name_Box6"
        Me.Name_Box6.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box6.TabIndex = 17
        '
        'Status_Box5
        '
        Me.Status_Box5.Enabled = False
        Me.Status_Box5.Location = New System.Drawing.Point(172, 151)
        Me.Status_Box5.Name = "Status_Box5"
        Me.Status_Box5.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box5.TabIndex = 16
        '
        'Name_Box5
        '
        Me.Name_Box5.Enabled = False
        Me.Name_Box5.Location = New System.Drawing.Point(9, 151)
        Me.Name_Box5.Name = "Name_Box5"
        Me.Name_Box5.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box5.TabIndex = 15
        '
        'Status_Box4
        '
        Me.Status_Box4.Enabled = False
        Me.Status_Box4.Location = New System.Drawing.Point(172, 125)
        Me.Status_Box4.Name = "Status_Box4"
        Me.Status_Box4.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box4.TabIndex = 14
        '
        'Name_Box4
        '
        Me.Name_Box4.Enabled = False
        Me.Name_Box4.Location = New System.Drawing.Point(9, 125)
        Me.Name_Box4.Name = "Name_Box4"
        Me.Name_Box4.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box4.TabIndex = 13
        '
        'Status_Box3
        '
        Me.Status_Box3.Enabled = False
        Me.Status_Box3.Location = New System.Drawing.Point(172, 99)
        Me.Status_Box3.Name = "Status_Box3"
        Me.Status_Box3.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box3.TabIndex = 12
        '
        'Name_Box3
        '
        Me.Name_Box3.Enabled = False
        Me.Name_Box3.Location = New System.Drawing.Point(9, 99)
        Me.Name_Box3.Name = "Name_Box3"
        Me.Name_Box3.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box3.TabIndex = 11
        '
        'Status_Box2
        '
        Me.Status_Box2.Enabled = False
        Me.Status_Box2.Location = New System.Drawing.Point(172, 73)
        Me.Status_Box2.Name = "Status_Box2"
        Me.Status_Box2.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box2.TabIndex = 10
        '
        'Name_Box2
        '
        Me.Name_Box2.Enabled = False
        Me.Name_Box2.Location = New System.Drawing.Point(9, 73)
        Me.Name_Box2.Name = "Name_Box2"
        Me.Name_Box2.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box2.TabIndex = 9
        '
        'Status_Box1
        '
        Me.Status_Box1.Enabled = False
        Me.Status_Box1.Location = New System.Drawing.Point(172, 47)
        Me.Status_Box1.Name = "Status_Box1"
        Me.Status_Box1.Size = New System.Drawing.Size(151, 20)
        Me.Status_Box1.TabIndex = 8
        '
        'Name_Box1
        '
        Me.Name_Box1.Enabled = False
        Me.Name_Box1.Location = New System.Drawing.Point(9, 47)
        Me.Name_Box1.Name = "Name_Box1"
        Me.Name_Box1.Size = New System.Drawing.Size(154, 20)
        Me.Name_Box1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Rauswerfen:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Spieler:"
        '
        'PingPong
        '
        Me.PingPong.Enabled = True
        Me.PingPong.Interval = 15000
        '
        'Player_Refresh
        '
        Me.Player_Refresh.Enabled = True
        '
        'PingPong2
        '
        Me.PingPong2.Interval = 10000
        '
        'Host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1926, 997)
        Me.Controls.Add(Me.Spieler_Panel)
        Me.Controls.Add(Me.Chat_Panel)
        Me.Controls.Add(Me.Menue_Button)
        Me.Controls.Add(Me.Menue_Panel)
        Me.Name = "Host"
        Me.Text = "Host"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menue_Panel.ResumeLayout(False)
        Me.Menue_Panel.PerformLayout()
        Me.Chat_Panel.ResumeLayout(False)
        Me.Chat_Panel.PerformLayout()
        Me.Spieler_Panel.ResumeLayout(False)
        Me.Spieler_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menue_Panel As Panel
    Friend WithEvents Menue_Button As Button
    Friend WithEvents Beenden_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Chat_Panel As Panel
    Friend WithEvents Chat_Box As RichTextBox
    Friend WithEvents Chat_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Chat_Sende_Button As Button
    Friend WithEvents Chat_Sendebox As TextBox
    Friend WithEvents Spieler_Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Status_Box10 As TextBox
    Friend WithEvents Name_Box10 As TextBox
    Friend WithEvents Status_Box9 As TextBox
    Friend WithEvents Name_Box9 As TextBox
    Friend WithEvents Status_Box8 As TextBox
    Friend WithEvents Name_Box8 As TextBox
    Friend WithEvents Status_Box7 As TextBox
    Friend WithEvents Name_Box7 As TextBox
    Friend WithEvents Status_Box6 As TextBox
    Friend WithEvents Name_Box6 As TextBox
    Friend WithEvents Status_Box5 As TextBox
    Friend WithEvents Name_Box5 As TextBox
    Friend WithEvents Status_Box4 As TextBox
    Friend WithEvents Name_Box4 As TextBox
    Friend WithEvents Status_Box3 As TextBox
    Friend WithEvents Name_Box3 As TextBox
    Friend WithEvents Status_Box2 As TextBox
    Friend WithEvents Name_Box2 As TextBox
    Friend WithEvents Status_Box1 As TextBox
    Friend WithEvents Name_Box1 As TextBox
    Friend WithEvents Kick_Button8 As Button
    Friend WithEvents Kick_Button7 As Button
    Friend WithEvents Kick_Button6 As Button
    Friend WithEvents Kick_Button5 As Button
    Friend WithEvents Kick_Button4 As Button
    Friend WithEvents Kick_Button3 As Button
    Friend WithEvents Kick_Button2 As Button
    Friend WithEvents Kick_Button9 As Button
    Friend WithEvents Kick_Button10 As Button
    Friend WithEvents Spieler_Button As Button
    Friend WithEvents PingPong As Timer
    Friend WithEvents Player_Refresh As Timer
    Friend WithEvents PingPong2 As Timer
End Class
