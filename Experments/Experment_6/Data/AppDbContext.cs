using Experment_6.Models;
using Microsoft.EntityFrameworkCore;

namespace Experment_6.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
}
