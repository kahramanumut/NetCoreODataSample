using Microsoft.EntityFrameworkCore;

public class LibraryDbContext:DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
    {
        
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
}