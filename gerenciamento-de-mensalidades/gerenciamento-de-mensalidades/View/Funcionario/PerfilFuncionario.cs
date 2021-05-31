using gerenciamento_de_mensalidades.View.Administrador;
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
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class PerfilFuncionario : Form
    {
        FuncionarioModel usuarioFuncionario;
        UsuarioController usuarioController = new UsuarioController();
        FuncionarioController funcionarioController = new FuncionarioController();
        public PerfilFuncionario(FuncionarioModel funcionario)
        {
            InitializeComponent();
            usuarioFuncionario = funcionario;
        }

        private void PerfilFuncionario_Load(object sender, EventArgs e)
        {
            CarregarMeusDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(usuarioFuncionario, this);
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            txbSenha1.Clear();
            txbSenha2.Clear();

            panelTrocaSenha.Visible = true;
            panelBotaoAS.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Alterar Senha"))
                {
                    bool statusAlterarSenha = usuarioController.AlterarSenha(idUsuario: usuarioFuncionario.IdUsuario, senha: txbSenha1.Text);

                    if (statusAlterarSenha)
                    {
                        panelTrocaSenha.Visible = false;
                        panelBotaoAS.Visible = true;
                        MessageBox.Show("Senha alterada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Meus Dados"))
                {
                    bool statusEdicao = funcionarioController.AtualizarFuncionario(idUsuario: usuarioFuncionario.IdUsuario, nome: txbNome.Text, 
                                                                                   dataNascimento: dtpNascimento.Value, cpf: txbCPF.Text, 
                                                                                   contato: txbContato.Text);
                    bool statusAlterarEmail = usuarioController.AlterarEmail(idUsuario: usuarioFuncionario.IdUsuario, email: txbEmail.Text);

                    if (statusEdicao || statusAlterarEmail)
                    {
                        RecarregarMeusDados();
                        DisplayPanelMeusDados("ReadOnly");
                        MessageBox.Show("Dados atualizados com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            DisplayPanelMeusDados("Update");
        }

        private void CarregarMeusDados()
        {
            lblNomeUsuario.Text = usuarioFuncionario.Nome;
            txbNome.Text = usuarioFuncionario.Nome;
            txbCPF.Text = usuarioFuncionario.CPF;
            txbNascimento.Text = usuarioFuncionario.DataNascimento.Value.ToString("dd/MM/yyyy");
            dtpNascimento.Value = usuarioFuncionario.DataNascimento.Value;
            txbContato.Text = usuarioFuncionario.Contato;
            txbEmail.Text = usuarioFuncionario.Email;
        }

        private void RecarregarMeusDados()
        {
            FuncionarioModel funcionario = funcionarioController.BuscarFuncionario(idUsuario: usuarioFuncionario.IdUsuario);

            usuarioFuncionario.Nome = funcionario.Nome;
            usuarioFuncionario.CPF = funcionario.CPF;
            usuarioFuncionario.DataNascimento = funcionario.DataNascimento;
            usuarioFuncionario.Contato = funcionario.Contato;

            UsuarioModel usuario = usuarioController.BuscarUsuarioPorId(idUsuario: usuarioFuncionario.IdUsuario);

            usuarioFuncionario.Email = usuario.Email;

            CarregarMeusDados();
        }

        private void DisplayPanelMeusDados(String mode)
        {
            if (mode == "ReadOnly")
            {
                txbNome.ReadOnly = true;
                txbCPF.ReadOnly = true;
                txbNascimento.Visible = true;
                dtpNascimento.Visible = false;
                txbContato.ReadOnly = true;
                txbEmail.ReadOnly = true;

                btnEditarPessoa.Visible = true;
                btnSalvarPessoa.Visible = false;
            }
            else if (mode == "Update")
            {
                txbNome.ReadOnly = false;
                txbCPF.ReadOnly = false;
                txbNascimento.Visible = false;
                dtpNascimento.Visible = true;
                txbContato.ReadOnly = false;
                txbEmail.ReadOnly = false;

                btnEditarPessoa.Visible = false;
                btnSalvarPessoa.Visible = true;
            }
        }

        private Boolean ValidarCampos(String panel)
        {
            if (panel == "Meus Dados")
            {
                if (dtpNascimento.Value.Date > DateTime.Now.Date.AddYears(-16))
                {
                    MessageBox.Show("Idade não pode ser menor do que 16 anos", "Falha ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (txbNome.Text != "" && txbCPF.Text != "" && txbContato.Text != "" && txbEmail.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de atualizar", "Falha ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (panel == "Alterar Senha")
            {
                if (txbSenha1.Text != txbSenha2.Text)
                {
                    MessageBox.Show("As senhas devem ser identicas", "Falha ao trocar de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (txbSenha1.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Defina uma nova senha antes de alterar a senha", "Falha ao trocar de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
