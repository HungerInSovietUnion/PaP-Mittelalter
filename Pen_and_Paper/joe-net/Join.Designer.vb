<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Join
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_IP = New System.Windows.Forms.TextBox()
        Me.TB_Port = New System.Windows.Forms.TextBox()
        Me.B_Connect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beitreten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP-Adresse:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(64, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Port:"
        '
        'Tb_IP
        '
        Me.Tb_IP.Location = New System.Drawing.Point(114, 63)
        Me.Tb_IP.Name = "Tb_IP"
        Me.Tb_IP.Size = New System.Drawing.Size(158, 20)
        Me.Tb_IP.TabIndex = 2
        Me.Tb_IP.Text = "localhost"
        '
        'TB_Port
        '
        Me.TB_Port.Location = New System.Drawing.Point(114, 95)
        Me.TB_Port.Name = "TB_Port"
        Me.TB_Port.Size = New System.Drawing.Size(158, 20)
        Me.TB_Port.TabIndex = 2
        Me.TB_Port.Text = "8888"
        '
        'B_Connect
        '
        Me.B_Connect.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.B_Connect.Location = New System.Drawing.Point(90, 137)
        Me.B_Connect.Name = "B_Connect"
        Me.B_Connect.Size = New System.Drawing.Size(118, 33)
        Me.B_Connect.TabIndex = 3
        Me.B_Connect.Text = "Beitreten"
        Me.B_Connect.UseVisualStyleBackColor = True
        '
        'Join
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 181)
        Me.Controls.Add(Me.B_Connect)
        Me.Controls.Add(Me.TB_Port)
        Me.Controls.Add(Me.Tb_IP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Join"
        Me.Text = "Join"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_IP As TextBox
    Friend WithEvents TB_Port As TextBox
    Friend WithEvents B_Connect As Button
End Class
