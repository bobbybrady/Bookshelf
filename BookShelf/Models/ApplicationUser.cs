using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(25)]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(35)]
        [MinLength(1)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        public List<Book> Book { get; set; }
        public List<Author> Author { get; set; }
    }
}
