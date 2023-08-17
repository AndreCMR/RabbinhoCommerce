using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public class ObterCarrinho : IObterCarrinho
    {

        private const string SessionKey = "Carrinho";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ObterCarrinho(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }
        public Carrinho Execute()
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var carrinhoJson = session.GetString(SessionKey);
            if (string.IsNullOrEmpty(carrinhoJson))
            {
                return new Carrinho();
            }
            return JsonConvert.DeserializeObject<Carrinho>(carrinhoJson);
        }
    }
}
