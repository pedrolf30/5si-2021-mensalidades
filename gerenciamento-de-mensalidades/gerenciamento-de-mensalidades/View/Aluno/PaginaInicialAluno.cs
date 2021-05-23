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

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class PaginaInicialAluno : Form
    {
        UsuarioModel currentUser;
        public PaginaInicialAluno(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnMinhasMensalidades_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }
    }
}
