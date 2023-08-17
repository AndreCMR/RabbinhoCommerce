namespace RabbinhoCommerce.Domain.Entities
{
    public class Carrinho
    {
        public List<ItemCarrinho> Itens { get; set; }
        public decimal Total { get; set; }

        public Carrinho()
        {
            Itens = new List<ItemCarrinho>();
            Total = 0;
        }

    }
}
