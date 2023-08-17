using Microsoft.EntityFrameworkCore;
using RabbinhoCommerce.Domain.Entities;

namespace RabbinhoCommerce.Infra.DataContext
{
    public class RabbinhoCommerceContext : DbContext
    {  

        public RabbinhoCommerceContext(DbContextOptions options) : base(options)
        {
            //
        }
      
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(string)))
            {
                property.SetMaxLength(250);
            }
        }

    
    }
}
