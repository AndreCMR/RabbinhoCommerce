using RabbinhoCommerce.Domain.Entities;
using RabbinhoCommerce.Infra;
using RabbinhoCommerce.Infra.DataContext;

namespace RabbinhoCommerce.Application
{
    public class ObterProdutoPorId : IObterProdutoPorId
    {

        private readonly RabbinhoCommerceContext _context;

        public ObterProdutoPorId(RabbinhoCommerceContext context)
        {
            _context = context;
        }

        public Produto Execute(int produtoId)
        {
            var produto = _context.Produto.FirstOrDefault(x => x.Id == produtoId);

            return produto;
        }
    }
}
