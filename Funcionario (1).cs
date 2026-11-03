namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {

        public string nome;

        public int idade;

        public string sexo;

        public double salario;

        public double CalcularDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro = (salario * mesesTrabalhados) / 12;

            return Math.Round (decimoTerceiro,2);
        }
        public double CalcularFerias()
        {
            double ferias = (salario+salario)/3;
            return Math.Round (ferias,2);
        }

    }
}
