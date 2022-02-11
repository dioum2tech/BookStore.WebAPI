using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book>? Books { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
    }
}
