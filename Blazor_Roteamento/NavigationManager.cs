
namespace Blazor_Roteamento
{

    /*
 -----------------------------------------------------------------------------------------------------------------

        * Navigation Manager : o Blazor fornece o serviço NavigationManager que 
            permite navegar para outras partes da aplicação usando código C#,
            via Navigation Manager podemos objet a url na qual esta o usuario e 
            podemos também direcionar o usuario para outra parte da nossa aplicação.

        Ex: @inject NavigationManager navigationManager

 -----------------------------------------------------------------------------------------------------------------

        * Membros fornecidos pelo NavigationManager:
        * 
            - Uri : Obtém a URL absoluta atual.

            - BaseURI : Obtém a URI base (com uma barra á direita) que pode ser anexada aos caminhos
                         de URI absoluta.

            - NavigateTo : Navega para a URL especificada, se "forceLoad" for verdadeiro.
                  - O roteamento do lado do cliente é ignorado.
                  - o navegador é forçado a carregar a nova pagina do servidor, idependente da URL ser tratada, 
                    normalmente pelo roteador do lado do cliente.
            
            - LocationChanged : Um evento que é acionado quando o local de navegação é alterado.

            - ToAbsoluteUri : Converte uma URL relativa em uma URL absoluto.

            - ToBaseRelativePath : Dado uma URL base (por exemplo, um URL retornado anteriormente por GetBaseUri),
                                   converte uma URL absoluta em uma URL relativa ao prefixo da URL base.
           
        

     */
}
