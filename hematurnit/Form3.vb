Public Class Form3
    Dim tic As Integer
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 10
        tic = tic + 1
        Me.Text = "جارى الاغلاق .." & 10 - tic
        If tic = 10 Then
            Timer1.Enabled = False
            Process.Start("shutdown", "-s -f -t 0")
        End If
    End Sub


    

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("shutdown", "-s -f -t 0")
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThemeButton1.Click
        End
    End Sub
End Class