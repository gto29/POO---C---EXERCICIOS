// Declaração de Variáveis \\

double valorCompra, valorDesconto;
bool cadastroCliente;
string percentualDesconto = "";

// Entrada \\

Console.WriteLine("Insira o valor da sua compra abaixo.");
valorCompra = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O cliente está cadastrado? Digite 'true' para SIM e 'false' para NÃO.");
cadastroCliente = Convert.ToBoolean(Console.ReadLine());

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

Console.WriteLine($"Percentual de Desconto: {percentualDesconto}");
Console.WriteLine($"Valor do Desconto: R${valorDesconto}");
Console.WriteLine($"Valor Final: R${valorCompra}");
Console.ReadKey();