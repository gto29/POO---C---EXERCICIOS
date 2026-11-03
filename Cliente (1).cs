namespace WebApiExemplosPOOESW.Model
{
    public class Cliente
    {
        private int id;
        private string nome;
        private int cpf;
        private int telefone;
        private string endereco;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }


        public void Adicionar()
        {
            //adicionar
        }
        public void Excluir(int id)
        {
            //Excluir
        }
        public void Alterar(int id)
        {
            //alterar
        }
        public void PesquisarPorId(int id)
        {
            //PEsquisar id
        }
        public void ListarTodos()
        {
            //Listar
        }
        public void PesquisarPorNome(int id)
        {
            //Pesquisar
        }
    }
}