using System.ComponentModel.DataAnnotations;

namespace WebApiCore.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }
        [MaxLength(250)]
        public string? PassWord { get; set; }
    }
}
