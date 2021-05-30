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
    public partial class MensalidadesAluno : Form
    {
        AlunoModel usuarioAluno;
        MensalidadeController mensalidadeController = new MensalidadeController();
        public MensalidadesAluno(AlunoModel aluno)
        {
            InitializeComponent();
            usuarioAluno = aluno;
        }

        private void MensalidadesAluno_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = usuarioAluno.Nome;
            CarregarDadosMensalidadesAluno(statusData: "Mais recentes", statusPagamento: "Todas");
        }

        private void cbStatusData_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosMensalidadesAluno(statusData: cbStatusData.Text, statusPagamento: cbStatusPagamento.Text != "" ? cbStatusPagamento.Text : "Todas");
        }

        private void cbStatusPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosMensalidadesAluno(statusData: cbStatusData.Text != "" ? cbStatusData.Text : "Mais recentes", statusPagamento: cbStatusPagamento.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            usuarioController.VoltarParaPaginaInicial(usuarioAluno, this);
        }

        private void CarregarDadosMensalidadesAluno(String statusData, String statusPagamento)
        {
            dgvMensalidadesAluno.DataSource = null;
            dgvMensalidadesAluno.Rows.Clear();
            dgvMensalidadesAluno.Refresh();
            mensalidadeController.ListarMensalidadesAluno(statusData, statusPagamento, idAluno: usuarioAluno.IdAluno)
                .ForEach(mensalidade => dgvMensalidadesAluno.Rows.Add(mensalidade.Valor, mensalidade.MesMensalidade, mensalidade.DataVencimento, 
                                                                      mensalidade.Pago ? "Sim" : "Não", mensalidade.DataPagamento));
        }
    }
}
