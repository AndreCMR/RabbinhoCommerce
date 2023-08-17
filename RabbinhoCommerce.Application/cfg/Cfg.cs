using Microsoft.EntityFrameworkCore;
using RabbinhoCommerce.Infra.DataContext;

namespace RabbinhoCommerce.Application.cfg
{
    public static class Cfg
    {
        public static void AddCfgApplication(this IServiceCollection services)
        {
            services.AddScoped<IListarTodosProdutos, ListarTodosProdutos>();
            services.AddScoped<IObterProdutoPorId, ObterProdutoPorId>();


            services.AddScoped<IAdicionarItemCarrinho, AdicionarItemCarrinho>();
            services.AddScoped<IObterCarrinho, ObterCarrinho>();
            services.AddScoped<IObterItensCarrinho, ObterItensCarrinho>();
            services.AddScoped<IValidarCheckout, ValidarCheckout>();

            services.AddScoped<IRemoverItemCarrinho, RemoverItemCarrinho>();

            services.AddScoped<IAdicionarPedido, AdicionarPedido>();


            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();
        }


        public static void AddCfgDatabase(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<RabbinhoCommerceContext>(x =>
                   x.EnableSensitiveDataLogging()
                    .UseSqlServer(connectionString: Configuration.GetConnectionString("RabbinhoCommerce"), sqlServerOptionsAction: sqlOptions => sqlOptions.EnableRetryOnFailure())
               );
        }
    }
}
