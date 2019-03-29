using Vendas.Data.Context;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class FuncionariosController : ControllerBase<Funcionario>
    {
        public FuncionariosController(DataContext context) : base(context)
        {
        }
    }
}