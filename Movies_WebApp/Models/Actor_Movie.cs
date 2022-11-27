namespace Movies_WebApp.Models
{
    public class Actor_Movie //create a reference to many-to-many relationships
    {
        public int MovieID { get; set; }//foreign key
        public Movie Movie { get; set; }//one-to-many
        public int ActorID { get; set; }//foreign key
        public Actor Actor { get; set; }//one-to-many

    }
}
