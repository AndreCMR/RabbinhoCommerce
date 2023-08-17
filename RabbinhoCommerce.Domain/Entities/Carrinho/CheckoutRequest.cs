namespace RabbinhoCommerce.Domain.Entities
{
    public class CheckoutRequest
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string NumeroCartaoCredito { get; set; }
        public string DataValidade { get; set; }
        public string CodigoSeguranca { get; set; }

        public DateTime Data { get; set; }

        public decimal Total { get; set; }

        public string Status { get; set; }
    }
}
