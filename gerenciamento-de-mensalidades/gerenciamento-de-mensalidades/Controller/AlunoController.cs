using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class AlunoController
    {
        public AlunoModel BuscarAluno(Int32 idUsuario)
        {
            AlunoModel funcionario = new AlunoModel(idUsuario);
            return funcionario.BuscarAluno();
        }

        public Boolean CadastrarAluno(Int32 idUsuario, String nome, Int32 ra, DateTime dataNascimento, String cpf, String cursoMatriculado, String contato)
        {
            AlunoModel funcionario = new AlunoModel(idUsuario, nome, ra, dataNascimento, cpf, cursoMatriculado, contato);
            return funcionario.CadastrarAluno();
        }

        public Boolean AtualizarAluno(Int32 idUsuario, String nome, Int32 ra, DateTime dataNascimento, String cpf, String cursoMatriculado, String contato)
        {
            AlunoModel funcionario = new AlunoModel(idUsuario, nome, ra, dataNascimento, cpf, cursoMatriculado, contato);
            return funcionario.AtualizarAluno();
        }
    }
}
