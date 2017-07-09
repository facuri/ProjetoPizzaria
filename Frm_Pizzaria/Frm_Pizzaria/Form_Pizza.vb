Imports System.Data.OleDb
Public Class Form_Pizza
    Dim a1 As String
    Dim a2 As String
    Dim a3 As String
    Dim preco As Double = 0
    Dim precototal As Double = 0
    Dim codcli As Integer
    Dim recebeu As Double = 0
    Dim troco As Double
    Dim moeda As Double


    Private Sub Form_Pizza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega os dados para a tabela 'PizzariaDataSet.Tabela_Pizza'. Você pode movê-la, ou removê-la, conforme necessário.
        Me.Tabela_PizzaTableAdapter.Fill(Me.PizzariaDataSet.Tabela_Pizza)
        Carrega_nomes()


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.TabelaPizzaBindingSource.MoveFirst()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim position As Integer
        position = Me.TabelaPizzaBindingSource.Position
        Me.TabelaPizzaBindingSource.MovePrevious()
        If position < 1 Then
            Beep()
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Me.TabelaPizzaBindingSource.MoveNext()
        If TabelaPizzaBindingSource.Position = TabelaPizzaBindingSource.Count - 1 Then
            Beep()
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.TabelaPizzaBindingSource.MoveLast()
    End Sub

    Private Sub TextBox10_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
   
    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox11.Text = Me.TabelaPizzaBindingSource.Position + 1 & " / " & Me.TabelaPizzaBindingSource.Count
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Refrigerante(2L)" Then
            TextBox_preco.Text = Val("9").ToString("c")
        ElseIf ComboBox1.Text = "Refrigerante(1L)" Then
            TextBox_preco.Text = Val("4.5").ToString("c")
        ElseIf ComboBox1.Text = "Refrigerante(290ml)" Then
            TextBox_preco.Text = Val("2").ToString("c")
        ElseIf ComboBox1.Text = "Refrigerante(Lata)" Then
            TextBox_preco.Text = Val("4.5").ToString("c")
        ElseIf ComboBox1.Text = "Itaipava(250ml)" Then
            TextBox_preco.Text = Val("2").ToString("c")
        ElseIf ComboBox1.Text = "Kaiser(Lata)" Then
            TextBox_preco.Text = Val("2.8").ToString("c")
        ElseIf ComboBox1.Text = "Skol(Lata)" Then
            TextBox_preco.Text = Val("3").ToString("c")
        ElseIf ComboBox1.Text = "Kaiser(600ml)" Then
            TextBox_preco.Text = Val("4").ToString("c")
        ElseIf ComboBox1.Text = "Brahma(600ml)" Then
            TextBox_preco.Text = Val("5").ToString("c")
        Else : ComboBox1.Text = "Sucos"
            TextBox_preco.Text = Val("4.5").ToString("c")

        End If

        Select Case ComboBox1.Text
            Case "Refrigerante(2L)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida1.jpg")
                PictureBox2.Visible = True
            Case "Refrigerante(1L)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida2.jpg")
                PictureBox2.Visible = True
            Case "Refrigerante(290ml)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida3.jpg")
                PictureBox2.Visible = True
            Case "Refrigerante(Lata)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida4.jpg")
                PictureBox2.Visible = True
            Case "Itaipava(250ml)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida5.jpg")
                PictureBox2.Visible = True
            Case "Kaiser(Lata)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida6.jpg")
                PictureBox2.Visible = True
            Case "Skol(Lata)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida7.jpg")
                PictureBox2.Visible = True
            Case "Kaiser(600ml)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida8.jpg")
                PictureBox2.Visible = True
            Case "Brahma(600ml)"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida9.jpg")
                PictureBox2.Visible = True
            Case "Sucos"
                PictureBox2.Load("D:\Usuários\Dalmo\Pictures\bebidas\bebida10.jpg")
                PictureBox2.Visible = True
        End Select

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        a1 = Val(TextBox_pedido.Text)
        a2 = (TextBox_pedido.Text * 0.9)

        TextBoxpagar.Text = FormatCurrency(a2, 2)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBoxpagar.Text = TextBox_pedido.Text
    End Sub

    Private Sub Button_abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_abrir.Click
        ListBox1.Items.Add(".................................................")
        ListBox1.Items.Add("  Pizzaria Villa Itália ")
        ListBox1.Items.Add("Fone: (19) 3661-9601")
        ListBox1.Items.Add("Espírito Santo do Pinhal - São Paulo")
        ListBox1.Items.Add(".................................................")
        ListBox1.Items.Add("Nome do cliente" & " - " & ComboBox_cliente.Text)
        ListBox1.Items.Add("Telefone" & " - " & TextBox_telefone.Text)
        ListBox1.Items.Add(".................................................")
        ListBox1.Items.Add("Cupom Fiscal")
        ListBox1.Items.Add("Lista de Pedidos")
        ListBox1.Items.Add("Pedido   Preço")
        ListBox1.Items.Add(".................................................")


    End Sub

    Private Sub Button_adicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_adicionar.Click
        preco = CDec(TextBox_preco.Text)
        ListBox1.Items.Add(ComboBox1.Text & " - " & TextBox_preco.Text)
        precototal = preco + precototal
        TextBox_pedido.Text = Val(precototal).ToString("c")


    End Sub

    Private Sub CheckBox_pequenaChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_pequena.CheckedChanged
        If CheckBox_pequena.Checked = True Then
            preco = CDec(TextBox15.Text)
            ListBox1.Items.Add(ComboBox2.Text & " - " & TextBox15.Text)
            precototal = preco + precototal
            TextBox_pedido.Text = Val(precototal).ToString("c")
        End If



    End Sub

    Private Sub CheckBox_mediaCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_media.CheckedChanged

        If CheckBox_media.Checked = True Then
            preco = CDec(TextBox14.Text)
            ListBox1.Items.Add(ComboBox2.Text & " - " & TextBox14.Text)
            precototal = preco + precototal
            TextBox_pedido.Text = Val(precototal).ToString("c")
        End If

    End Sub

    Private Sub CheckBox_grandeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_grande.CheckedChanged

        If CheckBox_grande.Checked = True Then
            preco = CDec(TextBox13.Text)
            ListBox1.Items.Add(ComboBox2.Text & " - " & TextBox13.Text)
            precototal = preco + precototal
            TextBox_pedido.Text = Val(precototal).ToString("c")
        End If

    End Sub
    Private Sub Button_infvalor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_infvalor.Click
        recebeu = InputBox("Qual o Valor Pago?", "Cupom Fiscal")

        TextBox1.Text = FormatCurrency(recebeu, 2)
        If recebeu < TextBoxpagar.Text Then
            MsgBox("Valor Pago (R$" & recebeu & ",00). É Menor que o Valor Total (" & TextBoxpagar.Text & ")")
        Else
            TextBox1.Text = FormatCurrency(recebeu, 2)
            troco = recebeu - TextBoxpagar.Text
            TextBox2.Text = FormatCurrency(troco, 2)
            MsgBox("Valor Pago,  (" & TextBox1.Text & "). Troco (" & TextBox2.Text & ")")
            MessageBox.Show("Obrigado e Volte Sempre!", "Pizzaria Villa Itália", MessageBoxButtons.OK)
        End If
        ListBox1.Items.Add(".................................................")
        ListBox1.Items.Add("Total " & ":" & TextBoxpagar.Text)
        ListBox1.Items.Add("Valor Pago" & ":" & TextBox1.Text)
        ListBox1.Items.Add("Troco" & ":" & TextBox2.Text)
        ListBox1.Items.Add(".................................................")
        ListBox1.Items.Add("Funcionário(a)" & " : " & ComboBox_funcionario.Text)
    End Sub

    Private Sub Button_reiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_reiniciar.Click
        ComboBox1.Text = ""
        ComboBox_cliente.Text = ""
        ComboBox_funcionario.Text = ""
        TextBox_telefone.Text = ""
        TextBox_rg.Text = ""
        TextBox_preco.Text = ""
        ListBox1.Items.Clear()
        TextBox_pedido.Text = "R$0,00"

        TextBoxpagar.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        precototal = 0
        preco = 0

        MsgBox("O Cupom Foi Reiniciado! Clique para Abrir Cupom para Iniciar um Novo")
    End Sub

    Private Sub Button_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_imprimir.Click

        Try

            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDocument1.DocumentName = "Frm_Pizza"
                PrintPreviewDialog1.ShowDialog()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim y As Integer = 15
        For i = 0 To ListBox1.Items.Count - 1
            e.Graphics.DrawString(ListBox1.Items(i).ToString, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 10, y)
            y += 15

        Next

    End Sub
    Private Sub Carrega_nomes()
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"

        con.Open()
        Dim comando As New OleDbCommand

        comando.CommandText = "select nome_cli from tabela_clientes order by nome_cli "

        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader()
        ComboBox_cliente.Items.Clear()

        Do While leitor.Read
            ComboBox_cliente.Items.Add(leitor("nome_cli"))
        Loop
        con.Close()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        comando.CommandText = "select nome from tabela_funcionario order by nome"

        comando.CommandType = CommandType.Text

        comando.Connection = con

        leitor = comando.ExecuteReader()
        ComboBox_funcionario.Items.Clear()

        Do While leitor.Read
            ComboBox_funcionario.Items.Add(leitor("nome"))
        Loop

        con.Close()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"

        con.Open()

        comando.CommandText = "select nome_pizza,ingredientes_pizza,preco_pequena,preco_media,preco_grande from tabela_pizza order by nome_pizza "

        comando.CommandType = CommandType.Text

        comando.Connection = con
        leitor = comando.ExecuteReader()
        ComboBox2.Items.Clear()

        Do While leitor.Read
            ComboBox2.Items.Add(leitor("nome_pizza"))
        Loop
        con.Close()


    End Sub

    Private Sub ComboBox_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_cliente.SelectedIndexChanged
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        Dim comando As New OleDbCommand
        comando.CommandText = "select telefone_com,rg_cli from tabela_clientes where nome_cli = '" & ComboBox_cliente.Text & "'"
        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader()

        leitor.Read()

        TextBox_telefone.Text = leitor("telefone_com")
        TextBox_rg.Text = leitor("rg_cli")

        con.Close()

    End Sub

    Private Sub ComboBox_funcionario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_funcionario.SelectedIndexChanged
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        Dim comando As New OleDbCommand
        comando.CommandText = "select nome from tabela_funcionario where nome = '" & ComboBox_funcionario.Text & "'"

        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader()

        leitor.Read()
        con.Close()
    End Sub
    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Form_Funcionarios.ShowDialog()
    End Sub

   
    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        Dim comando As New OleDbCommand
        comando.CommandText = "select nome_pizza,ingredientes_pizza,preco_pequena,preco_media,preco_grande from tabela_pizza where nome_pizza = '" & ComboBox2.Text & "'"
        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader()

        leitor.Read()
        TextBox12.Text = leitor("ingredientes_pizza")
        TextBox15.Text = leitor("preco_pequena")
        TextBox14.Text = leitor("preco_media")
        TextBox13.Text = leitor("preco_grande")

        Select Case ComboBox2.Text
            Case "Aliche"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza1.jpg")
                PictureBox1.Visible = True
            Case "Americana"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza2.jpg")
                PictureBox1.Visible = True
            Case "Atum"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza3.jpg")
                PictureBox1.Visible = True
            Case "Bacon"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza4.jpg")
                PictureBox1.Visible = True
            Case "Baiana"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza5.jpg")
                PictureBox1.Visible = True
            Case "Calabresa"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza6.jpg")
                PictureBox1.Visible = True
            Case "Calabresa C/ Catupiry"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza7.jpg")
                PictureBox1.Visible = True
            Case "Cheddar"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza8.jpg")
                PictureBox1.Visible = True
            Case "Donatello"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza9.jpg")
                PictureBox1.Visible = True
            Case "Escarola"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza10.jpg")
                PictureBox1.Visible = True
            Case "Framboesa"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza11.jpg")
                PictureBox1.Visible = True
            Case "Hawaii"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza12.jpg")
                PictureBox1.Visible = True
            Case "Jardineira"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza13.jpg")
                PictureBox1.Visible = True
            Case "Napolitana"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza14.jpg")
                PictureBox1.Visible = True
            Case "Primavera"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\pizzas\pizza15.jpg")
                PictureBox1.Visible = True

        End Select

        con.Close()

    End Sub
End Class