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

namespace gerenciamento_de_mensalidades.View.Administrador
{
    public partial class CadastroUsuarios : Form
    {
        UsuarioModel currentUser; 
        UsuarioController usuarioController = new UsuarioController();
        FuncionarioController funcionarioController = new FuncionarioController();
        AlunoController alunoController = new AlunoController();
        public CadastroUsuarios(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            lblEmailCurrentUser.Text = currentUser.Email;
            CarregadarDadosUsuarios();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            usuarioController.VoltarParaPaginaInicial(currentUser, this);
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            DisplayPanelFuncionario("Update");
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            DisplayPanelAluno("Update");
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            txbEmailCF.Clear();
            txbSenha1CF.Clear();
            txbSenha2CF.Clear();
            txbNomeCF.Clear();
            dtpNascimentoCF.Value = DateTime.Now;
            txbCPFCF.Clear();
            txbContatoCF.Clear();

            panelCF.Visible = true;
            btnCF.Visible = false;
            panelFuncionario.Visible = false;
            panelAluno.Visible = false;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
            {
                if (row.Cells[2].Value.ToString() == "Funcionario")
                {
                    SelecionarUsuarioFuncionario(row);
                }
                else if (row.Cells[2].Value.ToString() == "Aluno")
                {
                    SelecionarUsuarioAluno(row);
                }
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("CF"))
                {
                    int idUsuario = usuarioController.CadastrarUsuario(email: txbEmailCF.Text, senha: txbSenha1CF.Text, tipoUsuario: TipoUsuario.Funcionario, ativo: true);
                    bool statusCadastro = idUsuario != 0 ? funcionarioController.CadastrarFuncionario(idUsuario, nome: txbNomeCF.Text, dataNascimento: dtpNascimentoCF.Value,
                                                                                                 cpf: txbCPFCF.Text, contato: txbContatoCF.Text) : false;

                    if (statusCadastro)
                    {
                        panelCF.Visible = false;
                        btnCF.Visible = true;
                        CarregadarDadosUsuarios();
                        MessageBox.Show("Funcionário cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Funcionario"))
                    if (usuarioController.AtualizarUsuario(idUsuario: int.Parse(txbIdUsuarioFuncionario.Text), email: txbEmailFuncionario.Text, ativo: cbAtivoFuncionario.Text == "Sim" ? true : false))
                    {
                        if (funcionarioController.AtualizarFuncionario(idUsuario: int.Parse(txbIdUsuarioFuncionario.Text), nome: txbNomeFuncionario.Text,
                                                                       dataNascimento: dtpNascimentoFuncionario.Value, cpf: txbCPFFuncionario.Text, contato: txbContatoFuncionario.Text))
                        {
                            txbNascFuncionario.Text = dtpNascimentoFuncionario.Value.ToString("dd/MM/yyyy");
                            txbAtivoFuncionario.Text = cbAtivoFuncionario.Text;
                            DisplayPanelFuncionario("ReadOnly");
                            CarregadarDadosUsuarios();
                            MessageBox.Show("Funcionário atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var escolha = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (escolha == DialogResult.Yes)
                {
                    if (usuarioController.ExcluirUsuario(idUsuario: int.Parse(txbIdUsuarioFuncionario.Text)))
                    {
                        panelFuncionario.Visible = false;
                        CarregadarDadosUsuarios();
                        MessageBox.Show("Funcionário excluído com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("Aluno"))
                    if (usuarioController.AtualizarUsuario(idUsuario: int.Parse(txbIdUsuarioAluno.Text), email: txbEmailAluno.Text, ativo: cbAtivoAluno.Text == "Sim" ? true : false))
                    {
                        if (alunoController.AtualizarAluno(idUsuario: int.Parse(txbIdUsuarioAluno.Text), nome: txbNomeAluno.Text, ra: int.Parse(txbRAAluno.Text),
                                                           dataNascimento: dtpNascimentoAluno.Value, cpf: txbCPFAluno.Text, cursoMatriculado: cbCursoAluno.Text, contato: txbContatoAluno.Text))
                        {
                            txbNascAluno.Text = dtpNascimentoAluno.Value.ToString("dd/MM/yyyy");
                            txbCursoAluno.Text = cbCursoAluno.Text;
                            txbAtivoAluno.Text = cbAtivoAluno.Text;
                            DisplayPanelAluno("ReadOnly");
                            CarregadarDadosUsuarios();
                            MessageBox.Show("Aluno atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            try
            {
                var escolha = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (escolha == DialogResult.Yes)
                {
                    if (usuarioController.ExcluirUsuario(idUsuario: int.Parse(txbIdUsuarioAluno.Text)))
                    {
                        panelAluno.Visible = false;
                        CarregadarDadosUsuarios();
                        MessageBox.Show("Usuário aluno excluído com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregadarDadosUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            usuarioController.ListarUsuarios()
                .ForEach(usuario => dgvUsuarios.Rows.Add(usuario.IdUsuario, usuario.Email, usuario.TipoUsuario, usuario.Ativo ? "Sim" : "Não"));
        }

        private void SelecionarUsuarioFuncionario(DataGridViewRow row)
        {
            FuncionarioModel funcionario = funcionarioController.BuscarFuncionario(idUsuario: Convert.ToInt32(row.Cells[0].Value));

            if (funcionario.TipoUsuario != TipoUsuario.Undefined)
            {
                txbIdUsuarioFuncionario.Text = row.Cells[0].Value.ToString();
                txbNomeFuncionario.Text = funcionario.Nome;
                txbCPFFuncionario.Text = funcionario.CPF;
                txbNascFuncionario.Text = funcionario.DataNascimento.Value.ToString("dd/MM/yyyy");
                dtpNascimentoFuncionario.Value = funcionario.DataNascimento.Value;
                txbContatoFuncionario.Text = funcionario.Contato;
                txbEmailFuncionario.Text = row.Cells[1].Value.ToString();
                txbAtivoFuncionario.Text = row.Cells[3].Value.ToString();
                cbAtivoFuncionario.SelectedIndex = row.Cells[3].Value.ToString() == "Sim" ? 0 : 1;

                DisplayPanelFuncionario("ReadOnly");

                panelFuncionario.Visible = true;
                btnCF.Visible = true;
                panelCF.Visible = false;
                panelAluno.Visible = false;
            }
        }

        private void SelecionarUsuarioAluno(DataGridViewRow row)
        {
            AlunoModel aluno = alunoController.BuscarAlunoPorIdUsuario(idUsuario: Convert.ToInt32(row.Cells[0].Value));

            if (aluno.TipoUsuario != TipoUsuario.Undefined)
            {
                txbIdUsuarioAluno.Text = row.Cells[0].Value.ToString();
                txbNomeAluno.Text = aluno.Nome;
                txbRAAluno.Text = aluno.RA.ToString();
                txbCPFAluno.Text = aluno.CPF;
                txbNascAluno.Text = aluno.DataNascimento.ToString("dd/MM/yyyy");
                dtpNascimentoAluno.Value = aluno.DataNascimento;
                txbContatoAluno.Text = aluno.Contato;
                txbEmailAluno.Text = row.Cells[1].Value.ToString();
                txbCursoAluno.Text = aluno.CursoMatriculado;
                cbCursoAluno.Text = aluno.CursoMatriculado;
                txbAtivoAluno.Text = row.Cells[3].Value.ToString();
                cbAtivoAluno.SelectedIndex = row.Cells[3].Value.ToString() == "Sim" ? 0 : 1;

                DisplayPanelAluno("ReadOnly");

                panelAluno.Visible = true;
                btnCF.Visible = true;
                panelCF.Visible = false;
                panelFuncionario.Visible = false;
            }
        }

        private Boolean ValidarCampos(String panel)
        {
            if (panel == "Funcionario")
            {
                if (dtpNascimentoFuncionario.Value.Date > DateTime.Now.Date.AddYears(-16))
                {
                    MessageBox.Show("O funcionário não pode ser menor de 16 anos", "Falha ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (txbNomeFuncionario.Text != "" && txbCPFFuncionario.Text != "" && txbContatoFuncionario.Text != "" && txbEmailFuncionario.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de atualizar", "Falha ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (panel == "CF")
            {
                if (txbSenha1CF.Text != txbSenha2CF.Text)
                {
                    MessageBox.Show("As senhas devem ser identicas", "Falha ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (dtpNascimentoCF.Value.Date > DateTime.Now.Date.AddYears(-16))
                {
                    MessageBox.Show("O funcionário não pode ser menor de 16 anos", "Falha ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }               
                else if (txbNomeCF.Text != "" && txbCPFCF.Text != "" && txbContatoCF.Text != "" && txbEmailCF.Text != "" && txbSenha1CF.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de cadastrar", "Falha ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (panel == "Aluno")
            {
                if (txbNomeAluno.Text != "" && txbRAAluno.Text != "" && txbCPFAluno.Text != "" && txbContatoAluno.Text != "" && txbEmailAluno.Text != "")
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

        private void DisplayPanelFuncionario(String mode)
        {
            if (mode == "ReadOnly")
            {
                txbNomeFuncionario.ReadOnly = true;
                txbCPFFuncionario.ReadOnly = true;
                dtpNascimentoFuncionario.Visible = false;
                txbNascFuncionario.Visible = true;
                txbContatoFuncionario.ReadOnly = true;
                txbEmailFuncionario.ReadOnly = true;
                cbAtivoFuncionario.Visible = false;
                txbAtivoFuncionario.Visible = true;

                btnEditarFuncionario.Visible = true;
                btnExcluirFuncionario.Visible = true;
                btnAtualizarFuncionario.Visible = false;
            }
            else if (mode == "Update")
            {
                txbNomeFuncionario.ReadOnly = false;
                txbCPFFuncionario.ReadOnly = false;
                dtpNascimentoFuncionario.Visible = true;
                txbNascFuncionario.Visible = false;
                txbContatoFuncionario.ReadOnly = false;
                txbEmailFuncionario.ReadOnly = false;
                cbAtivoFuncionario.Visible = true;
                txbAtivoFuncionario.Visible = false;

                btnEditarFuncionario.Visible = false;
                btnExcluirFuncionario.Visible = false;
                btnAtualizarFuncionario.Visible = true;
            }
        }

        private void DisplayPanelAluno(String mode)
        {
            if (mode == "ReadOnly")
            {
                txbNomeAluno.ReadOnly = true;
                txbRAAluno.ReadOnly = true;
                txbCPFAluno.ReadOnly = true;
                dtpNascimentoAluno.Visible = false;
                txbNascAluno.Visible = true;
                txbContatoAluno.ReadOnly = true;
                txbEmailAluno.ReadOnly = true;
                cbCursoAluno.Visible = false;
                txbCursoAluno.Visible = true;
                cbAtivoAluno.Visible = false;
                txbAtivoAluno.Visible = true;

                btnEditarAluno.Visible = true;
                btnExcluirAluno.Visible = true;
                btnAtualizarAluno.Visible = false;
            }
            else if (mode == "Update")
            {
                txbNomeAluno.ReadOnly = false;
                txbRAAluno.ReadOnly = false;
                txbCPFAluno.ReadOnly = false;
                dtpNascimentoAluno.Visible = true;
                txbNascAluno.Visible = false;
                txbContatoAluno.ReadOnly = false;
                txbEmailAluno.ReadOnly = false;
                cbCursoAluno.Visible = true;
                txbCursoAluno.Visible = false;
                cbAtivoAluno.Visible = true;
                txbAtivoAluno.Visible = false;

                btnEditarAluno.Visible = false;
                btnExcluirAluno.Visible = false;
                btnAtualizarAluno.Visible = true;
            }
        }

    }
}
