using Microsoft.AspNetCore.Mvc;
using RabbinhoCommerce.Application;
using RabbinhoCommerce.Domain.Entities;
using RabbitLib;

[Route("api/[controller]")]
[ApiController]
public class CarrinhosController : ControllerBase
{
    private readonly ILogger<CarrinhosController> _logger;
    private readonly IConfiguration _configuration;

    public CarrinhosController(ILogger<CarrinhosController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    
    public IActionResult Get([FromServices] IObterItensCarrinho service)
    {
       var carrinho = service.Execute();

        return Ok(carrinho);

    }

    [HttpPost("{produtoId}/{quantidade}")]
    public IActionResult Post([FromServices] IObterProdutoPorId serviceProduto, [FromServices] IAdicionarItemCarrinho service, int produtoId, int quantidade)
    {
        var produto = serviceProduto.Execute(produtoId);

        service.Execute(produto, quantidade);

        return Ok();
    }

    [HttpPost("checkout")]
    public IActionResult Checkout([FromBody] CheckoutRequest request, IObterItensCarrinho service, IAdicionarPedido servicePedido, IValidarCheckout serviceValidarCheckout)
    {
        // Valide as informações fornecidas pelo cliente
        var retornoValidacao = serviceValidarCheckout.Execute(request);
        if (retornoValidacao != "")
        {
            return BadRequest(retornoValidacao);
        }
        
        // ...
        var carrinho = service.Execute();

        // Calcule o total do pedido
        decimal total = 0;
        foreach (var item in carrinho)
        {
            total += item.ProdutoCarrinho.Preco * item.Quantidade;
        }

        var pedido = new Pedido
        {
            Data = request.Data,
            Total = total,
            Status = request.Status
        };

        servicePedido.Execute(pedido);

        ///// Treco de código abaixo simula a chamada da camada de serviço
        var _rabbitConfig = _configuration.GetSection("RabbitConfig").Get<RabbitConfig>();
        var _rabbitManager = new RabbitManager(_rabbitConfig);
        var channel = _rabbitManager.CreateChannel(_rabbitConfig.Queue);
        var sucesso = _rabbitManager.NewMessage(channel, _rabbitConfig.Queue, $"Pedido {Guid.NewGuid()}");
        /////

        if (sucesso)
            return Created("ok", new { Mensagem = "Enviado para pagamento" });

        return BadRequest(new { Mensagem = "Pedido recusado" });
    }

    [HttpDelete("{produtoId}")]
    public IActionResult Delete([FromServices] IRemoverItemCarrinho service,int produtoId)
    {
        service.Execute(produtoId);

        return Ok();
    }


}