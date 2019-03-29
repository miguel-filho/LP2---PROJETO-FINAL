using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vendas.Data.Context;
using Vendas.Repositories;

namespace Vendas.Controllers
{
    [Route("api/[controller]/")]
    public abstract class ControllerBase<T> : Controller where T : class
    {
        public RepositoryBase<T> _repository;
        public ControllerBase(DataContext context)
        {
            _repository = new RepositoryBase<T>(context);
        }
        [HttpGet]
        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _repository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
        /* CREATE */
        [HttpPost]
        public IActionResult Create([FromBody]T entity)
        {
            if (entity == null)
            {
                return BadRequest("Objeto não pode ser null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_repository.Create(entity));

        }
        /* UPDATE */
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            _repository.Update(entity, id);
            return NoContent();
        }
        /* DELETE */
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _repository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _repository.Delete(id);
            return Ok();
        }
    }
}