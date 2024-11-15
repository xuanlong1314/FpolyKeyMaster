using KeyMaster_Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_API.Data
{
    public class AppDBcontexts : DbContext
    {
        public AppDBcontexts(DbContextOptions<AppDBcontexts> options) 
            : base(options)
        {
        }

        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<KeyCap> KeyCaps { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<KieuGiamGia> KieuGiamGias { get; set; }
        public DbSet<Led> Leds { get; set; }
        public DbSet<LichSuHoaDon> LichSuHoaDons { get; set; }
        public DbSet<LoaiKN> LoaiKNs { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<Mau> Maus { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<PhieuGiamGia> PhieuGiamGias { get; set; }
        public DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamCT> SanPhamCTs { get; set; }
        public DbSet<SanPhamKM> SanPhamKMs { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<HinhAnh> HinhAnhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=LONG;Initial Catalog=FpolyKeyMasters;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
