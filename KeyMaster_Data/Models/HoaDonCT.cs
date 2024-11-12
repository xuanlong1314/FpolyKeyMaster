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
    public class HoaDonCT
    {
        [Key]
        public Guid IdHoaDonCT { get; set; }
        public Guid IdSanPhamCT { get; set; }
        [ForeignKey("IdSanPhamCT")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int SoLuong { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 0.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        [NotMapped]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PhiVanChuyen { get; set; }
        public Guid IdHoaDon { get; set; }
        [ForeignKey("IdHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }

}
