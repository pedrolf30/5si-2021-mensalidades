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
    public partial class SolicitacoesAluno : Form
    {
        AlunoModel usuarioAluno;
        SolicitacaoController solicitacaoController = new SolicitacaoController();
        public SolicitacoesAluno(AlunoModel aluno)
        {
            InitializeComponent();
            usuarioAluno = aluno;
        }

        private void SolicitacoesAluno_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = usuarioAluno.Nome;
            CarregarDadosSolicitacoes("Todas");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFieldsSolicitacao("Hide All");
            CarregarDadosSolicitacoes(cbStatus.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(usuarioAluno, this);
        }

        private void btnCriarSolicitacao_Click(object sender, EventArgs e)
        {
            LimparCampos();

            lblCategoria.Visible = true;
            lblDesc.Visible = true;
            cbCategoria.Visible = true;
            txbCategoria.Visible = false;
            rtbDescricao.Visible = true;
            rtbDescricao.ReadOnly = false;
            btnEnviar.Visible = true;

            DisplayFieldsSolicitacao("Hide");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    bool statusEnvio = solicitacaoController.EnviarSolicitacao(idAluno: usuarioAluno.IdAluno, categoria: cbCategoria.Text, descricao: rtbDescricao.Text, 
                                                                               dataSolicitacao: DateTime.Now, status: "Pendente");

                    if (statusEnvio)
                    {
                        lblCategoria.Visible = false;
                        lblDesc.Visible = false;
                        cbCategoria.Visible = false;
                        rtbDescricao.Visible = false;
                        rtbDescricao.ReadOnly = true;
                        btnEnviar.Visible = false;
                        CarregarDadosSolicitacoes(cbStatus.Text);
                        MessageBox.Show("Solicitação enviada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSolicitacoes.SelectedRows)
            {
                SelecionarSolicitacao(row);

                cbCategoria.Visible = false;
                txbCategoria.Visible = true;
                lblCategoria.Visible = true;
                lblDesc.Visible = true;
                rtbDescricao.Visible = true;
                rtbDescricao.ReadOnly = true;
                btnEnviar.Visible = false;

                DisplayFieldsSolicitacao("Show");
            }            
        }

        private void CarregarDadosSolicitacoes(String status)
        {
            dgvSolicitacoes.DataSource = null;
            dgvSolicitacoes.Rows.Clear();
            dgvSolicitacoes.Refresh();
            solicitacaoController.ListarSolicitacoesAluno(status, idAluno: usuarioAluno.IdAluno)
                .ForEach(solicitacao => dgvSolicitacoes.Rows.Add(solicitacao.Categoria, solicitacao.Descricao, solicitacao.DataSolicitacao, solicitacao.Status, 
                                                                 solicitacao.Funcionario.Nome, solicitacao.Resposta));
        }

        private void SelecionarSolicitacao(DataGridViewRow row)
        {
            txbCategoria.Text = row.Cells[0].Value.ToString();
            rtbDescricao.Text = row.Cells[1].Value.ToString();
            txbDataSolicitacao.Text = Convert.ToDateTime(row.Cells[2].Value).ToString("dd/MM/yyyy");
            txbStatus.Text = row.Cells[3].Value.ToString();
            txbAtendidoPor.Text = row.Cells[4].Value !=  null ? row.Cells[4].Value.ToString() : "**Não Atendido**";
            rtbResposta.Text = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "**Sem Resposta**";
        }

        private void LimparCampos()
        {
            cbCategoria.SelectedIndex = -1;
            rtbDescricao.Clear();
        }

        private Boolean ValidarCampos()
        {
            if (cbCategoria.SelectedIndex != -1 && rtbDescricao.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de enviar", "Falha ao enviar solicitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            
        }

        private void DisplayFieldsSolicitacao(String mode)
        {
            if (mode == "Show")
            {
                lblDataSolicitacao.Visible = true;
                lblStatus.Visible = true;
                lblAtendidoPor.Visible = true;
                lblResposta.Visible = true;
                txbDataSolicitacao.Visible = true;
                txbStatus.Visible = true;
                txbAtendidoPor.Visible = true;
                rtbResposta.Visible = true;
            }
            else if (mode == "Hide")
            {
                lblDataSolicitacao.Visible = false;
                lblStatus.Visible = false;
                lblAtendidoPor.Visible = false;
                lblResposta.Visible = false;
                txbDataSolicitacao.Visible = false;
                txbStatus.Visible = false;
                txbAtendidoPor.Visible = false;
                rtbResposta.Visible = false;
            }
            else if (mode == "Hide All")
            {
                lblCategoria.Visible = false;
                lblDesc.Visible = false;
                cbCategoria.Visible = false;
                txbCategoria.Visible = false;
                rtbDescricao.Visible = false;
                btnEnviar.Visible = false;

                lblDataSolicitacao.Visible = false;
                lblStatus.Visible = false;
                lblAtendidoPor.Visible = false;
                lblResposta.Visible = false;
                txbDataSolicitacao.Visible = false;
                txbStatus.Visible = false;
                txbAtendidoPor.Visible = false;
                rtbResposta.Visible = false;
            }
        }
    }
}
