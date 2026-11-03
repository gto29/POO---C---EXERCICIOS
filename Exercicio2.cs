string classificacaoIdade="", situacaoVoto = "";
int idade;

Console.WriteLine("Digite aqui sua idade: ");
    idade = Convert.ToInt16(Console.ReadLine());
if ((idade > 0) && (idade < 13))
{
    classificacaoIdade = "FAIXA ETARIA--CRIANÇA--";
    situacaoVoto = "Não obrigatório o voto";


}
else if ((idade >= 13) && (idade <= 17))
{
    classificacaoIdade = "adolescente";
    if ((idade >= 16) && (idade <= 17))
    { 
    situacaoVoto = "Voto OPCIONAL";
}
    else
    {
        situacaoVoto = "Voto proibido";

    }
}
else if ((idade > 17) && (idade <= 59))
{
    classificacaoIdade = "Adulto";
    situacaoVoto = "Voto obrigatório";
}
else
{
    classificacaoIdade = "idoso";
    situacaoVoto = "Voto opcional";
}
Console.WriteLine($"A idade da pessoa é: {idade} ");
Console.WriteLine(classificacaoIdade);
Console.WriteLine($"situação do voto: {situacaoVoto} ");