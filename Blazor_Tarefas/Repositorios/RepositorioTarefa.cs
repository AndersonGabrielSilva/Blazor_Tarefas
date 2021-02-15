using Blazor_Tarefas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Tarefas.Repositorios
{
    public class RepositorioTarefa : IRepositorio<Tarefa>
    {
        public List<Tarefa> ObterLista()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {
                    Id= 9874564,
                    Descricao = "Fazer o curso de Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2019-08-11")

                },
                  new Tarefa
                {
                    Id= 75315985,
                    Descricao = "Estudar Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2020-08-11")

                }
            };
        }
    }
}
