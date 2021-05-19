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
    public partial class ListagemAlunos : Form
    {
        public ListagemAlunos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNome.Visible = true;
            txbNome.Visible = true;
            lblContato.Visible = true;
            txbContato.Visible = true;
            lblRA.Visible = true;
            txbRA.Visible = true;
            lblCPF.Visible = true;
            txbCPF.Visible = true;
            lblEmail.Visible = true;
            txbEmail.Visible = true;
            lblCurso.Visible = true;
            txbCurso.Visible = true;
            lblNascimento.Visible = true;
            txbNascimento.Visible = true;

            qtdValorTotalDividas.Visible = true;
            panelQtdMensalidadesAtrasadas.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialFuncionario paginaInicialFuncionario = new PaginaInicialFuncionario();
            paginaInicialFuncionario.Show();
            this.Visible = false;
        }
    }
}
