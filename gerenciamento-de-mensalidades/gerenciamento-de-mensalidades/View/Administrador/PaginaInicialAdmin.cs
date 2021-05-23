using gerenciamento_de_mensalidades.View.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.View.Administrador
{
    public partial class PaginaInicialAdmin : Form
    {
        UsuarioModel currentUser;
        public PaginaInicialAdmin(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void PaginaInicialAdmin_Load(object sender, EventArgs e)
        {
            lblEmailCurrentUser.Text = currentUser.Email;
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios usuarios = new CadastroUsuarios(currentUser);
            this.Hide();
            usuarios.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }
    }
}
