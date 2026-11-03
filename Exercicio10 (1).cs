using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        int quantidadePositivos = 0;
        int quantidadeNegativos = 0;
        int quantidadeZeros = 0;

        int somaPositivos = 0;
        int somaNegativos = 0;

        Console.WriteLine("Informe os 10 números:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > 0)
            {
                quantidadePositivos++;
                somaPositivos += numeros[i];
            }
            else if (numeros[i] < 0)
            {
                quantidadeNegativos++;
                somaNegativos += numeros[i];
            }
            else
            {
                quantidadeZeros++;
            }
        }

        Console.WriteLine("Quantidade de positivos: " + quantidadePositivos);
        Console.WriteLine("Quantidade de negativos: " + quantidadeNegativos);
        Console.WriteLine("Quantidade de zeros: " + quantidadeZeros);
        Console.WriteLine("Soma dos positivos: " + somaPositivos);
        Console.WriteLine("Soma dos negativos: " + somaNegativos);
    }
}
