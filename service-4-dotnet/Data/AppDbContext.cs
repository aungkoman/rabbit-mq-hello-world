using Microsoft.EntityFrameworkCore;
using service_4_dotnet.Models;

namespace service_4_dotnet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Person> Persons { get; set; }
}