<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmsg_Pro
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
        Me.TB_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.L_SN = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Name
        '
        Me.TB_Name.Location = New System.Drawing.Point(97, 53)
        Me.TB_Name.Name = "TB_Name"
        Me.TB_Name.Size = New System.Drawing.Size(100, 20)
        Me.TB_Name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serien-Nummer"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(124, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'L_SN
        '
        Me.L_SN.AutoSize = True
        Me.L_SN.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.L_SN.Location = New System.Drawing.Point(197, 22)
        Me.L_SN.Name = "L_SN"
        Me.L_SN.Size = New System.Drawing.Size(0, 16)
        Me.L_SN.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.Button2.Location = New System.Drawing.Point(15, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fmsg_Pro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 174)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.L_SN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Name)
        Me.Name = "fmsg_Pro"
        Me.Text = "Profil erstellen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents L_SN As Label
    Friend WithEvents Button2 As Button
End Class
