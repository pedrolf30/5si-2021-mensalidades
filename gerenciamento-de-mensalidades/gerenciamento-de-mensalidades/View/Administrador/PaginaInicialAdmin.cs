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
using gerenciamento_de_mensalidades.Controller;

namespace gerenciamento_de_mensalidades.View.Administrador
{
    public partial class PaginaInicialAdmin : Form
    {
        UsuarioModel currentUser;
        FuncionarioModel usuarioAdministrador;
        FuncionarioController funcionarioController = new FuncionarioController();
        MensalidadeController mensalidadeController = new MensalidadeController();
        public PaginaInicialAdmin(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void PaginaInicialAdmin_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuarioAdministrador();
            lblNomeUsuario.Text = usuarioAdministrador.Nome;
            lblTotalAlunosEndividados.Text = mensalidadeController.BuscarTotalAlunosEndividados().ToString();
            lblTotalMensalidadesAtrasadas.Text = mensalidadeController.BuscarTotalMensalidadesAtrasadas().ToString();
            lblTotalDividaAlunos.Text = mensalidadeController.BuscarValorTotalDividas().ToString("F");
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilFuncionario perfilFuncionario = new PerfilFuncionario(usuarioAdministrador);
            this.Hide();
            perfilFuncionario.Show();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios usuarios = new CadastroUsuarios(usuarioAdministrador);
            this.Hide();
            usuarios.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }

        private void CarregarDadosUsuarioAdministrador()
        {
            usuarioAdministrador = funcionarioController.BuscarFuncionario(idUsuario: currentUser.IdUsuario);
            usuarioAdministrador.IdUsuario = currentUser.IdUsuario;
            usuarioAdministrador.Email = currentUser.Email;
            usuarioAdministrador.Senha = currentUser.Senha;
            usuarioAdministrador.TipoUsuario = currentUser.TipoUsuario;
            usuarioAdministrador.Ativo = currentUser.Ativo;
        }
    }
}
