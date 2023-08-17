using Microsoft.AspNetCore.Mvc;
using RabbinhoCommerce.Application;
using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
      
   

        [HttpGet("produtos")]
        public async Task<ActionResult<List<Produto>>> Get([FromServices] IListarTodosProdutos service)
        {
            var produto = await service.Execute();

            return Ok(produto);
        }
    }
}