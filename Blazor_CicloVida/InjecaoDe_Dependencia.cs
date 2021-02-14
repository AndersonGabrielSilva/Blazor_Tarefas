

namespace Blazor_CicloVida
{
  /*
 --------------------------------------------------------------------------------------------------------------------

    *As Maneiras mais comuns de implementar a Injeção de dependência são:
        - Usar a diretiva @inject, na pagina razor
            ex: @page "/"
                @inject HttpClient http
                
        - Usar uma propriedade, batando apenas decorar a propriedade com o atributo Inject
            ex: 
                [Inject] 
                public HttpClient http {get; set;}

        - Usar no construtor da classe, como no AspNet MVC   

---------------------------------------------------------------------------------------------------------------------

    * O Blazor oferece Três serviçoes por padrão que podemos utilizar
    
        1 - HttpClient : Usado para realizar requisiçoes Http a um servidor.

        2 - IJSRuntime : Usado para trabalhar com JavaScript.

        3 - NavigationManager - Permite trabalhar com a navegação do usuário.


    * Conceito de Tempo de Vida de um Serviço
    
        1 - Scoped : O tempo de vida do serviço esta vinculado ao 'contexto' que para web é a requisição HTTP. Assim
                     no lado do cliente este tempo de vida se comporta como um 'Singleton'.


        2 - Singleton : O DI cria uma 'única intância do serviço', que será compartilhado por todos os componentes
                        da aplicação onde o serviço for injetado.


        3 - Transient - Toda vez que o componente solicitar uma instância de um serviço Transiente ao DI, ele irá receber 
                        uma nova intância do serviço.
        

        Exemplo de configuração do Serviço: 
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Demo1>();

            services.AddSingleton<Servico1>();

            services.AddTransient<ITeste,Teste>(); Interface / Classe

        }
        
 ----------------------------------------------------------------------------------------------------------------------    
   */
}
