namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {
        private int id;

        private string nome;

        private string cpf;

        private string email;

        private string cargo;

        private double salario;

        private DateTime dataAdmissao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }

        public void Adicionar()
        {
            //Adicionar valores ao bando de dados
        }

        public void Excluir(int id)
        {
            //Adicionar valores ao bando de dados
        }

        public void Alterar(int id)
        {
            //Adicionar valores ao bando de dados
        }

        public string PesquisarPorId(int id)
        {
            return "Dados do Funcionário";
        }
        public string PesquisarPorNome(int id)
        {
            return "Dados do funcionario";
        }

        public string ListarTodos()
        {
            return "dados do funcionário";
        }
    }
}
