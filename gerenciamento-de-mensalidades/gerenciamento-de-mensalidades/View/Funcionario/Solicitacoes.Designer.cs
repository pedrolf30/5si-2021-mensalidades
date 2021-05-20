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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbAtendimento = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDtSolicitacao = new System.Windows.Forms.TextBox();
            this.lblDtSolicitacao = new System.Windows.Forms.Label();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txbAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(767, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome usuário conectado";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.txbPesquisa.Location = new System.Drawing.Point(329, 83);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.ReadOnly = true;
            this.txbPesquisa.Size = new System.Drawing.Size(352, 21);
            this.txbPesquisa.TabIndex = 122;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aluno,
            this.Categoria,
            this.Descricao,
            this.DtSolicitacao,
            this.Status,
            this.Atendimento});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 318);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // DtSolicitacao
            // 
            this.DtSolicitacao.HeaderText = "Data Solicitação";
            this.DtSolicitacao.Name = "DtSolicitacao";
            this.DtSolicitacao.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Atendimento
            // 
            this.Atendimento.HeaderText = "Atendimento";
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.ReadOnly = true;
            this.Atendimento.Width = 195;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(736, 83);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(142, 21);
            this.cbCurso.TabIndex = 120;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(896, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 123;
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.btnDeletar);
            this.panelDados.Controls.Add(this.btnSalvar);
            this.panelDados.Controls.Add(this.rtbFeedback);
            this.panelDados.Controls.Add(this.lblFeedback);
            this.panelDados.Controls.Add(this.rtbDescricao);
            this.panelDados.Controls.Add(this.lblDescricao);
            this.panelDados.Controls.Add(this.cbAtendimento);
            this.panelDados.Controls.Add(this.cbStatus);
            this.panelDados.Controls.Add(this.cbCategoria);
            this.panelDados.Controls.Add(this.lblAtendimento);
            this.panelDados.Controls.Add(this.lblStatus);
            this.panelDados.Controls.Add(this.lblCategoria);
            this.panelDados.Controls.Add(this.txtDtSolicitacao);
            this.panelDados.Controls.Add(this.lblDtSolicitacao);
            this.panelDados.Controls.Add(this.txbCurso);
            this.panelDados.Controls.Add(this.lblCurso);
            this.panelDados.Controls.Add(this.txbAluno);
            this.panelDados.Controls.Add(this.lblAluno);
            this.panelDados.Controls.Add(this.txbEmail);
            this.panelDados.Controls.Add(this.txbContato);
            this.panelDados.Controls.Add(this.lblEmail);
            this.panelDados.Controls.Add(this.lblContato);
            this.panelDados.Location = new System.Drawing.Point(12, 441);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1029, 182);
            this.panelDados.TabIndex = 124;
            this.panelDados.Visible = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeletar.Location = new System.Drawing.Point(936, 110);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(93, 47);
            this.btnDeletar.TabIndex = 177;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(825, 110);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 47);
            this.btnSalvar.TabIndex = 176;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFeedback.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbFeedback.Location = new System.Drawing.Point(370, 125);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(339, 57);
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
            this.rtbDescricao.Location = new System.Drawing.Point(82, 68);
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
            this.lblDescricao.Location = new System.Drawing.Point(0, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 16);
            this.lblDescricao.TabIndex = 172;
            this.lblDescricao.Text = "Descrição:";
            // 
            // cbAtendimento
            // 
            this.cbAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAtendimento.ForeColor = System.Drawing.SystemColors.Control;
            this.cbAtendimento.FormattingEnabled = true;
            this.cbAtendimento.Location = new System.Drawing.Point(825, 65);
            this.cbAtendimento.Name = "cbAtendimento";
            this.cbAtendimento.Size = new System.Drawing.Size(204, 21);
            this.cbAtendimento.TabIndex = 171;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(792, 33);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(237, 21);
            this.cbStatus.TabIndex = 170;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(453, 33);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(248, 21);
            this.cbCategoria.TabIndex = 169;
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
            this.txtDtSolicitacao.Size = new System.Drawing.Size(213, 21);
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
            this.txbCurso.Location = new System.Drawing.Point(71, 30);
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
            this.lblCurso.Location = new System.Drawing.Point(0, 33);
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
            this.txbAluno.Location = new System.Drawing.Point(71, 2);
            this.txbAluno.Name = "txbAluno";
            this.txbAluno.ReadOnly = true;
            this.txbAluno.Size = new System.Drawing.Size(280, 21);
            this.txbAluno.TabIndex = 161;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAluno.Location = new System.Drawing.Point(0, 5);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(51, 16);
            this.lblAluno.TabIndex = 160;
            this.lblAluno.Text = "Aluno:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmail.Location = new System.Drawing.Point(430, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(271, 21);
            this.txbEmail.TabIndex = 159;
            // 
            // txbContato
            // 
            this.txbContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContato.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContato.Location = new System.Drawing.Point(792, 0);
            this.txbContato.Name = "txbContato";
            this.txbContato.ReadOnly = true;
            this.txbContato.Size = new System.Drawing.Size(237, 21);
            this.txbContato.TabIndex = 158;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(367, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 157;
            this.lblEmail.Text = "Email:";
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
            // Solicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1053, 635);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Name = "Solicitacoes";
            this.Text = "Solicitações";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atendimento;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbAtendimento;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDtSolicitacao;
        private System.Windows.Forms.Label lblDtSolicitacao;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txbAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
    }
}