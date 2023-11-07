namespace LexiconIMDB.Models.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public float Rating { get; set; }
    }
}
