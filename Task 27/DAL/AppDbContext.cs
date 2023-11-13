using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("DESKTOP-GOU1KUJ\\MSSQLSERVER01;Database=MusicApp;Trusted_Connection=true;integrated security=true;encrypt=false;""");
    }
}
