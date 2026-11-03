

using Exercicio1_POO.Model;

cliente cliente = new cliente();

Console.WriteLine("informe o cpf do cliente");
cliente.cpf = Console.ReadLine();

Console.WriteLine("informe o Nome do cliente");
cliente.nome = Console.ReadLine();

Console.WriteLine("informe o cnh do cliente");
cliente.cnh = Console.ReadLine();

Console.WriteLine($"Dados do cliente \r\n " +
    $"Nome: {cliente.nome}\r\n" +
    $"Cpf: {cliente.cpf}\r\n" +
    $"Cnh: {cliente.cnh}");


Carro carro = new Carro();

Console.WriteLine("informe o Id do Carro");
carro.idCarro = Convert.ToInt16(Console.ReadLine());


Console.WriteLine("informe a placa do Carro");
carro.placa = Console.ReadLine();

Console.WriteLine("informe o fabricante do Carro");
carro.fabricante = Console.ReadLine();

Console.WriteLine("informe o modelo do Carro");
carro.modelo = Console.ReadLine();

Console.WriteLine("informe o ano do Carro");
carro.ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe a diaria do Carro");
carro.valorDiaria = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Dados do carro \r\n " +
    $"ID carro: {cliente.nome}\r\n" +
    $"Placa do carro: {carro.placa}\r\n" +
    $"Modelo do carro: {carro.modelo}\r\n" +
    $"Ano do carro: {carro.ano}\r\n" +
    $"Diaria do carro: {carro.valorDiaria}" +
    $"A fabricante é: {carro.fabricante}");


