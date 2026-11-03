using Microsoft.AspNetCore.Mvc;

namespace ApiWebExercicioRevisaoLogica.Controllers
{
    public class FaixaEtariaController : Controller
    {
        [HttpGet("ClassificacaoFaixaEtaria")]
        public string ClassificacaoFaixaEtaria(int idadePessoa)
        {
            //DECLARACAO VARIAVEIS
            string classificacaoIdade = "", situacaoVoto = "";
            int idade;

            //ENTRADA
            idade = idadePessoa;

            //PROCESSAMENTO
            if ((idade > 0) && (idade < 13))
            {
                classificacaoIdade = "FAIXA ETARIA--CRIANÇA--";
                situacaoVoto = "Não obrigatório o voto";


            }
            else if ((idade >= 13) && (idade <= 17))
            {
                classificacaoIdade = "adolescente";
                if ((idade >= 16) && (idade <= 17))
                {
                    situacaoVoto = "Voto OPCIONAL";
                }
                else
                {
                    situacaoVoto = "Voto proibido";

                }
            }
            else if ((idade > 17) && (idade <= 59))
            {
                classificacaoIdade = "Adulto";
                situacaoVoto = "Voto obrigatório";
            }
            else
            {
                classificacaoIdade = "idoso";
                situacaoVoto = "Voto opcional";
            }


            //SAÍDA
            return $"A idade da pessoa é: {idade} ANOS \r\n" +
                $"A classificaçao desta pessoa é {classificacaoIdade} \r\n" +
                $"{situacaoVoto} \r\n";



        }
    }
}
