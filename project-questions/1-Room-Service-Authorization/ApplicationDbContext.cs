public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasData(
            new Room { Id = 1, Name = "1A", Floor = 1 },
            new Room { Id = 2, Name = "2B", Floor = 2 }
        );
    }

    public DbSet<Room> Rooms { get; set; }
}
