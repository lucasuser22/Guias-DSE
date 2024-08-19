namespace MVCPelicula.Models
{
    public class Genero
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Propiedad de navegacion
        public ICollection<Pelicula> Peliculas { get; set; }

    }
}
