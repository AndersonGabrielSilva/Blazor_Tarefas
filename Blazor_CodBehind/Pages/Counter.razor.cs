using Blazor_CodBehind.Servicos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CodBehind.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Inject]
        protected Servico1 Servico { get; set; }

        protected void IncrementCount()
        {
            currentCount++;
            Servico.Valor = currentCount;
        }
    }
}
