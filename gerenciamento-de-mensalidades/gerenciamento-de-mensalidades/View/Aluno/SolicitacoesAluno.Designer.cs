namespace gerenciamento_de_mensalidades.View.Aluno
{
    partial class SolicitacoesAluno
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgvSolicitacoes = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSolicitação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtendidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnCriarSolicitacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbDataSolicitacao = new System.Windows.Forms.TextBox();
            this.lblDataSolicitacao = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbAtendidoPor = new System.Windows.Forms.TextBox();
            this.lblAtendidoPor = new System.Windows.Forms.Label();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.Location = new System.Drawing.Point(860, 302);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(92, 26);
            this.btnEnviar.TabIndex = 80;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.Location = new System.Drawing.Point(868, 206);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.Size = new System.Drawing.Size(247, 73);
            this.rtbDescricao.TabIndex = 72;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(735, 206);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(83, 16);
            this.lblDesc.TabIndex = 71;
            this.lblDesc.Text = "Descrição:";
            this.lblDesc.Visible = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Solicitação de Bolsa",
            "Solicitação de Plano de Pagamento Extendido"});
            this.cbCategoria.Location = new System.Drawing.Point(868, 173);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(247, 21);
            this.cbCategoria.TabIndex = 69;
            this.cbCategoria.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.Location = new System.Drawing.Point(735, 174);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 16);
            this.lblCategoria.TabIndex = 68;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Visible = false;
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
            this.Categoria,
            this.Descrição,
            this.DataSolicitação,
            this.Status,
            this.AtendidoPor,
            this.Resposta});
            this.dgvSolicitacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvSolicitacoes.Location = new System.Drawing.Point(12, 136);
            this.dgvSolicitacoes.Name = "dgvSolicitacoes";
            this.dgvSolicitacoes.ReadOnly = true;
            this.dgvSolicitacoes.Size = new System.Drawing.Size(707, 334);
            this.dgvSolicitacoes.TabIndex = 67;
            this.dgvSolicitacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitacoes_CellClick);
            // 
            // Categoria
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Descrição
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Descrição.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 130;
            // 
            // DataSolicitação
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataSolicitação.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataSolicitação.HeaderText = "Data Solicitação";
            this.DataSolicitação.Name = "DataSolicitação";
            this.DataSolicitação.ReadOnly = true;
            this.DataSolicitação.Width = 125;
            // 
            // Status
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // AtendidoPor
            // 
            dataGridViewCellStyle5.NullValue = "*Não Atendido*";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AtendidoPor.DefaultCellStyle = dataGridViewCellStyle5;
            this.AtendidoPor.HeaderText = "Atendido Por";
            this.AtendidoPor.Name = "AtendidoPor";
            this.AtendidoPor.ReadOnly = true;
            // 
            // Resposta
            // 
            dataGridViewCellStyle6.NullValue = "*Sem Resposta*";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Resposta.DefaultCellStyle = dataGridViewCellStyle6;
            this.Resposta.HeaderText = "Resposta";
            this.Resposta.Name = "Resposta";
            this.Resposta.ReadOnly = true;
            this.Resposta.Width = 130;
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
            this.cbStatus.Location = new System.Drawing.Point(551, 102);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 21);
            this.cbStatus.TabIndex = 66;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(12, 92);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 26);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(58, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minhas solicitações";
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
            // btnCriarSolicitacao
            // 
            this.btnCriarSolicitacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarSolicitacao.Location = new System.Drawing.Point(868, 97);
            this.btnCriarSolicitacao.Name = "btnCriarSolicitacao";
            this.btnCriarSolicitacao.Size = new System.Drawing.Size(146, 26);
            this.btnCriarSolicitacao.TabIndex = 79;
            this.btnCriarSolicitacao.Text = "Criar Solicitação";
            this.btnCriarSolicitacao.UseVisualStyleBackColor = true;
            this.btnCriarSolicitacao.Click += new System.EventHandler(this.btnCriarSolicitacao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 60);
            this.panel1.TabIndex = 63;
            // 
            // txbCategoria
            // 
            this.txbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCategoria.Location = new System.Drawing.Point(868, 173);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(247, 21);
            this.txbCategoria.TabIndex = 81;
            this.txbCategoria.Visible = false;
            // 
            // txbDataSolicitacao
            // 
            this.txbDataSolicitacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbDataSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.txbDataSolicitacao.Location = new System.Drawing.Point(868, 295);
            this.txbDataSolicitacao.Name = "txbDataSolicitacao";
            this.txbDataSolicitacao.ReadOnly = true;
            this.txbDataSolicitacao.Size = new System.Drawing.Size(247, 21);
            this.txbDataSolicitacao.TabIndex = 83;
            this.txbDataSolicitacao.Visible = false;
            // 
            // lblDataSolicitacao
            // 
            this.lblDataSolicitacao.AutoSize = true;
            this.lblDataSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDataSolicitacao.Location = new System.Drawing.Point(735, 296);
            this.lblDataSolicitacao.Name = "lblDataSolicitacao";
            this.lblDataSolicitacao.Size = new System.Drawing.Size(127, 16);
            this.lblDataSolicitacao.TabIndex = 82;
            this.lblDataSolicitacao.Text = "Data Solicitação:";
            this.lblDataSolicitacao.Visible = false;
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.txbStatus.Location = new System.Drawing.Point(868, 334);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(247, 21);
            this.txbStatus.TabIndex = 85;
            this.txbStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(735, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 84;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // txbAtendidoPor
            // 
            this.txbAtendidoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbAtendidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAtendidoPor.ForeColor = System.Drawing.SystemColors.Control;
            this.txbAtendidoPor.Location = new System.Drawing.Point(868, 372);
            this.txbAtendidoPor.Name = "txbAtendidoPor";
            this.txbAtendidoPor.ReadOnly = true;
            this.txbAtendidoPor.Size = new System.Drawing.Size(247, 21);
            this.txbAtendidoPor.TabIndex = 87;
            this.txbAtendidoPor.Visible = false;
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.AutoSize = true;
            this.lblAtendidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidoPor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAtendidoPor.Location = new System.Drawing.Point(735, 373);
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Size = new System.Drawing.Size(102, 16);
            this.lblAtendidoPor.TabIndex = 86;
            this.lblAtendidoPor.Text = "Atendido Por:";
            this.lblAtendidoPor.Visible = false;
            // 
            // rtbResposta
            // 
            this.rtbResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResposta.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbResposta.Location = new System.Drawing.Point(868, 409);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.ReadOnly = true;
            this.rtbResposta.Size = new System.Drawing.Size(247, 61);
            this.rtbResposta.TabIndex = 89;
            this.rtbResposta.Text = "";
            this.rtbResposta.Visible = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResposta.Location = new System.Drawing.Point(735, 409);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(79, 16);
            this.lblResposta.TabIndex = 88;
            this.lblResposta.Text = "Resposta:";
            this.lblResposta.Visible = false;
            // 
            // SolicitacoesAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1127, 496);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txbAtendidoPor);
            this.Controls.Add(this.lblAtendidoPor);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbDataSolicitacao);
            this.Controls.Add(this.lblDataSolicitacao);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dgvSolicitacoes);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCriarSolicitacao);
            this.Controls.Add(this.panel1);
            this.Name = "SolicitacoesAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.SolicitacoesAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgvSolicitacoes;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnCriarSolicitacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbDataSolicitacao;
        private System.Windows.Forms.Label lblDataSolicitacao;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbAtendidoPor;
        private System.Windows.Forms.Label lblAtendidoPor;
        private System.Windows.Forms.RichTextBox rtbResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSolicitação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtendidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
    }
}