<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Nome_CliLabel As System.Windows.Forms.Label
        Dim Telefone_ComLabel As System.Windows.Forms.Label
        Dim Telefone_CelLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim RG_cliLabel As System.Windows.Forms.Label
        Dim Data_NascimentoLabel As System.Windows.Forms.Label
        Dim Data_CadastroLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Clientes))
        Me.Tabela_ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tabela_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzariaDataSet = New Frm_Pizzaria.PizzariaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tabela_ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nome_CliTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Tabela_ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox_estado = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_sexo = New System.Windows.Forms.ComboBox()
        Me.Tabela_ClientesTableAdapter = New Frm_Pizzaria.PizzariaDataSetTableAdapters.Tabela_ClientesTableAdapter()
        Me.TableAdapterManager = New Frm_Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager()
        Me.MaskedTextBox_rg = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Nome_CliLabel = New System.Windows.Forms.Label()
        Telefone_ComLabel = New System.Windows.Forms.Label()
        Telefone_CelLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        RG_cliLabel = New System.Windows.Forms.Label()
        Data_NascimentoLabel = New System.Windows.Forms.Label()
        Data_CadastroLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.Tabela_ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabela_ClientesBindingNavigator.SuspendLayout()
        CType(Me.Tabela_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabela_ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nome_CliLabel
        '
        Nome_CliLabel.AutoSize = True
        Nome_CliLabel.Location = New System.Drawing.Point(8, 121)
        Nome_CliLabel.Name = "Nome_CliLabel"
        Nome_CliLabel.Size = New System.Drawing.Size(38, 13)
        Nome_CliLabel.TabIndex = 3
        Nome_CliLabel.Text = "Nome:"
        '
        'Telefone_ComLabel
        '
        Telefone_ComLabel.AutoSize = True
        Telefone_ComLabel.Location = New System.Drawing.Point(8, 152)
        Telefone_ComLabel.Name = "Telefone_ComLabel"
        Telefone_ComLabel.Size = New System.Drawing.Size(101, 13)
        Telefone_ComLabel.TabIndex = 5
        Telefone_ComLabel.Text = "Telefone Comercial:"
        '
        'Telefone_CelLabel
        '
        Telefone_CelLabel.AutoSize = True
        Telefone_CelLabel.Location = New System.Drawing.Point(244, 152)
        Telefone_CelLabel.Name = "Telefone_CelLabel"
        Telefone_CelLabel.Size = New System.Drawing.Size(87, 13)
        Telefone_CelLabel.TabIndex = 7
        Telefone_CelLabel.Text = "Telefone Celular:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(8, 182)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 9
        EnderecoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(257, 182)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 11
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(8, 215)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 13
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(257, 215)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 15
        EstadoLabel.Text = "Estado:"
        '
        'RG_cliLabel
        '
        RG_cliLabel.AutoSize = True
        RG_cliLabel.Location = New System.Drawing.Point(8, 281)
        RG_cliLabel.Name = "RG_cliLabel"
        RG_cliLabel.Size = New System.Drawing.Size(66, 13)
        RG_cliLabel.TabIndex = 17
        RG_cliLabel.Text = "Número RG:"
        '
        'Data_NascimentoLabel
        '
        Data_NascimentoLabel.AutoSize = True
        Data_NascimentoLabel.Location = New System.Drawing.Point(8, 247)
        Data_NascimentoLabel.Name = "Data_NascimentoLabel"
        Data_NascimentoLabel.Size = New System.Drawing.Size(92, 13)
        Data_NascimentoLabel.TabIndex = 19
        Data_NascimentoLabel.Text = "Data Nascimento:"
        '
        'Data_CadastroLabel
        '
        Data_CadastroLabel.AutoSize = True
        Data_CadastroLabel.Location = New System.Drawing.Point(225, 247)
        Data_CadastroLabel.Name = "Data_CadastroLabel"
        Data_CadastroLabel.Size = New System.Drawing.Size(78, 13)
        Data_CadastroLabel.TabIndex = 21
        Data_CadastroLabel.Text = "Data Cadastro:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(8, 306)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 23
        SexoLabel.Text = "Sexo:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(139, 306)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 25
        EmailLabel.Text = "Email:"
        '
        'Tabela_ClientesBindingNavigator
        '
        Me.Tabela_ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tabela_ClientesBindingNavigator.BindingSource = Me.Tabela_ClientesBindingSource
        Me.Tabela_ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tabela_ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tabela_ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tabela_ClientesBindingNavigatorSaveItem})
        Me.Tabela_ClientesBindingNavigator.Location = New System.Drawing.Point(0, 28)
        Me.Tabela_ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tabela_ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tabela_ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tabela_ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tabela_ClientesBindingNavigator.Name = "Tabela_ClientesBindingNavigator"
        Me.Tabela_ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tabela_ClientesBindingNavigator.Size = New System.Drawing.Size(638, 25)
        Me.Tabela_ClientesBindingNavigator.TabIndex = 0
        Me.Tabela_ClientesBindingNavigator.Text = "BindingNavigator1"
        Me.Tabela_ClientesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'Tabela_ClientesBindingSource
        '
        Me.Tabela_ClientesBindingSource.DataMember = "Tabela_Clientes"
        Me.Tabela_ClientesBindingSource.DataSource = Me.PizzariaDataSet
        '
        'PizzariaDataSet
        '
        Me.PizzariaDataSet.DataSetName = "PizzariaDataSet"
        Me.PizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tabela_ClientesBindingNavigatorSaveItem
        '
        Me.Tabela_ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tabela_ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tabela_ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tabela_ClientesBindingNavigatorSaveItem.Name = "Tabela_ClientesBindingNavigatorSaveItem"
        Me.Tabela_ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tabela_ClientesBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Nome_CliTextBox
        '
        Me.Nome_CliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Nome_Cli", True))
        Me.Nome_CliTextBox.Location = New System.Drawing.Point(48, 118)
        Me.Nome_CliTextBox.Name = "Nome_CliTextBox"
        Me.Nome_CliTextBox.Size = New System.Drawing.Size(196, 20)
        Me.Nome_CliTextBox.TabIndex = 1
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(66, 179)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(174, 20)
        Me.EnderecoTextBox.TabIndex = 4
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(293, 179)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(118, 20)
        Me.BairroTextBox.TabIndex = 5
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(52, 212)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(188, 20)
        Me.CidadeTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(175, 303)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(128, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'Tabela_ClientesDataGridView
        '
        Me.Tabela_ClientesDataGridView.AutoGenerateColumns = False
        Me.Tabela_ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabela_ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Tabela_ClientesDataGridView.DataSource = Me.Tabela_ClientesBindingSource
        Me.Tabela_ClientesDataGridView.Location = New System.Drawing.Point(11, 337)
        Me.Tabela_ClientesDataGridView.MultiSelect = False
        Me.Tabela_ClientesDataGridView.Name = "Tabela_ClientesDataGridView"
        Me.Tabela_ClientesDataGridView.ReadOnly = True
        Me.Tabela_ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabela_ClientesDataGridView.Size = New System.Drawing.Size(600, 220)
        Me.Tabela_ClientesDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código_Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome_Cli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefone_Com"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefone Comercial"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefone_Cel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefone Celular"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Endereco"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Bairro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bairro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "RG_cli"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Número RG"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Data_Nascimento"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Data Nascimento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Data_Cadastro"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Data Cadastro"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Sexo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(222, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Clientes"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.LightGray
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(358, 73)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(55, 23)
        Me.Button14.TabIndex = 98
        Me.Button14.Text = "Alterar"
        Me.ToolTip1.SetToolTip(Me.Button14, "Alterar registro")
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.LightGray
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(477, 73)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(55, 23)
        Me.Button13.TabIndex = 97
        Me.Button13.Text = "Excluir"
        Me.ToolTip1.SetToolTip(Me.Button13, "excluir registro")
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightGray
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(311, 73)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(53, 23)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Incluir"
        Me.ToolTip1.SetToolTip(Me.Button10, "Adicionar novo registro")
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightGray
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(213, 73)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 23)
        Me.Button9.TabIndex = 96
        Me.Button9.Text = ">|"
        Me.ToolTip1.SetToolTip(Me.Button9, "Último registro")
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightGray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(21, 73)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(43, 23)
        Me.Button8.TabIndex = 95
        Me.Button8.Text = "|<"
        Me.ToolTip1.SetToolTip(Me.Button8, "Primeiro registro")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(532, 73)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 23)
        Me.Button7.TabIndex = 94
        Me.Button7.Text = "Sair"
        Me.ToolTip1.SetToolTip(Me.Button7, "Sair")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TextBox1.TabIndex = 93
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Posição atual")
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(411, 73)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 23)
        Me.Button6.TabIndex = 92
        Me.Button6.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.Button6, "Cancelar registro")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(260, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 23)
        Me.Button3.TabIndex = 91
        Me.Button3.Text = "Novo"
        Me.ToolTip1.SetToolTip(Me.Button3, "Adicionar registro")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(160, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = ">>>>"
        Me.ToolTip1.SetToolTip(Me.Button2, "Próximo registro")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "<<<<"
        Me.ToolTip1.SetToolTip(Me.Button1, "Registro anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(638, 28)
        Me.MenuStrip1.TabIndex = 101
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PizzaToolStripMenuItem, Me.FuncionáriosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'PizzaToolStripMenuItem
        '
        Me.PizzaToolStripMenuItem.Name = "PizzaToolStripMenuItem"
        Me.PizzaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PizzaToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.PizzaToolStripMenuItem.Text = "Pizza "
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(396, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 34)
        Me.Panel1.TabIndex = 102
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pesquisar/Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(304, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Código_Cliente", True))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Location = New System.Drawing.Point(116, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Label3"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Telefone_Com", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(109, 149)
        Me.MaskedTextBox1.Mask = "(99) 0000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 2
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Telefone_Cel", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(332, 149)
        Me.MaskedTextBox2.Mask = "(99) 0000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 3
        '
        'ComboBox_estado
        '
        Me.ComboBox_estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Estado", True))
        Me.ComboBox_estado.FormattingEnabled = True
        Me.ComboBox_estado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE ", "DF ", "ES ", "GO ", "MA ", "MT ", "MS ", "MG ", "PR ", "PB ", "PA ", "PE ", "PI ", "RJ ", "RN ", "RS", "RO", "RR", "SC", "SE ", "SP", "TO"})
        Me.ComboBox_estado.Location = New System.Drawing.Point(301, 212)
        Me.ComboBox_estado.Name = "ComboBox_estado"
        Me.ComboBox_estado.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox_estado.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Data_Nascimento", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 241)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Data_Cadastro", True))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(305, 241)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'ComboBox_sexo
        '
        Me.ComboBox_sexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "Sexo", True))
        Me.ComboBox_sexo.FormattingEnabled = True
        Me.ComboBox_sexo.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBox_sexo.Location = New System.Drawing.Point(43, 303)
        Me.ComboBox_sexo.Name = "ComboBox_sexo"
        Me.ComboBox_sexo.Size = New System.Drawing.Size(63, 21)
        Me.ComboBox_sexo.TabIndex = 11
        '
        'Tabela_ClientesTableAdapter
        '
        Me.Tabela_ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabela_ClientesTableAdapter = Me.Tabela_ClientesTableAdapter
        Me.TableAdapterManager.Tabela_FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.Tabela_PizzaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Frm_Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaskedTextBox_rg
        '
        Me.MaskedTextBox_rg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabela_ClientesBindingSource, "RG_cli", True))
        Me.MaskedTextBox_rg.Location = New System.Drawing.Point(74, 274)
        Me.MaskedTextBox_rg.Mask = "00.000.000-0"
        Me.MaskedTextBox_rg.Name = "MaskedTextBox_rg"
        Me.MaskedTextBox_rg.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_rg.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(178, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(213, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(436, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "*"
        '
        'Form_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(638, 566)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox_rg)
        Me.Controls.Add(Me.ComboBox_sexo)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox_estado)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabela_ClientesDataGridView)
        Me.Controls.Add(Nome_CliLabel)
        Me.Controls.Add(Me.Nome_CliTextBox)
        Me.Controls.Add(Telefone_ComLabel)
        Me.Controls.Add(Telefone_CelLabel)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(RG_cliLabel)
        Me.Controls.Add(Data_NascimentoLabel)
        Me.Controls.Add(Data_CadastroLabel)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Tabela_ClientesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.Tabela_ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabela_ClientesBindingNavigator.ResumeLayout(False)
        Me.Tabela_ClientesBindingNavigator.PerformLayout()
        CType(Me.Tabela_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabela_ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PizzariaDataSet As Frm_Pizzaria.PizzariaDataSet
    Friend WithEvents Tabela_ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabela_ClientesTableAdapter As Frm_Pizzaria.PizzariaDataSetTableAdapters.Tabela_ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Frm_Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabela_ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tabela_ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nome_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tabela_ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox_estado As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents PizzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaskedTextBox_rg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
