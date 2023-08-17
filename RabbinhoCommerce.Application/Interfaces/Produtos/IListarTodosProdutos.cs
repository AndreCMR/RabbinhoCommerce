using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IListarTodosProdutos
    {
         Task<List<Produto>> Execute();

    }
}
