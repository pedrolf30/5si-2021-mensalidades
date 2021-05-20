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
    public partial class Solicitacoes : Form
    {
        public Solicitacoes()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDados.Visible = true;

            if (ConfigurationManager.AppSettings["user"] == "Admin")
            {
                btnDeletar.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            panelDados.Visible = false;
            MessageBox.Show("Solicitação salva com sucesso!");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            panelDados.Visible = false;
            MessageBox.Show("Solicitação deletada com sucesso!");
        }
    }
}
