using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Movies_WebApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies_WebApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        
        public string Name { get; set; }

        
        public string Description { get; set; }

        
        public double Price { get; set; }

        
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //relationships
        public List<Actor_Movie> Actor_Movies { get; set; }  //one-to-many

        //Cinema
        public int CinemaID { get; set; }//foreign key
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }//foreign key
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }
    }
}
