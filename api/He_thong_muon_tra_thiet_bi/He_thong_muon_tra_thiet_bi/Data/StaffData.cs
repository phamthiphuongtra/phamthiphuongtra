using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace He_thong_muon_tra_thiet_bi.Data
{
    [Table("Staff")]

    public class StaffData
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone {  get; set; }
        public string Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
