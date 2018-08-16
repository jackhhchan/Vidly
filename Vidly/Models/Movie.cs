using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(100)]
        public string Name { get; set; }

        public byte GenresId { get; set; }
        public Genres Genre { get; set; }

        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? NumberInStock { get; set; }
    }
}