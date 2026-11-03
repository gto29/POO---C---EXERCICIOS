double salario, bonificacaoEmpresa, salarioFinal;
int tempoEmpresa;
string percentualBonificacaoEmpresa;



Console.WriteLine("Digite aqui seu salario: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite aqui seu tempo de empresa: ");
tempoEmpresa = Convert.ToInt16(Console.ReadLine());



percentualBonificacaoEmpresa = (salario < 2000) && (tempoEmpresa > 10) ? "25%" :
(salario < 2000) ? "20%" :
(salario >= 2000 && salario < 5000) && (tempoEmpresa > 10) ? "15%" :
(salario >= 2000) && (salario< 5000) ? "10%" :
(salario > 5000) && (tempoEmpresa > 10) ? "10%" : "5%";




if (salario < 2000)
{

    if (tempoEmpresa > 10)
    {
        bonificacaoEmpresa = salario * 0.25;
        salario += bonificacaoEmpresa;
        
    }
    else
    {
        bonificacaoEmpresa = salario * 0.2;
        salario += bonificacaoEmpresa;
        
    }
}

else if (salario >= 2000 && salario <= 5000)
{
    if (tempoEmpresa > 10)
    {
        bonificacaoEmpresa = salario * 0.25;
        salario += bonificacaoEmpresa;
        
    }
    else
    {
        bonificacaoEmpresa = salario * 0.2;
        salario += bonificacaoEmpresa;
        
    }
}
else if (salario > 5000)
{
    bonificacaoEmpresa = salario * 0.25;
    salario += bonificacaoEmpresa;
    

}





Console.WriteLine($"A % de bonificação é: {percentualBonificacaoEmpresa} ");
Console.WriteLine($"seu salario final é: {salario} ");




Console.ReadKey();


