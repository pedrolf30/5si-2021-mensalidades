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
using gerenciamento_de_mensalidades.View.Aluno;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class PaginaInicialFuncionario : Form
    {
        UsuarioModel currentUser;
        public PaginaInicialFuncionario(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.Show();
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            this.Close();
            sairParaLogin.Show();
        }
    }
}
