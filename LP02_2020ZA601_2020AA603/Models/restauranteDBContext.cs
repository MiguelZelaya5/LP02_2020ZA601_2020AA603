using Microsoft.EntityFrameworkCore;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class restauranteDBContext:DbContext
    {
        public restauranteDBContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<pedidos>? pedidos { get; set; }
        public DbSet<platos>? platos { get; set; }

        public DbSet<motoristas>? motoristas { get; set; }
        public DbSet<clientes>? clientes { get; set; }
    }
}
