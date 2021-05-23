using gerenciamento_de_mensalidades.View.Administrador;
using gerenciamento_de_mensalidades.View.Aluno;
using gerenciamento_de_mensalidades.View.Funcionario;
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

namespace gerenciamento_de_mensalidades
{
    public partial class Login : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuarioAluno cadUsuarioAluno = new CadastroUsuarioAluno();
            this.Hide();
            cadUsuarioAluno.Show();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            usuarioController.FazerLogin(txbEmail, txbSenha, this);
        }
    }
}
