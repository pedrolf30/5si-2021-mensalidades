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
using gerenciamento_de_mensalidades.Enum;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class Solicitacoes : Form
    {
        FuncionarioModel usuarioFuncionario;
        SolicitacaoController solicitacaoController = new SolicitacaoController();

        Boolean minhasSolicitacoes = false;

        public Solicitacoes(FuncionarioModel funcionario)
        {
            InitializeComponent();
            usuarioFuncionario = funcionario;
        }

        private void Solicitacoes_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = usuarioFuncionario.Nome;
            CarregarDadosSolicitacoes(pesquisa: "", status: "Todas", minhasSolicitacoes: false);
        }

        private async void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txbPesquisa.Text;

            await Task.Delay(400);

            if (pesquisa == txbPesquisa.Text)
                CarregarDadosSolicitacoes(pesquisa, status: cbStatus.Text, minhasSolicitacoes);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosSolicitacoes(pesquisa: txbPesquisa.Text, status: cbStatus.Text, minhasSolicitacoes);
        }

        private void cbMinhasSolicitacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMinhasSolicitacoes.Text == "Minhas Solicitações")
            {
                minhasSolicitacoes = true;
            }
            else
            {
                minhasSolicitacoes = false;
            }

            CarregarDadosSolicitacoes(pesquisa: txbPesquisa.Text, status: cbStatus.Text, minhasSolicitacoes);
        }

        private void dgvSolicitacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSolicitacoes.SelectedRows)
            {
                SelecionarSolicitacao(row);

                if (row.Cells[5].Value.ToString() == "Pendente")
                {
                    btnAprovar.Visible = true;
                    btnRecusar.Visible = true;
                    rtbFeedback.ReadOnly = false;
                }
                else
                {
                    btnAprovar.Visible = false;
                    btnRecusar.Visible = false;
                    rtbFeedback.ReadOnly = true;
                }

                if (usuarioFuncionario.TipoUsuario == TipoUsuario.Administrador)
                {
                    btnDeletar.Visible = true;
                }
                else
                {
                    btnDeletar.Visible = false;
                }

                panelDados.Visible = true;
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    bool statusAprovacao = solicitacaoController.ResponderSolicitacao(status: "Aprovado", resposta: rtbFeedback.Text, atendente: usuarioFuncionario, 
                                                                                      idSolicitacao: int.Parse(txbIDSolicitacao.Text));

                    if (statusAprovacao)
                    {
                        panelDados.Visible = false;
                        CarregarDadosSolicitacoes(pesquisa: txbPesquisa.Text, status: cbStatus.Text, minhasSolicitacoes);
                        MessageBox.Show("Solicitação aprovada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    bool statusRecusa = solicitacaoController.ResponderSolicitacao(status: "Rejeitado", resposta: rtbFeedback.Text, atendente: usuarioFuncionario,
                                                                                   idSolicitacao: int.Parse(txbIDSolicitacao.Text));

                    if (statusRecusa)
                    {
                        panelDados.Visible = false;
                        CarregarDadosSolicitacoes(pesquisa: txbPesquisa.Text, status: cbStatus.Text, minhasSolicitacoes);
                        MessageBox.Show("Solicitação recusada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (solicitacaoController.ExcluirSolicitacao(idSolicitacao: int.Parse(txbIDSolicitacao.Text)))
                    {
                        panelDados.Visible = false;
                        CarregarDadosSolicitacoes(pesquisa: txbPesquisa.Text, status: cbStatus.Text, minhasSolicitacoes);
                        MessageBox.Show("Solicitação excluída com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            usuarioController.VoltarParaPaginaInicial(usuarioFuncionario, this);
        }

        private void CarregarDadosSolicitacoes(String pesquisa, String status, Boolean minhasSolicitacoes)
        {
            dgvSolicitacoes.DataSource = null;
            dgvSolicitacoes.Rows.Clear();
            dgvSolicitacoes.Refresh();
            solicitacaoController.ListarSolicitacoes(pesquisa, status, minhasSolicitacoes, idFuncionario: usuarioFuncionario.IdFuncionario)
                .ForEach(solicitacao => dgvSolicitacoes.Rows.Add(solicitacao.IdSolicitacao, solicitacao.Aluno.Nome, solicitacao.Categoria,
                                                                 solicitacao.Descricao, solicitacao.DataSolicitacao, solicitacao.Status,
                                                                 solicitacao.Funcionario.Nome, solicitacao.Resposta, solicitacao.Aluno.Contato,
                                                                 solicitacao.Aluno.CursoMatriculado));
        }

        private void SelecionarSolicitacao(DataGridViewRow row)
        {
            txbIDSolicitacao.Text = row.Cells[0].Value.ToString();
            txbAluno.Text = row.Cells[1].Value.ToString();
            txbCategoria.Text = row.Cells[2].Value.ToString();
            rtbDescricao.Text = row.Cells[3].Value.ToString();
            txtDtSolicitacao.Text = Convert.ToDateTime(row.Cells[4].Value).ToString("dd/MM/yyyy");
            txbStatus.Text = row.Cells[5].Value.ToString();
            txbAtendimento.Text = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : "** Aguardando Atendimento **";
            rtbFeedback.Text = row.Cells[7].Value != null ? row.Cells[7].Value.ToString() : "";
            txbContato.Text = row.Cells[8].Value.ToString();
            txbCurso.Text = row.Cells[9].Value.ToString();
        }

        private Boolean ValidarCampos()
        {
            if (rtbFeedback.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha o campo de Feedback ao Aluno explicando porque a solicitação foi aprovada ou rejeitada", 
                            "Falha ao responder solicitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
