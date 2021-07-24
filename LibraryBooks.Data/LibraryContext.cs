using LibraryBooks.Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data
{
    public class LibraryContext : IdentityDbContext
    {

        public DbSet<BookEntityModel> Books { get; set; }

        public DbSet<TakeBooksEnityModel> TakeBooks { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

            Database.EnsureCreated();











            if(!Roles.Any())
            {

                Roles.AddRange(

                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Name = "Client", NormalizedName = "CLIENT" });

            }


            if(!Books.Any())
            {

                Books.AddRange(

                    new BookEntityModel { Title = "Book1", Author = "Author1", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book2", Author = "Author2", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book3", Author = "Author3", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book4", Author = "Author4", Description = "Typa opisanie =)", Year = 2000, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book5", Author = "Author5", Description = "Typa opisanie =)", Year = 2000, CountPages = 135, CountBooks = 16 },
                    new BookEntityModel { Title = "Book6", Author = "Author6", Description = "Typa opisanie =)", Year = 2020, CountPages = 10, CountBooks = 11 },
                    new BookEntityModel { Title = "Book7", Author = "Author7", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book8", Author = "Author8", Description = "Typa opisanie =)", Year = 2021, CountPages = 174, CountBooks = 0 },
                    new BookEntityModel { Title = "Book9", Author = "Author9", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book10", Author = "Auhor10", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Bk11", Author = "Athr11", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book12", Author = "Author12", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Bok13", Author = "Author13", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book14", Author = "Author14", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 11 },
                    new BookEntityModel { Title = "Book15", Author = "Author15", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 0 },
                    new BookEntityModel { Title = "Book16", Author = "Author16", Description = "Typa opisanie =)", Year = 1991, CountPages = 135, CountBooks = 31 },
                    new BookEntityModel { Title = "Book17", Author = "Auhor17", Description = "Typa opisanie =)", Year = 2021, CountPages = 135, CountBooks = 15 },
                    new BookEntityModel { Title = "Book18", Author = "Author18", Description = "Typa opisanie =)", Year = 2021, CountPages = 600, CountBooks = 1 },
                    new BookEntityModel { Title = "Bok19", Author = "Author19", Description = "Typa opisanie =)", Year = 2021, CountPages = 994, CountBooks = 2 },
                    new BookEntityModel { Title = "Book20", Author = "Author20", Description = "Typa opisanie =)", Year = 2021, CountPages = 165, CountBooks = 0 }

                    ) ;


            }

        }


    }
}
