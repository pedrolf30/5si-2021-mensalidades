namespace gerenciamento_de_mensalidades.View.Administrador
{
    partial class CadastroUsuarios
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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAluno = new System.Windows.Forms.Panel();
            this.txbNascAluno = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txbCPFAluno = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbRAAluno = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txbNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCursoAluno = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txbEmailAluno = new System.Windows.Forms.TextBox();
            this.txbContatoAluno = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNascFuncionario = new System.Windows.Forms.TextBox();
            this.txbEmailFuncionario = new System.Windows.Forms.TextBox();
            this.txbContatoFuncionario = new System.Windows.Forms.TextBox();
            this.txbCPFFuncionario = new System.Windows.Forms.TextBox();
            this.txbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtivarFuncionario = new System.Windows.Forms.Button();
            this.btnAtivarAluno = new System.Windows.Forms.Button();
            this.panelCF = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbEmailCF = new System.Windows.Forms.TextBox();
            this.txbContatoCF = new System.Windows.Forms.TextBox();
            this.txbCPFCF = new System.Windows.Forms.TextBox();
            this.txbNomeCF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbSenha1CF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbSenha2CF = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpNascimentoCF = new System.Windows.Forms.DateTimePicker();
            this.btnCF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAluno.SuspendLayout();
            this.panelFuncionario.SuspendLayout();
            this.panelCF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(611, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(58, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Usuários";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(570, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome usuário conectado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Email,
            this.Administrador,
            this.Ativo});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.Location = new System.Drawing.Point(26, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 336);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(26, 78);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 26);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.txbPesquisa.Location = new System.Drawing.Point(216, 83);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.ReadOnly = true;
            this.txbPesquisa.Size = new System.Drawing.Size(178, 21);
            this.txbPesquisa.TabIndex = 119;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            this.Administrador.Width = 75;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 50;
            // 
            // panelAluno
            // 
            this.panelAluno.Controls.Add(this.btnAtivarAluno);
            this.panelAluno.Controls.Add(this.label1);
            this.panelAluno.Controls.Add(this.txbCursoAluno);
            this.panelAluno.Controls.Add(this.lblCurso);
            this.panelAluno.Controls.Add(this.txbEmailAluno);
            this.panelAluno.Controls.Add(this.txbContatoAluno);
            this.panelAluno.Controls.Add(this.lblEmail);
            this.panelAluno.Controls.Add(this.lblContato);
            this.panelAluno.Controls.Add(this.txbNascAluno);
            this.panelAluno.Controls.Add(this.lblNascimento);
            this.panelAluno.Controls.Add(this.txbCPFAluno);
            this.panelAluno.Controls.Add(this.lblCPF);
            this.panelAluno.Controls.Add(this.txbRAAluno);
            this.panelAluno.Controls.Add(this.lblRA);
            this.panelAluno.Controls.Add(this.txbNomeAluno);
            this.panelAluno.Controls.Add(this.lblNome);
            this.panelAluno.Location = new System.Drawing.Point(438, 117);
            this.panelAluno.Name = "panelAluno";
            this.panelAluno.Size = new System.Drawing.Size(341, 336);
            this.panelAluno.TabIndex = 120;
            this.panelAluno.Visible = false;
            // 
            // txbNascAluno
            // 
            this.txbNascAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNascAluno.Enabled = false;
            this.txbNascAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNascAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNascAluno.Location = new System.Drawing.Point(103, 139);
            this.txbNascAluno.Name = "txbNascAluno";
            this.txbNascAluno.ReadOnly = true;
            this.txbNascAluno.Size = new System.Drawing.Size(228, 21);
            this.txbNascAluno.TabIndex = 121;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNascimento.Location = new System.Drawing.Point(3, 139);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(94, 16);
            this.lblNascimento.TabIndex = 119;
            this.lblNascimento.Text = "Nascimento:";
            this.lblNascimento.Visible = false;
            // 
            // txbCPFAluno
            // 
            this.txbCPFAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCPFAluno.Enabled = false;
            this.txbCPFAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPFAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCPFAluno.Location = new System.Drawing.Point(163, 106);
            this.txbCPFAluno.Name = "txbCPFAluno";
            this.txbCPFAluno.ReadOnly = true;
            this.txbCPFAluno.Size = new System.Drawing.Size(168, 21);
            this.txbCPFAluno.TabIndex = 118;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPF.Location = new System.Drawing.Point(119, 109);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 16);
            this.lblCPF.TabIndex = 117;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Visible = false;
            // 
            // txbRAAluno
            // 
            this.txbRAAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbRAAluno.Enabled = false;
            this.txbRAAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRAAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbRAAluno.Location = new System.Drawing.Point(42, 106);
            this.txbRAAluno.Name = "txbRAAluno";
            this.txbRAAluno.ReadOnly = true;
            this.txbRAAluno.Size = new System.Drawing.Size(71, 21);
            this.txbRAAluno.TabIndex = 116;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRA.Location = new System.Drawing.Point(3, 109);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(33, 16);
            this.lblRA.TabIndex = 115;
            this.lblRA.Text = "RA:";
            this.lblRA.Visible = false;
            // 
            // txbNomeAluno
            // 
            this.txbNomeAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNomeAluno.Enabled = false;
            this.txbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNomeAluno.Location = new System.Drawing.Point(62, 77);
            this.txbNomeAluno.Name = "txbNomeAluno";
            this.txbNomeAluno.ReadOnly = true;
            this.txbNomeAluno.Size = new System.Drawing.Size(269, 21);
            this.txbNomeAluno.TabIndex = 114;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(3, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 113;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            // 
            // txbCursoAluno
            // 
            this.txbCursoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCursoAluno.Enabled = false;
            this.txbCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCursoAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCursoAluno.Location = new System.Drawing.Point(60, 234);
            this.txbCursoAluno.Name = "txbCursoAluno";
            this.txbCursoAluno.ReadOnly = true;
            this.txbCursoAluno.Size = new System.Drawing.Size(271, 21);
            this.txbCursoAluno.TabIndex = 127;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurso.Location = new System.Drawing.Point(3, 237);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 16);
            this.lblCurso.TabIndex = 126;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Visible = false;
            // 
            // txbEmailAluno
            // 
            this.txbEmailAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmailAluno.Enabled = false;
            this.txbEmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmailAluno.Location = new System.Drawing.Point(60, 200);
            this.txbEmailAluno.Name = "txbEmailAluno";
            this.txbEmailAluno.ReadOnly = true;
            this.txbEmailAluno.Size = new System.Drawing.Size(271, 21);
            this.txbEmailAluno.TabIndex = 125;
            // 
            // txbContatoAluno
            // 
            this.txbContatoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContatoAluno.Enabled = false;
            this.txbContatoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContatoAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContatoAluno.Location = new System.Drawing.Point(74, 170);
            this.txbContatoAluno.Name = "txbContatoAluno";
            this.txbContatoAluno.ReadOnly = true;
            this.txbContatoAluno.Size = new System.Drawing.Size(257, 21);
            this.txbContatoAluno.TabIndex = 124;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(3, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 123;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Visible = false;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContato.Location = new System.Drawing.Point(3, 173);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(65, 16);
            this.lblContato.TabIndex = 122;
            this.lblContato.Text = "Contato:";
            this.lblContato.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(132, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "Aluno";
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.Controls.Add(this.btnAtivarFuncionario);
            this.panelFuncionario.Controls.Add(this.txbNascFuncionario);
            this.panelFuncionario.Controls.Add(this.txbEmailFuncionario);
            this.panelFuncionario.Controls.Add(this.txbContatoFuncionario);
            this.panelFuncionario.Controls.Add(this.txbCPFFuncionario);
            this.panelFuncionario.Controls.Add(this.txbNomeFuncionario);
            this.panelFuncionario.Controls.Add(this.label3);
            this.panelFuncionario.Controls.Add(this.label4);
            this.panelFuncionario.Controls.Add(this.label9);
            this.panelFuncionario.Controls.Add(this.label5);
            this.panelFuncionario.Controls.Add(this.label8);
            this.panelFuncionario.Controls.Add(this.label2);
            this.panelFuncionario.Location = new System.Drawing.Point(438, 117);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(341, 336);
            this.panelFuncionario.TabIndex = 121;
            this.panelFuncionario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(132, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 121;
            this.label2.Text = "Funcionário";
            // 
            // txbNascFuncionario
            // 
            this.txbNascFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNascFuncionario.Enabled = false;
            this.txbNascFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNascFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNascFuncionario.Location = new System.Drawing.Point(105, 143);
            this.txbNascFuncionario.Name = "txbNascFuncionario";
            this.txbNascFuncionario.ReadOnly = true;
            this.txbNascFuncionario.Size = new System.Drawing.Size(228, 21);
            this.txbNascFuncionario.TabIndex = 132;
            // 
            // txbEmailFuncionario
            // 
            this.txbEmailFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmailFuncionario.Enabled = false;
            this.txbEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmailFuncionario.Location = new System.Drawing.Point(64, 198);
            this.txbEmailFuncionario.Name = "txbEmailFuncionario";
            this.txbEmailFuncionario.ReadOnly = true;
            this.txbEmailFuncionario.Size = new System.Drawing.Size(269, 21);
            this.txbEmailFuncionario.TabIndex = 130;
            // 
            // txbContatoFuncionario
            // 
            this.txbContatoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContatoFuncionario.Enabled = false;
            this.txbContatoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContatoFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContatoFuncionario.Location = new System.Drawing.Point(76, 172);
            this.txbContatoFuncionario.Name = "txbContatoFuncionario";
            this.txbContatoFuncionario.ReadOnly = true;
            this.txbContatoFuncionario.Size = new System.Drawing.Size(257, 21);
            this.txbContatoFuncionario.TabIndex = 129;
            // 
            // txbCPFFuncionario
            // 
            this.txbCPFFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCPFFuncionario.Enabled = false;
            this.txbCPFFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPFFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCPFFuncionario.Location = new System.Drawing.Point(49, 116);
            this.txbCPFFuncionario.Name = "txbCPFFuncionario";
            this.txbCPFFuncionario.ReadOnly = true;
            this.txbCPFFuncionario.Size = new System.Drawing.Size(284, 21);
            this.txbCPFFuncionario.TabIndex = 128;
            // 
            // txbNomeFuncionario
            // 
            this.txbNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNomeFuncionario.Enabled = false;
            this.txbNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNomeFuncionario.Location = new System.Drawing.Point(64, 88);
            this.txbNomeFuncionario.Name = "txbNomeFuncionario";
            this.txbNomeFuncionario.ReadOnly = true;
            this.txbNomeFuncionario.Size = new System.Drawing.Size(269, 21);
            this.txbNomeFuncionario.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 122;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(5, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 125;
            this.label9.Text = "Contato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(5, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(5, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "CPF:";
            // 
            // btnAtivarFuncionario
            // 
            this.btnAtivarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtivarFuncionario.Location = new System.Drawing.Point(92, 256);
            this.btnAtivarFuncionario.Name = "btnAtivarFuncionario";
            this.btnAtivarFuncionario.Size = new System.Drawing.Size(193, 26);
            this.btnAtivarFuncionario.TabIndex = 122;
            this.btnAtivarFuncionario.Text = "Desativar funcionário";
            this.btnAtivarFuncionario.UseVisualStyleBackColor = true;
            this.btnAtivarFuncionario.Click += new System.EventHandler(this.btnAtivarFuncionario_Click);
            // 
            // btnAtivarAluno
            // 
            this.btnAtivarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtivarAluno.Location = new System.Drawing.Point(122, 272);
            this.btnAtivarAluno.Name = "btnAtivarAluno";
            this.btnAtivarAluno.Size = new System.Drawing.Size(129, 26);
            this.btnAtivarAluno.TabIndex = 133;
            this.btnAtivarAluno.Text = "Desativar aluno";
            this.btnAtivarAluno.UseVisualStyleBackColor = true;
            // 
            // panelCF
            // 
            this.panelCF.Controls.Add(this.dtpNascimentoCF);
            this.panelCF.Controls.Add(this.txbSenha2CF);
            this.panelCF.Controls.Add(this.label18);
            this.panelCF.Controls.Add(this.txbSenha1CF);
            this.panelCF.Controls.Add(this.label17);
            this.panelCF.Controls.Add(this.btnSalvar);
            this.panelCF.Controls.Add(this.txbEmailCF);
            this.panelCF.Controls.Add(this.txbContatoCF);
            this.panelCF.Controls.Add(this.txbCPFCF);
            this.panelCF.Controls.Add(this.txbNomeCF);
            this.panelCF.Controls.Add(this.label11);
            this.panelCF.Controls.Add(this.label12);
            this.panelCF.Controls.Add(this.label13);
            this.panelCF.Controls.Add(this.label14);
            this.panelCF.Controls.Add(this.label15);
            this.panelCF.Controls.Add(this.label16);
            this.panelCF.Location = new System.Drawing.Point(438, 78);
            this.panelCF.Name = "panelCF";
            this.panelCF.Size = new System.Drawing.Size(341, 375);
            this.panelCF.TabIndex = 133;
            this.panelCF.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(117, 346);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 26);
            this.btnSalvar.TabIndex = 122;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbEmailCF
            // 
            this.txbEmailCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmailCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailCF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmailCF.Location = new System.Drawing.Point(45, 70);
            this.txbEmailCF.Name = "txbEmailCF";
            this.txbEmailCF.Size = new System.Drawing.Size(269, 21);
            this.txbEmailCF.TabIndex = 130;
            // 
            // txbContatoCF
            // 
            this.txbContatoCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbContatoCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContatoCF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbContatoCF.Location = new System.Drawing.Point(76, 315);
            this.txbContatoCF.Name = "txbContatoCF";
            this.txbContatoCF.Size = new System.Drawing.Size(257, 21);
            this.txbContatoCF.TabIndex = 129;
            // 
            // txbCPFCF
            // 
            this.txbCPFCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCPFCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPFCF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCPFCF.Location = new System.Drawing.Point(49, 259);
            this.txbCPFCF.Name = "txbCPFCF";
            this.txbCPFCF.Size = new System.Drawing.Size(284, 21);
            this.txbCPFCF.TabIndex = 128;
            // 
            // txbNomeCF
            // 
            this.txbNomeCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbNomeCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbNomeCF.Location = new System.Drawing.Point(64, 231);
            this.txbNomeCF.Name = "txbNomeCF";
            this.txbNomeCF.Size = new System.Drawing.Size(269, 21);
            this.txbNomeCF.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(5, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 122;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(140, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 126;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(5, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 125;
            this.label13.Text = "Contato:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(5, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 123;
            this.label14.Text = "Nascimento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(5, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 16);
            this.label15.TabIndex = 124;
            this.label15.Text = "CPF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(91, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 16);
            this.label16.TabIndex = 121;
            this.label16.Text = "Criar usuário funcionário";
            // 
            // txbSenha1CF
            // 
            this.txbSenha1CF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSenha1CF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha1CF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbSenha1CF.Location = new System.Drawing.Point(45, 111);
            this.txbSenha1CF.Name = "txbSenha1CF";
            this.txbSenha1CF.Size = new System.Drawing.Size(269, 21);
            this.txbSenha1CF.TabIndex = 134;
            this.txbSenha1CF.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(135, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 133;
            this.label17.Text = "Senha:";
            // 
            // txbSenha2CF
            // 
            this.txbSenha2CF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSenha2CF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha2CF.ForeColor = System.Drawing.SystemColors.Control;
            this.txbSenha2CF.Location = new System.Drawing.Point(43, 152);
            this.txbSenha2CF.Name = "txbSenha2CF";
            this.txbSenha2CF.Size = new System.Drawing.Size(269, 21);
            this.txbSenha2CF.TabIndex = 136;
            this.txbSenha2CF.UseSystemPasswordChar = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(103, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 16);
            this.label18.TabIndex = 135;
            this.label18.Text = "Confirmar senha:";
            // 
            // dtpNascimentoCF
            // 
            this.dtpNascimentoCF.Location = new System.Drawing.Point(105, 287);
            this.dtpNascimentoCF.Name = "dtpNascimentoCF";
            this.dtpNascimentoCF.Size = new System.Drawing.Size(227, 20);
            this.dtpNascimentoCF.TabIndex = 137;
            // 
            // btnCF
            // 
            this.btnCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCF.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCF.Location = new System.Drawing.Point(530, 82);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(175, 24);
            this.btnCF.TabIndex = 138;
            this.btnCF.Text = "Criar novo funcionário";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.panelCF);
            this.Controls.Add(this.panelAluno);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroUsuarios";
            this.Text = "Usuários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAluno.ResumeLayout(false);
            this.panelAluno.PerformLayout();
            this.panelFuncionario.ResumeLayout(false);
            this.panelFuncionario.PerformLayout();
            this.panelCF.ResumeLayout(false);
            this.panelCF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Panel panelAluno;
        private System.Windows.Forms.TextBox txbNascAluno;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txbCPFAluno;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbRAAluno;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txbNomeAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCursoAluno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txbEmailAluno;
        private System.Windows.Forms.TextBox txbContatoAluno;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtivarFuncionario;
        private System.Windows.Forms.TextBox txbNascFuncionario;
        private System.Windows.Forms.TextBox txbEmailFuncionario;
        private System.Windows.Forms.TextBox txbContatoFuncionario;
        private System.Windows.Forms.TextBox txbCPFFuncionario;
        private System.Windows.Forms.TextBox txbNomeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtivarAluno;
        private System.Windows.Forms.Panel panelCF;
        private System.Windows.Forms.DateTimePicker dtpNascimentoCF;
        private System.Windows.Forms.TextBox txbSenha2CF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbSenha1CF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbEmailCF;
        private System.Windows.Forms.TextBox txbContatoCF;
        private System.Windows.Forms.TextBox txbCPFCF;
        private System.Windows.Forms.TextBox txbNomeCF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCF;
    }
}