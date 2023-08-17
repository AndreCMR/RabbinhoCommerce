using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IAdicionarItemCarrinho
    {
        void Execute(Produto produto, int quantidade);

    }
}
