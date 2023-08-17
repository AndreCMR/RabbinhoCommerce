using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Infra
{
    public interface  IProdutoRepository
    {
        Task<List<Produto>> ObterProdutos();

        Produto ObterProdutoPorId(int produtoId);
    }
}
