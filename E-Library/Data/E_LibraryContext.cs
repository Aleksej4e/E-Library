using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Library.Models;

namespace E_Library.Data
{
    public class E_LibraryContext : DbContext
    {
        public E_LibraryContext (DbContextOptions<E_LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<E_Library.Models.Book> Book { get; set; } = default!;

        public DbSet<E_Library.Models.Author>? Author { get; set; }

        public DbSet<E_Library.Models.Genre>? Genre { get; set; }

        public DbSet<E_Library.Models.Review>? Review { get; set; }
    }
}
