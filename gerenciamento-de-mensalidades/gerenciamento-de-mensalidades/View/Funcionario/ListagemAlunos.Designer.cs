namespace gerenciamento_de_mensalidades.View.Funcionario
{
    partial class ListagemAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolsista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMensalidadesAtrasadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDivida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoBolsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnAtualizarBolsa = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.cbDesconto = new System.Windows.Forms.ComboBox();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.txbIDAluno = new System.Windows.Forms.TextBox();
            this.cbStatusPagamento = new System.Windows.Forms.ComboBox();
            this.cbStatusData = new System.Windows.Forms.ComboBox();
            this.dgvMensalidades = new System.Windows.Forms.DataGridView();
            this.Mês = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBolsista = new System.Windows.Forms.Button();
            this.btnRemoverBolsa = new System.Windows.Forms.Button();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 60);
            this.panel1.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(58, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alunos";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeUsuario.Location = new System.Drawing.Point(909, 21);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(181, 16);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "Nome usuário conectado";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.RA,
            this.Nascimento,
            this.CPF,
            this.Curso,
            this.Contato,
            this.Bolsista,
            this.email,
            this.numMensalidadesAtrasadas,
            this.valorTotalDivida,
            this.idAluno,
            this.idUsuario,
            this.descontoBolsa});
            this.dgvAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvAlunos.Location = new System.Drawing.Point(12, 120);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(1163, 318);
            this.dgvAlunos.TabIndex = 85;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            // 
            // Nome
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // RA
            // 
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            this.RA.Width = 60;
            // 
            // Nascimento
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Nascimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            this.Nascimento.Width = 90;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 90;
            // 
            // Curso
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Curso.DefaultCellStyle = dataGridViewCellStyle3;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 150;
            // 
            // Contato
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contato.DefaultCellStyle = dataGridViewCellStyle4;
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            // 
            // Bolsista
            // 
            this.Bolsista.HeaderText = "Bolsista";
            this.Bolsista.Name = "Bolsista";
            this.Bolsista.ReadOnly = true;
            this.Bolsista.Width = 55;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // numMensalidadesAtrasadas
            // 
            dataGridViewCellStyle5.NullValue = null;
            this.numMensalidadesAtrasadas.DefaultCellStyle = dataGridViewCellStyle5;
            this.numMensalidadesAtrasadas.HeaderText = "Nº Mensalidades Atrasadas";
            this.numMensalidadesAtrasadas.Name = "numMensalidadesAtrasadas";
            this.numMensalidadesAtrasadas.ReadOnly = true;
            this.numMensalidadesAtrasadas.Width = 110;
            // 
            // valorTotalDivida
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorTotalDivida.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorTotalDivida.HeaderText = "Valor Total Dívida";
            this.valorTotalDivida.Name = "valorTotalDivida";
            this.valorTotalDivida.ReadOnly = true;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID Aluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // descontoBolsa
            // 
            this.descontoBolsa.HeaderText = "Desconto Bolsa";
            this.descontoBolsa.Name = "descontoBolsa";
            this.descontoBolsa.ReadOnly = true;
            this.descontoBolsa.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(12, 81);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 26);
            this.btnVoltar.TabIndex = 82;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.txbPesquisa.Location = new System.Drawing.Point(329, 86);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(352, 21);
            this.txbPesquisa.TabIndex = 118;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.btnExcluirAluno);
            this.panelDados.Controls.Add(this.btnAtualizarBolsa);
            this.panelDados.Controls.Add(this.lblDesconto);
            this.panelDados.Controls.Add(this.cbDesconto);
            this.panelDados.Controls.Add(this.txbIDUsuario);
            this.panelDados.Controls.Add(this.txbIDAluno);
            this.panelDados.Controls.Add(this.cbStatusPagamento);
            this.panelDados.Controls.Add(this.cbStatusData);
            this.panelDados.Controls.Add(this.dgvMensalidades);
            this.panelDados.Controls.Add(this.btnBolsista);
            this.panelDados.Controls.Add(this.btnRemoverBolsa);
            this.panelDados.Controls.Add(this.txbCurso);
            this.panelDados.Controls.Add(this.lblCurso);
            this.panelDados.Controls.Add(this.txbNascimento);
            this.panelDados.Controls.Add(this.lblNascimento);
            this.panelDados.Controls.Add(this.txbCPF);
            this.panelDados.Controls.Add(this.lblCPF);
            this.panelDados.Controls.Add(this.txbRA);
            this.panelDados.Controls.Add(this.lblRA);
            this.panelDados.Controls.Add(this.txbNome);
            this.panelDados.Controls.Add(this.lblNome);
            this.panelDados.Controls.Add(this.txbEmail);
            this.panelDados.Controls.Add(this.txbContato);
            this.panelDados.Controls.Add(this.lblEmail);
            this.panelDados.Controls.Add(this.lblContato);
            this.panelDados.Location = new System.Drawing.Point(13, 444);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1162, 194);
            this.panelDados.TabIndex = 119;
            this.panelDados.Visible = false;
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluirAluno.Location = new System.Drawing.Point(361, 137);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(200, 26);
            this.btnExcluirAluno.TabIndex = 144;
            this.btnExcluirAluno.Text = "Excluir aluno";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Visible = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnAtualizarBolsa
            // 
            this.btnAtualizarBolsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarBolsa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizarBolsa.Location = new System.Drawing.Point(361, 73);
            this.btnAtualizarBolsa.Name = "btnAtualizarBolsa";
            this.btnAtualizarBolsa.Size = new System.Drawing.Size(200, 26);
            this.btnAtualizarBolsa.TabIndex = 138;
            this.btnAtualizarBolsa.Text = "Atualizar bolsa";
            this.btnAtualizarBolsa.UseVisualStyleBackColor = true;
            this.btnAtualizarBolsa.Visible = false;
            this.btnAtualizarBolsa.Click += new System.EventHandler(this.btnAtualizarBolsa_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesconto.Location = new System.Drawing.Point(358, 45);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(78, 16);
            this.lblDesconto.TabIndex = 143;
            this.lblDesconto.Text = "Desconto:";
            // 
            // cbDesconto
            // 
            this.cbDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbDesconto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDesconto.ForeColor = System.Drawing.SystemColors.Control;
            this.cbDesconto.FormattingEnabled = true;
            this.cbDesconto.Items.AddRange(new object[] {
            "10%",
            "25%",
            "35%",
            "50%",
            "60%",
            "75%",
            "85%",
            "100%"});
            this.cbDesconto.Location = new System.Drawing.Point(442, 42);
            this.cbDesconto.Name = "cbDesconto";
            this.cbDesconto.Size = new System.Drawing.Size(119, 21);
            this.cbDesconto.TabIndex = 121;
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbIDUsuario.Location = new System.Drawing.Point(40, 40);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.ReadOnly = true;
            this.txbIDUsuario.Size = new System.Drawing.Size(71, 21);
            this.txbIDUsuario.TabIndex = 142;
            this.txbIDUsuario.Visible = false;
            // 
            // txbIDAluno
            // 
            this.txbIDAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbIDAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbIDAluno.Location = new System.Drawing.Point(40, 40);
            this.txbIDAluno.Name = "txbIDAluno";
            this.txbIDAluno.ReadOnly = true;
            this.txbIDAluno.Size = new System.Drawing.Size(71, 21);
            this.txbIDAluno.TabIndex = 141;
            this.txbIDAluno.Visible = false;
            // 
            // cbStatusPagamento
            // 
            this.cbStatusPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbStatusPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatusPagamento.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStatusPagamento.FormattingEnabled = true;
            this.cbStatusPagamento.Items.AddRange(new object[] {
            "Todas",
            "Pagas",
            "Não Pagas"});
            this.cbStatusPagamento.Location = new System.Drawing.Point(993, 5);
            this.cbStatusPagamento.Name = "cbStatusPagamento";
            this.cbStatusPagamento.Size = new System.Drawing.Size(145, 21);
            this.cbStatusPagamento.TabIndex = 140;
            this.cbStatusPagamento.SelectedIndexChanged += new System.EventHandler(this.cbStatusPagamento_SelectedIndexChanged);
            // 
            // cbStatusData
            // 
            this.cbStatusData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbStatusData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatusData.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStatusData.FormattingEnabled = true;
            this.cbStatusData.Items.AddRange(new object[] {
            "Mais recentes",
            "Mais antigas"});
            this.cbStatusData.Location = new System.Drawing.Point(834, 6);
            this.cbStatusData.Name = "cbStatusData";
            this.cbStatusData.Size = new System.Drawing.Size(142, 21);
            this.cbStatusData.TabIndex = 139;
            this.cbStatusData.SelectedIndexChanged += new System.EventHandler(this.cbStatusData_SelectedIndexChanged);
            // 
            // dgvMensalidades
            // 
            this.dgvMensalidades.AllowUserToAddRows = false;
            this.dgvMensalidades.AllowUserToDeleteRows = false;
            this.dgvMensalidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvMensalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mês,
            this.Valor,
            this.DataVencimento,
            this.Pago,
            this.DataPagamento});
            this.dgvMensalidades.Location = new System.Drawing.Point(649, 34);
            this.dgvMensalidades.Name = "dgvMensalidades";
            this.dgvMensalidades.ReadOnly = true;
            this.dgvMensalidades.Size = new System.Drawing.Size(510, 150);
            this.dgvMensalidades.TabIndex = 138;
            // 
            // Mês
            // 
            this.Mês.HeaderText = "Mês";
            this.Mês.Name = "Mês";
            this.Mês.ReadOnly = true;
            // 
            // Valor
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle7;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // DataVencimento
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.DataVencimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataVencimento.HeaderText = "Data Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 50;
            // 
            // DataPagamento
            // 
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = "** Não Pago **";
            this.DataPagamento.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataPagamento.HeaderText = "Data Pagamento";
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            // 
            // btnBolsista
            // 
            this.btnBolsista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBolsista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolsista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBolsista.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBolsista.Location = new System.Drawing.Point(361, 73);
            this.btnBolsista.Name = "btnBolsista";
            this.btnBolsista.Size = new System.Drawing.Size(200, 26);
            this.btnBolsista.TabIndex = 137;
            this.btnBolsista.Text = "Definir aluno como bolsista";
            this.btnBolsista.UseVisualStyleBackColor = true;
            this.btnBolsista.Visible = false;
            this.btnBolsista.Click += new System.EventHandler(this.btnBolsista_Click);
            // 
            // btnRemoverBolsa
            // 
            this.btnRemoverBolsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverBolsa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoverBolsa.Location = new System.Drawing.Point(361, 105);
            this.btnRemoverBolsa.Name = "btnRemoverBolsa";
            this.btnRemoverBolsa.Size = new System.Drawing.Size(200, 26);
            this.btnRemoverBolsa.TabIndex = 136;
            this.btnRemoverBolsa.Text = "Remover bolsa";
            this.btnRemoverBolsa.UseVisualStyleBackColor = true;
            this.btnRemoverBolsa.Visible = false;
            this.btnRemoverBolsa.Click += new System.EventHandler(this.btnRemoverBolsa_Click);
            // 
            // txbCurso
            // 
            this.txbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCurso.Location = new System.Drawing.Point(60, 162);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.ReadOnly = true;
            this.txbCurso.Size = new System.Drawing.Size(271, 21);
            this.txbCurso.TabIndex = 135;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurso.Location = new System.Drawing.Point(3, 165);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 16);
            this.lblCurso.TabIndex = 134;
            this.lblCurso.Text = "Curso:";
            // 
            // txbNascimento
            // 
            this.txbNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNascimento.Location = new System.Drawing.Point(101, 72);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.ReadOnly = true;
            this.txbNascimento.Size = new System.Drawing.Size(228, 21);
            this.txbNascimento.TabIndex = 133;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNascimento.Location = new System.Drawing.Point(3, 73);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(94, 16);
            this.lblNascimento.TabIndex = 131;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCPF.Location = new System.Drawing.Point(161, 40);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.ReadOnly = true;
            this.txbCPF.Size = new System.Drawing.Size(168, 21);
            this.txbCPF.TabIndex = 130;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPF.Location = new System.Drawing.Point(119, 43);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 16);
            this.lblCPF.TabIndex = 129;
            this.lblCPF.Text = "CPF:";
            // 
            // txbRA
            // 
            this.txbRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRA.ForeColor = System.Drawing.SystemColors.Control;
            this.txbRA.Location = new System.Drawing.Point(40, 40);
            this.txbRA.Name = "txbRA";
            this.txbRA.ReadOnly = true;
            this.txbRA.Size = new System.Drawing.Size(71, 21);
            this.txbRA.TabIndex = 128;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRA.Location = new System.Drawing.Point(3, 43);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(33, 16);
            this.lblRA.TabIndex = 127;
            this.lblRA.Text = "RA:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNome.Location = new System.Drawing.Point(60, 11);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(269, 21);
            this.txbNome.TabIndex = 126;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(3, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 125;
            this.lblNome.Text = "Nome:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmail.Location = new System.Drawing.Point(58, 128);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(271, 21);
            this.txbEmail.TabIndex = 124;
            // 
            // txbContato
            // 
            this.txbContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContato.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContato.Location = new System.Drawing.Point(72, 98);
            this.txbContato.Name = "txbContato";
            this.txbContato.ReadOnly = true;
            this.txbContato.Size = new System.Drawing.Size(257, 21);
            this.txbContato.TabIndex = 123;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(3, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 122;
            this.lblEmail.Text = "Email:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContato.Location = new System.Drawing.Point(3, 101);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(65, 16);
            this.lblContato.TabIndex = 121;
            this.lblContato.Text = "Contato:";
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "Todos os Cursos",
            "Sistemas de Informação",
            "Direito",
            "Pedagogia",
            "Psicologia"});
            this.cbCurso.Location = new System.Drawing.Point(935, 86);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(216, 21);
            this.cbCurso.TabIndex = 120;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // ListagemAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1187, 648);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnVoltar);
            this.Name = "ListagemAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Alunos";
            this.Load += new System.EventHandler(this.ListagemAlunos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.DataGridView dgvMensalidades;
        private System.Windows.Forms.Button btnBolsista;
        private System.Windows.Forms.Button btnRemoverBolsa;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mês;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
        private System.Windows.Forms.ComboBox cbStatusPagamento;
        private System.Windows.Forms.ComboBox cbStatusData;
        private System.Windows.Forms.TextBox txbIDUsuario;
        private System.Windows.Forms.TextBox txbIDAluno;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.ComboBox cbDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolsista;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMensalidadesAtrasadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDivida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoBolsa;
        private System.Windows.Forms.Button btnAtualizarBolsa;
        private System.Windows.Forms.Button btnExcluirAluno;
    }
}