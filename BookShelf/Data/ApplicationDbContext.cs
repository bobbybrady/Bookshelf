using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
               .HasMany(o => o.Book)
               .WithOne(l => l.User)
               .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<ApplicationUser>()
              .HasMany(o => o.Author)
              .WithOne(l => l.User)
              .OnDelete(DeleteBehavior.Restrict);
        }
    
    }
}
