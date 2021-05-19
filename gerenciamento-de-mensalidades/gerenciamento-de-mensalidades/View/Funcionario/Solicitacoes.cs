using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Funcionario
{
    public partial class Solicitacoes : Form
    {
        public Solicitacoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario();
            paginaInicialFuncionario.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAluno.Visible = true;
            lblEmail.Visible = true;
            lblContato.Visible = true;
            lblCategoria.Visible = true;
            lblStatus.Visible = true;
            lblAtendimento.Visible = true;
            lblDtSolicitacao.Visible = true;
            lblDescricao.Visible = true;
            lblFeedback.Visible = true;
            lblCurso.Visible = true;

            txbAluno.Visible = true;
            txbEmail.Visible = true;
            txbContato.Visible = true;
            cbCategoria.Visible = true;
            cbStatus.Visible = true;
            cbAtendimento.Visible = true;
            txtDtSolicitacao.Visible = true;
            rtbFeedback.Visible = true;
            rtbDescricao.Visible = true;
            txbCurso.Visible = true;

            btnSalvar.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblAluno.Visible = false;
            lblEmail.Visible = false;
            lblContato.Visible = false;
            lblCategoria.Visible = false;
            lblStatus.Visible = false;
            lblAtendimento.Visible = false;
            lblDtSolicitacao.Visible = false;
            lblDescricao.Visible = false;
            lblFeedback.Visible = false;
            lblCurso.Visible = false;

            txbAluno.Visible = false;
            txbEmail.Visible = false;
            txbContato.Visible = false;
            cbCategoria.Visible = false;
            cbStatus.Visible = false;
            cbAtendimento.Visible = false;
            txtDtSolicitacao.Visible = false;
            rtbFeedback.Visible = false;
            rtbDescricao.Visible = false;
            txbCurso.Visible = false;

            btnSalvar.Visible = false;
            MessageBox.Show("Solicitação salva com sucesso!");
        }
    }
}
