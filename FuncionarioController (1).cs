using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet("RetornarDadosFuncionario")]

        public string RetornarDadosFuncionario(string nomeFuncionario,
            string sexoFuncionario,
            int idadeFuncionario,
            double salarioFuncionario)

        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario; 
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;

            return $"Dados Funcionario\r\n" +
                $"Nome Funcionario:{funcionario.nome}\r\n" +
                $"Sexo do Funcionario:{funcionario.sexo}\r\n" +
                $"Idade do Funcionario:{funcionario.idade}\r\n" +
                $"Salario do Funcionario:{funcionario.salario}";
        }
        [HttpPost("CalcularDecimoTerceiro")]
        public string CalcularDecimoTerceiro(string nomeFuncionario,
                                            string sexoFuncionario,
                                            int idadeFuncionario,
                                            double salarioFuncionario,
                                            int meses)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;
            double decimoTerceiro = funcionario.CalcularDecimoTerceiro(meses);

            return $"Calculo do Decimo Terceiro do Funcionário\r\n" +
               $"Nome Funcionario:{funcionario.nome}\r\n" +
               $"Sexo do Funcionario:{funcionario.sexo}\r\n" +
               $"Idade do Funcionario:{funcionario.idade}\r\n" +
               $"Salario do Funcionario:{funcionario.salario}\r\n" +
               $"Décimo Terceiro R${decimoTerceiro}";

        }
        [HttpPost("CalcularFerias")]
        public string CalcularFerias(string nomeFuncionario,
                                            string sexoFuncionario,
                                            int idadeFuncionario,
                                            double salarioFuncionario
                                            )
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncionario;
            funcionario.salario = salarioFuncionario;
            double ferias = funcionario.CalcularFerias();

            return $"Calculo do Decimo Terceiro do Funcionário\r\n" +
               $"Nome Funcionario:{funcionario.nome}\r\n" +
               $"Sexo do Funcionario:{funcionario.sexo}\r\n" +
               $"Idade do Funcionario:{funcionario.idade}\r\n" +
               $"Salario do Funcionario:{funcionario.salario}\r\n" +
               $"Dias de ferias: {ferias}";
        }
    }
}
