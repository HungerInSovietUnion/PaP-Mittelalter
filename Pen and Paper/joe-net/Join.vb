Public Class Join
    Public IP As String
    Public Port As String


    Private Sub B_Connect_Click(sender As Object, e As EventArgs) Handles B_Connect.Click
        IP = Tb_IP.Text
        Port = TB_Port.Text
        Client.Show()
    End Sub

    Private Sub Join_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class