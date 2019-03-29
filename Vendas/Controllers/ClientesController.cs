using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class ClientesController : ControllerBase<Cliente>
    {
        public ClientesController(DataContext context) : base(context)
        {
        }
    }
}