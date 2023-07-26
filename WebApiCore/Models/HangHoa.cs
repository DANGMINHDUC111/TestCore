using System;

namespace WebApiCore.Models
{
    public class HangHoaVM
    {
        public string? TenHangHoa { get; set; }
        public double DonGia { get; set; }
    }

    public class HangHoa: HangHoaVM
    {
        public int MaHangHoa { get; set; }
    }
}
