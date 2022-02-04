using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookStore.API.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
    }
}
