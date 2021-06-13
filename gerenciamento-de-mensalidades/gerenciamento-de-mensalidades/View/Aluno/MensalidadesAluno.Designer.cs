namespace gerenciamento_de_mensalidades.View.Aluno
{
    partial class MensalidadesAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.dgvMensalidadesAluno = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mês = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatusPagamento = new System.Windows.Forms.ComboBox();
            this.cbStatusData = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidadesAluno)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(58, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minhas Mensalidades";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeUsuario.Location = new System.Drawing.Point(561, 21);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(181, 16);
            this.lblNomeUsuario.TabIndex = 3;
            this.lblNomeUsuario.Text = "Nome usuário conectado";
            // 
            // dgvMensalidadesAluno
            // 
            this.dgvMensalidadesAluno.AllowUserToAddRows = false;
            this.dgvMensalidadesAluno.AllowUserToDeleteRows = false;
            this.dgvMensalidadesAluno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvMensalidadesAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMensalidadesAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensalidadesAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Mês,
            this.DataVencimento,
            this.Pago,
            this.DataPagamento});
            this.dgvMensalidadesAluno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvMensalidadesAluno.Location = new System.Drawing.Point(141, 126);
            this.dgvMensalidadesAluno.Name = "dgvMensalidadesAluno";
            this.dgvMensalidadesAluno.ReadOnly = true;
            this.dgvMensalidadesAluno.Size = new System.Drawing.Size(562, 318);
            this.dgvMensalidadesAluno.TabIndex = 46;
            // 
            // Valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 110;
            // 
            // Mês
            // 
            this.Mês.HeaderText = "Mês";
            this.Mês.Name = "Mês";
            this.Mês.ReadOnly = true;
            this.Mês.Width = 115;
            // 
            // DataVencimento
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataVencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataVencimento.HeaderText = "Data Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 75;
            // 
            // DataPagamento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "*Não Pago*";
            this.DataPagamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataPagamento.HeaderText = "Data Pagamento";
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
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
            this.cbStatusPagamento.Location = new System.Drawing.Point(539, 91);
            this.cbStatusPagamento.Name = "cbStatusPagamento";
            this.cbStatusPagamento.Size = new System.Drawing.Size(145, 21);
            this.cbStatusPagamento.TabIndex = 45;
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
            this.cbStatusData.Location = new System.Drawing.Point(380, 92);
            this.cbStatusData.Name = "cbStatusData";
            this.cbStatusData.Size = new System.Drawing.Size(142, 21);
            this.cbStatusData.TabIndex = 44;
            this.cbStatusData.SelectedIndexChanged += new System.EventHandler(this.cbStatusData_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(141, 87);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 26);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // MensalidadesAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMensalidadesAluno);
            this.Controls.Add(this.cbStatusPagamento);
            this.Controls.Add(this.cbStatusData);
            this.Controls.Add(this.btnVoltar);
            this.Name = "MensalidadesAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensalidades Aluno";
            this.Load += new System.EventHandler(this.MensalidadesAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidadesAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.DataGridView dgvMensalidadesAluno;
        private System.Windows.Forms.ComboBox cbStatusPagamento;
        private System.Windows.Forms.ComboBox cbStatusData;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mês;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
    }
}