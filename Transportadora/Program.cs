﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Transportadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(
                    (_, services) => {
                        services.AddHostedService<Worker>();
                    }).Build().Run();
        }
    }
}
