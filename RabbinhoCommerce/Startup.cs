using Microsoft.EntityFrameworkCore;
using RabbinhoCommerce.Application.cfg;
using RabbinhoCommerce.Infra.DataContext;

namespace RabbinhoCommerce
{
    public class Startup
    {

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services, IApplicationBuilder app, IWebHostEnvironment env)
        {
            services.AddDbContext<RabbinhoCommerceContext>(options =>
            {
                options.EnableSensitiveDataLogging();
                options.UseSqlServer(_configuration.GetConnectionString("RabbinhoCommerce"));
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            services.AddSession();


        }
        public static void Main(string[] args)
       => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(
                    webBuilder => webBuilder.UseStartup<Startup>());

     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

        }




    }  
    
}

