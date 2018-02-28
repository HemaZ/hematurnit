Public Class Form1
    Dim hours As Integer
    Dim min As Integer
    Dim sec As Integer
    Dim total As Integer
    Dim total2 As Integer
    Dim now As Integer
    Dim mod1 As Integer
    Dim mod2 As Integer

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            hours = Integer.Parse(TextBox1.Text)
        Catch
            MsgBox("من فضلك ادخل اعداد حقيقية فقط", MsgBoxStyle.Critical, "خطأ")
            TextBox1.Text = 0
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            min = Integer.Parse(TextBox2.Text)
        Catch
            MsgBox("من فضلك ادخل اعداد حقيقية فقط", MsgBoxStyle.Critical, "خطأ")
            TextBox2.Text = 0
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            sec = Integer.Parse(TextBox3.Text)
        Catch
            MsgBox("من فضلك ادخل اعداد حقيقية فقط", MsgBoxStyle.Critical, "خطأ")
            TextBox3.Text = 0
        End Try
    End Sub

   



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 1
        ProgressBar1.Value = ProgressBar1.Value + 1
        now = now + 1
        total2 = total - now
        If total = now Then
            Timer1.Enabled = False
            Form3.Show()
        End If


        Label8.Text = total2 \ 3600
        mod1 = total2 Mod 3600
        Label9.Text = mod1 \ 60
        mod2 = mod1 Mod 60

        
        Label10.Text = mod2
       
    End Sub

    

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub البرنامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles البرنامجToolStripMenuItem.Click
        End
    End Sub

    Private Sub اخفاءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخفاءToolStripMenuItem.Click

        Me.Hide()


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        

    End Sub

    Private Sub مساعدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مساعدةToolStripMenuItem.Click
        MsgBox("لطلب المساعدة او اى استفسار يمكنك مراسلتى على " & vbCrLf & "Egy.Kid1@gmail.com" & vbCrLf & "egy_kid1@yahoo.com")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub اغلاقToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub اخفاءToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub مساعدةToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("لطلب المساعدة او اى استفسار يمكنك مراسلتى على " & vbCrLf & "Egy.Kid1@gmail.com" & vbCrLf & "egy_kid1@yahoo.com", MsgBoxStyle.Information, "مساعدة")
    End Sub

    Private Sub المبرمجToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False

        If hours > 0 Then total = total + hours * 3600
        If min > 0 Then total = total + min * 60
        If sec > 0 Then total = total + sec
        ProgressBar1.Maximum = total
        ToolStripProgressBar1.Maximum = total
        Timer1.Enabled = True
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click

        If MsgBox("هل تريد فعلا اغلاق الجهاز ", MsgBoxStyle.OkCancel, "تأكيد") = MsgBoxResult.Ok Then
            Me.Hide()
            Form3.Show()

        End If
    End Sub

    Private Sub اغلاقToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اغلاقToolStripMenuItem2.Click
        End
    End Sub

    Private Sub اخفاءToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخفاءToolStripMenuItem3.Click
        Me.Hide()
    End Sub

    Private Sub مساعدةToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مساعدةToolStripMenuItem3.Click
        MsgBox("لطلب المساعدة او اى استفسار يمكنك مراسلتى على " & vbCrLf & "Egy.Kid1@gmail.com" & vbCrLf & "egy_kid1@yahoo.com", MsgBoxStyle.Information, "مساعدة")
    End Sub

    Private Sub المبرمجToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles المبرمجToolStripMenuItem3.Click
        Form2.Show()
    End Sub

    Private Sub ThemeTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            sec = Integer.Parse(TextBox1.Text)
        Catch
            MsgBox("من فضلك ادخل اعداد حقيقية فقط", MsgBoxStyle.Critical, "خطأ")
            TextBox1.Text = 0
        End Try
    End Sub
End Class
