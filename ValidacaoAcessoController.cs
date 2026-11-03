using Microsoft.AspNetCore.Mvc;

namespace ApiWebExercicioRevisaoLogica.Controllers
{
    public class ValidacaoAcessoController : Controller
    {
        [HttpPost("ValidacaoAcessoApi")]
        public string ValidacaoAcessoApi(int idadeUsuario, string SenhaUsuarioApi, bool acessoPermitidoUsuario)
        {

            //entrada
            int idade;
            string senhaUsuario;
            bool permissaoAcesso;

            idade = idadeUsuario;
            senhaUsuario = SenhaUsuarioApi;
            permissaoAcesso = acessoPermitidoUsuario;


            //processamento
            if ((idade >= 18) && (senhaUsuario == "guto2909") && (permissaoAcesso == true))
            {
                return "Aceso concedido" + $"sua idade é {idade}";
            }
            else return "acesso negado";
            
                
            

            //saida
            
        }
    }
}
