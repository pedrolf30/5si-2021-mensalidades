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
    public partial class CadastroAluno : Form
    {
        AlunoController alunoController = new AlunoController();
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    bool statusCadastro = alunoController.CadastrarAluno(nome: txbNome.Text, ra: int.Parse(txbRA.Text), dataNascimento: dtpNascimento.Value, 
                                                                         cpf: txbCPF.Text, cursoMatriculado: cbCurso.Text, contato: txbContato.Text);

                    if (statusCadastro)
                    {
                        MessageBox.Show("Aluno cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ValidarCampos()
        {
            if (txbNome.Text != "" && txbRA.Text != "" && txbCPF.Text != "" && txbContato.Text != "" && cbCurso.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar", "Falha ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            
        }
    }
}
