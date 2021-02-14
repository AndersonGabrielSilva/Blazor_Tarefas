
namespace Blazor_Tarefas.Shared
{
   /*
    * Cada componente possui alguns Metodos especiais que podemos sobrescrever para capturar o ciclo de vida do componente

   *  Assim podemos execultar código em determinados pontos do ciclo de Vida de um Componente
   
---------------------------------------------------------------------------------------------------------------------------------------
   *  O Ciclo de Vida de um componente Blazor possui as seguintes etapas e métodos:
   

     1 - Inicialização do Componente - OnInitializedAsync e OnInitialized
         - São execultados apenas uma unica vez

     2 - Recpção de Parametos do Pai - OnParametersSetAsync e OnParametersSet
         - São execultados após a inicialização do componente e cada vez que o componente for renderizado.
         - Utilizamos este metodo para quando necessitamos execultas alguns metodos que dependam que os valors dos parametros sejam preenchidos

     3 - Término da Renderização do Componente - OnAfterRenderAsync e OnAfterRender
         - São execultados após a renderização do componente.
         - São execulktados CADA VEZ que o componente é renderizado.
         - Use esses métodos para execultar etapas de inicialização adicionais usando o contéudo 
           renderizado como ativar bibliotecas JavaScript que operam nos elementos DOM.
         - Este metodo pode recever um parametro do tipo bool que informa se a renderização do componente esta ocorrendo na primeira vez.
            EX: protect override async OnAfterRenderAsync(bool firstRender)
                {
                    if(firstRender) //É defino como true na primeira vez que a instancia é invocada
                    {
                        await ....
                    }
                }

     4 - Desconstrução do Componente - IDisposable/Dispose
         - 


    * Em cada uma destas etapas do ciclo de vida temos a execulção de metodos especiais que podemos usar segundo nossas necessidades
 ----------------------------------------------------------------------------------------------------------------------------------------      
    
    */
}
