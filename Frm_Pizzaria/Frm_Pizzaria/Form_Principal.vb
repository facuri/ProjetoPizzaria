Public Class Form_Principal
    Dim marquee As New Letreiro

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        marquee.Andar()
    End Sub

    Private Sub Form_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox_letreiro.Tag = TextBox1.Text
        marquee.SetControle(PictureBox_letreiro)
        marquee.SetBuffer(29)
        marquee.SetCor(Brushes.Red)

        Dim strdia, strmes, strano, strminuto, strhora As String
        strdia = Now.Day.ToString
        strmes = Now.Month.ToString
        strano = Now.Year.ToString
        strhora = Now.Hour.ToString
        strminuto = Now.Minute.ToString
        Label_hora.Text = "Hora: " + strhora + ":" + strminuto
        Label_Data.Text = "Data: " + strdia + "/" + strmes + "/" + strano
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PictureBox_letreiro.Tag = TextBox1.Text
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Deseja Realmente Sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmação!") = MsgBoxResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Form_Clientes.ShowDialog()

    End Sub

   Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Form_Funcionarios.ShowDialog()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PizzaToolStripMenuItem.Click
        Form_Pizza.ShowDialog()

    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Form_propaganda.ShowDialog()
    End Sub

    Private Sub PictureBox_letreiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_letreiro.Click

    End Sub

    Private Sub Label_hora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_hora.Click

    End Sub
End Class
