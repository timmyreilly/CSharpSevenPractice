using System.ComponentModel.DataAnnotations;

namespace WebAppOne.Models
{
    public class Song
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Artist { get; set; }

        [Required]
        public string Album { get; set; }

        // [Required]
        // public string Genre { get; set; }

    }
}