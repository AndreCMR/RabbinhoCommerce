using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public class AdicionarItemCarrinho : IAdicionarItemCarrinho
    {

        IObterCarrinho _obterCarrinho;

        private const string SessionKey = "Carrinho";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdicionarItemCarrinho(IObterCarrinho obterCarrinho, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _obterCarrinho = obterCarrinho;

        }
        public void Execute(Produto produto, int quantidade)
        {
            var carrinho = _obterCarrinho.Execute();

            var item =  carrinho.Itens.FirstOrDefault(i => i.ProdutoCarrinho.Id == produto.Id);
            if (item == null)
            {
                item = new ItemCarrinho
                {
                    ProdutoCarrinho = produto,
                    Quantidade = quantidade,
                    PrecoUnitario = produto.Preco
                };
                carrinho.Total = quantidade * produto.Preco;
                carrinho.Itens.Add(item);
            }
            else
            {
                item.Quantidade += quantidade;
            }

            SalvarCarrinho(carrinho);

        }


        private void SalvarCarrinho(Carrinho carrinho)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var carrinhoJson = JsonConvert.SerializeObject(carrinho);
            session.SetString(SessionKey, carrinhoJson);
        }


    }
}
