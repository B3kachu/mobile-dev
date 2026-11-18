using Microsoft.EntityFrameworkCore;

namespace AvaloniaHomework.Data;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Coach> Coaches => Set<Coach>();
    public DbSet<Session> Sessions => Set<Session>();

    public static string DbPath
    {
        get
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            Directory.CreateDirectory(folder);
            return Path.Combine(folder, "plantacademy.db");
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}