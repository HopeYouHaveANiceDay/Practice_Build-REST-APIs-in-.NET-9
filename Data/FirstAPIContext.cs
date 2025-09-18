using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

/*FirstAPIContext 類別繼承自 DbContext。
DbContext 提供許多屬性與方法，讓我們可以查詢、儲存、更新資料庫中的資料。 */

namespace WebApplication1.Data {
    public class FirstAPIContext : DbContext {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options) : base(options)
        {   
        }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(

                new Book

                {
                    Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    YearPublished = 2001
                },

                new Book
                {
                    Id = 2,
                    Title = "Book 2",
                    Author = "Author 2",
                    YearPublished = 2002
                },


                new Book
                {
                    Id = 3,
                    Title = "Book 3",
                    Author = "Author 3",
                    YearPublished = 2003
                },

                new Book
                {
                    Id = 4,
                    Title = "Book 4",
                    Author = "Author 4",
                    YearPublished = 2004
                },

                new Book
                {
                    Id = 5,
                    Title = "Book 5",
                    Author = "Author 5",
                    YearPublished = 2005
                }
            );
        }
        
        public DbSet<Book> Books { get; set; }
    }
}