using RabbinhoCommerce.Application;
using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public class ObterItensCarrinho : IObterItensCarrinho
    {
        private const string SessionKey = "Carrinho";
        private readonly IHttpContextAccessor _httpContextAccessor;
        IObterCarrinho _obterCarrinho;


        public ObterItensCarrinho(IObterCarrinho obterCarrinho,IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _obterCarrinho = obterCarrinho;
        }

        public IEnumerable<ItemCarrinho> Execute()
        {
            var carrinho = _obterCarrinho.Execute();
            return carrinho.Itens;
        }
    }
}
