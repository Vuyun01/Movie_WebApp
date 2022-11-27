using System.ComponentModel.DataAnnotations;


namespace Movies_WebApp.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        [Display(Name = "Profile Image")]
        [Required(ErrorMessage = "Profile Image is required")]
        public string ProfileImageURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full name must be between 3 and 50 characters")]

        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]

        public string Bio { get; set; }

        //relationships

        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
