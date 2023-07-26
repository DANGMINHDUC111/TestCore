using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCore.Data
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }
        [MaxLength(250)]
        public string? PassWord { get; set; }
        public string? HoTen { get; set; }
        public string? Email { get; set; }
    }
}
