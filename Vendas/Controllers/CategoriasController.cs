using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class CategoriasController : ControllerBase<Categoria>
    {
        public CategoriasController(DataContext context) : base(context)
        {
        }
    }
}