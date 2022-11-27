using System.ComponentModel.DataAnnotations;

namespace Movies_WebApp.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //relationships

        public List<Movie> Movies { get; set; }
    }
}
