using System.Collections.Generic;
using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("DefaultConnection") { }

    public DbSet<Employee> Employees { get; set; }
}
