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
        UsuarioModel currentUser;
        public SolicitacoesAluno(UsuarioModel usuario)
        {
            InitializeComponent();
            currentUser = usuario;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(currentUser, this);
        }

        private void btnCriarSolicitacao_Click(object sender, EventArgs e)
        {
            lblCategoria.Visible = true;
            lblDesc.Visible = true;
            cbCategoria.Visible = true;
            rtbDescricao.Visible = true;
            rtbDescricao.ReadOnly = false;
            btnEnviar.Visible = true;

            lblDtSolicitacao.Visible = false;
            lblStatus.Visible = false;
            lblAtendidoPor.Visible = false;
            txbCategoria.Visible = false;
            txbDtSolicitacao.Visible = false;
            txbStatus.Visible = false;
            txbAtendidoPor.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblCategoria.Visible = false;
            lblDesc.Visible = false;
            cbCategoria.Visible = false;
            rtbDescricao.Visible = false;
            btnEnviar.Visible = false;
            rtbDescricao.ReadOnly = true;
            MessageBox.Show("Solicitação enviada com sucesso!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbCategoria.Visible = false;
            lblCategoria.Visible = true;
            lblDesc.Visible = true;
            lblDtSolicitacao.Visible = true;
            lblStatus.Visible = true;
            lblAtendidoPor.Visible = true;
            txbCategoria.Visible = true;
            rtbDescricao.Visible = true;
            txbDtSolicitacao.Visible = true;
            txbStatus.Visible = true;
            txbAtendidoPor.Visible = true;

            btnEnviar.Visible = false;
            rtbDescricao.ReadOnly = true;

        }
    }
}
