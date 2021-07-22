using LibraryBooks.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data
{
    public class LibraryContext : DbContext
    {

        public DbSet<BookEntityModel> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

            Database.EnsureCreated();

        }


    }
}
