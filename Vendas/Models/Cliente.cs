using System.Collections.Generic;

namespace Vendas.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}