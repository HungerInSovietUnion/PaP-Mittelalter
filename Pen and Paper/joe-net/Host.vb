
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class Host

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Public IP As String
    Public Port As String
    'Spieler SN

    Public PN01 As String
    Public PN02 As String
    Public PN03 As String
    Public PN04 As String
    Public PN05 As String
    Public PN06 As String
    Public PN07 As String
    Public PN08 As String
    Public PN09 As String
    Public PN10 As String


    Public P01 As String
    Public P02 As String
    Public P03 As String
    Public P04 As String
    Public P05 As String
    Public P06 As String
    Public P07 As String
    Public P08 As String
    Public P09 As String
    Public P10 As String
    'Public P11 As String ' Wenn mehr spieler, Hier erweitern

    'Spieler Status
    Public PS01 As String
    Public PS02 As String
    Public PS03 As String
    Public PS04 As String
    Public PS05 As String
    Public PS06 As String
    Public PS07 As String
    Public PS08 As String
    Public PS09 As String
    Public PS10 As String
    'Public PS11 As String ' Wenn mehr spieler, Hier erweitern




    'netstream reader
    Private Sub AddItem(ByVal s As String)


        'Command Executer
        Try
            'MsgBox(s) 'Debugg
            'MsgBox(P01 + vbCrLf + P02 + vbCrLf + P03 + vbCrLf + P04 + vbCrLf + P05 + vbCrLf + P06 + vbCrLf + P07 + vbCrLf + P08 + vbCrLf + P09 + vbCrLf + P10 + vbCrLf + PS01 + vbCrLf + PS02 + vbCrLf + PS03 + vbCrLf + PS04 + vbCrLf + PS05 + vbCrLf + PS06 + vbCrLf + PS07 + vbCrLf + PS08 + vbCrLf + PS09 + vbCrLf + PS10 + vbCrLf)
            Dim Connect() As String = s.Split(":")

            'First Connect and Reconnect
            If Connect(0) = "CON" Then
                Dim NC As Boolean = True
                If Connect(1) = P01 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box1.Text = "Connected"
                    PS01 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P02 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box2.Text = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P03 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box3.Text = "Connected"
                    PS03 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P04 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box4.Text = "Connected"
                    PS04 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P05 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box5.Text = "Connected"
                    PS05 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P06 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box6.Text = "Connected"
                    PS06 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P07 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box7.Text = "Connected"
                    PS07 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P08 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box8.Text = "Connected"
                    PS08 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P09 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box9.Text = "Connected"
                    PS09 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If
                If Connect(1) = P10 Then

                    streamw.Write("CHT:" + Connect(2) + " hat sich wieder verbunden" + vbCrLf)
                    streamw.Flush()
                    NC = False
                    Status_Box10.Text = "Connected"
                    PS10 = "Connected"
                    streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                    streamw.Flush()

                End If

                'ElseIf Connect(1) = P11 Then 'Wenn mehr spieler, Hier erweitern

                ' Wenn spieler sich noch nicht verbunden hatte bekommt er hier ein spieler zugewiesen

                If NC = True Then
                    If P01 = "" Then
                        P01 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box1.Text = Connect(2)
                        Status_Box1.Text = "Connected"
                        PS01 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN01 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
                        streamw.Flush()
                    End If
                End If

                If NC = True Then
                    If P02 = "" Then
                        P02 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box2.Text = Connect(2)
                        Status_Box2.Text = "Connected"
                        PS02 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN02 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P03 = "" Then
                        P03 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box3.Text = Connect(2)
                        Status_Box3.Text = "Connected"
                        PS03 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN03 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P04 = "" Then
                        P04 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box4.Text = Connect(2)
                        Status_Box4.Text = "Connected"
                        PS04 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN04 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P05 = "" Then
                        P05 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box5.Text = Connect(2)
                        Status_Box5.Text = "Connected"
                        PS05 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN05 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P06 = "" Then
                        P06 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box6.Text = Connect(2)
                        Status_Box6.Text = "Connected"
                        PS06 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN06 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P07 = "" Then
                        P07 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box7.Text = Connect(2)
                        Status_Box7.Text = "Connected"
                        PS07 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN07 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P08 = "" Then
                        P08 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box8.Text = Connect(2)
                        Status_Box8.Text = "Connected"
                        PS08 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN08 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P09 = "" Then
                        P09 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box9.Text = Connect(2)
                        Status_Box9.Text = "Connected"
                        PS09 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN09 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If
                If NC = True Then
                    If P10 = "" Then
                        P10 = Connect(1)
                        streamw.Write("CHT:" + Connect(2) + " hat sich verbunden" + vbCrLf)
                        streamw.Flush()
                        NC = False
                        Name_Box10.Text = Connect(2)
                        Status_Box10.Text = "Connected"
                        PS10 = "Connected"
                        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
                        streamw.Flush()
                        PN10 = Connect(2)
                        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)

                        streamw.Flush()
                    End If
                End If


                'If P11 = "" Then 'Wenn mehr spieler, Hier erweitern
            End If

            'Ping-Pong H
            If Connect(0) = "PON" Then
                If Connect(1) = P01 Then
                    Status_Box1.Text = "Connected"
                    PS01 = "Connected"
                End If
                If Connect(1) = P02 Then
                    Status_Box2.Text = "Connected"
                    PS02 = "Connected"
                End If
                If Connect(1) = P03 Then
                    Status_Box3.Text = "Connected"
                    PS03 = "Connected"
                End If
                If Connect(1) = P04 Then
                    Status_Box4.Text = "Connected"
                    PS04 = "Connected"
                End If
                If Connect(1) = P05 Then
                    Status_Box5.Text = "Connected"
                    PS05 = "Connected"
                End If
                If Connect(1) = P06 Then
                    Status_Box6.Text = "Connected"
                    PS06 = "Connected"
                End If
                If Connect(1) = P07 Then
                    Status_Box7.Text = "Connected"
                    PS07 = "Connected"
                End If
                If Connect(1) = P08 Then
                    Status_Box8.Text = "Connected"
                    PS08 = "Connected"
                End If
                If Connect(1) = P09 Then
                    Status_Box9.Text = "Connected"
                    PS09 = "Connected"
                End If
                If Connect(1) = P10 Then
                    Status_Box10.Text = "Connected"
                    PS10 = "Connected"
                End If
            End If

            'Ping Pong C
            If Connect(0) = "PIN" Then
                streamw.WriteLine("PON:" + Hauptmenue.C_SN)
                streamw.Flush()
            End If

            'Chat (alle)
            If Connect(0) = "CHT" Then
                Chat_Box.Text = Chat_Box.Text + Connect(1) + vbCrLf
            End If


        Catch ex As Exception
        End Try
        'Weiter....
        'RichTextBox1.Text = RichTextBox1.Text + s + vbCrLf
    End Sub


    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                MsgBox("Verbindung zu Server Abgebrochen")
                t.Interrupt()
                t.Abort()
                Close()
            End Try
        End While
    End Sub

    Private Sub Host_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'externer server beenden
        Try
            client.Close()
            Process.GetProcessesByName("Joe-Net-ServerH")(0).Kill()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Host_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'server starten
        Try
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\Joe-Net-ServerH.exe", My.Resources.Joe_Net_ServerH, False)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\Joe-Net-ServerH.exe")
        Catch ex As Exception
            MsgBox("Es Läuft Bereits Eine Anwendung mit Port 8888")
        End Try

        'verbindungs variablen
        IP = "127.0.0.1"
        Port = 8888

        'verbindungs aufbau
        Try
            client.Connect(IP, Port) ' hier die ip des servers eintragen. 

            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine("CON:" + Hauptmenue.C_SN + ":" + Hauptmenue.C_Name)
                streamw.Flush()
                t.Start()

            End If
        Catch ex As Exception
            MsgBox("Verbindung zu Server konnte nicht hergestellt werden")
            Try
                t.Interrupt()
                t.Abort()
            Catch exx As Exception

            End Try
            Close()

        End Try

        'Ping start
        PingPong.Start()
    End Sub




    'Menü Buttons
    Private Sub Menue_Button_Click(sender As Object, e As EventArgs) Handles Menue_Button.Click
        If Menue_Panel.Visible = False Then
            Menue_Panel.Visible = True
        Else
            Menue_Panel.Visible = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Beenden_Button.Click
        Select Case MessageBox.Show("Willst du das Spiel wirklich verlassen", "Spiel Beenden", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                Select Case MessageBox.Show("Bist du dir sicher", "Spiel Beenden", MessageBoxButtons.YesNo)
                    Case Windows.Forms.DialogResult.Yes
                        Select Case MessageBox.Show("Wirklich ?", "Spiel Beenden", MessageBoxButtons.YesNo)
                            Case Windows.Forms.DialogResult.Yes
                                Me.Close()

                            Case Windows.Forms.DialogResult.No
                                'Code für Nein
                        End Select
                    Case Windows.Forms.DialogResult.No
                        'Code für Nein
                End Select
            Case Windows.Forms.DialogResult.No
                'Code für Nein
        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Chat_Button.Click
        If Chat_Panel.Visible = False Then
            Chat_Panel.Visible = True
        Else
            Chat_Panel.Visible = False
        End If
    End Sub
    Private Sub Spieler_Button_Click(sender As Object, e As EventArgs) Handles Spieler_Button.Click
        If Spieler_Panel.Visible = False Then
            Spieler_Panel.Visible = True
        Else
            Spieler_Panel.Visible = False
        End If



    End Sub
    Private Sub Chat_Sende_Button_Click(sender As Object, e As EventArgs) Handles Chat_Sende_Button.Click

        streamw.Write("CHT:" + Hauptmenue.C_Name + " ; " + Chat_Sendebox.Text + vbCrLf)
        streamw.Flush()
    End Sub



    'Timer
    Private Sub Player_Refresh_Tick(sender As Object, e As EventArgs) Handles Player_Refresh.Tick
        Status_Box1.Text = PS01
        Status_Box2.Text = PS02
        Status_Box3.Text = PS03
        Status_Box4.Text = PS04
        Status_Box5.Text = PS05
        Status_Box6.Text = PS06
        Status_Box7.Text = PS07
        Status_Box8.Text = PS08
        Status_Box9.Text = PS09
        Status_Box10.Text = PS10

        Name_Box1.Text = PN01
        Name_Box2.Text = PN02
        Name_Box3.Text = PN03
        Name_Box4.Text = PN04
        Name_Box5.Text = PN05
        Name_Box6.Text = PN06
        Name_Box7.Text = PN07
        Name_Box8.Text = PN08
        Name_Box9.Text = PN09
        Name_Box10.Text = PN10

    End Sub
    Private Sub PingPong_Tick(sender As Object, e As EventArgs) Handles PingPong.Tick
        streamw.WriteLine("PIN:" + vbCrLf)
        streamw.Flush()

        If PS01 = "Connected" Then
            PS01 = "Ping"
        End If

        If PS02 = "Connected" Then
            PS02 = "Ping"
        End If

        If PS03 = "Connected" Then
            PS03 = "Ping"
        End If

        If PS04 = "Connected" Then
            PS04 = "Ping"
        End If

        If PS05 = "Connected" Then
            PS05 = "Ping"
        End If

        If PS06 = "Connected" Then
            PS06 = "Ping"
        End If

        If PS07 = "Connected" Then
            PS07 = "Ping"
        End If

        If PS08 = "Connected" Then
            PS08 = "Ping"
        End If

        If PS09 = "Connected" Then
            PS09 = "Ping"
        End If

        If PS10 = "Connected" Then
            PS10 = "Ping"
        End If

        'PS11="Ping"' 

        PingPong2.Enabled = True


    End Sub
    Private Sub PingPong2_Tick(sender As Object, e As EventArgs) Handles PingPong2.Tick

        If PS01 = "Ping" Then
            PS01 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS02 = "Ping" Then
            PS02 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS03 = "Ping" Then
            PS03 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS04 = "Ping" Then
            PS04 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS05 = "Ping" Then
            PS05 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS06 = "Ping" Then
            PS06 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS07 = "Ping" Then
            PS07 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS08 = "Ping" Then
            PS08 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS09 = "Ping" Then
            PS09 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If

        If PS10 = "Ping" Then
            PS10 = "Disconnected"
            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
        End If
        PingPong2.Enabled = False
    End Sub



    'Kick Buttons
    Private Sub Kick_Button2_Click(sender As Object, e As EventArgs) Handles Kick_Button2.Click
        If Not P02 = "" Then
            streamw.WriteLine("KIK:" + P02)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN02 + " wurde aus dem Spiel enfernt!")
            streamw.Flush()


            P02 = P03
            PS02 = PS03
            PN02 = PN03

            P03 = P04
            PS03 = PS04
            PN03 = PN04

            P04 = P05
            PS04 = P05
            PN04 = PN05

            P05 = P06
            PS05 = PS06
            PN05 = PS06

            P06 = P07
            PS06 = PS07
            PN06 = PN07

            P07 = P08
            PS07 = PS08
            PN07 = PN08

            P08 = P09
            PS08 = PS09
            PN08 = PN09

            P09 = P10
            PS09 = PS10
            PN09 = PN10

            streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
            streamw.Flush()
            streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If
    End Sub
    Private Sub Kick_Button3_Click(sender As Object, e As EventArgs) Handles Kick_Button3.Click
        If Not P03 = "" Then
            streamw.WriteLine("KIK:" + P03)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN03 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P03 = P04
        PS03 = PS04
        PN03 = PN04

        P04 = P05
        PS04 = P05
        PN04 = PN05

        P05 = P06
        PS05 = PS06
        PN05 = PS06

        P06 = P07
        PS06 = PS07
        PN06 = PN07

        P07 = P08
        PS07 = PS08
        PN07 = PN08

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If

    End Sub
    Private Sub Kick_Button4_Click(sender As Object, e As EventArgs) Handles Kick_Button4.Click
        If Not P04 = "" Then
            streamw.WriteLine("KIK:" + P04)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN04 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P04 = P05
        PS04 = P05
        PN04 = PN05

        P05 = P06
        PS05 = PS06
        PN05 = PS06

        P06 = P07
        PS06 = PS07
        PN06 = PN07

        P07 = P08
        PS07 = PS08
        PN07 = PN08

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If
    End Sub
    Private Sub Kick_Button5_Click(sender As Object, e As EventArgs) Handles Kick_Button5.Click
        If Not P05 = "" Then
            streamw.WriteLine("KIK:" + P05)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN05 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P05 = P06
        PS05 = PS06
        PN05 = PS06

        P06 = P07
        PS06 = PS07
        PN06 = PN07

        P07 = P08
        PS07 = PS08
        PN07 = PN08

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If
    End Sub
    Private Sub Kick_Button6_Click(sender As Object, e As EventArgs) Handles Kick_Button6.Click
        If Not P06 = "" Then
            streamw.WriteLine("KIK:" + P06)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN06 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P06 = P07
        PS06 = PS07
        PN06 = PN07

        P07 = P08
        PS07 = PS08
        PN07 = PN08

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If

    End Sub
    Private Sub Kick_Button7_Click(sender As Object, e As EventArgs) Handles Kick_Button7.Click
        If Not P07 = "" Then
            streamw.WriteLine("KIK:" + P07)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN07 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P07 = P08
        PS07 = PS08
        PN07 = PN08

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If

    End Sub
    Private Sub Kick_Button8_Click(sender As Object, e As EventArgs) Handles Kick_Button8.Click
        If Not P08 = "" Then
            streamw.WriteLine("KIK:" + P08)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN08 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P08 = P09
        PS08 = PS09
        PN08 = PN09

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If

    End Sub
    Private Sub Kick_Button9_Click(sender As Object, e As EventArgs) Handles Kick_Button9.Click
        If Not P09 = "" Then
            streamw.WriteLine("KIK:" + P09)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN09 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P09 = P10
        PS09 = PS10
        PN09 = PN10

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If
    End Sub
    Private Sub Kick_Button10_Click(sender As Object, e As EventArgs) Handles Kick_Button10.Click
        If Not P10 = "" Then
            streamw.WriteLine("KIK:" + P10)
            streamw.Flush()
            streamw.WriteLine("CHT:" + PN10 + " wurde aus dem Spiel enfernt!")
        streamw.Flush()

        P10 = ""
        PS10 = ""
        PN10 = ""

        streamw.WriteLine("SSA:" + PS01 + ":" + PS02 + ":" + PS03 + ":" + PS04 + ":" + PS05 + ":" + PS06 + ":" + PS07 + ":" + PS08 + ":" + PS09 + ":" + PS10)
        streamw.Flush()
        streamw.WriteLine("SNA:" + PN01 + ":" + PN02 + ":" + PN03 + ":" + PN04 + ":" + PN05 + ":" + PN06 + ":" + PN07 + ":" + PN08 + ":" + PN09 + ":" + PN10)
            streamw.Flush()
        End If
    End Sub
End Class