using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUD_MVC.Helper;

public class SchoolDbContext : DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
}
