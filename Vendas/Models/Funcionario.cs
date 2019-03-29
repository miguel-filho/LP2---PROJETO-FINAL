using System;
using System.Collections.Generic;

namespace Vendas.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Pedidos = new HashSet<Pedido>();
              
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cargo { get; set; }
        public string Fone { get; set; }
        public DateTime DataNasc { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}