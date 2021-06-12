namespace gerenciamento_de_mensalidades.View.Funcionario
{
    partial class Solicitacoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dgvSolicitacoes = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbMinhasSolicitacoes = new System.Windows.Forms.ComboBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.txbAtendimento = new System.Windows.Forms.TextBox();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnRecusar = new System.Windows.Forms.Button();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDtSolicitacao = new System.Windows.Forms.TextBox();
            this.lblDtSolicitacao = new System.Windows.Forms.Label();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txbAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txbIDSolicitacao = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.lblIDSolicitacao = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoes)).BeginInit();
            this.panelDados.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1053, 60);
            this.panel1.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(58, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Solicitações";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeUsuario.Location = new System.Drawing.Point(767, 21);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(181, 16);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "Nome usuário conectado";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.txbPesquisa.Location = new System.Drawing.Point(286, 83);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(352, 21);
            this.txbPesquisa.TabIndex = 122;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // dgvSolicitacoes
            // 
            this.dgvSolicitacoes.AllowUserToAddRows = false;
            this.dgvSolicitacoes.AllowUserToDeleteRows = false;
            this.dgvSolicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSolicitacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvSolicitacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aluno,
            this.Categoria,
            this.Descricao,
            this.DtSolicitacao,
            this.Status,
            this.Atendimento,
            this.Resposta,
            this.Contato,
            this.curso});
            this.dgvSolicitacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvSolicitacoes.Location = new System.Drawing.Point(12, 117);
            this.dgvSolicitacoes.Name = "dgvSolicitacoes";
            this.dgvSolicitacoes.ReadOnly = true;
            this.dgvSolicitacoes.Size = new System.Drawing.Size(1029, 318);
            this.dgvSolicitacoes.TabIndex = 121;
            this.dgvSolicitacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitacoes_CellClick);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todas",
            "Pendentes",
            "Aprovadas",
            "Rejeitadas"});
            this.cbStatus.Location = new System.Drawing.Point(720, 82);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(142, 21);
            this.cbStatus.TabIndex = 120;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(12, 78);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 26);
            this.btnVoltar.TabIndex = 119;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbMinhasSolicitacoes
            // 
            this.cbMinhasSolicitacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbMinhasSolicitacoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinhasSolicitacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinhasSolicitacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.cbMinhasSolicitacoes.FormattingEnabled = true;
            this.cbMinhasSolicitacoes.Items.AddRange(new object[] {
            "Todas",
            "Minhas Solicitações"});
            this.cbMinhasSolicitacoes.Location = new System.Drawing.Point(884, 82);
            this.cbMinhasSolicitacoes.Name = "cbMinhasSolicitacoes";
            this.cbMinhasSolicitacoes.Size = new System.Drawing.Size(145, 21);
            this.cbMinhasSolicitacoes.TabIndex = 123;
            this.cbMinhasSolicitacoes.SelectedIndexChanged += new System.EventHandler(this.cbMinhasSolicitacoes_SelectedIndexChanged);
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.txbAtendimento);
            this.panelDados.Controls.Add(this.btnAprovar);
            this.panelDados.Controls.Add(this.txbStatus);
            this.panelDados.Controls.Add(this.txbCategoria);
            this.panelDados.Controls.Add(this.btnDeletar);
            this.panelDados.Controls.Add(this.btnRecusar);
            this.panelDados.Controls.Add(this.rtbFeedback);
            this.panelDados.Controls.Add(this.lblFeedback);
            this.panelDados.Controls.Add(this.rtbDescricao);
            this.panelDados.Controls.Add(this.lblDescricao);
            this.panelDados.Controls.Add(this.lblAtendimento);
            this.panelDados.Controls.Add(this.lblStatus);
            this.panelDados.Controls.Add(this.lblCategoria);
            this.panelDados.Controls.Add(this.txtDtSolicitacao);
            this.panelDados.Controls.Add(this.lblDtSolicitacao);
            this.panelDados.Controls.Add(this.txbCurso);
            this.panelDados.Controls.Add(this.lblCurso);
            this.panelDados.Controls.Add(this.txbAluno);
            this.panelDados.Controls.Add(this.lblAluno);
            this.panelDados.Controls.Add(this.txbIDSolicitacao);
            this.panelDados.Controls.Add(this.txbContato);
            this.panelDados.Controls.Add(this.lblIDSolicitacao);
            this.panelDados.Controls.Add(this.lblContato);
            this.panelDados.Location = new System.Drawing.Point(12, 441);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1029, 182);
            this.panelDados.TabIndex = 124;
            this.panelDados.Visible = false;
            // 
            // txbAtendimento
            // 
            this.txbAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            this.txbAtendimento.Location = new System.Drawing.Point(821, 67);
            this.txbAtendimento.Name = "txbAtendimento";
            this.txbAtendimento.ReadOnly = true;
            this.txbAtendimento.Size = new System.Drawing.Size(205, 21);
            this.txbAtendimento.TabIndex = 181;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAprovar.Location = new System.Drawing.Point(757, 110);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(84, 47);
            this.btnAprovar.TabIndex = 180;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            this.btnAprovar.Visible = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.txbStatus.Location = new System.Drawing.Point(782, 32);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(244, 21);
            this.txbStatus.TabIndex = 179;
            // 
            // txbCategoria
            // 
            this.txbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCategoria.Location = new System.Drawing.Point(453, 32);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(248, 21);
            this.txbCategoria.TabIndex = 178;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeletar.Location = new System.Drawing.Point(935, 110);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(82, 47);
            this.btnDeletar.TabIndex = 177;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnRecusar
            // 
            this.btnRecusar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecusar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecusar.Location = new System.Drawing.Point(847, 110);
            this.btnRecusar.Name = "btnRecusar";
            this.btnRecusar.Size = new System.Drawing.Size(82, 47);
            this.btnRecusar.TabIndex = 176;
            this.btnRecusar.Text = "Recusar";
            this.btnRecusar.UseVisualStyleBackColor = true;
            this.btnRecusar.Visible = false;
            this.btnRecusar.Click += new System.EventHandler(this.btnRecusar_Click);
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFeedback.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbFeedback.Location = new System.Drawing.Point(370, 125);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.ReadOnly = true;
            this.rtbFeedback.Size = new System.Drawing.Size(339, 51);
            this.rtbFeedback.TabIndex = 175;
            this.rtbFeedback.Text = "";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFeedback.Location = new System.Drawing.Point(465, 106);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(147, 16);
            this.lblFeedback.TabIndex = 174;
            this.lblFeedback.Text = "Feedback ao Aluno:";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.Location = new System.Drawing.Point(89, 67);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.Size = new System.Drawing.Size(269, 109);
            this.rtbDescricao.TabIndex = 173;
            this.rtbDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescricao.Location = new System.Drawing.Point(3, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 16);
            this.lblDescricao.TabIndex = 172;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAtendimento.Location = new System.Drawing.Point(721, 70);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(98, 16);
            this.lblAtendimento.TabIndex = 168;
            this.lblAtendimento.Text = "Atendimento:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(721, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 167;
            this.lblStatus.Text = "Status:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.Location = new System.Drawing.Point(367, 35);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 16);
            this.lblCategoria.TabIndex = 166;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtDtSolicitacao
            // 
            this.txtDtSolicitacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtDtSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDtSolicitacao.Location = new System.Drawing.Point(496, 67);
            this.txtDtSolicitacao.Name = "txtDtSolicitacao";
            this.txtDtSolicitacao.ReadOnly = true;
            this.txtDtSolicitacao.Size = new System.Drawing.Size(205, 21);
            this.txtDtSolicitacao.TabIndex = 165;
            // 
            // lblDtSolicitacao
            // 
            this.lblDtSolicitacao.AutoSize = true;
            this.lblDtSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDtSolicitacao.Location = new System.Drawing.Point(367, 70);
            this.lblDtSolicitacao.Name = "lblDtSolicitacao";
            this.lblDtSolicitacao.Size = new System.Drawing.Size(127, 16);
            this.lblDtSolicitacao.TabIndex = 164;
            this.lblDtSolicitacao.Text = "Data Solicitação:";
            // 
            // txbCurso
            // 
            this.txbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCurso.Location = new System.Drawing.Point(71, 34);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.ReadOnly = true;
            this.txbCurso.Size = new System.Drawing.Size(280, 21);
            this.txbCurso.TabIndex = 163;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurso.Location = new System.Drawing.Point(3, 34);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 16);
            this.lblCurso.TabIndex = 162;
            this.lblCurso.Text = "Curso:";
            // 
            // txbAluno
            // 
            this.txbAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbAluno.Location = new System.Drawing.Point(424, 3);
            this.txbAluno.Name = "txbAluno";
            this.txbAluno.ReadOnly = true;
            this.txbAluno.Size = new System.Drawing.Size(277, 21);
            this.txbAluno.TabIndex = 161;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAluno.Location = new System.Drawing.Point(367, 6);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(51, 16);
            this.lblAluno.TabIndex = 160;
            this.lblAluno.Text = "Aluno:";
            // 
            // txbIDSolicitacao
            // 
            this.txbIDSolicitacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbIDSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.txbIDSolicitacao.Location = new System.Drawing.Point(118, 3);
            this.txbIDSolicitacao.Name = "txbIDSolicitacao";
            this.txbIDSolicitacao.ReadOnly = true;
            this.txbIDSolicitacao.Size = new System.Drawing.Size(233, 21);
            this.txbIDSolicitacao.TabIndex = 159;
            // 
            // txbContato
            // 
            this.txbContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContato.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContato.Location = new System.Drawing.Point(789, 2);
            this.txbContato.Name = "txbContato";
            this.txbContato.ReadOnly = true;
            this.txbContato.Size = new System.Drawing.Size(237, 21);
            this.txbContato.TabIndex = 158;
            // 
            // lblIDSolicitacao
            // 
            this.lblIDSolicitacao.AutoSize = true;
            this.lblIDSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIDSolicitacao.Location = new System.Drawing.Point(3, 6);
            this.lblIDSolicitacao.Name = "lblIDSolicitacao";
            this.lblIDSolicitacao.Size = new System.Drawing.Size(109, 16);
            this.lblIDSolicitacao.TabIndex = 157;
            this.lblIDSolicitacao.Text = "ID Solicitação:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContato.Location = new System.Drawing.Point(721, 5);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(65, 16);
            this.lblContato.TabIndex = 156;
            this.lblContato.Text = "Contato:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Aluno
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Aluno.DefaultCellStyle = dataGridViewCellStyle1;
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 170;
            // 
            // Categoria
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Descricao
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // DtSolicitacao
            // 
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtSolicitacao.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtSolicitacao.HeaderText = "Data Solicitação";
            this.DtSolicitacao.Name = "DtSolicitacao";
            this.DtSolicitacao.ReadOnly = true;
            this.DtSolicitacao.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Atendimento
            // 
            dataGridViewCellStyle5.NullValue = "** Aguardando Atendimento **";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Atendimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.Atendimento.HeaderText = "Atendimento";
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.ReadOnly = true;
            this.Atendimento.Width = 170;
            // 
            // Resposta
            // 
            this.Resposta.HeaderText = "Resposta";
            this.Resposta.Name = "Resposta";
            this.Resposta.ReadOnly = true;
            this.Resposta.Visible = false;
            // 
            // Contato
            // 
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Visible = false;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Visible = false;
            // 
            // Solicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1053, 635);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.cbMinhasSolicitacoes);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dgvSolicitacoes);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Name = "Solicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.Solicitacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoes)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dgvSolicitacoes;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbMinhasSolicitacoes;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnRecusar;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDtSolicitacao;
        private System.Windows.Forms.Label lblDtSolicitacao;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txbAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txbIDSolicitacao;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label lblIDSolicitacao;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
    }
}