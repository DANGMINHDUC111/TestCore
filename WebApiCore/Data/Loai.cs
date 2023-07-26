using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCore.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        public string? TenLoai { get; set; }
        public virtual ICollection<HangHoa>? HangHoas { get; set;}
    }
}
