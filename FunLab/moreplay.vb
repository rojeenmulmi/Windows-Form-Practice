Public Class moreplay

    Private Sub btncopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncopy.Click
        Clipboard.SetText(txtcopy.text)
    End Sub

    Private Sub btnpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaste.Click
        txtpaste.Text = Clipboard.GetText
    End Sub

    Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
        FormFun.counter += 1
        FormFun.Lbcount.Text = "counet is" & FormFun.counter
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class