using Microsoft.EntityFrameworkCore;
namespace TCS_ClineName_CodeFirstApproach.DbConnect
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
       : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
    }
}
