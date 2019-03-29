namespace Vendas.Models
{
    public class DetalhesPed
    {
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}