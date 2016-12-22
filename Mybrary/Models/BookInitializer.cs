using Mybrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mybrary.Models
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<MybraryEntities>
    {
        protected override void Seed(MybraryEntities context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"  
            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/79/To_Kill_a_Mockingbird.JPG/220px-To_Kill_a_Mockingbird.JPG",
                    Isbn = "1238937289",
                    Synopsis = "...",
                    Title = "To Kill a Mocking Bird"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4e/US_cover_of_Go_Set_a_Watchman.jpg",
                    Isbn = "1238937289",
                    Synopsis = "...",
                    Title = "Go Set a Watchman"
                }
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}