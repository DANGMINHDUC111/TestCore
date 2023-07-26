namespace WebApiCore.Data
{
    public enum TinhTrangDonHang
    {
        New = 0,
        Payment = 1,
        Complete = 2,
        Cancle = -1
    }
    public class DonHang
    {
        public Guid MaDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime? NgayGiao { get; set; }
        public TinhTrangDonHang TinhTrangDonHang { get; set; }
        public string? NguoiNhan { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }

        public ICollection<DonHangChiTiet>? DonHangChiTiets { get; set; }

        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
