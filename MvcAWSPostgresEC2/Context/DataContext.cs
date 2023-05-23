using Microsoft.EntityFrameworkCore;
using MvcAWSPostgresEC2.Models;

namespace MvcAWSPostgresEC2.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>
            options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
