using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class BolsistaController
    {
        public Boolean VerificarSeEhBolsista(Int32 idAluno)
        {
            BolsistaModel bolsista = new BolsistaModel(idAluno);
            return bolsista.VerificarSeEhBolsista();
        }

        public String BuscarBolsaDesconto(Int32 idAluno)
        {
            BolsistaModel bolsista = new BolsistaModel(idAluno);
            return bolsista.BuscarBolsaDesconto();
        }

        public Boolean CadastrarBolsa(Int32 idAluno, String desconto)
        {
            BolsistaModel bolsista = new BolsistaModel(idAluno, desconto);
            return bolsista.CadastrarBolsa();
        }

        public Boolean AtualizarBolsa(Int32 idAluno, String desconto)
        {
            BolsistaModel bolsista = new BolsistaModel(idAluno, desconto);
            return bolsista.AtualizarBolsa();
        }

        public Boolean RemoverBolsa(Int32 idAluno)
        {
            BolsistaModel bolsista = new BolsistaModel(idAluno);
            return bolsista.RemoverBolsa();
        }
    }
}
