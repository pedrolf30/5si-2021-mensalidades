using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class FuncionarioController
    {
        public FuncionarioModel BuscarFuncionario(Int32 idUsuario)
        {
            FuncionarioModel funcionario = new FuncionarioModel(idUsuario);
            return funcionario.BuscarFuncionario();
        }

        public Boolean CadastrarFuncionario(Int32 idUsuario, String nome, DateTime dataNascimento, String cpf, String contato)
        {
            FuncionarioModel funcionario = new FuncionarioModel(idUsuario, nome, dataNascimento, cpf, contato);
            return funcionario.CadastrarFuncionario();
        }

        public Boolean AtualizarFuncionario(Int32 idUsuario, String nome, DateTime dataNascimento, String cpf, String contato)
        {
            FuncionarioModel funcionario = new FuncionarioModel(idUsuario, nome, dataNascimento, cpf, contato);
            return funcionario.AtualizarFuncionario();
        }
    }
}
