using System;

namespace Vendas.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public int FuncionarioId { get; set; }
        public int ClienteId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
    }
}