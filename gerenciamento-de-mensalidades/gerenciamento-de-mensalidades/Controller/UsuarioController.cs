using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciamento_de_mensalidades.Model;
using gerenciamento_de_mensalidades.Enum;
using gerenciamento_de_mensalidades.View.Administrador;
using gerenciamento_de_mensalidades.View.Funcionario;
using gerenciamento_de_mensalidades.View.Aluno;

namespace gerenciamento_de_mensalidades.Controller
{
    class UsuarioController
    {
        public void FazerLogin(TextBox email, TextBox senha, Form loginView)
        {
            UsuarioModel usuario = new UsuarioModel(email: email.Text, senha: senha.Text);
            usuario = usuario.FazerLogin();

            if (usuario.TipoUsuario == TipoUsuario.Administrador)
            {
                PaginaInicialAdmin paginaInicialAdmin = new PaginaInicialAdmin(usuario);
                loginView.Hide();
                paginaInicialAdmin.ShowDialog();
            }
            else if (usuario.TipoUsuario == TipoUsuario.Funcionario)
            {
                PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario(usuario);
                loginView.Hide();
                paginaInicialFuncionario.ShowDialog();
            }
            else if (usuario.TipoUsuario == TipoUsuario.Aluno)
            {
                PaginaInicialAluno paginaInicialAluno = new PaginaInicialAluno(usuario);
                loginView.Hide();
                paginaInicialAluno.ShowDialog();
            }
            else if (usuario.TipoUsuario == TipoUsuario.Deactivated)
            {
                MessageBox.Show("Conta de usuário desativada", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                senha.Text = "";
            }                     
        }

        public List<UsuarioModel> ListarUsuarios()
        {
            UsuarioModel usuario = new UsuarioModel();
            return usuario.ListarUsuarios();
        }

        public Int32 CadastrarUsuario(String email, String senha, TipoUsuario tipoUsuario, Boolean ativo)
        {
            UsuarioModel usuario = new UsuarioModel(email, senha, tipoUsuario, ativo);
            return usuario.CadastrarUsuario();
        }

        public Boolean AtualizarUsuario(Int32 idUsuario, String email, Boolean ativo)
        {
            UsuarioModel usuario = new UsuarioModel(idUsuario, email, ativo);
            return usuario.AtualizarUsuario();
        }

        public Boolean ExcluirUsuario(Int32 idUsuario)
        {
            UsuarioModel usuario = new UsuarioModel(idUsuario);
            return usuario.ExcluirUsuario();
        }

        public void VoltarParaPaginaInicial(UsuarioModel usuario, Form currentView)
        {
            if (usuario.TipoUsuario == TipoUsuario.Administrador)
            {
                PaginaInicialAdmin paginaInicialAdmin = new PaginaInicialAdmin(usuario);
                currentView.Close();
                paginaInicialAdmin.ShowDialog();
            }
            else if (usuario.TipoUsuario == TipoUsuario.Funcionario)
            {
                PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario(usuario);
                currentView.Close();
                paginaInicialFuncionario.ShowDialog();
            }
            else if (usuario.TipoUsuario == TipoUsuario.Aluno)
            {
                PaginaInicialAluno paginaInicialAluno = new PaginaInicialAluno(usuario);
                currentView.Close();
                paginaInicialAluno.ShowDialog();
            }
        }
    }
}
