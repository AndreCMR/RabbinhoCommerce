using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Application
{
    public class ValidarCheckout : IValidarCheckout
    {
        public string Execute(CheckoutRequest request)
        {
            string retorno = "";
            // Valide as informações fornecidas pelo cliente
            if (string.IsNullOrEmpty(request.Nome))
            {
                retorno = "O nome é obrigatório";
                return retorno;
            }
            if (string.IsNullOrEmpty(request.Endereco))
            {
                retorno = "O endereço é obrigatório";
                return retorno;
            }
            

            return retorno;

        }
    }
}
