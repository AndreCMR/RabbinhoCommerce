using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IRemoverItemCarrinho
    {
        void Execute(int produtoId);
    }
}
