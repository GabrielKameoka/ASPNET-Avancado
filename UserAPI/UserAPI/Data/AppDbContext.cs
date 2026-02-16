using Microsoft.EntityFrameworkCore;

namespace UserAPI.Data;

public class AppDbContext : DbContext
{
    public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<Person> Persons { get; set; }
}