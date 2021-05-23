using Microsoft.Web.Services3.Referral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamento_de_mensalidades.Enum
{
    public enum TipoUsuario
    {
        Deactivated = -1,
        Undefined = 0,
        Administrador = 1,
        Funcionario = 2,
        Aluno = 3
    }
}
