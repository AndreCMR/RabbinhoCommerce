using System;

namespace RabbinhoCommerce.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public decimal Total { get; set; }

        public string Status { get; set; }
    }
}
