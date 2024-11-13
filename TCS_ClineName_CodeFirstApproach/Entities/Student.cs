using System.ComponentModel.DataAnnotations;

namespace TCS_ClineName_CodeFirstApproach.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLocation {  get; set; }
    }
}
