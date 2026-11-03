using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Informe os 10 números:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número para pesquisar: ");
        int pesquisa = int.Parse(Console.ReadLine());

        int quantidade = 0;

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == pesquisa)
            {
                quantidade++;
            }
        }

        if (quantidade > 0)
        {
            Console.WriteLine("Número encontrado.");
            Console.WriteLine("Quantidade de ocorrências: " + quantidade);
            Console.Write("Posições: ");

            int posicaoAtual = 0;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == pesquisa)
                {
                    if (posicaoAtual > 0)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i + 1);
                    posicaoAtual++;
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Número não encontrado.");
            Console.WriteLine("Quantidade de ocorrências: 0");
        }
    }
}
