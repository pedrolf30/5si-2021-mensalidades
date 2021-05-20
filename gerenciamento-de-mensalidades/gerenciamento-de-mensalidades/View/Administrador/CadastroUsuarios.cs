using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_mensalidades.View.Administrador
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaInicialAdmin homePageAdmin = new PaginaInicialAdmin();
            homePageAdmin.Show();
            this.Visible = false;
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            panelCF.Visible = true;
            btnCF.Visible = false;
            panelFuncionario.Visible = false;
            panelAluno.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            panelCF.Visible = false;
            btnCF.Visible = true;
            MessageBox.Show("Funcionário cadastrado com sucesso!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelFuncionario.Visible = true;
            panelCF.Visible = false;
            panelAluno.Visible = false;
        }

        private void btnAtivarFuncionario_Click(object sender, EventArgs e)
        {
            //TO DO - Implementar logica de if para alternar nome do botão/msgbox ao clickar Ativar/Desativar cliente

            MessageBox.Show("Funcionário desativado com sucesso");
        }
    }
}
