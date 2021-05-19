using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class PerfilFuncionario : Form
    {
        public PerfilFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialFuncionario homePageFuncionario = new PaginaInicialFuncionario();
            homePageFuncionario.Show();
            this.Visible = false;
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            lblSenha1.Visible = true;
            lblSenha2.Visible = true;
            txbSenha1.Visible = true;
            txbSenha2.Visible = true;
            btnSalvar.Visible = true;
            btnTrocaSenha.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblSenha1.Visible = false;
            lblSenha2.Visible = false;
            txbSenha1.Visible = false;
            txbSenha2.Visible = false;
            btnSalvar.Visible = false;
            btnTrocaSenha.Visible = true;
            MessageBox.Show("Senha alterada com sucesso!");
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            txbNome.ReadOnly = true;

            txbCPF.ReadOnly = true;
            txbNascimento.Visible = true;
            dtpNascimento.Visible = false;
            txbContato.ReadOnly = true;
            txbEmail.ReadOnly = true;

            btnEditarPessoa.Visible = true;
            btnSalvarPessoa.Visible = false;
            MessageBox.Show("Dados alterados com sucesso!");
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            txbNome.ReadOnly = false;
            txbCPF.ReadOnly = false;
            txbNascimento.Visible = false;
            dtpNascimento.Visible = true;
            txbContato.ReadOnly = false;
            txbEmail.ReadOnly = false;

            txbNome.Enabled = true;
            txbCPF.Enabled = true;
            txbContato.Enabled = true;
            txbEmail.Enabled = true;

            btnEditarPessoa.Visible = false;
            btnSalvarPessoa.Visible = true;
        }
    }
}
