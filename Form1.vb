Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Song, AudioPlayMode.BackgroundLoop)

    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        My.Computer.Audio.Play(My.Resources.Song, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Label1.Text = DateTime.Now
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyBase.WindowState = FormWindowState.Minimized
        My.Computer.Audio.Stop()
        Dim Write As New System.IO.StreamWriter(CurDir() & "\Data\enUS\realmlist.wtf")
        Write.Write("set realmlist bloodcraft.no-ip.org")
        Write.Close()
        Dim AppPath = (CurDir() & "\WoW.exe")
        Shell(AppPath, vbMinimizedFocus)
        MyBase.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("http://bloodcraft.no-ip.org/")
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://svannon.thruhere.net:8080/forums/index.php")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("http://demise-bc.enjin.com/home")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://demise-bc.enjin.com/forum")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.WindowState = FormWindowState.Minimized
        My.Computer.Audio.Stop()
        Dim Write As New System.IO.StreamWriter(CurDir() & "\Data\enUS\realmlist.wtf")
        Write.Write("set realmlist logon.omegawow.eu")
        Write.Close()
        Dim AppPath = (CurDir() & "\WoW.exe")
        Shell(AppPath, vbMinimizedFocus)
        MyBase.WindowState = FormWindowState.Minimized
    End Sub
End Class
