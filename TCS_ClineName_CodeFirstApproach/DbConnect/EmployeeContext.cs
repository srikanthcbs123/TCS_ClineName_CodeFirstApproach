using Microsoft.EntityFrameworkCore;
using TCS_ClineName_CodeFirstApproach;//by using key wd import the namespace
namespace TCS_ClineName_CodeFirstApproach.DbConnect
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
       : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Departement> departements { get; set; }
    }
}
