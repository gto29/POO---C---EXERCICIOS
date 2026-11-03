double nota1, nota2, mediaNota;
int faltas;
string situacaoAluno = "";




Console.WriteLine("digite a primeira nota");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite a segunda nota");
nota2 = Convert.ToDouble(Console.ReadLine());

mediaNota = (nota1 + nota2) / 2;

Console.WriteLine("digite o numero de faltas: ");
faltas = Convert.ToInt32(Console.ReadLine());



if ((mediaNota >= 7) && (faltas <= 10))
{
    situacaoAluno = "APROVADO";
}
else if ((mediaNota < 7) && (faltas <= 10))
{
    situacaoAluno = "REPROVADO";
}


else if (faltas > 10)
{
    situacaoAluno = "Reprovado por FALTA";
}



Console.WriteLine($"Sua media e {mediaNota} e voce esta: {situacaoAluno}");

Console.ReadKey();




