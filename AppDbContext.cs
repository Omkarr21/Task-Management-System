public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Task> Tasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Document> Documents { get; set; }
}
