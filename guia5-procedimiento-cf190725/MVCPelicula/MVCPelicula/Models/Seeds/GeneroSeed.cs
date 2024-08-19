using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MVCPelicula.Models.Seeds
{
    public class GeneroSeed: IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder) {

            builder.HasData(
                new Genero { Id = 1, Name = "Comedia" },
                new Genero { Id = 2, Name = "Romance" },
                new Genero { Id = 3, Name = "Aventura" },
                new Genero { Id = 4, Name = "Accion" },
                new Genero { Id = 5, Name = "Ficcion" },
                new Genero { Id = 6, Name = "Drama" });
                
                
        }


    }

    
}
