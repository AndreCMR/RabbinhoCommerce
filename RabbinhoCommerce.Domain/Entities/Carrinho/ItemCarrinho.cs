namespace RabbinhoCommerce.Domain.Entities
{
    public class ItemCarrinho
    {
        public Produto ProdutoCarrinho { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
