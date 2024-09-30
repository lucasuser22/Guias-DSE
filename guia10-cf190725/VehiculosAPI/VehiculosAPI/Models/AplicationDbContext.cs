using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VehiculosAPI.Models
{
    public class AplicationDbContext : IdentityDbContext<Usuario>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Marca> Marca { get; set; }

        public DbSet<Modelo> Modelo { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set; }

        public DbSet<Usuario> Usuario { get; set; }


    }
}
