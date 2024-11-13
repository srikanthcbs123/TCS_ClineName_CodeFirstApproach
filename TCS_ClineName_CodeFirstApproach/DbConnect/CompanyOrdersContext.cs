using Microsoft.EntityFrameworkCore;
using TCS_ClineName_CodeFirstApproach.Entities;
namespace TCS_ClineName_CodeFirstApproach.DbConnect
{
    public class CompanyOrdersContext:DbContext
    {
        public CompanyOrdersContext(DbContextOptions<CompanyOrdersContext> options)
       : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Student> students { get; set; }
    }
}
