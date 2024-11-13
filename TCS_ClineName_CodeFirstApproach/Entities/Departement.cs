using System.ComponentModel.DataAnnotations;

namespace TCS_ClineName_CodeFirstApproach
{
    public class Departement
    {
        //if you apply [key]  attrbute to id property in entity classes it will automatically apply the primary key for id column and identity also applied automatically
        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
        public string deptlocation { get; set; }
    }
}
