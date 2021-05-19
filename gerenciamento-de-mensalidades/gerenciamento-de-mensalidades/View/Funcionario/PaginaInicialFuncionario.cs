using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class PaginaInicialFuncionario : Form
    {
        public PaginaInicialFuncionario()
        {
            InitializeComponent();
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilFuncionario perfilFuncionario = new PerfilFuncionario();
            perfilFuncionario.Show();
            this.Visible = false;
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            Solicitacoes solicitacoes = new Solicitacoes();
            solicitacoes.Show();
            this.Visible = false;

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            ListagemAlunos listagemAlunos = new ListagemAlunos();
            listagemAlunos.Show();
            this.Visible = false;
        }
    }
}
