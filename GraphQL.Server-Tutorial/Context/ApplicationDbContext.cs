using GraphQL.Server_Tutorial.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Server_Tutorial.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
