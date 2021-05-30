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

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class PaginaInicialAluno : Form
    {
        UsuarioModel currentUser;
        AlunoModel usuarioAluno;
        AlunoController alunoController = new AlunoController();
        MensalidadeController mensalidadeController = new MensalidadeController();
        public PaginaInicialAluno(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void PaginaInicialAluno_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuarioAluno();
            lblNomeUsuario.Text = usuarioAluno.Nome;
            lblMensalidadesAtrasadas.Text = mensalidadeController.BuscarTotalMensalidadesAtrasadasAluno(idAluno: usuarioAluno.IdAluno).ToString();
            lblValorTotalDividas.Text = mensalidadeController.BuscarValorTotalDividasAluno(idAluno: usuarioAluno.IdAluno).ToString("F");
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            PerfilAluno perfilAluno = new PerfilAluno(usuarioAluno);
            this.Hide();
            perfilAluno.Show();
        }

        private void btnMinhasMensalidades_Click(object sender, EventArgs e)
        {
            MensalidadesAluno mensalidadesAluno = new MensalidadesAluno(usuarioAluno);
            this.Hide();
            mensalidadesAluno.Show();
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            SolicitacoesAluno solicitacoesAluno = new SolicitacoesAluno(usuarioAluno);
            this.Hide();
            solicitacoesAluno.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login sairParaLogin = new Login();
            sairParaLogin.Show();
            this.Visible = false;
        }

        private void CarregarDadosUsuarioAluno()
        {
            usuarioAluno = alunoController.BuscarAlunoPorIdUsuario(idUsuario: currentUser.IdUsuario);
            usuarioAluno.IdUsuario = currentUser.IdUsuario;
            usuarioAluno.Email = currentUser.Email;
            usuarioAluno.Senha = currentUser.Senha;
            usuarioAluno.TipoUsuario = currentUser.TipoUsuario;
            usuarioAluno.Ativo = currentUser.Ativo;
        }
    }
}
