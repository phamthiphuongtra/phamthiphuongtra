using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace He_thong_muon_tra_thiet_bi.Data
{
    [Table("Device")]
    public class DeviceData
    {
        [Key]
        public int ID { get; set; }
        public string PenAndWipes { get; set; }
        public string ChalkAndWipes { get; set;}
        public string Projector { get; set;}
        public string Connector { get; set;}
        public string Mic {  get; set;}
        public string PowerOutlet { get; set;}
        public string BottledWater { get; set;}
        public string Status { get; set;}
        public DateTime Time { get; set; }

    }
}
