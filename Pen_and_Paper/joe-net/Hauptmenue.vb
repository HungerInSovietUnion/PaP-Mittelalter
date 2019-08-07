Imports System
Imports System.IO
Imports System.Text
Imports System.Environment



Public Class Hauptmenue
    'Variabeln ...
    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public YourPath As String = appData + "\Joe-Apps\Profil"
    Public YourPath2 As String = appData + "\Joe-Apps\Pen and Paper - Mittelalter\Karaktere"
    Public C_Name As String
    Public C_SN As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HMenue_Panel.Dock = DockStyle.Fill

        'Create Path
        If (Not System.IO.Directory.Exists(YourPath)) Then
            System.IO.Directory.CreateDirectory(YourPath)
        End If
        If (Not System.IO.Directory.Exists(YourPath2)) Then
            System.IO.Directory.CreateDirectory(YourPath2)
        End If



        'Check Porfiel data

        If (Not System.IO.File.Exists(YourPath + "\pro.joe")) Then

            Button_Optionen.Enabled = False
            Button_Spielen.Enabled = False
            MsgBox("Du musst erst ein Profil erstellen")
            fmsg_Pro.Show()

        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(YourPath + "\pro.joe")
            Dim pro() As String = fileReader.Split(";")
            L_SN.Text = pro(0)
            L_NAME.Text = pro(1)

            C_SN = pro(0)
            C_Name = pro(1)


        End If







    End Sub

    Private Sub Button_Beenden_Click(sender As Object, e As EventArgs) Handles Button_Beenden.Click
        Me.Close()
    End Sub

    Private Sub Button_Optionen_Click(sender As Object, e As EventArgs) Handles Button_Optionen.Click
        HMenue_Panel.Visible = False
        Optionen_Panel.Visible = True
        HMenue_Panel.Dock = DockStyle.None
        Optionen_Panel.Dock = DockStyle.Fill


    End Sub

    Private Sub Button_Spielen_Click(sender As Object, e As EventArgs) Handles Button_Spielen.Click
        Spiel_Panel.Visible = True
        HMenue_Panel.Visible = False
        Spiel_Panel.Dock = DockStyle.Fill
        HMenue_Panel.Dock = DockStyle.None

    End Sub
    Private Sub B_Button1_Click(sender As Object, e As EventArgs) Handles B_Button1.Click
        Spiel_Panel.Visible = False
        HMenue_Panel.Visible = True
        Spiel_Panel.Dock = DockStyle.None
        HMenue_Panel.Dock = DockStyle.Fill

    End Sub

    Private Sub Profil_Button_Click(sender As Object, e As EventArgs) Handles Profil_Button.Click
        Optionen_Panel.Visible = False
        Profil_Panel.Visible = True
        Optionen_Panel.Dock = DockStyle.None
        Profil_Panel.Dock = DockStyle.Fill


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Optionen_Panel.Visible = False
        HMenue_Panel.Visible = True
        Optionen_Panel.Dock = DockStyle.None
        HMenue_Panel.Dock = DockStyle.Fill

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Profil_Panel.Visible = False
        Optionen_Panel.Visible = True
        Profil_Panel.Dock = DockStyle.None
        Optionen_Panel.Dock = DockStyle.Fill

    End Sub
    Private Sub Button_Host_Click(sender As Object, e As EventArgs) Handles Button_Host.Click
        Host.Show()
    End Sub

    Private Sub Join_Button_Click(sender As Object, e As EventArgs) Handles Join_Button.Click
        Join.Show()
    End Sub


    Private Sub Profiel_Info_Button_Click(sender As Object, e As EventArgs) Handles Profiel_Info_Button.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(YourPath + "\pro.joe")
        Dim pro() As String = fileReader.Split(";")
        MsgBox("Seriennummer: " + pro(0) + vbCrLf + "Name: " + pro(1))
    End Sub

    Private Sub Neues_Profiel_Button_Click(sender As Object, e As EventArgs) Handles Neues_Profiel_Button.Click
        Select Case MessageBox.Show("Wenn du ein neues Profiel erstellst wird das alte ersetzt" + vbCrLf + "willst du dennoch ein neues Profil erstellen", "Neues Profil", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                My.Computer.FileSystem.DeleteFile(YourPath + "\pro.joe")
                fmsg_Pro.Show()

            Case Windows.Forms.DialogResult.No
                'Code für Nein
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CharacterC.Show()

    End Sub
End Class
