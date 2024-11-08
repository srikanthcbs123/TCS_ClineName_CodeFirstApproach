using System.ComponentModel.DataAnnotations;

namespace TCS_ClineName_CodeFirstApproach
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public int empsalary { get; set; }
    }
}
