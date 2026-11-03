using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[10];
        double soma = 0;
        double maior;
        double menor;

        Console.WriteLine("Informe os 10 números:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = double.Parse(Console.ReadLine());
        }

        maior = numeros[0];
        menor = numeros[0];

        for (int i = 0; i < 10; i++)
        {
            soma += numeros[i];

            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        double media = soma / 10;

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Média: " + media.ToString("F2"));
        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Menor: " + menor);
    }
}
