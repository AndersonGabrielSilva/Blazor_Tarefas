using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_InjecaoDependencia_Core_3.Servicos
{
    /// <summary>
    /// A Instancia é unica e compartilhada por todos os Client
    /// </summary>
    public class ServicoSingleton
    {
        public int Valor { get; set; }

    }
}
