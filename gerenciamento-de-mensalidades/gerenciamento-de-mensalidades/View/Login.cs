using gerenciamento_de_mensalidades.View.Aluno;
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

namespace gerenciamento_de_mensalidades
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuarioAluno cadUsuarioAluno = new CadastroUsuarioAluno();
            cadUsuarioAluno.Show();
            this.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PaginaInicialFuncionario homePageFuncionario = new PaginaInicialFuncionario();
            homePageFuncionario.Show();
            this.Visible = false;
        }
    }
}
