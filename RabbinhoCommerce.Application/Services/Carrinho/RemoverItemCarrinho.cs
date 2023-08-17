using Microsoft.AspNetCore.Http;
using RabbinhoCommerce.Domain.Entities;
namespace RabbinhoCommerce.Application
{
    public class RemoverItemCarrinho : IRemoverItemCarrinho
    {

        private const string SessionKey = "Carrinho";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RemoverItemCarrinho(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void Execute(int produtoId)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.Remove(SessionKey);
        }
    }
}
