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
using gerenciamento_de_mensalidades.Model;
using gerenciamento_de_mensalidades.Controller;
using gerenciamento_de_mensalidades.Enum;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class ListagemAlunos : Form
    {
        FuncionarioModel usuarioFuncionario;
        AlunoController alunoController = new AlunoController();
        UsuarioController usuarioController = new UsuarioController();
        BolsistaController bolsistaController = new BolsistaController();
        MensalidadeController mensalidadeController = new MensalidadeController();

        public ListagemAlunos(FuncionarioModel funcionario)
        {
            InitializeComponent();
            usuarioFuncionario = funcionario;
        }

        private void ListagemAlunos_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = usuarioFuncionario.Nome;
            CarregarDadosAlunos(pesquisa: "", curso: "Todos os Cursos");
        }

        private async void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txbPesquisa.Text;

            await Task.Delay(400);

            if (pesquisa == txbPesquisa.Text)
            {
                CarregarDadosAlunos(pesquisa, curso: cbCurso.Text);
            }
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosAlunos(pesquisa: txbPesquisa.Text, curso: cbCurso.Text);
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAlunos.SelectedRows)
            {
                SelecionarAluno(row);

                if (row.Cells[6].Value.ToString() == "Sim")
                {
                    cbDesconto.Text = row.Cells[12].Value.ToString();
                    btnBolsista.Visible = false;
                    btnAtualizarBolsa.Visible = true;
                    btnRemoverBolsa.Visible = true;
                }
                else
                {
                    cbDesconto.SelectedIndex = -1;
                    btnBolsista.Visible = true;
                    btnAtualizarBolsa.Visible = false;
                    btnRemoverBolsa.Visible = false;
                }

                if (usuarioFuncionario.TipoUsuario == TipoUsuario.Administrador)
                {
                    btnExcluirAluno.Visible = true;
                }
                else
                {
                    btnExcluirAluno.Visible = false;
                }

                cbStatusData.SelectedIndex = -1;
                cbStatusPagamento.SelectedIndex = -1;
                panelDados.Visible = true;
            }
        }

        private void cbStatusData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusData.SelectedIndex != -1)
                CarregarDadosMensalidadesAluno(statusData: cbStatusData.Text, statusPagamento: cbStatusPagamento.Text != "" ? cbStatusPagamento.Text : "Todas");
        }

        private void cbStatusPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusPagamento.SelectedIndex != -1)
                CarregarDadosMensalidadesAluno(statusData: cbStatusData.Text != "" ? cbStatusData.Text : "Mais recentes", statusPagamento: cbStatusPagamento.Text);
        }

        private void btnBolsista_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("cadastrar"))
                {
                    bool statusCadastro = bolsistaController.CadastrarBolsa(idAluno: int.Parse(txbIDAluno.Text), desconto: cbDesconto.Text);

                    if (statusCadastro)
                    {
                        btnBolsista.Visible = false;
                        btnAtualizarBolsa.Visible = true;
                        btnRemoverBolsa.Visible = true;
                        CarregarDadosAlunos(pesquisa: txbPesquisa.Text, curso: cbCurso.Text);
                        MessageBox.Show("Bolsa cadastrada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarBolsa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos("atualizar"))
                {
                    bool statusAtualizacao = bolsistaController.AtualizarBolsa(idAluno: int.Parse(txbIDAluno.Text), desconto: cbDesconto.Text);

                    if (statusAtualizacao)
                    {
                        CarregarDadosAlunos(pesquisa: txbPesquisa.Text, curso: cbCurso.Text);
                        MessageBox.Show("Bolsa atualizada com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverBolsa_Click(object sender, EventArgs e)
        {
            try
            {
                var escolha = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (escolha == DialogResult.Yes)
                {
                    if (bolsistaController.RemoverBolsa(idAluno: int.Parse(txbIDAluno.Text)))
                    {
                        cbDesconto.SelectedIndex = -1;
                        btnBolsista.Visible = true;
                        btnAtualizarBolsa.Visible = false;
                        btnRemoverBolsa.Visible = false;
                        CarregarDadosAlunos(pesquisa: txbPesquisa.Text, curso: cbCurso.Text);
                        MessageBox.Show("Bolsa removida com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var escolha = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (escolha == DialogResult.Yes)
                {
                    if (alunoController.ExcluirAluno(ra: int.Parse(txbRA.Text)) && usuarioController.ExcluirUsuario(idUsuario: int.Parse(txbIDUsuario.Text)))
                    {
                        panelDados.Visible = false;
                        CarregarDadosAlunos(pesquisa: txbPesquisa.Text, curso: cbCurso.Text);
                        MessageBox.Show("Aluno excluído com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            usuarioController.VoltarParaPaginaInicial(usuarioFuncionario, this);
        }

        private void CarregarDadosAlunos(String pesquisa, String curso)
        {
            dgvAlunos.DataSource = null;
            dgvAlunos.Rows.Clear();
            dgvAlunos.Refresh();
            alunoController.ListarAlunos(pesquisa, curso).ForEach(a => dgvAlunos.Rows.Add(a.Nome, a.RA, a.DataNascimento, a.CPF, a.CursoMatriculado, a.Contato, 
                                                                                          bolsistaController.VerificarSeEhBolsista(a.IdAluno) ? "Sim" : "Não", 
                                                                                          usuarioController.BuscarUsuarioPorId(a.IdUsuario).Email, 
                                                                                          mensalidadeController.BuscarTotalMensalidadesAtrasadasAluno(a.IdAluno), 
                                                                                          mensalidadeController.BuscarValorTotalDividasAluno(a.IdAluno), a.IdAluno, 
                                                                                          a.IdUsuario, bolsistaController.BuscarBolsaDesconto(a.IdAluno)));
        }

        private void CarregarDadosMensalidadesAluno(String statusData, String statusPagamento)
        {
            dgvMensalidades.DataSource = null;
            dgvMensalidades.Rows.Clear();
            dgvMensalidades.Refresh();
            mensalidadeController.ListarMensalidadesAluno(statusData, statusPagamento, idAluno: int.Parse(txbIDAluno.Text))
                .ForEach(mensalidade => dgvMensalidades.Rows.Add(mensalidade.MesMensalidade, mensalidade.Valor, mensalidade.DataVencimento,
                                                                 mensalidade.Pago ? "Sim" : "Não", mensalidade.DataPagamento));
        }

        private void SelecionarAluno(DataGridViewRow row)
        {
            txbNome.Text = row.Cells[0].Value.ToString();
            txbRA.Text = row.Cells[1].Value.ToString();
            txbNascimento.Text = Convert.ToDateTime(row.Cells[2].Value).ToString("dd/MM/yyyy");
            txbCPF.Text = row.Cells[3].Value.ToString();
            txbCurso.Text = row.Cells[4].Value.ToString();
            txbContato.Text = row.Cells[5].Value.ToString();
            txbEmail.Text = row.Cells[7].Value.ToString();
            txbIDAluno.Text = row.Cells[10].Value.ToString();
            txbIDUsuario.Text = row.Cells[11].Value.ToString();

            CarregarDadosMensalidadesAluno(statusData: "Mais recentes", statusPagamento: "Todas");
        }

        private Boolean ValidarCampos(String acao)
        {
            if (cbDesconto.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha o campo de desconto antes de " + acao + " a bolsa",
                                "Falha ao " + acao + " a bolsa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
