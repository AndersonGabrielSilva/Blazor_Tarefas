using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_InjecaoDependencia_Core_3.Servicos
{
    /// <summary>
    /// A Cada Nova chamada é gerada uma nova instancia
    /// </summary>
    public class ServicoTransient
    {
        public int Valor { get; set; }

    }
}
