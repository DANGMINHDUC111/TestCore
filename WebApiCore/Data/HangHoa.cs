using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCore.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHangHoa { get; set; }
        public string? TenHangHoa { get; set; }
        public string? MoTa { get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }
        public ICollection<DonHangChiTiet>? DonHangChiTiets { get; set; }

        public HangHoa()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
