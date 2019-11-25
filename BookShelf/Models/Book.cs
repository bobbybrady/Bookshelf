using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public int ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
