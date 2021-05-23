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
using gerenciamento_de_mensalidades.Controller;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class Solicitacoes : Form
    {
        UsuarioModel currentUser;
        public Solicitacoes(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(currentUser, this);
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
