namespace WebApiExemplosPOOESW.Model
{
    public class itemVenda
    {
        private int produtoId;
        private int vendaId;
        private int quantidadeProduto;
        private double precoUnitario;

        public int ProdutoId { get => produtoId; set => produtoId = value; }
        public int VendaId { get => vendaId; set => vendaId = value; }
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }

        public void InserirItem()
        {
            //Inserir item
        }

        public void ExcluirItem()
        {
            //excluir item
        }
    }
}
