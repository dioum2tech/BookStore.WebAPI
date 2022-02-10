using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookStore.API.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Book { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
    }
}
