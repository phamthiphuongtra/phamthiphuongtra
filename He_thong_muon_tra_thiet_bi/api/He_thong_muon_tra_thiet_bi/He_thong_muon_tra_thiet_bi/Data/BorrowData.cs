using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace He_thong_muon_tra_thiet_bi.Data
{
    [Table("BorrowEquipment")]
    public class BorrowData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Phone { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ConfirmBorrowed {  get; set; }
        public string ReturnConfirm {  get; set; }
        public string Pen { get; set; }
        public string Chalk { get; set; }
        public string Projector { get; set;}
        public string Connector { get; set; }
        public string Mic { get; set; }
        public string PowerOutlet { get; set;}
        public string BottledWater { get; set;}
        public string Status { get; set; }
        public string StudentCode { get; set; }
        public string Wipes { get; set; }
        public string Room { get; set; }
    }
}
