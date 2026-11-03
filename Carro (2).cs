namespace WebApiExemplosPOOESW.Model
{
    public class Carro
    {
        public string marca;

        public string modelo;

        public string placa;

        public string cor;

        public int numeroMarcha;

        public string fabricacao;

        public int anoModelo;

        public int velocidade;

        public bool ligado;

        public bool desligado;

        public string Buzinar()
        {
            return "biiiiiiiiiiiiiiiih";
        }
        public int Acelerar(int VelocidadeAcelerecao)
        {
            velocidade = velocidade + VelocidadeAcelerecao;
            return velocidade;
        }
        public string Ligar()
        {
            if(ligado == false)
            {
                ligado = true;
                ligado = false;
                return "o carro foi desligado";
            }
            else
            {
                return "o carro ja esta desligado";
            }
        }

        
    }
}
