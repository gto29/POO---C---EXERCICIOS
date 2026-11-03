using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploEncapsulamentoContaBancariaController : Controller
    {
        [HttpGet("RetornarDadosConta")]
        public string RetornarDadosConta(int numeroConta, 
                                        string nomeTitular)
                                       
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;
           // contaBancaria.Saldo = saldoConta;
            return contaBancaria.RetornarDadosConta();
        }

        [HttpPost("Depositar")]
        public string Depositar(int numeroConta,
                                string nomeTitular,
                                double valorDeposito)
        {

            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;
            contaBancaria.Depositar(valorDeposito);
            return contaBancaria.RetornarDadosConta();
        }
        [HttpPost("Sacar")]
        public string Sacar(int numeroConta,
                                string nomeTitular,
                                double valorSaque)
        {

            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;
            if(valorSaque > contaBancaria.Saldo)
            {
                return "O valor não pode ser sacado, seu saldo é insuficiente";
            }
            else
            {
                contaBancaria.Sacar(valorSaque);
                return contaBancaria.RetornarDadosConta();
            }
            
        }

    }
}
