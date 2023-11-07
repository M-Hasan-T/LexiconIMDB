using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LexiconIMDB.Models.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public float Rating { get; set; }
    }
}
