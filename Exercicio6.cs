int[] numeros = new int [10];

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"informe o numero {i+1}  ");
    numeros[i] = Convert.ToInt16(Console.ReadLine());

}
Console.WriteLine($"A ordem original é: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($" {numeros[i]}");
}
Console.WriteLine($"A ordem inversa é: ");
for (int i = 9; i >= 0; i--)
{
    Console.WriteLine($"{numeros[i]} ");
}