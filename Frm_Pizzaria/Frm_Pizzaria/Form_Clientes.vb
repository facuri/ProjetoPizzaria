Imports System.Data.OleDb
Public Class Form_Clientes
    Dim anome(0) As String
    Dim codcli As Integer
    Dim leitor As OleDbDataReader


    Private Sub Tabela_ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabela_ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabela_ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PizzariaDataSet)

    End Sub

    Private Sub Form_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega os dados para a tabela 'PizzariaDataSet.Tabela_Clientes'. Você pode movê-la, ou removê-la, conforme necessário.
        Me.Tabela_ClientesTableAdapter.Fill(Me.PizzariaDataSet.Tabela_Clientes)


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Tabela_ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim position As Integer
        position = Me.Tabela_ClientesBindingSource.Position
        Me.Tabela_ClientesBindingSource.MovePrevious()
        If position < 1 Then
            Beep()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Tabela_ClientesBindingSource.MoveNext()
        If Tabela_ClientesBindingSource.Position = Tabela_ClientesBindingSource.Count - 1 Then
            Beep()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Tabela_ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Nome_CliTextBox.Focus()
        Me.Tabela_ClientesBindingSource.AddNew()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        incluir_nomes()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        alterar_nomes()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Tabela_ClientesBindingSource.CancelEdit()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        excluir_nomes()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Tabela_ClientesDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabela_ClientesDataGridView.SelectionChanged
        TextBox1.Text = Me.Tabela_ClientesBindingSource.Position + 1 & " / " & Me.Tabela_ClientesBindingSource.Count
    End Sub

    Private Sub EmailTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmailTextBox.LostFocus
        critica_campos()
    End Sub

    Private Sub RG_cliTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
            MessageBox.Show("Erro de Digitação!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Public Function critica_campos()
        If Not (EmailTextBox.Text.Contains("@") And EmailTextBox.Text.Contains(".")) Then
            MessageBox.Show("Digite o endereço do email completo! ", "Erro de digitação!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EmailTextBox.Focus()
            Return False

        End If
        Return True

    End Function

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Tabela_ClientesBindingSource.Filter = "Nome_cli like '%" & TextBox2.Text.ToLower & "%'"
    End Sub
    Private Sub carrega_infocli()
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"

        con.Open()
        Dim comando As New OleDbCommand()
        comando.CommandText = "select código_cliente,nome_cli,telefone_com,telefone_cel,endereco ,bairro,cidade,estado,rg_cli,data_nascimento,data_cadastro,sexo,email " & _
                              "from tabela_clientes where nome_cli  = " & Label3.Text
        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader

        leitor.Read()

        codcli = leitor("código_cliente")

        leitor.Close()

        con.Close()

    End Sub
    Public Sub carrega_nomes()
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()
        Dim comando As New OleDbCommand()
        comando.CommandText = "select código_cliente, nome_cli,telefone_com,telefone_cel,endereco,bairro,cidade,estado,rg_cli,data_nascimento,data_cadastro,sexo,email from tabela_clientes "
        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim leitor As OleDbDataReader
        leitor = comando.ExecuteReader

        comando.Connection = con

        con.Close()
        Nome_CliTextBox.Text = 0

        Tabela_ClientesDataGridView.Rows.Remove(Tabela_ClientesDataGridView.CurrentRow)



    End Sub
    Private Sub incluir_nomes()
        Dim con As New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Usuários\Dalmo\Documents\VB,cd Principal\APOSTILA,VB-ESTUDOS\Apostila - VB2008\Exercícios,VB-apostila,2008\Projeto, Pizzaria,2\Frm_Pizzaria\Frm_Pizzaria\Pizzaria.accdb'"
        con.Open()

        If Nome_CliTextBox.Text = "" Then
            MessageBox.Show("O Campo Nome é obrigatório!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Nome_CliTextBox.Focus()
        
            Exit Sub

        End If

        If Not MaskedTextBox_rg.MaskCompleted Then
            MessageBox.Show("O Campo RG é obrigatório!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MaskedTextBox_rg.Focus()
            Exit Sub
        End If

        If Not MaskedTextBox1.MaskCompleted Then
            MessageBox.Show("O Campo Telefone é obrigatório!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MaskedTextBox1.Focus()
            Exit Sub
        End If

        If Not MaskedTextBox2.MaskCompleted Then
            MessageBox.Show("O Campo Celular é obrigatório!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MaskedTextBox2.Focus()
            Exit Sub
        End If

        MessageBox.Show("Dados Inseridos com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim comando As New OleDbCommand()

        comando.CommandText = "insert into  tabela_clientes (nome_cli,telefone_com,telefone_cel,endereco ,bairro ,cidade,estado,rg_cli,data_nascimento,data_cadastro,sexo,email) " & _
                              " values( ? , ? , ? , ? , ? , ? , ? , ? , ? , ? , ? , ? )"
        comando.Parameters.Clear()
        comando.Parameters.Add("@Nome_cli", OleDbType.VarChar, 30).Value = Nome_CliTextBox.Text
        comando.Parameters.Add("@Telefone_com", System.Data.OleDb.OleDbType.VarChar, 15).Value = MaskedTextBox1.Text
        comando.Parameters.Add("@Telefone_cel", System.Data.OleDb.OleDbType.VarChar, 15).Value = MaskedTextBox2.Text
        comando.Parameters.Add("@Endereco", System.Data.OleDb.OleDbType.VarChar, 40).Value = EnderecoTextBox.Text
        comando.Parameters.Add("@Bairro", System.Data.OleDb.OleDbType.VarChar, 15).Value = BairroTextBox.Text
        comando.Parameters.Add("@Cidade", System.Data.OleDb.OleDbType.VarChar, 30).Value = CidadeTextBox.Text
        comando.Parameters.Add("@Estado", System.Data.OleDb.OleDbType.VarChar, 3).Value = ComboBox_estado.Text
        comando.Parameters.Add("@RG_cli", System.Data.OleDb.OleDbType.VarChar, 12).Value = MaskedTextBox_rg.Text
        comando.Parameters.Add("@data_nascimento", System.Data.OleDb.OleDbType.VarChar, 10).Value = DateTimePicker1.Text
        comando.Parameters.Add("@data_cadastro", System.Data.OleDb.OleDbType.VarChar, 10).Value = DateTimePicker2.Text
        comando.Parameters.Add("@sexo", System.Data.OleDb.OleDbType.VarChar, 10).Value = ComboBox_sexo.Text
        comando.Parameters.Add("@email", System.Data.OleDb.OleDbType.VarChar, 25).Value = EmailTextBox.Text

        comando.CommandType = CommandType.Text

        comando.Connection = con
        Dim c As Integer
        Try
            c = comando.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir  dados no Banco de Dados: " & ex.Message)
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

        comando.CommandText = "update  tabela_clientes set nome_cli = '" & Nome_CliTextBox.Text & "', " & _
             "telefone_com = '" & MaskedTextBox1.Text & "', " & _
             "telefone_cel = '" & MaskedTextBox2.Text & "', " & _
             "endereco  = '" & EnderecoTextBox.Text & "', " & _
             "bairro  = '" & BairroTextBox.Text & "', " & _
             "cidade = '" & CidadeTextBox.Text & "', " & _
             "Estado ='" & ComboBox_estado.Text & "', " & _
             "rg_cli = '" & MaskedTextBox_rg.Text & "'," & _
             "data_nascimento ='" & DateTimePicker1.Text & "', " & _
            "data_cadastro ='" & DateTimePicker2.Text & "', " & _
             "sexo ='" & ComboBox_sexo.Text & "', " & _
            "email ='" & EmailTextBox.Text & "' " & _
             "where código_cliente = " & Label3.Text

        comando.Connection = con
        Dim c As Integer
        Try

            c = comando.ExecuteNonQuery

        Catch ex As Exception

            carrega_nomes()

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
        comando.CommandText = "delete from tabela_clientes where código_cliente = " & Label3.Text

        comando.CommandType = CommandType.Text

        comando.Connection = con

        Dim c As Integer
        Try
            c = comando.ExecuteNonQuery

        Catch ex As Exception
            MessageBox.Show("Erro ao apagar  dados no Banco de Dados: " & ex.Message)
            carrega_infocli()

            Return
        End Try
        MessageBox.Show(String.Format("Registro apagado com sucesso! - {0} registros .", c))
        carrega_nomes()

    End Sub

    Private Sub Form_Clientes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            Me.Tabela_ClientesBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.PizzariaDataSet)
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Form_Funcionarios.ShowDialog()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PizzaToolStripMenuItem.Click
        Form_Pizza.ShowDialog()
    End Sub
End Class