using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public interface IValidarCheckout
    {
        string Execute(CheckoutRequest request);
    }
}
