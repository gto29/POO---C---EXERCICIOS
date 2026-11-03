using Microsoft.AspNetCore.Mvc;

namespace WEBApiExercicioRevisaoLogica.Controllers
{
    public class DescontoLojaController : Controller
    {
        [HttpPost("DescontoLoja")]
        public string DescontoLoja(double valorCompraPessoa, bool cadastroClienteUsuario)
        {

            // Declaração de Variáveis \\

            double valorCompra, valorDesconto;
            bool cadastroCliente;
            string percentualDesconto = "";

            // Entrada \\

            valorCompra = valorCompraPessoa;
            cadastroCliente = cadastroClienteUsuario;

            // Processamento \\

            percentualDesconto = (valorCompra > 1000) && (cadastroCliente == true) ? "Desconto de 20%" :
                     (valorCompra > 1000) ? "Desconto de 15%" :
                     (valorCompra >= 500 && valorCompra <= 1000) && (cadastroCliente == true) ? "Desconto de 15%" :
                     (valorCompra >= 500 && valorCompra <= 1000) ? "Desconto de 10%" :
                     (valorCompra < 500) && (cadastroCliente == true) ? "Desconto de 10%" : "Desconto de 5%";

            if (valorCompra > 1000)
            {

                if (cadastroCliente == true)
                {

                    valorDesconto = valorCompra * 0.20;
                    valorCompra -= valorDesconto;

                }
                else
                {

                    valorDesconto = valorCompra * 0.15;
                    valorCompra -= valorDesconto;

                }

            }
            else if (valorCompra >= 500 && valorCompra <= 1000)
            {

                if (cadastroCliente == true)
                {

                    valorDesconto = valorCompra * 0.15;
                    valorCompra -= valorDesconto;

                }
                else
                {

                    valorDesconto = valorCompra * 0.10;
                    valorCompra -= valorDesconto;

                }

            }
            else
            {

                if (cadastroCliente == true)
                {

                    valorDesconto = valorCompra * 0.10;
                    valorCompra -= valorDesconto;

                }
                else
                {

                    valorDesconto = valorCompra * 0.05;
                    valorCompra -= valorDesconto;

                }
            }

            // Saída \\

            return $"Percentual de Desconto: {percentualDesconto}\n" +
                   $"Valor do Desconto: R${valorDesconto}\n" +
                   $"Valor Final: R${valorCompra}\n";
        }
    }
}
