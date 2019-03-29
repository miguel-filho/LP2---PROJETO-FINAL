using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class DetalhesController : ControllerBase<DetalhesPed>
    {
        public DetalhesController(DataContext context) : base(context)
        {
        }
    }
}