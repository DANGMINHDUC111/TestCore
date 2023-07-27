using Microsoft.EntityFrameworkCore;

namespace WebApiCore.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region dbset
        public DbSet<HangHoa> HangHoa { get; set;}
        public DbSet<Loai> Loai { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiet { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(x =>
            {
                x.ToTable("DonHang");
                x.HasKey(dh => dh.MaDonHang);
                x.Property(dh=> dh.NgayDatHang).HasDefaultValue(DateTime.UtcNow);
            });

            modelBuilder.Entity<DonHangChiTiet>(x =>
            {
                x.ToTable("DonHangChiTiet");
                x.HasKey(c => new { c.MaDonHang, c.MaHangHoa });

                x.HasOne(c => c.DonHang)
                .WithMany(c => c.DonHangChiTiets)
                .HasForeignKey(c => c.MaDonHang)
                .HasConstraintName("FK_DonHangCT_DonHang");

                x.HasOne(c => c.HangHoa)
                .WithMany(c => c.DonHangChiTiets)
                .HasForeignKey(c => c.MaHangHoa)
                .HasConstraintName("FK_DonHangCT_HangHoa");
            });

            modelBuilder.Entity<NguoiDung>(x =>
            {
                x.HasIndex(c => c.UserName).IsUnique();
            });
        }
    }
}
