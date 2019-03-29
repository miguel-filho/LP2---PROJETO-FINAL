using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class ProdutosController : ControllerBase<Produto>
    {
        public ProdutosController(DataContext context) : base(context)
        {
        }
    }
}