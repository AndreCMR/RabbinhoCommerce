using Microsoft.EntityFrameworkCore;
using RabbinhoCommerce.Domain.Entities;
using RabbinhoCommerce.Infra.DataContext;

namespace RabbinhoCommerce.Application
{
    public class ListarTodosProdutos : IListarTodosProdutos
    {

        private readonly RabbinhoCommerceContext _context;

        public ListarTodosProdutos(RabbinhoCommerceContext context)
        {
            _context = context;
        }


        public async Task<List<Produto>> Execute(){

            var produtos = await _context.Produto.ToListAsync();

            return produtos;
        }

    }
}
