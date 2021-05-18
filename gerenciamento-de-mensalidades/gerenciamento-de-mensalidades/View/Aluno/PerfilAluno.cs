using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Aluno
{
    public partial class PerfilAluno : Form
    {
        public PerfilAluno()
        {
            InitializeComponent();
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            lblSenha1.Visible = true;
            lblSenha2.Visible = true;
            txbSenha1.Visible = true;
            txbSenha2.Visible = true;
            btnSalvar.Visible = true;
            btnTrocaSenha.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblSenha1.Visible = false;
            lblSenha2.Visible = false;
            txbSenha1.Visible = false;
            txbSenha2.Visible = false;
            btnSalvar.Visible = false;
            btnTrocaSenha.Visible = true;
            MessageBox.Show("Senha alterada com sucesso!");
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
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

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
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
            MessageBox.Show("Dados alterados com sucesso!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
            btnDeletar.Visible = true;
            btnAdicionar.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados adicionados com sucesso!");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnDeletar.Visible = false;
            btnAdicionar.Visible = true;
            MessageBox.Show("Dados deletados com sucesso!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnDeletar.Visible = false;
            btnAdicionar.Visible = true;
            MessageBox.Show("Dados editados com sucesso!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialAluno paginaInicialAluno = new PaginaInicialAluno();
            paginaInicialAluno.Show();
            this.Visible = false;
        }
    }
}
