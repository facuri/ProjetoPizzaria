Imports System.Data.OleDb
Public Class Form_Funcionarios
    Dim anome(0) As String
    Dim codcli As Integer
    Dim leitor As OleDbDataReader

    Private Sub Tabela_FuncionarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabela_FuncionarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabela_FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PizzariaDataSet)

    End Sub

    Private Sub Form_Funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega os dados para a tabela 'PizzariaDataSet.Tabela_Funcionario'. Você pode movê-la, ou removê-la, conforme necessário.
        Me.Tabela_FuncionarioTableAdapter.Fill(Me.PizzariaDataSet.Tabela_Funcionario)
        fotos()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Tabela_FuncionarioBindingSource.MoveFirst()
        fotos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim position As Integer
        position = Me.Tabela_FuncionarioBindingSource.Position
        Me.Tabela_FuncionarioBindingSource.MovePrevious()
        If position < 1 Then
            Beep()


        End If
        fotos()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Tabela_FuncionarioBindingSource.MoveNext()
        If Tabela_FuncionarioBindingSource.Position = Tabela_FuncionarioBindingSource.Count - 1 Then
            Beep()
        End If
        fotos()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Tabela_FuncionarioBindingSource.MoveLast()
        fotos()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NomeTextBox.Focus()
        Me.Tabela_FuncionarioBindingSource.AddNew()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        incluir_nomes()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        alterar_nomes()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        excluir_nomes()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Tabela_FuncionarioBindingSource.CancelEdit()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Tabela_FuncionarioDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabela_FuncionarioDataGridView.SelectionChanged
        TextBox1.Text = Me.Tabela_FuncionarioBindingSource.Position + 1 & " / " & Me.Tabela_FuncionarioBindingSource.Count
    End Sub
    'Pesquisa por nome
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Tabela_FuncionarioBindingSource.Filter = "Nome like '%" & TextBox2.Text.ToLower & "%'"
    End Sub

    Private Sub Form_Funcionarios_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.Tabela_FuncionarioBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.PizzariaDataSet)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub incluir_nomes()
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        MessageBox.Show("Dados Inseridos com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim comando As New OleDbCommand()

        comando.CommandText = "insert into  tabela_funcionario (nome,cargo,telefone) " & _
        " values( ? , ? , ?  )"
        comando.Parameters.Clear()
        comando.Parameters.Add("@Nome", OleDbType.VarChar, 30).Value = NomeTextBox.Text
        comando.Parameters.Add("@cargo", System.Data.OleDb.OleDbType.VarChar, 20).Value = ComboBox1.Text
        comando.Parameters.Add("@Telefone", System.Data.OleDb.OleDbType.VarChar, 15).Value = MaskedTextBox1.Text

        comando.CommandType = CommandType.Text

        comando.Connection = con

        Dim c As Integer
        Try
            c = comando.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir  dados no Banco de Dados: " & ex.Message)
            MessageBox.Show("Dados inseridos com sucesso: " & ex.Message)

            Return
        End Try

    End Sub
    Private Sub alterar_nomes()
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"

        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao tentar acessar conexão com o  Banco de Dados." & ex.Message)
            Return
        End Try
        MessageBox.Show("Dados Inseridos com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim comando As New OleDbCommand()

        comando.CommandText = "update  tabela_funcionario set nome = '" & NomeTextBox.Text & "', " & _
        "cargo = '" & ComboBox1.Text & "', " & _
       "telefone = '" & MaskedTextBox1.Text & "' " & _
      "where código_funcionario = " & Label2.Text

        comando.Connection = con

        Dim c As Integer
        Try
            c = comando.ExecuteNonQuery

        Catch ex As Exception
            Return
        End Try

    End Sub
    Private Sub excluir_nomes()
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao tentar acessar conexão com o  Banco de Dados." & ex.Message)
            Return
        End Try

        Dim comando As New OleDbCommand()
        comando.CommandText = "delete from tabela_funcionario where código_funcionario = " & Label2.Text

        comando.CommandType = CommandType.Text

        comando.Connection = con

        Dim c As Integer

        Try
            c = comando.ExecuteNonQuery

        Catch ex As Exception
            MessageBox.Show("Erro ao apagar  dados no Banco de Dados: " & ex.Message)
            Return
        End Try
        MessageBox.Show(String.Format("Registro apagado com sucesso! - {0} registros .", c))
    End Sub
    'Carrega fotos dos funcionários
    Private Sub fotos()
        Select Case NomeTextBox.Text
            Case "Carlos Marcos"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto1.jpg")
                PictureBox1.Visible = True
            Case "Carmen Amaro"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto2.jpg")
                PictureBox1.Visible = True
            Case "Cleusa Santos"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto3.jpg")
                PictureBox1.Visible = True
            Case "Fernanda Varani"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto4.jpg")
                PictureBox1.Visible = True
            Case "Franscisco Lopes"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto5.jpg")
                PictureBox1.Visible = True
            Case "Giovanna Mendes"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto6.jpg")
                PictureBox1.Visible = True
            Case "José Mendes"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto7.jpg")
                PictureBox1.Visible = True
            Case "Manoel Maia"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto8.jpg")
                PictureBox1.Visible = True
            Case "Marcos Júnior"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto9.jpg")
                PictureBox1.Visible = True
            Case "Rafael Marcos"
                PictureBox1.Load("D:\Usuários\Dalmo\Pictures\fotos\foto10.jpg")
                PictureBox1.Visible = True


        End Select

    End Sub





    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class