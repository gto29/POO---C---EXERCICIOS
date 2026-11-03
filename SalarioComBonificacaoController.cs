using Microsoft.AspNetCore.Mvc;

namespace ApiWebExercicioRevisaoLogica.Controllers;
    public class SalarioComBonificacaoController : Controller
    {
    [HttpPost("CalcularSalarioBonificacao")]
        public string CalcularSalarioBonificacao (double salarioFuncionarioApi, int tempoEmpresaApi)
        {
        double salario, bonificacaoEmpresa, salarioFinal;
        int tempoEmpresa;
        string percentualBonificacaoEmpresa;

        salario = salarioFuncionarioApi;
        tempoEmpresa = tempoEmpresaApi;


        //Se/Senao
        percentualBonificacaoEmpresa = (salario < 2000) && (tempoEmpresa > 10) ? "25%" :
(salario < 2000) ? "20%" :
(salario >= 2000 && salario < 5000) && (tempoEmpresa > 10) ? "15%" :
(salario >= 2000) && (salario < 5000) ? "10%" :
(salario > 5000) && (tempoEmpresa > 10) ? "10%" : "5%";




        if (salario < 2000)
        {

            if (tempoEmpresa > 10)
            {
                bonificacaoEmpresa = salario * 0.25;
                salario += bonificacaoEmpresa;

            }
            else
            {
                bonificacaoEmpresa = salario * 0.2;
                salario += bonificacaoEmpresa;

            }
        }

        else if (salario >= 2000 && salario <= 5000)
        {
            if (tempoEmpresa > 10)
            {
                bonificacaoEmpresa = salario * 0.25;
                salario += bonificacaoEmpresa;

            }
            else
            {
                bonificacaoEmpresa = salario * 0.2;
                salario += bonificacaoEmpresa;

            }
        }
        else if (salario > 5000)
        {
            bonificacaoEmpresa = salario * 0.25;
            salario += bonificacaoEmpresa;


        }
        return $"Seu salario final é: {salario}\r\n"  +
            $"Valor da bonificação{percentualBonificacaoEmpresa}\r\n" +
             $"Seu tempo na empresa é : {tempoEmpresa}\r\n";
            


        
    }
    }

