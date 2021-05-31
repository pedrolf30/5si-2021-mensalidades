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
using gerenciamento_de_mensalidades.Controller;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class PaginaInicialFuncionario : Form
    {
        UsuarioModel currentUser;
        FuncionarioModel usuarioFuncionario;
        FuncionarioController funcionarioController = new FuncionarioController();
        MensalidadeController mensalidadeController = new MensalidadeController();
        public PaginaInicialFuncionario(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void PaginaInicialFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuarioFuncionario();
            lblNomeUsuario.Text = usuarioFuncionario.Nome;
            lblTotalAlunosEndividados.Text = mensalidadeController.BuscarTotalAlunosEndividados().ToString();
            lblTotalMensalidadesAtrasadas.Text = mensalidadeController.BuscarTotalMensalidadesAtrasadas().ToString();
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilFuncionario perfilFuncionario = new PerfilFuncionario(usuarioFuncionario);
            this.Hide();
            perfilFuncionario.Show();
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

        private void CarregarDadosUsuarioFuncionario()
        {
            usuarioFuncionario = funcionarioController.BuscarFuncionario(idUsuario: currentUser.IdUsuario);
            usuarioFuncionario.IdUsuario = currentUser.IdUsuario;
            usuarioFuncionario.Email = currentUser.Email;
            usuarioFuncionario.Senha = currentUser.Senha;
            usuarioFuncionario.TipoUsuario = currentUser.TipoUsuario;
            usuarioFuncionario.Ativo = currentUser.Ativo;
        }
    }
}
