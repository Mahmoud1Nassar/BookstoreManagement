using BookstoreManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
