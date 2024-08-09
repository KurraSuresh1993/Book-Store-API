using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStoreApi.Models;

namespace BookStoreApi.Data
{
    public class BookStoreApiContext : DbContext
    {
        public BookStoreApiContext (DbContextOptions<BookStoreApiContext> options)
            : base(options)
        {
        }

        public DbSet<BookStoreApi.Models.BookModel> BookModel { get; set; } = default!;
    }
}
