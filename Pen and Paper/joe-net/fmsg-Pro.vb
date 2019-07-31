Public Class fmsg_Pro

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    'Seriennummer Gererieren mit "set" button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ran_id As Integer = GetRandom(100000000, 1000000000)
        L_SN.Text = ran_id
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ERRORR As Boolean = False

        If L_SN.Text = "" Then
            MsgBox("Bitte auf den 'set' Knopf Betätigen ")
            ERRORR = True
        End If
        If TB_Name.Text = "" Then
            MsgBox("Bitte Dein name in das Namensfeld eintragen")
            ERRORR = True

        End If
        If ERRORR = False Then
            Dim list As String
            list = L_SN.Text + ";" + TB_Name.Text
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath + "\pro.joe", list, True)
            MsgBox("Um die änderungen zu Speichern wird musst du das Programm Neu starten")

            Me.Close()
        End If

    End Sub







End Class