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

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class PerfilAluno : Form
    {
        AlunoModel usuarioAluno;
        AlunoController alunoController = new AlunoController();
        EnderecoController enderecoController = new EnderecoController();
        UsuarioController usuarioController = new UsuarioController();
        public PerfilAluno(AlunoModel aluno)
        {
            InitializeComponent();
            usuarioAluno = aluno;
        }

        private void PerfilAluno_Load(object sender, EventArgs e)
        {
            CarregarMeusDados();
            CarregarDadosEnderecos();
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            DisplayPanelAlterarSenha("Update");
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Alterar Senha"))
                {
                    bool statusAlterarSenha = usuarioController.AlterarSenha(idUsuario: usuarioAluno.IdUsuario, senha: txbSenha1.Text);

                    if (statusAlterarSenha)
                    {
                        usuarioAluno.Senha = txbSenha1.Text;
                        txbSenha1.Text = "";
                        txbSenha2.Text = "";
                        DisplayPanelAlterarSenha("ReadOnly");
                        MessageBox.Show("Senha alterada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Meus Dados"))
                {
                    bool statusEdicaoAluno = alunoController.AtualizarAluno(idUsuario: usuarioAluno.IdUsuario, nome: txbNome.Text, ra: int.Parse(txbRA.Text), dataNascimento: dtpNascimento.Value, 
                                                                       cpf: txbCPF.Text, cursoMatriculado: cbCurso.Text, contato: txbContato.Text);
                    bool statusAlterarEmail = usuarioController.AlterarEmail(idUsuario: usuarioAluno.IdUsuario, email: txbEmail.Text);

                    if (statusEdicaoAluno || statusAlterarEmail)
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

        private void dgvEnderecos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEnderecos.SelectedRows)
            {
                SelecionarEndereco(row);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Meus Endereços"))
                {
                    bool statusCadastro = enderecoController.CadastrarEndereco(idAluno: usuarioAluno.IdAluno, rua: txbRua.Text, numero: int.Parse(txbNumero.Text), cep: txbCEP.Text,
                                                                               bairro: txbBairro.Text, cidade: txbCidade.Text, estado: cbEstado.Text, complemento: txbComplemento.Text);

                    if (statusCadastro)
                    {
                        LimparCamposEndereco();
                        CarregarDadosEnderecos();
                        MessageBox.Show("Endereço adicionado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var escolha = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (escolha == DialogResult.Yes)
                {
                    if (enderecoController.ExcluirEndereco(idEndereco: int.Parse(txbIdEndereco.Text)))
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        btnAdicionar.Enabled = true;
                        LimparCamposEndereco();
                        CarregarDadosEnderecos();
                        MessageBox.Show("Endereço excluído com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Meus Endereços"))
                {
                    bool statusEdicao = enderecoController.AtualizarEndereco(idEndereco: int.Parse(txbIdEndereco.Text), rua: txbRua.Text, numero: int.Parse(txbNumero.Text), cep: txbCEP.Text,
                                                                             bairro: txbBairro.Text, cidade: txbCidade.Text, estado: cbEstado.Text, complemento: txbComplemento.Text);

                    if (statusEdicao)
                    {
                        btnEditar.Enabled = false;
                        btnDeletar.Enabled = false;
                        btnAdicionar.Enabled = true;
                        LimparCamposEndereco();
                        CarregarDadosEnderecos();
                        MessageBox.Show("Endereço atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(usuarioAluno, this);
        }

        private void CarregarMeusDados()
        {
            lblNomeUsuario.Text = usuarioAluno.Nome;
            txbNome.Text = usuarioAluno.Nome;
            txbRA.Text = usuarioAluno.RA.ToString();
            txbCPF.Text = usuarioAluno.CPF;
            txbNascimento.Text = usuarioAluno.DataNascimento.ToString("dd/MM/yyyy");
            dtpNascimento.Value = usuarioAluno.DataNascimento;
            txbCurso.Text = usuarioAluno.CursoMatriculado;
            cbCurso.Text = usuarioAluno.CursoMatriculado;
            txbContato.Text = usuarioAluno.Contato;
            txbEmail.Text = usuarioAluno.Email;
        }

        private void CarregarDadosEnderecos()
        {
            dgvEnderecos.DataSource = null;
            dgvEnderecos.Rows.Clear();
            dgvEnderecos.Refresh();
            enderecoController.ListarEnderecosAluno(idAluno: usuarioAluno.IdAluno)
                .ForEach(endereco => dgvEnderecos.Rows.Add(endereco.IdEndereco, endereco.Rua, endereco.Numero, endereco.CEP, endereco.Bairro, 
                                                           endereco.Cidade, endereco.Estado, endereco.Complemento));
        }

        private void RecarregarMeusDados()
        {
            AlunoModel aluno = alunoController.BuscarAlunoPorIdUsuario(idUsuario: usuarioAluno.IdUsuario);

            usuarioAluno.Nome = aluno.Nome;
            usuarioAluno.RA = aluno.RA;
            usuarioAluno.CPF = aluno.CPF;
            usuarioAluno.DataNascimento = aluno.DataNascimento;
            usuarioAluno.CursoMatriculado = aluno.CursoMatriculado;
            usuarioAluno.Contato = aluno.Contato;

            UsuarioModel usuario = usuarioController.BuscarUsuarioPorId(idUsuario: usuarioAluno.IdUsuario);

            usuarioAluno.Email = usuario.Email;

            CarregarMeusDados();
        }

        private void SelecionarEndereco(DataGridViewRow row)
        {
            txbIdEndereco.Text = Convert.ToInt32(row.Cells[0].Value).ToString();
            txbRua.Text = row.Cells[1].Value.ToString();
            txbNumero.Text = Convert.ToInt32(row.Cells[2].Value).ToString();
            txbCEP.Text = row.Cells[3].Value.ToString();
            txbBairro.Text = row.Cells[4].Value.ToString();
            txbCidade.Text = row.Cells[5].Value.ToString();
            cbEstado.Text = row.Cells[6].Value.ToString();
            txbComplemento.Text = row.Cells[7].Value.ToString();

            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnAdicionar.Enabled = false;
        }

        private void LimparCamposEndereco()
        {
            txbIdEndereco.Text = "";
            txbRua.Text = "";
            txbNumero.Text = "";
            txbCEP.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            cbEstado.SelectedIndex = -1;
            txbComplemento.Text = "";
        }

        private void DisplayPanelMeusDados(String mode)
        {
            if (mode == "ReadOnly")
            {
                txbNome.ReadOnly = true;
                txbRA.ReadOnly = true;
                txbCPF.ReadOnly = true;
                txbNascimento.Visible = true;
                dtpNascimento.Visible = false;
                txbCurso.Visible = true;
                cbCurso.Visible = false;
                txbContato.ReadOnly = true;
                txbEmail.ReadOnly = true;

                btnEditarPessoa.Visible = true;
                btnSalvarPessoa.Visible = false;
            }
            else if (mode == "Update")
            {
                txbNome.ReadOnly = false;
                txbRA.ReadOnly = false;
                txbCPF.ReadOnly = false;
                txbNascimento.Visible = false;
                dtpNascimento.Visible = true;
                txbCurso.Visible = false;
                cbCurso.Visible = true;
                txbContato.ReadOnly = false;
                txbEmail.ReadOnly = false;

                btnEditarPessoa.Visible = false;
                btnSalvarPessoa.Visible = true;
            }
        }

        private void DisplayPanelAlterarSenha(String mode)
        {
            if (mode == "ReadOnly")
            {
                lblSenha1.Visible = false;
                lblSenha2.Visible = false;
                txbSenha1.Visible = false;
                txbSenha2.Visible = false;
                btnSalvar.Visible = false;
                btnTrocaSenha.Visible = true;
            }
            else if (mode == "Update")
            {
                lblSenha1.Visible = true;
                lblSenha2.Visible = true;
                txbSenha1.Visible = true;
                txbSenha2.Visible = true;
                btnSalvar.Visible = true;
                btnTrocaSenha.Visible = false;
            }
        }

        private Boolean ValidarCampos(String panel)
        {
            if (panel == "Meus Dados")
            {
                if (txbNome.Text != "" && txbRA.Text != "" && txbCPF.Text != "" && txbContato.Text != "" && txbEmail.Text != "")
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
            else if (panel == "Meus Endereços")
            {
                if (txbRua.Text != "" && txbNumero.Text != "" && txbCEP.Text != "" && txbBairro.Text != "" && txbCidade.Text != "" && cbEstado.SelectedIndex != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de atualizar", "Falha ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
