using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class EnderecoController
    {
        public List<EnderecoModel> ListarEnderecosAluno(Int32 idAluno)
        {
            EnderecoModel endereco = new EnderecoModel();
            return endereco.ListarEnderecosAluno(idAluno);
        }

        public Boolean CadastrarEndereco(Int32 idAluno, String rua, Int32 numero, String cep, String bairro, String cidade, String estado, String complemento)
        {
            EnderecoModel endereco = new EnderecoModel(rua, numero, cep, bairro, cidade, estado, complemento);
            return endereco.CadastrarEndereco(idAluno);
        }

        public Boolean AtualizarEndereco(Int32 idEndereco, String rua, Int32 numero, String cep, String bairro, String cidade, String estado, String complemento)
        {
            EnderecoModel endereco = new EnderecoModel(idEndereco, rua, numero, cep, bairro, cidade, estado, complemento);
            return endereco.AtualizarEndereco();
        }

        public Boolean ExcluirEndereco(Int32 idEndereco)
        {
            EnderecoModel endereco = new EnderecoModel(idEndereco);
            return endereco.ExcluirEndereco();
        }
    }
}
