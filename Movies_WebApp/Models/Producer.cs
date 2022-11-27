using System.ComponentModel.DataAnnotations;

namespace Movies_WebApp.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }

        [Display(Name = "Profile Image")]
        public string ProfileImageURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //relationships
        public List<Movie> Movies { get; set; }
    }
}
