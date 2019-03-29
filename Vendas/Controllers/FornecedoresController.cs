using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class FornecedoresController : ControllerBase<Fornecedor>
    {
        public FornecedoresController(DataContext context) : base(context)
        {
        }
    }
}