using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_InjecaoDependencia_Core_3.Servicos
{
    //A instancia está amarrada ao contexto
    public class ServicoScoped
    {
        public int Valor { get; set; }
    }
}
