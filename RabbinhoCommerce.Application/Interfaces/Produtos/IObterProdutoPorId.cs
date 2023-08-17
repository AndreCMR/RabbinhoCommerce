using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface  IObterProdutoPorId
    {
        Produto Execute(int produtoId);
    }
}
