namespace WebApiExemplosPOOESW.Model
{
    public class ContaBancaria
    {
        private int numero;

        private string titular;

        private double saldo = 1000;

        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; private set => saldo = value; }

        public string RetornarDadosConta()
        {
            return $"Dados da Conta Bancária\r\n" +
                $"Número da Conta: {Numero}\r\n" +
                $"Titular da Conta: {Titular}\r\n" +
                $"Saldo da conta:R${Saldo}";
        }
        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

            public void Sacar(double valorSaque)
        {
            Saldo -= valorSaque;
        }

    }
}
