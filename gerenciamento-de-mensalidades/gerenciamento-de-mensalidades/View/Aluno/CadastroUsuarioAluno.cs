using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerenciamento_de_mensalidades.Controller;
using gerenciamento_de_mensalidades.Model;
using gerenciamento_de_mensalidades.Enum;

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class CadastroUsuarioAluno : Form
    {
        Login loginView;
        AlunoController alunoController = new AlunoController();
        UsuarioController usuarioController = new UsuarioController();
        public CadastroUsuarioAluno(Login login)
        {
            InitializeComponent();
            loginView = login;
        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    AlunoModel aluno = alunoController.BuscarAlunoPorRA(ra: int.Parse(txbRA.Text));

                    if (aluno.IdAluno != 0)
                    {
                        MessageBox.Show("Aluno com o RA '" + txbRA.Text + "' já possui conta de usuário", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (aluno.TipoUsuario != TipoUsuario.Undefined)
                    {
                        int idUsuario = usuarioController.CadastrarUsuario(email: txbEmail.Text, senha: txbSenha1.Text, tipoUsuario: TipoUsuario.Aluno, ativo: true);
                        bool statusCadastro = idUsuario != 0 ? alunoController.VincularUsuarioAluno(idUsuario, ra: int.Parse(txbRA.Text)) : false;

                        if (statusCadastro)
                        {
                            MessageBox.Show("Conta de usuário cadastrada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado com o RA '" + txbRA.Text +  "'", "Falha ao cadastrar-se", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ValidarCampos()
        {
            if (txbSenha1.Text != txbSenha2.Text)
            {
                MessageBox.Show("As senhas devem ser identicas", "Falha ao cadastrar-se", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txbEmail.Text != "" && txbRA.Text != "" && txbSenha1.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar-se", "Falha ao cadastrar-se", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
