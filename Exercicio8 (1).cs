using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int quantidadePares = 0;
        int quantidadeImpares = 0;
        int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Informe os 10 números:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                quantidadePares++;
                somaPares += numeros[i];
            }
            else
            {
                quantidadeImpares++;
                somaImpares += numeros[i];
            }
        }

        Console.WriteLine("Quantidade de pares: " + quantidadePares);
        Console.WriteLine("Quantidade de ímpares: " + quantidadeImpares);
        Console.WriteLine("Soma dos pares: " + somaPares);
        Console.WriteLine("Soma dos ímpares: " + somaImpares);
    }
}
