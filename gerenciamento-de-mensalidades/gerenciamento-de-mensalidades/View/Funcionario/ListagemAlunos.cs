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
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class ListagemAlunos : Form
    {
        UsuarioModel currentUser;
        public ListagemAlunos(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
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
