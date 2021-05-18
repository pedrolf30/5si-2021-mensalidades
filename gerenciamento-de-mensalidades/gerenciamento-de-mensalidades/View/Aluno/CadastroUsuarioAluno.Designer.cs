namespace gerenciamento_de_mensalidades.View.Aluno
{
    partial class CadastroUsuarioAluno
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbSenha2 = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbSenha1 = new System.Windows.Forms.TextBox();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbSenha1);
            this.panel1.Controls.Add(this.lblSenha1);
            this.panel1.Controls.Add(this.btnContinuar);
            this.panel1.Controls.Add(this.txbSenha2);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.lblSenha2);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(35, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 273);
            this.panel1.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuar.Location = new System.Drawing.Point(197, 214);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(125, 30);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbSenha2
            // 
            this.txbSenha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha2.ForeColor = System.Drawing.SystemColors.Control;
            this.txbSenha2.Location = new System.Drawing.Point(270, 153);
            this.txbSenha2.Name = "txbSenha2";
            this.txbSenha2.Size = new System.Drawing.Size(214, 21);
            this.txbSenha2.TabIndex = 3;
            this.txbSenha2.UseSystemPasswordChar = true;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.txbEmail.Location = new System.Drawing.Point(28, 67);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(214, 21);
            this.txbEmail.TabIndex = 2;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha2.Location = new System.Drawing.Point(266, 130);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(218, 20);
            this.lblSenha2.TabIndex = 1;
            this.lblSenha2.Text = "Digite a senha novamente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(24, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Digite o seu email";
            // 
            // txbSenha1
            // 
            this.txbSenha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha1.ForeColor = System.Drawing.SystemColors.Control;
            this.txbSenha1.Location = new System.Drawing.Point(28, 153);
            this.txbSenha1.Name = "txbSenha1";
            this.txbSenha1.Size = new System.Drawing.Size(214, 21);
            this.txbSenha1.TabIndex = 6;
            this.txbSenha1.UseSystemPasswordChar = true;
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha1.Location = new System.Drawing.Point(24, 130);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(144, 20);
            this.lblSenha1.TabIndex = 5;
            this.lblSenha1.Text = "Digite sua senha";
            // 
            // CadastroUsuarioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(592, 389);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroUsuarioAluno";
            this.Text = "Criando usuário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSenha1;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbSenha2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.Label lblEmail;
    }
}