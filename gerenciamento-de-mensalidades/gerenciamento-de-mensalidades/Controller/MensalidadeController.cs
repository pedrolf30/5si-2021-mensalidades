using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciamento_de_mensalidades.Model;

namespace gerenciamento_de_mensalidades.Controller
{
    class MensalidadeController
    {
        public List<MensalidadeModel> ListarMensalidadesAluno(String statusData, String statusPagamento, Int32 idAluno)
        {
            return MensalidadeModel.ListarMensalidadesAluno(statusData, statusPagamento, idAluno);
        }

        public Int32 BuscarTotalMensalidadesAtrasadasAluno(Int32 idAluno)
        {
            return MensalidadeModel.BuscarTotalMensalidadesAtrasadasAluno(idAluno);
        }

        public Int32 BuscarTotalMensalidadesAtrasadas()
        {
            return MensalidadeModel.BuscarTotalMensalidadesAtrasadas();
        }

        public Double BuscarValorTotalDividasAluno(Int32 idAluno)
        {
            return MensalidadeModel.BuscarValorTotalDividasAluno(idAluno);
        }

        public Double BuscarValorTotalDividas()
        {
            return MensalidadeModel.BuscarValorTotalDividas();
        }

        public Int32 BuscarTotalAlunosEndividados()
        {
            return MensalidadeModel.BuscarTotalAlunosEndividados();
        }
    }
}
