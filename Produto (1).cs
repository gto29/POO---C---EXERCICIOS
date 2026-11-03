using System.Reflection;

namespace WebApiExemplosPOOESW.Model
{
    public class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private int unidadeMedida;
        private double precoUnitario;
        private ImageFileMachine imgProduto;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public ImageFileMachine ImgProduto { get => imgProduto; set => imgProduto = value; }

        public void Adicionar()
        {
            //Adicionar
        }

        public void Excluir(int id)
        {
            //Excluir
        }

        public void Alterar(int id)
        {
            //alterar
        }

        public void PesquisarProdutoPorId(int id)
        {
            //Pesquisar produto id
        }

        public void ListarTodosProdutos()
        {
            //Listar produtos
        }
    }
}
