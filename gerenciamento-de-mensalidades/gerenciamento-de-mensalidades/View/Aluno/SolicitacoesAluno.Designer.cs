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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txbAtendidoPor = new System.Windows.Forms.TextBox();
            this.lblAtendidoPor = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbDtSolicitacao = new System.Windows.Forms.TextBox();
            this.lblDtSolicitacao = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtendidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSolicitação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCriarSolicitacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.Location = new System.Drawing.Point(756, 347);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(92, 26);
            this.btnEnviar.TabIndex = 80;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbAtendidoPor
            // 
            this.txbAtendidoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbAtendidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAtendidoPor.ForeColor = System.Drawing.SystemColors.Control;
            this.txbAtendidoPor.Location = new System.Drawing.Point(825, 400);
            this.txbAtendidoPor.Name = "txbAtendidoPor";
            this.txbAtendidoPor.ReadOnly = true;
            this.txbAtendidoPor.Size = new System.Drawing.Size(186, 21);
            this.txbAtendidoPor.TabIndex = 78;
            this.txbAtendidoPor.Visible = false;
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.AutoSize = true;
            this.lblAtendidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidoPor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAtendidoPor.Location = new System.Drawing.Point(687, 401);
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Size = new System.Drawing.Size(102, 16);
            this.lblAtendidoPor.TabIndex = 77;
            this.lblAtendidoPor.Text = "Atendido Por:";
            this.lblAtendidoPor.Visible = false;
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.txbStatus.Location = new System.Drawing.Point(825, 362);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(186, 21);
            this.txbStatus.TabIndex = 76;
            this.txbStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(685, 363);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 75;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // txbDtSolicitacao
            // 
            this.txbDtSolicitacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbDtSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDtSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.txbDtSolicitacao.Location = new System.Drawing.Point(825, 324);
            this.txbDtSolicitacao.Name = "txbDtSolicitacao";
            this.txbDtSolicitacao.ReadOnly = true;
            this.txbDtSolicitacao.Size = new System.Drawing.Size(186, 21);
            this.txbDtSolicitacao.TabIndex = 74;
            this.txbDtSolicitacao.Visible = false;
            // 
            // lblDtSolicitacao
            // 
            this.lblDtSolicitacao.AutoSize = true;
            this.lblDtSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDtSolicitacao.Location = new System.Drawing.Point(685, 328);
            this.lblDtSolicitacao.Name = "lblDtSolicitacao";
            this.lblDtSolicitacao.Size = new System.Drawing.Size(131, 16);
            this.lblDtSolicitacao.TabIndex = 73;
            this.lblDtSolicitacao.Text = "Data Solicitação: ";
            this.lblDtSolicitacao.Visible = false;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbDescricao.Location = new System.Drawing.Point(825, 205);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.Size = new System.Drawing.Size(186, 109);
            this.rtbDescricao.TabIndex = 72;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(685, 206);
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
            this.cbCategoria.Location = new System.Drawing.Point(825, 173);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(186, 21);
            this.cbCategoria.TabIndex = 69;
            this.cbCategoria.Visible = false;
            // 
            // txbCategoria
            // 
            this.txbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCategoria.Location = new System.Drawing.Point(825, 174);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(186, 21);
            this.txbCategoria.TabIndex = 70;
            this.txbCategoria.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.Location = new System.Drawing.Point(685, 174);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 16);
            this.lblCategoria.TabIndex = 68;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Visible = false;
            // 
            // Resposta
            // 
            this.Resposta.HeaderText = "Resposta";
            this.Resposta.Name = "Resposta";
            this.Resposta.ReadOnly = true;
            // 
            // AtendidoPor
            // 
            this.AtendidoPor.HeaderText = "Atendido Por";
            this.AtendidoPor.Name = "AtendidoPor";
            this.AtendidoPor.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DataSolicitação
            // 
            this.DataSolicitação.HeaderText = "Data Solicitação";
            this.DataSolicitação.Name = "DataSolicitação";
            this.DataSolicitação.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Descrição,
            this.DataSolicitação,
            this.Status,
            this.AtendidoPor,
            this.Resposta});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 318);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(510, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 66;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(351, 102);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(142, 21);
            this.cbCurso.TabIndex = 65;
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
            // btnCriarSolicitacao
            // 
            this.btnCriarSolicitacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarSolicitacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarSolicitacao.Location = new System.Drawing.Point(756, 97);
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 60);
            this.panel1.TabIndex = 63;
            // 
            // SolicitacoesAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1025, 488);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbAtendidoPor);
            this.Controls.Add(this.lblAtendidoPor);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbDtSolicitacao);
            this.Controls.Add(this.lblDtSolicitacao);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCriarSolicitacao);
            this.Controls.Add(this.panel1);
            this.Name = "SolicitacoesAluno";
            this.Text = "SolicitacoesAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txbAtendidoPor;
        private System.Windows.Forms.Label lblAtendidoPor;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbDtSolicitacao;
        private System.Windows.Forms.Label lblDtSolicitacao;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtendidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSolicitação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCriarSolicitacao;
        private System.Windows.Forms.Panel panel1;
    }
}