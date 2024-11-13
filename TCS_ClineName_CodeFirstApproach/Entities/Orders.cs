using System.ComponentModel.DataAnnotations;

namespace TCS_ClineName_CodeFirstApproach.Entities
{
    public class Orders
    {
        [Key]
        public int orderid { get; set; }
        public string ordername { get; set; }
        public string orderlocation { get; set; }
        public int orderamount { get;set; }//new requiremnt filed/property is added.
    }
}
