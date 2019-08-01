Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class Client

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)

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



    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                MsgBox("Verbindung zum server Abgebrochen")
                t.Interrupt()
                t.Abort()
                Close()
            End Try
        End While
    End Sub
    'netstream reader
    Private Sub AddItem(ByVal s As String)


        'Command Executer
        Try
            'MsgBox(s) 'Debugg

            Dim Connect() As String = s.Split(":")
            'connect
            If Connect(0) = Hauptmenue.C_SN Then
                'msg

            End If

            'Chat (alle)
            If Connect(0) = "CHT" Then
                Chat_Box.Text = Chat_Box.Text + Connect(1) + vbCrLf
            End If


            'Ping Pong
            If Connect(0) = "PIN" Then
                streamw.WriteLine("PON:" + Hauptmenue.C_SN)
                streamw.Flush()
            End If


            'Spielerstatus
            If Connect(0) = "SSA" Then
                PS01 = Connect(1)
                PS02 = Connect(2)
                PS03 = Connect(3)
                PS04 = Connect(4)
                PS05 = Connect(5)
                PS06 = Connect(6)
                PS07 = Connect(7)
                PS08 = Connect(8)
                PS09 = Connect(9)
                PS10 = Connect(10)
            End If

            'SpielerName
            If Connect(0) = "SNA" Then
                PN01 = Connect(1)
                PN02 = Connect(2)
                PN03 = Connect(3)
                PN04 = Connect(4)
                PN05 = Connect(5)
                PN06 = Connect(6)
                PN07 = Connect(7)
                PN08 = Connect(8)
                PN09 = Connect(9)
                PN10 = Connect(10)
            End If

            'Kick
            If Connect(0) = "KIK" Then
                If Connect(1) = Hauptmenue.C_SN Then
                    MsgBox("Du wurdest aus dem spiel entfernt")
                    client.Close()
                    t.Interrupt()
                    t.Abort()
                    Me.Close()
                End If
            End If

        Catch ex As Exception
        End Try
        'Weiter....
        'RichTextBox1.Text = RichTextBox1.Text + s + vbCrLf
    End Sub


    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'verbindungs aufbau
        Try
            client.Connect(Join.IP, Join.Port) ' hier die ip des servers eintragen. 

            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)

                'First Connect
                streamw.WriteLine("CON:" + Hauptmenue.C_SN + ":" + Hauptmenue.C_Name)
                streamw.Flush()


                t.Start()

            End If
        Catch ex As Exception
            MsgBox("Verbindung zu Server Konnte Nicht hergestellt werden")
            Try
                t.Interrupt()
                t.Abort()
            Catch exx As Exception

            End Try
            Close()

        End Try
    End Sub

    Private Sub Client_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            client.Close()

            t.Interrupt()
            t.Abort()
        Catch exx As Exception
            MsgBox("Thread not closed")
        End Try
    End Sub

    Private Sub Menue_Button_Click(sender As Object, e As EventArgs) Handles Menue_Button.Click
        If Menue_Panel.Visible = False Then
            Menue_Panel.Visible = True
        Else
            Menue_Panel.Visible = False
        End If
    End Sub

    Private Sub Chat_Button_Click(sender As Object, e As EventArgs) Handles Chat_Button.Click
        If Chat_Panel.Visible = False Then
            Chat_Panel.Visible = True
        Else
            Chat_Panel.Visible = False
        End If
    End Sub

    Private Sub Beenden_Button_Click(sender As Object, e As EventArgs) Handles Beenden_Button.Click
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

    Private Sub Chat_Sende_Button_Click(sender As Object, e As EventArgs) Handles Chat_Sende_Button.Click
        streamw.Write("CHT:" + Hauptmenue.C_Name + " ; " + Chat_Sendebox.Text + vbCrLf)
        streamw.Flush()
    End Sub

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

    Private Sub Name_Box1_TextChanged(sender As Object, e As EventArgs) Handles Name_Box1.TextChanged

    End Sub
End Class