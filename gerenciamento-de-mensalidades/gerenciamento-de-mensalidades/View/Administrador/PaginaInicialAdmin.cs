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

namespace gerenciamento_de_mensalidades.View.Administrador
{
    public partial class PaginaInicialAdmin : Form
    {
        public PaginaInicialAdmin()
        {
            InitializeComponent();
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilFuncionario perfilFuncionario = new PerfilFuncionario();
            perfilFuncionario.Show();
            this.Visible = false;
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            ListagemAlunos listagemAlunos = new ListagemAlunos();
            listagemAlunos.Show();
            this.Visible = false;
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            Solicitacoes solicitacoes = new Solicitacoes();
            solicitacoes.Show();
            this.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios solicitacoes = new CadastroUsuarios();
            solicitacoes.Show();
            this.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }
    }
}
