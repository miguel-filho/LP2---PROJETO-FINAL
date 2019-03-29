using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class PedidosController : ControllerBase<Pedido>
    {
        public PedidosController(DataContext context) : base(context)
        {
        }
    }
}