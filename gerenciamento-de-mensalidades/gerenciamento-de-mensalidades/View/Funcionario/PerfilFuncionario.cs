using gerenciamento_de_mensalidades.View.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            if (ConfigurationManager.AppSettings["user"] == "Func")
            {
                PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario();
                paginaInicialFuncionario.Show();
                this.Visible = false;
            }
            else if (ConfigurationManager.AppSettings["user"] == "Admin")
            {
                PaginaInicialAdmin homePageAdmin = new PaginaInicialAdmin();
                homePageAdmin.Show();
                this.Visible = false;
            }
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            panelTrocaSenha.Visible = true;
            panelBotaoAS.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            panelTrocaSenha.Visible = false;
            panelBotaoAS.Visible = true;
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

            txbNome.Enabled = false;
            txbCPF.Enabled = false;
            txbContato.Enabled = false;
            txbEmail.Enabled = false;

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
