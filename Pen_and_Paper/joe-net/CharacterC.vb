Public Class CharacterC
    Private Sub M_Menue_Button_Click(sender As Object, e As EventArgs) Handles M_Menue_Button.Click
        If M_Menue_Panel.Visible = False Then
            M_Menue_Panel.Visible = True
        Else
            M_Menue_Panel.Visible = False
        End If
    End Sub

    Private Sub M_Menue_Button2_Click(sender As Object, e As EventArgs) Handles M_Menue_Button2.Click
        If M_Menue_Panel.Visible = False Then
            M_Menue_Panel.Visible = True
        Else
            M_Menue_Panel.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim err As Boolean
        Dim SehrHoch As Integer = 0
        Dim Hoch As Integer = 0
        Dim Mittel As Integer = 0
        Dim Niedrig As Integer = 0
        Dim SehrNiedrig As Integer = 0

        If TB_Intuition.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Intuition.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Intuition.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Intuition.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Intuition.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Scharfsinn.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Scharfsinn.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Scharfsinn.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Scharfsinn.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Scharfsinn.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Wahrnehmung.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Wahrnehmung.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Wahrnehmung.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Wahrnehmung.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Wahrnehmung.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Intelligenz.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Intelligenz.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Intelligenz.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Intelligenz.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Intelligenz.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Charisma.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Charisma.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Charisma.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Charisma.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Charisma.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Konstitution.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Konstitution.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Konstitution.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Konstitution.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Konstitution.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Körperkraft.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Körperkraft.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Körperkraft.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Körperkraft.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Körperkraft.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If TB_Manipulation.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Manipulation.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Manipulation.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Manipulation.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Manipulation.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If


        If SehrHoch = 1 Then
            If Hoch = 2 Then
                If Mittel = 2 Then
                    If Niedrig = 2 Then
                        If SehrNiedrig = 1 Then
                            err = False
                        Else
                            err = True
                        End If
                    Else
                        err = True
                    End If
                Else
                    err = True
                End If
            Else
                err = True
            End If
        Else
            err = True
        End If


        MsgBox(TB_Intuition.Value.ToString + vbCrLf + TB_Scharfsinn.Value.ToString + vbCrLf + TB_Wahrnehmung.Value.ToString + vbCrLf + TB_Intelligenz.Value.ToString + vbCrLf + TB_Charisma.Value.ToString + vbCrLf + TB_Konstitution.Value.ToString + vbCrLf + TB_Körperkraft.Value.ToString + vbCrLf + TB_Manipulation.Value.ToString)
        MsgBox(SehrHoch.ToString + vbCrLf + Hoch.ToString + vbCrLf + Mittel.ToString + vbCrLf + Niedrig.ToString + vbCrLf + SehrNiedrig.ToString)


        If err = True Then

            MsgBox("Bitte beachte die vorgegebenen Skillpunkte der Character Skills")
        End If


    End Sub



    Private Sub Character_Skills_Button_Click(sender As Object, e As EventArgs) Handles Character_Skills_Button.Click
        Character_Skills_Panel.Dock = DockStyle.Fill
        Life_Skills_Panel.Dock = DockStyle.None
        RI_Panel.Dock = DockStyle.None
        Beruf_Panel.Dock = DockStyle.None

    End Sub

    Private Sub Life_Skills_Button_Click(sender As Object, e As EventArgs) Handles Life_Skills_Button.Click
        Life_Skills_Panel.Dock = DockStyle.Fill
        Character_Skills_Panel.Dock = DockStyle.None
        RI_Panel.Dock = DockStyle.None
        Beruf_Panel.Dock = DockStyle.None
    End Sub


    Private Sub RI_Button_Click(sender As Object, e As EventArgs) Handles RI_Button.Click
        RI_Panel.Dock = DockStyle.Fill
        Life_Skills_Panel.Dock = DockStyle.None
        Character_Skills_Panel.Dock = DockStyle.None
        Beruf_Panel.Dock = DockStyle.None


    End Sub
    Private Sub Beruf_Button_Click(sender As Object, e As EventArgs) Handles Beruf_Button.Click
        Beruf_Panel.Dock = DockStyle.Fill
        RI_Panel.Dock = DockStyle.None
        Life_Skills_Panel.Dock = DockStyle.None
        Character_Skills_Panel.Dock = DockStyle.None

    End Sub

    Private Sub Rasse_CBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Rasse_CBox.SelectedIndexChanged
        If Rasse_CBox.SelectedIndex = 0 Then
            RI_Zwerg_Panel.Dock = DockStyle.Fill
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Goblin_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 1 Then
            RI_Mensch_Panel.Dock = DockStyle.Fill
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Goblin_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 2 Then
            RI_Riese_Panel.Dock = DockStyle.Fill
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Goblin_Panel.Dock = DockStyle.None
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 3 Then
            RI_Goblin_Panel.Dock = DockStyle.Fill
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 4 Then
            RI_Nachtelf_Panel.Dock = DockStyle.Fill
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 5 Then
            RI_Waldelf_Panel.Dock = DockStyle.Fill
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
            RI_Echsenmensch_Panel.Dock = DockStyle.None
        End If

        If Rasse_CBox.SelectedIndex = 6 Then
            RI_Echsenmensch_Panel.Dock = DockStyle.Fill
            RI_Waldelf_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Mensch_Panel.Dock = DockStyle.None
            RI_Zwerg_Panel.Dock = DockStyle.None
            RI_Riese_Panel.Dock = DockStyle.None
            RI_Nachtelf_Panel.Dock = DockStyle.None
        End If


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Beruf_CBox.SelectedIndexChanged
        If Beruf_CBox.SelectedIndex = 0 Then
            B_Arbeitslos_Panel.Dock = DockStyle.Fill
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 1 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.Fill
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If


        If Beruf_CBox.SelectedIndex = 2 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.Fill
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 3 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.Fill
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 4 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.Fill
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 5 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.Fill
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 6 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.Fill
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 7 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.Fill
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 8 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.Fill
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 9 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.Fill
            B_Koch_Panel.Dock = DockStyle.None
        End If

        If Beruf_CBox.SelectedIndex = 10 Then
            B_Arbeitslos_Panel.Dock = DockStyle.None
            B_Fischer_Panel.Dock = DockStyle.None
            B_Bauer_Panel.Dock = DockStyle.None
            B_Händler_Panel.Dock = DockStyle.None
            B_Wirt_Panel.Dock = DockStyle.None
            B_Priester_Panel.Dock = DockStyle.None
            B_Magier_Panel.Dock = DockStyle.None
            B_Soldat_Panel.Dock = DockStyle.None
            B_Handwerk_Panel.Dock = DockStyle.None
            B_Sammler_Panel.Dock = DockStyle.None
            B_Koch_Panel.Dock = DockStyle.Fill
        End If


    End Sub



    Private Sub M_Speichern_Button_Click(sender As Object, e As EventArgs) Handles M_Speichern_Button.Click
        'Der heftige shit !!!


        Dim Fehlermeldung As String = "Das speichern ist aufgrund folgenden fehlers Fehlgeschlagen:" + vbCrLf + vbCrLf
        Dim errrr As Integer = 0


        'Namens box überprüfung
        If Name_Box.TextLength <= 1 Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("Das Feld ""Name"" muss mehr als aus einem Zeigen Bestehen!") + vbCrLf
        End If

        'Vornamens box überprüfung
        If Vorname_Box.TextLength <= 1 Then
            errrr = 1

            Fehlermeldung = Fehlermeldung + ("Das Feld ""Vorname"" muss mehr als aus einem Zeigen Bestehen!") + vbCrLf
        End If

        'Alters box überprüfung
        Try
            Alter_Box.Text = Alter_Box.Text + 1
            Alter_Box.Text = Alter_Box.Text - 1
        Catch ex As Exception
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Alter"" muss eine Zahl stehen!") + vbCrLf
        End Try

        If Alter_Box.Text = "" Then
            errrr = 1
        End If

        'Gewicht box überprüfung
        Try
            Gewicht_Box.Text = Gewicht_Box.Text + 1
            Gewicht_Box.Text = Gewicht_Box.Text - 1
        Catch ex As Exception
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Alter"" muss eine Zahl stehen!") + vbCrLf
        End Try
        If Gewicht_Box.Text = "" Then
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Alter"" muss eine Zahl stehen!") + vbCrLf
            errrr = 1
        End If

        'Rasen box überprüfung
        If Rasse_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Rasse"" muss eine Rasse ausgewählt werden!") + vbCrLf
        End If

        'Religion box überprüfung
        If Religion_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Religion"" muss eine Religion ausgewählt werden!") + vbCrLf
        End If

        'Statur box überprüfung
        If Statur_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Statur"" muss eine Statur ausgewählt werden!") + vbCrLf
        End If

        'Beruf box überprüfung
        If Beruf_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Beruf"" muss ein Beruf ausgewählt werden!") + vbCrLf
        End If

        'Charakterzüge boxen überprüfung
        Dim errror As Integer = 0

        If Charakterzüge1.SelectedItem = Charakterzüge2.SelectedItem Then
            errror = 1
        End If

        If Charakterzüge2.SelectedItem = Charakterzüge3.SelectedItem Then
            errror = 1
        End If

        If Charakterzüge3.SelectedItem = Charakterzüge1.SelectedItem Then
            errror = 1
        End If

        If Charakterzüge1.SelectedItem = "" Then
            errror = 2
        End If

        If Charakterzüge2.SelectedItem = "" Then
            errror = 2
        End If

        If Charakterzüge2.SelectedItem = "" Then
            errror = 2
        End If

        If errror = 2 Then
            Fehlermeldung = Fehlermeldung + ("Einer der ""Charakterzüge"" Boxen ist leer ") + vbCrLf
        End If

        If errror = 1 Then
            Fehlermeldung = Fehlermeldung + ("Einer der ""Charakterzüge"" Boxen ist mit einer anderen edentisch ") + vbCrLf
        End If

        'SozialerStatus box überprüfung
        If SozialerStatus_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Sozialer Status"" muss ein SozialerStatus ausgewählt werden!") + vbCrLf
        End If


        'FamilienStatus box überprüfung
        If FamilienStatus_CBox.Text = "" Then
            errrr = 1
            Fehlermeldung = Fehlermeldung + ("In dem Feld ""Familienstatus"" muss ein SozialerStatus ausgewählt werden!") + vbCrLf
        End If


        'Life skills
        Dim SehrHoch As Integer = 0
        Dim Hoch As Integer = 0
        Dim Mittel As Integer = 0
        Dim Niedrig As Integer = 0
        Dim SehrNiedrig As Integer = 0

        If TB_Handwerk.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Handwerk.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Handwerk.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Handwerk.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Handwerk.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Heilkunde.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Heilkunde.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Heilkunde.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Heilkunde.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Heilkunde.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Geschick.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Geschick.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Geschick.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Geschick.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Geschick.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Magie_Zauber.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Magie_Zauber.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Magie_Zauber.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Magie_Zauber.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Magie_Zauber.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Menschenkenntnisse.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Menschenkenntnisse.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Menschenkenntnisse.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Menschenkenntnisse.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Menschenkenntnisse.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Tierkenntnisse.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Tierkenntnisse.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Tierkenntnisse.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Tierkenntnisse.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Tierkenntnisse.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        If TB_Diplomatie.Value = 1 Then
            SehrNiedrig = SehrNiedrig + 1
        End If
        If TB_Diplomatie.Value = 2 Then
            Niedrig = Niedrig + 1
        End If
        If TB_Diplomatie.Value = 3 Then
            Mittel = Mittel + 1
        End If
        If TB_Diplomatie.Value = 4 Then
            Hoch = Hoch + 1
        End If
        If TB_Diplomatie.Value = 5 Then
            SehrHoch = SehrHoch + 1
        End If

        Dim err_f As Integer = 0

        If SehrHoch = 1 Then
            If Hoch = 1 Then
                If Mittel = 2 Then
                    If Niedrig = 2 Then
                        If SehrNiedrig = 1 Then


                        Else
                            errrr = 1
                            err_f = 1
                        End If
                    Else
                        errrr = 1
                        err_f = 1
                    End If
                Else
                    errrr = 1
                    err_f = 1
                End If
            Else
                errrr = 1
                err_f = 1
            End If
        Else
            errrr = 1
            err_f = 1
        End If

        MsgBox(SehrHoch.ToString + vbCrLf + Hoch.ToString + vbCrLf + Mittel.ToString + vbCrLf + Niedrig.ToString + vbCrLf + SehrNiedrig.ToString)


        If err_f = 1 Then
            Fehlermeldung = Fehlermeldung + ("Bitte beachte die vorgegebenen Skillpunkte der Life Skills") + vbCrLf
        End If

        'xxxxxxxxxxxxx


        Dim SehrHoch2 As Integer = 0
        Dim Hoch2 As Integer = 0
        Dim Mittel2 As Integer = 0
        Dim Niedrig2 As Integer = 0
        Dim SehrNiedrig2 As Integer = 0

        If TB_Intuition.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Intuition.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Intuition.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Intuition.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Intuition.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Scharfsinn.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Scharfsinn.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Scharfsinn.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Scharfsinn.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Scharfsinn.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Wahrnehmung.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Wahrnehmung.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Wahrnehmung.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Wahrnehmung.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Wahrnehmung.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Intelligenz.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Intelligenz.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Intelligenz.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Intelligenz.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Intelligenz.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If

        If TB_Charisma.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Charisma.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Charisma.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Charisma.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Charisma.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Konstitution.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Konstitution.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Konstitution.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Konstitution.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Konstitution.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Körperkraft.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Körperkraft.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Körperkraft.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Körperkraft.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Körperkraft.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If


        If TB_Manipulation.Value = 1 Then
            SehrNiedrig2 = SehrNiedrig2 + 1
        End If
        If TB_Manipulation.Value = 2 Then
            Niedrig2 = Niedrig2 + 1
        End If
        If TB_Manipulation.Value = 3 Then
            Mittel2 = Mittel2 + 1
        End If
        If TB_Manipulation.Value = 4 Then
            Hoch2 = Hoch2 + 1
        End If
        If TB_Manipulation.Value = 5 Then
            SehrHoch2 = SehrHoch2 + 1
        End If

        Dim err_d As Integer = 0
        If SehrHoch2 = 1 Then
            If Hoch2 = 2 Then
                If Mittel2 = 2 Then
                    If Niedrig2 = 2 Then
                        If SehrNiedrig2 = 1 Then


                        Else
                            errrr = 1
                            err_d = 1
                        End If
                    Else
                        errrr = 1
                        err_d = 1
                    End If
                Else
                    errrr = 1
                    err_d = 1
                End If
            Else
                errrr = 1
                err_d = 1
            End If
        Else
            errrr = 1
            err_d = 1
        End If

        MsgBox(TB_Intuition.Value.ToString + vbCrLf + TB_Scharfsinn.Value.ToString + vbCrLf + TB_Wahrnehmung.Value.ToString + vbCrLf + TB_Intelligenz.Value.ToString + vbCrLf + TB_Charisma.Value.ToString + vbCrLf + TB_Konstitution.Value.ToString + vbCrLf + TB_Körperkraft.Value.ToString + vbCrLf + TB_Manipulation.Value.ToString)
        MsgBox(SehrHoch2.ToString + vbCrLf + Hoch2.ToString + vbCrLf + Mittel2.ToString + vbCrLf + Niedrig2.ToString + vbCrLf + SehrNiedrig2.ToString)



        If err_d = 1 Then
            Fehlermeldung = Fehlermeldung + ("Bitte beachte die vorgegebenen Skillpunkte der Character Skills") + vbCrLf
        End If














        If errrr = 1 Then
            MsgBox(Fehlermeldung)
        End If

        If errrr = 0 Then
            Dim point As String = ""
            point = point + Name_Box.Text.ToString + ":" + Vorname_Box.Text.ToString + ":" + Alter_Box.Text.ToString + ":" + Gewicht_Box.Text.ToString + ":" + Rasse_CBox.Text.ToString + ":" + Religion_CBox.Text.ToString + ":" + Statur_CBox.Text.ToString + ":" + Beruf_CBox.Text.ToString + ":" + Charakterzüge1.Text.ToString + ":" + Charakterzüge2.Text.ToString + ":" + Charakterzüge3.Text.ToString + ":" + SozialerStatus_CBox.Text.ToString + ":" + FamilienStatus_CBox.Text.ToString + ":" + TB_Handwerk.Value.ToString + ":" + TB_Heilkunde.Value.ToString + ":" + TB_Geschick.Value.ToString + ":" + TB_Magie_Zauber.Value.ToString + ":" + TB_Menschenkenntnisse.Value.ToString + ":" + TB_Tierkenntnisse.Value.ToString + ":" + TB_Diplomatie.Value.ToString + ":" + TB_Intuition.Value.ToString + ":" + TB_Scharfsinn.Value.ToString + ":" + TB_Wahrnehmung.Value.ToString + ":" + TB_Intelligenz.Value.ToString + ":" + TB_Charisma.Value.ToString + ":" + TB_Konstitution.Value.ToString + ":" + TB_Körperkraft.Value.ToString + ":" + TB_Manipulation.Value.ToString
            MsgBox(point)
        End If





    End Sub
End Class