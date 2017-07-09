Public Class Form_propaganda

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Coral
        Else
            Label1.ForeColor = Color.Black

        End If


    End Sub
End Class