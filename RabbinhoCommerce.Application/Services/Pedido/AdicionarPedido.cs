using RabbinhoCommerce.Domain.Entities;
using RabbinhoCommerce.Infra.DataContext;

namespace RabbinhoCommerce.Application


{
    public class AdicionarPedido : IAdicionarPedido
    {
        private readonly RabbinhoCommerceContext _context;

        public AdicionarPedido(RabbinhoCommerceContext context)
        {
            _context = context;
        }
        public void Execute(Pedido pedido)
        {

            _context.Add(pedido);
        }
    }
}
