using System.Collections.Generic;

namespace Vendas.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}