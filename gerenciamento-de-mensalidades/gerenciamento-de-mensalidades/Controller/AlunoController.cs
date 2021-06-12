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
        public List<AlunoModel> ListarAlunos(String pesquisa, String curso)
        {
            AlunoModel aluno = new AlunoModel();
            return aluno.ListarAlunos(pesquisa, curso);
        }

        public AlunoModel BuscarAlunoPorRA(Int32 ra)
        {
            AlunoModel aluno = new AlunoModel(ra);
            return aluno.BuscarAlunoPorRA();
        }

        public AlunoModel BuscarAlunoPorIdUsuario(Int32 idUsuario)
        {
            AlunoModel aluno = new AlunoModel();
            aluno.IdUsuario = idUsuario;
            return aluno.BuscarAlunoPorIdUsuario();
        }

        public Boolean CadastrarAluno(String nome, Int32 ra, DateTime dataNascimento, String cpf, String cursoMatriculado, String contato)
        {
            AlunoModel aluno = new AlunoModel(nome, ra, dataNascimento, cpf, cursoMatriculado, contato);
            return aluno.CadastrarAluno();
        }

        public Boolean AtualizarAluno(Int32 idUsuario, String nome, Int32 ra, DateTime dataNascimento, String cpf, String cursoMatriculado, String contato)
        {
            AlunoModel aluno = new AlunoModel(idUsuario, nome, ra, dataNascimento, cpf, cursoMatriculado, contato);
            return aluno.AtualizarAluno();
        }

        public Boolean ExcluirAluno(Int32 ra)
        {
            AlunoModel aluno = new AlunoModel(ra);
            return aluno.ExcluirAluno();
        }

        public Boolean VincularUsuarioAluno(Int32 idUsuario, Int32 ra)
        {
            AlunoModel aluno = new AlunoModel(idUsuario, ra);
            return aluno.VincularUsuarioAluno();
        }
    }
}
