using System.Collections.Generic;

namespace Vendas.Models
{
    public class Produto
    {
        public Produto()
        {
            Detalhes = new HashSet<DetalhesPed>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<DetalhesPed> Detalhes { get; set; }
    }
}