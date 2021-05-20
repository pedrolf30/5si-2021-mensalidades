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
    public partial class ListagemAlunos : Form
    {
        public ListagemAlunos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDados.Visible = true;

            if (ConfigurationManager.AppSettings["user"] == "Admin")
            {
                btnDesativar.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["user"] == "Func")
            {
                PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario();
                paginaInicialFuncionario.Show();
                this.Visible = false;
            }
            else if(ConfigurationManager.AppSettings["user"] == "Admin")
            {
                PaginaInicialAdmin homePageAdmin = new PaginaInicialAdmin();
                homePageAdmin.Show();
                this.Visible = false;
            }
            
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno desativado com sucesso!");
        }

        private void btnBolsista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Aluno X agora é um bolsista");
        }
    }
}
