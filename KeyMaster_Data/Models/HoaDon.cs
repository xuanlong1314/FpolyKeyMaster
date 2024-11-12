using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyMaster_Data.Models;
namespace KeyMaster_Data.Models
{
    public class HoaDon
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        public Guid IdNguoiDung { get; set; }
        [ForeignKey("IdNguoiDung")]
        public Guid IdPhuongThucThanhToan { get; set; }
        [ForeignKey("IdPhuongThucThanhToan")]
        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        [NotMapped]
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayVanChuyen { get; set; }
        public DateTime? NgayGiaoHangDuKien { get; set; }
        public DateTime? NgayNhanHang { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PhiVanChuyen { get; set; }
        public string? GhiChu { get; set; }

        public Guid? IdDiaChi { get; set; }
        [ForeignKey("IdDiaChi")]
        public Guid? IdPhieuGiamGia { get; set; }
        [ForeignKey("IdPhieuGiamGia")]
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual PhuongThucThanhToan PhuongThucThanhToan { get; set; }
        public virtual DiaChi DiaChi { get; set; }
        public virtual PhieuGiamGia PhieuGiamGia { get; set; }

        public virtual ICollection<LichSuHoaDon> LichSuHoaDons { get; set; }
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }
}