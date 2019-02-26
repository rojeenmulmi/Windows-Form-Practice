Public Class FormFun
    Public counter As Integer

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDropDown.CheckedChanged
        Lblpicked.Text = "You picked Drop Down style"
        cboSubjects.DropDownStyle = ComboBoxStyle.DropDown

    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDropList.CheckedChanged
        Lblpicked.Text = "You picked dropdownlist style"
        cboSubjects.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSimple.CheckedChanged
        Lblpicked.Text = "You picked simple style"
        cboSubjects.DropDownStyle = ComboBoxStyle.Simple
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cboSubjects.Items.Add("English")
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cboSubjects.Items.Remove("French")
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fruitArray() As String = {"Straberry", "Apple", "Orange", "Banana", "Peach"}
        Dim query = From afruit In fruitArray
        Where afruit.Contains("e")
        Select afruit

        cboSubjects.Items.Clear()
        For Each fruit In query
            cboSubjects.Items.Add(fruit)
        Next

        Button3.Enabled = False
    End Sub

    Private Sub btnplaymore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplaymore.Click, JumpToSecondFormToolStripMenuItem.Click
        moreplay.ShowDialog()

    End Sub

    Private Sub ToBluectrlBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToBluectrlBToolStripMenuItem.Click
        lblfun.ForeColor = Color.Blue
    End Sub

    Private Sub ToGreenctrlGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToGreenctrlGToolStripMenuItem.Click
        lblfun.ForeColor = Color.Green
    End Sub

    Private Sub ToRedctrlRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToRedctrlRToolStripMenuItem.Click
        lblfun.ForeColor = Color.Red
    End Sub

    Private Sub btnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnroll.Click
        Dim roller As New Random
        Dim num1, num2 As Integer
        num1 = roller.Next(6) + 1
        num2 = roller.Next(1, 7)
        lbresult.Text = "rolled: " & num1 & "," & num2
        If num1 = num2 Then
            MessageBox.Show("you rolled doubles")
        End If
    End Sub

 
    Private Sub FormFun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim mssg As String
        mssg = txtteletype.Text.Substring(1) & txtteletype.Text.Substring(0, 1)
        txtteletype.Text = mssg
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            btnStart.Text = "start it"
            btnStart.ForeColor = Color.Green
        Else
            Timer1.Enabled = True
            btnStart.Text = "stop it"
            btnStart.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnfaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfaster.Click
        If Timer1.Interval > 40 Then
            Timer1.Interval -= 20
            btnfaster.Text = "faster" & Timer1.Interval & "ms)"
        Else
            btnfaster.Enabled = False 'stop whren it reashes 40
        End If
        If Timer1.Interval < 400 Then
            btnslower.Enabled = True
        End If
    End Sub

    Private Sub btnslower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnslower.Click
        If Timer1.Interval < 400 Then
            Timer1.Interval += 20
            btnfaster.Text = "faster" & Timer1.Interval & "ms)"
        Else
            btnslower.Enabled = False 'stop whren it reashes 400
        End If
        If Timer1.Interval > 40 Then
            btnfaster.Enabled = True
        End If
    End Sub

End Class
