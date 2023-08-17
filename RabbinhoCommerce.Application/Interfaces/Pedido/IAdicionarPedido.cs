using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IAdicionarPedido
    {
        void Execute(Pedido pedido);
    }
}
