using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IObterItensCarrinho
    {
        IEnumerable<ItemCarrinho> Execute();
    }
}
