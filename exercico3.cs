int idade;
string senhaAcesso = "";
string senhaUsuario;
string permissaoAcesso = "";

Console.WriteLine("Digite aqui sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite aqui sua senha: ");
senhaUsuario = Console.ReadLine();

Console.WriteLine("Digite aqui se sua conta ta ativa sim ou nao ");



if ((idade >=18)&&(senhaAcesso == "guto2909")&&(permissaoAcesso=="sim")) 
{
    permissaoAcesso = "Acesso permitido";
}
else
{
    permissaoAcesso = "Acesso negado";
}

Console.WriteLine($"Sua idade é: {idade} ");
Console.WriteLine(permissaoAcesso);
