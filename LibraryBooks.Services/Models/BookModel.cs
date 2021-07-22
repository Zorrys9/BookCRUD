using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Models
{
    public class BookModel
    {

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int CountPages { get; set; }

        public int CountBooks { get; set; }

        public int Year { get; set; }



        public static implicit operator BookModel(BookEntityModel model)
        {
            if (model != null)
            {

                return new BookModel
                {

                    Id = model.Id,
                    Title = model.Title,
                    Author = model.Author,
                    Description = model.Description,
                    CountBooks = model.CountBooks,
                    CountPages = model.CountPages,
                    Year = model.Year

                };

            }
            else
            {
                return model;
            }
        }

        public static implicit operator BookEntityModel(BookModel model)
        {
            if (model != null)
            {

                return new BookEntityModel
                {

                    Id = model.Id,
                    Title = model.Title,
                    Author = model.Author,
                    Description = model.Description,
                    CountBooks = model.CountBooks,
                    CountPages = model.CountPages,
                    Year = model.Year

                };

            }
            else
            {
                return model;
            }
        }

        public static implicit operator BookModel(BookViewModel model)
        {
            if (model != null)
            {

                return new BookModel
                {

                    Id = model.Id,
                    Title = model.Title,
                    Author = model.Author,
                    Description = model.Description,
                    CountBooks = model.CountBooks,
                    CountPages = model.CountPages,
                    Year = model.Year

                };

            }
            else
            {
                return model;
            }
        }

        public static implicit operator BookViewModel(BookModel model)
        {
            if (model != null)
            {

                return new BookViewModel
                {

                    Id = model.Id,
                    Title = model.Title,
                    Author = model.Author,
                    Description = model.Description,
                    CountBooks = model.CountBooks,
                    CountPages = model.CountPages,
                    Year = model.Year

                };

            }
            else
            {
                return model;
            }
        }



    }
}
